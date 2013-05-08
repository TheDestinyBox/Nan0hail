Imports System.Threading
Public Class Builder

    Private Sub Builder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        '   MakeItHail()
    End Sub

    Public Sub MakeItHail()
        Timer1.Stop()
        ProgressBar1.Value = 1

        lblStatus.Text = "Getting ready"
        Call CheckDir()



        lblStatus.Text = "Checking for any old files"
        Call ipswCleanup()


        lblStatus.Text = "Extracting Resources"
        Call ExtractResources()

        lblStatus.Text = "Copying IPSW"
        Call copyIPSW()

        lblStatus.Text = "Extracting IPSW"
        Call ExtractIPSW()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        MakeItHail()
        Timer1.Stop()
    End Sub
End Class