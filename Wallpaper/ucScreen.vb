Imports System.Drawing.Imaging

Public Class ucScreen

    Public Property WScreen() As Screen

    Private Sub ucScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        txtMatrixWidth.Text = WScreen.MatrixWidth
        txtMatrixHeight.Text = WScreen.MatrixHeight

        pbImage.BackgroundImage = WScreen.BackgroundImage.Base64ToImage
        If pbImage.BackgroundImage IsNot Nothing Then btnDelImage.Show()

        lblNotify.Visible = False
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
                .MatrixWidth = CInt(txtMatrixWidth.Text)
                .MatrixHeight = CInt(txtMatrixHeight.Text)
                .BackgroundImage = pbImage.BackgroundImage.ImageToBase64(Imaging.ImageFormat.Png)
            End With
            WScreen = newScreen

            lblNotify.Visible = False
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
        txtDisplayX.TextChanged, txtDisplayY.TextChanged, txtMatrixHeight.TextChanged, txtMatrixWidth.TextChanged, txtPort.TextChanged, txtProtocol.TextChanged, txtTimeout.TextChanged,
        cbAutoconnect.CheckedChanged, pbImage.BackgroundImageChanged

        If sender Is txtMatrixWidth Or sender Is txtMatrixHeight Then
            Try
                txtTotalLEDs.Text = CInt(txtMatrixWidth.Text) * CInt(txtMatrixHeight.Text)
            Catch ex As Exception
            End Try
        End If

        lblNotify.Visible = True
    End Sub

    Private Sub pbImage_Click(sender As Object, e As EventArgs) Handles pbImage.Click
        'Dim ofd As New OpenFileDialog() With {.Filter = ImageCodecInfo.GetImageEncoders().Aggregate("All Files (*.*)|*.*", Function(s, c) $"{s}|{c.CodecName.Substring(8).Replace("Codec", "Files").Trim()} ({c.FilenameExtension})|{c.FilenameExtension}"), .Multiselect = False, .Title = "Select Image file..."}
        'If ofd.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
        '    pbImage.BackgroundImage = Image.FromFile(ofd.FileName)
        '    btnDelImage.Show()
        'End If
        Dim imgDialog As New frmImgDialog With {.ParentPB = pbImage, .ParentDelBtn = btnDelImage}
        imgDialog.Show()
    End Sub

    Private Sub btnDelImage_Click(sender As Object, e As EventArgs) Handles btnDelImage.Click
        pbImage.BackgroundImage = Nothing
        btnDelImage.Hide()
    End Sub
End Class
