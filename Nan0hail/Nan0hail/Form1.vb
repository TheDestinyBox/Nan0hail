Imports System.IO
Imports System.Management
Public Class MainMenu
    Dim Numofdrives As Integer = 0
    Public Function File_Exists(ByVal strFile As String) As Boolean

        If strFile.Length <> 0 Then
            Dim oFile As New FileInfo(strFile)
            If oFile.Exists = True Then
                File_Exists = True
            Else
                File_Exists = False
            End If
        End If

    End Function


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub MainMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label4.Text = iDevice
        If iDevice.Contains("DFU") Then
            OfflineMode = True
            DFUstartmode = True
        End If
        If OfflineMode = True Then
            If DFUstartmode = True Then
                Button1.Visible = False
                Button2.Enabled = False
                Button6.Enabled = False
                Timer1.Start()
            Else
                Button2.Enabled = False
                Label4.Visible = False
                Button6.Enabled = False
                Label5.Visible = False
                Button1.Visible = True
            End If
        Else
            'iPod Connection Status
            Timer1.Start()
        End If
        Label2.Text = Me.ProductVersion
        Shell("cmd /c taskkill /f /t /im iTunes.exe", AppWinStyle.Hide)
        Shell("cmd /c taskkill /f /t /im iTunesHelper.exe", AppWinStyle.Hide)

    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        TMenu.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        NanoRevive.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        SorA.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Backup.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
        '    Label5.Text = "Connected"
        '    Label5.ForeColor = Color.Green
        'Else
        '    Label5.Text = "Disconnected"
        '    Label5.ForeColor = Color.Red
        'End If
        RichTextBox1.Text = ""

        If System.IO.Directory.Exists("A:\" & "iPod_Control\") = True Then
            MainDrive = "A:\"
        End If
        If System.IO.Directory.Exists("B:\" & "iPod_Control\") = True Then
            MainDrive = "B:\"
        End If
        If System.IO.Directory.Exists("C:\" & "iPod_Control\") = True Then
            MainDrive = "C:\"
        End If
        If System.IO.Directory.Exists("D:\" & "iPod_Control\") = True Then
            MainDrive = "D:\"
        End If
        If System.IO.Directory.Exists("E:\" & "iPod_Control\") = True Then
            MainDrive = "E:\"
        End If
        If System.IO.Directory.Exists("F:\" & "iPod_Control\") = True Then
            MainDrive = "F:\"
        End If
        If System.IO.Directory.Exists("G:\" & "iPod_Control\") = True Then
            MainDrive = "G:\"
        End If
        If System.IO.Directory.Exists("H:\" & "iPod_Control\") = True Then
            MainDrive = "H:\"
        End If
        If System.IO.Directory.Exists("I:\" & "iPod_Control\") = True Then
            MainDrive = "I:\"
        End If
        If System.IO.Directory.Exists("J:\" & "iPod_Control\") = True Then
            MainDrive = "J:\"
        End If
        If System.IO.Directory.Exists("K:\" & "iPod_Control\") = True Then
            MainDrive = "K:\"
        End If
        If System.IO.Directory.Exists("L:\" & "iPod_Control\") = True Then
            MainDrive = "L:\"
        End If
        If System.IO.Directory.Exists("M:\" & "iPod_Control\") = True Then
            MainDrive = "M:\"
        End If
        If System.IO.Directory.Exists("N:\" & "iPod_Control\") = True Then
            MainDrive = "N:\"
        End If
        If System.IO.Directory.Exists("O:\" & "iPod_Control\") = True Then
            MainDrive = "O:\"
        End If
        If System.IO.Directory.Exists("P:\" & "iPod_Control\") = True Then
            MainDrive = "P:\"
        End If
        If System.IO.Directory.Exists("Q:\" & "iPod_Control\") = True Then
            MainDrive = "Q:\"
        End If
        If System.IO.Directory.Exists("R:\" & "iPod_Control\") = True Then
            MainDrive = "R:\"
        End If
        If System.IO.Directory.Exists("S:\" & "iPod_Control\") = True Then
            MainDrive = "S:\"
        End If
        If System.IO.Directory.Exists("T:\" & "iPod_Control\") = True Then
            MainDrive = "T:\"
        End If
        If System.IO.Directory.Exists("U:\" & "iPod_Control\") = True Then
            MainDrive = "U:\"
        End If
        If System.IO.Directory.Exists("V:\" & "iPod_Control\") = True Then
            MainDrive = "V:\"
        End If
        If System.IO.Directory.Exists("W:\" & "iPod_Control\") = True Then
            MainDrive = "W:\"
        End If
        If System.IO.Directory.Exists("X:\" & "iPod_Control\") = True Then
            MainDrive = "X:\"
        End If
        If System.IO.Directory.Exists("Y:\" & "iPod_Control\") = True Then
            MainDrive = "Y:\"
        End If
        If System.IO.Directory.Exists("Z:\" & "iPod_Control\") = True Then
            MainDrive = "Z:\"
        End If

        Dim searcher As New ManagementObjectSearcher( _
       "root\CIMV2", _
       "SELECT * FROM Win32_PnPEntity WHERE Caption = 'Apple Mobile Device USB Driver'")
        For Each queryObj As ManagementObject In searcher.Get()
            RichTextBox1.Text += ("DeviceID: {0}" & queryObj("DeviceID"))
        Next

        'iPod Nano 6G
        If RichTextBox1.Text.Contains("PID_1266") = True Then
            Label4.Text = "iPod Nano 6G"
            Label4.Visible = True
            iDevice = "iPod Nano 6G"
            PID = "PID_1266"
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
            Button2.Enabled = True
            Button6.Enabled = True
            If Not MainDrive = "" Then
                OfflineMode = False
                DFUstartmode = False
            End If

            'iPod Nano 6G DFU
        ElseIf RichTextBox1.Text.Contains("PID_1232") = True Then
            Label4.Text = "iPod Nano 6G (DFU)"
            Label4.Visible = True
            iDevice = "iPod Nano 6G"
            PID = "PID_1232"
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
            Button1.Visible = False
            Button2.Enabled = False
            Button6.Enabled = False
            OfflineMode = True
            DFUstartmode = True
            'iPod Nano 7G
        ElseIf RichTextBox1.Text.Contains("PID_1267") = True Then
            Label4.Text = "iPod Nano 7G"
            Label4.Visible = True
            iDevice = "iPod Nano 7G"
            PID = "PID_1267"
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
            Button2.Enabled = True
            Button6.Enabled = True
            If Not MainDrive = "" Then
                OfflineMode = False
                DFUstartmode = False
            End If
            'iPod Nano 6G DFU
        ElseIf RichTextBox1.Text.Contains("PID_1234") = True Then
            Label4.Text = "iPod Nano 7G (DFU)"
            Label4.Visible = True
            iDevice = "iPod Nano 7G"
            PID = "PID_1234"
            Label5.Text = "Connected"
            Label5.ForeColor = Color.Green
            Button1.Visible = False
            Button2.Enabled = False
            Button6.Enabled = False
            OfflineMode = True
            DFUstartmode = True
        Else
            Label4.Visible = False
            Label4.Text = ""
            Label5.Text = "Disconnected"
            Label5.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        LocateDevice.Show()
        Me.Close()
    End Sub
End Class
