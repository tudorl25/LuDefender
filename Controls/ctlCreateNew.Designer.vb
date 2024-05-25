<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlCreateNew
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label3 = New Label()
        lblConfirm = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        lblPass = New TextBox()
        lblEmail = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        CheckBox2.ForeColor = Color.White
        CheckBox2.Location = New Point(48, 224)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(119, 21)
        CheckBox2.TabIndex = 40
        CheckBox2.Text = "Show password"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(46, 145)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(119, 21)
        CheckBox1.TabIndex = 39
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Moulpali", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(458, 114)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 46)
        Label1.TabIndex = 38
        Label1.Text = "CREATE ACCOUNT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(21, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 25)
        Label3.TabIndex = 36
        Label3.Text = "Confirm Password"
        ' 
        ' lblConfirm
        ' 
        lblConfirm.Location = New Point(201, 196)
        lblConfirm.Name = "lblConfirm"
        lblConfirm.Size = New Size(179, 23)
        lblConfirm.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(56, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 34
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(75, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 25)
        Label5.TabIndex = 33
        Label5.Text = "Email"
        ' 
        ' lblPass
        ' 
        lblPass.Location = New Point(201, 116)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(179, 23)
        lblPass.TabIndex = 32
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(201, 42)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(179, 23)
        lblEmail.TabIndex = 31
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.blueButton
        PictureBox1.Location = New Point(438, 93)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(199, 93)
        PictureBox1.TabIndex = 41
        PictureBox1.TabStop = False
        ' 
        ' ctlCreateNew
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        BackgroundImage = My.Resources.Resources.backGround
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Label3)
        Controls.Add(lblConfirm)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(lblPass)
        Controls.Add(lblEmail)
        Name = "ctlCreateNew"
        Size = New Size(696, 299)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPass As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
