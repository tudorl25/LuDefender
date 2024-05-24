Public Class ctlLogIn
    Dim data As DatabaseManager = New DatabaseManager()
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, Label1.MouseDown
        data.Login(lblEmail.Text, lblPass.Text)
        My.Settings.userEmail = lblEmail.Text
        My.Settings.userPassword = lblPass.Text
        frmAccount.Label3.Text = "Account: " + My.Settings.userEmail
        My.Settings.Save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lblPass.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub ctlLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPass.UseSystemPasswordChar = True
    End Sub
End Class
