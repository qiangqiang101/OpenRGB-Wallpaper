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
            End With
            WScreen = newScreen
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
End Class
