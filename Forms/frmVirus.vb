Imports System.Runtime.InteropServices
Imports System.IO

Public Class frmVirus
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Private scanCenter As ctlScanning = New ctlScanning

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles btnIgnore.MouseDown, closeButton.MouseDown
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


    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles btnRemove.MouseDown
        Timer1.Start()

    End Sub

    Private Sub frmVirus_Load(sender As Object, e As EventArgs) Handles Me.Load
        detectedThreats.Items.Clear()
        For Each strVir As String In scanCenter.virusList
            detectedThreats.Items.Add(strVir)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If detectedThreats.Items.Count > 0 Then
            Dim FileToDelete As String = detectedThreats.Items.Item(0).ToString()
            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
            End If
            detectedThreats.Items.RemoveAt(0)

        Else

            Timer1.Stop()
                Me.Close()

        End If
        Threading.Thread.Sleep(100)
    End Sub

End Class