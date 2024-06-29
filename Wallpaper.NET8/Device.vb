Imports System.Drawing.Imaging
Imports System.Transactions
Imports OpenRGB.NET

Public Class Device

    Public Property Device() As E131Device

    Private Sub Device_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbSizeMode.DataSource = [Enum].GetValues(GetType(PictureBoxSizeMode)).Cast(Of PictureBoxSizeMode)

        Try
            Using OpenRgbClient As New OpenRgbClient("127.0.0.1", Device.Port, "Getting devices information")
                If OpenRgbClient.Connected Then
                    For Each dev In OpenRgbClient.GetAllControllerData
                        If dev.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then cmbDeviceName.Items.Add(dev.Name)
                    Next
                    If cmbDeviceName.SelectedItem <> Nothing Then
                        For Each zone In OpenRgbClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = Device.Name).Zones
                            If zone.MatrixMap IsNot Nothing Then cmbDeviceZone.Items.Add(zone.Name)
                        Next
                    End If
                End If
            End Using
        Catch ex As Exception
            Log(ex)
            cmbDeviceName.Items.Add(Device.Name)
            cmbDeviceZone.Items.Add(Device.Zone)
        End Try

        cmbDeviceName.SelectedItem = Device.Name
        cmbDeviceZone.SelectedItem = Device.Zone
        nudPort.Value = Device.Port
        cbAutoconnect.Checked = Device.AutoConnect

        nudDisplayX.Value = Device.Position.X
        nudDisplayY.Value = Device.Position.Y
        nudDisplayWidth.Value = Device.Size.Width
        nudDisplayHeight.Value = Device.Size.Height

        pbImage.Image = Device.BackgroundImage.Base64ToImage
        If pbImage.BackgroundImage IsNot Nothing Then btnDelImage.Enabled = True

        cmbBackColor.SelectedItem = ColorTranslator.FromHtml(Device.BackgroundColor)
        cmbSizeMode.SelectedItem = Device.SizeMode
        lblNotify.Visible = False
        btnApply.Enabled = False
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            Dim newDevice As New E131Device
            With newDevice
                .Port = CInt(nudPort.Value)
                .Name = cmbDeviceName.SelectedItem
                .Zone = cmbDeviceZone.SelectedItem
                .AutoConnect = cbAutoconnect.Checked
                .Position = New Point(CInt(nudDisplayX.Value), CInt(nudDisplayY.Value))
                .Size = New Size(CInt(nudDisplayWidth.Value), CInt(nudDisplayHeight.Value))
                .BackgroundImage = pbImage.Image.ImageToBase64(Imaging.ImageFormat.Png)
                .BackgroundColor = ColorTranslator.ToHtml(cmbBackColor.SelectedValue)
                .SizeMode = cmbSizeMode.SelectedItem
            End With
            Device = newDevice

            lblNotify.Visible = False
            btnApply.Enabled = False

            Dim tp = Main.tcDevices.TabPages.Item(Main.CurrentTabIndex)
            tp.Text = If(newDevice.Name = newDevice.Zone, newDevice.Name, $"{newDevice.Name} - {newDevice.Zone}")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim result As DialogResult = MessageBox.Show("Confirm remove?", "Remove", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Try
                Main.tcDevices.TabPages.Remove(Main.tcDevices.TabPages(Main.CurrentTabIndex))
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub _TextChanged(sender As Object, e As EventArgs)
        lblNotify.Visible = True
        btnApply.Enabled = True
    End Sub

    Private Sub _ValueChanged(sender As Object, e As EventArgs) Handles nudDisplayX.ValueChanged, nudDisplayY.ValueChanged, nudDisplayWidth.ValueChanged, nudDisplayHeight.ValueChanged
        lblNotify.Visible = True
        btnApply.Enabled = True
    End Sub

    Private Sub _SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbBackColor.SelectedValueChanged, cmbDeviceName.SelectedValueChanged, cmbDeviceZone.SelectedValueChanged, cmbSizeMode.SelectedValueChanged
        lblNotify.Visible = True
        btnApply.Enabled = True
    End Sub

    Private Sub btnDelImage_Click(sender As Object, e As EventArgs) Handles btnDelImage.Click
        pbImage.Image = Nothing
        btnDelImage.Enabled = False
    End Sub

    Private Sub btnChgImage_Click(sender As Object, e As EventArgs) Handles btnChgImage.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .DefaultExt = "png"
            .InitialDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\WhirlwindFX\Components"
            .Filter = "PNG file|*.PNG|All files|*.*"
            .Title = "Select image file..."
            .Multiselect = False
        End With
        If ofd.ShowDialog <> DialogResult.Cancel Then
            pbImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnGetWallpaper_Click(sender As Object, e As EventArgs) Handles btnGetWallpaper.Click
        Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/qiangqiang101/OpenRGB-Wallpaper/wiki/Wallpapers", .UseShellExecute = True})
    End Sub

    Private Sub cmbDeviceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeviceName.SelectedIndexChanged
        cmbDeviceZone.Items.Clear()

        Try
            Using oRGBClient As New OpenRgbClient("127.0.0.1", Device.Port, "Getting devices information")
                If oRGBClient.Connected Then
                    For Each zone In oRGBClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = CStr(cmbDeviceName.SelectedItem)).Zones
                        If zone.MatrixMap IsNot Nothing Then cmbDeviceZone.Items.Add(zone.Name)
                    Next
                End If
            End Using
        Catch ex As Exception
            cmbDeviceZone.Items.Add(If(Device.Zone = Nothing, "", Device.Zone))
        End Try

        If cmbDeviceZone.Items.Count <> 0 Then cmbDeviceZone.SelectedIndex = 0
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cmbDeviceName.Items.Clear()

        Try
            Using oRGBClient As New OpenRgbClient("127.0.0.1", Device.Port, "Getting devices information")
                If oRGBClient.Connected Then
                    For Each dev In oRGBClient.GetAllControllerData
                        If dev.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then cmbDeviceName.Items.Add(dev.Name)
                    Next
                End If
            End Using
        Catch ex As Exception
            cmbDeviceName.Items.Add(Device.Name)
        End Try

        cmbDeviceName.SelectedItem = Device.Name
    End Sub
End Class
