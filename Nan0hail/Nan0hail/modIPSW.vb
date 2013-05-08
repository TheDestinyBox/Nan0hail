Imports System.IO
Module modIPSW
    Public IPSWstring As String = ""
    Public IPSWHash As String = ""
    Public Model As String = ""
    Public IPSWVersion As String = ""
    Public cmdline As String


    Dim path1 As String = "c:\Nan0hail\IPSWcreation"


    Public Sub CheckDir()

        If Directory.Exists(path1) Then
            Exit Sub
        Else
            Directory.CreateDirectory(path1)
        End If

    End Sub

    Public Sub ipswCleanup()

    End Sub

    Public Sub ExtractResources()

    End Sub

    Public Sub copyIPSW()

        Dim type As String = "zip"

        ' If MsgBox(" Your File is being Converted into a " + type + " File") Then
        Dim oldFile As String = Mid(IPSWstring, 1, Len(IPSWstring) - 4)
        FileCopy(IPSWstring, oldFile + type)
        'End If


    End Sub

    Public Sub ExtractIPSW()

        '  cmdline = Quote.Text & "pois0n.exe" & Quote.Text & " run"
        '   ExecCmd(cmdline, True)

    End Sub
End Module





