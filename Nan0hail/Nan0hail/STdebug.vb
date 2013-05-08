Imports System.IO
Public Class STdebug
    Dim path As String = MainDrive & "iPod_Control\"
    Dim destination As String = "c:\Nan0hail\Tweaks\Extra\"
    Dim fileroot1 As String = "c:\Nan0hail\Tweaks\Extra\"
   
    Private Sub STdebug_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        STdev.ToolStrip1.Enabled = False
        STdev.MenuStrip1.Enabled = False
        STdev.tab1textbox.Enabled = False
        STdev.tab1textbox.ReadOnly = True
        If newselect1 = "" Then
            MsgBox("Error 324975: If you ever see this error(which I don't think anyone will), please email me and tell me this error code. My email: thedestinybox@gmail.com")
            Exit Sub
        ElseIf newselect1 = "IconState.plist" Then
            path = path + "Device\IconState.plist"
            destination = destination + "IconState.plist"
        ElseIf newselect1 = "iPodSettings.xml" Then
            path = path + "Device\iPodSettings.xml"
            destination = destination + "iPodSettings.xml"
        ElseIf newselect1 = "iPodTimerSettings.xml" Then
            path = path + "Device\iPodTimerSettings.xml"
            destination = destination + "iPodTimerSettings.xml"
        ElseIf newselect1 = "SysInfoExtended" Then
            path = path + "Device\SysInfoExtended"
            destination = destination + "SysInfoExtended"
        ElseIf newselect1 = "Locals_US_FM.plist" Then
            path = path + "Device\Radio\Locals_US_FM.plist"
            destination = destination + "Locals_US_FM.plist"
        ElseIf newselect1 = "Presets_US_FM.plist" Then
            path = path + "Device\Radio\Presets_US_FM.plist"
            destination = destination + "Presets_US_FM.plist"
        ElseIf newselect1 = "iTunesPrefs.plist" Then
            path = path + "iTunes\iTunesPrefs.plist"
            destination = destination + "iTunesPrefs.plist"
        ElseIf newselect1 = "CacheInfo.plist" Then
            path = path + "Speakable\CacheInfo.plist"
            destination = destination + "CacheInfo.plist"
        ElseIf newselect1 = "ConfigInfo.plist" Then
            path = path + "Speakable\Radio\ConfigInfo.plist"
            destination = destination + "ConfigInfo.plist"
        End If

        If Directory.Exists(fileroot1) Then

            Directory.Delete(fileroot1, True)
        End If

        If Directory.Exists(fileroot1) Then
        Else

            Directory.CreateDirectory(fileroot1)
        End If

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        checkconnetion()
        Timer1.Stop()
    End Sub

    Public Sub checkconnetion()
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            Timer1.Stop()
            DebugGogo1()


        Else
            'Disconnected
            Timer1.Stop()
            MsgBox("Please plug in your iPod Nano 6G")
            STdev.tab1textbox.ReadOnly = False
            Me.Close()
        End If
    End Sub

    Private Sub DebugGogo1()
        Timer1.Stop()
        'Try
        Label2.Visible = True
        Label4.Text = "Backing Up Old File..."
        Label4.Visible = True
        My.Computer.FileSystem.MoveFile(path, destination)
        Delay(0.5)
        DebugGogo2()

        'Catch ex As Exception
        '    MsgBox("Error, Please Debug again")
        'End Try

    End Sub

    Private Sub DebugGogo2()
        'Try
        Label4.Text = "Injecting Tweak(Stage 1/2)..."
        File.Create(path)
        Delay(2)
        Label4.Text = "Injecting Tweak(Stage 2/2)..."
        Dim writer As New System.IO.StreamWriter(path)
        writer.Write(STdev.tab1textbox.Text)
        writer.Close()
        Delay(2)
        TextBox1.Visible = True
        Label4.Visible = False
        Timer2.Start()
        TextBox1.Visible = True
        'Catch ex As Exception
        '    MsgBox("Error")
        'End Try
    End Sub

    Private Sub DebugGogo3()
        Label4.Text = "Please Wait..."
        TextBox1.Text = ""
        Delay(1)
        Label2.Text = "You may now disconnect"
        Label2.ForeColor = Color.Green
        Label4.Text = "Done"
        TextBox1.Text = "To now start the debug on your iPod and to use it, please unplug your iPod. To end the debug, connect your iPod back into the computer. "
        Timer4.Start()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected
            Label4.Text = "Rebooting..."
            Label4.Visible = True
            Timer3.Start()
            Timer2.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            DebugGogo3()
            Timer3.Stop()
        Else
            'Disconnected

        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected
            Label4.Text = "Debug is in progress on your device!"
            Label4.Visible = True
            Label2.Visible = False
            TextBox1.Text = "To end the debug, connect your iPod back into the computer. Ending the debug will TRY to return your iPod back to what is was before you started debugging your tweak."
            Timer5.Start()
            Timer4.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            EndDebug1()
            Timer5.Stop()
        Else
            'Disconnected

        End If
    End Sub

    Private Sub EndDebug1()
        Timer5.Stop()
        TextBox1.Text = ""
        Label4.Text = "Ending Debug..."
        Label2.Text = "DO NOT UNPLUG"
        Label2.ForeColor = Color.Red
        Label2.Visible = True
        Delay(1)
        Label4.Text = "Trying to returning iPod to normal"
        Kill(path)
        Delay(2)
        My.Computer.FileSystem.MoveFile(destination, path)
        TextBox1.Text = "Hold on to the power button and minus volume button at the same time until you see the Apple logo. Then you must let go. After do not touch your device until told."
        Label4.Text = ""
        Timer6.Start()
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected
            Label4.Text = "Rebooting..."
            Timer7.Start()
            Timer6.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = True Then
            'Connected
            EndDebug2()
            Timer7.Stop()
        Else
            'Disconnected

        End If
    End Sub

    Private Sub EndDebug2()
        Label4.Text = "Done"
        TextBox1.Text = ""
        Label1.Text = "Debug Finnished!"
        Label2.Visible = False
        Delay(1)
        STdev.ToolStrip1.Enabled = True
        STdev.MenuStrip1.Enabled = True
        STdev.tab1textbox.Enabled = True
        STdev.tab1textbox.ReadOnly = False
        Me.Close()
    End Sub

End Class