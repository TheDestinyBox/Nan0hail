Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Management
Public Class Verify
    Public MD51 As Boolean = False

    Private WithEvents get_MD5 As System.ComponentModel.BackgroundWorker

    Public Sub get_MD5_hash(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles get_MD5.DoWork

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(IPSWstring, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        IPswhash = sb.ToString.ToLower
    End Sub

    Private Sub get_md5_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles get_MD5.RunWorkerCompleted
        If ipswhash = "d0fb9268b082b40fbd6738f76ef96cd9" Then
            Label1.Visible = False
            PictureBox1.Visible = False
            Model = "iPod Nano 6G"
            Label3.Text = Model
            Label4.Text = "Version: 1.2"
            IPSWVersion = "1.2"
            Label5.Text = "iPod_1.2_36B10147"
            Label6.Text = "Hash: " & ipswhash
            Label2.Text = "IPSW Varified!"
            Label2.ForeColor = Color.Green
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Button3.Enabled = True

        ElseIf IPSWHash = "afdeac49ffcf99c36f1307907e5693a7" Then
            Label1.Visible = False
            PictureBox1.Visible = False
            Model = "iPod Nano 7G"
            Label3.Text = Model
            Label4.Text = "Version: 1.0.1"
            IPSWVersion = "1.0.1"
            Label5.Text = "iPod_1.0.1_37A10002"
            Label6.Text = "Hash: " & IPSWHash
            Label2.Text = "IPSW Varified!"
            Label2.ForeColor = Color.Green
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Button3.Enabled = True

        Else

            Label1.Visible = False
            PictureBox1.Visible = False
            Label2.Text = "Not a valid IPSW"
            Label2.ForeColor = Color.Red
            Label2.Visible = True
            TextBox1.Text = IPSWHash

        End If

    End Sub

    Public Function getFilesMD5Hash(ByVal file As String) As String

        'MD5 hash provider for computing the hash of the file
        Dim md5 As New MD5CryptoServiceProvider()

        'open the file
        Dim stream As New FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        'calculate the files hash
        md5.ComputeHash(stream)

        'close our stream
        stream.Close()

        'byte array of files hash
        Dim hash As Byte() = md5.Hash

        'string builder to hold the results
        Dim sb As New StringBuilder()

        'loop through each byte in the byte array
        For Each b As Byte In hash
            'format each byte into the proper value and append
            'current value to return value
            sb.Append(String.Format("{0:X2}", b))
        Next

        'return the MD5 hash of the file
        Return sb.ToString.ToLower()
        ' iDevLoaded = True
    End Function



    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = True
        Label1.Text = "Verifying IPSW"
        Timer1.Start()
        PictureBox1.Visible = True
        'OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '--------------your code------------------- 
            IPSWstring = OpenFileDialog1.FileName

        Else

            Me.Close()

        End If

    End Sub
    Public Sub verifyIPSW()

        ' Dim type As String = "zip"

        'If MsgBox(" Your File is being Converted into a " + type + " File") Then
        '  Dim oldFile As String = Mid(My.Settings.IPSWstring, 1, Len(My.Settings.IPSWstring) - 4)
        '  FileCopy(My.Settings.IPSWstring, oldFile + type)
        'End If

        '  MyExtract()
        Timer1.Stop()

        get_MD5 = New System.ComponentModel.BackgroundWorker
        get_MD5.WorkerReportsProgress = True
        get_MD5.WorkerSupportsCancellation = True
        get_MD5.RunWorkerAsync()

    End Sub

    Private Sub MyExtract()
        Dim zipToUnpack As String = "C1P3SML.zip"
        Dim unpackDirectory As String = "Extracted Files"
        'Using zip1 As ZipFile = ZipFile.Read(zipToUnpack)
        '  ' here, we extract every entry, but we could extract conditionally
        '  ' based on entry name, size, date, checkbox status, etc.  
        'For Each e As ZipEntry In zip1
        'e.Extract(unpackDirectory, ExtractExistingFileAction.OverwriteSilently)
        '  Next
        '  End Using
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not IPSWstring = "" Then
            Label1.Visible = True
            Label1.Text = "Verifying IPSW"
            ' Delay(1)
            verifyIPSW()
            Timer1.Stop()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MainMenu.Close()
        IPSWcreator.Show()
        Me.Close()
    End Sub

End Class