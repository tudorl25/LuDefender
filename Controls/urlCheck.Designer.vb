<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class urlCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(urlCheck))
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        closeButton = New PictureBox()
        Panel1 = New Panel()
        lblUrl = New Label()
        lblState2 = New Label()
        Label3 = New Label()
        lblState1 = New Label()
        lilRadar = New Label()
        ImageList1 = New ImageList(components)
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        Panel2.Size = New Size(397, 47)
        Panel2.TabIndex = 3
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
        closeButton.Location = New Point(351, 6)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(40, 40)
        closeButton.SizeMode = PictureBoxSizeMode.Zoom
        closeButton.TabIndex = 3
        closeButton.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblUrl)
        Panel1.Controls.Add(lblState2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblState1)
        Panel1.Controls.Add(lilRadar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(397, 450)
        Panel1.TabIndex = 4
        ' 
        ' lblUrl
        ' 
        lblUrl.Font = New Font("Moulpali", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUrl.ForeColor = Color.White
        lblUrl.Location = New Point(12, 347)
        lblUrl.Name = "lblUrl"
        lblUrl.Size = New Size(373, 42)
        lblUrl.TabIndex = 3
        lblUrl.Text = "http://www.website.com"
        lblUrl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblState2
        ' 
        lblState2.Font = New Font("Moulpali", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblState2.ForeColor = Color.White
        lblState2.Location = New Point(12, 379)
        lblState2.Name = "lblState2"
        lblState2.Size = New Size(373, 42)
        lblState2.TabIndex = 4
        lblState2.Text = "poses any threat to your device..."
        lblState2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 401)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        ' 
        ' lblState1
        ' 
        lblState1.Font = New Font("Moulpali", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblState1.ForeColor = Color.White
        lblState1.Location = New Point(12, 318)
        lblState1.Name = "lblState1"
        lblState1.Size = New Size(373, 42)
        lblState1.TabIndex = 1
        lblState1.Text = "STATUS: Trying to determine whether"
        lblState1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lilRadar
        ' 
        lilRadar.AutoSize = True
        lilRadar.ImageIndex = 0
        lilRadar.ImageList = ImageList1
        lilRadar.Location = New Point(66, 50)
        lilRadar.MinimumSize = New Size(256, 256)
        lilRadar.Name = "lilRadar"
        lilRadar.Size = New Size(256, 256)
        lilRadar.TabIndex = 0
        lilRadar.Text = "Label1"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "radar1.png")
        ImageList1.Images.SetKeyName(1, "radar2.png")
        ImageList1.Images.SetKeyName(2, "radar3.png")
        ImageList1.Images.SetKeyName(3, "radar4.png")
        ImageList1.Images.SetKeyName(4, "radar5.png")
        ImageList1.Images.SetKeyName(5, "radar6.png")
        ImageList1.Images.SetKeyName(6, "radar7.png")
        ImageList1.Images.SetKeyName(7, "radar8.png")
        ImageList1.Images.SetKeyName(8, "radar9.png")
        ImageList1.Images.SetKeyName(9, "radar10.png")
        ImageList1.Images.SetKeyName(10, "radar11.png")
        ImageList1.Images.SetKeyName(11, "radar12.png")
        ImageList1.Images.SetKeyName(12, "radar13.png")
        ImageList1.Images.SetKeyName(13, "radar14.png")
        ImageList1.Images.SetKeyName(14, "radar15.png")
        ImageList1.Images.SetKeyName(15, "radar16.png")
        ImageList1.Images.SetKeyName(16, "radar17.png")
        ImageList1.Images.SetKeyName(17, "radar18.png")
        ImageList1.Images.SetKeyName(18, "radar19.png")
        ImageList1.Images.SetKeyName(19, "radar20.png")
        ImageList1.Images.SetKeyName(20, "radar21.png")
        ImageList1.Images.SetKeyName(21, "radar22.png")
        ImageList1.Images.SetKeyName(22, "radar23.png")
        ImageList1.Images.SetKeyName(23, "radar24.png")
        ImageList1.Images.SetKeyName(24, "radar25.png")
        ImageList1.Images.SetKeyName(25, "radar26.png")
        ImageList1.Images.SetKeyName(26, "radar27.png")
        ImageList1.Images.SetKeyName(27, "radar28.png")
        ImageList1.Images.SetKeyName(28, "radar29.png")
        ImageList1.Images.SetKeyName(29, "radar30.png")
        ImageList1.Images.SetKeyName(30, "radar31.png")
        ImageList1.Images.SetKeyName(31, "radar32.png")
        ImageList1.Images.SetKeyName(32, "radar33.png")
        ImageList1.Images.SetKeyName(33, "radar34.png")
        ImageList1.Images.SetKeyName(34, "radar35.png")
        ImageList1.Images.SetKeyName(35, "radar36.png")
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' urlCheck
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(397, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "urlCheck"
        StartPosition = FormStartPosition.CenterParent
        Text = "urlCheck"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(closeButton, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lilRadar As Label
    Friend WithEvents lblUrl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblState1 As Label
    Friend WithEvents lblState2 As Label
End Class
