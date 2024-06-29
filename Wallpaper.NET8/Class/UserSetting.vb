Imports System.Drawing.Drawing2D
Imports System.Runtime
Imports System.Text.Json.Serialization
Imports System.Xml.Serialization
Imports Newtonsoft.Json
Imports JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute

Public Class UserSetting

    'GDI Graphics
    Public SmoothingMode As SmoothingMode = SmoothingMode.AntiAlias
    Public CompositingQuality As CompositingQuality = CompositingQuality.HighSpeed
    Public InterpolationMode As InterpolationMode = InterpolationMode.Bilinear
    Public PixelOffsetMode As PixelOffsetMode = PixelOffsetMode.HighSpeed

    'Global Graphics
    Public LEDShape As LEDShape = LEDShape.Rectangle
    Public LEDPadding As Single = 0
    Public TimerIntervals As Integer = 30
    Public RoundedRectangleCornerRadius As Integer = 10

    'General
    Public StartWithWindows As Boolean = False
    Public StartMinimized As Boolean = True
    Public RestoreWallpaperWhenExit As Boolean = False
    Public NoToasters As Boolean = False
    Public AutoPause As Boolean = True
    Public CPUUsagePauseValue As Integer = 70
    Public GrayscaleTrayIcon As Boolean = False
    Public Language As String = "en-US"

    Public E131Devices As List(Of E131Device)

    Public Sub Save(filename As String, silent As Boolean)
        IO.File.WriteAllText(filename, JsonConvert.SerializeObject(Me, Formatting.Indented))
        If Not silent Then MsgBox($"Image data successfully saved.", MsgBoxStyle.Information, "Build")
    End Sub

    Public Function Load(filename As String) As UserSetting
        Return JsonConvert.DeserializeObject(Of UserSetting)(IO.File.ReadAllText(filename))
    End Function

End Class

Public Class E131Device

    'SDK Client
    Public Port As Integer
    Public AutoConnect As Boolean

    'Device
    Public Name As String
    Public Zone As String

    'Display
    Public Position As Point
    Public Size As Size
    Public BackgroundImage As String
    Public SizeMode As PictureBoxSizeMode
    Public BackgroundColor As String

End Class

Public Enum LEDShape
    Rectangle
    RoundedRectangle
    Sphere
End Enum