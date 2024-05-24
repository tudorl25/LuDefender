<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTools
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
        btnFirewall = New PictureBox()
        userInput = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        btnShredder = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        CType(btnFirewall, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnShredder, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnFirewall
        ' 
        btnFirewall.Image = My.Resources.Resources.disable_firewall
        btnFirewall.Location = New Point(47, 17)
        btnFirewall.Name = "btnFirewall"
        btnFirewall.Size = New Size(795, 168)
        btnFirewall.TabIndex = 22
        btnFirewall.TabStop = False
        ' 
        ' userInput
        ' 
        userInput.AcceptsTab = True
        userInput.BackColor = Color.FromArgb(CByte(46), CByte(41), CByte(68))
        userInput.BorderStyle = BorderStyle.None
        userInput.Font = New Font("Moulpali", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userInput.ForeColor = Color.White
        userInput.Location = New Point(81, 334)
        userInput.Name = "userInput"
        userInput.Size = New Size(724, 33)
        userInput.TabIndex = 23
        userInput.Text = "http://www.website.com"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.url_checker
        PictureBox1.Location = New Point(42, 206)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 211)
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(btnShredder)
        Panel1.Controls.Add(btnFirewall)
        Panel1.Controls.Add(userInput)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(889, 683)
        Panel1.TabIndex = 25
        ' 
        ' btnShredder
        ' 
        btnShredder.Image = My.Resources.Resources.file_shredder
        btnShredder.Location = New Point(42, 439)
        btnShredder.Name = "btnShredder"
        btnShredder.Size = New Size(800, 175)
        btnShredder.TabIndex = 25
        btnShredder.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' frmTools
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "frmTools"
        Size = New Size(889, 683)
        CType(btnFirewall, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnShredder, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnFirewall As PictureBox
    Friend WithEvents userInput As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnShredder As PictureBox

End Class
