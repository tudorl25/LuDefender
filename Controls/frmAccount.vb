Imports System.Runtime.InteropServices

Public Class frmAccount
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.MouseDown
        Me.Close()
    End Sub
    Private Sub frmPopup_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel2.MouseDown, PictureBox1.MouseDown
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseDown, Label1.MouseDown
        CtlLogIn1.BringToFront()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.MouseDown, Label2.MouseDown
        CtlCreateNew1.BringToFront()
    End Sub

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "LuDefender - Account"
        If Not (My.Settings.userEmail = "") Then
            Label3.Text = "Account: " + My.Settings.userEmail
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CtlLogIn1_Load(sender As Object, e As EventArgs) Handles CtlLogIn1.Load

    End Sub
End Class