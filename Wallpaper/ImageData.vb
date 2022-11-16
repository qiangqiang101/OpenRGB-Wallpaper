Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization

<Serializable>
Public Structure ImageData

    Public ReadOnly Property Instance As ImageData
        Get
            Return ReadFromBinFile()
        End Get
    End Property

    <XmlIgnore>
    Public Property FileName() As String

    Public ImagesLib As List(Of ImageLib)

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

    Public Sub SaveSilent()
        Using fs As FileStream = File.Create(FileName)
            Dim formatter As New BinaryFormatter()
            formatter.Serialize(fs, Me)
        End Using
    End Sub

    Public Function ReadFromBinFile() As ImageData
        If Not File.Exists(FileName) Then
            Return New ImageData(FileName)
        End If

        Try
            Using fs As FileStream = File.OpenRead(FileName)
                Dim formatter As New BinaryFormatter
                Dim instance = CType(formatter.Deserialize(fs), ImageData)
                Return instance
            End Using
        Catch ex As Exception
            Return New ImageData(FileName)
        End Try
    End Function

End Structure

<Serializable>
Public Structure ImageLib

    Public Image As String
    Public FileName As String

End Structure