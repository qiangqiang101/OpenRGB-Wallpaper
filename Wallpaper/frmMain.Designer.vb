<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbInterpolation = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCompositing = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSmoothing = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tcScreen = New System.Windows.Forms.TabControl()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddScreen = New System.Windows.Forms.Button()
        Me.cbStartAtLogin = New System.Windows.Forms.CheckBox()
        Me.taskbarMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbInterpolation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCompositing)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSmoothing)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graphics settings"
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
        Me.cmbInterpolation.Location = New System.Drawing.Point(148, 80)
        Me.cmbInterpolation.Name = "cmbInterpolation"
        Me.cmbInterpolation.Size = New System.Drawing.Size(306, 23)
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
        Me.cmbCompositing.Location = New System.Drawing.Point(148, 51)
        Me.cmbCompositing.Name = "cmbCompositing"
        Me.cmbCompositing.Size = New System.Drawing.Size(306, 23)
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
        Me.cmbSmoothing.Location = New System.Drawing.Point(148, 22)
        Me.cmbSmoothing.Name = "cmbSmoothing"
        Me.cmbSmoothing.Size = New System.Drawing.Size(306, 23)
        Me.cmbSmoothing.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(268, 542)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 25)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tcScreen
        '
        Me.tcScreen.Location = New System.Drawing.Point(12, 161)
        Me.tcScreen.Name = "tcScreen"
        Me.tcScreen.SelectedIndex = 0
        Me.tcScreen.Size = New System.Drawing.Size(460, 353)
        Me.tcScreen.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(373, 542)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 25)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddScreen
        '
        Me.btnAddScreen.Location = New System.Drawing.Point(373, 130)
        Me.btnAddScreen.Name = "btnAddScreen"
        Me.btnAddScreen.Size = New System.Drawing.Size(99, 25)
        Me.btnAddScreen.TabIndex = 1
        Me.btnAddScreen.Text = "+ Add Screen"
        Me.btnAddScreen.UseVisualStyleBackColor = True
        '
        'cbStartAtLogin
        '
        Me.cbStartAtLogin.AutoSize = True
        Me.cbStartAtLogin.Location = New System.Drawing.Point(12, 520)
        Me.cbStartAtLogin.Name = "cbStartAtLogin"
        Me.cbStartAtLogin.Size = New System.Drawing.Size(128, 19)
        Me.cbStartAtLogin.TabIndex = 3
        Me.cbStartAtLogin.Text = "Start with Windows"
        Me.cbStartAtLogin.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(484, 579)
        Me.ControlBox = False
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
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpenRGB Wallpaper"
        Me.taskbarMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
