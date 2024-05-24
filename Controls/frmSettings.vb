Imports Microsoft.Win32

Public Class frmSettings

    Private blueI As Integer = 2
    Private blueList As String()

    Private redI As Integer = 0
    Private redList As String() = {"ENGLISH MODE", "MOD ROMANA"}


    Private purpleI As Integer = 2
    Private purpleList As String()

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        changeOnLanguage()
        Select Case My.Settings.scheduledScanMode
            Case 10
                blueI = 0
            Case 30
                blueI = 1
            Case 60
                blueI = 2
            Case 180
                blueI = 3
            Case 1440
                blueI = 4
            Case -1
                blueI = 5
        End Select
        'lblScheduled.Text = blueList(blueI)
        'purpleI = My.Settings.startupMode
        'lblStartup.Text = purpleList(purpleI)
        lblLanguage.Text = redList(redI)
    End Sub

    Private Sub changeOnLanguage()
        If My.Settings.englishEnabled = True Then
            PictureBox1.BackgroundImage = My.Resources.settingScheduledScanning
            PictureBox2.BackgroundImage = My.Resources.settingDisplayedLanguage
            PictureBox3.BackgroundImage = My.Resources.settingRunOnStartup
            redI = 0
            purpleList = {"START NORMAL", "START MINIMIZED", "OFF"}
            blueList = {"EXTRA FREQUENT MODE (once every 10 minutes)", "FREQUENT MODE (once every 30 minutes)", "NORMAL MODE (once an hour)", "SELDOM MODE (once every 3 hours)", "EXTRA SELDOM MODE (once a day)", "OFF"}
        Else
            PictureBox1.BackgroundImage = My.Resources.RO_settingScheduledScanning
            PictureBox2.BackgroundImage = My.Resources.RO_settingDisplayedLanguage
            PictureBox3.BackgroundImage = My.Resources.RO_settingRunOnStartup
            redI = 1
            purpleList = {"LANSARE NORMAL", "LANSARE MINIMIZAT", "OPRIT"}
            blueList = {"MOD EXTRA FRECVENT (o data la 10 minute)", "MOD FRECVENT (o data la 30 de minute)", "MOD NORMAL (o data pe ora)", "MOD RAR (o data la 3 ore)", "MOD EXTRA RAR (o data pe zi)", "OPRIT"}
        End If
        purpleI = My.Settings.startupMode
        lblStartup.Text = purpleList(purpleI)
        lblScheduled.Text = blueList(blueI)
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
            My.Settings.englishEnabled = True
        Else
            My.Settings.englishEnabled = False
        End If
        My.Settings.Save()
        changeOnLanguage()
        Main.changeOnLanguage()
    End Sub
    Private Sub redDown_Click(sender As Object, e As EventArgs) Handles redDown.MouseDown
        If redI = 0 Then
            redI = 1
        Else
            redI -= 1
        End If
        lblLanguage.Text = redList(redI)
        If redI = 0 Then
            My.Settings.englishEnabled = True
        Else
            My.Settings.englishEnabled = False
        End If

        My.Settings.Save()
        changeOnLanguage()
        Main.changeOnLanguage()
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
        If purpleI = 2 Then
            RemoveFromStartup("LuDefender")
        Else
            AddToStartup(Application.ExecutablePath, "LuDefender")
        End If
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
        If purpleI = 2 Then
            RemoveFromStartup("LuDefender")
        Else
            AddToStartup(Application.ExecutablePath, "LuDefender")
        End If
    End Sub

    Sub AddToStartup(ByVal exePath As String, ByVal appName As String)
        Try
            ' Open the registry key
            Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            ' Add the value in the registry key
            regKey.SetValue(appName, exePath)

            regKey.Close()
        Catch ex As Exception
            Console.WriteLine("Error adding to startup: " & ex.Message)
        End Try
    End Sub

    Sub RemoveFromStartup(ByVal appName As String)
        Try
            ' Open the registry key
            Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            ' Check if the key exists and delete it
            If regKey.GetValue(appName) IsNot Nothing Then
                regKey.DeleteValue(appName)
            End If

            regKey.Close()
        Catch ex As Exception
            Console.WriteLine("Error removing from startup: " & ex.Message)
        End Try
    End Sub


End Class
