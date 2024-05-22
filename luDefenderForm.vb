Imports System.Linq.Expressions
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Main
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Dim myCol As myColors = New myColors
    Public targetPos As Integer = 98
    Dim kP1 As Double = 0.5

    Private lastTime As DateTime
    Private lastTimeTwo As DateTime

    Public Shared minutes As New Integer


    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, topPanel.MouseDown, appLogo.MouseDown
        If e.Button = Form.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub minButton_Click(sender As Object, e As EventArgs) Handles btnMin.MouseDown
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles btnClose.MouseDown
        Me.Hide()
    End Sub

    Private Sub logButton_Click(sender As Object, e As EventArgs) Handles btnLog.MouseDown
        Timer1.Start()
        targetPos = 245
    End Sub

    Private Sub settingButton_Click(sender As Object, e As EventArgs) Handles btnSettings.MouseDown
        Timer1.Start()
        targetPos = 296
        'transitionPic.Image = My.Resources.Tools
        'transitionPic.BringToFront()
        'Dim Waiter As New ManualResetEvent(False)
        'Waiter.WaitOne(10) 'to get it into milliseconds
        FrmSettings1.BringToFront()
    End Sub

    Private Sub toolButton_Click(sender As Object, e As EventArgs) Handles btnTool.MouseDown
        Timer1.Start()
        targetPos = 195
        transitionPic.Image = My.Resources.Tools
        transitionPic.BringToFront()
        Dim Waiter As New ManualResetEvent(False)
        Waiter.WaitOne(10) 'to get it into milliseconds
        FrmTools1.BringToFront()
    End Sub

    Private Sub scanButton_Click(sender As Object, e As EventArgs) Handles btnScan.MouseDown
        Timer1.Start()
        targetPos = 149
        'transitionPic.Image = My.Resources.Scanning
        'transitionPic.BringToFront()
        'Dim Waiter As New ManualResetEvent(False)
        'Waiter.WaitOne(10) 'to get it into milliseconds
        CtlScanning1.BringToFront()
    End Sub


    Private Sub dashButton_Click(sender As Object, e As EventArgs) Handles btnDash.MouseDown


        Timer1.Start()
        targetPos = 98
        'transitionPic.Image = My.Resources.Dashboard
        'transitionPic.BringToFront()

        'Dim Waiter As New ManualResetEvent(False)
        'Waiter.WaitOne(10) 'to get it into milliseconds

        'Console.WriteLine("Waiting is over!")

        CtlDashboard1.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Speed1 As Integer = kP1 * (targetPos - selectionThingy.Top)
        selectionThingy.Location = New Point(selectionThingy.Left, selectionThingy.Top + Speed1)
        If selectionThingy.Top.Equals(targetPos) Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Visible Then
            lastTime = DateTime.Parse(My.Settings.dateOfLastScan)

            Dim diff As TimeSpan = DateTime.Now - lastTime

            CtlDashboard1.lblMinutes.Text = diff.Minutes.ToString() + " minutes"
            CtlDashboard1.lblDaysHours.Text = diff.Days.ToString() + " days, " + diff.Hours.ToString() + " hours"
        End If


        If ctlScanning.active = False And My.Settings.scheduledScanMode > -1 Then
            lastTimeTwo = DateTime.Parse(My.Settings.dateOfLastSessionScan)
            Dim second_diff As TimeSpan = DateTime.Now - lastTimeTwo
            minutes = second_diff.Minutes + second_diff.Hours * 60 + second_diff.Days * 1440
            If minutes >= My.Settings.scheduledScanMode Then
                SwitchToScanning()
                CtlScanning1.QuickScan()
            End If
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'transitionPic.Image = My.Resources.Dashboard
        ' transitionPic.BringToFront()
        'CtlDashboard1.BringToFront()

        My.Settings.dateOfLastSessionScan = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        'My.Settings.scheduledScanMode = 5
        My.Settings.Save()

        Timer2.Start()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        Me.Show()
    End Sub

    Public Sub SwitchToScanning()
        Timer1.Start()
        targetPos = 149
        transitionPic.Image = My.Resources.Scanning
        transitionPic.BringToFront()
        Dim Waiter As New ManualResetEvent(False)
        Waiter.WaitOne(10)
        CtlScanning1.BringToFront()
    End Sub

End Class
