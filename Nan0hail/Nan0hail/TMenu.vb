Public Class TMenu

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        STdev.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("Coming Soon")
    End Sub

    Private Sub TMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If OfflineMode = True Then
            Button2.Enabled = False
        End If
        If iDevice = "iPod Nano 7G" Then
            Button2.Enabled = False
        End If
        If iDevice = "iPod Nano 7G (DFU)" Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TweaksMain.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class