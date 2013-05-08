Option Strict Off
Option Explicit On
Module ProcessCmd
    'Constants
    Public Const NORMAL_PRIORITY_CLASS As Integer = &H20
    Public Const HIGH_PRIORITY_CLASS As Integer = &H80
    Public Const INFINITE As Short = -1
    Private Const STARTF_USESHOWWINDOW As Short = 1
    Private Const SW_HIDE As Short = 0

    'public Types
    Public Structure STARTUPINFO
        Dim cb As Integer
        Dim lpReserved As String
        Dim lpDesktop As String
        Dim lpTitle As String
        Dim dwX As Integer
        Dim dwY As Integer
        Dim dwXSize As Integer
        Dim dwYSize As Integer
        Dim dwXCountChars As Integer
        Dim dwYCountChars As Integer
        Dim dwFillAttribute As Integer
        Dim dwFlags As Integer
        Dim wShowWindow As Short
        Dim cbReserved2 As Short
        Dim lpReserved2 As Integer
        Dim hStdInput As Integer
        Dim hStdOutput As Integer
        Dim hStdError As Integer
    End Structure

    Public Structure PROCESS_INFORMATION
        Dim hProcess As Integer
        Dim hThread As Integer
        Dim dwProcessID As Integer
        Dim dwThreadID As Integer
    End Structure



    'API Declarations
    Public Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
    'UPGRADE_WARNING: Structure PROCESS_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    'UPGRADE_WARNING: Structure STARTUPINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
    Public Declare Function CreateProcessA Lib "kernel32" (ByVal lpApplicationName As Integer, ByVal lpCommandLine As String, ByVal lpProcessAttributes As Integer, ByVal lpThreadAttributes As Integer, ByVal bInheritHandles As Integer, ByVal dwCreationFlags As Integer, ByVal lpEnvironment As Integer, ByVal lpCurrentDirectory As Integer, ByRef lpStartupInfo As STARTUPINFO, ByRef lpProcessInformation As PROCESS_INFORMATION) As Integer
    Public Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer

    'example use
    'cmdline = "%comspec% /c """ & App.Path & "\7z.exe x -oIPSW ,original.ipsw"""
    'or
    'cmdline = "7z.exe x -oIPSW ,original.ipsw"
    'or
    'cmdline = "DEL fstab.original /f /q"

    'ExecCmd (cmdline, True) 'False = show windows



    Public Function ExecCmd(ByVal cmdline As String, Optional ByVal HideWindow As Boolean = False) As Integer
        Dim Proc As PROCESS_INFORMATION
        Dim start As STARTUPINFO = Nothing
        Dim ReturnValue As Short

        'Hide window?
        If (HideWindow) Then
            start.dwFlags = STARTF_USESHOWWINDOW
            start.wShowWindow = SW_HIDE
        End If


        'Initialize The STARTUPINFO Structure
        start.cb = Len(start)

        'Start The Shelled Application
        ReturnValue = CreateProcessA(0, cmdline, 0, 0, 1, HIGH_PRIORITY_CLASS, 0, 0, start, Proc)

        'Wait for The Shelled Application to Finish
        Do
            ReturnValue = WaitForSingleObject(Proc.hProcess, 0)
            System.Windows.Forms.Application.DoEvents()
            Delay(1)
        Loop Until ReturnValue <> 258

        'Close Handle to Shelled Application
        ReturnValue = CloseHandle(Proc.hProcess)

    End Function


End Module
