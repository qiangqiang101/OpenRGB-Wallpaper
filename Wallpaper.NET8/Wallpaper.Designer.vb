<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wallpaper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        tmUpdate = New Timer(components)
        pbDiffuser = New PictureBox()
        tmCheckOpenRGB = New Timer(components)
        CType(pbDiffuser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tmUpdate
        ' 
        tmUpdate.Enabled = True
        tmUpdate.Interval = 10
        ' 
        ' pbDiffuser
        ' 
        pbDiffuser.BackColor = Color.Transparent
        pbDiffuser.Dock = DockStyle.Fill
        pbDiffuser.Location = New Point(0, 0)
        pbDiffuser.Name = "pbDiffuser"
        pbDiffuser.Size = New Size(140, 91)
        pbDiffuser.SizeMode = PictureBoxSizeMode.Zoom
        pbDiffuser.TabIndex = 1
        pbDiffuser.TabStop = False
        ' 
        ' tmCheckOpenRGB
        ' 
        tmCheckOpenRGB.Interval = 10000
        ' 
        ' Wallpaper
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(140, 91)
        ControlBox = False
        Controls.Add(pbDiffuser)
        Font = New Font("Segoe UI", 10F)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Wallpaper"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "OpenRGB Wallpaper 2"
        CType(pbDiffuser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tmUpdate As Timer
    Friend WithEvents pbDiffuser As PictureBox
    Friend WithEvents tmCheckOpenRGB As Timer
End Class
