<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWallpaper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWallpaper))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.skiaView = New SkiaSharp.Views.Desktop.SKGLControl()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'skiaView
        '
        Me.skiaView.BackColor = System.Drawing.Color.Black
        Me.skiaView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.skiaView.Location = New System.Drawing.Point(0, 0)
        Me.skiaView.Name = "skiaView"
        Me.skiaView.Size = New System.Drawing.Size(136, 77)
        Me.skiaView.TabIndex = 0
        Me.skiaView.VSync = False
        '
        'frmWallpaper
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(136, 77)
        Me.ControlBox = False
        Me.Controls.Add(Me.skiaView)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWallpaper"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OpenRGB Wallpaper"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents skiaView As SkiaSharp.Views.Desktop.SKGLControl
End Class
