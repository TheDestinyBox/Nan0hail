Imports System.Management
Public Class NanoRevive
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Private WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Public OnlineMode = False
    Public OfflineMode = False
    Public iDevice As String
    Public DFUConnected As Boolean
    Public UploadediBSS As Boolean = False
    Public UploadediBEC As Boolean = False
    Public InRecovery As Boolean = False
    Public UploadedWTF As Boolean = False
    Public IrLooking4DFUPreparingtoUploadiBSS As Boolean = False
    Public Downloaded As Boolean = False
    Public IPSWPath As String
    Public temppath As String
    Public cmdline As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Close()
    End Sub


    Public Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        DFUConnected = False
        Do Until DFUConnected = True
            'Searching for DFU...
            console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (DFU) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                console.Text += (queryObj("Description"))
            Next
            If console.Text.Contains("DFU") Then
                DFUConnected = True
                If IrLooking4DFUPreparingtoUploadiBSS = True Then
                    IrLooking4DFUPreparingtoUploadiBSS = False

                End If
            End If
        Loop
    End Sub
    Public Sub Increase()
        If ProgressBar1.Value = 100 Then
            Exit Sub
        End If
        ProgressBar1.Value = ProgressBar1.Value + 3
    End Sub
    Public Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Do Until ProgressBar1.Value = 99
            ProgressBar1.Invoke(CType(AddressOf Increase, MethodInvoker))
            'Sleep(75)
        Loop
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start("http://twitter.com/iH8sn0w")
    End Sub
    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.Cyan
    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Red
    End Sub
    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.Cyan
    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Red
    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        Process.Start("http://twitter.com/iC_J")
    End Sub
    Private Sub Label14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.MouseEnter
        Label14.ForeColor = Color.Cyan
    End Sub
    Private Sub Label14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.MouseLeave
        Label14.ForeColor = Color.Red
    End Sub
    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        Process.Start("http://twitter.com/p0sixninja")
    End Sub
    Private Sub Label15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseEnter
        Label15.ForeColor = Color.Cyan
    End Sub
    Private Sub Label15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseLeave
        Label15.ForeColor = Color.Red
    End Sub
    Private Sub Label5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseEnter
        Label5.ForeColor = Color.Cyan
    End Sub
    Private Sub Label5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Red
    End Sub
    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        Label6.ForeColor = Color.Cyan
    End Sub
    Private Sub Label6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.Red
    End Sub
    Private Sub Label12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseEnter
        Label12.ForeColor = Color.Cyan
    End Sub
    Private Sub Label12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseLeave
        Label12.ForeColor = Color.Red
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://pod2g-ios.blogspot.com/")
    End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Process.Start("http://twitter.com/LiLBush81")
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start("http://twitter.com/w3st05")
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("http://twitter.com/planetbeing")
    End Sub
    Function HighlightWords(ByVal rtb As RichTextBox, ByVal sFindString As String, ByVal lColor As System.Drawing.Color) As Integer

        Dim iFoundPos As Integer 'Position of first character of match
        Dim iFindLength As Integer       'Length of string to find
        Dim iOriginalSelStart As Integer
        Dim iOriginalSelLength As Integer
        Dim iMatchCount As Integer      'Number of matches

        'Save the insertion points current location and length
        iOriginalSelStart = rtb.SelectionStart
        iOriginalSelLength = rtb.SelectionLength

        'Cache the length of the string to find
        iFindLength = Len(sFindString)

        'Attempt to find the first match
        iFoundPos = rtb.Find(sFindString, 0, RichTextBoxFinds.NoHighlight)
        While iFoundPos > 0
            iMatchCount = iMatchCount + 1
            iFoundPos = rtb.Find("THIS SHOULD NOT RETURN ANYTHIN---3$#@$#%@$#@!$@#$#@$@!#$!@#$!@$234-AND I MEAN IT!!!#@!$!%&*()(*&^%$#@!", iFoundPos + iFindLength, RichTextBoxFinds.NoHighlight)
        End While

        'Restore the insertion point to its original location and length
        rtb.SelectionStart = iOriginalSelStart
        rtb.SelectionLength = iOriginalSelLength

        'Return the number of matches
        HighlightWords = iMatchCount
    End Function

    Public Sub GoGoGadgetiREB()
        temppath = System.Environment.CurrentDirectory
        'Decide if I should run online or offline.

        If iDevice = "iPod Touch 4" Then
            Call run_limera1n()
            Exit Sub
        End If
    End Sub

    Public Sub GoGoGadget_iBEC()
        SaveToDisk("wait.img3", "wait.img3")
        Delay(6)
        Label11.Text = "Setting Up iBSS..."
        ProgressBar1.Value = 90
        cmdline = Quote.Text & "itunnel.exe" & Quote.Text & " -c " & Quote.Text & "bgcolor 0 255 0" & Quote.Text
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        MsgBox("If you have the green screen on your device." & Chr(13) & "You may restore to custom firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."
        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
    End Sub
    Public Sub GoGoGadgetCleanup()

        OfflineMode = False
        OnlineMode = False

        Label10.Visible = False
        Label10.Text = "DFU Helper"
        Label11.Visible = False
        Label16.Visible = False
        ProgressBar1.Visible = False
        GroupBox1.Visible = True
        IrLooking4DFUPreparingtoUploadiBSS = False
        DFUConnected = False
        InRecovery = False
        Button1.Enabled = True
    End Sub
    Public Sub CleanupDFU()
        Label11.Text = "Preparing..."
        Prepare.Visible = False
        dfuinstructions.Visible = False
        Label10.Left = (TabControl1.Width / 2) - (Label10.Width / 2)
        ProgressBar1.Style = ProgressBarStyle.Blocks
        Call GoGoGadgetiREB()
    End Sub
    Public Sub PrepDFU()
        'false visible stuff
    End Sub
    Public Sub DFUHelper()
        Label4.Invoke(CType(AddressOf PrepDFU, MethodInvoker))
        ProgressBar1.Value = 0
        GroupBox1.Visible = False
        Label11.Text = "Searching for DFU..."
        Label11.Visible = True
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Marquee

        Label10.Left = (TabControl1.Width / 2) - (Label10.Width / 2)
        Label10.Visible = True
        'Prepare.Visible = True
        Label16.Visible = True
        Label16.Text = "Press and Hold the Power + Minus Volume (45)"

        Delay(1)
        BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (44)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (43)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (42)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (41)"

        Delay(1)


        Label16.Text = "Press and Hold the Power + Minus Volume (40)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (39)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (38)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (37)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (36)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If

        Label16.Text = "Press and Hold the Power + Minus Volume (35)"


        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (34)"


        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (33)"


        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (32)"


        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If

        Label16.Text = "Press and Hold the Power + Minus Volume (31)"

        Delay(1)

        Label16.Text = "Press and Hold the Power + Minus Volume (30)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (29)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (28)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (27)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (26)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (25)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (24)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (23)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (22)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (21)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (20)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (19)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (18)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (17)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (16)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (15)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (14)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (13)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (12)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (11)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (10)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (9)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (8)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (7)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (6)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (5)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (4)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (3)"

        Delay(1)
        Label16.Text = "Press and Hold the Power + Minus Volume (2)"

        Delay(1)
        If DFUConnected = True Then
            Call CleanupDFU()
            Exit Sub
        End If
        Label16.Text = "Press and Hold the Power + Minus Volume (1)"

        Delay(1)
        Call GoGoGadgetCleanup()

        Label16.Visible = False
        MsgBox("You failed to Enter DFU. Please Try again.", MsgBoxStyle.Critical)
        Button1.Enabled = True

        GroupBox1.Visible = True
        iPod4btn.Text = "Retry"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub run_limera1n()
        Button1.Enabled = False
        Label16.Text = "Continue Holding Power + Minus Button"
        SaveToDisk("pois0n.exe", "pois0n.exe")
        Label11.Text = "Exploiting with limera1n..."
        BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        BackgroundWorker2.RunWorkerAsync()
        ProgressBar1.Visible = True
        ProgressBar1.Style = ProgressBarStyle.Blocks
        Label16.Text = "You may now let go of all buttons"
        cmdline = Quote.Text & "pois0n.exe" & Quote.Text & " run"
        ExecCmd(cmdline, True)
        ProgressBar1.Value = 100
        Label11.Text = "Done! :)"
        'Sleep(100)
        MsgBox("Your device is almost done reviving! Now you just need to open up iTunes and then iTunes will recognize it and do the rest.", MsgBoxStyle.Information)
        ' MsgBox("Your device is now in a PWNED DFU state (black screen)." & Chr(13) & Chr(13) & "You may now launch iTunes and do SHIFT + Restore" & Chr(13) & "to restore to Custom Firmware." & Chr(13) & Chr(13) & "Note: If you get Error 2003 in iTunes after Extracting," & Chr(13) & "Just unplug/replug it in and do it again.", MsgBoxStyle.Information)
        Label11.Text = "Cleaning up..."


        'Delete
        SaveToDisk("cleanup.bat", "cleanup.bat")
        Folder_Delete("Resources")
        cmdline = "cmd /c " & Quote.Text & "cleanup.bat" & Quote.Text
        ExecCmd(cmdline, True)
        cmdline = "cmd /c DEL " & Quote.Text & "cleanup.bat" & Quote.Text & " /f /q"
        ExecCmd(cmdline, True)
        Call GoGoGadgetCleanup()
    End Sub
    Public Sub AskforMode()
        GroupBox1.Visible = False
    End Sub

    Private Sub iPod4btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPod4btn.Click
        MsgBox("WARNING: If you are using a iPod Nano 7G, hold the Power button and the Home buttons instead of the Power and the minus volume")
        iDevice = "iPod Touch 4"
        Button1.Enabled = False
        Label4.Invoke(CType(AddressOf DFUHelper, MethodInvoker))

    End Sub

    Private Sub BackgroundWorker3_DoWork1(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Do Until InRecovery = True
            'Searching for Recovery...
            console.Text = " "
            Dim searcher As New ManagementObjectSearcher( _
                      "root\CIMV2", _
                      "SELECT * FROM Win32_PnPEntity WHERE Description = 'Apple Recovery (iBoot) USB Driver'")
            For Each queryObj As ManagementObject In searcher.Get()

                console.Text += (queryObj("Description"))
            Next
            If console.Text.Contains("iBoot") Then
                InRecovery = True
            End If
        Loop
        If UploadediBSS = True Then
            UploadediBSS = False

        ElseIf UploadediBEC = True Then
            UploadediBEC = False
            Label4.Invoke(CType(AddressOf GoGoGadget_iBEC, MethodInvoker))
        End If
    End Sub
End Class