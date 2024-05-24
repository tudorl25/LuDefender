Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography

Public Class urlCheck
    Private TargetDb As String()
    Private databaseTxt As String = My.Resources.url_database
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Private i As Integer = 0

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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lilRadar.ImageIndex = 35 Then
            If i = 1 Then
                If TargetDb.Contains(frmTools.urlToCheck) Then
                    If My.Settings.englishEnabled Then
                        lblState1.Text = "STATE: Website with the URL"
                        lblState1.ForeColor = Color.Red
                        lblUrl.Text = frmTools.urlToCheck
                        lblUrl.ForeColor = Color.Red
                        lblState2.Text = "is dangerous and should be avoided"
                        lblState2.ForeColor = Color.Red
                    Else
                        lblState1.Text = "STARE: Site-ul web cu URL"
                        lblState1.ForeColor = Color.Red
                        lblUrl.Text = frmTools.urlToCheck
                        lblUrl.ForeColor = Color.Red
                        lblState2.Text = "este periculos si trebuie evitat"
                        lblState2.ForeColor = Color.Red
                    End If
                Else
                    If My.Settings.englishEnabled Then
                        lblState1.Text = "STATE: Website with the URL"
                        lblState1.ForeColor = Color.Green
                        lblUrl.Text = frmTools.urlToCheck
                        lblUrl.ForeColor = Color.Green
                        lblState2.Text = "is clean and safe to browse"
                        lblState2.ForeColor = Color.Green
                    Else
                        lblState1.Text = "STARE: Site-ul web cu URL"
                        lblState1.ForeColor = Color.Green
                        lblUrl.Text = frmTools.urlToCheck
                        lblUrl.ForeColor = Color.Green
                        lblState2.Text = "este sigur"
                        lblState2.ForeColor = Color.Green
                    End If
                End If

                    i = 0
                Timer1.Stop()
            Else
                i += 1
            End If
        Else
            lilRadar.ImageIndex = lilRadar.ImageIndex + 1
        End If
    End Sub



    Private Sub urlCheck_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "LuDefender - Detection"
        Timer1.Start()
        lblUrl.Text = frmTools.urlToCheck
        lblState1.ForeColor = Color.White
        lblUrl.ForeColor = Color.White
        lblState2.ForeColor = Color.White
        TargetDb = databaseTxt.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
    End Sub
End Class