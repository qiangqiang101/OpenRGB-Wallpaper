﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbAutoconnect = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPort = New Wallpaper.NumBox(Me.components)
        Me.cmbDeviceName = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDisplayHeight = New Wallpaper.NumBox(Me.components)
        Me.txtDisplayWidth = New Wallpaper.NumBox(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDisplayY = New Wallpaper.NumBox(Me.components)
        Me.txtDisplayX = New Wallpaper.NumBox(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbRenderer = New System.Windows.Forms.ComboBox()
        Me.lblWallpaperDownload = New System.Windows.Forms.LinkLabel()
        Me.btnChgImage = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbImageFit = New System.Windows.Forms.ComboBox()
        Me.btnBackColor = New System.Windows.Forms.Button()
        Me.btnDelImage = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cmbDeviceZone = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(74, 22)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(80, 23)
        Me.txtIPAddress.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Device Name"
        '
        'cbAutoconnect
        '
        Me.cbAutoconnect.AutoSize = True
        Me.cbAutoconnect.Location = New System.Drawing.Point(6, 51)
        Me.cbAutoconnect.Name = "cbAutoconnect"
        Me.cbAutoconnect.Size = New System.Drawing.Size(95, 19)
        Me.cbAutoconnect.TabIndex = 6
        Me.cbAutoconnect.Text = "Autoconnect"
        Me.cbAutoconnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.txtIPAddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbAutoconnect)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 74)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SDK Server"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(240, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(80, 23)
        Me.txtPort.TabIndex = 3
        '
        'cmbDeviceName
        '
        Me.cmbDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeviceName.FormattingEnabled = True
        Me.cmbDeviceName.Location = New System.Drawing.Point(86, 3)
        Me.cmbDeviceName.Name = "cmbDeviceName"
        Me.cmbDeviceName.Size = New System.Drawing.Size(216, 23)
        Me.cmbDeviceName.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDisplayHeight)
        Me.GroupBox2.Controls.Add(Me.txtDisplayWidth)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDisplayY)
        Me.GroupBox2.Controls.Add(Me.txtDisplayX)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 85)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display"
        '
        'txtDisplayHeight
        '
        Me.txtDisplayHeight.Location = New System.Drawing.Point(240, 51)
        Me.txtDisplayHeight.Name = "txtDisplayHeight"
        Me.txtDisplayHeight.Size = New System.Drawing.Size(80, 23)
        Me.txtDisplayHeight.TabIndex = 3
        '
        'txtDisplayWidth
        '
        Me.txtDisplayWidth.Location = New System.Drawing.Point(74, 51)
        Me.txtDisplayWidth.Name = "txtDisplayWidth"
        Me.txtDisplayWidth.Size = New System.Drawing.Size(80, 23)
        Me.txtDisplayWidth.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Width"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Height"
        '
        'txtDisplayY
        '
        Me.txtDisplayY.Location = New System.Drawing.Point(240, 22)
        Me.txtDisplayY.Name = "txtDisplayY"
        Me.txtDisplayY.Size = New System.Drawing.Size(80, 23)
        Me.txtDisplayY.TabIndex = 1
        '
        'txtDisplayX
        '
        Me.txtDisplayX.Location = New System.Drawing.Point(74, 22)
        Me.txtDisplayX.Name = "txtDisplayX"
        Me.txtDisplayX.Size = New System.Drawing.Size(80, 23)
        Me.txtDisplayX.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Y"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Enabled = False
        Me.btnApply.Location = New System.Drawing.Point(232, 596)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(99, 25)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(3, 596)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(99, 25)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblNotify
        '
        Me.lblNotify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotify.ForeColor = System.Drawing.Color.Red
        Me.lblNotify.Location = New System.Drawing.Point(3, 566)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(328, 27)
        Me.lblNotify.TabIndex = 5
        Me.lblNotify.Text = "You have unsave changes."
        Me.lblNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotify.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cmbRenderer)
        Me.GroupBox4.Controls.Add(Me.lblWallpaperDownload)
        Me.GroupBox4.Controls.Add(Me.btnChgImage)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cmbImageFit)
        Me.GroupBox4.Controls.Add(Me.btnBackColor)
        Me.GroupBox4.Controls.Add(Me.btnDelImage)
        Me.GroupBox4.Controls.Add(Me.pbImage)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 232)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 334)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Image"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 303)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Renderer"
        '
        'cmbRenderer
        '
        Me.cmbRenderer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRenderer.FormattingEnabled = True
        Me.cmbRenderer.Location = New System.Drawing.Point(160, 300)
        Me.cmbRenderer.Name = "cmbRenderer"
        Me.cmbRenderer.Size = New System.Drawing.Size(160, 23)
        Me.cmbRenderer.TabIndex = 4
        '
        'lblWallpaperDownload
        '
        Me.lblWallpaperDownload.AutoSize = True
        Me.lblWallpaperDownload.Location = New System.Drawing.Point(119, 23)
        Me.lblWallpaperDownload.Name = "lblWallpaperDownload"
        Me.lblWallpaperDownload.Size = New System.Drawing.Size(86, 15)
        Me.lblWallpaperDownload.TabIndex = 5
        Me.lblWallpaperDownload.TabStop = True
        Me.lblWallpaperDownload.Text = "Get Wallpapers"
        '
        'btnChgImage
        '
        Me.btnChgImage.Location = New System.Drawing.Point(6, 22)
        Me.btnChgImage.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChgImage.Name = "btnChgImage"
        Me.btnChgImage.Size = New System.Drawing.Size(80, 23)
        Me.btnChgImage.TabIndex = 0
        Me.btnChgImage.Text = "Select.."
        Me.btnChgImage.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Background Color"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 245)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Image Fit"
        '
        'cmbImageFit
        '
        Me.cmbImageFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImageFit.FormattingEnabled = True
        Me.cmbImageFit.Location = New System.Drawing.Point(160, 242)
        Me.cmbImageFit.Name = "cmbImageFit"
        Me.cmbImageFit.Size = New System.Drawing.Size(160, 23)
        Me.cmbImageFit.TabIndex = 2
        '
        'btnBackColor
        '
        Me.btnBackColor.BackColor = System.Drawing.Color.White
        Me.btnBackColor.Location = New System.Drawing.Point(160, 271)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(80, 23)
        Me.btnBackColor.TabIndex = 3
        Me.btnBackColor.UseVisualStyleBackColor = False
        '
        'btnDelImage
        '
        Me.btnDelImage.Location = New System.Drawing.Point(240, 19)
        Me.btnDelImage.Name = "btnDelImage"
        Me.btnDelImage.Size = New System.Drawing.Size(80, 23)
        Me.btnDelImage.TabIndex = 1
        Me.btnDelImage.Text = "Clear"
        Me.btnDelImage.UseVisualStyleBackColor = True
        Me.btnDelImage.Visible = False
        '
        'pbImage
        '
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbImage.Location = New System.Drawing.Point(6, 48)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(314, 188)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 6
        Me.pbImage.TabStop = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(308, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(23, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "↻"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cmbDeviceZone
        '
        Me.cmbDeviceZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeviceZone.FormattingEnabled = True
        Me.cmbDeviceZone.Location = New System.Drawing.Point(86, 32)
        Me.cmbDeviceZone.Name = "cmbDeviceZone"
        Me.cmbDeviceZone.Size = New System.Drawing.Size(245, 23)
        Me.cmbDeviceZone.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 15)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Device Zone"
        '
        'ucScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmbDeviceZone)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbDeviceName)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblNotify)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ucScreen"
        Me.Size = New System.Drawing.Size(334, 626)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPort As NumBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbAutoconnect As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDisplayHeight As NumBox
    Friend WithEvents txtDisplayWidth As NumBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDisplayY As NumBox
    Friend WithEvents txtDisplayX As NumBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblNotify As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnDelImage As Button
    Friend WithEvents btnBackColor As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbImageFit As ComboBox
    Friend WithEvents btnChgImage As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lblWallpaperDownload As LinkLabel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbRenderer As ComboBox
    Friend WithEvents cmbDeviceName As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbDeviceZone As ComboBox
    Friend WithEvents Label12 As Label
End Class
