Public Class ctlCreateNew
    Dim data As DatabaseManager = New DatabaseManager()


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, Label1.MouseDown
        If lblPass.Text = lblConfirm.Text Then
            data.CreateNew(lblEmail.Text, lblPass.Text)
            My.Settings.userEmail = lblEmail.Text
            My.Settings.userPassword = lblPass.Text
            frmAccount.Label3.Text = "Account: " + My.Settings.userEmail
            My.Settings.Save()
        Else
            MessageBox.Show("The confirmed password is different")
        End If
    End Sub

    Private Sub ctlCreateNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPass.UseSystemPasswordChar = True
        lblConfirm.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        lblPass.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        lblConfirm.UseSystemPasswordChar = Not CheckBox2.Checked
    End Sub
End Class
