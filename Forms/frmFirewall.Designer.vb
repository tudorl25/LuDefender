<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirewall
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirewall))
        Panel1 = New Panel()
        MyButton2 = New myButton()
        MyButton1 = New myButton()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        closeButton = New PictureBox()
        CircularPictureBox3 = New circularPictureBox()
        CircularPictureBox1 = New circularPictureBox()
        CircularPictureBox2 = New circularPictureBox()
        CircularPictureBox4 = New circularPictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(CircularPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(CircularPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(CircularPictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(CircularPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(MyButton1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(CircularPictureBox3)
        Panel1.Controls.Add(CircularPictureBox1)
        Panel1.Controls.Add(CircularPictureBox2)
        Panel1.Controls.Add(CircularPictureBox4)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 225)
        Panel1.TabIndex = 1
        ' 
        ' MyButton2
        ' 
        MyButton2.BotColor = Color.CornflowerBlue
        MyButton2.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MyButton2.ForeColor = Color.Snow
        MyButton2.Location = New Point(207, 132)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(139, 53)
        MyButton2.TabIndex = 4
        MyButton2.Text = "Yes, I'm sure"
        MyButton2.TopColor = Color.CornflowerBlue
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' MyButton1
        ' 
        MyButton1.BotColor = Color.CornflowerBlue
        MyButton1.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MyButton1.ForeColor = Color.Snow
        MyButton1.Location = New Point(25, 132)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(139, 53)
        MyButton1.TabIndex = 3
        MyButton1.Text = "No, go back"
        MyButton1.TopColor = Color.CornflowerBlue
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(102, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 20)
        Label2.TabIndex = 2
        Label2.Text = "the Firewall off?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(6, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 23)
        Label1.TabIndex = 1
        Label1.Text = "Are you sure that you want to turn"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.CornflowerBlue
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(lblTitle)
        Panel2.Controls.Add(closeButton)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(373, 47)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Lime
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Snow
        lblTitle.Location = New Point(48, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(162, 30)
        lblTitle.TabIndex = 4
        lblTitle.Text = "luDefender"
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.Transparent
        closeButton.Image = CType(resources.GetObject("closeButton.Image"), Image)
        closeButton.Location = New Point(331, 3)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(40, 40)
        closeButton.SizeMode = PictureBoxSizeMode.Zoom
        closeButton.TabIndex = 3
        closeButton.TabStop = False
        ' 
        ' CircularPictureBox3
        ' 
        CircularPictureBox3.BackColor = Color.CornflowerBlue
        CircularPictureBox3.Location = New Point(150, 132)
        CircularPictureBox3.Name = "CircularPictureBox3"
        CircularPictureBox3.Size = New Size(25, 53)
        CircularPictureBox3.TabIndex = 10
        CircularPictureBox3.TabStop = False
        ' 
        ' CircularPictureBox1
        ' 
        CircularPictureBox1.BackColor = Color.CornflowerBlue
        CircularPictureBox1.Location = New Point(13, 132)
        CircularPictureBox1.Name = "CircularPictureBox1"
        CircularPictureBox1.Size = New Size(25, 53)
        CircularPictureBox1.TabIndex = 11
        CircularPictureBox1.TabStop = False
        ' 
        ' CircularPictureBox2
        ' 
        CircularPictureBox2.BackColor = Color.CornflowerBlue
        CircularPictureBox2.Location = New Point(194, 132)
        CircularPictureBox2.Name = "CircularPictureBox2"
        CircularPictureBox2.Size = New Size(25, 53)
        CircularPictureBox2.TabIndex = 12
        CircularPictureBox2.TabStop = False
        ' 
        ' CircularPictureBox4
        ' 
        CircularPictureBox4.BackColor = Color.CornflowerBlue
        CircularPictureBox4.Location = New Point(333, 132)
        CircularPictureBox4.Name = "CircularPictureBox4"
        CircularPictureBox4.Size = New Size(25, 53)
        CircularPictureBox4.TabIndex = 13
        CircularPictureBox4.TabStop = False
        ' 
        ' frmFirewall
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(375, 225)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmFirewall"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmFirewall"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(closeButton, ComponentModel.ISupportInitialize).EndInit()
        CType(CircularPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(CircularPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(CircularPictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(CircularPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyButton2 As myButton
    Friend WithEvents MyButton1 As myButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents CircularPictureBox3 As circularPictureBox
    Friend WithEvents CircularPictureBox1 As circularPictureBox
    Friend WithEvents CircularPictureBox2 As circularPictureBox
    Friend WithEvents CircularPictureBox4 As circularPictureBox
End Class
