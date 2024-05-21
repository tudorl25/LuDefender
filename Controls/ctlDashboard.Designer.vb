<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlDashboard
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
        Panel1 = New Panel()
        lblMinutes = New Label()
        lblDaysHours = New Label()
        lblSafe = New Label()
        lblCorny = New Label()
        PictureBox4 = New PictureBox()
        btnFullScan = New PictureBox()
        btnQuickScan = New PictureBox()
        PictureBox1 = New PictureBox()
        logoSafety = New PictureBox()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnFullScan, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnQuickScan, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoSafety, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.bigPatch4
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Location = New Point(0, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(889, 683)
        Panel1.TabIndex = 0
        ' 
        ' lblMinutes
        ' 
        lblMinutes.AutoSize = True
        lblMinutes.Font = New Font("Moulpali", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMinutes.ForeColor = Color.White
        lblMinutes.Image = My.Resources.Resources.lilPatch3
        lblMinutes.Location = New Point(629, 497)
        lblMinutes.Name = "lblMinutes"
        lblMinutes.Size = New Size(132, 60)
        lblMinutes.TabIndex = 20
        lblMinutes.Text = "0 minutes"
        ' 
        ' lblDaysHours
        ' 
        lblDaysHours.AutoSize = True
        lblDaysHours.Font = New Font("Moulpali", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDaysHours.ForeColor = Color.White
        lblDaysHours.Image = My.Resources.Resources.lilPatch2
        lblDaysHours.Location = New Point(629, 437)
        lblDaysHours.Name = "lblDaysHours"
        lblDaysHours.Size = New Size(190, 60)
        lblDaysHours.TabIndex = 19
        lblDaysHours.Text = "0 days, 0 hours"
        ' 
        ' lblSafe
        ' 
        lblSafe.AutoSize = True
        lblSafe.BackColor = Color.Transparent
        lblSafe.Font = New Font("Moulpali", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSafe.ForeColor = Color.White
        lblSafe.Image = My.Resources.Resources.lilPatch
        lblSafe.Location = New Point(264, 239)
        lblSafe.Name = "lblSafe"
        lblSafe.Size = New Size(71, 60)
        lblSafe.TabIndex = 18
        lblSafe.Text = "Safe"
        ' 
        ' lblCorny
        ' 
        lblCorny.AutoSize = True
        lblCorny.BackColor = Color.Transparent
        lblCorny.Font = New Font("Moulpali", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCorny.ForeColor = Color.White
        lblCorny.Location = New Point(70, 292)
        lblCorny.Name = "lblCorny"
        lblCorny.Size = New Size(661, 34)
        lblCorny.TabIndex = 17
        lblCorny.Text = "Our protective measures have been implemented, so don't worry, LuDefender is making sure of your safety"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.lastScanLgo1
        PictureBox4.Location = New Point(600, 376)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(251, 217)
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' btnFullScan
        ' 
        btnFullScan.Image = My.Resources.Resources.fullScanLogo
        btnFullScan.Location = New Point(320, 376)
        btnFullScan.Name = "btnFullScan"
        btnFullScan.Size = New Size(251, 217)
        btnFullScan.TabIndex = 15
        btnFullScan.TabStop = False
        ' 
        ' btnQuickScan
        ' 
        btnQuickScan.Image = My.Resources.Resources.quickScanLogo
        btnQuickScan.Location = New Point(40, 376)
        btnQuickScan.Name = "btnQuickScan"
        btnQuickScan.Size = New Size(251, 217)
        btnQuickScan.TabIndex = 14
        btnQuickScan.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.statusSafeLogo1
        PictureBox1.Location = New Point(40, 233)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(816, 116)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' logoSafety
        ' 
        logoSafety.Image = My.Resources.Resources.weGotYourBackLogo
        logoSafety.Location = New Point(245, 35)
        logoSafety.Name = "logoSafety"
        logoSafety.Size = New Size(386, 160)
        logoSafety.TabIndex = 12
        logoSafety.TabStop = False
        ' 
        ' ctlDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(16), CByte(12), CByte(40))
        BackgroundImage = My.Resources.Resources.bigPatch4
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(lblMinutes)
        Controls.Add(lblDaysHours)
        Controls.Add(lblSafe)
        Controls.Add(lblCorny)
        Controls.Add(PictureBox4)
        Controls.Add(btnFullScan)
        Controls.Add(btnQuickScan)
        Controls.Add(PictureBox1)
        Controls.Add(logoSafety)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "ctlDashboard"
        Size = New Size(889, 683)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(btnFullScan, ComponentModel.ISupportInitialize).EndInit()
        CType(btnQuickScan, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(logoSafety, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblDaysHours As Label
    Friend WithEvents lblSafe As Label
    Friend WithEvents lblCorny As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnFullScan As PictureBox
    Friend WithEvents btnQuickScan As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents logoSafety As PictureBox

End Class
