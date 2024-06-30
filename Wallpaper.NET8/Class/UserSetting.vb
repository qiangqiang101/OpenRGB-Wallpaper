Imports System.Drawing.Drawing2D
Imports Newtonsoft.Json
Imports OpenRGB.NET

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
    Public Port As Integer
    Public AutoConnect As Boolean

    Public E131Devices As List(Of E131Device)

    Public Sub Save(filename As String, silent As Boolean)
        IO.File.WriteAllText(filename, JsonConvert.SerializeObject(Me, Formatting.Indented))
        If Not silent Then MsgBox(Translation.Localization.UserSettingsSuccessfullySaved, MsgBoxStyle.Information, Translation.Localization.Successful)
    End Sub

    Public Function Load(filename As String) As UserSetting
        Return JsonConvert.DeserializeObject(Of UserSetting)(IO.File.ReadAllText(filename))
    End Function

End Class

Public Class E131Device

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

Public Class Language

    Public Name As String = "English"
    Public ID As String = "en-US"
    Public Localization As New Localization()

    Public Function Load(filename As String) As Language
        Return JsonConvert.DeserializeObject(Of Language)(IO.File.ReadAllText(filename))
    End Function

    Public Sub Save(filename As String)
        IO.File.WriteAllText(filename, JsonConvert.SerializeObject(Me, Formatting.Indented))
    End Sub

End Class

Public Class Localization

    'Global
    Public Apply As String = "Apply"
    Public GettingDevicesInformation As String = "Getting devices information"
    Public [Error] As String = "Error"
    Public UserSettingsSuccessfullySaved As String = "User settings successfully saved."
    Public Successful As String = "Successful"

    'Main
    Public OpenRGBWallpaper2 As String = "OpenRGB Wallpaper 2"
    Public GraphicsSettings As String = "Graphics Settings"
    Public SmoothingMode As String = "Smoothing Mode"
    Public CompositingQuality As String = "Compositing Quality"
    Public InterpolationMode As String = "Interpolation Mode"
    Public PixelOffsetMode As String = "Pixel Offset Mode"
    Public LEDShape As String = "LED Shape"
    Public RoundedRectangleRadius As String = "Rounded Rectangle Radius"
    Public LEDPadding As String = "LED Padding"
    Public RefreshInterval As String = "Refresh Interval "
    Public _ms As String = " {0}ms"
    Public GeneralSettings As String = "General Settings"
    Public StartWithWindows As String = "Start With Windows"
    Public StartMinimized As String = "Start Minimized"
    Public RestoreWallpaperWhenExit As String = "Restore Wallpaper When Exit"
    Public DisableNotifications As String = "Disable Notifications"
    Public PauseWhenCPUUsageReaches As String = "Pause When CPU Usage Reaches "
    Public _pct As String = " {0}%"
    Public CPUUsagePauseValue As String = "CPU Usage Pause Value"
    Public GrayscaleTrayIcon As String = "Grayscale Tray Icon"
    Public Language As String = "Language"
    Public SDKPort As String = "SDK Port"
    Public AutoConnectToSDKServer As String = "Auto Connect to SDK Server"
    Public DeviceSettings As String = "Device Settings"
    Public WallpaperDevices As String = "Wallpaper Devices"
    Public AddDevice As String = "+ Add Device"
    Public MadeWithHeartBy As String = "Made with ❤ by "
    Public SaveChanges As String = "Save Changes"
    Public Cancel As String = "Cancel"
    Public WaitingOpenRGBProcess As String = "Waiting OpenRGB process to startup, this might take several seconds."
    Public OpenRGBProcessFound As String = "OpenRGB process found, applying Wallpaper(s)."
    Public Play As String = "Play"
    Public Pause As String = "Pause"
    Public Connect As String = "Connect"
    Public Reconnect As String = "Reconnect"
    Public Settings As String = "Settings"
    Public Help As String = "Help"
    Public [Exit] As String = "Exit"
    Public YouCanAccessSettings As String = "You can access settings by right clicking the icon."

    'Device
    Public Device As String = "Device"
    Public TheE131Device As String = "The E1.31 device"
    Public Refresh As String = "↻ Refresh"
    Public Name As String = "Name"
    Public Zone As String = "Zone"
    Public Display As String = "Display"
    Public X As String = "X"
    Public Y As String = "Y"
    Public Width As String = "Width"
    Public Height As String = "Height"
    Public CoverImage As String = "Cover Image"
    Public [Select] As String = "Select..."
    Public Clear As String = "Clear"
    Public GetWallpapers As String = "Get Wallpapers"
    Public SizeMode As String = "Size Mode"
    Public Background As String = "Background"
    Public YouHaveUnsaveChanges As String = "You have unsave changes."
    Public Remove As String = "Remove"
    Public ConfirmRemoveDevice As String = "Confirm remove device?"
    Public SelectImageFile As String = "Select image file..."

    'Wallpaper
    Public LocalOpenRGBServerUnavailable As String = "Connection attempt failed, Local OpenRGB server unavailable."
    Public OpenRGBIsntRunning As String = "Connection attempt failed, OpenRGB isn't running."
    Public AttemptingToConnectToLocalOpenRGBServer As String = "Attempting to connect to local OpenRGB server."

End Class

Public Enum LEDShape
    Rectangle
    RoundedRectangle
    Sphere
End Enum