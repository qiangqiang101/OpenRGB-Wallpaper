﻿Imports System.ComponentModel
Imports OpenRGB.NET

Public Class frmWallpaper

    Dim oRgbClient As OpenRGBClient = Nothing
    Dim renderString As String = Nothing

    Public Property WScreen() As Screen

    Private Sub frmWallpaper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        Connect(WScreen)
    End Sub

    Public Sub Connect(ws As Screen)
        Try
            oRgbClient = New OpenRGBClient(ws.IPAddress, ws.Port, ws.Name, ws.Autoconnect, ws.Timeout, ws.ProtocolVersion)
        Catch ex As Exception
            renderString = ex.Message
        End Try
    End Sub

    Public Sub Connect()
        oRgbClient.Connect()
    End Sub

    Public Sub Reconnect()
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If

        Connect(WScreen)
        renderString = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Invalidate()
    End Sub

    Private Sub frmWallpaper_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If oRgbClient IsNot Nothing Then
            If oRgbClient.Connected Then oRgbClient.Dispose()
        End If
    End Sub

    Private Sub frmWallpaper_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim graphic As Graphics = e.Graphics
        graphic.SmoothingMode = UserSettings.SmoothingMode
        graphic.CompositingQuality = UserSettings.CompositingQuality
        graphic.InterpolationMode = UserSettings.InterpolationMode

        Try
            If oRgbClient IsNot Nothing Then
                If oRgbClient.Connected Then
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
                                Dim X As Single = rectangleSize.Width * i
                                Dim Y As Single = rectangleSize.Height * j

                                graphic.FillRectangle(sb, New RectangleF(X, Y, rectangleSize.Width, rectangleSize.Height))
                            End Using
                            count += 1
                            If count >= wallpaper.Leds.Count Then count = 0
                        Next
                    Next
                End If
            End If
        Catch ex As Exception
            renderString = ex.Message
        End Try

        Try
            Using sb As New SolidBrush(Color.White)
                graphic.DrawString(renderString, Font, sb, New RectangleF(20.0F, 20.0F, ClientRectangle.Width - 20.0F, ClientRectangle.Height - 20.0F))
            End Using
        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmWallpaper_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
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
