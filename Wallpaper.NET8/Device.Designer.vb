<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Device
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblName = New NSLabel()
        cmbDeviceName = New NSComboBox()
        btnRefresh = New NSButton()
        lblZone = New NSLabel()
        cmbDeviceZone = New NSComboBox()
        gbDisplay = New NSGroupBox()
        lblHeight = New NSLabel()
        nudDisplayHeight = New NSNumericUpDown()
        lblWidth = New NSLabel()
        nudDisplayWidth = New NSNumericUpDown()
        lblY = New NSLabel()
        nudDisplayY = New NSNumericUpDown()
        lblX = New NSLabel()
        nudDisplayX = New NSNumericUpDown()
        gbDevice = New NSGroupBox()
        gbImage = New NSGroupBox()
        cmbBackColor = New NSComboBoxColorPicker()
        lblBC = New NSLabel()
        cmbSizeMode = New NSComboBox()
        lblSM = New NSLabel()
        btnGetWallpaper = New NSButton()
        btnDelImage = New NSButton()
        btnChgImage = New NSButton()
        pbImage = New PictureBox()
        lblNotify = New NSLabel()
        btnRemove = New NSButton()
        btnApply = New NSButton()
        gbDisplay.SuspendLayout()
        gbDevice.SuspendLayout()
        gbImage.SuspendLayout()
        CType(pbImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Segoe UI", 9F)
        lblName.Location = New Point(6, 51)
        lblName.Name = "lblName"
        lblName.Size = New Size(72, 24)
        lblName.TabIndex = 3
        lblName.Value1 = "Name"
        lblName.Value2 = ""
        ' 
        ' cmbDeviceName
        ' 
        cmbDeviceName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbDeviceName.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbDeviceName.DrawMode = DrawMode.OwnerDrawFixed
        cmbDeviceName.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDeviceName.ForeColor = Color.White
        cmbDeviceName.FormattingEnabled = True
        cmbDeviceName.Location = New Point(84, 51)
        cmbDeviceName.Name = "cmbDeviceName"
        cmbDeviceName.Size = New Size(244, 24)
        cmbDeviceName.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.Location = New Point(228, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 24)
        btnRefresh.TabIndex = 0
        btnRefresh.Text = "↻ Refresh"
        ' 
        ' lblZone
        ' 
        lblZone.Font = New Font("Segoe UI", 9F)
        lblZone.Location = New Point(6, 81)
        lblZone.Name = "lblZone"
        lblZone.Size = New Size(72, 24)
        lblZone.TabIndex = 8
        lblZone.Text = "NsLabel1"
        lblZone.Value1 = "Zone"
        lblZone.Value2 = ""
        ' 
        ' cmbDeviceZone
        ' 
        cmbDeviceZone.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbDeviceZone.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbDeviceZone.DrawMode = DrawMode.OwnerDrawFixed
        cmbDeviceZone.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDeviceZone.ForeColor = Color.White
        cmbDeviceZone.FormattingEnabled = True
        cmbDeviceZone.Location = New Point(84, 81)
        cmbDeviceZone.Name = "cmbDeviceZone"
        cmbDeviceZone.Size = New Size(244, 24)
        cmbDeviceZone.TabIndex = 2
        ' 
        ' gbDisplay
        ' 
        gbDisplay.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbDisplay.Controls.Add(lblHeight)
        gbDisplay.Controls.Add(nudDisplayHeight)
        gbDisplay.Controls.Add(lblWidth)
        gbDisplay.Controls.Add(nudDisplayWidth)
        gbDisplay.Controls.Add(lblY)
        gbDisplay.Controls.Add(nudDisplayY)
        gbDisplay.Controls.Add(lblX)
        gbDisplay.Controls.Add(nudDisplayX)
        gbDisplay.DrawSeperator = True
        gbDisplay.Location = New Point(3, 120)
        gbDisplay.Name = "gbDisplay"
        gbDisplay.Padding = New Padding(3, 32, 3, 3)
        gbDisplay.Size = New Size(334, 95)
        gbDisplay.SubTitle = ""
        gbDisplay.TabIndex = 2
        gbDisplay.Text = "NsGroupBox1"
        gbDisplay.Title = "Display"
        ' 
        ' lblHeight
        ' 
        lblHeight.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHeight.Font = New Font("Segoe UI", 9F)
        lblHeight.Location = New Point(170, 65)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(72, 24)
        lblHeight.TabIndex = 21
        lblHeight.Text = "NsLabel6"
        lblHeight.Value1 = "Height"
        lblHeight.Value2 = ""
        ' 
        ' nudDisplayHeight
        ' 
        nudDisplayHeight.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        nudDisplayHeight.DecimalPlaces = 0
        nudDisplayHeight.Increment = 1
        nudDisplayHeight.InterceptArrowKeys = True
        nudDisplayHeight.Location = New Point(248, 65)
        nudDisplayHeight.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nudDisplayHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudDisplayHeight.Name = "nudDisplayHeight"
        nudDisplayHeight.ReadOnly = False
        nudDisplayHeight.Size = New Size(80, 24)
        nudDisplayHeight.TabIndex = 3
        nudDisplayHeight.TextAlign = HorizontalAlignment.Left
        nudDisplayHeight.ThousandsSeparator = False
        nudDisplayHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblWidth
        ' 
        lblWidth.Font = New Font("Segoe UI", 9F)
        lblWidth.Location = New Point(6, 65)
        lblWidth.Name = "lblWidth"
        lblWidth.Size = New Size(72, 24)
        lblWidth.TabIndex = 19
        lblWidth.Text = "NsLabel6"
        lblWidth.Value1 = "Width"
        lblWidth.Value2 = ""
        ' 
        ' nudDisplayWidth
        ' 
        nudDisplayWidth.DecimalPlaces = 0
        nudDisplayWidth.Increment = 1
        nudDisplayWidth.InterceptArrowKeys = True
        nudDisplayWidth.Location = New Point(84, 65)
        nudDisplayWidth.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nudDisplayWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        nudDisplayWidth.Name = "nudDisplayWidth"
        nudDisplayWidth.ReadOnly = False
        nudDisplayWidth.Size = New Size(80, 24)
        nudDisplayWidth.TabIndex = 2
        nudDisplayWidth.TextAlign = HorizontalAlignment.Left
        nudDisplayWidth.ThousandsSeparator = False
        nudDisplayWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblY
        ' 
        lblY.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblY.Font = New Font("Segoe UI", 9F)
        lblY.Location = New Point(170, 35)
        lblY.Name = "lblY"
        lblY.Size = New Size(72, 24)
        lblY.TabIndex = 17
        lblY.Text = "NsLabel6"
        lblY.Value1 = "Y"
        lblY.Value2 = ""
        ' 
        ' nudDisplayY
        ' 
        nudDisplayY.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        nudDisplayY.DecimalPlaces = 0
        nudDisplayY.Increment = 1
        nudDisplayY.InterceptArrowKeys = True
        nudDisplayY.Location = New Point(248, 35)
        nudDisplayY.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nudDisplayY.Minimum = New Decimal(New Integer() {99999, 0, 0, Integer.MinValue})
        nudDisplayY.Name = "nudDisplayY"
        nudDisplayY.ReadOnly = False
        nudDisplayY.Size = New Size(80, 24)
        nudDisplayY.TabIndex = 1
        nudDisplayY.TextAlign = HorizontalAlignment.Left
        nudDisplayY.ThousandsSeparator = False
        nudDisplayY.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' lblX
        ' 
        lblX.Font = New Font("Segoe UI", 9F)
        lblX.Location = New Point(6, 35)
        lblX.Name = "lblX"
        lblX.Size = New Size(72, 24)
        lblX.TabIndex = 15
        lblX.Text = "NsLabel6"
        lblX.Value1 = "X"
        lblX.Value2 = ""
        ' 
        ' nudDisplayX
        ' 
        nudDisplayX.DecimalPlaces = 0
        nudDisplayX.Increment = 1
        nudDisplayX.InterceptArrowKeys = True
        nudDisplayX.Location = New Point(84, 35)
        nudDisplayX.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        nudDisplayX.Minimum = New Decimal(New Integer() {99999, 0, 0, Integer.MinValue})
        nudDisplayX.Name = "nudDisplayX"
        nudDisplayX.ReadOnly = False
        nudDisplayX.Size = New Size(80, 24)
        nudDisplayX.TabIndex = 0
        nudDisplayX.TextAlign = HorizontalAlignment.Left
        nudDisplayX.ThousandsSeparator = False
        nudDisplayX.Value = New Decimal(New Integer() {0, 0, 0, 0})
        ' 
        ' gbDevice
        ' 
        gbDevice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbDevice.Controls.Add(cmbDeviceName)
        gbDevice.Controls.Add(lblName)
        gbDevice.Controls.Add(btnRefresh)
        gbDevice.Controls.Add(lblZone)
        gbDevice.Controls.Add(cmbDeviceZone)
        gbDevice.DrawSeperator = True
        gbDevice.Location = New Point(3, 3)
        gbDevice.Name = "gbDevice"
        gbDevice.Padding = New Padding(3, 48, 3, 3)
        gbDevice.Size = New Size(334, 111)
        gbDevice.SubTitle = "The E1.31 device"
        gbDevice.TabIndex = 0
        gbDevice.Text = "NsGroupBox1"
        gbDevice.Title = "Device"
        ' 
        ' gbImage
        ' 
        gbImage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbImage.Controls.Add(cmbBackColor)
        gbImage.Controls.Add(lblBC)
        gbImage.Controls.Add(cmbSizeMode)
        gbImage.Controls.Add(lblSM)
        gbImage.Controls.Add(btnGetWallpaper)
        gbImage.Controls.Add(btnDelImage)
        gbImage.Controls.Add(btnChgImage)
        gbImage.Controls.Add(pbImage)
        gbImage.DrawSeperator = True
        gbImage.Location = New Point(3, 221)
        gbImage.Name = "gbImage"
        gbImage.Padding = New Padding(3, 32, 3, 3)
        gbImage.Size = New Size(334, 223)
        gbImage.SubTitle = ""
        gbImage.TabIndex = 3
        gbImage.Text = "NsGroupBox1"
        gbImage.Title = "Cover Image"
        ' 
        ' cmbBackColor
        ' 
        cmbBackColor.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbBackColor.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbBackColor.DrawMode = DrawMode.OwnerDrawFixed
        cmbBackColor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBackColor.ForeColor = Color.White
        cmbBackColor.FormattingEnabled = True
        cmbBackColor.IntegralHeight = False
        cmbBackColor.Items.AddRange(New Object() {Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Cornsilk, Color.Crimson, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray, Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia, Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray, Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed, Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush, Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow, Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon, Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen, Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue, Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy, Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.PowderBlue, Color.Purple, Color.RebeccaPurple, Color.Red, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen, Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Cornsilk, Color.Crimson, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray, Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia, Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray, Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed, Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush, Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow, Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon, Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen, Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue, Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy, Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.PowderBlue, Color.Purple, Color.RebeccaPurple, Color.Red, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen, Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Cornsilk, Color.Crimson, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray, Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia, Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray, Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed, Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush, Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow, Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon, Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen, Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue, Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy, Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.PowderBlue, Color.Purple, Color.RebeccaPurple, Color.Red, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen, Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Cornsilk, Color.Crimson, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray, Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia, Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray, Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed, Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush, Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow, Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon, Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen, Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue, Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy, Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.PowderBlue, Color.Purple, Color.RebeccaPurple, Color.Red, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen, Color.AliceBlue, Color.AntiqueWhite, Color.Aqua, Color.Aquamarine, Color.Azure, Color.Beige, Color.Bisque, Color.Black, Color.BlanchedAlmond, Color.Blue, Color.BlueViolet, Color.Brown, Color.BurlyWood, Color.CadetBlue, Color.Chartreuse, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Cornsilk, Color.Crimson, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGoldenrod, Color.DarkGray, Color.DarkGreen, Color.DarkKhaki, Color.DarkMagenta, Color.DarkOliveGreen, Color.DarkOrange, Color.DarkOrchid, Color.DarkRed, Color.DarkSalmon, Color.DarkSeaGreen, Color.DarkSlateBlue, Color.DarkSlateGray, Color.DarkTurquoise, Color.DarkViolet, Color.DeepPink, Color.DeepSkyBlue, Color.DimGray, Color.DodgerBlue, Color.Firebrick, Color.FloralWhite, Color.ForestGreen, Color.Fuchsia, Color.Gainsboro, Color.GhostWhite, Color.Gold, Color.Goldenrod, Color.Gray, Color.Green, Color.GreenYellow, Color.Honeydew, Color.HotPink, Color.IndianRed, Color.Indigo, Color.Ivory, Color.Khaki, Color.Lavender, Color.LavenderBlush, Color.LawnGreen, Color.LemonChiffon, Color.LightBlue, Color.LightCoral, Color.LightCyan, Color.LightGoldenrodYellow, Color.LightGreen, Color.LightGray, Color.LightPink, Color.LightSalmon, Color.LightSeaGreen, Color.LightSkyBlue, Color.LightSlateGray, Color.LightSteelBlue, Color.LightYellow, Color.Lime, Color.LimeGreen, Color.Linen, Color.Magenta, Color.Maroon, Color.MediumAquamarine, Color.MediumBlue, Color.MediumOrchid, Color.MediumPurple, Color.MediumSeaGreen, Color.MediumSlateBlue, Color.MediumSpringGreen, Color.MediumTurquoise, Color.MediumVioletRed, Color.MidnightBlue, Color.MintCream, Color.MistyRose, Color.Moccasin, Color.NavajoWhite, Color.Navy, Color.OldLace, Color.Olive, Color.OliveDrab, Color.Orange, Color.OrangeRed, Color.Orchid, Color.PaleGoldenrod, Color.PaleGreen, Color.PaleTurquoise, Color.PaleVioletRed, Color.PapayaWhip, Color.PeachPuff, Color.Peru, Color.Pink, Color.Plum, Color.PowderBlue, Color.Purple, Color.RebeccaPurple, Color.Red, Color.RosyBrown, Color.RoyalBlue, Color.SaddleBrown, Color.Salmon, Color.SandyBrown, Color.SeaGreen, Color.SeaShell, Color.Sienna, Color.Silver, Color.SkyBlue, Color.SlateBlue, Color.SlateGray, Color.Snow, Color.SpringGreen, Color.SteelBlue, Color.Tan, Color.Teal, Color.Thistle, Color.Tomato, Color.Turquoise, Color.Violet, Color.Wheat, Color.White, Color.WhiteSmoke, Color.Yellow, Color.YellowGreen})
        cmbBackColor.Location = New Point(84, 193)
        cmbBackColor.MaxDropDownItems = 10
        cmbBackColor.Name = "cmbBackColor"
        cmbBackColor.Size = New Size(245, 24)
        cmbBackColor.TabIndex = 4
        ' 
        ' lblBC
        ' 
        lblBC.Font = New Font("Segoe UI", 9F)
        lblBC.Location = New Point(6, 193)
        lblBC.Name = "lblBC"
        lblBC.Size = New Size(72, 24)
        lblBC.TabIndex = 7
        lblBC.Value1 = "Background"
        lblBC.Value2 = ""
        ' 
        ' cmbSizeMode
        ' 
        cmbSizeMode.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSizeMode.BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        cmbSizeMode.DrawMode = DrawMode.OwnerDrawFixed
        cmbSizeMode.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSizeMode.ForeColor = Color.White
        cmbSizeMode.FormattingEnabled = True
        cmbSizeMode.Location = New Point(84, 163)
        cmbSizeMode.Name = "cmbSizeMode"
        cmbSizeMode.Size = New Size(245, 24)
        cmbSizeMode.TabIndex = 3
        ' 
        ' lblSM
        ' 
        lblSM.Font = New Font("Segoe UI", 9F)
        lblSM.Location = New Point(6, 163)
        lblSM.Name = "lblSM"
        lblSM.Size = New Size(72, 24)
        lblSM.TabIndex = 5
        lblSM.Value1 = "Size Mode"
        lblSM.Value2 = ""
        ' 
        ' btnGetWallpaper
        ' 
        btnGetWallpaper.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGetWallpaper.Location = New Point(228, 95)
        btnGetWallpaper.Name = "btnGetWallpaper"
        btnGetWallpaper.Size = New Size(101, 24)
        btnGetWallpaper.TabIndex = 2
        btnGetWallpaper.Text = "Get Wallpapers"
        ' 
        ' btnDelImage
        ' 
        btnDelImage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnDelImage.Enabled = False
        btnDelImage.Location = New Point(228, 65)
        btnDelImage.Name = "btnDelImage"
        btnDelImage.Size = New Size(101, 24)
        btnDelImage.TabIndex = 1
        btnDelImage.Text = "Clear"
        ' 
        ' btnChgImage
        ' 
        btnChgImage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnChgImage.Location = New Point(228, 35)
        btnChgImage.Name = "btnChgImage"
        btnChgImage.Size = New Size(101, 24)
        btnChgImage.TabIndex = 0
        btnChgImage.Text = "Select.."
        ' 
        ' pbImage
        ' 
        pbImage.Location = New Point(6, 35)
        pbImage.Name = "pbImage"
        pbImage.Size = New Size(216, 122)
        pbImage.SizeMode = PictureBoxSizeMode.Zoom
        pbImage.TabIndex = 0
        pbImage.TabStop = False
        ' 
        ' lblNotify
        ' 
        lblNotify.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblNotify.Font = New Font("Segoe UI", 9F)
        lblNotify.ForeColor = Color.Red
        lblNotify.Location = New Point(3, 449)
        lblNotify.Name = "lblNotify"
        lblNotify.Size = New Size(334, 24)
        lblNotify.TabIndex = 20
        lblNotify.Text = "NsLabel6"
        lblNotify.Value1 = "You have unsave changes."
        lblNotify.Value2 = ""
        lblNotify.Visible = False
        ' 
        ' btnRemove
        ' 
        btnRemove.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRemove.Location = New Point(3, 479)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(100, 24)
        btnRemove.TabIndex = 4
        btnRemove.Text = "Remove"
        ' 
        ' btnApply
        ' 
        btnApply.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnApply.Location = New Point(237, 479)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(100, 24)
        btnApply.TabIndex = 5
        btnApply.Text = "Apply"
        ' 
        ' Device
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        Controls.Add(btnApply)
        Controls.Add(btnRemove)
        Controls.Add(lblNotify)
        Controls.Add(gbImage)
        Controls.Add(gbDevice)
        Controls.Add(gbDisplay)
        Name = "Device"
        Size = New Size(340, 506)
        gbDisplay.ResumeLayout(False)
        gbDevice.ResumeLayout(False)
        gbImage.ResumeLayout(False)
        CType(pbImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblName As NSLabel
    Friend WithEvents cmbDeviceName As NSComboBox
    Friend WithEvents btnRefresh As NSButton
    Friend WithEvents lblZone As NSLabel
    Friend WithEvents cmbDeviceZone As NSComboBox
    Friend WithEvents gbDisplay As NSGroupBox
    Friend WithEvents lblY As NSLabel
    Friend WithEvents nudDisplayY As NSNumericUpDown
    Friend WithEvents lblX As NSLabel
    Friend WithEvents nudDisplayX As NSNumericUpDown
    Friend WithEvents lblHeight As NSLabel
    Friend WithEvents nudDisplayHeight As NSNumericUpDown
    Friend WithEvents lblWidth As NSLabel
    Friend WithEvents nudDisplayWidth As NSNumericUpDown
    Friend WithEvents gbDevice As NSGroupBox
    Friend WithEvents gbImage As NSGroupBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnChgImage As NSButton
    Friend WithEvents btnDelImage As NSButton
    Friend WithEvents cmbSizeMode As NSComboBox
    Friend WithEvents lblSM As NSLabel
    Friend WithEvents btnGetWallpaper As NSButton
    Friend WithEvents lblBC As NSLabel
    Friend WithEvents cmbBackColor As NSComboBoxColorPicker
    Friend WithEvents lblNotify As NSLabel
    Friend WithEvents btnRemove As NSButton
    Friend WithEvents btnApply As NSButton

End Class
