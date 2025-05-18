Imports System.ComponentModel
Imports System.IO
Imports System.Reflection.Emit
Imports System.Security.AccessControl
Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Security.Principal
Imports System.Text
Public Class ctlScanning

    Public detectedDangers As Integer = 0
    Private maxim As Integer = 0
    Private index As Integer = 0
    Private i As Integer = 0
    Public Shared active As Boolean = False
    Private startTime As DateTime
    Private md5Hashes As New HashSet(Of String)()
    Dim quickOrNot As Boolean
    Dim lastScanPath As String

    Private hashDb As String = My.Resources.hash_database1
    Private md5HashList As String()

    Private desiredPath As String() = {"Desktop", "Downloads", "Music", "Pictures", "Videos", "Saved Games"}

    Public Shared virusList As List(Of String) = New List(Of String)
    Public scheduledScanMode As Integer = My.Settings.scheduledScanMode

    Private imageList As ImageAnimator

    Private fileHash As String

    Public Sub changeOnLanguage()
        If My.Settings.englishEnabled Then
            PictureBox1.Image = My.Resources.filesScanned
            PictureBox2.Image = My.Resources.startScan
            stopScan.Image = My.Resources.stopScan
            Panel2.BackgroundImage = My.Resources.scanStatus3
        Else
            PictureBox1.Image = My.Resources.RO_filesScanned
            PictureBox2.Image = My.Resources.RO_startScan
            stopScan.Image = My.Resources.RO_stopScan
            Panel2.BackgroundImage = My.Resources.RO_scanStatus
        End If
    End Sub

    Public Sub StartScan()
        quickOrNot = False
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            md5HashList = hashDb.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            virusList.Clear()
            index = 0
            ListView1.Items.Clear()
            ListBox1.Items.Clear()
            Timer1.Start()
            Timer2.Start()
            active = True
            startTime = DateTime.Now
        Else
            active = False
            Exit Sub
        End If

        Try
            'On Error Resume Next
            lastScanPath = FolderBrowserDialog1.SelectedPath
            For Each strFile In Directory.GetFiles(lastScanPath, "*.*", SearchOption.AllDirectories)

                ListBox1.Items.Add(strFile)

            Next
        Catch ex As Exception
            'Console.Write(ex.ToString())
        End Try
    End Sub

    Public Sub QuickScan()
        quickOrNot = True
        md5HashList = hashDb.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        virusList.Clear()
        index = 0
        ListView1.Items.Clear()
        ListBox1.Items.Clear()
        Timer1.Start()
        Timer2.Start()
        active = True
        startTime = DateTime.Now
        Dim startPath As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\"


        For Each strPath In desiredPath
            Try
                For Each strFile In Directory.GetFiles(startPath + strPath, "*.*", SearchOption.AllDirectories)
                    ListBox1.Items.Add(strFile)
                Next
            Catch ex As Exception
                Console.Write(ex)
            End Try
        Next
    End Sub

    Private Function CalculateMD5(filePath As String) As String
        Using md5 As MD5 = MD5.Create()
            Using stream As FileStream = File.OpenRead(filePath)
                Dim hashBytes As Byte() = md5.ComputeHash(stream)
                Dim hashStringBuilder As New StringBuilder

                For Each hashByte As Byte In hashBytes
                    hashStringBuilder.Append(hashByte.ToString("x2"))
                Next
                Return hashStringBuilder.ToString()
            End Using
        End Using

    End Function

    Private Sub AddItemToListView(fileName As String, status As String, fileType As String, color As Color)

        Dim item As New ListViewItem(fileName)
        item.SubItems.Add(fileType)
        item.SubItems.Add(status)
        item.ForeColor = color
        Dim setItem As ListViewItem = ListView1.Items.Add(item)
        setItem.EnsureVisible()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        maxim = ListBox1.Items.Count

        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1

            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

            Try
                Dim str As String = ListBox1.SelectedItem.ToString()
                Dim fileExtension As String = Path.GetExtension(str.ToLower())
                fileHash = CalculateMD5(str)
                If md5HashList.Contains(fileHash) Then
                    AddItemToListView(str, "Dangerous", fileExtension, Color.Red)
                    virusList.Add(str)

                    detectedDangers += 1
                Else
                    AddItemToListView(str, "Clean", fileExtension, Color.Green)

                End If
                'MessageBox.Show(str + " " + fileHash)
                lblFileScanned.Text = index.ToString()
                lblDangerous.Text = detectedDangers.ToString()
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

            index += 1
            Dim diff As TimeSpan = DateTime.Now - startTime
            lblTimeElapsed.Text = diff.ToString("mm\:ss")
            lblPercent.Text = System.Math.Round((100 * index / maxim), 2).ToString() + "%"

        Else

            Dim diff As TimeSpan = DateTime.Now - DateTime.Parse(My.Settings.dateOfLastScan)
            My.Settings.dateOfLastScan = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            My.Settings.dateOfLastSessionScan = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            ListView1.Enabled = True
            Timer1.Stop()
            active = False
            lblFileScanned.Text = ListBox1.Items.Count
            If detectedDangers > 0 Then
                detectedDangers = 0
                frmVirus.ShowDialog()
            Else
                If quickOrNot = False Then
                    My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") +
                        " - We scanned and found no threats in " + lastScanPath + ";"

                    My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd HH:mm") +
                        " - Nu au fost detectate pericole in " + lastScanPath + ";"
                Else

                    If diff.Hours > 12 Then
                        My.Settings.eventLog = My.Settings.eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd") + " - No threats found today in scheduled scans;"
                        My.Settings.RO_eventLog = My.Settings.RO_eventLog + " " + DateTime.Now.ToString("yyyy.MM.dd") + " - Nu au fost detectate pericole azi prin scanare rapida;"
                    End If
                End If
                My.Settings.Save()
            End If

        End If
    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles stopScan.MouseDown
        ListView1.Enabled = True
        My.Settings.dateOfLastSessionScan = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Timer1.Stop()
        active = False
        If detectedDangers > 0 Then
            detectedDangers = 0
            frmVirus.ShowDialog()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If active = False And lilRadar.ImageIndex = 35 Then
            lilRadar.ImageIndex = 0
            Timer2.Stop()
        ElseIf lilRadar.ImageIndex = 35 Then
            lilRadar.ImageIndex = 0
        Else
            lilRadar.ImageIndex = lilRadar.ImageIndex + 1
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        StartScan()
    End Sub

    Private Sub ctlScanning_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.dateOfLastScan = "xx" Then
            My.Settings.dateOfLastScan = DateTime.Now.ToString("yyyy.MM.dd HH:mm")
        End If
        changeOnLanguage()
    End Sub
End Class
