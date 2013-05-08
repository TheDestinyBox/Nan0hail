Imports System.IO
Public Class STdev
    Dim SelectedFilePath123 As String
    Dim SelectedFileName123 As String
    Dim DebugMode As Boolean = False
    Dim deviceSelect As String


    Private Sub LoadListbox()
        Dim files() As String = IO.Directory.GetDirectories("c:\Nan0hail\Tweaks\My Tweaks")
        Dim fileWrappers As New List(Of FileWrapper)

        For Each file As String In files
            Dim fw As New FileWrapper(file)
            fileWrappers.Add(fw)
        Next

        ListBox2.DataSource = fileWrappers
    End Sub

    Private Sub STdev_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Directory.Exists(path1) Then
        Else

            Directory.CreateDirectory(path1)
        End If

        If Directory.Exists(path2) Then
        Else

            Directory.CreateDirectory(path2)
        End If

        MsgBox("Please back up your iPod Nano before testing tweaks on your iPod, just in case anything bad happeneds.")

        LoadListbox()
        Try
            Dim fw As FileWrapper = DirectCast(ListBox2.SelectedItem, FileWrapper)
            SelectedFilePath123 = (fw.FullPath)
            SelectedFileName123 = (fw.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        newselect1 = ListBox1.SelectedItem
        If newselect1 = "" Then
            MsgBox("Please Select a File")
            Exit Sub
        ElseIf newselect1 = "IconState.plist" Then
            TabPage1.Text = "IconState.plist"
            tab1textbox.Text = IconStatetxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "iPodSettings.xml" Then
            TabPage1.Text = "iPodSettings.xml"
            tab1textbox.Text = iPodSettingstxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "iPodTimerSettings.xml" Then
            TabPage1.Text = "iPodTimerSettings.xml"
            tab1textbox.Text = iPodTimerSettingstxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "SysInfoExtended" Then
            TabPage1.Text = "SysInfoExtended"
            tab1textbox.Text = SysInfoExtended.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "Locals_US_FM.plist" Then
            TabPage1.Text = "Locals_US_FM.plist"
            tab1textbox.Text = Locals_US_FMtxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "Presets_US_FM.plist" Then
            TabPage1.Text = "Presets_US_FM.plist"
            tab1textbox.Text = Presets_US_FMtxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "iTunesPrefs.plist" Then
            TabPage1.Text = "iTunesPrefs.plist"
            tab1textbox.Text = iTunesPrefstxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "CacheInfo.plist" Then
            TabPage1.Text = "CacheInfo.plist"
            tab1textbox.Text = CacheInfotxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        ElseIf newselect1 = "ConfigInfo.plist" Then
            TabPage1.Text = "ConfigInfo.plist"
            tab1textbox.Text = ConfigInfotxt.Text
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        'If Directory.Exists(path1 & tweakname) Then

        'Else
        '    Directory.CreateDirectory(path1 & tweakname)
        'End If

        'If Not File.Exists(path1 & tweakname & "\" & newselect1) Then
        '    File.Create(path1 & tweakname & "\" & newselect1)
        'Else
        'End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel5.Visible = True
        Panel4.Visible = False
        Panel3.Visible = True
        Panel2.Visible = True
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter a Name")
        Else
            tweakname = TextBox1.Text
            tweakdiscription = TextBox2.Text
            Panel3.Visible = False
        End If

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        SaveTweak()


    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button1.Enabled = True
        Panel3.Visible = False
        Panel2.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False


    End Sub

    Private Sub StartDebuggingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StartDebuggingToolStripMenuItem.Click
        If iDevice = "iPod Nano 7G" Then
            MsgBox("You cannot debug with an iPod Nano 7G!")
            Exit Sub
        End If
        If iDevice = "iPod Nano 7G (DFU)" Then
            MsgBox("You cannot debug with an iPod Nano 7G!")
            Exit Sub
        End If
        If DFUstartmode = True Then
            MsgBox("You cannot debug while your device is in DFU mode!")
            Exit Sub
        End If
        If OfflineMode = True Then
            MsgBox("You cannot debug on offline mode!")
            Exit Sub
        End If

        DebugMode = True
        STdebug.Show()


    End Sub

    Private Sub SaveTweak()

        If Directory.Exists(path1 & tweakname) Then

        Else
            Directory.CreateDirectory(path1 & tweakname)
        End If

        If Not File.Exists(path1 & tweakname & "\" & newselect1) Then
            File.Create(path1 & tweakname & "\" & newselect1)
        Else
        End If

        If Not File.Exists(path1 & tweakname & "\" & "Discription.txt") Then
            File.Create(path1 & tweakname & "\" & "Discription.txt")
            
        Else
        End If

        'Dim writer As New System.IO.StreamWriter(path1 & tweakname & "\" & newselect1)
        'writer.Write(tab1textbox.Text)
        'writer.Close()

        savetweak2()

    End Sub

    Private Sub savetweak2()

        Delay(1)

        Dim writer As New System.IO.StreamWriter(path1 & tweakname & "\" & newselect1)
        writer.Write(tab1textbox.Text)
        writer.Close()
        If tweakdiscription = "" Then
        Else
            Dim writer1 As New System.IO.StreamWriter(path1 & tweakname & "\" & "Discription.txt")
            writer1.Write(tweakdiscription)
            writer1.Close()

        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        tab1textbox.Undo()
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        tab1textbox.ClearUndo()
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        If iDevice = "iPod Nano 7G" Then
            MsgBox("You cannot debug with an iPod Nano 7G!")
            Exit Sub
        End If
        If iDevice = "iPod Nano 7G (DFU)" Then
            MsgBox("You cannot debug with an iPod Nano 7G!")
            Exit Sub
        End If
        If DFUstartmode = True Then
            MsgBox("You cannot debug while your device is in DFU mode!")
            Exit Sub
        End If
        If OfflineMode = True Then
            MsgBox("You cannot debug on offline mode!")
            Exit Sub
        End If


        DebugMode = True
        STdebug.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        SaveTweak()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        tab1textbox.Cut()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        tab1textbox.Copy()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        tab1textbox.Paste()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim fw As FileWrapper = DirectCast(ListBox2.SelectedItem, FileWrapper)
        SelectedFilePath123 = (fw.FullPath)
        SelectedFileName123 = (fw.FileName)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If File.Exists(SelectedFilePath123 & "\IconState.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\IconState.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "IconState.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\iPodSettings.xml") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\iPodSettings.xml")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "iPodSettings.xml"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\iPodTimerSettings.xml") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\iPodTimerSettings.xml")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "iPodTimerSettings.xml"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\Locals_US_FM.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\Locals_US_FM.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "Locals_US_FM.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\Presets_US_FM.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\Presets_US_FM.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "Presets_US_FM.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\iTunesPrefs.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\iTunesPrefs.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "iTunesPrefs.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\CacheInfo.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\CacheInfo.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "CacheInfo.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
        If File.Exists(SelectedFilePath123 & "\ConfigInfo.plist") Then
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\ConfigInfo.plist")
            tab1textbox.Text = objreader.ReadToEnd
            objreader.Close()
            tweakname = SelectedFileName123
            newselect1 = "ConfigInfo.plist"
            TabPage1.Text = newselect1
            Me.Text = tweakname & " - Nan0hail"
            Panel1.Visible = False
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        tab1textbox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        tab1textbox.ClearUndo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CutToolStripMenuItem.Click
        tab1textbox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        tab1textbox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        tab1textbox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        tab1textbox.SelectAll()
    End Sub


    Private Sub BuildTweak()

        If Directory.Exists(path3) Then

        Else
            Directory.CreateDirectory(path3)
        End If

        Delay(1)

        Dim path123 As String = path1 & tweakname & "\"

        If Directory.Exists(path3 & tweakname) Then
            Try
                System.IO.Directory.Delete(path3 & tweakname, True)
                '  Delay(1)
                Directory.CreateDirectory(path3 & tweakname)
                My.Computer.FileSystem.CopyDirectory(path123, path3 & tweakname)
                MsgBox("Your tweak has now been build and is ready! You can now find and select your tweak in the Tweaks section.")
            Catch ex As Exception
                MsgBox("Error 8746: Please save your tweak at least once before building a tweak.")
                Exit Sub
            End Try
        Else
            Try
                Directory.CreateDirectory(path3 & tweakname)
                My.Computer.FileSystem.CopyDirectory(path123, path3 & tweakname)
                MsgBox("Your tweak has now been build and is ready! You can now find and select your tweak in the Tweaks section.")
            Catch ex As Exception
                MsgBox("Error 8746: Please Try Again.")
                Exit Sub
            End Try
        End If




    End Sub


    Private Sub BuildTweekToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BuildTweekToolStripMenuItem.Click
        BuildTweak()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                MsgBox("Please select a device")
                Exit Sub
            End If
        End If

        If RadioButton1.Checked = True Then
            deviceSelect = "iPod Nano 6G"
        End If
        If RadioButton2.Checked = True Then
            deviceSelect = "iPod Nano 7G"
        End If


        Panel5.Visible = False

    End Sub
End Class