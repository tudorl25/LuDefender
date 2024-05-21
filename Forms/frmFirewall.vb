Imports System.Runtime.InteropServices

Public Class frmFirewall

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Dim firewall As New Process
        firewall.StartInfo.Verb = "runas"
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "c:\windows\system32\"
        firewall.StartInfo.UseShellExecute = True
        firewall.StartInfo.Arguments = "/c netsh Advfirewall set allprofiles state off"
        firewall.Start()
        Me.Close()
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Me.Close()
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub frmFirewall_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel2.MouseDown, lblTitle.MouseDown
        If e.Button = Form.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

End Class