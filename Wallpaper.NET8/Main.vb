Imports System.IO
Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports OpenRGB.NET

Public Class Main

    Private wpForms As New List(Of Wallpaper)
    Private hiddenAutoStart As Boolean = False
    Private canClose As Boolean = False
    Private explorerPID As Integer = 0
    Private defaultWallpaper As String

    Public Property CurrentTabIndex() As Integer = 0

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        defaultWallpaper = GetDesktopWallpaper()

        Dim explorer As Process = Process.GetProcessesByName("explorer").FirstOrDefault
        explorerPID = explorer.Id

        If Not File.Exists(UserSettingFile) Then
            Dim currScreen As New E131Device()
            With currScreen
                .Position = Screen.FromControl(Me).Bounds.Location
                .Size = Screen.FromControl(Me).Bounds.Size

                Try
                    Using oRGBClient As New OpenRgbClient(name:=Translation.Localization.GettingDevicesInformation)
                        If oRGBClient.Connected Then
                            For Each device In oRGBClient.GetAllControllerData
                                If device.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then .Name = device.Name
                            Next
                            For Each zone In oRGBClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = .Name).Zones
                                If zone.MatrixMap IsNot Nothing Then .Zone = zone.Name
                            Next
                        End If
                    End Using
                Catch ex As Exception
                    .Name = "Wallpaper1"
                    .Zone = "Wallpaper1"
                End Try

                .BackgroundColor = ColorTranslator.ToHtml(Drawing.Color.Black)
            End With
            Dim deviceList As New List(Of E131Device)
            deviceList.Add(currScreen)

            Dim newUserSetting As New UserSetting()
            With newUserSetting
                .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                .CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                .InterpolationMode = Drawing2D.InterpolationMode.Bilinear
                .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
                .LEDShape = LEDShape.Rectangle
                .RoundedRectangleCornerRadius = 10
                .LEDPadding = 0
                .TimerIntervals = 30
                .StartWithWindows = False
                .StartMinimized = True
                .RestoreWallpaperWhenExit = False
                .NoToasters = False
                .AutoPause = True
                .CPUUsagePauseValue = 70
                .GrayscaleTrayIcon = False
                .Language = "en-US"
                .Port = 6742
                .AutoConnect = False
                .E131Devices = deviceList
                .Save(UserSettingFile, True)
            End With
            UserSettings = newUserSetting
        Else
            UserSettings = New UserSetting().Load(UserSettingFile)
        End If

        Translate()
        cmbSmoothing.DataSource = [Enum].GetValues(GetType(Drawing2D.SmoothingMode)).Cast(Of Drawing2D.SmoothingMode).ToList.Where(Function(x) x <> Drawing2D.SmoothingMode.Invalid).ToArray
        cmbCompositing.DataSource = [Enum].GetValues(GetType(Drawing2D.CompositingQuality)).Cast(Of Drawing2D.CompositingQuality).ToList.Where(Function(x) x <> Drawing2D.CompositingQuality.Invalid).ToArray
        cmbInterpolation.DataSource = [Enum].GetValues(GetType(Drawing2D.InterpolationMode)).Cast(Of Drawing2D.InterpolationMode).ToList.Where(Function(x) x <> Drawing2D.InterpolationMode.Invalid).ToArray
        cmbLedShape.DataSource = [Enum].GetValues(GetType(LEDShape)).Cast(Of LEDShape)
        cmbPixelOffset.DataSource = [Enum].GetValues(GetType(Drawing2D.PixelOffsetMode)).Cast(Of Drawing2D.PixelOffsetMode).ToList.Where(Function(x) x <> Drawing2D.PixelOffsetMode.Invalid).ToArray
        With cmbLanguage
            .DataSource = LanguageDropdownList
            .DisplayMember = "Text"
            .ValueMember = "Value"
        End With

        cmbSmoothing.SelectedItem = UserSettings.SmoothingMode
        cmbCompositing.SelectedItem = UserSettings.CompositingQuality
        cmbInterpolation.SelectedItem = UserSettings.InterpolationMode
        cmbPixelOffset.SelectedItem = UserSettings.PixelOffsetMode
        cmbLedShape.SelectedItem = UserSettings.LEDShape
        cbNoToaster.Checked = UserSettings.NoToasters
        tbTimerInterval.Value = If(UserSettings.TimerIntervals < 1, 30, UserSettings.TimerIntervals)
        lblRI.Value2 = $"{tbTimerInterval.Value}ms"
        nudLEDPadding.Value = UserSettings.LEDPadding
        cbGrayscaleIcon.Checked = UserSettings.GrayscaleTrayIcon
        nudRoundRectRadius.Value = UserSettings.RoundedRectangleCornerRadius
        nudCPUUsageValue.Value = If(UserSettings.CPUUsagePauseValue = 0, 10, UserSettings.CPUUsagePauseValue)
        cbAutoPause.Checked = UserSettings.AutoPause
        lblPWCUR.Value2 = String.Format(Translation.Localization._pct, CInt(nudCPUUsageValue.Value))
        cmbLanguage.SelectedValue = UserSettings.Language
        nudRoundRectRadius.Enabled = (cmbLedShape.SelectedItem = LEDShape.RoundedRectangle)
        nudCPUUsageValue.Enabled = cbAutoPause.Checked
        cbStartAtLogin.Checked = UserSettings.StartWithWindows
        cbStartMinimized.Checked = UserSettings.StartMinimized
        cbRestoreWallpaper.Checked = UserSettings.RestoreWallpaperWhenExit
        nudPort.Value = UserSettings.Port
        cbAutoconnect.Checked = UserSettings.AutoConnect

        For Each device In UserSettings.E131Devices
            Dim newTab As New TabPage
            With newTab
                .Text = If(device.Name = device.Zone, device.Name, $"{device.Name} - {device.Zone}")
                .AutoScroll = True
                Dim dev As New Device
                With dev
                    .Device = device
                    .Dock = DockStyle.Fill
                End With
                newTab.Controls.Add(dev)
                .Tag = dev
            End With
            tcDevices.TabPages.Add(newTab)
        Next

        If Not UserSettings.NoToasters Then
            niNotify.Visible = True
            niNotify.ShowBalloonTip(1000)
            niNotify.Text = Translation.Localization.OpenRGBWallpaper2
            If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
        End If

        Dim OpenRGB As Process() = Process.GetProcessesByName("OpenRGB")
        If OpenRGB.Length <> 0 Then
            Threading.Thread.Sleep(1000)
            SetAsWallpaper()
        End If
    End Sub

    Private Sub SetAsWallpaper(Optional waitForOpenRGB As Boolean = False)
        Dim progman = Win32Wrapper.FindWindow("Progman", Nothing)
        Dim result As IntPtr = IntPtr.Zero
        Win32Wrapper.SendMessageTimeout(progman, &H52C, New IntPtr(0), IntPtr.Zero, Win32Wrapper.SendMessageTimeoutFlags.SMTO_NORMAL, 1000, result)

        Dim workerw As IntPtr = IntPtr.Zero
        Win32Wrapper.EnumWindows(New Win32Wrapper.EnumWindowsProc(Function(tophandle, topparamhandle)
                                                                      Dim p As IntPtr = Win32Wrapper.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)

                                                                      If p <> IntPtr.Zero Then
                                                                          workerw = Win32Wrapper.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", IntPtr.Zero)
                                                                      End If

                                                                      Return True
                                                                  End Function), IntPtr.Zero)

        For Each device In UserSettings.E131Devices
            Dim newWP As New Wallpaper
            Win32Wrapper.SetParent(newWP.Handle, workerw)
            wpForms.Add(newWP)
            With newWP
                .Device = device
                .WaitForOpenRGB = waitForOpenRGB
                .Text = device.Name
                .StartPosition = FormStartPosition.CenterScreen
                .Location = device.Position
                .Size = device.Size
                .tmUpdate.Interval = If(UserSettings.TimerIntervals < 5, 30, UserSettings.TimerIntervals)
                .tmUpdate.Enabled = True
                .Show()
            End With
        Next

        If Not waitForOpenRGB Then Timer1.Stop()
    End Sub

    Private Sub ResetWallpaper()
        For Each form In wpForms
            If form.oRGBClient IsNot Nothing Then
                If form.oRgbClient.Connected Then form.oRgbClient.Dispose()
                form.Close()
            End If
        Next
        wpForms.Clear()

        SetAsWallpaper()
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles tsmiExit.Click
        canClose = True

        If UserSettings.RestoreWallpaperWhenExit Then
            For Each form In wpForms
                form.Close()
            Next
            SetDesktopWallpaper(defaultWallpaper)
        End If

        Close()
    End Sub

    Private Sub tsmiConnect_Click(sender As Object, e As EventArgs) Handles tsmiConnect.Click
        If UserSettings.AutoConnect Then
            For Each form In wpForms
                form.Connect()
            Next
        End If
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If UserSettings.StartMinimized Then Visible = False
    End Sub

    Private Sub tsmiReconnect_Click(sender As Object, e As EventArgs) Handles tsmiReconnect.Click
        For Each form In wpForms
            form.Reconnect()
        Next
    End Sub

    Private Sub tsmiHelp_Click(sender As Object, e As EventArgs) Handles tsmiHelp.Click
        Process.Start(New ProcessStartInfo With {.FileName = "https://github.com/qiangqiang101/OpenRGB-Wallpaper", .UseShellExecute = True})
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim OpenRGB As Process() = Process.GetProcessesByName("OpenRGB")
        If OpenRGB.Length = 0 Then
            If Not UserSettings.NoToasters Then
                niNotify.BalloonTipText = Translation.Localization.WaitingOpenRGBProcess
                niNotify.Visible = True
                niNotify.ShowBalloonTip(1000)
                niNotify.Text = Translation.Localization.OpenRGBWallpaper2
                If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
            End If
            Timer1.Interval = 60000
        Else
            Timer1.Interval = 60000
            If Not UserSettings.NoToasters Then
                niNotify.BalloonTipText = Translation.Localization.OpenRGBProcessFound
                niNotify.Visible = True
                niNotify.ShowBalloonTip(1000)
                niNotify.Text = Translation.Localization.OpenRGBWallpaper2
                If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim OpenRGB As Process() = Process.GetProcessesByName("OpenRGB")
        Dim explorer As Process = Process.GetProcessesByName("explorer").FirstOrDefault
        If explorer.Id <> explorerPID Then
            If Not OpenRGB.Length = 0 Then
                ResetWallpaper()
                explorerPID = explorer.Id
            End If
        End If
    End Sub

    Private Sub tsmiSettings_Click(sender As Object, e As EventArgs) Handles tsmiSettings.Click
        Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newDeviceList As New List(Of E131Device)
        For Each tp As TabPage In tcDevices.TabPages
            Dim dev As Device = tp.Tag
            newDeviceList.Add(dev.Device)
        Next

        Dim newUserSetting As New UserSetting
        With newUserSetting
            .SmoothingMode = cmbSmoothing.SelectedItem
            .CompositingQuality = cmbCompositing.SelectedItem
            .InterpolationMode = cmbInterpolation.SelectedItem
            .PixelOffsetMode = cmbPixelOffset.SelectedItem
            .LEDShape = cmbLedShape.SelectedItem
            .RoundedRectangleCornerRadius = CInt(nudRoundRectRadius.Value)
            .LEDPadding = CInt(nudLEDPadding.Value)
            .TimerIntervals = tbTimerInterval.Value
            .StartWithWindows = cbStartAtLogin.Checked
            .StartMinimized = cbStartMinimized.Checked
            .RestoreWallpaperWhenExit = cbRestoreWallpaper.Checked
            .NoToasters = cbNoToaster.Checked
            .AutoPause = cbAutoPause.Checked
            .CPUUsagePauseValue = CInt(nudCPUUsageValue.Value)
            .GrayscaleTrayIcon = cbGrayscaleIcon.Checked
            .Language = cmbLanguage.SelectedValue
            .Port = CInt(nudPort.Value)
            .AutoConnect = cbAutoconnect.Checked
            .E131Devices = newDeviceList
            .Save(UserSettingFile, False)
        End With
        UserSettings = newUserSetting

        If hiddenAutoStart Then
            If cbStartAtLogin.Checked Then CreateShortcutInStartUp() Else DeleteShortcutInStartup()
        End If

        ResetWallpaper()
        If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
        If UserSettings.Language <> Translation.Name Then
            Translate(True)
            For Each tp As TabPage In tcDevices.TabPages
                Dim device As Device = tp.Tag
                device.Translate(True)
            Next
        End If

        Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Visible = False
    End Sub

    Private Sub btnAddScreen_Click(sender As Object, e As EventArgs) Handles btnAddScreen.Click
        Dim newTab As New TabPage()
        With newTab
            .Text = $"Wallpaper{UserSettings.E131Devices.Count + 1}"
            .AutoScroll = True
            Dim dev As New Device
            With dev
                .Device = New E131Device() With {.Name = $"Wallpaper{UserSettings.E131Devices.Count + 1}", .Position = Screen.PrimaryScreen.Bounds.Location, .Size = Screen.PrimaryScreen.Bounds.Size}
                .Dock = DockStyle.Fill
            End With
            newTab.Controls.Add(dev)
            .Tag = dev
        End With
        tcDevices.TabPages.Add(newTab)
    End Sub

    Private Sub tcDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcDevices.SelectedIndexChanged
        CurrentTabIndex = tcDevices.SelectedIndex
    End Sub

    Private Sub tsmiPause_Click(sender As Object, e As EventArgs) Handles tsmiPause.Click
        For Each form In wpForms
            form.IsPaused = Not form.IsPaused
        Next

        If wpForms.FirstOrDefault.IsPaused Then tsmiPause.Text = Translation.Localization.Play Else tsmiPause.Text = Translation.Localization.Pause
    End Sub

    Private Sub cbStartAtLogin_CheckedChanged(sender As Object) Handles cbStartAtLogin.CheckedChanged
        hiddenAutoStart = True
    End Sub

    Private Sub tbTimerInterval_Scroll(sender As Object) Handles tbTimerInterval.Scroll
        lblRI.Value2 = String.Format(Translation.Localization._ms, tbTimerInterval.Value)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim newDeviceList As New List(Of E131Device)
        For Each tp As TabPage In tcDevices.TabPages
            Dim dev As Device = tp.Tag
            newDeviceList.Add(dev.Device)
        Next

        Dim newUserSetting As New UserSetting
        With newUserSetting
            .SmoothingMode = cmbSmoothing.SelectedItem
            .CompositingQuality = cmbCompositing.SelectedItem
            .InterpolationMode = cmbInterpolation.SelectedItem
            .PixelOffsetMode = cmbPixelOffset.SelectedItem
            .LEDShape = cmbLedShape.SelectedItem
            .RoundedRectangleCornerRadius = CInt(nudRoundRectRadius.Value)
            .LEDPadding = CInt(nudLEDPadding.Value)
            .TimerIntervals = tbTimerInterval.Value
            .StartWithWindows = cbStartAtLogin.Checked
            .StartMinimized = cbStartMinimized.Checked
            .RestoreWallpaperWhenExit = cbRestoreWallpaper.Checked
            .NoToasters = cbNoToaster.Checked
            .AutoPause = cbAutoPause.Checked
            .CPUUsagePauseValue = CInt(nudCPUUsageValue.Value)
            .GrayscaleTrayIcon = cbGrayscaleIcon.Checked
            .Language = cmbLanguage.SelectedValue
            .Port = CInt(nudPort.Value)
            .AutoConnect = cbAutoconnect.Checked
            .E131Devices = newDeviceList
            .Save(UserSettingFile, True)
        End With
        UserSettings = newUserSetting

        If hiddenAutoStart Then
            If cbStartAtLogin.Checked Then CreateShortcutInStartUp() Else DeleteShortcutInStartup()
        End If

        ResetWallpaper()
        If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
        If UserSettings.Language <> Translation.Name Then
            Translate(True)
            For Each tp As TabPage In tcDevices.TabPages
                Dim device As Device = tp.Tag
                device.Translate(True)
            Next
        End If
    End Sub

    Private Sub cbAutoPause_CheckedChanged(sender As Object) Handles cbAutoPause.CheckedChanged
        nudCPUUsageValue.Enabled = cbAutoPause.Checked
    End Sub

    Private Sub cmbLedShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLedShape.SelectedIndexChanged
        nudRoundRectRadius.Enabled = (cmbLedShape.SelectedItem = LEDShape.RoundedRectangle)
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.WindowsShutDown Then Return

        If Not canClose Then
            e.Cancel = True
            Visible = False
        End If
    End Sub

    Private Sub nudCPUUsageValue_ValueChanged(sender As Object, e As EventArgs) Handles nudCPUUsageValue.ValueChanged
        lblPWCUR.Value2 = String.Format(Translation.Localization._pct, CInt(nudCPUUsageValue.Value))
    End Sub

    Private Sub niNotify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niNotify.MouseDoubleClick
        Visible = True
    End Sub

    Private Sub Translate(Optional invalidate As Boolean = False)
        If File.Exists($"{UserSettings.Language}.json") Then
            Translation = New Language().Load($"{UserSettings.Language}.json")
            Dim loc = Translation.Localization

            Text = loc.OpenRGBWallpaper2
            NsTheme1.Text = Text
            niNotify.BalloonTipTitle = Text
            niNotify.Text = Text

            gbGraphics.Title = loc.GraphicsSettings
            lblSM.Value1 = loc.SmoothingMode
            lblCQ.Value1 = loc.CompositingQuality
            lblIM.Value1 = loc.InterpolationMode
            lblPOM.Value1 = loc.PixelOffsetMode
            lblLS.Value1 = loc.LEDShape
            lblRRR.Value1 = loc.RoundedRectangleRadius
            lblLP.Value1 = loc.LEDPadding
            lblRI.Value1 = loc.RefreshInterval
            lblRI.Value2 = String.Format(loc._ms, tbTimerInterval.Value)
            gbGeneral.Title = loc.GeneralSettings
            lblSWW.Value1 = loc.StartWithWindows
            lblSMz.Value1 = loc.StartMinimized
            lblRWWE.Value1 = loc.RestoreWallpaperWhenExit
            lblDN.Value1 = loc.DisableNotifications
            lblPWCUR.Value1 = loc.PauseWhenCPUUsageReaches
            lblPWCUR.Value2 = String.Format(loc._pct, CInt(nudCPUUsageValue.Value))
            lblCUPV.Value1 = loc.CPUUsagePauseValue
            lblGTI.Value1 = loc.GrayscaleTrayIcon
            lblLang.Value1 = loc.Language
            lblPort.Value1 = loc.SDKPort
            lblAutoconnect.Value1 = loc.AutoConnectToSDKServer
            gbDevice.Title = loc.DeviceSettings
            gbDevice.SubTitle = loc.WallpaperDevices
            btnAddScreen.Text = loc.AddDevice
            lblMentaL.Value1 = loc.MadeWithHeartBy
            btnApply.Text = loc.Apply
            btnSave.Text = loc.SaveChanges
            btnCancel.Text = loc.Cancel
            niNotify.BalloonTipText = loc.YouCanAccessSettings
            tsmiConnect.Text = loc.Connect
            tsmiReconnect.Text = loc.Reconnect
            tsmiPause.Text = loc.Pause
            tsmiSettings.Text = loc.Settings
            tsmiHelp.Text = loc.Help
            tsmiExit.Text = loc.Exit

            If invalidate Then
                btnAddScreen.Invalidate()
                btnApply.Invalidate()
                btnSave.Invalidate()
                btnCancel.Invalidate()
            End If
        End If
    End Sub
End Class
