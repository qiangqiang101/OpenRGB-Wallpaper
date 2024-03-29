﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.niNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.taskbarMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPixelOffset = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbInterpolation = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCompositing = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSmoothing = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRoundRectRadius = New Wallpaper.NumBox(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLEDPadding = New Wallpaper.NumBox(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLedShape = New System.Windows.Forms.ComboBox()
        Me.lblTimerInterval = New System.Windows.Forms.Label()
        Me.tbTimerInterval = New System.Windows.Forms.TrackBar()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tcScreen = New System.Windows.Forms.TabControl()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddScreen = New System.Windows.Forms.Button()
        Me.cbStartAtLogin = New System.Windows.Forms.CheckBox()
        Me.cbNoToaster = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRGBPattern = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbRGBTransform = New System.Windows.Forms.ComboBox()
        Me.cbStaticEffects = New System.Windows.Forms.CheckBox()
        Me.cbAutoPause = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numCPUUsageValue = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cbGrayscaleIcon = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbAntialias = New System.Windows.Forms.CheckBox()
        Me.cbVSync = New System.Windows.Forms.CheckBox()
        Me.taskbarMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbTimerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numCPUUsageValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'niNotify
        '
        Me.niNotify.BalloonTipText = "You can access setting by right clicking the icon."
        Me.niNotify.BalloonTipTitle = "OpenRGB Wallpaper"
        Me.niNotify.ContextMenuStrip = Me.taskbarMenu
        Me.niNotify.Icon = CType(resources.GetObject("niNotify.Icon"), System.Drawing.Icon)
        Me.niNotify.Visible = True
        '
        'taskbarMenu
        '
        Me.taskbarMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.ReconnectToolStripMenuItem, Me.PauseToolStripMenuItem, Me.ToolStripSeparator1, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.taskbarMenu.Name = "taskbarMenu"
        Me.taskbarMenu.Size = New System.Drawing.Size(131, 148)
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'ReconnectToolStripMenuItem
        '
        Me.ReconnectToolStripMenuItem.Name = "ReconnectToolStripMenuItem"
        Me.ReconnectToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ReconnectToolStripMenuItem.Text = "Reconnect"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(127, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbPixelOffset)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbInterpolation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCompositing)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSmoothing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graphics Settings GDI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Pixel Offset Mode"
        '
        'cmbPixelOffset
        '
        Me.cmbPixelOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPixelOffset.FormattingEnabled = True
        Me.cmbPixelOffset.Location = New System.Drawing.Point(177, 109)
        Me.cmbPixelOffset.Name = "cmbPixelOffset"
        Me.cmbPixelOffset.Size = New System.Drawing.Size(160, 23)
        Me.cmbPixelOffset.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Interpolation Mode"
        '
        'cmbInterpolation
        '
        Me.cmbInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInterpolation.FormattingEnabled = True
        Me.cmbInterpolation.Location = New System.Drawing.Point(177, 80)
        Me.cmbInterpolation.Name = "cmbInterpolation"
        Me.cmbInterpolation.Size = New System.Drawing.Size(160, 23)
        Me.cmbInterpolation.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Compositing Quality"
        '
        'cmbCompositing
        '
        Me.cmbCompositing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompositing.FormattingEnabled = True
        Me.cmbCompositing.Location = New System.Drawing.Point(177, 51)
        Me.cmbCompositing.Name = "cmbCompositing"
        Me.cmbCompositing.Size = New System.Drawing.Size(160, 23)
        Me.cmbCompositing.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Smoothing Mode"
        '
        'cmbSmoothing
        '
        Me.cmbSmoothing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSmoothing.FormattingEnabled = True
        Me.cmbSmoothing.Location = New System.Drawing.Point(177, 22)
        Me.cmbSmoothing.Name = "cmbSmoothing"
        Me.cmbSmoothing.Size = New System.Drawing.Size(160, 23)
        Me.cmbSmoothing.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Rounded Rectangle Radius"
        '
        'txtRoundRectRadius
        '
        Me.txtRoundRectRadius.Location = New System.Drawing.Point(177, 51)
        Me.txtRoundRectRadius.Name = "txtRoundRectRadius"
        Me.txtRoundRectRadius.Size = New System.Drawing.Size(80, 23)
        Me.txtRoundRectRadius.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "LED Padding"
        '
        'txtLEDPadding
        '
        Me.txtLEDPadding.Location = New System.Drawing.Point(177, 80)
        Me.txtLEDPadding.Name = "txtLEDPadding"
        Me.txtLEDPadding.Size = New System.Drawing.Size(80, 23)
        Me.txtLEDPadding.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "LED Shape"
        '
        'cmbLedShape
        '
        Me.cmbLedShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLedShape.FormattingEnabled = True
        Me.cmbLedShape.Location = New System.Drawing.Point(177, 22)
        Me.cmbLedShape.Name = "cmbLedShape"
        Me.cmbLedShape.Size = New System.Drawing.Size(160, 23)
        Me.cmbLedShape.TabIndex = 4
        '
        'lblTimerInterval
        '
        Me.lblTimerInterval.AutoSize = True
        Me.lblTimerInterval.Location = New System.Drawing.Point(6, 122)
        Me.lblTimerInterval.Name = "lblTimerInterval"
        Me.lblTimerInterval.Size = New System.Drawing.Size(87, 15)
        Me.lblTimerInterval.TabIndex = 8
        Me.lblTimerInterval.Text = "Tick Interval (0)"
        '
        'tbTimerInterval
        '
        Me.tbTimerInterval.Location = New System.Drawing.Point(177, 109)
        Me.tbTimerInterval.Maximum = 200
        Me.tbTimerInterval.Minimum = 1
        Me.tbTimerInterval.Name = "tbTimerInterval"
        Me.tbTimerInterval.Size = New System.Drawing.Size(160, 45)
        Me.tbTimerInterval.TabIndex = 7
        Me.tbTimerInterval.TickFrequency = 10
        Me.tbTimerInterval.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tbTimerInterval.Value = 10
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(494, 724)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 25)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tcScreen
        '
        Me.tcScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcScreen.Location = New System.Drawing.Point(358, 9)
        Me.tcScreen.Margin = New System.Windows.Forms.Padding(0)
        Me.tcScreen.Name = "tcScreen"
        Me.tcScreen.SelectedIndex = 0
        Me.tcScreen.Size = New System.Drawing.Size(342, 681)
        Me.tcScreen.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(599, 724)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 25)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddScreen
        '
        Me.btnAddScreen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddScreen.Location = New System.Drawing.Point(359, 693)
        Me.btnAddScreen.Name = "btnAddScreen"
        Me.btnAddScreen.Size = New System.Drawing.Size(99, 25)
        Me.btnAddScreen.TabIndex = 13
        Me.btnAddScreen.Text = "+ Add Screen"
        Me.btnAddScreen.UseVisualStyleBackColor = True
        '
        'cbStartAtLogin
        '
        Me.cbStartAtLogin.AutoSize = True
        Me.cbStartAtLogin.Location = New System.Drawing.Point(12, 383)
        Me.cbStartAtLogin.Name = "cbStartAtLogin"
        Me.cbStartAtLogin.Size = New System.Drawing.Size(128, 19)
        Me.cbStartAtLogin.TabIndex = 3
        Me.cbStartAtLogin.Text = "Start with Windows"
        Me.cbStartAtLogin.UseVisualStyleBackColor = True
        '
        'cbNoToaster
        '
        Me.cbNoToaster.AutoSize = True
        Me.cbNoToaster.Location = New System.Drawing.Point(12, 408)
        Me.cbNoToaster.Name = "cbNoToaster"
        Me.cbNoToaster.Size = New System.Drawing.Size(135, 19)
        Me.cbNoToaster.TabIndex = 4
        Me.cbNoToaster.Text = "Disable Notifications"
        Me.cbNoToaster.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 737)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Made with ❤ by Bartholomew ""Not MentaL"" Ho"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(389, 724)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(99, 25)
        Me.btnApply.TabIndex = 10
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbRGBPattern)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbRGBTransform)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 538)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 82)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Static Effects (Only work when not connected to OpenRGB)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "RGB Pattern"
        '
        'cmbRGBPattern
        '
        Me.cmbRGBPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRGBPattern.FormattingEnabled = True
        Me.cmbRGBPattern.Location = New System.Drawing.Point(177, 51)
        Me.cmbRGBPattern.Name = "cmbRGBPattern"
        Me.cmbRGBPattern.Size = New System.Drawing.Size(160, 23)
        Me.cmbRGBPattern.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "RGB Transform"
        '
        'cmbRGBTransform
        '
        Me.cmbRGBTransform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRGBTransform.FormattingEnabled = True
        Me.cmbRGBTransform.Location = New System.Drawing.Point(177, 22)
        Me.cmbRGBTransform.Name = "cmbRGBTransform"
        Me.cmbRGBTransform.Size = New System.Drawing.Size(160, 23)
        Me.cmbRGBTransform.TabIndex = 1
        '
        'cbStaticEffects
        '
        Me.cbStaticEffects.AutoSize = True
        Me.cbStaticEffects.Location = New System.Drawing.Point(12, 513)
        Me.cbStaticEffects.Name = "cbStaticEffects"
        Me.cbStaticEffects.Size = New System.Drawing.Size(131, 19)
        Me.cbStaticEffects.TabIndex = 8
        Me.cbStaticEffects.Text = "Enable Static Effects"
        Me.cbStaticEffects.UseVisualStyleBackColor = True
        '
        'cbAutoPause
        '
        Me.cbAutoPause.AutoSize = True
        Me.cbAutoPause.Location = New System.Drawing.Point(12, 433)
        Me.cbAutoPause.Name = "cbAutoPause"
        Me.cbAutoPause.Size = New System.Drawing.Size(292, 19)
        Me.cbAutoPause.TabIndex = 5
        Me.cbAutoPause.Text = "Automatically pause when CPU Usage reaches N%"
        Me.cbAutoPause.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 461)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "CPU Usage Pause Value"
        '
        'numCPUUsageValue
        '
        Me.numCPUUsageValue.Location = New System.Drawing.Point(189, 459)
        Me.numCPUUsageValue.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCPUUsageValue.Name = "numCPUUsageValue"
        Me.numCPUUsageValue.Size = New System.Drawing.Size(80, 23)
        Me.numCPUUsageValue.TabIndex = 6
        Me.numCPUUsageValue.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(275, 461)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 15)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "%"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'cbGrayscaleIcon
        '
        Me.cbGrayscaleIcon.AutoSize = True
        Me.cbGrayscaleIcon.Location = New System.Drawing.Point(12, 488)
        Me.cbGrayscaleIcon.Name = "cbGrayscaleIcon"
        Me.cbGrayscaleIcon.Size = New System.Drawing.Size(126, 19)
        Me.cbGrayscaleIcon.TabIndex = 7
        Me.cbGrayscaleIcon.Text = "Grayscale Tray Icon"
        Me.cbGrayscaleIcon.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbLedShape)
        Me.GroupBox3.Controls.Add(Me.txtRoundRectRadius)
        Me.GroupBox3.Controls.Add(Me.tbTimerInterval)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblTimerInterval)
        Me.GroupBox3.Controls.Add(Me.txtLEDPadding)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 163)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Graphics Settings Global"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbAntialias)
        Me.GroupBox4.Controls.Add(Me.cbVSync)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 48)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Graphics Settings Skia && OpenGL"
        '
        'cbAntialias
        '
        Me.cbAntialias.AutoSize = True
        Me.cbAntialias.Location = New System.Drawing.Point(177, 22)
        Me.cbAntialias.Name = "cbAntialias"
        Me.cbAntialias.Size = New System.Drawing.Size(93, 19)
        Me.cbAntialias.TabIndex = 1
        Me.cbAntialias.Text = "Anti-aliasing"
        Me.cbAntialias.UseVisualStyleBackColor = True
        '
        'cbVSync
        '
        Me.cbVSync.AutoSize = True
        Me.cbVSync.Location = New System.Drawing.Point(6, 22)
        Me.cbVSync.Name = "cbVSync"
        Me.cbVSync.Size = New System.Drawing.Size(58, 19)
        Me.cbVSync.TabIndex = 0
        Me.cbVSync.Text = "VSync"
        Me.cbVSync.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(710, 761)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cbGrayscaleIcon)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.numCPUUsageValue)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbStaticEffects)
        Me.Controls.Add(Me.cbAutoPause)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbNoToaster)
        Me.Controls.Add(Me.cbStartAtLogin)
        Me.Controls.Add(Me.btnAddScreen)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tcScreen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpenRGB Wallpaper"
        Me.taskbarMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbTimerInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numCPUUsageValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents niNotify As NotifyIcon
    Friend WithEvents taskbarMenu As ContextMenuStrip
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReconnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbInterpolation As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCompositing As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSmoothing As ComboBox
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnSave As Button
    Friend WithEvents tcScreen As TabControl
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddScreen As Button
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbStartAtLogin As CheckBox
    Friend WithEvents lblTimerInterval As Label
    Friend WithEvents tbTimerInterval As TrackBar
    Friend WithEvents cbNoToaster As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbLedShape As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbPixelOffset As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLEDPadding As NumBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbRGBPattern As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbRGBTransform As ComboBox
    Friend WithEvents cbStaticEffects As CheckBox
    Friend WithEvents cbGrayscaleIcon As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRoundRectRadius As NumBox
    Friend WithEvents cbAutoPause As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents numCPUUsageValue As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbVSync As CheckBox
    Friend WithEvents cbAntialias As CheckBox
End Class
