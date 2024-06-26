﻿

Imports System.Threading
Imports System.Windows
Imports OpenRGB.NET

Public Class frmMain

    Private wpForms As New List(Of Object)
    Private hiddenAutoStart As Boolean = False
    Private CanClose As Boolean = False

    Public Property CurrentTabIndex() As Integer = 0

    Private explorerPID As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim explorer As Process = Process.GetProcessesByName("explorer").FirstOrDefault
        explorerPID = explorer.Id

        If Not IO.File.Exists(UserSettingFile) Then
            Dim currScreen As New Screen()
            With currScreen
                .Position = System.Windows.Forms.Screen.FromControl(Me).Bounds.Location
                .Size = System.Windows.Forms.Screen.FromControl(Me).Bounds.Size
                .IPAddress = "127.0.0.1"
                .Port = 6742

                Try
                    Using oRgbClient As New OpenRGBClient(name:="Getting devices information")
                        If oRgbClient.Connected Then
                            For Each device In oRgbClient.GetAllControllerData
                                If device.Zones.Where(Function(x) x.MatrixMap IsNot Nothing).Count >= 1 Then .Name = device.Name
                            Next
                            For Each zone In oRgbClient.GetAllControllerData.FirstOrDefault(Function(x) x.Name = .Name).Zones
                                If zone.MatrixMap IsNot Nothing Then .Zone = zone.Name
                            Next
                        End If
                    End Using
                Catch ex As Exception
                    .Name = "Wallpaper1"
                    .Zone = "Wallpaper1"
                End Try

                .Autoconnect = False
                .BackgroundColor = ColorTranslator.ToHtml(Color.Black)
                .Renderer = Renderer.Skia
            End With
            Dim screenList As New List(Of Screen)
            screenList.Add(currScreen)

            Dim newUserSetting As New UserSettingData(UserSettingFile)
            With newUserSetting
                .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                .CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                .InterpolationMode = Drawing2D.InterpolationMode.Bilinear
                .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
                .LEDShape = LEDShape.Rectangle
                .StartWithWindows = False
                .NoToasters = False
                .TimerIntervals = 30
                .LEDPadding = 0
                .StaticEffect = False
                .RGBTrasform = RGBTransform.Slide1
                .RGBPattern = RGBPattern.Rainbow
                .RoundedRectangleCornerRadius = 10
                .AutoPause = True
                .CpuUsagePauseValue = 70
                .AntiAlias = True
                .VSync = True
                .Screens = screenList
                .SaveSilentXml()
            End With
            UserSettings = New UserSettingData(UserSettingFile).InstanceXml
        End If
        If Not IO.File.Exists(UserImageFile) Then
            Dim newUserImage As New ImageData(UserImageFile)
            With newUserImage
                .ImagesLib = New List(Of ImageLib)
                .SaveSilent()
            End With
            UserImage = New ImageData(UserImageFile).Instance
        End If

        cmbSmoothing.DataSource = [Enum].GetValues(GetType(Drawing2D.SmoothingMode)).Cast(Of Drawing2D.SmoothingMode).ToList.Where(Function(x) x <> Drawing2D.SmoothingMode.Invalid).ToArray
        cmbCompositing.DataSource = [Enum].GetValues(GetType(Drawing2D.CompositingQuality)).Cast(Of Drawing2D.CompositingQuality).ToList.Where(Function(x) x <> Drawing2D.CompositingQuality.Invalid).ToArray
        cmbInterpolation.DataSource = [Enum].GetValues(GetType(Drawing2D.InterpolationMode)).Cast(Of Drawing2D.InterpolationMode).ToList.Where(Function(x) x <> Drawing2D.InterpolationMode.Invalid).ToArray
        cmbLedShape.DataSource = [Enum].GetValues(GetType(LEDShape)).Cast(Of LEDShape)
        cmbPixelOffset.DataSource = [Enum].GetValues(GetType(Drawing2D.PixelOffsetMode)).Cast(Of Drawing2D.PixelOffsetMode).ToList.Where(Function(x) x <> Drawing2D.PixelOffsetMode.Invalid).ToArray
        cmbRGBTransform.DataSource = [Enum].GetValues(GetType(RGBTransform)).Cast(Of RGBTransform)
        cmbRGBPattern.DataSource = [Enum].GetValues(GetType(RGBPattern)).Cast(Of RGBPattern)

        cmbSmoothing.SelectedItem = UserSettings.SmoothingMode
        cmbCompositing.SelectedItem = UserSettings.CompositingQuality
        cmbInterpolation.SelectedItem = UserSettings.InterpolationMode
        cmbPixelOffset.SelectedItem = UserSettings.PixelOffsetMode
        cmbLedShape.SelectedItem = UserSettings.LEDShape
        cmbRGBTransform.SelectedItem = UserSettings.RGBTrasform
        cmbRGBPattern.SelectedItem = UserSettings.RGBPattern
        cbNoToaster.Checked = UserSettings.NoToasters
        tbTimerInterval.Value = If(UserSettings.TimerIntervals < 1, 30, UserSettings.TimerIntervals)
        lblTimerInterval.Text = $"Tick Interval ({tbTimerInterval.Value})"
        txtLEDPadding.Text = UserSettings.LEDPadding
        cbStaticEffects.Checked = UserSettings.StaticEffect
        GroupBox2.Enabled = cbStaticEffects.Checked
        cbGrayscaleIcon.Checked = UserSettings.GrayscaleTrayIcon

        txtRoundRectRadius.Text = UserSettings.RoundedRectangleCornerRadius
        numCPUUsageValue.Value = If(UserSettings.CpuUsagePauseValue = 0, 10, UserSettings.CpuUsagePauseValue)
        cbAutoPause.Checked = UserSettings.AutoPause
        cbAutoPause.Text = $"Automatically pause when CPU Usage reaches {numCPUUsageValue.Value}%"

        txtRoundRectRadius.Enabled = (cmbLedShape.SelectedItem = LEDShape.RoundedRectangle)
        numCPUUsageValue.Enabled = cbAutoPause.Checked

        cbVSync.Checked = UserSettings.VSync
        cbAntialias.Checked = UserSettings.AntiAlias

        For Each scr In UserSettings.Screens
            Dim newTab As New TabPage()
            With newTab
                .Text = $"{scr.Name} - {scr.Zone}"
                .AutoScroll = True
                Dim ucScr As New ucScreen
                With ucScr
                    .WScreen = scr
                    .Dock = DockStyle.Fill
                End With
                newTab.Controls.Add(ucScr)
                .Tag = ucScr
            End With
            tcScreen.TabPages.Add(newTab)
        Next
        cbStartAtLogin.Checked = UserSettings.StartWithWindows

        If Not UserSettings.NoToasters Then
            niNotify.Visible = True
            niNotify.ShowBalloonTip(1000)
            niNotify.Text = "OpenRGB Wallpaper"
        End If

        Dim OpenRGB As Process() = Process.GetProcessesByName("OpenRGB")
        If OpenRGB.Length <> 0 Then
            If UserSettings.StaticEffect Then
                Threading.Thread.Sleep(1000)

                If wpForms.Count = 0 Then
                    Threading.Thread.Sleep(1000)
                    SetAsWallpaper(UserSettings.StaticEffect)
                Else
                    For Each form In wpForms
                        form.Reconnect(UserSettings.StaticEffect)
                    Next
                    Timer1.Stop()
                End If
            Else
                Threading.Thread.Sleep(1000)
                SetAsWallpaper()
            End If
        End If

        If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
    End Sub

    Private Sub SetAsWallpaper(Optional WaitForOpenRGB As Boolean = False)
        Dim progman = W32.FindWindow("Progman", Nothing)
        Dim result As IntPtr = IntPtr.Zero
        W32.SendMessageTimeout(progman, &H52C, New IntPtr(0), IntPtr.Zero, W32.SendMessageTimeoutFlags.SMTO_NORMAL, 1000, result)

        Dim workerw As IntPtr = IntPtr.Zero
        W32.EnumWindows(New W32.EnumWindowsProc(Function(tophandle, topparamhandle)
                                                    Dim p As IntPtr = W32.FindWindowEx(tophandle, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)

                                                    If p <> IntPtr.Zero Then
                                                        workerw = W32.FindWindowEx(IntPtr.Zero, tophandle, "WorkerW", IntPtr.Zero)
                                                    End If

                                                    Return True
                                                End Function), IntPtr.Zero)

        'Try

        'Catch ex As Exception
        '    Log(ex)
        'End Try

        For Each screen In UserSettings.Screens
            Select Case screen.Renderer
                Case Renderer.GDI
                    Dim newWP As New frmWallpaperGDI
                    W32.SetParent(newWP.Handle, workerw)
                    wpForms.Add(newWP)
                    With newWP
                        .WScreen = screen
                        .WaitForOpenRGB = WaitForOpenRGB
                        .Text = screen.Name
                        .StartPosition = FormStartPosition.CenterScreen
                        .Location = screen.Position
                        .Size = screen.Size
                        .Timer1.Interval = If(UserSettings.TimerIntervals < 5, 30, UserSettings.TimerIntervals)
                        .Timer1.Enabled = True
                        .Show()
                    End With
                Case Renderer.Skia
                    Dim newWP As New frmWallpaper
                    W32.SetParent(newWP.Handle, workerw)
                    wpForms.Add(newWP)
                    With newWP
                        .WScreen = screen
                        .WaitForOpenRGB = WaitForOpenRGB
                        .Text = screen.Name
                        .StartPosition = FormStartPosition.CenterScreen
                        .Location = screen.Position
                        .Size = screen.Size
                        .Timer1.Interval = If(UserSettings.TimerIntervals < 5, 30, UserSettings.TimerIntervals)
                        .Timer1.Enabled = True
                        .Show()
                    End With
                Case Renderer.OpenGL
                    Dim newWP As New frmWallpaperGL
                    W32.SetParent(newWP.Handle, workerw)
                    wpForms.Add(newWP)
                    With newWP
                        .WScreen = screen
                        .WaitForOpenRGB = WaitForOpenRGB
                        .Text = screen.Name
                        .StartPosition = FormStartPosition.CenterScreen
                        .Location = screen.Position
                        .Size = screen.Size
                        .Timer1.Interval = If(UserSettings.TimerIntervals < 5, 30, UserSettings.TimerIntervals)
                        .Timer1.Enabled = True
                        .Show()
                    End With
            End Select
        Next

        If Not WaitForOpenRGB Then Timer1.Stop()
    End Sub

    Private Sub ResetWallpaper()
        For Each form In wpForms
            If form.oRgbClient IsNot Nothing Then
                If form.oRgbClient.Connected Then form.oRgbClient.Dispose()
                form.Close()
            End If
        Next
        wpForms.Clear()

        SetAsWallpaper()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        CanClose = True

        For Each form In wpForms
            form.Close()
        Next

        Me.Close()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        For Each form In wpForms.Where(Function(x) x.WScreen.Autoconnect = False)
            form.Connect()
        Next
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Visible = False
    End Sub

    Private Sub ReconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReconnectToolStripMenuItem.Click
        For Each form In wpForms
            form.Reconnect()
        Next
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Process.Start("https://github.com/qiangqiang101/OpenRGB-Wallpaper")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim OpenRGB As Process() = Process.GetProcessesByName("OpenRGB")
        If OpenRGB.Length = 0 Then
            If Not UserSettings.NoToasters Then
                niNotify.BalloonTipText = "Waiting OpenRGB process to startup, this might take several seconds."
                niNotify.Visible = True
                niNotify.ShowBalloonTip(1000)
                niNotify.Text = "OpenRGB Wallpaper"
            End If
            Timer1.Interval = 60000

            If UserSettings.StaticEffect Then
                Threading.Thread.Sleep(1000)
                SetAsWallpaper(UserSettings.StaticEffect)
            End If
        Else
            Timer1.Interval = 60000
            If Not UserSettings.NoToasters Then
                niNotify.BalloonTipText = "OpenRGB process found, applying Wallpaper(s)."
                niNotify.Visible = True
                niNotify.ShowBalloonTip(1000)
                niNotify.Text = "OpenRGB Wallpaper"
            End If

            If UserSettings.StaticEffect Then
                Threading.Thread.Sleep(1000)

                If wpForms.Count = 0 Then
                    Threading.Thread.Sleep(1000)
                    SetAsWallpaper(UserSettings.StaticEffect)
                Else
                    For Each form In wpForms
                        form.Reconnect(UserSettings.StaticEffect)
                    Next
                    Timer1.Stop()
                End If
            Else
                Threading.Thread.Sleep(1000)
                SetAsWallpaper()
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

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Visible = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newUserSetting As New UserSettingData
        With newUserSetting
            .FileName = UserSettingFile
            .SmoothingMode = cmbSmoothing.SelectedItem
            .CompositingQuality = cmbCompositing.SelectedItem
            .InterpolationMode = cmbInterpolation.SelectedItem
            .PixelOffsetMode = cmbPixelOffset.SelectedItem
            .LEDShape = cmbLedShape.SelectedItem
            .NoToasters = cbNoToaster.Checked
            .TimerIntervals = tbTimerInterval.Value
            .LEDPadding = CInt(txtLEDPadding.Text)
            .StaticEffect = cbStaticEffects.Checked
            .RGBPattern = cmbRGBPattern.SelectedItem
            .RGBTrasform = cmbRGBTransform.SelectedItem
            Dim newScreenList As New List(Of Screen)
            For Each tp As TabPage In tcScreen.TabPages
                Dim uc As ucScreen = tp.Tag
                newScreenList.Add(uc.WScreen)
            Next
            .Screens = newScreenList
            .StartWithWindows = cbStartAtLogin.Checked
            .RoundedRectangleCornerRadius = CInt(txtRoundRectRadius.Text)
            .AutoPause = cbAutoPause.Checked
            .CpuUsagePauseValue = CInt(numCPUUsageValue.Value)
            .GrayscaleTrayIcon = cbGrayscaleIcon.Checked
            .VSync = cbVSync.Checked
            .AntiAlias = cbAntialias.Checked
            .SaveXml()
        End With

        UserSettings = New UserSettingData(UserSettingFile).InstanceXml

        If hiddenAutoStart Then
            If cbStartAtLogin.Checked Then CreateShortcutInStartUp() Else DeleteShortcutInStartup()
        End If

        ResetWallpaper()
        If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall

        Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Visible = False
    End Sub

    Private Sub btnAddScreen_Click(sender As Object, e As EventArgs) Handles btnAddScreen.Click
        Dim newTab As New TabPage()
        With newTab
            .Text = $"Wallpaper{UserSettings.Screens.Count + 1}"
            .AutoScroll = True
            Dim ucScr As New ucScreen
            With ucScr
                .WScreen = New Screen() With {.Autoconnect = False, .IPAddress = "127.0.0.1", .Name = $"Wallpaper{UserSettings.Screens.Count + 1}", .Port = 6742,
                    .Position = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Location, .Size = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size}
                .Dock = DockStyle.Fill
            End With
            newTab.Controls.Add(ucScr)
            .Tag = ucScr
        End With
        tcScreen.TabPages.Add(newTab)
    End Sub

    Private Sub tcScreen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcScreen.SelectedIndexChanged
        CurrentTabIndex = tcScreen.SelectedIndex
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        For Each form In wpForms
            form.IsPaused = Not form.IsPaused
        Next

        If wpForms.FirstOrDefault.IsPaused Then PauseToolStripMenuItem.Text = "Play" Else PauseToolStripMenuItem.Text = "Pause"
    End Sub

    Private Sub cbStartAtLogin_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartAtLogin.CheckedChanged
        hiddenAutoStart = True
    End Sub

    Private Sub tbTimerInterval_Scroll(sender As Object, e As EventArgs) Handles tbTimerInterval.Scroll
        lblTimerInterval.Text = $"Tick Interval ({tbTimerInterval.Value})"
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim newUserSetting As New UserSettingData
        With newUserSetting
            .FileName = UserSettingFile
            .SmoothingMode = cmbSmoothing.SelectedItem
            .CompositingQuality = cmbCompositing.SelectedItem
            .InterpolationMode = cmbInterpolation.SelectedItem
            .PixelOffsetMode = cmbPixelOffset.SelectedItem
            .LEDShape = cmbLedShape.SelectedItem
            .NoToasters = cbNoToaster.Checked
            .TimerIntervals = tbTimerInterval.Value
            .LEDPadding = CInt(txtLEDPadding.Text)
            .StaticEffect = cbStaticEffects.Checked
            .RGBPattern = cmbRGBPattern.SelectedItem
            .RGBTrasform = cmbRGBTransform.SelectedItem
            Dim newScreenList As New List(Of Screen)
            For Each tp As TabPage In tcScreen.TabPages
                Dim uc As ucScreen = tp.Tag
                newScreenList.Add(uc.WScreen)
            Next
            .Screens = newScreenList
            .StartWithWindows = cbStartAtLogin.Checked
            .RoundedRectangleCornerRadius = CInt(txtRoundRectRadius.Text)
            .AutoPause = cbAutoPause.Checked
            .CpuUsagePauseValue = CInt(numCPUUsageValue.Value)
            .GrayscaleTrayIcon = cbGrayscaleIcon.Checked
            .VSync = cbVSync.Checked
            .AntiAlias = cbAntialias.Checked
            .SaveSilentXml()
        End With

        UserSettings = New UserSettingData(UserSettingFile).InstanceXml

        If hiddenAutoStart Then
            If cbStartAtLogin.Checked Then CreateShortcutInStartUp() Else DeleteShortcutInStartup()
        End If

        ResetWallpaper()
        If UserSettings.GrayscaleTrayIcon Then niNotify.Icon = My.Resources.orgbwico Else niNotify.Icon = My.Resources.openrgbwall
    End Sub

    Private Sub cbStaticEffects_CheckedChanged(sender As Object, e As EventArgs) Handles cbStaticEffects.CheckedChanged
        GroupBox2.Enabled = cbStaticEffects.Checked
    End Sub

    Private Sub cbAutoPause_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoPause.CheckedChanged
        numCPUUsageValue.Enabled = cbAutoPause.Checked
    End Sub

    Private Sub cmbLedShape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLedShape.SelectedIndexChanged
        txtRoundRectRadius.Enabled = (cmbLedShape.SelectedItem = LEDShape.RoundedRectangle)
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.WindowsShutDown Then Return

        If Not CanClose Then
            e.Cancel = True
            Visible = False
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("https://imnotmental.com/")
    End Sub

    Private Sub numCPUUsageValue_ValueChanged(sender As Object, e As EventArgs) Handles numCPUUsageValue.ValueChanged
        cbAutoPause.Text = $"Automatically pause when CPU Usage reaches {numCPUUsageValue.Value}%"
    End Sub

    Private Sub niNotify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles niNotify.MouseDoubleClick
        Visible = True
    End Sub
End Class