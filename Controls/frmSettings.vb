Public Class frmSettings

    Private blueI As Integer = 2
    Private blueList As String() = {"EXTRA FREQUENT MODE (once every 10 minutes)", "FREQUENT MODE (once every 30 minutes)", "NORMAL MODE (once an hour)", "SELDOM MODE (once every 3 hours)", "EXTRA SELDOM MODE (once a day)", "OFF"}

    Private redI As Integer = 0
    Private redList As String() = {"ENGLISH MODE", "MOD ROMÂNĂ"}

    Private purpleI As Integer = 2
    Private purpleList As String() = {"START NORMAL", "START MINIMIZED", "OFF"}

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        'scheduledScanning.SelectedIndex = My.Settings.scheduledScanMode
    End Sub


    Private Sub blueUp_Click(sender As Object, e As EventArgs) Handles blueUp.MouseDown

        If blueI = 5 Then
            blueI = 0
        Else
            blueI += 1
        End If
        lblScheduled.Text = blueList(blueI)
        Select Case blueI
            Case 0
                My.Settings.scheduledScanMode = 10
            Case 1
                My.Settings.scheduledScanMode = 30
            Case 2
                My.Settings.scheduledScanMode = 60
            Case 3
                My.Settings.scheduledScanMode = 180
            Case 4
                My.Settings.scheduledScanMode = 1440
            Case 5
                My.Settings.scheduledScanMode = -1
        End Select
        My.Settings.Save()
    End Sub

    Private Sub blueDown_Click(sender As Object, e As EventArgs) Handles blueDown.MouseDown
        If blueI = 0 Then
            blueI = 5
        Else
            blueI -= 1
        End If
        lblScheduled.Text = blueList(blueI)
        Select Case blueI
            Case 0
                My.Settings.scheduledScanMode = 10
            Case 1
                My.Settings.scheduledScanMode = 30
            Case 2
                My.Settings.scheduledScanMode = 60
            Case 3
                My.Settings.scheduledScanMode = 180
            Case 4
                My.Settings.scheduledScanMode = 1440
            Case 5
                My.Settings.scheduledScanMode = -1
        End Select
        My.Settings.Save()
    End Sub

    Private Sub redUp_Click(sender As Object, e As EventArgs) Handles redUp.MouseDown
        If redI = 1 Then
            redI = 0
        Else
            redI += 1
        End If
        lblLanguage.Text = redList(redI)
        If redI = 0 Then
            My.Settings.englishEnabled = False
        Else
            My.Settings.englishEnabled = True
        End If
        My.Settings.Save()
    End Sub
    Private Sub redDown_Click(sender As Object, e As EventArgs) Handles redDown.MouseDown
        If redI = 0 Then
            redI = 1
        Else
            redI -= 1
        End If
        lblLanguage.Text = redList(redI)
        If redI = 0 Then
            My.Settings.englishEnabled = False
        Else
            My.Settings.englishEnabled = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub purpleUp_Click(sender As Object, e As EventArgs) Handles purpleUp.MouseDown
        If purpleI = 2 Then
            purpleI = 0
        Else
            purpleI += 1
        End If
        lblStartup.Text = purpleList(purpleI)
        My.Settings.startupMode = purpleI
        My.Settings.Save()
    End Sub

    Private Sub purpleDown_Click(sender As Object, e As EventArgs) Handles purpleDown.MouseDown
        If purpleI = 0 Then
            purpleI = 2
        Else
            purpleI -= 1
        End If
        lblStartup.Text = purpleList(purpleI)
        My.Settings.startupMode = purpleI
        My.Settings.Save()
    End Sub
End Class
