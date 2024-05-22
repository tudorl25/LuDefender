<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        NotifyIcon1 = New NotifyIcon(components)
        mainPanel = New Panel()
        FrmSettings1 = New frmSettings()
        topPanel = New Panel()
        btnClose = New PictureBox()
        btnMin = New PictureBox()
        appLogo = New PictureBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnDash = New PictureBox()
        btnScan = New PictureBox()
        btnTool = New PictureBox()
        btnLog = New PictureBox()
        btnSettings = New PictureBox()
        selectionThingy = New PictureBox()
        CtlDashboard1 = New ctlDashboard()
        CtlScanning1 = New ctlScanning()
        FrmTools1 = New frmTools()
        transitionPic = New PictureBox()
        mainPanel.SuspendLayout()
        topPanel.SuspendLayout()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(appLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(btnDash, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnScan, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnTool, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnLog, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnSettings, ComponentModel.ISupportInitialize).BeginInit()
        CType(selectionThingy, ComponentModel.ISupportInitialize).BeginInit()
        CType(transitionPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.Transparent
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(topPanel)
        mainPanel.Controls.Add(Panel1)
        mainPanel.Controls.Add(CtlDashboard1)
        mainPanel.Controls.Add(CtlScanning1)
        mainPanel.Controls.Add(FrmTools1)
        mainPanel.Controls.Add(transitionPic)
        mainPanel.Controls.Add(FrmSettings1)
        mainPanel.Location = New Point(-1, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1076, 764)
        mainPanel.TabIndex = 0
        ' 
        ' FrmSettings1
        ' 
        FrmSettings1.BackColor = Color.Transparent
        FrmSettings1.BackgroundImage = CType(resources.GetObject("FrmSettings1.BackgroundImage"), Image)
        FrmSettings1.BackgroundImageLayout = ImageLayout.Center
        FrmSettings1.Location = New Point(187, 80)
        FrmSettings1.Name = "FrmSettings1"
        FrmSettings1.Size = New Size(889, 683)
        FrmSettings1.TabIndex = 6
        ' 
        ' topPanel
        ' 
        topPanel.BackColor = Color.Transparent
        topPanel.Controls.Add(btnClose)
        topPanel.Controls.Add(btnMin)
        topPanel.Controls.Add(appLogo)
        topPanel.Dock = DockStyle.Top
        topPanel.Location = New Point(0, 0)
        topPanel.Name = "topPanel"
        topPanel.Size = New Size(1074, 82)
        topPanel.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Image = My.Resources.Resources.closeButton
        btnClose.Location = New Point(1015, 25)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(39, 39)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 2
        btnClose.TabStop = False
        ' 
        ' btnMin
        ' 
        btnMin.Image = My.Resources.Resources.minButton
        btnMin.Location = New Point(954, 25)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(39, 39)
        btnMin.SizeMode = PictureBoxSizeMode.Zoom
        btnMin.TabIndex = 1
        btnMin.TabStop = False
        ' 
        ' appLogo
        ' 
        appLogo.Image = My.Resources.Resources.appLogo
        appLogo.Location = New Point(40, 19)
        appLogo.Name = "appLogo"
        appLogo.Size = New Size(140, 50)
        appLogo.TabIndex = 0
        appLogo.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnDash)
        Panel1.Controls.Add(btnScan)
        Panel1.Controls.Add(btnTool)
        Panel1.Controls.Add(btnLog)
        Panel1.Controls.Add(btnSettings)
        Panel1.Controls.Add(selectionThingy)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(190, 764)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(187, 81)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(889, 683)
        Panel2.TabIndex = 12
        ' 
        ' btnDash
        ' 
        btnDash.Image = My.Resources.Resources.dasboardTab
        btnDash.Location = New Point(33, 102)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(113, 32)
        btnDash.TabIndex = 4
        btnDash.TabStop = False
        ' 
        ' btnScan
        ' 
        btnScan.Image = My.Resources.Resources.scanningTab
        btnScan.Location = New Point(33, 150)
        btnScan.Name = "btnScan"
        btnScan.Size = New Size(113, 34)
        btnScan.TabIndex = 3
        btnScan.TabStop = False
        ' 
        ' btnTool
        ' 
        btnTool.Image = My.Resources.Resources.toolTab
        btnTool.Location = New Point(33, 198)
        btnTool.Name = "btnTool"
        btnTool.Size = New Size(113, 32)
        btnTool.TabIndex = 2
        btnTool.TabStop = False
        ' 
        ' btnLog
        ' 
        btnLog.Image = My.Resources.Resources.logTab
        btnLog.Location = New Point(33, 247)
        btnLog.Name = "btnLog"
        btnLog.Size = New Size(113, 33)
        btnLog.TabIndex = 1
        btnLog.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Image = My.Resources.Resources.settingsTab
        btnSettings.Location = New Point(33, 295)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(113, 33)
        btnSettings.TabIndex = 0
        btnSettings.TabStop = False
        ' 
        ' selectionThingy
        ' 
        selectionThingy.Image = My.Resources.Resources.selectionThingy1
        selectionThingy.Location = New Point(115, 98)
        selectionThingy.Name = "selectionThingy"
        selectionThingy.Size = New Size(73, 50)
        selectionThingy.TabIndex = 5
        selectionThingy.TabStop = False
        ' 
        ' CtlDashboard1
        ' 
        CtlDashboard1.BackColor = Color.Transparent
        CtlDashboard1.BackgroundImage = CType(resources.GetObject("CtlDashboard1.BackgroundImage"), Image)
        CtlDashboard1.BackgroundImageLayout = ImageLayout.Center
        CtlDashboard1.Location = New Point(184, 80)
        CtlDashboard1.Name = "CtlDashboard1"
        CtlDashboard1.Size = New Size(889, 683)
        CtlDashboard1.TabIndex = 2
        ' 
        ' CtlScanning1
        ' 
        CtlScanning1.BackColor = Color.Transparent
        CtlScanning1.BackgroundImage = CType(resources.GetObject("CtlScanning1.BackgroundImage"), Image)
        CtlScanning1.BackgroundImageLayout = ImageLayout.Center
        CtlScanning1.Location = New Point(187, 84)
        CtlScanning1.Name = "CtlScanning1"
        CtlScanning1.Size = New Size(889, 683)
        CtlScanning1.TabIndex = 3
        ' 
        ' FrmTools1
        ' 
        FrmTools1.BackColor = Color.Transparent
        FrmTools1.BackgroundImage = CType(resources.GetObject("FrmTools1.BackgroundImage"), Image)
        FrmTools1.BackgroundImageLayout = ImageLayout.Center
        FrmTools1.Location = New Point(186, 82)
        FrmTools1.Name = "FrmTools1"
        FrmTools1.Size = New Size(889, 683)
        FrmTools1.TabIndex = 4
        ' 
        ' transitionPic
        ' 
        transitionPic.Image = My.Resources.Resources.bigPatch4
        transitionPic.Location = New Point(187, 81)
        transitionPic.Name = "transitionPic"
        transitionPic.Size = New Size(889, 683)
        transitionPic.TabIndex = 5
        transitionPic.TabStop = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(22), CByte(18), CByte(47))
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1074, 764)
        Controls.Add(mainPanel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        Text = "Form1"
        mainPanel.ResumeLayout(False)
        topPanel.ResumeLayout(False)
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        CType(btnMin, ComponentModel.ISupportInitialize).EndInit()
        CType(appLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(btnDash, ComponentModel.ISupportInitialize).EndInit()
        CType(btnScan, ComponentModel.ISupportInitialize).EndInit()
        CType(btnTool, ComponentModel.ISupportInitialize).EndInit()
        CType(btnLog, ComponentModel.ISupportInitialize).EndInit()
        CType(btnSettings, ComponentModel.ISupportInitialize).EndInit()
        CType(selectionThingy, ComponentModel.ISupportInitialize).EndInit()
        CType(transitionPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents mainPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents appLogo As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMin As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSettings As PictureBox
    Friend WithEvents btnDash As PictureBox
    Friend WithEvents btnScan As PictureBox
    Friend WithEvents btnTool As PictureBox
    Friend WithEvents btnLog As PictureBox
    Friend WithEvents selectionThingy As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents CtlScanning1 As ctlScanning
    Friend WithEvents FrmTools1 As frmTools
    Friend WithEvents transitionPic As PictureBox
    Friend WithEvents FrmSettings1 As frmSettings

End Class
