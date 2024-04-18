Imports System.Drawing.Imaging
Imports OpenRGB.NET
Imports OpenRGB.NET.Models

Public Class ucScreen

    Public Property WScreen() As Screen

    Private Sub ucScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbImageFit.DataSource = [Enum].GetValues(GetType(ImageFit)).Cast(Of ImageFit)
        cmbRenderer.DataSource = [Enum].GetValues(GetType(Renderer)).Cast(Of Renderer)
        Try
            Using oRgbClient As New OpenRGBClient(WScreen.IPAddress, WScreen.Port, "Getting devices information")
                If oRgbClient.Connected Then
                    For Each device In oRgbClient.GetAllControllerData
                        If device.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then cmbDeviceName.Items.Add(device.Name)
                    Next
                    For Each zone In oRgbClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = WScreen.Name).Zones
                        If zone.MatrixMap IsNot Nothing Then
                            cmbDeviceZone.Items.Add(zone.Name)
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            cmbDeviceName.Items.Add(WScreen.Name)
            cmbDeviceZone.Items.Add(If(WScreen.Zone = Nothing, "", WScreen.Zone))
        End Try

        cmbDeviceName.SelectedItem = WScreen.Name
        cmbDeviceZone.SelectedItem = If(WScreen.Zone = Nothing, "", WScreen.Zone)
        txtIPAddress.Text = WScreen.IPAddress
        txtPort.Text = WScreen.Port
        cbAutoconnect.Checked = WScreen.Autoconnect

        txtDisplayX.Text = WScreen.Position.X
        txtDisplayY.Text = WScreen.Position.Y
        txtDisplayWidth.Text = WScreen.Size.Width
        txtDisplayHeight.Text = WScreen.Size.Height

        pbImage.BackgroundImage = WScreen.BackgroundImage.Base64ToImage
        If pbImage.BackgroundImage IsNot Nothing Then btnDelImage.Show()

        btnBackColor.BackColor = ColorTranslator.FromHtml(WScreen.BackgroundColor)
        cmbImageFit.SelectedItem = WScreen.ImageFit
        cmbRenderer.SelectedItem = WScreen.Renderer
        lblNotify.Visible = False
        btnApply.Enabled = False
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            Dim newScreen As New Screen
            With newScreen
                .IPAddress = txtIPAddress.Text
                .Port = CInt(txtPort.Text)
                .Name = cmbDeviceName.SelectedItem
                .Zone = cmbDeviceZone.SelectedItem
                .Autoconnect = cbAutoconnect.Checked
                .Position = New Point(CInt(txtDisplayX.Text), CInt(txtDisplayY.Text))
                .Size = New Size(CInt(txtDisplayWidth.Text), CInt(txtDisplayHeight.Text))
                .BackgroundImage = pbImage.BackgroundImage.ImageToBase64(Imaging.ImageFormat.Png)
                .BackgroundColor = ColorTranslator.ToHtml(btnBackColor.BackColor)
                .ImageFit = cmbImageFit.SelectedItem
                .Renderer = cmbRenderer.SelectedItem
            End With
            WScreen = newScreen

            lblNotify.Visible = False
            btnApply.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim result As DialogResult = MessageBox.Show("Confirm remove?", "Remove", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                frmMain.tcScreen.TabPages.Remove(frmMain.tcScreen.TabPages(frmMain.CurrentTabIndex))
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub txtTextChanged(sender As Object, e As EventArgs) Handles txtIPAddress.TextChanged, txtDisplayHeight.TextChanged, cmbRenderer.SelectedIndexChanged,
        txtDisplayWidth.TextChanged, txtDisplayX.TextChanged, txtDisplayY.TextChanged, txtPort.TextChanged,
        cbAutoconnect.CheckedChanged, pbImage.BackgroundImageChanged, cmbImageFit.SelectedIndexChanged, btnBackColor.BackColorChanged

        lblNotify.Visible = True
        btnApply.Enabled = True
    End Sub

    Private Sub btnDelImage_Click(sender As Object, e As EventArgs) Handles btnDelImage.Click
        pbImage.BackgroundImage = Nothing
        btnDelImage.Hide()
    End Sub

    Private Sub btnChgImage_Click(sender As Object, e As EventArgs) Handles btnChgImage.Click, pbImage.Click
        Dim imgDialog As New frmImgDialog With {.ParentPB = pbImage, .ParentDelBtn = btnDelImage}
        imgDialog.Show()
    End Sub

    Private Sub lblWallpaperDownload_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblWallpaperDownload.LinkClicked
        Process.Start("https://github.com/qiangqiang101/OpenRGB-Wallpaper/wiki/Wallpapers")
    End Sub

    Private Sub btnBackColor_Click(sender As Object, e As EventArgs) Handles btnBackColor.Click
        If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
            btnBackColor.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub cmbDeviceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceName.SelectedIndexChanged
        lblNotify.Visible = True
        btnApply.Enabled = True
        cmbDeviceZone.Items.Clear()

        Try
            Using oRgbClient As New OpenRGBClient(WScreen.IPAddress, WScreen.Port, "Getting devices information")
                If oRgbClient.Connected Then
                    For Each zone In oRgbClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = CStr(cmbDeviceName.SelectedItem)).Zones
                        If zone.MatrixMap IsNot Nothing Then
                            cmbDeviceZone.Items.Add(zone.Name)
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            cmbDeviceZone.Items.Add(If(WScreen.Zone = Nothing, "", WScreen.Zone))
        End Try

        If cmbDeviceZone.Items.Count <> 0 Then
            cmbDeviceZone.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cmbDeviceName.Items.Clear()

        Try
            Using oRgbClient As New OpenRGBClient(WScreen.IPAddress, WScreen.Port, "Getting devices information")
                If oRgbClient.Connected Then
                    For Each device In oRgbClient.GetAllControllerData
                        If device.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then cmbDeviceName.Items.Add(device.Name)
                    Next
                End If
            End Using
        Catch ex As Exception
            cmbDeviceName.Items.Add(WScreen.Name)
        End Try

        cmbDeviceName.SelectedItem = WScreen.Name
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim sd As New frmScreenDialog
        With sd
            .MyParent = Me
        End With
        sd.Show()

    End Sub
End Class
