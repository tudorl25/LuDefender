Imports System.Runtime.InteropServices

Public Class Main
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Dim myCol As myColors = New myColors
    Dim targetPos As Integer = 13
    Dim slidePos As Integer = 139
    Dim kP1 As Double = 0.25
    Dim kP2 As Double = 0.25


    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, topPanel.MouseDown, lblTitle.MouseDown
        If e.Button = Form.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub minButton_Click(sender As Object, e As EventArgs) Handles minButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        frmPopup.ShowDialog()
    End Sub

    Private Sub logButton_Click(sender As Object, e As EventArgs) Handles logButton.Click
        Timer1.Start()
        targetPos = 768
        slidePos = 123
    End Sub

    Private Sub settingButton_Click(sender As Object, e As EventArgs) Handles settingButton.Click
        Timer1.Start()
        targetPos = 906
        slidePos = 109
    End Sub

    Private Sub toolButton_Click(sender As Object, e As EventArgs) Handles toolButton.Click
        Timer1.Start()
        targetPos = 331
        slidePos = 75
    End Sub

    Private Sub scanButton_Click(sender As Object, e As EventArgs) Handles scanButton.Click
        Timer1.Start()
        targetPos = 170
        slidePos = 140
        CtlScanning1.BringToFront()
    End Sub

    Private Sub dashButton_Click(sender As Object, e As EventArgs) Handles dashButton.Click
        Timer1.Start()
        targetPos = 13
        slidePos = 139
        CtlDashboard1.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Speed1 As Integer = kP1 * (targetPos - slideThingy.Left)
        Dim Speed2 As Integer = kP2 * (slidePos - slideThingy.Size.Width)
        slideThingy.Location = New Point(slideThingy.Left + Speed1, slideThingy.Top)
        slideThingy.Size = New Size(slideThingy.Size.Width + Speed2, 10)
        If slideThingy.Left.Equals(targetPos) Then
            Timer1.Stop()
        End If
    End Sub
End Class
