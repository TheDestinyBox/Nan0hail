Public Class SimpleEM
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub SimpleEM_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        TabPage3.Dispose()
        TabPage4.Dispose()
        TabPage5.Dispose()
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

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If TextBox22.Text = "" Then
            Label8.Text = "15"
            Button12.Enabled = False
        Else
            If TextBox23.Text = "" Then
                Label8.Text = "14"
                Button12.Enabled = True
            Else
                If TextBox24.Text = "" Then
                    Label8.Text = "13"
                    Button12.Enabled = True
                Else
                    If TextBox25.Text = "" Then
                        Label8.Text = "12"
                        Button12.Enabled = True
                    Else
                        If TextBox26.Text = "" Then
                            Label8.Text = "11"
                            Button12.Enabled = True
                        Else
                            If TextBox27.Text = "" Then
                                Label8.Text = "10"
                                Button12.Enabled = True
                            Else
                                If TextBox28.Text = "" Then
                                    Label8.Text = "9"
                                    Button12.Enabled = True
                                Else
                                    If TextBox29.Text = "" Then
                                        Label8.Text = "8"
                                        Button12.Enabled = True
                                    Else
                                        If TextBox30.Text = "" Then
                                            Label8.Text = "7"
                                            Button12.Enabled = True
                                        Else
                                            If TextBox31.Text = "" Then
                                                Label8.Text = "6"
                                                Button12.Enabled = True
                                            Else
                                                If TextBox32.Text = "" Then
                                                    Label8.Text = "5"
                                                    Button12.Enabled = True
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        Label8.Text = "4"
                                                        Button12.Enabled = True
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            Label8.Text = "3"
                                                            Button12.Enabled = True
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                Label8.Text = "2"
                                                                Button12.Enabled = True
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    Label8.Text = "1"
                                                                    Button12.Enabled = True
                                                                Else

                                                                    Label8.Text = "0"

                                                                    Button4.Enabled = False
                                                                    Button5.Enabled = False
                                                                    Button6.Enabled = False
                                                                    Button7.Enabled = False
                                                                    Button8.Enabled = False
                                                                    Button9.Enabled = False
                                                                    Button10.Enabled = False
                                                                    Button11.Enabled = False
                                                                    Button12.Enabled = True
                                                                    Button13.Enabled = False
                                                                    Button14.Enabled = False
                                                                    Button15.Enabled = False
                                                                    Button16.Enabled = False
                                                                    Button17.Enabled = False
                                                                    Button18.Enabled = False
                                                                    Button19.Enabled = False
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If TextBox36.Text = "" Then
            If TextBox35.Text = "" Then
                If TextBox34.Text = "" Then
                    If TextBox33.Text = "" Then
                        If TextBox32.Text = "" Then
                            If TextBox31.Text = "" Then
                                If TextBox30.Text = "" Then
                                    If TextBox29.Text = "" Then
                                        If TextBox28.Text = "" Then
                                            If TextBox27.Text = "" Then
                                                If TextBox26.Text = "" Then
                                                    If TextBox25.Text = "" Then
                                                        If TextBox24.Text = "" Then
                                                            If TextBox23.Text = "" Then
                                                                If TextBox22.Text = "" Then
                                                                    Button12.Enabled = False
                                                                Else
                                                                    TextBox22.Text = ""
                                                                End If
                                                            Else
                                                                TextBox23.Text = ""
                                                            End If
                                                        Else
                                                            TextBox24.Text = ""
                                                        End If
                                                    Else
                                                        TextBox25.Text = ""
                                                    End If
                                                Else
                                                    TextBox26.Text = ""
                                                End If
                                            Else
                                                TextBox27.Text = ""
                                            End If
                                        Else
                                            TextBox28.Text = ""
                                        End If
                                    Else
                                        TextBox29.Text = ""
                                    End If
                                Else
                                    TextBox30.Text = ""
                                End If
                            Else
                                TextBox31.Text = ""
                            End If
                        Else
                            TextBox32.Text = ""
                        End If
                    Else
                        TextBox33.Text = ""
                    End If
                Else
                    TextBox34.Text = ""
                End If
            Else
                TextBox35.Text = ""
            End If
        Else
            TextBox36.Text = ""
        End If
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox37.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox37.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox37.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox37.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox37.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox37.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox37.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox37.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox37.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox37.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox37.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox37.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox37.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox37.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox37.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox38.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox38.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox38.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox38.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox38.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox38.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox38.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox38.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox38.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox38.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox38.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox38.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox38.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox38.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox38.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox39.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox39.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox39.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox39.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox39.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox39.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox39.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox39.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox39.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox39.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox39.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox39.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox39.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox39.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox39.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox40.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox40.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox40.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox40.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox40.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox40.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox40.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox40.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox40.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox40.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox40.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox40.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox40.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox40.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox40.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox41.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox41.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox41.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox41.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox41.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox41.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox41.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox41.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox41.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox41.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox41.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox41.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox41.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox41.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox41.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox42.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox42.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox42.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox42.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox42.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox42.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox42.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox42.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox42.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox42.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox42.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox42.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox42.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox42.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox42.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox43.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox43.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox43.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox43.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox43.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox43.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox43.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox43.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox43.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox43.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox43.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox43.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox43.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox43.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox43.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox44.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox44.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox44.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox44.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox44.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox44.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox44.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox44.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox44.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox44.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox44.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox44.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox44.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox44.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox44.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
            Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
        writer.Write(TextBox45.Text & TextBox22.Text & TextBox23.Text & TextBox24.Text & TextBox25.Text & TextBox26.Text & TextBox27.Text & TextBox28.Text & TextBox29.Text & TextBox30.Text & TextBox31.Text & TextBox32.Text & TextBox33.Text & TextBox34.Text & TextBox35.Text & TextBox36.Text & TextBox46.Text)
        writer.Close()
        Label2.Text = Label2.Text + "Icons"
        Panel1.Visible = True
            Timer3.Start()
        Else
            MsgBox("Error 8528: Cannot find file.")
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox47.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox47.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox47.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox47.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox47.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox47.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox47.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox47.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox47.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox47.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox47.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox47.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox47.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox47.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox47.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox48.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox48.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox48.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox48.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox48.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox48.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox48.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox48.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox48.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox48.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox48.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox48.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox48.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox48.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox48.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox49.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox49.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox49.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox49.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox49.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox49.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox49.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox49.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox49.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox49.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox49.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox49.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox49.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox49.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox49.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox50.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox50.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox50.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox50.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox50.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox50.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox50.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox50.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox50.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox50.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox50.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox50.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox50.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox50.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox50.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox51.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox51.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox51.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox51.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox51.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox51.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox51.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox51.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox51.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox51.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox51.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox51.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox51.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox51.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox51.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox52.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox52.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox52.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox52.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox52.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox52.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox52.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox52.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox52.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox52.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox52.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox52.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox52.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox52.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox52.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox53.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox53.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox53.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox53.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox53.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox53.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox53.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox53.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox53.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox53.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox53.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox53.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox53.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox53.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox53.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox13.Text = "1"
        Else
            TextBox13.Text = "0"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox21.Text = "1"
        Else
            TextBox21.Text = "0"
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TextBox7.Text > 100 Then
            MsgBox("Brightness level too high. Please choose a brightness level from 1-100")
            TextBox7.Text = "50"
        Else
            If TextBox7.Text <= 1 Then
                MsgBox("Brightness level too low. Please choose a brightness level from 1-100")
                TextBox7.Text = "50"
            Else
                If TextBox7.Text = "" Then
                    MsgBox("Please Enter a number between 1-100 for brightness level")
                Else
                    If System.IO.File.Exists(MainDrive & "iPod_Control\Device\iPodSettings.xml") = True Then
                        Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\iPodSettings.xml")
                        writer.Write(TextBox8.Text & TextBox13.Text & TextBox9.Text & TextBox7.Text & TextBox10.Text & TextBox14.Text & TextBox11.Text & TextBox20.Text & TextBox12.Text & TextBox21.Text & TextBox15.Text)
                        writer.Close()
                        'Reboot
                        Label2.Text = Label2.Text + "Settings"
                        Panel1.Visible = True
                        Timer3.Start()
                    Else
                        MsgBox("Error 8529: Cannot find file.")
                    End If
                    End If
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = False Then
            'Disonnected

            Label3.Visible = True
            Timer4.Start()
            Timer3.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            Label3.Visible = False
            TextBox1.Text = "Done!"
            Button20.Visible = True
            Timer4.Stop()
        Else
            'Disconnected

        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        If TextBox22.Text = "" Then
            TextBox22.Text = TextBox2.Text
        Else
            If TextBox23.Text = "" Then
                TextBox23.Text = TextBox2.Text
            Else
                If TextBox24.Text = "" Then
                    TextBox24.Text = TextBox2.Text
                Else
                    If TextBox25.Text = "" Then
                        TextBox25.Text = TextBox2.Text
                    Else
                        If TextBox26.Text = "" Then
                            TextBox26.Text = TextBox2.Text
                        Else
                            If TextBox27.Text = "" Then
                                TextBox27.Text = TextBox2.Text
                            Else
                                If TextBox28.Text = "" Then
                                    TextBox28.Text = TextBox2.Text
                                Else
                                    If TextBox29.Text = "" Then
                                        TextBox29.Text = TextBox2.Text
                                    Else
                                        If TextBox30.Text = "" Then
                                            TextBox30.Text = TextBox2.Text
                                        Else
                                            If TextBox31.Text = "" Then
                                                TextBox31.Text = TextBox2.Text
                                            Else
                                                If TextBox32.Text = "" Then
                                                    TextBox32.Text = TextBox2.Text
                                                Else
                                                    If TextBox33.Text = "" Then
                                                        TextBox33.Text = TextBox2.Text
                                                    Else
                                                        If TextBox34.Text = "" Then
                                                            TextBox34.Text = TextBox2.Text
                                                        Else
                                                            If TextBox35.Text = "" Then
                                                                TextBox35.Text = TextBox2.Text
                                                            Else
                                                                If TextBox36.Text = "" Then
                                                                    TextBox36.Text = TextBox2.Text
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class