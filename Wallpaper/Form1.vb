Imports System.ComponentModel
Imports OpenRGB.NET

Public Class Form1

    Dim oRgbClient As OpenRGBClient = Nothing

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            oRgbClient = New OpenRGBClient("127.0.0.1", 6742, "Wallpaper1", True, 1000, 2)
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Invalidate()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If oRgbClient IsNot Nothing AndAlso oRgbClient.Connected Then
            Dim wallpaper = oRgbClient.GetAllControllerData.Where(Function(x) x.Name = "Wallpaper1").FirstOrDefault
            Dim graphic As Graphics = e.Graphics

            graphic.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            graphic.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear

            'Dim rectangleSize As Integer = Me.Width / wallpaper.Leds.Count
            'Dim rectangleY As Integer = (Me.Height / 2) - (rectangleSize / 2)
            Dim rows As Integer = 11
            Dim cols As Integer = 25
            Dim rectangleSize As New SizeF(ClientRectangle.Width / (wallpaper.Leds.Count / rows), ClientRectangle.Height / rows)

            'For i As Integer = 0 To wallpaper.Leds.Count - 1
            '    Dim rgbColor = wallpaper.Colors(i).ToColor
            '    Using sb As New SolidBrush(rgbColor)
            '        Dim X As Single = rectangleSize.Width * i
            '        Dim Y As Single = CalcY(rows, i, rectangleSize.Height) 'rectangleSize.Height * (i + rows)
            '        'Dim recPerRow As Integer = cols
            '        'Dim recPerCol As Integer = rows

            '        graphic.FillRectangle(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
            '        Using sb2 As New SolidBrush(ForeColor)
            '            graphic.DrawString(i, Font, sb2, X, Y)
            '        End Using
            '    End Using
            'Next

            For i As Integer = 0 To wallpaper.Leds.Count - 1
                For j As Integer = 0 To rows - 1
                    Dim rgbColor = wallpaper.Colors(i).ToColor
                    Using sb As New SolidBrush(rgbColor)
                        Dim X As Single = rectangleSize.Width * i
                        Dim Y As Single = rectangleSize.Height * j

                        graphic.FillRectangle(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                        Using sb2 As New SolidBrush(ForeColor)
                            graphic.DrawString(i, Font, sb2, X, Y)
                        End Using
                    End Using
                Next
            Next

        End If
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.TopMost = True
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.FormBorderStyle = FormBorderStyle.None
            Me.TopMost = False
        End If
    End Sub
End Class
