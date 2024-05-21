<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVirus
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVirus))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        closeButton = New PictureBox()
        Panel1 = New Panel()
        btnRemove = New PictureBox()
        btnIgnore = New PictureBox()
        detectedThreats = New ListBox()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnRemove, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnIgnore, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.Size = New Size(800, 47)
        Panel2.TabIndex = 1
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
        closeButton.Location = New Point(757, 3)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(40, 40)
        closeButton.SizeMode = PictureBoxSizeMode.Zoom
        closeButton.TabIndex = 3
        closeButton.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnRemove)
        Panel1.Controls.Add(btnIgnore)
        Panel1.Controls.Add(detectedThreats)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 403)
        Panel1.TabIndex = 2
        ' 
        ' btnRemove
        ' 
        btnRemove.Image = My.Resources.Resources.removeThem
        btnRemove.Location = New Point(398, 292)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(307, 82)
        btnRemove.TabIndex = 3
        btnRemove.TabStop = False
        ' 
        ' btnIgnore
        ' 
        btnIgnore.Image = My.Resources.Resources.ignoreThem
        btnIgnore.Location = New Point(99, 292)
        btnIgnore.Name = "btnIgnore"
        btnIgnore.Size = New Size(271, 82)
        btnIgnore.TabIndex = 2
        btnIgnore.TabStop = False
        ' 
        ' detectedThreats
        ' 
        detectedThreats.BackColor = Color.FromArgb(CByte(32), CByte(27), CByte(60))
        detectedThreats.BorderStyle = BorderStyle.FixedSingle
        detectedThreats.Font = New Font("Moulpali", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        detectedThreats.ForeColor = Color.Tomato
        detectedThreats.FormattingEnabled = True
        detectedThreats.ItemHeight = 46
        detectedThreats.Location = New Point(85, 48)
        detectedThreats.Name = "detectedThreats"
        detectedThreats.Size = New Size(645, 186)
        detectedThreats.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.files_scanned_list
        PictureBox2.Location = New Point(50, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(718, 270)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' frmVirus
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmVirus"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmVirus"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(closeButton, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(btnRemove, ComponentModel.ISupportInitialize).EndInit()
        CType(btnIgnore, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents detectedThreats As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnIgnore As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRemove As PictureBox
End Class
