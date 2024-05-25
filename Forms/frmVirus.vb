Imports System.Runtime.InteropServices
Imports System.IO

Public Class frmVirus
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Dim nrOfUnresolved As Integer
    Private scanCenter As ctlScanning = New ctlScanning
    'Public unresolvedVirus As New List(Of String)

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles btnIgnore.MouseDown, closeButton.MouseDown
        My.Settings.isSafe = False
        My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - Am detectat " + My.Settings.unresolvedVirus.Count.ToString() + " amenintari nerezolvate, navigati la Panou de bord pentru a le elimina;"
        My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - We detected " + My.Settings.unresolvedVirus.Count.ToString() + " unresolved threats, navigate to Dashboard to remove them;"
        My.Settings.Save()
        Main.CtlDashboard1.changeOnLanguage()
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
        Me.Text = "LuDefender - Detection"
        Try
            If My.Settings.unresolvedVirus IsNot Nothing Then
                nrOfUnresolved = My.Settings.unresolvedVirus.Count
            Else
                nrOfUnresolved = 0
                My.Settings.unresolvedVirus = New Specialized.StringCollection
            End If

        Catch ex As Exception
            My.Settings.unresolvedVirus = New Specialized.StringCollection
            nrOfUnresolved = 0
        End Try

        If My.Settings.englishEnabled Then
            PictureBox2.Image = My.Resources.files_scanned_list
            btnIgnore.Image = My.Resources.ignoreThem
            btnRemove.Image = My.Resources.removeThem
        Else
            PictureBox2.Image = My.Resources.RO_files_scanned_list
            btnIgnore.Image = My.Resources.RO_ignoreThem
            btnRemove.Image = My.Resources.RO_removeThem
        End If
        detectedThreats.Items.Clear()
        If My.Settings.isSafe Then
            For Each strVir As String In scanCenter.virusList
                My.Settings.unresolvedVirus.Add(strVir)
                detectedThreats.Items.Add(strVir)
            Next
        Else
            If My.Settings.unresolvedVirus.Count = 0 Then
                My.Settings.isSafe = True
            Else

                For Each strVir As String In My.Settings.unresolvedVirus
                    detectedThreats.Items.Add(strVir)
                Next
            End If
        End If
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If detectedThreats.Items.Count > 0 Then
            Dim FileToDelete As String = detectedThreats.Items.Item(0).ToString()
            If System.IO.File.Exists(FileToDelete) = True Then

                System.IO.File.Delete(FileToDelete)
            End If
            If My.Settings.unresolvedVirus.Contains(FileToDelete) Then
                My.Settings.unresolvedVirus.Remove(FileToDelete)
            End If
            detectedThreats.Items.RemoveAt(0)

        Else
            If My.Settings.isSafe Then
                My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - Am gasit si eliminat " + Main.CtlScanning1.ListBox1.Items.Count.ToString() + " amenintari;"
                My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - We found and removed " + Main.CtlScanning1.ListBox1.Items.Count.ToString() + " dangerous files;"
            Else
                If My.Settings.unresolvedVirus.Count = 0 Then
                    My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - Am eliminat " + nrOfUnresolved.ToString() + " amenintari nerezolvate;"
                    My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - We removed " + nrOfUnresolved.ToString() + " unresolved threats;"

                    My.Settings.isSafe = True
                    My.Settings.Save()
                    Main.CtlDashboard1.changeOnLanguage()
                Else
                    My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - Am detectat " + nrOfUnresolved.ToString() + " amenintari nerezolvate, navigati la Panou de bord pentru a le elimina;"
                    My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") + " - We detected " + My.Settings.unresolvedVirus.Count.ToString() + " unresolved threats, navigate to Dashboard to remove them;"
                End If
            End If
            Timer1.Stop()
            Me.Close()
        End If
        My.Settings.Save()
        Threading.Thread.Sleep(100)
    End Sub

End Class