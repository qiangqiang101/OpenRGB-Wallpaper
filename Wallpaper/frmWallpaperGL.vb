Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports OpenRGB.NET
Imports SkiaSharp
Imports SkiaSharp.Views.Desktop

Public Class frmWallpaperGL

    Dim renderString As String = Nothing
    Dim rgbPosition As Single = 0F
    Dim StaticEffect As Boolean = False
    Dim OffColor As Color = Color.FromArgb(255, 0, 0, 0)

    Public oRgbClient As OpenRGBClient = Nothing
    Public IsPaused As Boolean = False
    Public BackSKImg As SKBitmap = Nothing
    Public ImgFit As ImageFit = ImageFit.Stretch
    Public WaitForOpenRGB As Boolean = False
    Public cpuUsage As New PerformanceCounter("Processor", "% Processor Time", "_Total")

    Public Property WScreen() As Screen

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

    Private Sub frmWallpaperGL_Load(sender As Object, e As EventArgs) Handles Me.Load
        BackColor = ColorTranslator.FromHtml(WScreen.BackgroundColor)
        skiaView.BackColor = BackColor
        BackSKImg = WScreen.BackgroundImage.Base64ToSKBitmap
        ImgFit = WScreen.ImageFit
        skiaView.VSync = UserSettings.VSync

        If BackSKImg IsNot Nothing Then
            If ImgFit = ImageFit.Fit Then
                Dim BackImg = WScreen.BackgroundImage.Base64ToImage.ResizeImage(ClientRectangle.Size, True)
                BackSKImg = BackImg.ImageToBase64.Base64ToSKBitmap
            End If
        End If

        If Not WaitForOpenRGB Then Connect(WScreen)
    End Sub

    Public Sub Connect(ws As Screen)
        Try
            If Not oRgbClient Is Nothing Then oRgbClient.Dispose()
            oRgbClient = New OpenRGBClient(ws.IPAddress, ws.Port, $"{ws.Name} [OpenGL]", ws.Autoconnect, 1000, 2)
        Catch ex As Exception
            renderString = $"48 Connect Error: {ex.Message}"
            Log(ex)
        End Try
    End Sub

    Public Sub Connect()
        Try
            oRgbClient.Connect()
        Catch ex As Exception
            renderString = $"57 Connect Error: {ex.Message}"
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
            renderString = $"72 Reconnect Error: {ex.Message}"
            Log(ex)
        End Try
    End Sub

    Private Function HighCpuUsage() As Boolean
        If UserSettings.AutoPause Then
            Return CInt(Math.Ceiling(cpuUsage.NextValue)) >= UserSettings.CpuUsagePauseValue
        Else
            Return False
        End If
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsPaused AndAlso Not HighCpuUsage() Then
            If StaticEffect Then Invalidate()
            skiaView.Invalidate()

            If UserSettings.StaticEffect AndAlso StaticEffect Then
                rgbPosition += 50.0F
                If rgbPosition >= Single.MaxValue - 1.0F Then rgbPosition = 0F
            End If
        End If
    End Sub

    Private Sub frmWallpaperGL_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If
    End Sub

    Private Sub skiaView_PaintSurface(sender As Object, e As SKPaintGLSurfaceEventArgs) Handles skiaView.PaintSurface
        Dim canvas = e.Surface.Canvas
        canvas.Clear(BackColor.ToSKColor)

        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
                    If StaticEffect Then StaticEffect = False

                    Dim wallpaper = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = WScreen.Name).FirstOrDefault
                    Dim oMatrix = wallpaper.Zones.Where(Function(x) x.Name = WScreen.Zone).FirstOrDefault.MatrixMap

                    If oMatrix IsNot Nothing Then
                        Dim Width As Integer = oMatrix.Width
                        Dim Height As Integer = oMatrix.Height

                        'Dim rectangleSize As New SizeF(ClientRectangle.Width / (wallpaper.Leds.Count / Width), ClientRectangle.Height / Height)
                        Dim rectangleSize As New SizeF(ClientRectangle.Width / Width, ClientRectangle.Height / Height)

                        Dim matrix(Width - 1, Height - 1) As String
                        Dim count As Integer = 0
                        For j As Integer = 0 To matrix.GetUpperBound(0)
                            For i As Integer = 0 To matrix.GetUpperBound(0)
                                Dim rgbColor = wallpaper.Colors(count).ToColor
                                If rgbColor <> OffColor Then
                                    Dim X As Single = rectangleSize.Width * i
                                    Dim Y As Single = rectangleSize.Height * j
                                    Dim W As Single = rectangleSize.Width
                                    Dim H As Single = rectangleSize.Height
                                    Dim P As Single = UserSettings.LEDPadding

                                    Using paint As New SKPaint With {.Color = rgbColor.ToSKColor, .IsAntialias = UserSettings.AntiAlias, .Style = SKPaintStyle.Fill}
                                        Select Case UserSettings.LEDShape
                                            Case LEDShape.Rectangle
                                                Dim rect = SKRect.Create(X + P, Y + P, W - P, H - P)
                                                canvas.DrawRect(rect, paint)
                                            Case LEDShape.RoundedRectangle
                                                Dim rect = SKRect.Create(X + P, Y + P, W - P, H - P)
                                                Using rrect As New SKRoundRect(rect, UserSettings.RoundedRectangleCornerRadius)
                                                    canvas.DrawRoundRect(rrect, paint)
                                                End Using
                                            Case LEDShape.Sphere
                                                Dim rect = SKRect.Create(X + P, Y + P, W - P, H - P)
                                                Using rrect As New SKRoundRect(rect, 360)
                                                    canvas.DrawRoundRect(rrect, paint)
                                                End Using
                                        End Select
                                    End Using
                                End If

                                count += 1
                                If count >= wallpaper.Leds.Count Then count = 0
                            Next
                        Next
                    End If
                Else
                    If Not StaticEffect Then StaticEffect = True
                End If
            Else
                If Not StaticEffect Then StaticEffect = True
            End If
        Catch ex As Exception
            If Not StaticEffect Then StaticEffect = True
            renderString = $"208 On Paint: {ex.Message}"
            Log(ex)
        End Try

        If StaticEffect Then
            If UserSettings.StaticEffect Then
                Using paint = New SKPaint
                    Dim rect = SKRect.Create(0, 0, Size.Width, Size.Height)
                    Dim transform As SKMatrix = Nothing

                    Select Case UserSettings.RGBTrasform
                        Case RGBTransform.Slide1
                            transform = SKMatrix.CreateTranslation(rgbPosition, -rgbPosition)
                        Case RGBTransform.Slide2
                            transform = SKMatrix.CreateTranslation(-rgbPosition, rgbPosition)
                        Case RGBTransform.Rotate1
                            transform = SKMatrix.CreateRotation(rgbPosition)
                        Case RGBTransform.Rotate2
                            transform = SKMatrix.CreateRotation(-rgbPosition)
                    End Select

                    Select Case UserSettings.RGBPattern
                        Case RGBPattern.BlueToRed
                            Dim colors = New SKColor() {New SKColor(3, 24, 237), New SKColor(122, 13, 125), New SKColor(254, 0, 1)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.Cyberpunk
                            Dim colors = New SKColor() {New SKColor(206, 253, 66), New SKColor(0, 220, 255), New SKColor(206, 253, 66)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.Police
                            Dim colors = New SKColor() {SKColors.Black, New SKColor(0, 0, 135), New SKColor(12, 0, 243), SKColors.Red, SKColors.Black}
                            Dim positions = New Single() {0F, 0.25F, 0.5F, 0.75F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.PurplePink
                            Dim colors = New SKColor() {New SKColor(254, 0, 146), New SKColor(75, 0, 217), New SKColor(254, 0, 146)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.Rainbow
                            Dim colors = New SKColor() {SKColors.Purple, SKColors.Red, SKColors.Yellow, SKColors.Lime, SKColors.Cyan, SKColors.Blue, SKColors.Purple}
                            Dim positions = New Single() {0F, 0.1666F, 0.3333F, 0.5F, 0.6666F, 0.8333F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.RedToBlack
                            Dim colors = New SKColor() {SKColors.Red, SKColors.Black, New SKColor(128, 0, 0)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.YellowPink
                            Dim colors = New SKColor() {New SKColor(241, 249, 5), New SKColor(255, 6, 231), New SKColor(241, 249, 5)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                        Case RGBPattern.YellowToRed
                            Dim colors = New SKColor() {New SKColor(245, 188, 64), New SKColor(254, 64, 125), New SKColor(249, 30, 31)}
                            Dim positions = New Single() {0F, 0.5F, 1.0F}
                            paint.Shader = SKShader.CreateLinearGradient(New SKPoint(rect.Left, rect.Top), New SKPoint(rect.Right, rect.Bottom), colors, positions, SKShaderTileMode.Repeat, transform)
                    End Select

                    canvas.DrawRect(rect, paint)
                End Using
            End If
        End If

        Try
            If BackSKImg IsNot Nothing Then
                Select Case ImgFit
                    Case ImageFit.None
                        canvas.DrawBitmap(BackSKImg, SKRect.Create(ClientRectangle.X, ClientRectangle.Y, BackSKImg.Width, BackSKImg.Height))
                    Case ImageFit.Center
                        Dim imgSize As Integer = BackSKImg.Width + BackSKImg.Height
                        Dim crSize As Integer = ClientRectangle.Width + ClientRectangle.Height
                        Dim iX As Integer = (ClientRectangle.Width - BackSKImg.Width) / 2
                        Dim iY As Integer = (ClientRectangle.Height - BackSKImg.Height) / 2

                        If crSize > imgSize Then
                            canvas.DrawBitmap(BackSKImg, SKRect.Create(iX, iY, ClientRectangle.Width, ClientRectangle.Height))
                        Else
                            canvas.DrawBitmap(BackSKImg, SKRect.Create(iX, iY, BackSKImg.Width, BackSKImg.Height))
                        End If
                    Case ImageFit.Stretch
                        canvas.DrawBitmap(BackSKImg, SKRect.Create(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height))
                    Case ImageFit.Fill, ImageFit.Fit
                        Dim aspectRatio As Double
                        Dim newHeight, newWidth As Integer
                        Dim maxWidth As Integer = Width
                        Dim maxHeight As Integer = Width

                        If BackSKImg.Width > maxWidth Or BackSKImg.Height > maxHeight Then
                            If BackSKImg.Width >= BackSKImg.Height Then ' image is wider than tall
                                newWidth = maxWidth
                                aspectRatio = BackSKImg.Width / maxWidth
                                newHeight = CInt(BackSKImg.Height / aspectRatio)
                            Else ' image is taller than wide
                                newHeight = maxHeight
                                aspectRatio = BackSKImg.Height / maxHeight
                                newWidth = CInt(BackSKImg.Width / aspectRatio)
                            End If
                        Else
                            If BackSKImg.Width > BackSKImg.Height Then
                                newWidth = maxWidth
                                aspectRatio = BackSKImg.Width / maxWidth
                                newHeight = CInt(BackSKImg.Height / aspectRatio)
                            Else
                                newHeight = maxHeight
                                aspectRatio = BackSKImg.Height / maxHeight
                                newWidth = CInt(BackSKImg.Width / aspectRatio)
                            End If
                        End If

                        Dim newX As Integer = (Width - newWidth) / 2
                        Dim newY As Integer = (Height - newHeight) / 2

                        canvas.DrawBitmap(BackSKImg, SKRect.Create(newX, newY, newWidth, newHeight))
                End Select

            End If
        Catch ex As Exception
            renderString = $"270 On Paint: {ex.Message}"
            Log(ex)
        End Try

        Try
            If renderString <> Nothing Then
                Using font As New SKFont With {.Size = Me.Font.Size * 2}
                    Using paint As New SKPaint() With {.Color = SKColors.White, .IsAntialias = UserSettings.AntiAlias, .Style = SKPaintStyle.Fill}
                        canvas.DrawText(renderString, 20, 20, font, paint)
                    End Using
                End Using
            End If
        Catch ex As Exception
            Log(ex)
        End Try
    End Sub

End Class