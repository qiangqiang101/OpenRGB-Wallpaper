Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

<Serializable>
Public Structure UserSettingData

    Public ReadOnly Property Instance As UserSettingData
        Get
            Return ReadFromBinFile()
        End Get
    End Property

    Public ReadOnly Property InstanceXml As UserSettingData
        Get
            Return ReadFromFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    'Graphics
    Public SmoothingMode As Drawing2D.SmoothingMode
    Public CompositingQuality As Drawing2D.CompositingQuality
    Public InterpolationMode As Drawing2D.InterpolationMode
    Public PixelOffsetMode As Drawing2D.PixelOffsetMode
    Public LEDShape As LEDShape
    Public StartWithWindows As Boolean
    Public NoToasters As Boolean
    Public TimerIntervals As Integer
    Public BackgroundColor As String

    Public Screens As List(Of Screen)

    Public Sub New(filename As String)
        Me.FileName = filename
    End Sub

    Public Sub Save()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using

        MsgBox($"Settings successfully saved.", MsgBoxStyle.Information, "Build")
    End Sub

    Public Sub SaveXml()
        Dim ser = New XmlSerializer(GetType(UserSettingData))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()

        MsgBox($"Settings successfully saved.", MsgBoxStyle.Information, "Save")
    End Sub

    Public Sub SaveSilent()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using
    End Sub

    Public Sub SaveSilentXml()
        Dim ser = New XmlSerializer(GetType(UserSettingData))
        Dim writer As TextWriter = New StreamWriter(FileName)
        ser.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Function ReadFromFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Dim ser = New XmlSerializer(GetType(UserSettingData))
            Dim reader As TextReader = New StreamReader(FileName)
            Dim instance = CType(ser.Deserialize(reader), UserSettingData)
            reader.Close()
            Return instance
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

    Public Function ReadFromBinFile() As UserSettingData
        If Not File.Exists(FileName) Then
            Return New UserSettingData(FileName)
        End If

        Try
            Using fs As FileStream = File.OpenRead(FileName)
                Dim formatter As New BinaryFormatter
                Dim instance = CType(formatter.Deserialize(fs), UserSettingData)
                Return instance
            End Using
        Catch ex As Exception
            Return New UserSettingData(FileName)
        End Try
    End Function

End Structure

Public Structure Screen

    'SDK Client
    Public IPAddress As String
    Public Port As Integer
    Public Name As String
    Public Autoconnect As Boolean
    Public Timeout As Integer
    Public ProtocolVersion As UInteger

    'Display
    Public Position As Point
    Public Size As Size
    Public BackgroundImage As String

    'Matrix
    Public MatrixWidth As Integer
    Public MatrixHeight As Integer

End Structure

Public Enum LEDShape
    Rectangle
    RoundedRectangle
    Sphere
End Enum