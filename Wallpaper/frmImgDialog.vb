Imports System.Drawing.Imaging
Imports System.IO

Public Class frmImgDialog

    Public Property ParentPB() As PictureBox
    Public Property ParentDelBtn() As Button

    Private Sub frmImgDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each image In UserImage.ImagesLib
            Dim lvi As New ListViewItem(Path.GetFileName(image.FileName)) With {.Tag = image.Image}
            lvFiles.Items.Add(lvi)
        Next
    End Sub

    Private Sub lvFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFiles.SelectedIndexChanged
        If lvFiles.SelectedItems.Count <> 0 Then
            Dim firstSelecteditem As ListViewItem = lvFiles.SelectedItems(0)
            pbPreview.BackgroundImage = firstSelecteditem.Tag.ToString.Base64ToImage
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ofd As New OpenFileDialog() With {.Filter = "PNG Files (*.PNG)|*.PNG", .Multiselect = True, .Title = "Select Image file..."}
        If ofd.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            For Each file In ofd.FileNames
                Dim lvi As New ListViewItem(Path.GetFileName(file)) With {.Tag = Image.FromFile(file).ImageToBase64}
                lvFiles.Items.Add(lvi)
            Next

            SaveUserImage()
        End If
    End Sub

    Private Sub SaveUserImage()
        Try
            Dim newImage As New ImageData(UserImageFile)
            With newImage
                Dim newImagesLib As New List(Of ImageLib)
                For Each lvi As ListViewItem In lvFiles.Items
                    newImagesLib.Add(New ImageLib() With {.FileName = lvi.SubItems(0).Text, .Image = lvi.Tag.ToString})
                Next
                .ImagesLib = newImagesLib
                .SaveSilent()
            End With

            UserImage = New ImageData(UserImageFile).Instance
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each file As ListViewItem In lvFiles.SelectedItems
            lvFiles.Items.Remove(file)
        Next

        SaveUserImage()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If lvFiles.SelectedItems.Count > 1 Then
            MsgBox("Only the first image will be selected.", MsgBoxStyle.Exclamation, "Warning")
        End If
        Dim firstSelecteditem As ListViewItem = lvFiles.SelectedItems(0)
        ParentPB.BackgroundImage = firstSelecteditem.Tag.ToString.Base64ToImage
        ParentDelBtn.Show()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class