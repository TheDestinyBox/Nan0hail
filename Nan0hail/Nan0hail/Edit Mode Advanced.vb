Public Class Edit_Mode_Advanced
    Dim SaveType As String
    Private Sub Edit_Mode_Advanced_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer4.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green


        Else
            Label5.Text = "Disconnected"
            Label5.ForeColor = Color.Red

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If iDevice = "iPod Nano 7G" Then
            MsgBox("Editing icons is not yet supported for the iPod Nano 7G")
        Else
            SaveType = "Icons"
            Button5.Visible = False
            Panel1.Visible = True
            SaveChanges()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        SaveType = "Settings"
        Button5.Visible = False
        Panel1.Visible = True
        SaveChanges()
    End Sub

    Private Sub SaveChanges()
        If SaveType = "Icons" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Label2.Text = Label2.Text + "Icons"
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(TextBox7.Text)
                writer.Close()
                TextBox1.Visible = True
                Timer2.Start()
            Else
                MsgBox("Error 8628: Cannot find file.")
                Panel1.Visible = False
            End If
        ElseIf SaveType = "Settings" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\iPodSettings.xml") = True Then
                Label2.Text = Label2.Text + "Settings"
                Dim writer2 As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\iPodSettings.xml")
                writer2.Write(TextBox8.Text)
                writer2.Close()
                TextBox1.Visible = True
                Timer2.Start()
            Else
                MsgBox("Error 8629: Cannot find file.")
                Panel1.Visible = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected

            Label3.Visible = True
            Timer3.Start()
            Timer2.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            Label3.Visible = False
            TextBox1.Text = "Done!"
            Button1.Visible = True
            Timer3.Stop()
        Else
            'Disconnected

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer4.Start()
        Panel1.Visible = False
        Button5.Visible = True
        TextBox1.Text = "Hold on to the power button and minus volume button at the same time until you see the Apple logo. Then you must let go. After do not touch your device until done."
        TextBox1.Visible = False
        Button1.Visible = False
        Label2.Text = "Making Changes to the "
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If Label5.Text = "Connected" Then
            Try
                Dim objreader As New System.IO.StreamReader(MainDrive & "iPod_Control\Device\IconState.plist")
                TextBox7.Text = objreader.ReadToEnd
                objreader.Close()
                Button2.Enabled = True
            Catch ex As Exception
                TextBox7.Text = "Cannot find IconState.plist file on Nano!"
                Button2.Enabled = False
            End Try

            Try
                Dim objreader2 As New System.IO.StreamReader(MainDrive & "iPod_Control\Device\iPodSettings.xml")
                TextBox8.Text = objreader2.ReadToEnd
                objreader2.Close()
                Timer4.Stop()
                Button4.Enabled = True
            Catch ex As Exception
                TextBox8.Text = "Cannot find iPodSettings.xml file on Nano!"
                Button4.Enabled = False
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Timer4.Start()
    End Sub
End Class