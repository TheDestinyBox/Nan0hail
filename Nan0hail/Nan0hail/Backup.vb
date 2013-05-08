Imports System.IO
Public Class Backup
    Dim SelectedFilePath123 As String
    Dim SelectedFileName123 As String
    Private Sub LoadListbox()
        SelectedFileName123 = ""
        SelectedFilePath123 = ""

        Dim files() As String = IO.Directory.GetDirectories("c:\Nan0hail\Backup")
        Dim fileWrappers As New List(Of FileWrapper)

        For Each file As String In files
            Dim fw As New FileWrapper(file)
            fileWrappers.Add(fw)
        Next

        ListBox1.DataSource = fileWrappers

    End Sub

    Private Sub Backup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
     
        If Not Directory.Exists("c:\Nan0hail\Backup") = True Then
            Directory.CreateDirectory("c:\Nan0hail\Backup")
        Else
        End If
        LoadListbox()
        Try
            Dim fw As FileWrapper = DirectCast(ListBox1.SelectedItem, FileWrapper)
            SelectedFilePath123 = (fw.FullPath)
            SelectedFileName123 = (fw.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim fw As FileWrapper = DirectCast(ListBox1.SelectedItem, FileWrapper)
        'MessageBox.Show(fw.FullPath, fw.FileName)
        SelectedFilePath123 = (fw.FullPath)
        SelectedFileName123 = (fw.FileName)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Label4.Visible = True
        ListBox1.Visible = False
        ListBox1.Enabled = False
        TextBox1.Visible = True
        Button4.Visible = True
        Label3.Visible = True
        Button6.Enabled = False
        Button10.Enabled = True
        Button7.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Cleanup()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Visible = False
        TextBox1.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button3.Visible = False
        Button10.Visible = False
        Button5.Visible = False
        Label6.Visible = True
        Label3.Visible = False
        Label4.Visible = False
        Delay(1)
        Backup()
    End Sub

    Private Sub Cleanup()
        Label4.Visible = False
        TextBox1.Visible = False
        Button4.Visible = False
        Label3.Visible = False
        TextBox1.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button3.Enabled = True
        Button10.Enabled = False
        Button5.Enabled = True
        TextBox1.Enabled = True
        TextBox1.Text = ""
        ListBox1.Enabled = True
        ListBox1.Visible = True
        Label2.Visible = False
        Label6.Visible = False
        Button6.Visible = True
        Button7.Visible = True
        Button3.Visible = True
        Button10.Visible = True
        Button5.Enabled = True
        Button5.Visible = True
        SelectedFileName123 = ""
        SelectedFilePath123 = ""
        LoadListbox()
    End Sub

    Private Sub Backup()
        If Directory.Exists("c:\Nan0hail\Backup\" & TextBox1.Text) Then
            MsgBox("Backup Name Already Exists!")
            Cleanup()
            Exit Sub
        Else
            Directory.CreateDirectory("c:\Nan0hail\Backup\" & TextBox1.Text)
        End If
        Dim path As String = MainDrive
        Dim destination As String = "c:\Nan0hail\Backup\" & TextBox1.Text & "\"
        Try

            My.Computer.FileSystem.CurrentDirectory = path

            ' loop through the files in the directory
            For Each foundFile As String In My.Computer.FileSystem.GetDirectories _
                (My.Computer.FileSystem.CurrentDirectory)
                ' strip off the directory
                foundFile = Microsoft.VisualBasic.Right(foundFile, Len(foundFile) - 3)
                
                ' copy the file
                My.Computer.FileSystem.CopyDirectory(foundFile, destination & foundFile, True)

            Next



            'My.Computer.FileSystem.CopyDirectory(path, destination, True)
            MsgBox("Your iPod Nano has successfully backed up!")
            Cleanup()
        Catch ex As Exception
            MsgBox("Failed to backup")
            If Directory.Exists("c:\Nan0hail\Backup\" & TextBox1.Text & "\") Then
                System.IO.Directory.Delete("c:\Nan0hail\Backup\" & TextBox1.Text & "\", True)
                If Directory.Exists("c:\Nan0hail\Backup\" & TextBox1.Text & "\") Then
                    System.IO.Directory.Delete("c:\Nan0hail\Backup\" & TextBox1.Text & "\", True)
                    Cleanup()
                End If
                Cleanup()
            End If

        End Try
    End Sub

    Private Sub RestoreFromBackUp()
        Dim path As String = MainDrive

        If Directory.Exists(path) Then
          
            Try
                System.IO.Directory.Delete(path, True)
               
                Try
                    Dim path1 As String = "c:\Nan0hail\Backup\" & SelectedFileName123
                    Dim destination As String = MainDrive

                    My.Computer.FileSystem.CopyDirectory(path1, destination)
                    'Reboot iPod
                    RebootTime()
                    Cleanup()
                Catch ex0 As Exception
                    MsgBox("Error, please try restoring again")
                    Cleanup()
                End Try
            Catch ex As Exception
            
                Try
                    Dim path1 As String = "c:\Nan0hail\Backup\" & SelectedFileName123
                    Dim destination As String = MainDrive

                    My.Computer.FileSystem.CopyDirectory(path1, destination)
                    'Reboot iPod
                    RebootTime()
                    Cleanup()
                Catch ex1 As Exception
                    MsgBox("Error, please try restoring again")
                    Cleanup()
                End Try
            End Try
        Else
            MsgBox("Error, Cannot find device!")
            Cleanup()
        End If


    End Sub

    Private Sub RebootTime()
        Panel1.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If SelectedFilePath123 = "" Then
            MsgBox("Please select a backup to restore to!")
            Exit Sub
        End If

        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you would like to Restore from Back up?", MsgBoxStyle.YesNo, " ")
        If ask = MsgBoxResult.Yes Then
            Label2.Visible = True
            Button3.Enabled = True
            ListBox1.Visible = False
            Button5.Visible = False
            Button3.Visible = False
            Button6.Visible = False
            Button10.Visible = False
            Button7.Visible = False
            Label2.Visible = True
            Delay(1)
            RestoreFromBackUp()
        Else
            If ask = MsgBoxResult.No Then

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure you would like to Remove this Back up?", MsgBoxStyle.YesNo, " ")
        If ask = MsgBoxResult.Yes Then

            Dim pathdelete As String = SelectedFilePath123
            If Directory.Exists(pathdelete) Then
                System.IO.Directory.Delete(pathdelete, True)
                LoadListbox()
            Else
                MsgBox("Cannot delete backup! Please try again.")
                LoadListbox()
            End If

            'Delete name from text document in next step

        Else
            If ask = MsgBoxResult.No Then

            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\") = False Then
            'Disonnected

            Label5.Visible = True
            Timer2.Start()
            Timer1.Stop()
        Else
            'Connected

        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If System.IO.Directory.Exists(MainDrive & "iPod_Control\Device\") = True Then
            'Connected
            Label5.Visible = False
            Timer2.Stop()
            MsgBox("Successfully Restored iPod!")
            Panel1.Visible = False

        Else
            'Disconnected

        End If
    End Sub
End Class

Public Class FileWrapper

    Public Property FileName As String
    Public Property FullPath As String

    Public Sub New(ByVal filePath As String)
        FullPath = filePath
        FileName = IO.Path.GetFileName(filePath)
    End Sub

    Public Overrides Function ToString() As String
        Return FileName
    End Function
End Class