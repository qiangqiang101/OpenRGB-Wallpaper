Imports System.Text.RegularExpressions

Public Class frmScreenDialog

    Public Property MyParent As ucScreen

    Private Sub frmScreenDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xx As Integer = 0
        Dim yy As Integer = 0

        For Each scr In Windows.Forms.Screen.AllScreens.OrderBy(Function(x) x.Bounds.X)
            Dim button As New Button()
            With button
                .Font = New Font(Font.FontFamily, 20.0F, FontStyle.Regular)
                .Text = $"{UppercaseFirstLetter(scr.DeviceName.Replace("\\.\", "").ToLower)}"
                .Size = New Size(scr.Bounds.Width / 10, scr.Bounds.Height / 10)
                .Location = New Point(xx, yy)
                .Name = $"screen{Num(scr.DeviceName)}"
                .Tag = scr

                xx += .Size.Width
                yy += scr.Bounds.Y / 10
            End With
            AddHandler button.Click, AddressOf Button_Click
            Controls.Add(button)
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim button As Button = sender
        Dim scr As Windows.Forms.Screen = button.Tag
        MyParent.txtDisplayX.Text = scr.Bounds.X
        MyParent.txtDisplayY.Text = scr.Bounds.Y
        MyParent.txtDisplayWidth.Text = scr.Bounds.Width
        MyParent.txtDisplayHeight.Text = scr.Bounds.Height
        Me.Close()
    End Sub

    Private Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    Private Function Num(ByVal value As String) As Integer
        Dim returnVal As String = String.Empty
        Dim collection As MatchCollection = Regex.Matches(value, "\d+")
        For Each m As Match In collection
            returnVal += m.ToString()
        Next
        Return Convert.ToInt32(returnVal)
    End Function

End Class