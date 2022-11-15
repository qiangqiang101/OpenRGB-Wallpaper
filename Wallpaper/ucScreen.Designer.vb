<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucScreen
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
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimeout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.cbAutoconnect = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProtocol = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDisplayHeight = New System.Windows.Forms.TextBox()
        Me.txtDisplayWidth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDisplayY = New System.Windows.Forms.TextBox()
        Me.txtDisplayX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMatrixHeight = New System.Windows.Forms.TextBox()
        Me.txtMatrixWidth = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(74, 22)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(120, 23)
        Me.txtIPAddress.TabIndex = 0
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
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(299, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(120, 23)
        Me.txtPort.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Timeout"
        '
        'txtTimeout
        '
        Me.txtTimeout.Location = New System.Drawing.Point(74, 80)
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.Size = New System.Drawing.Size(120, 23)
        Me.txtTimeout.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(74, 51)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(345, 23)
        Me.txtClientName.TabIndex = 2
        '
        'cbAutoconnect
        '
        Me.cbAutoconnect.AutoSize = True
        Me.cbAutoconnect.Location = New System.Drawing.Point(74, 109)
        Me.cbAutoconnect.Name = "cbAutoconnect"
        Me.cbAutoconnect.Size = New System.Drawing.Size(95, 19)
        Me.cbAutoconnect.TabIndex = 5
        Me.cbAutoconnect.Text = "Autoconnect"
        Me.cbAutoconnect.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Protocol Version"
        '
        'txtProtocol
        '
        Me.txtProtocol.Location = New System.Drawing.Point(299, 80)
        Me.txtProtocol.Name = "txtProtocol"
        Me.txtProtocol.Size = New System.Drawing.Size(120, 23)
        Me.txtProtocol.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIPAddress)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProtocol)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbAutoconnect)
        Me.GroupBox1.Controls.Add(Me.txtClientName)
        Me.GroupBox1.Controls.Add(Me.txtTimeout)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SDK Client"
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
        Me.GroupBox2.Location = New System.Drawing.Point(3, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display"
        '
        'txtDisplayHeight
        '
        Me.txtDisplayHeight.Location = New System.Drawing.Point(299, 51)
        Me.txtDisplayHeight.Name = "txtDisplayHeight"
        Me.txtDisplayHeight.Size = New System.Drawing.Size(120, 23)
        Me.txtDisplayHeight.TabIndex = 3
        '
        'txtDisplayWidth
        '
        Me.txtDisplayWidth.Location = New System.Drawing.Point(77, 51)
        Me.txtDisplayWidth.Name = "txtDisplayWidth"
        Me.txtDisplayWidth.Size = New System.Drawing.Size(120, 23)
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
        Me.Label9.Location = New System.Drawing.Point(203, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Height"
        '
        'txtDisplayY
        '
        Me.txtDisplayY.Location = New System.Drawing.Point(299, 22)
        Me.txtDisplayY.Name = "txtDisplayY"
        Me.txtDisplayY.Size = New System.Drawing.Size(120, 23)
        Me.txtDisplayY.TabIndex = 1
        '
        'txtDisplayX
        '
        Me.txtDisplayX.Location = New System.Drawing.Point(77, 22)
        Me.txtDisplayX.Name = "txtDisplayX"
        Me.txtDisplayX.Size = New System.Drawing.Size(120, 23)
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
        Me.Label7.Location = New System.Drawing.Point(203, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Y"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMatrixHeight)
        Me.GroupBox3.Controls.Add(Me.txtMatrixWidth)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(144, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Matrix Size"
        '
        'txtMatrixHeight
        '
        Me.txtMatrixHeight.Location = New System.Drawing.Point(158, 51)
        Me.txtMatrixHeight.Name = "txtMatrixHeight"
        Me.txtMatrixHeight.Size = New System.Drawing.Size(120, 23)
        Me.txtMatrixHeight.TabIndex = 1
        '
        'txtMatrixWidth
        '
        Me.txtMatrixWidth.Location = New System.Drawing.Point(158, 22)
        Me.txtMatrixWidth.Name = "txtMatrixWidth"
        Me.txtMatrixWidth.Size = New System.Drawing.Size(120, 23)
        Me.txtMatrixWidth.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Width"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Height"
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(335, 337)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(99, 25)
        Me.btnApply.TabIndex = 5
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(3, 337)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(99, 25)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblNotify
        '
        Me.lblNotify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNotify.ForeColor = System.Drawing.Color.Red
        Me.lblNotify.Location = New System.Drawing.Point(108, 337)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(221, 25)
        Me.lblNotify.TabIndex = 5
        Me.lblNotify.Text = "You have unsave changes."
        Me.lblNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotify.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbImage)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 232)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(135, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Image"
        '
        'pbImage
        '
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.Location = New System.Drawing.Point(3, 19)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(129, 78)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 6
        Me.pbImage.TabStop = False
        '
        'ucScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblNotify)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ucScreen"
        Me.Size = New System.Drawing.Size(440, 367)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTimeout As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents cbAutoconnect As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProtocol As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDisplayHeight As TextBox
    Friend WithEvents txtDisplayWidth As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDisplayY As TextBox
    Friend WithEvents txtDisplayX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtMatrixHeight As TextBox
    Friend WithEvents txtMatrixWidth As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblNotify As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pbImage As PictureBox
End Class
