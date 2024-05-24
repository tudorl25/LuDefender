Imports System.IO
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmTools

    Public Shared urlToCheck As String

    Public Sub changeOnLanguage()
        If My.Settings.englishEnabled Then
            If My.Settings.fireWallActive Then
                btnFirewall.Image = My.Resources.enable_firewall
            Else
                btnFirewall.Image = My.Resources.disable_firewall
            End If
            PictureBox1.Image = My.Resources.url_checker
            btnShredder.Image = My.Resources.file_shredder
        Else
            If My.Settings.fireWallActive Then
                btnFirewall.Image = My.Resources.RO_enable_firewall
            Else
                btnFirewall.Image = My.Resources.RO_disable_firewall
            End If
            PictureBox1.Image = My.Resources.RO_url_checker
            btnShredder.Image = My.Resources.RO_file_shredder
        End If
    End Sub

    Private Sub btnFirewall_Click(sender As Object, e As EventArgs) Handles btnFirewall.MouseDown

        Dim firewall As New Process
        firewall.StartInfo.Verb = "runas"
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "c:\windows\system32\"
        firewall.StartInfo.UseShellExecute = True

        If My.Settings.fireWallActive Then

            firewall.StartInfo.Arguments = "/c netsh Advfirewall set allprofiles state off"

        Else

            firewall.StartInfo.Arguments = "/c netsh Advfirewall set allprofiles state on"

        End If
        firewall.Start()
        My.Settings.fireWallActive = Not My.Settings.fireWallActive
        My.Settings.Save()
        fireWallStateHandle()
    End Sub


    Private Sub fireWallStateHandle()
        If My.Settings.fireWallActive = True Then
            btnFirewall.Image = My.Resources.enable_firewall
        Else
            btnFirewall.Image = My.Resources.disable_firewall
        End If
    End Sub

    Private Sub frmTools_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fireWallStateHandle()
        changeOnLanguage()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        urlToCheck = userInput.Text
        Dim pattern As String
        pattern = "http://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"
        If Regex.IsMatch(urlToCheck, pattern) Then
            urlToCheck = urlToCheck.Remove(0, 11)
            urlCheck.ShowDialog()
        Else
            userInput.Text = "Please enter a valid website url, ex: http://www.website.com"
        End If

    End Sub

    Private Sub btnShredder_Click(sender As Object, e As EventArgs) Handles btnShredder.Click
        SecureDelete()
    End Sub

    Sub SecureDelete()

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then

            Dim filePath As String = OpenFileDialog1.FileName

            Try
                Dim fileLength As Long = New FileInfo(filePath).Length

                Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Write)
                    For pass As Integer = 1 To 3
                        fs.Position = 0
                        Dim buffer(4096 - 1) As Byte

                        Using rng As New RNGCryptoServiceProvider()
                            Dim totalBytesWritten As Long = 0

                            While totalBytesWritten < fileLength
                                rng.GetBytes(buffer)
                                Dim bytesToWrite As Integer = Math.Min(4096, fileLength - totalBytesWritten)
                                fs.Write(buffer, 0, bytesToWrite)
                                totalBytesWritten += bytesToWrite
                            End While
                        End Using
                    Next
                End Using

                File.SetAttributes(filePath, FileAttributes.Normal)

                File.Delete(filePath)

                MessageBox.Show("File securely deleted.")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub
End Class
