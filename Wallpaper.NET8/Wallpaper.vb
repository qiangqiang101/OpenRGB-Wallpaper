Imports System.ComponentModel
Imports OpenRGB.NET

Public Class Wallpaper

    Dim connectString As String = Nothing
    Dim rgbPosition As Single = 0F
    Dim StaticEffect As Boolean = False
    Dim OffColor As Drawing.Color = Drawing.Color.FromArgb(255, 0, 0, 0)

    Public oRgbClient As OpenRgbClient = Nothing
    Public IsPaused As Boolean = False
    Public WaitForOpenRGB As Boolean = False
    Public cpuUsage As New PerformanceCounter("Processor", "% Processor Time", "_Total")

    Public Property Device() As E131Device

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        DoubleBuffered = True
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim MyCreateParams As CreateParams = MyBase.CreateParams
            MyCreateParams.ExStyle = MyCreateParams.ExStyle Or &H80
            Return MyCreateParams
        End Get
    End Property

    Private Sub Wallpaper_Load(sender As Object, e As EventArgs) Handles Me.Load
        BackColor = ColorTranslator.FromHtml(Device.BackgroundColor)
        pbDiffuser.Image = Device.BackgroundImage.Base64ToImage
        pbDiffuser.SizeMode = Device.SizeMode

        If Not WaitForOpenRGB Then Connect(Device)
    End Sub

    Public Sub Connect(dev As E131Device)
        If IsOpenRGBRunning() Then
            Try
                If Not oRgbClient Is Nothing Then oRgbClient.Dispose()
                oRgbClient = New OpenRgbClient("127.0.0.1", dev.Port, dev.Name, dev.AutoConnect)
                connectString = Nothing
                tmCheckOpenRGB.Stop()
            Catch ex As Exception
                Log(ex)
                connectString &= $"{vbCrLf}[{Now.ToString("hh:mm:ss tt")}] Connection attempt failed, Local OpenRGB server unavailable."
                tmCheckOpenRGB.Start()
            End Try
        Else
            connectString &= $"{vbCrLf}[{Now.ToString("hh:mm:ss tt")}] Connection attempt failed, OpenRGB isn't running."
            tmCheckOpenRGB.Start()
        End If
    End Sub

    Public Sub Connect()
        Try
            oRgbClient.Connect()
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Public Sub Reconnect(Optional removeWaitForOpenRGB As Boolean = False)
        If removeWaitForOpenRGB Then WaitForOpenRGB = False
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If

        Try
            Connect(Device)
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

    Private Function HighCPUUsage() As Boolean
        If UserSettings.AutoPause Then Return CInt(Math.Ceiling(cpuUsage.NextValue)) >= UserSettings.CPUUsagePauseValue Else Return False
    End Function

    Private Sub tmUpdate_Tick(sender As Object, e As EventArgs) Handles tmUpdate.Tick
        If Not IsPaused AndAlso Not HighCPUUsage() Then Invalidate()
    End Sub

    Private Sub Wallpaper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oRgbClient IsNot Nothing Then If oRgbClient.Connected Then oRgbClient.Dispose()
    End Sub

    Private Sub PrepareGraphics(graphic As Graphics)
        graphic.SmoothingMode = UserSettings.SmoothingMode
        graphic.CompositingQuality = UserSettings.CompositingQuality
        graphic.InterpolationMode = UserSettings.InterpolationMode
        graphic.PixelOffsetMode = UserSettings.PixelOffsetMode
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim graphic As Graphics = e.Graphics
        PrepareGraphics(graphic)
        graphic.Clear(BackColor)

        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
                    Dim wallpaper = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = Device.Name).FirstOrDefault
                    Dim oMatrix = wallpaper.Zones.Where(Function(x) x.Name = Device.Zone).FirstOrDefault.MatrixMap

                    If oMatrix IsNot Nothing Then
                        Dim mWidth As Integer = oMatrix.Width
                        Dim mHeight As Integer = oMatrix.Height

                        Dim rectangleSize As New SizeF(Width / mWidth, Height / mHeight)

                        Dim matrix(mWidth - 1, mHeight - 1) As String
                        Dim count As Integer = 0

                        For row As Integer = 0 To matrix.GetUpperBound(1)
                            For col As Integer = 0 To matrix.GetUpperBound(0)
                                Dim rgbColor = wallpaper.Colors(count).ToColor
                                If rgbColor <> OffColor Then
                                    Using sb As New SolidBrush(rgbColor)
                                        Dim X As Single = rectangleSize.Width * col
                                        Dim Y As Single = rectangleSize.Height * row
                                        Dim W As Single = rectangleSize.Width
                                        Dim H As Single = rectangleSize.Height
                                        Dim P As Single = UserSettings.LEDPadding
                                        Dim RF As RectangleF = New RectangleF(X + P, Y + P, W - P, H - P)
                                        Dim R As Rectangle = New Rectangle(X + P, Y + P, W - P, H - P)

                                        Select Case UserSettings.LEDShape
                                            Case LEDShape.Rectangle
                                                graphic.FillRectangle(sb, RF)
                                            Case LEDShape.RoundedRectangle
                                                graphic.FillRoundedRectangle(sb, R, UserSettings.RoundedRectangleCornerRadius)
                                            Case LEDShape.Sphere
                                                graphic.FillEllipse(sb, RF)
                                        End Select
                                    End Using
                                End If

                                count += 1
                                If count >= wallpaper.Leds.Count Then count = 0
                            Next
                        Next
                    End If
                Else
                    tmCheckOpenRGB.Start()
                End If
            End If
        Catch ex As Exception
            Log(ex)
        End Try

        MyBase.OnPaint(e)
    End Sub

    Private Sub tmCheckOpenRGB_Tick(sender As Object, e As EventArgs) Handles tmCheckOpenRGB.Tick
        connectString &= $"{vbCrLf}[{Now.ToString("hh:mm:ss tt")}] Attempting to connect to local OpenRGB server."
        Connect()
    End Sub

    Private Sub pbDiffuser_Paint(sender As Object, e As PaintEventArgs) Handles pbDiffuser.Paint
        Try
            If connectString <> Nothing Then
                e.Graphics.DrawString(connectString, Font, Brushes.White, New PointF(20, 1))
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub
End Class