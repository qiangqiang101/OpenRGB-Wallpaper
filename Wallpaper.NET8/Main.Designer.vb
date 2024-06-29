<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits FormEx

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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        NsTheme1 = New NSTheme()
        GroupBox1 = New NSGroupBox()
        tcDevices = New NSTabControl()
        btnAddScreen = New NSButton()
        btnClose = New NSControlButton()
        lblMentaL = New NSLabel()
        btnCancel = New NSButton()
        btnSave = New NSButton()
        btnApply = New NSButton()
        gbGeneral = New NSGroupBox()
        lblRWWE = New NSLabel()
        cbRestoreWallpaper = New NSOnOffBox()
        lblSMz = New NSLabel()
        cbStartMinimized = New NSOnOffBox()
        lblLang = New NSLabel()
        cmbLanguage = New NSComboBox()
        lblGTI = New NSLabel()
        cbGrayscaleIcon = New NSOnOffBox()
        lblCUPV = New NSLabel()
        nudCPUUsageValue = New NSNumericUpDown()
        lblPWCUR = New NSLabel()
        cbAutoPause = New NSOnOffBox()
        lblDN = New NSLabel()
        cbNoToaster = New NSOnOffBox()
        lblSWW = New NSLabel()
        cbStartAtLogin = New NSOnOffBox()
        gbGraphics = New NSGroupBox()
        lblRI = New NSLabel()
        tbTimerInterval = New NSTrackBar()
        lblLP = New NSLabel()
        nudLEDPadding = New NSNumericUpDown()
        lblRRR = New NSLabel()
        nudRoundRectRadius = New NSNumericUpDown()
        lblLS = New NSLabel()
        cmbLedShape = New NSComboBox()
        lblPOM = New NSLabel()
        cmbPixelOffset = New NSComboBox()
        lblIM = New NSLabel()
        cmbInterpolation = New NSComboBox()
        lblCQ = New NSLabel()
        cmbCompositing = New NSComboBox()
        lblSM = New NSLabel()
        cmbSmoothing = New NSComboBox()
        niNotify = New NotifyIcon(components)
        taskbarMenu = New NSContextMenu()
        tsmiConnect = New ToolStripMenuItem()
        tsmiReconnect = New ToolStripMenuItem()
        tsmiPause = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        tsmiSettings = New ToolStripMenuItem()
        tsmiHelp = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        tsmiExit = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        NsTheme1.SuspendLayout()
        GroupBox1.SuspendLayout()
        gbGeneral.SuspendLayout()
        gbGraphics.SuspendLayout()
        taskbarMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' NsTheme1
        ' 
        NsTheme1.AccentOffset = 42
        NsTheme1.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        NsTheme1.BorderStyle = FormBorderStyle.FixedSingle
        NsTheme1.Controls.Add(GroupBox1)
        NsTheme1.Controls.Add(btnClose)
        NsTheme1.Controls.Add(lblMentaL)
        NsTheme1.Controls.Add(btnCancel)
        NsTheme1.Controls.Add(btnSave)
        NsTheme1.Controls.Add(btnApply)
        NsTheme1.Controls.Add(gbGeneral)
        NsTheme1.Controls.Add(gbGraphics)
        NsTheme1.Customization = ""
        NsTheme1.Dock = DockStyle.Fill
        NsTheme1.Font = New Font("Segoe UI", 9.0F)
        NsTheme1.Image = Nothing
        NsTheme1.Location = New Point(0, 0)
        NsTheme1.Movable = True
        NsTheme1.Name = "NsTheme1"
        NsTheme1.NoRounding = False
        NsTheme1.Padding = New Padding(3, 33, 3, 3)
        NsTheme1.Sizable = False
        NsTheme1.Size = New Size(844, 636)
        NsTheme1.SmartBounds = True
        NsTheme1.StartPosition = FormStartPosition.CenterScreen
        NsTheme1.TabIndex = 0
        NsTheme1.Text = "OpenRGB Wallpaper 2"
        NsTheme1.TransparencyKey = Color.Empty
        NsTheme1.Transparent = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(tcDevices)
        GroupBox1.Controls.Add(btnAddScreen)
        GroupBox1.DrawSeperator = True
        GroupBox1.Location = New Point(361, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 48, 3, 3)
        GroupBox1.Size = New Size(471, 556)
        GroupBox1.SubTitle = "E1.31 Devices"
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        GroupBox1.Title = "Device Settings"
        ' 
        ' tcDevices
        ' 
        tcDevices.Alignment = TabAlignment.Left
        tcDevices.Dock = DockStyle.Fill
        tcDevices.DrawMode = TabDrawMode.OwnerDrawFixed
        tcDevices.ItemSize = New Size(48, 130)
        tcDevices.Location = New Point(3, 48)
        tcDevices.Multiline = True
        tcDevices.Name = "tcDevices"
        tcDevices.SelectedIndex = 0
        tcDevices.Size = New Size(465, 505)
        tcDevices.SizeMode = TabSizeMode.Fixed
        tcDevices.TabIndex = 1
        ' 
        ' btnAddScreen
        ' 
        btnAddScreen.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddScreen.Location = New Point(365, 12)
        btnAddScreen.Name = "btnAddScreen"
        btnAddScreen.Size = New Size(100, 24)
        btnAddScreen.TabIndex = 0
        btnAddScreen.Text = "+ Add Screen"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.ControlButton = NSControlButton.Button.Close
        btnClose.Location = New Point(821, 5)
        btnClose.Margin = New Padding(0)
        btnClose.MaximumSize = New Size(18, 20)
        btnClose.MinimumSize = New Size(18, 20)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(18, 20)
        btnClose.TabIndex = 0
        btnClose.Text = "NsControlButton1"
        ' 
        ' lblMentaL
        ' 
        lblMentaL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblMentaL.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblMentaL.Location = New Point(12, 600)
        lblMentaL.Name = "lblMentaL"
        lblMentaL.Size = New Size(502, 24)
        lblMentaL.TabIndex = 16
        lblMentaL.Text = "NsLabel14"
        lblMentaL.Value1 = "Made with ❤ by"
        lblMentaL.Value2 = " Bartholomew ""Not MentaL"" Ho"
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancel.Location = New Point(732, 600)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 24)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        ' 
        ' btnSave
        ' 
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSave.Location = New Point(626, 600)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 24)
        btnSave.TabIndex = 5
        btnSave.Text = "Save Changes"
        ' 
        ' btnApply
        ' 
        btnApply.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnApply.Location = New Point(520, 600)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(100, 24)
        btnApply.TabIndex = 4
        btnApply.Text = "Apply"
        ' 
        ' gbGeneral
        ' 
        gbGeneral.Controls.Add(lblRWWE)
        gbGeneral.Controls.Add(cbRestoreWallpaper)
        gbGeneral.Controls.Add(lblSMz)
        gbGeneral.Controls.Add(cbStartMinimized)
        gbGeneral.Controls.Add(lblLang)
        gbGeneral.Controls.Add(cmbLanguage)
        gbGeneral.Controls.Add(lblGTI)
        gbGeneral.Controls.Add(cbGrayscaleIcon)
        gbGeneral.Controls.Add(lblCUPV)
        gbGeneral.Controls.Add(nudCPUUsageValue)
        gbGeneral.Controls.Add(lblPWCUR)
        gbGeneral.Controls.Add(cbAutoPause)
        gbGeneral.Controls.Add(lblDN)
        gbGeneral.Controls.Add(cbNoToaster)
        gbGeneral.Controls.Add(lblSWW)
        gbGeneral.Controls.Add(cbStartAtLogin)
        gbGeneral.DrawSeperator = True
        gbGeneral.Location = New Point(12, 317)
        gbGeneral.Name = "gbGeneral"
        gbGeneral.Padding = New Padding(3, 32, 3, 3)
        gbGeneral.Size = New Size(343, 275)
        gbGeneral.SubTitle = ""
        gbGeneral.TabIndex = 2
        gbGeneral.Title = "General Settings"
        ' 
        ' lblRWWE
        ' 
        lblRWWE.Font = New Font("Segoe UI", 9.0F)
        lblRWWE.Location = New Point(68, 95)
        lblRWWE.Name = "lblRWWE"
        lblRWWE.Size = New Size(269, 24)
        lblRWWE.TabIndex = 30
        lblRWWE.Text = "NsLabel9"
        lblRWWE.Value1 = "Restore Wallpaper when exit"
        lblRWWE.Value2 = ""
        ' 
        ' cbRestoreWallpaper
        ' 
        cbRestoreWallpaper.Checked = False
        cbRestoreWallpaper.Location = New Point(6, 95)
        cbRestoreWallpaper.MaximumSize = New Size(56, 24)
        cbRestoreWallpaper.MinimumSize = New Size(56, 24)
        cbRestoreWallpaper.Name = "cbRestoreWallpaper"
        cbRestoreWallpaper.Size = New Size(56, 24)
        cbRestoreWallpaper.TabIndex = 2
        cbRestoreWallpaper.Text = "NsOnOffBox1"
        ' 
        ' lblSMz
        ' 
        lblSMz.Font = New Font("Segoe UI", 9.0F)
        lblSMz.Location = New Point(68, 65)
        lblSMz.Name = "lblSMz"
        lblSMz.Size = New Size(269, 24)
        lblSMz.TabIndex = 28
        lblSMz.Text = "NsLabel9"
        lblSMz.Value1 = "Start Minimized"
        lblSMz.Value2 = ""
        ' 
        ' cbStartMinimized
        ' 
        cbStartMinimized.Checked = False
        cbStartMinimized.Location = New Point(6, 65)
        cbStartMinimized.MaximumSize = New Size(56, 24)
        cbStartMinimized.MinimumSize = New Size(56, 24)
        cbStartMinimized.Name = "cbStartMinimized"
        cbStartMinimized.Size = New Size(56, 24)
        cbStartMinimized.TabIndex = 1
        cbStartMinimized.Text = "NsOnOffBox1"
        ' 
        ' lblLang
        ' 
        lblLang.Font = New Font("Segoe UI", 9.0F)
        lblLang.Location = New Point(6, 245)
        lblLang.Name = "lblLang"
        lblLang.Size = New Size(165, 24)
        lblLang.TabIndex = 26
        lblLang.Text = "NsLabel5"
        lblLang.Value1 = "Language"
        lblLang.Value2 = ""
        ' 
        ' cmbLanguage
        ' 
        cmbLanguage.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbLanguage.DrawMode = DrawMode.OwnerDrawFixed
        cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLanguage.ForeColor = Color.White
        cmbLanguage.FormattingEnabled = True
        cmbLanguage.Location = New Point(177, 245)
        cmbLanguage.Name = "cmbLanguage"
        cmbLanguage.Size = New Size(160, 24)
        cmbLanguage.TabIndex = 7
        ' 
        ' lblGTI
        ' 
        lblGTI.Font = New Font("Segoe UI", 9.0F)
        lblGTI.Location = New Point(68, 215)
        lblGTI.Name = "lblGTI"
        lblGTI.Size = New Size(269, 24)
        lblGTI.TabIndex = 24
        lblGTI.Text = "NsLabel13"
        lblGTI.Value1 = "Grayscale Tray Icon"
        lblGTI.Value2 = ""
        ' 
        ' cbGrayscaleIcon
        ' 
        cbGrayscaleIcon.Checked = False
        cbGrayscaleIcon.Location = New Point(6, 215)
        cbGrayscaleIcon.MaximumSize = New Size(56, 24)
        cbGrayscaleIcon.MinimumSize = New Size(56, 24)
        cbGrayscaleIcon.Name = "cbGrayscaleIcon"
        cbGrayscaleIcon.Size = New Size(56, 24)
        cbGrayscaleIcon.TabIndex = 6
        cbGrayscaleIcon.Text = "NsOnOffBox1"
        ' 
        ' lblCUPV
        ' 
        lblCUPV.Font = New Font("Segoe UI", 9.0F)
        lblCUPV.Location = New Point(6, 185)
        lblCUPV.Name = "lblCUPV"
        lblCUPV.Size = New Size(165, 24)
        lblCUPV.TabIndex = 22
        lblCUPV.Text = "NsLabel12"
        lblCUPV.Value1 = "CPU Usage Pause Value"
        lblCUPV.Value2 = ""
        ' 
        ' nudCPUUsageValue
        ' 
        nudCPUUsageValue.DecimalPlaces = 0
        nudCPUUsageValue.Increment = 1
        nudCPUUsageValue.InterceptArrowKeys = True
        nudCPUUsageValue.Location = New Point(177, 185)
        nudCPUUsageValue.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        nudCPUUsageValue.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudCPUUsageValue.Name = "nudCPUUsageValue"
        nudCPUUsageValue.ReadOnly = False
        nudCPUUsageValue.Size = New Size(80, 24)
        nudCPUUsageValue.TabIndex = 5
        nudCPUUsageValue.TextAlign = HorizontalAlignment.Left
        nudCPUUsageValue.ThousandsSeparator = False
        nudCPUUsageValue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblPWCUR
        ' 
        lblPWCUR.Font = New Font("Segoe UI", 9.0F)
        lblPWCUR.Location = New Point(68, 155)
        lblPWCUR.Name = "lblPWCUR"
        lblPWCUR.Size = New Size(269, 24)
        lblPWCUR.TabIndex = 20
        lblPWCUR.Text = "NsLabel11"
        lblPWCUR.Value1 = "Pause when CPU Usage reaches "
        lblPWCUR.Value2 = "60%"
        ' 
        ' cbAutoPause
        ' 
        cbAutoPause.Checked = False
        cbAutoPause.Location = New Point(6, 155)
        cbAutoPause.MaximumSize = New Size(56, 24)
        cbAutoPause.MinimumSize = New Size(56, 24)
        cbAutoPause.Name = "cbAutoPause"
        cbAutoPause.Size = New Size(56, 24)
        cbAutoPause.TabIndex = 4
        cbAutoPause.Text = "NsOnOffBox1"
        ' 
        ' lblDN
        ' 
        lblDN.Font = New Font("Segoe UI", 9.0F)
        lblDN.Location = New Point(68, 125)
        lblDN.Name = "lblDN"
        lblDN.Size = New Size(269, 24)
        lblDN.TabIndex = 18
        lblDN.Text = "NsLabel10"
        lblDN.Value1 = "Disable Notifications"
        lblDN.Value2 = ""
        ' 
        ' cbNoToaster
        ' 
        cbNoToaster.Checked = False
        cbNoToaster.Location = New Point(6, 125)
        cbNoToaster.MaximumSize = New Size(56, 24)
        cbNoToaster.MinimumSize = New Size(56, 24)
        cbNoToaster.Name = "cbNoToaster"
        cbNoToaster.Size = New Size(56, 24)
        cbNoToaster.TabIndex = 3
        cbNoToaster.Text = "NsOnOffBox1"
        ' 
        ' lblSWW
        ' 
        lblSWW.Font = New Font("Segoe UI", 9.0F)
        lblSWW.Location = New Point(68, 35)
        lblSWW.Name = "lblSWW"
        lblSWW.Size = New Size(269, 24)
        lblSWW.TabIndex = 16
        lblSWW.Text = "NsLabel9"
        lblSWW.Value1 = "Start with Windows"
        lblSWW.Value2 = ""
        ' 
        ' cbStartAtLogin
        ' 
        cbStartAtLogin.Checked = False
        cbStartAtLogin.Location = New Point(6, 35)
        cbStartAtLogin.MaximumSize = New Size(56, 24)
        cbStartAtLogin.MinimumSize = New Size(56, 24)
        cbStartAtLogin.Name = "cbStartAtLogin"
        cbStartAtLogin.Size = New Size(56, 24)
        cbStartAtLogin.TabIndex = 0
        cbStartAtLogin.Text = "NsOnOffBox1"
        ' 
        ' gbGraphics
        ' 
        gbGraphics.Controls.Add(lblRI)
        gbGraphics.Controls.Add(tbTimerInterval)
        gbGraphics.Controls.Add(lblLP)
        gbGraphics.Controls.Add(nudLEDPadding)
        gbGraphics.Controls.Add(lblRRR)
        gbGraphics.Controls.Add(nudRoundRectRadius)
        gbGraphics.Controls.Add(lblLS)
        gbGraphics.Controls.Add(cmbLedShape)
        gbGraphics.Controls.Add(lblPOM)
        gbGraphics.Controls.Add(cmbPixelOffset)
        gbGraphics.Controls.Add(lblIM)
        gbGraphics.Controls.Add(cmbInterpolation)
        gbGraphics.Controls.Add(lblCQ)
        gbGraphics.Controls.Add(cmbCompositing)
        gbGraphics.Controls.Add(lblSM)
        gbGraphics.Controls.Add(cmbSmoothing)
        gbGraphics.DrawSeperator = True
        gbGraphics.Location = New Point(12, 36)
        gbGraphics.Name = "gbGraphics"
        gbGraphics.Padding = New Padding(3, 32, 3, 3)
        gbGraphics.Size = New Size(343, 275)
        gbGraphics.SubTitle = ""
        gbGraphics.TabIndex = 1
        gbGraphics.Text = "NsGroupBox1"
        gbGraphics.Title = "Graphics Settings"
        ' 
        ' lblRI
        ' 
        lblRI.Font = New Font("Segoe UI", 9.0F)
        lblRI.Location = New Point(6, 245)
        lblRI.Name = "lblRI"
        lblRI.Size = New Size(165, 24)
        lblRI.TabIndex = 15
        lblRI.Text = "NsLabel8"
        lblRI.Value1 = "Refresh Interval "
        lblRI.Value2 = "30ms"
        ' 
        ' tbTimerInterval
        ' 
        tbTimerInterval.Location = New Point(177, 245)
        tbTimerInterval.Maximum = 200
        tbTimerInterval.Minimum = 10
        tbTimerInterval.Name = "tbTimerInterval"
        tbTimerInterval.Size = New Size(160, 24)
        tbTimerInterval.TabIndex = 7
        tbTimerInterval.Text = "NsTrackBar1"
        tbTimerInterval.Value = 30
        ' 
        ' lblLP
        ' 
        lblLP.Font = New Font("Segoe UI", 9.0F)
        lblLP.Location = New Point(6, 215)
        lblLP.Name = "lblLP"
        lblLP.Size = New Size(165, 24)
        lblLP.TabIndex = 13
        lblLP.Text = "NsLabel7"
        lblLP.Value1 = "LED Padding"
        lblLP.Value2 = ""
        ' 
        ' nudLEDPadding
        ' 
        nudLEDPadding.DecimalPlaces = 0
        nudLEDPadding.Increment = 1
        nudLEDPadding.InterceptArrowKeys = True
        nudLEDPadding.Location = New Point(177, 215)
        nudLEDPadding.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        nudLEDPadding.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudLEDPadding.Name = "nudLEDPadding"
        nudLEDPadding.ReadOnly = False
        nudLEDPadding.Size = New Size(80, 24)
        nudLEDPadding.TabIndex = 6
        nudLEDPadding.TextAlign = HorizontalAlignment.Left
        nudLEDPadding.ThousandsSeparator = False
        nudLEDPadding.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblRRR
        ' 
        lblRRR.Font = New Font("Segoe UI", 9.0F)
        lblRRR.Location = New Point(6, 185)
        lblRRR.Name = "lblRRR"
        lblRRR.Size = New Size(165, 24)
        lblRRR.TabIndex = 11
        lblRRR.Text = "NsLabel6"
        lblRRR.Value1 = "Rounded Rectangle Radius"
        lblRRR.Value2 = ""
        ' 
        ' nudRoundRectRadius
        ' 
        nudRoundRectRadius.DecimalPlaces = 0
        nudRoundRectRadius.Increment = 1
        nudRoundRectRadius.InterceptArrowKeys = True
        nudRoundRectRadius.Location = New Point(177, 185)
        nudRoundRectRadius.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        nudRoundRectRadius.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudRoundRectRadius.Name = "nudRoundRectRadius"
        nudRoundRectRadius.ReadOnly = False
        nudRoundRectRadius.Size = New Size(80, 24)
        nudRoundRectRadius.TabIndex = 5
        nudRoundRectRadius.TextAlign = HorizontalAlignment.Left
        nudRoundRectRadius.ThousandsSeparator = False
        nudRoundRectRadius.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblLS
        ' 
        lblLS.Font = New Font("Segoe UI", 9.0F)
        lblLS.Location = New Point(6, 155)
        lblLS.Name = "lblLS"
        lblLS.Size = New Size(165, 24)
        lblLS.TabIndex = 9
        lblLS.Text = "NsLabel5"
        lblLS.Value1 = "LED Shape"
        lblLS.Value2 = ""
        ' 
        ' cmbLedShape
        ' 
        cmbLedShape.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbLedShape.DrawMode = DrawMode.OwnerDrawFixed
        cmbLedShape.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLedShape.ForeColor = Color.White
        cmbLedShape.FormattingEnabled = True
        cmbLedShape.Location = New Point(177, 155)
        cmbLedShape.Name = "cmbLedShape"
        cmbLedShape.Size = New Size(160, 24)
        cmbLedShape.TabIndex = 4
        ' 
        ' lblPOM
        ' 
        lblPOM.Font = New Font("Segoe UI", 9.0F)
        lblPOM.Location = New Point(6, 125)
        lblPOM.Name = "lblPOM"
        lblPOM.Size = New Size(165, 24)
        lblPOM.TabIndex = 7
        lblPOM.Text = "NsLabel4"
        lblPOM.Value1 = "Pixel Offset Mode"
        lblPOM.Value2 = ""
        ' 
        ' cmbPixelOffset
        ' 
        cmbPixelOffset.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbPixelOffset.DrawMode = DrawMode.OwnerDrawFixed
        cmbPixelOffset.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPixelOffset.ForeColor = Color.White
        cmbPixelOffset.FormattingEnabled = True
        cmbPixelOffset.Location = New Point(177, 125)
        cmbPixelOffset.Name = "cmbPixelOffset"
        cmbPixelOffset.Size = New Size(160, 24)
        cmbPixelOffset.TabIndex = 3
        ' 
        ' lblIM
        ' 
        lblIM.Font = New Font("Segoe UI", 9.0F)
        lblIM.Location = New Point(6, 95)
        lblIM.Name = "lblIM"
        lblIM.Size = New Size(165, 24)
        lblIM.TabIndex = 5
        lblIM.Text = "NsLabel3"
        lblIM.Value1 = "Interpolation Mode"
        lblIM.Value2 = ""
        ' 
        ' cmbInterpolation
        ' 
        cmbInterpolation.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbInterpolation.DrawMode = DrawMode.OwnerDrawFixed
        cmbInterpolation.DropDownStyle = ComboBoxStyle.DropDownList
        cmbInterpolation.ForeColor = Color.White
        cmbInterpolation.FormattingEnabled = True
        cmbInterpolation.Location = New Point(177, 95)
        cmbInterpolation.Name = "cmbInterpolation"
        cmbInterpolation.Size = New Size(160, 24)
        cmbInterpolation.TabIndex = 2
        ' 
        ' lblCQ
        ' 
        lblCQ.Font = New Font("Segoe UI", 9.0F)
        lblCQ.Location = New Point(6, 65)
        lblCQ.Name = "lblCQ"
        lblCQ.Size = New Size(165, 24)
        lblCQ.TabIndex = 3
        lblCQ.Text = "NsLabel2"
        lblCQ.Value1 = "Compositing Quality"
        lblCQ.Value2 = ""
        ' 
        ' cmbCompositing
        ' 
        cmbCompositing.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbCompositing.DrawMode = DrawMode.OwnerDrawFixed
        cmbCompositing.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCompositing.ForeColor = Color.White
        cmbCompositing.FormattingEnabled = True
        cmbCompositing.Location = New Point(177, 65)
        cmbCompositing.Name = "cmbCompositing"
        cmbCompositing.Size = New Size(160, 24)
        cmbCompositing.TabIndex = 1
        ' 
        ' lblSM
        ' 
        lblSM.Font = New Font("Segoe UI", 9.0F)
        lblSM.Location = New Point(6, 35)
        lblSM.Name = "lblSM"
        lblSM.Size = New Size(165, 24)
        lblSM.TabIndex = 1
        lblSM.Text = "NsLabel1"
        lblSM.Value1 = "Smoothing Mode"
        lblSM.Value2 = ""
        ' 
        ' cmbSmoothing
        ' 
        cmbSmoothing.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbSmoothing.DrawMode = DrawMode.OwnerDrawFixed
        cmbSmoothing.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSmoothing.ForeColor = Color.White
        cmbSmoothing.FormattingEnabled = True
        cmbSmoothing.Location = New Point(177, 35)
        cmbSmoothing.Name = "cmbSmoothing"
        cmbSmoothing.Size = New Size(160, 24)
        cmbSmoothing.TabIndex = 0
        ' 
        ' niNotify
        ' 
        niNotify.BalloonTipText = "You can access setting by right clicking the icon."
        niNotify.BalloonTipTitle = "OpenRGB Wallpaper 2"
        niNotify.ContextMenuStrip = taskbarMenu
        niNotify.Icon = CType(resources.GetObject("niNotify.Icon"), Icon)
        niNotify.Text = "OpenRGB Wallpaper 2"
        niNotify.Visible = True
        ' 
        ' taskbarMenu
        ' 
        taskbarMenu.ForeColor = Color.White
        taskbarMenu.Items.AddRange(New ToolStripItem() {tsmiConnect, tsmiReconnect, tsmiPause, ToolStripSeparator1, tsmiSettings, tsmiHelp, ToolStripSeparator2, tsmiExit})
        taskbarMenu.Name = "taskbarMenu"
        taskbarMenu.Size = New Size(131, 148)
        ' 
        ' tsmiConnect
        ' 
        tsmiConnect.Name = "tsmiConnect"
        tsmiConnect.Size = New Size(130, 22)
        tsmiConnect.Text = "Connect"
        ' 
        ' tsmiReconnect
        ' 
        tsmiReconnect.Name = "tsmiReconnect"
        tsmiReconnect.Size = New Size(130, 22)
        tsmiReconnect.Text = "Reconnect"
        ' 
        ' tsmiPause
        ' 
        tsmiPause.Name = "tsmiPause"
        tsmiPause.Size = New Size(130, 22)
        tsmiPause.Text = "Pause"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(127, 6)
        ' 
        ' tsmiSettings
        ' 
        tsmiSettings.Name = "tsmiSettings"
        tsmiSettings.Size = New Size(130, 22)
        tsmiSettings.Text = "Settings"
        ' 
        ' tsmiHelp
        ' 
        tsmiHelp.Name = "tsmiHelp"
        tsmiHelp.Size = New Size(130, 22)
        tsmiHelp.Text = "Help"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(127, 6)
        ' 
        ' tsmiExit
        ' 
        tsmiExit.Name = "tsmiExit"
        tsmiExit.Size = New Size(130, 22)
        tsmiExit.Text = "Exit"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 5000
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(844, 636)
        Controls.Add(NsTheme1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Location = New Point(0, 0)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OpenRGB Wallpaper 2"
        NsTheme1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        gbGeneral.ResumeLayout(False)
        gbGraphics.ResumeLayout(False)
        taskbarMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents gbGraphics As NSGroupBox
    Friend WithEvents cmbSmoothing As NSComboBox
    Friend WithEvents lblPOM As NSLabel
    Friend WithEvents cmbPixelOffset As NSComboBox
    Friend WithEvents lblIM As NSLabel
    Friend WithEvents cmbInterpolation As NSComboBox
    Friend WithEvents lblCQ As NSLabel
    Friend WithEvents cmbCompositing As NSComboBox
    Friend WithEvents lblSM As NSLabel
    Friend WithEvents lblLS As NSLabel
    Friend WithEvents cmbLedShape As NSComboBox
    Friend WithEvents lblLP As NSLabel
    Friend WithEvents nudLEDPadding As NSNumericUpDown
    Friend WithEvents lblRRR As NSLabel
    Friend WithEvents nudRoundRectRadius As NSNumericUpDown
    Friend WithEvents lblRI As NSLabel
    Friend WithEvents tbTimerInterval As NSTrackBar
    Friend WithEvents gbGeneral As NSGroupBox
    Friend WithEvents cbStartAtLogin As NSOnOffBox
    Friend WithEvents lblPWCUR As NSLabel
    Friend WithEvents cbAutoPause As NSOnOffBox
    Friend WithEvents lblDN As NSLabel
    Friend WithEvents cbNoToaster As NSOnOffBox
    Friend WithEvents lblSWW As NSLabel
    Friend WithEvents lblGTI As NSLabel
    Friend WithEvents cbGrayscaleIcon As NSOnOffBox
    Friend WithEvents lblCUPV As NSLabel
    Friend WithEvents nudCPUUsageValue As NSNumericUpDown
    Friend WithEvents tcDevices As NSTabControl
    Friend WithEvents btnAddScreen As NSButton
    Friend WithEvents btnCancel As NSButton
    Friend WithEvents btnSave As NSButton
    Friend WithEvents btnApply As NSButton
    Friend WithEvents lblMentaL As NSLabel
    Friend WithEvents lblLang As NSLabel
    Friend WithEvents cmbLanguage As NSComboBox
    Friend WithEvents niNotify As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents taskbarMenu As NSContextMenu
    Friend WithEvents tsmiConnect As ToolStripMenuItem
    Friend WithEvents tsmiReconnect As ToolStripMenuItem
    Friend WithEvents tsmiPause As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiSettings As ToolStripMenuItem
    Friend WithEvents tsmiHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsmiExit As ToolStripMenuItem
    Friend WithEvents btnClose As NSControlButton
    Friend WithEvents lblSMz As NSLabel
    Friend WithEvents cbStartMinimized As NSOnOffBox
    Friend WithEvents lblRWWE As NSLabel
    Friend WithEvents cbRestoreWallpaper As NSOnOffBox
    Friend WithEvents GroupBox1 As NSGroupBox

End Class
