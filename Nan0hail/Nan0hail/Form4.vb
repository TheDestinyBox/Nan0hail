Public Class WallpaperCreator

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Error loading image")
        End Try
    End Sub

End Class