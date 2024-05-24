Public Class ctlEventLog
    Private Sub ctlEventLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateLog()
        changeOnLanguage()
    End Sub

    Public Sub updateLog()
        eventLog.Items.Clear()
        Dim evLog As String
        If My.Settings.englishEnabled Then
            evLog = My.Settings.eventLog
        Else
            evLog = My.Settings.RO_eventLog
        End If
        Dim logList() As String
        logList = evLog.Split(";"c)
        For Each Str As String In logList.Reverse
            If Str IsNot "" Then
                eventLog.Items.Add(Str)
            End If
        Next

    End Sub

    Public Sub changeOnLanguage()
        If My.Settings.englishEnabled = True Then
            btnClear.Image = My.Resources.clearBtn
            Panel1.BackgroundImage = My.Resources.Event_log1
        Else
            btnClear.Image = My.Resources.RO_clearBtn
            Panel1.BackgroundImage = My.Resources.RO_Event_log
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        eventLog.Items.Clear()
        My.Settings.eventLog = ""
        My.Settings.RO_eventLog = ""
        My.Settings.Save()
    End Sub
End Class
