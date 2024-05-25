<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlLogIn
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        Label5 = New Label()
        lblPass = New TextBox()
        lblEmail = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Moulpali", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(478, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 42)
        Label1.TabIndex = 48
        Label1.Text = "LOG INTO ACCOUNT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.blueButton
        PictureBox1.Location = New Point(455, 80)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 91)
        PictureBox1.TabIndex = 51
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(61, 185)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(119, 21)
        CheckBox1.TabIndex = 49
        CheckBox1.Text = "Show password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(71, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 45
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(90, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 25)
        Label5.TabIndex = 44
        Label5.Text = "Email"
        ' 
        ' lblPass
        ' 
        lblPass.Location = New Point(216, 156)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(179, 23)
        lblPass.TabIndex = 43
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(216, 82)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(179, 23)
        lblEmail.TabIndex = 42
        ' 
        ' ctlLogIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        BackgroundImage = My.Resources.Resources.backGround
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(lblPass)
        Controls.Add(lblEmail)
        Name = "ctlLogIn"
        Size = New Size(696, 299)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPass As TextBox
    Friend WithEvents lblEmail As TextBox

End Class
