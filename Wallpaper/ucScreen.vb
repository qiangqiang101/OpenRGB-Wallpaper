Imports System.Drawing.Imaging

Public Class ucScreen

    Public Property WScreen() As Screen

    Private Sub ucScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbImageFit.DataSource = [Enum].GetValues(GetType(ImageFit)).Cast(Of ImageFit)

        txtIPAddress.Text = WScreen.IPAddress
        txtPort.Text = WScreen.Port
        txtClientName.Text = WScreen.Name
        txtTimeout.Text = WScreen.Timeout
        txtProtocol.Text = WScreen.ProtocolVersion
        cbAutoconnect.Checked = WScreen.Autoconnect

        txtDisplayX.Text = WScreen.Position.X
        txtDisplayY.Text = WScreen.Position.Y
        txtDisplayWidth.Text = WScreen.Size.Width
        txtDisplayHeight.Text = WScreen.Size.Height

        pbImage.BackgroundImage = WScreen.BackgroundImage.Base64ToImage
        If pbImage.BackgroundImage IsNot Nothing Then btnDelImage.Show()

        btnBackColor.BackColor = ColorTranslator.FromHtml(WScreen.BackgroundColor)
        cmbImageFit.SelectedItem = WScreen.ImageFit

        lblNotify.Visible = False
        btnApply.Enabled = False
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            Dim newScreen As New Screen
            With newScreen
                .IPAddress = txtIPAddress.Text
                .Port = CInt(txtPort.Text)
                .Name = txtClientName.Text
                .Timeout = CInt(txtTimeout.Text)
                .ProtocolVersion = CInt(txtProtocol.Text)
                .Autoconnect = cbAutoconnect.Checked
                .Position = New Point(CInt(txtDisplayX.Text), CInt(txtDisplayY.Text))
                .Size = New Size(CInt(txtDisplayWidth.Text), CInt(txtDisplayHeight.Text))
                .BackgroundImage = pbImage.BackgroundImage.ImageToBase64(Imaging.ImageFormat.Png)
                .BackgroundColor = ColorTranslator.ToHtml(btnBackColor.BackColor)
                .ImageFit = cmbImageFit.SelectedItem
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
                frmMain.tcScreen.TabPages.Remove(frmMain.tcScreen.TabPages(frmMain.CurrentTabIndex)) 'RemoveAt(frmMain.CurrentTabIndex)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub txtTextChanged(sender As Object, e As EventArgs) Handles txtIPAddress.TextChanged, txtClientName.TextChanged, txtDisplayHeight.TextChanged, txtDisplayWidth.TextChanged,
        txtDisplayX.TextChanged, txtDisplayY.TextChanged, txtPort.TextChanged, txtProtocol.TextChanged, txtTimeout.TextChanged,
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
End Class
