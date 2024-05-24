<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        closeButton = New PictureBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(closeButton)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(696, 47)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.appLogo
        PictureBox1.Location = New Point(11, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 43)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.Transparent
        closeButton.Image = CType(resources.GetObject("closeButton.Image"), Image)
        closeButton.Location = New Point(757, 4)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(40, 40)
        closeButton.SizeMode = PictureBoxSizeMode.Zoom
        closeButton.TabIndex = 3
        closeButton.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(696, 299)
        Panel1.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.ignoreThem
        PictureBox2.Location = New Point(50, 352)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(270, 86)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.removeThem
        PictureBox3.Location = New Point(341, 352)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(306, 86)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(70, 371)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 32)
        Label1.TabIndex = 8
        Label1.Text = "LOG INTO ACCOUNT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(363, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(267, 32)
        Label2.TabIndex = 9
        Label2.Text = "CREATE NEW ACCOUNT"
        ' 
        ' frmAccount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        BackgroundImage = My.Resources.Resources.backGround
        ClientSize = New Size(696, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAccount"
        Text = "frmAccount"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(closeButton, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
