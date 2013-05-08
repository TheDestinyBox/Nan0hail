Imports System.Management
Public Class LocateDevice
    Dim Numofdrives As Integer = 0
    Dim numoftries As Integer = 0
    Dim numofdevices As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        iDevice = ""
        PID = ""
        If System.IO.Directory.Exists("A:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "A:\"
        End If
        If System.IO.Directory.Exists("B:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "B:\"
        End If
        If System.IO.Directory.Exists("C:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "C:\"
        End If
        If System.IO.Directory.Exists("D:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "D:\"
        End If
        If System.IO.Directory.Exists("E:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "E:\"
        End If
        If System.IO.Directory.Exists("F:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "F:\"
        End If
        If System.IO.Directory.Exists("G:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "G:\"
        End If
        If System.IO.Directory.Exists("H:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "H:\"
        End If
        If System.IO.Directory.Exists("I:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "I:\"
        End If
        If System.IO.Directory.Exists("J:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "J:\"
        End If
        If System.IO.Directory.Exists("K:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "K:\"
        End If
        If System.IO.Directory.Exists("L:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "L:\"
        End If
        If System.IO.Directory.Exists("M:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "M:\"
        End If
        If System.IO.Directory.Exists("N:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "N:\"
        End If
        If System.IO.Directory.Exists("O:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "O:\"
        End If
        If System.IO.Directory.Exists("P:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "P:\"
        End If
        If System.IO.Directory.Exists("Q:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "Q:\"
        End If
        If System.IO.Directory.Exists("R:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "R:\"
        End If
        If System.IO.Directory.Exists("S:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "S:\"
        End If
        If System.IO.Directory.Exists("T:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "T:\"
        End If
        If System.IO.Directory.Exists("U:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "U:\"
        End If
        If System.IO.Directory.Exists("V:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "V:\"
        End If
        If System.IO.Directory.Exists("W:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "W:\"
        End If
        If System.IO.Directory.Exists("X:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "X:\"
        End If
        If System.IO.Directory.Exists("Y:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "Y:\"
        End If
        If System.IO.Directory.Exists("Z:\" & "iPod_Control\") = True Then
            Numofdrives = Numofdrives + 1
            MainDrive = "Z:\"
        End If


        Dim searcher As New ManagementObjectSearcher( _
           "root\CIMV2", _
           "SELECT * FROM Win32_PnPEntity WHERE Caption = 'Apple Mobile Device USB Driver'")
        For Each queryObj As ManagementObject In searcher.Get()
            If RichTextBox1.Text = "" Then
                RichTextBox1.Text += ("DeviceID: {0}" & queryObj("DeviceID"))
                Timer1.Stop()
            ElseIf RichTextBox2.Text = "" Then
                RichTextBox2.Text += ("DeviceID: {0}" & queryObj("DeviceID"))
                Timer1.Stop()
            End If
        Next
        'iPod Nano 6G
        If RichTextBox1.Text.Contains("PID_1266") = True Then
            iDevice = "iPod Nano 6G"
            PID = "PID_1266"
            numofdevices = 1
        End If
        If RichTextBox2.Text.Contains("PID_1266") = True Then
            numofdevices = 2
        End If
        'iPod Nano 6G DFU
        If RichTextBox1.Text.Contains("PID_1232") = True Then
            iDevice = "iPod Nano 6G (DFU)"
            PID = "PID_1232"
            numofdevices = 1
        End If
        If RichTextBox2.Text.Contains("PID_1232") = True Then
            numofdevices = 2
        End If
        'iPod Nano 7G
        If RichTextBox1.Text.Contains("PID_1267") = True Then
            iDevice = "iPod Nano 7G"
            PID = "PID_1267"
            numofdevices = 1
        End If
        If RichTextBox2.Text.Contains("PID_1267") = True Then
            numofdevices = 2
        End If
        'iPod Nano 7G DFU
        If RichTextBox1.Text.Contains("PID_1234") = True Then
            iDevice = "iPod Nano 7G"
            PID = "PID_1234"
            numofdevices = 1
        End If
        If RichTextBox2.Text.Contains("PID_1234") = True Then
            numofdevices = 2
        End If


        If Numofdrives = 0 Then
            If numofdevices = 1 Then
                '6G in DFU
                If RichTextBox1.Text.Contains("PID_1232") = True Then
                    iDevice = "iPod Nano 6G (DFU)"
                    PID = "PID_1232"
                    Timer1.Stop()
                    Timer2.Stop()
                    DFUstartmode = True
                    OfflineMode = True
                    MainMenu.Show()
                    Me.Close()
                    Exit Sub
                End If
                If RichTextBox1.Text.Contains("PID_12?") = True Then
                    iDevice = "iPod Nano 7G (DFU)"
                    PID = "PID_1234"
                    Timer1.Stop()
                    Timer2.Stop()
                    DFUstartmode = True
                    OfflineMode = True
                    MainMenu.Show()
                    Me.Close()
                    Exit Sub
                End If
            End If
            Timer2.Start()
            Timer1.Start()
        ElseIf Numofdrives = 1 Then
            If numofdevices = 1 Then
                Timer1.Stop()
                Timer2.Stop()
                OfflineMode = False
                DFUstartmode = False
                MainMenu.Show()
                Me.Close()
                Exit Sub
            End If
            If numofdevices = 2 Then
                Label5.Visible = True
                Button2.Visible = True
                Timer2.Stop()
                Timer1.Stop()
                Label1.Visible = False
            End If
        ElseIf numofdevices = 2 Then
            Label5.Visible = True
            Button2.Visible = True
            Timer2.Stop()
            Timer1.Stop()
            Label1.Visible = False
            Exit Sub
        ElseIf Numofdrives = 2 Then
            PID = ""
            Timer2.Stop()
            Timer1.Stop()
            Label3.Visible = True
            Button3.Visible = True
            Label1.Visible = False
        End If
    End Sub

    Private Sub LocateDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If numoftries = 20 Then
            Timer2.Stop()
            Timer1.Stop()
            Button2.Visible = True
            Label1.Text = "Cannot find iPod!"
        Else
            numoftries = numoftries + 1
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        Button2.Visible = False
        numoftries = 0
        Numofdrives = 0
        numofdevices = 0
        Label1.Text = "Locating iPod..."
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        Label5.Visible = False
        Timer1.Start()
        Label1.Visible = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Label1.Text = "Locating iPod" Then
            Label1.Text = "Locating iPod."
            Exit Sub
        End If
        If Label1.Text = "Locating iPod." Then
            Label1.Text = "Locating iPod.."
            Exit Sub
        End If
        If Label1.Text = "Locating iPod.." Then
            Label1.Text = "Locating iPod..."
            Exit Sub
        End If
        If Label1.Text = "Locating iPod..." Then
            Label1.Text = "Locating iPod"
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OfflineMode = True
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.Description = "Select iPod Nano 6G"
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
        folderBrowserDialog.ShowNewFolderButton = True

        If folderBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            MainDrive = folderBrowserDialog.SelectedPath
            If System.IO.Directory.Exists(MainDrive & "iPod_Control") = True Then
                RichTextBox1.Text = ""
                Dim searcher As New ManagementObjectSearcher( _
         "root\CIMV2", _
         "SELECT * FROM Win32_PnPEntity WHERE Caption = 'Apple Mobile Device USB Driver'")
                For Each queryObj As ManagementObject In searcher.Get()

                    RichTextBox1.Text += ("DeviceID: {0}" & queryObj("DeviceID"))
                Next
                'iPod Nano 6G
                If RichTextBox1.Text.Contains("PID_1266") = True Then
                    iDevice = "iPod Nano 6G"
                    PID = "PID_1266"
                End If
                'iPod Nano 6G DFU
                If RichTextBox1.Text.Contains("PID_1232") = True Then
                    iDevice = "iPod Nano 6G (DFU)"
                    PID = "PID_1232"
                    OfflineMode = True
                    DFUstartmode = True
                End If
                'iPod Nano 7G
                If RichTextBox1.Text.Contains("PID_1267") = True Then
                    iDevice = "iPod Nano 7G"
                    PID = "PID_1267"
                End If
                'iPod Nano 7G DFU
                If RichTextBox1.Text.Contains("PID_1234") = True Then
                    iDevice = "iPod Nano 7G (DFU)"
                    PID = "PID_1234"
                    OfflineMode = True
                    DFUstartmode = True
                End If
                If Not PID = "" Then
                    OfflineMode = False
                    MainMenu.Show()
                    Me.Close()
                Else
                    Label4.Visible = True
                End If
            Else
                Label4.Visible = True
            End If
        End If
    End Sub
End Class