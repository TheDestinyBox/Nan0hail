Module Extra
    Public iDevice As String

    'Public InDFU As String
    Public PID As String
    Public MainDrive As String
    Public newselect1 As String
    Public newselect2 As String
    Public tweakname As String
    Public tweakdiscription As String
    Public path1 As String = "c:\Nan0hail\Tweaks\My Tweaks\"
    Public path2 As String = "c:\Nan0hail\Tweaks\Extra\"
    Public path3 As String = "c:\Nan0hail\Tweaks\Tweaks\"
    Public filetocreate As String = "c:\Nan0hail\Tweaks\My Tweaks\"
    Public OfflineMode As Boolean
    Public DFUstartmode As Boolean = False


    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed
        Loop

    End Sub

End Module
