<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlScanning
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlScanning))
        Panel1 = New Panel()
        Panel2 = New Panel()
        lblTimeElapsed = New Label()
        lblPercent = New Label()
        lblDangerous = New Label()
        lblFileScanned = New Label()
        lilRadar = New Label()
        ImageList1 = New ImageList(components)
        stopScan = New PictureBox()
        PictureBox2 = New PictureBox()
        ListView1 = New ListView()
        fileScanned = New ColumnHeader()
        fileType = New ColumnHeader()
        fileStatus = New ColumnHeader()
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Timer1 = New Timer(components)
        OpenFileDialog1 = New OpenFileDialog()
        Timer2 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(stopScan, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(stopScan)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ListBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(889, 683)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.scanStatus3
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(lblTimeElapsed)
        Panel2.Controls.Add(lblPercent)
        Panel2.Controls.Add(lblDangerous)
        Panel2.Controls.Add(lblFileScanned)
        Panel2.Controls.Add(lilRadar)
        Panel2.Location = New Point(324, 392)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(539, 220)
        Panel2.TabIndex = 30
        ' 
        ' lblTimeElapsed
        ' 
        lblTimeElapsed.AutoSize = True
        lblTimeElapsed.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimeElapsed.ForeColor = Color.White
        lblTimeElapsed.Location = New Point(172, 101)
        lblTimeElapsed.Name = "lblTimeElapsed"
        lblTimeElapsed.Size = New Size(71, 29)
        lblTimeElapsed.TabIndex = 22
        lblTimeElapsed.Text = "00:00"
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPercent.ForeColor = Color.White
        lblPercent.Location = New Point(41, 141)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(48, 29)
        lblPercent.TabIndex = 21
        lblPercent.Text = "0%"
        ' 
        ' lblDangerous
        ' 
        lblDangerous.AutoSize = True
        lblDangerous.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDangerous.ForeColor = Color.White
        lblDangerous.Location = New Point(271, 66)
        lblDangerous.Name = "lblDangerous"
        lblDangerous.Size = New Size(26, 29)
        lblDangerous.TabIndex = 20
        lblDangerous.Text = "0"
        ' 
        ' lblFileScanned
        ' 
        lblFileScanned.AutoSize = True
        lblFileScanned.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFileScanned.ForeColor = Color.White
        lblFileScanned.Location = New Point(271, 29)
        lblFileScanned.Name = "lblFileScanned"
        lblFileScanned.Size = New Size(26, 29)
        lblFileScanned.TabIndex = 19
        lblFileScanned.Text = "0"
        ' 
        ' lilRadar
        ' 
        lilRadar.AutoSize = True
        lilRadar.ImageIndex = 0
        lilRadar.ImageList = ImageList1
        lilRadar.Location = New Point(324, 9)
        lilRadar.MaximumSize = New Size(256, 256)
        lilRadar.MinimumSize = New Size(256, 256)
        lilRadar.Name = "lilRadar"
        lilRadar.Size = New Size(256, 256)
        lilRadar.TabIndex = 24
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
        ' stopScan
        ' 
        stopScan.Image = My.Resources.Resources.stopScan
        stopScan.Location = New Point(44, 511)
        stopScan.Name = "stopScan"
        stopScan.Size = New Size(269, 101)
        stopScan.TabIndex = 28
        stopScan.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.startScan
        PictureBox2.Location = New Point(44, 392)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(273, 100)
        PictureBox2.TabIndex = 22
        PictureBox2.TabStop = False
        ' 
        ' ListView1
        ' 
        ListView1.Alignment = ListViewAlignment.Left
        ListView1.BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        ListView1.BackgroundImage = My.Resources.Resources.filesScannedList
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {fileScanned, fileType, fileStatus})
        ListView1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListView1.ForeColor = Color.White
        ListView1.GridLines = True
        ListView1.HeaderStyle = ColumnHeaderStyle.Nonclickable
        ListView1.Location = New Point(82, 52)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(732, 250)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.List
        ' 
        ' fileScanned
        ' 
        fileScanned.Text = "File scanned"
        fileScanned.Width = 580
        ' 
        ' fileType
        ' 
        fileType.Text = "File type"
        fileType.Width = 75
        ' 
        ' fileStatus
        ' 
        fileStatus.Text = "File status"
        fileStatus.Width = 100
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.filesScanned
        PictureBox1.Location = New Point(44, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(815, 353)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(0, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 30)
        ListBox1.TabIndex = 27
        ListBox1.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 50
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 10
        ' 
        ' ctlScanning
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "ctlScanning"
        Size = New Size(889, 683)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(stopScan, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFileScanned As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblDangerous As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents fileScanned As ColumnHeader
    Friend WithEvents fileType As ColumnHeader
    Friend WithEvents fileStatus As ColumnHeader
    Friend WithEvents stopScan As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lilRadar As Label
    Friend WithEvents Timer2 As Timer

End Class
