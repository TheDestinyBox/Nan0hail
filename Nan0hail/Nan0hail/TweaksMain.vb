Imports System.IO
Public Class TweaksMain
    Dim SelectedFilePath123 As String
    Dim SelectedFileName123 As String
    Dim FileModName1 As String
    Private Sub LoadListbox()
        Dim files() As String = IO.Directory.GetDirectories(path3)
        Dim fileWrappers As New List(Of FileWrapper)

        Dim fw1 As New FileWrapper("1000 Settings Icon")
        fileWrappers.Add(fw1)
        Dim fw2 As New FileWrapper("Default Icon Layout")
        fileWrappers.Add(fw2)
        Dim fw3 As New FileWrapper("Default Settings")
        fileWrappers.Add(fw3)
        Dim fw4 As New FileWrapper("Double Icons")
        fileWrappers.Add(fw4)
        Dim fw5 As New FileWrapper("Only Music Stuff")
        fileWrappers.Add(fw5)
        Dim fw6 As New FileWrapper("Only Music Stuff +")
        fileWrappers.Add(fw6)

        For Each file As String In files
            Dim fw As New FileWrapper(file)
            fileWrappers.Add(fw)
        Next

        ListBox1.DataSource = fileWrappers
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
        Dim fw As FileWrapper = DirectCast(ListBox1.SelectedItem, FileWrapper)
        SelectedFilePath123 = (fw.FullPath)
        SelectedFileName123 = (fw.FileName)
        Label2.Text = SelectedFileName123
        ' If SelectedFileName123 = "1000 Settings Icon" Or "Default Icon Layout" Or "Default Settings" Or "Double Icons" Or "Only Music Stuff" Or "Only Music Stuff +" Then
        'textbox2.text = td1.text
        If SelectedFileName123 = "1000 Settings Icon" Then
            TextBox1.Text = T1Dis.Text
            TextBox2.Text = T1Modfile.Text
            Exit Sub
        ElseIf SelectedFileName123 = "Default Icon Layout" Then
            TextBox1.Text = T2Dis.Text
            TextBox2.Text = T2Modfile.Text
            Exit Sub
        ElseIf SelectedFileName123 = "Default Settings" Then
            TextBox1.Text = T3Dis.Text
            TextBox2.Text = T3Modfile.Text
            Exit Sub
        ElseIf SelectedFileName123 = "Double Icons" Then
            TextBox1.Text = T4Dis.Text
            TextBox2.Text = T4Modfile.Text
            Exit Sub
        ElseIf SelectedFileName123 = "Only Music Stuff" Then
            TextBox1.Text = T5Dis.Text
            TextBox2.Text = T5Modfile.Text
            Exit Sub
        ElseIf SelectedFileName123 = "Only Music Stuff +" Then
            TextBox1.Text = T6Dis.Text
            TextBox2.Text = T6Modfile.Text
            Exit Sub
        End If

        'Else
        Try
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\Discription.txt")
            TextBox1.Text = objreader.ReadToEnd
            objreader.Close()
        Catch ex As Exception
            MsgBox("Cannot find Discription file. This tweak may be corrupted.")
            TextBox2.Text = ""
            Button1.Enabled = False
            TextBox1.Text = ""
            Exit Sub
        End Try

        If File.Exists(SelectedFilePath123 & "\IconState.plist") Then
            FileModName1 = "IconState.plist"
        End If
        If File.Exists(SelectedFilePath123 & "\iPodSettings.xml") Then
            FileModName1 = "iPodSettings.xml"
        End If
        If File.Exists(SelectedFilePath123 & "\iPodTimerSettings.xml") Then
            FileModName1 = "iPodTimerSettings.xml"
        End If
        If File.Exists(SelectedFilePath123 & "\Locals_US_FM.plist") Then
            FileModName1 = "Locals_US_FM.plist"
        End If
        If File.Exists(SelectedFilePath123 & "\Presets_US_FM.plist") Then
            FileModName1 = "Presets_US_FM.plist"
        End If
        If File.Exists(SelectedFilePath123 & "\iTunesPrefs.plist") Then
            FileModName1 = "iTunesPrefs.plist"
        End If
        If File.Exists(SelectedFilePath123 & "\CacheInfo.plist") Then
            FileModName1 = "CacheInfo.plist"
        End If
        If File.Exists(SelectedFilePath123 & "\ConfigInfo.plist") Then
            FileModName1 = "ConfigInfo.plist"
        End If

        TextBox2.Text = FileModName1
        '    End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Close()
    End Sub


    Private Sub TweaksMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        If Directory.Exists(path3) Then
        Else

            Directory.CreateDirectory(path3)
        End If

       
        LoadListbox()

        Dim fw As FileWrapper = DirectCast(ListBox1.SelectedItem, FileWrapper)
        SelectedFilePath123 = (fw.FullPath)
        SelectedFileName123 = (fw.FileName)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'Rewrite
        'If SelectedFileName123 = "1000 Settings Icon" Or "Default Icon Layout" Or "Default Settings" Or "Double Icons" Or "Only Music Stuff" Or "Only Music Stuff +" Then

        If SelectedFileName123 = "1000 Settings Icon" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(T1Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        ElseIf SelectedFileName123 = "Default Icon Layout" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(T2Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        ElseIf SelectedFileName123 = "Default Settings" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\iPodSettings.xml") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\iPodSettings.xml")
                writer.Write(T3Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        ElseIf SelectedFileName123 = "Double Icons" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(T4Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        ElseIf SelectedFileName123 = "Only Music Stuff" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(T5Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        ElseIf SelectedFileName123 = "Only Music Stuff +" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(T6Code.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
                Exit Sub
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
                Exit Sub
            End If
        End If

        '  End If

        'Dont Rewrite
        Try
            Dim objreader As New System.IO.StreamReader(SelectedFilePath123 & "\" & FileModName1)
            TextBox3.Text = objreader.ReadToEnd
            objreader.Close()
        Catch ex As Exception
            MsgBox("Error: Cannot find tweak file!")
            Exit Sub
        End Try


        If FileModName1 = "IconState.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\IconState.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\IconState.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "iPodSettings.xml" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\iPodSettings.xml") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\iPodSettings.xml")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "iPodTimerSettings.xml" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\iPodTimerSettings.xml") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\iPodTimerSettings.xml")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "Locals_US_FM.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\Radio\Locals_US_FM.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\Radio\Locals_US_FM.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "Presets_US_FM.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Device\Radio\Presets_US_FM.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Device\Radio\Presets_US_FM.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "iTunesPrefs.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\iTunes\iTunesPrefs.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\iTunes\iTunesPrefs.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "CacheInfo.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Speakable\CacheInfo.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Speakable\CacheInfo.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If
        If FileModName1 = "ConfigInfo.plist" Then
            If System.IO.File.Exists(MainDrive & "iPod_Control\Speakable\Radio\ConfigInfo.plist") = True Then
                Dim writer As New System.IO.StreamWriter(MainDrive & "iPod_Control\Speakable\Radio\ConfigInfo.plist")
                writer.Write(TextBox3.Text)
                writer.Close()
                Panel1.Visible = True
                Delay(3)
                TextBox4.Visible = True
                Label8.Visible = False
                Timer2.Start()
            Else
                MsgBox("Error, cannot find the file in the iPod to tweak.")
            End If
        End If



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
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected

            Label7.Visible = True
            Timer3.Start()
            Timer2.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            Label7.Visible = False
            Button1.Visible = True
            TextBox4.Text = "Done!"
            Button3.Visible = True
            Timer3.Stop()
            MsgBox("Done! The tweak is now on your iPod.")
        Else
            'Disconnected

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        CleanUp()
    End Sub

    Private Sub CleanUp()
        Panel1.Visible = False
        TextBox4.Text = "Hold on to the power button and minus volume button at the same time until you see the Apple logo. Then you must let go. After do not touch your device until done."
        Label7.Visible = False
        Label8.Visible = True
        Button3.Visible = False
        TextBox3.Text = ""
        TextBox4.Visible = False
    End Sub
End Class