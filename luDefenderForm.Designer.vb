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
        panelPanel = New Panel()
        settingButton = New myButton()
        logButton = New myButton()
        toolButton = New myButton()
        scanButton = New myButton()
        dashButton = New myButton()
        slideThingy = New PictureBox()
        topPanel = New Panel()
        ludiLogo = New PictureBox()
        closeButton = New PictureBox()
        minButton = New PictureBox()
        lblTitle = New Label()
        Panel2 = New Panel()
        MainPanel = New Panel()
        CtlScanning1 = New ctlScanning()
        CtlDashboard1 = New ctlDashboard()
        Timer1 = New Timer(components)
        panelPanel.SuspendLayout()
        CType(slideThingy, ComponentModel.ISupportInitialize).BeginInit()
        topPanel.SuspendLayout()
        CType(ludiLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(closeButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(minButton, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        MainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelPanel
        ' 
        panelPanel.BackColor = Color.CornflowerBlue
        panelPanel.BorderStyle = BorderStyle.FixedSingle
        panelPanel.Controls.Add(settingButton)
        panelPanel.Controls.Add(logButton)
        panelPanel.Controls.Add(toolButton)
        panelPanel.Controls.Add(scanButton)
        panelPanel.Controls.Add(dashButton)
        panelPanel.Controls.Add(slideThingy)
        panelPanel.Controls.Add(topPanel)
        panelPanel.Dock = DockStyle.Top
        panelPanel.Location = New Point(0, 0)
        panelPanel.Name = "panelPanel"
        panelPanel.Size = New Size(1026, 100)
        panelPanel.TabIndex = 0
        ' 
        ' settingButton
        ' 
        settingButton.BotColor = Color.CornflowerBlue
        settingButton.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        settingButton.ForeColor = Color.Snow
        settingButton.Location = New Point(906, 59)
        settingButton.Name = "settingButton"
        settingButton.Size = New Size(109, 23)
        settingButton.TabIndex = 6
        settingButton.Text = "Settings"
        settingButton.TopColor = Color.CornflowerBlue
        settingButton.UseVisualStyleBackColor = True
        ' 
        ' logButton
        ' 
        logButton.BotColor = Color.CornflowerBlue
        logButton.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logButton.ForeColor = Color.Snow
        logButton.Location = New Point(768, 58)
        logButton.Name = "logButton"
        logButton.Size = New Size(123, 23)
        logButton.TabIndex = 5
        logButton.Text = "Event log"
        logButton.TopColor = Color.CornflowerBlue
        logButton.UseVisualStyleBackColor = True
        ' 
        ' toolButton
        ' 
        toolButton.BotColor = Color.CornflowerBlue
        toolButton.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        toolButton.ForeColor = Color.Snow
        toolButton.Location = New Point(331, 59)
        toolButton.Name = "toolButton"
        toolButton.Size = New Size(75, 23)
        toolButton.TabIndex = 4
        toolButton.Text = "Tools"
        toolButton.TopColor = Color.CornflowerBlue
        toolButton.UseVisualStyleBackColor = True
        ' 
        ' scanButton
        ' 
        scanButton.BotColor = Color.CornflowerBlue
        scanButton.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        scanButton.ForeColor = Color.Snow
        scanButton.Location = New Point(170, 58)
        scanButton.Name = "scanButton"
        scanButton.Size = New Size(140, 23)
        scanButton.TabIndex = 3
        scanButton.Text = "Scanning"
        scanButton.TopColor = Color.CornflowerBlue
        scanButton.UseVisualStyleBackColor = True
        ' 
        ' dashButton
        ' 
        dashButton.BotColor = Color.CornflowerBlue
        dashButton.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dashButton.ForeColor = Color.Snow
        dashButton.Location = New Point(13, 59)
        dashButton.Name = "dashButton"
        dashButton.Size = New Size(139, 23)
        dashButton.TabIndex = 2
        dashButton.Text = "Dashboard"
        dashButton.TopColor = Color.CornflowerBlue
        dashButton.UseVisualStyleBackColor = True
        ' 
        ' slideThingy
        ' 
        slideThingy.BackColor = Color.Snow
        slideThingy.Location = New Point(13, 83)
        slideThingy.Name = "slideThingy"
        slideThingy.Size = New Size(139, 10)
        slideThingy.TabIndex = 1
        slideThingy.TabStop = False
        ' 
        ' topPanel
        ' 
        topPanel.BackColor = Color.CornflowerBlue
        topPanel.BorderStyle = BorderStyle.FixedSingle
        topPanel.Controls.Add(ludiLogo)
        topPanel.Controls.Add(closeButton)
        topPanel.Controls.Add(minButton)
        topPanel.Controls.Add(lblTitle)
        topPanel.Dock = DockStyle.Top
        topPanel.Location = New Point(0, 0)
        topPanel.Name = "topPanel"
        topPanel.Size = New Size(1024, 47)
        topPanel.TabIndex = 0
        ' 
        ' ludiLogo
        ' 
        ludiLogo.BackColor = Color.Lime
        ludiLogo.Location = New Point(3, 2)
        ludiLogo.Name = "ludiLogo"
        ludiLogo.Size = New Size(40, 40)
        ludiLogo.SizeMode = PictureBoxSizeMode.Zoom
        ludiLogo.TabIndex = 3
        ludiLogo.TabStop = False
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = Color.Transparent
        closeButton.Image = CType(resources.GetObject("closeButton.Image"), Image)
        closeButton.Location = New Point(979, 3)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(40, 40)
        closeButton.SizeMode = PictureBoxSizeMode.Zoom
        closeButton.TabIndex = 2
        closeButton.TabStop = False
        ' 
        ' minButton
        ' 
        minButton.BackColor = Color.Transparent
        minButton.Image = CType(resources.GetObject("minButton.Image"), Image)
        minButton.Location = New Point(923, -1)
        minButton.Name = "minButton"
        minButton.Size = New Size(50, 50)
        minButton.SizeMode = PictureBoxSizeMode.Zoom
        minButton.TabIndex = 1
        minButton.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Snow
        lblTitle.Location = New Point(49, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(162, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "luDefender"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(MainPanel)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1026, 706)
        Panel2.TabIndex = 2
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(CtlDashboard1)
        MainPanel.Controls.Add(CtlScanning1)
        MainPanel.Location = New Point(-1, 99)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(1026, 606)
        MainPanel.TabIndex = 0
        ' 
        ' CtlScanning1
        ' 
        CtlScanning1.BackColor = Color.Snow
        CtlScanning1.Location = New Point(-1, 0)
        CtlScanning1.Name = "CtlScanning1"
        CtlScanning1.Size = New Size(1026, 606)
        CtlScanning1.TabIndex = 1
        ' 
        ' CtlDashboard1
        ' 
        CtlDashboard1.BackColor = Color.Snow
        CtlDashboard1.Location = New Point(-1, 0)
        CtlDashboard1.Name = "CtlDashboard1"
        CtlDashboard1.Size = New Size(1026, 606)
        CtlDashboard1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 25
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(1026, 706)
        Controls.Add(panelPanel)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        Text = "Form1"
        panelPanel.ResumeLayout(False)
        CType(slideThingy, ComponentModel.ISupportInitialize).EndInit()
        topPanel.ResumeLayout(False)
        topPanel.PerformLayout()
        CType(ludiLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(closeButton, ComponentModel.ISupportInitialize).EndInit()
        CType(minButton, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents minButton As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents slideThingy As PictureBox
    Friend WithEvents dashButton As myButton
    Friend WithEvents toolButton As myButton
    Friend WithEvents scanButton As myButton
    Friend WithEvents settingButton As myButton
    Friend WithEvents logButton As myButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ludiLogo As PictureBox
    Friend WithEvents CtlDashboard1 As ctlDashboard
    Friend WithEvents CtlScanning1 As ctlScanning

End Class
