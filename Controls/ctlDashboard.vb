Public Class ctlDashboard
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
End Class
