Public Class ctlEventLog
    Private Sub ctlEventLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.englishEnabled = True Then
            Panel1.BackgroundImage = My.Resources.Event_log1
        Else
            Panel1.BackgroundImage = My.Resources.RO_Event_log
        End If

    End Sub
End Class
