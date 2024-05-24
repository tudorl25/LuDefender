Public Class ctlCreateNew
    Dim data As DatabaseManager = New DatabaseManager()


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, Label1.MouseDown
        If lblPass.Text = lblConfirm.Text Then
            data.CreateNew(lblEmail.Text, lblPass.Text)
        End If
    End Sub

    Private Sub ctlCreateNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblPass.UseSystemPasswordChar = True
        lblConfirm.UseSystemPasswordChar = True
    End Sub
End Class
