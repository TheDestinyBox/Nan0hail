Public Class SorA

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Edit_Mode_Advanced.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If iDevice = "iPod Nano 7G" Then
            MsgBox("iPod Nano 7G does not yet support Simple Mode")
        Else
            SimpleEM.Show()
            Me.Close()
        End If

    End Sub
End Class