Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports OpenRGB.NET
Imports IWshRuntimeLibrary

Module Helper

    Public UserSettingFile As String = $"{My.Application.Info.DirectoryPath}\UserSettings.xml"
    Public UserSettings As UserSettingData = New UserSettingData(UserSettingFile).InstanceXml
    Public UserImageFile As String = $"{My.Application.Info.DirectoryPath}\UserImageDB.bin"
    Public UserImage As ImageData = New ImageData(UserImageFile).Instance

    <Extension>
    Public Function ToColor(modelcolor As Models.Color) As Color
        Return Color.FromArgb(modelcolor.R, modelcolor.G, modelcolor.B)
    End Function

    <Extension>
    Public Sub DrawRoundedRectangle(graphics As Graphics, pen As Pen, bounds As Rectangle, radius As Integer)
        If graphics Is Nothing Then
            Throw New ArgumentNullException("graphics")
        End If
        If pen Is Nothing Then
            Throw New ArgumentNullException("prush")
        End If

        Using path As GraphicsPath = RoundedRect(bounds, radius)
            graphics.DrawPath(pen, path)
        End Using
    End Sub

    <Extension>
    Public Sub FillRoundedRectangle(graphics As Graphics, brush As Brush, bounds As Rectangle, radius As Integer)
        If graphics Is Nothing Then
            Throw New ArgumentNullException("graphics")
        End If
        If brush Is Nothing Then
            Throw New ArgumentNullException("brush")
        End If

        Using path As GraphicsPath = RoundedRect(bounds, radius)
            graphics.FillPath(brush, path)
        End Using
    End Sub

    Private Function RoundedRect(bounds As Rectangle, radius As Integer) As GraphicsPath
        Dim diameter As Integer = radius * 2
        Dim size As Size = New Size(diameter, diameter)
        Dim arc As Rectangle = New Rectangle(bounds.Location, size)
        Dim path As GraphicsPath = New GraphicsPath

        If (radius = 0) Then
            path.AddRectangle(bounds)
            Return path
        End If

        'top left arc
        path.AddArc(arc, 180, 90)

        'top right arc
        arc.X = bounds.Right - diameter
        path.AddArc(arc, 270, 90)

        'bottom right arc
        arc.Y = bounds.Bottom - diameter
        path.AddArc(arc, 0, 90)

        'bottom left arc
        arc.X = bounds.Left
        path.AddArc(arc, 90, 90)

        path.CloseFigure()
        Return path
    End Function

    <Extension>
    Public Function Base64ToImage(Image As String) As Image
        Try
            If Image = Nothing Then
                Return Nothing
            Else
                Dim b64 As String = Image.Replace(" ", "+")
                Dim bite() As Byte = Convert.FromBase64String(b64)
                Dim stream As New MemoryStream(bite)
                Return Drawing.Image.FromStream(stream)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension>
    Public Function ImageToBase64(img As Image, Optional forceFormat As ImageFormat = Nothing, Optional formatting As Base64FormattingOptions = Base64FormattingOptions.InsertLineBreaks) As String
        Try
            If img IsNot Nothing Then
                If forceFormat Is Nothing Then forceFormat = img.RawFormat
                Dim stream As New MemoryStream
                img.Save(stream, forceFormat)
                Return Convert.ToBase64String(stream.ToArray, formatting)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    <Extension>
    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Dim newWidth As Integer
        Dim newHeight As Integer
        If preserveAspectRatio Then
            Dim originalWidth As Integer = image.Width
            Dim originalHeight As Integer = image.Height
            Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
            Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
            Dim percent As Single = If(percentHeight < percentWidth,
                    percentHeight, percentWidth)
            newWidth = CInt(originalWidth * percent)
            newHeight = CInt(originalHeight * percent)
        Else
            newWidth = size.Width
            newHeight = size.Height
        End If
        Dim newImage As Image = New Bitmap(newWidth, newHeight)
        Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
            graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic
            graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
        End Using
        Return newImage
    End Function

    Public Sub CreateShortcutInStartUp()
        Dim wshShell As New WshShell()
        Dim startupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

        Dim shortcut As IWshShortcut = CType(wshShell.CreateShortcut($"{startupFolder}\{Application.ProductName}.lnk"), IWshShortcut)
        With shortcut
            .TargetPath = Application.ExecutablePath
            .WorkingDirectory = Application.StartupPath
            .Description = "Launch OpenRGB Wallpaper"
            .Save()
        End With
    End Sub

    Public Sub DeleteShortcutInStartup()
        'Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
        Dim startupFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim shortcut As String = $"{startupFolder}\{Application.ProductName}.lnk"
        If IO.File.Exists(shortcut) Then IO.File.Delete(shortcut)
    End Sub

    Public Sub Log(ex As Exception)
        IO.File.AppendAllText(IO.Path.Combine($"{My.Application.Info.DirectoryPath}\", $"{Now.ToString("dd-MM-yyyy")}.log"), $"{Now.ToShortTimeString}: {ex.Message}{ex.StackTrace}{vbNewLine}")
    End Sub

    <Extension>
    Public Function RectToImage(brush As SolidBrush, pen As Pen, size As SizeF, shape As LEDShape) As Image
        Dim bitRect As New Bitmap(CInt(size.Width), CInt(size.Height))
        bitRect.Tag = brush.Color
        Dim graphic As Graphics = Graphics.FromImage(bitRect)

        Select Case shape
            Case LEDShape.Rectangle
                graphic.FillRectangle(brush, New RectangleF(0, 0, size.Width, size.Height))
                graphic.DrawRectangle(pen, New Rectangle(0, 0, size.Width, size.Height))
            Case LEDShape.RoundedRectangle
                graphic.FillRoundedRectangle(brush, New Rectangle(0, 0, size.Width, size.Height), 10)
                graphic.DrawRoundedRectangle(pen, New Rectangle(0, 0, size.Width, size.Height), 10)
            Case LEDShape.Sphere
                graphic.FillEllipse(brush, New RectangleF(0, 0, size.Width, size.Height))
                graphic.DrawEllipse(pen, New Rectangle(0, 0, size.Width, size.Height))
        End Select

        Return bitRect
    End Function

    <Extension>
    Public Function RectToImage(brush As SolidBrush, size As SizeF, shape As LEDShape) As Image
        Dim bitRect As New Bitmap(CInt(size.Width), CInt(size.Height))
        bitRect.Tag = brush.Color
        Dim graphic As Graphics = Graphics.FromImage(bitRect)

        Select Case shape
            Case LEDShape.Rectangle
                graphic.FillRectangle(brush, New RectangleF(0, 0, size.Width, size.Height))
            Case LEDShape.RoundedRectangle
                graphic.FillRoundedRectangle(brush, New Rectangle(0, 0, size.Width, size.Height), 10)
            Case LEDShape.Sphere
                graphic.FillEllipse(brush, New RectangleF(0, 0, size.Width, size.Height))
        End Select

        Return bitRect
    End Function

End Module
