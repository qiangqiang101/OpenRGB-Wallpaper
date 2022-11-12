Imports Win32Wrapper

Public Class frmMain

    Private wpForms As New List(Of frmWallpaper)

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IO.File.Exists(UserSettingFile) Then
            Dim currScreen As New Screen()
            With currScreen
                .Position = System.Windows.Forms.Screen.FromControl(Me).Bounds.Location
                .Size = System.Windows.Forms.Screen.FromControl(Me).Bounds.Size
                .MatrixWidth = 32
                .MatrixHeight = 18
                .IPAddress = "127.0.0.1"
                .Port = 6742
                .Name = "Wallpaper1"
                .Autoconnect = False
                .Timeout = 1000
                .ProtocolVersion = 2
            End With
            Dim screenList As New List(Of Screen)
            screenList.Add(currScreen)

            Dim newUserSetting As New UserSettingData(UserSettingFile)
            With newUserSetting
                .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                .CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                .InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
                .Screens = screenList
                .SaveSilentXml()
            End With
            UserSettings = New UserSettingData(UserSettingFile).InstanceXml
        End If

        SetAsWallpaper()

        niNotify.Visible = True
        niNotify.ShowBalloonTip(1000)
        niNotify.Text = "OpenRGB Wallpaper"

    End Sub

    Private Sub SetAsWallpaper()
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

        For Each screen In UserSettings.Screens
            Dim newWP As New frmWallpaper
            With newWP
                .WScreen = screen
                .Text = screen.Name
                .StartPosition = FormStartPosition.Manual
                .Location = screen.Position
                .Size = screen.Size
                .Show()
                W32.SetParent(.Handle, workerw)
            End With
            wpForms.Add(newWP)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
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
End Class