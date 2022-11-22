Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports OpenRGB.NET

Public Class frmWallpaper

    Dim renderString As String = Nothing
    Dim rgbPosition As Single = 0F
    Dim StaticEffect As Boolean = False

    Public oRgbClient As OpenRGBClient = Nothing
    Public IsPaused As Boolean = False
    Public BackImg As Image = Nothing
    Public ImgFit As ImageFit = ImageFit.Stretch
    Public WaitForOpenRGB As Boolean = False

    Public Property WScreen() As Screen

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private Sub frmWallpaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = ColorTranslator.FromHtml(WScreen.BackgroundColor)
        BackImg = WScreen.BackgroundImage.Base64ToImage
        ImgFit = WScreen.ImageFit
        DoubleBuffered = True
        If ImgFit = ImageFit.Fit Then BackImg = BackImg.ResizeImage(ClientRectangle.Size, True)

        If Not WaitForOpenRGB Then Connect(WScreen)
    End Sub

    Public Sub Connect(ws As Screen)
        Try
            oRgbClient = New OpenRGBClient(ws.IPAddress, ws.Port, ws.Name, ws.Autoconnect, ws.Timeout, ws.ProtocolVersion)
        Catch ex As Exception
            renderString = $"46 Connect Error: {ex.Message}"
            Log(ex)
        End Try
    End Sub

    Public Sub Connect()
        Try
            oRgbClient.Connect()
        Catch ex As Exception
            renderString = $"54 Connect Error: {ex.Message}"
            Log(ex)
        End Try
    End Sub

    Public Sub Reconnect(Optional RemoveWaitForOpenRGB As Boolean = False)
        If RemoveWaitForOpenRGB Then WaitForOpenRGB = False
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If

        Try
            Connect(WScreen)
            renderString = Nothing
        Catch ex As Exception
            renderString = $"68 Reconnect Error: {ex.Message}"
            Log(ex)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsPaused Then
            Invalidate()

            If UserSettings.StaticEffect AndAlso StaticEffect Then
                rgbPosition += 1.0F
                If rgbPosition >= Single.MaxValue - 1.0F Then rgbPosition = 0F
            End If
        End If
    End Sub

    Private Sub frmWallpaper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If
    End Sub

    Private Sub PrepareGraphics(graphic As Graphics)
        graphic.SmoothingMode = UserSettings.SmoothingMode
        graphic.CompositingQuality = UserSettings.CompositingQuality
        graphic.InterpolationMode = UserSettings.InterpolationMode
        graphic.PixelOffsetMode = UserSettings.PixelOffsetMode
    End Sub

    Private Sub GenerateRGBSpectrum(graphic As Graphics, size As Size)
        Using theBrush As New LinearGradientBrush(Point.Empty, New Point(size.Width, size.Height), Color.Red, Color.Blue)
            Select Case UserSettings.RGBTrasform
                Case RGBTransform.Slide1
                    theBrush.TranslateTransform(rgbPosition, -rgbPosition, MatrixOrder.Prepend)
                Case RGBTransform.Slide2
                    theBrush.TranslateTransform(-rgbPosition, rgbPosition, MatrixOrder.Prepend)
                Case RGBTransform.Rotate1
                    theBrush.RotateTransform(rgbPosition, MatrixOrder.Prepend)
                Case RGBTransform.Rotate2
                    theBrush.RotateTransform(-rgbPosition, MatrixOrder.Prepend)
            End Select

            Dim colorBlend As New ColorBlend()
            Select Case UserSettings.RGBPattern
                Case RGBPattern.BlueToRed
                    colorBlend.Colors = New Color() {Color.FromArgb(3, 24, 237), Color.FromArgb(122, 13, 125), Color.FromArgb(254, 0, 1)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
                Case RGBPattern.Cyberpunk
                    colorBlend.Colors = New Color() {Color.FromArgb(206, 253, 66), Color.FromArgb(0, 220, 255), Color.FromArgb(206, 253, 66)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
                Case RGBPattern.Police
                    colorBlend.Colors = New Color() {Color.Black, Color.FromArgb(0, 0, 135), Color.FromArgb(12, 0, 243), Color.Red, Color.Black}
                    colorBlend.Positions = New Single() {0F, 0.25F, 0.5F, 0.75F, 1.0F}
                Case RGBPattern.PurplePink
                    colorBlend.Colors = New Color() {Color.FromArgb(254, 0, 146), Color.FromArgb(75, 0, 217), Color.FromArgb(254, 0, 146)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
                Case RGBPattern.Rainbow
                    colorBlend.Colors = New Color() {Color.Purple, Color.Red, Color.Yellow, Color.Lime, Color.Cyan, Color.Blue, Color.Purple}
                    colorBlend.Positions = New Single() {0F, 0.1666F, 0.3333F, 0.5F, 0.6666F, 0.8333F, 1.0F}
                Case RGBPattern.RedToBlack
                    colorBlend.Colors = New Color() {Color.Red, Color.Black, Color.FromArgb(128, 0, 0)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
                Case RGBPattern.YellowPink
                    colorBlend.Colors = New Color() {Color.FromArgb(241, 249, 5), Color.FromArgb(255, 6, 231), Color.FromArgb(241, 249, 5)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
                Case RGBPattern.YellowToRed
                    colorBlend.Colors = New Color() {Color.FromArgb(245, 188, 64), Color.FromArgb(254, 64, 125), Color.FromArgb(249, 30, 31)}
                    colorBlend.Positions = New Single() {0F, 0.5F, 1.0F}
            End Select

            theBrush.InterpolationColors = colorBlend

            PrepareGraphics(graphic)

            Dim rgbImg As New Bitmap(size.Width, size.Height)
            Using g As Graphics = Graphics.FromImage(rgbImg)
                PrepareGraphics(g)
                g.FillRectangle(theBrush, 0, 0, size.Width, size.Height)
            End Using

            If rgbImg IsNot Nothing Then graphic.DrawImage(rgbImg, ClientRectangle)
        End Using
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim graphic As Graphics = e.Graphics
        PrepareGraphics(graphic)

        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
                    If StaticEffect Then StaticEffect = False

                    Dim wallpaper = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = WScreen.Name).FirstOrDefault

                    Dim Width As Integer = WScreen.MatrixWidth
                    Dim Height As Integer = WScreen.MatrixHeight

                    Dim rectangleSize As New SizeF(ClientRectangle.Width / (wallpaper.Leds.Count / Height), ClientRectangle.Height / Height)

                    Dim matrix(Width - 1, Height - 1) As String
                    Dim count As Integer = 0
                    For j As Integer = 0 To matrix.GetUpperBound(0)
                        For i As Integer = 0 To matrix.GetUpperBound(0)
                            Dim rgbColor = wallpaper.Colors(count).ToColor

                            Using sb As New SolidBrush(rgbColor)
                                If UserSettings.LEDPadding >= 1 Then
                                    Using pen As New Pen(BackColor, UserSettings.LEDPadding)
                                        Dim X As Single = rectangleSize.Width * i
                                        Dim Y As Single = rectangleSize.Height * j

                                        Select Case UserSettings.LEDShape
                                            Case LEDShape.Rectangle
                                                graphic.FillRectangle(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                                                graphic.DrawRectangle(pen, New Rectangle(X, Y, rectangleSize.Width, rectangleSize.Height))
                                            Case LEDShape.RoundedRectangle
                                                graphic.FillRoundedRectangle(sb, New Rectangle(X, Y, rectangleSize.Width, rectangleSize.Height), 10)
                                                graphic.DrawRoundedRectangle(pen, New Rectangle(X, Y, rectangleSize.Width, rectangleSize.Height), 10)
                                            Case LEDShape.Sphere
                                                graphic.FillEllipse(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                                                graphic.DrawEllipse(pen, New Rectangle(X, Y, rectangleSize.Width, rectangleSize.Height))
                                        End Select
                                    End Using
                                Else
                                    Dim X As Single = rectangleSize.Width * i
                                    Dim Y As Single = rectangleSize.Height * j

                                    Select Case UserSettings.LEDShape
                                        Case LEDShape.Rectangle
                                            graphic.FillRectangle(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                                        Case LEDShape.RoundedRectangle
                                            graphic.FillRoundedRectangle(sb, New Rectangle(X, Y, rectangleSize.Width, rectangleSize.Height), 10)
                                        Case LEDShape.Sphere
                                            graphic.FillEllipse(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                                    End Select
                                End If
                            End Using
                            count += 1
                            If count >= wallpaper.Leds.Count Then count = 0
                        Next
                    Next
                Else
                    If Not StaticEffect Then StaticEffect = True
                End If
            Else
                If Not StaticEffect Then StaticEffect = True
            End If
        Catch ex As Exception
            If Not StaticEffect Then StaticEffect = True
            renderString = $"220 On Paint: {ex.Message}"
            Log(ex)
        End Try

        If StaticEffect Then
            If UserSettings.StaticEffect Then GenerateRGBSpectrum(graphic, New Size(ClientRectangle.Width / 100, ClientRectangle.Height / 100))
        End If

        Try
            If BackImg IsNot Nothing Then
                Select Case ImgFit
                    Case ImageFit.None
                        graphic.DrawImage(BackImg, ClientRectangle.X, ClientRectangle.Y, New Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height), GraphicsUnit.Pixel)
                    Case ImageFit.Center
                        Dim imgSize As Integer = BackImg.Width + BackImg.Height
                        Dim crSize As Integer = ClientRectangle.Width + ClientRectangle.Height
                        Dim iX As Integer = (ClientRectangle.Width - BackImg.Width) / 2
                        Dim iY As Integer = (ClientRectangle.Height - BackImg.Height) / 2

                        If crSize > imgSize Then
                            graphic.DrawImage(BackImg, iX, iY, New Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height), GraphicsUnit.Pixel)
                        Else
                            graphic.DrawImage(BackImg, iX, iY, New Rectangle(0, 0, BackImg.Width, BackImg.Height), GraphicsUnit.Pixel)
                        End If
                    Case ImageFit.Stretch
                        graphic.DrawImage(BackImg, New RectangleF(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height), New RectangleF(0, 0, BackImg.Width, BackImg.Height), GraphicsUnit.Pixel)
                    Case ImageFit.Fill, ImageFit.Fit
                        Dim aspectRatio As Double
                        Dim newHeight, newWidth As Integer
                        Dim maxWidth As Integer = Width
                        Dim maxHeight As Integer = Width

                        If BackImg.Width > maxWidth Or BackImg.Height > maxHeight Then
                            If BackImg.Width >= BackImg.Height Then ' image is wider than tall
                                newWidth = maxWidth
                                aspectRatio = BackImg.Width / maxWidth
                                newHeight = CInt(BackImg.Height / aspectRatio)
                            Else ' image is taller than wide
                                newHeight = maxHeight
                                aspectRatio = BackImg.Height / maxHeight
                                newWidth = CInt(BackImg.Width / aspectRatio)
                            End If
                        Else
                            If BackImg.Width > BackImg.Height Then
                                newWidth = maxWidth
                                aspectRatio = BackImg.Width / maxWidth
                                newHeight = CInt(BackImg.Height / aspectRatio)
                            Else
                                newHeight = maxHeight
                                aspectRatio = BackImg.Height / maxHeight
                                newWidth = CInt(BackImg.Width / aspectRatio)
                            End If
                        End If

                        Dim newX As Integer = (Width - newWidth) / 2
                        Dim newY As Integer = (Height - newHeight) / 2

                        graphic.DrawImage(BackImg, New RectangleF(newX, newY, newWidth, newHeight))
                End Select

            End If
        Catch ex As Exception
            renderString = $"282 On Paint: {ex.Message}"
            Log(ex)
        End Try

        Try
            If renderString <> Nothing Then
                Using sb As New SolidBrush(Color.White)
                    graphic.DrawString(renderString, Font, sb, New RectangleF(20.0F, 20.0F, ClientRectangle.Width - 20.0F, ClientRectangle.Height - 20.0F))
                End Using
            End If
        Catch ex As Exception
            Log(ex)
        End Try

        MyBase.OnPaint(e)
    End Sub

End Class
