Public Class ctlDashboard

    Public Sub changeOnLanguage()
        If My.Settings.englishEnabled Then
            If My.Settings.isSafe Then
                logoSafety.Image = My.Resources.weGotYourBackLogo
                PictureBox1.Image = My.Resources.statusSafeLogo1
                lblSafe.Text = "SAFE"
                lblCorny.Text = "Our protective measures have been implemented, so don't worry, LuDefender is making sure of your safety"
            Else
                logoSafety.Image = My.Resources.deviceInDanger
                PictureBox1.Image = My.Resources.dangerSystemStatus
                lblSafe.Text = "VULNERABLE"
                lblCorny.Text = "Click here to find and remove the threats"
            End If
        Else
            If My.Settings.isSafe Then
                logoSafety.Image = My.Resources.RO_weGotYourBackLogo
                PictureBox1.Image = My.Resources.RO_statusSafeLogo
                lblSafe.Text = "SIGUR"
                lblCorny.Text = "Masurile noastre de protectie au fost implementate, nu va faceti griji, LuDefender asigura siguranta dumneavoastra"
            Else
                logoSafety.Image = My.Resources.RO_deviceInDanger
                PictureBox1.Image = My.Resources.RO_dangerSystemStatus1
                lblSafe.Text = "VULNERABIL"
                lblCorny.Text = "Apasati aici pentru a gasi si remedia pericolele"
            End If
        End If
    End Sub

    Private Sub btnQuickScan_Click(sender As Object, e As EventArgs) Handles btnQuickScan.Click
        Main.Timer1.Start()
        Main.targetPos = 149
        Main.CtlScanning1.BringToFront()
        Main.CtlScanning1.QuickScan()
    End Sub

    Private Sub btnFullScan_Click(sender As Object, e As EventArgs) Handles btnFullScan.Click
        Main.Timer1.Start()
        Main.targetPos = 149
        Main.CtlScanning1.BringToFront()
        Main.CtlScanning1.StartScan()
    End Sub

    Private Sub ctlDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        changeOnLanguage()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, lblCorny.MouseDown, lblSafe.MouseDown
        If My.Settings.isSafe = False Then
            frmVirus.ShowDialog()
        End If
    End Sub
End Class
