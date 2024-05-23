<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        blueUp = New PictureBox()
        blueDown = New PictureBox()
        redUp = New PictureBox()
        redDown = New PictureBox()
        purpleDown = New PictureBox()
        purpleUp = New PictureBox()
        lblScheduled = New Label()
        lblLanguage = New Label()
        lblStartup = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(blueUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(blueDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(redUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(redDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(purpleDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(purpleUp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.settingScheduledScanning
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(47, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(793, 190)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.settingDisplayedLanguage
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(47, 219)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(793, 190)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = My.Resources.Resources.settingRunOnStartup
        PictureBox3.BackgroundImageLayout = ImageLayout.Center
        PictureBox3.Location = New Point(47, 435)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(793, 190)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' blueUp
        ' 
        blueUp.Image = My.Resources.Resources.blueUp
        blueUp.Location = New Point(785, 23)
        blueUp.Name = "blueUp"
        blueUp.Size = New Size(33, 33)
        blueUp.TabIndex = 3
        blueUp.TabStop = False
        ' 
        ' blueDown
        ' 
        blueDown.Image = My.Resources.Resources.blueDown
        blueDown.Location = New Point(785, 56)
        blueDown.Name = "blueDown"
        blueDown.Size = New Size(33, 33)
        blueDown.TabIndex = 4
        blueDown.TabStop = False
        ' 
        ' redUp
        ' 
        redUp.Image = My.Resources.Resources.redUp
        redUp.Location = New Point(785, 252)
        redUp.Name = "redUp"
        redUp.Size = New Size(33, 33)
        redUp.TabIndex = 5
        redUp.TabStop = False
        ' 
        ' redDown
        ' 
        redDown.Image = My.Resources.Resources.redDown
        redDown.Location = New Point(785, 285)
        redDown.Name = "redDown"
        redDown.Size = New Size(33, 33)
        redDown.TabIndex = 6
        redDown.TabStop = False
        ' 
        ' purpleDown
        ' 
        purpleDown.Image = My.Resources.Resources.purpleDown
        purpleDown.Location = New Point(785, 500)
        purpleDown.Name = "purpleDown"
        purpleDown.Size = New Size(33, 33)
        purpleDown.TabIndex = 8
        purpleDown.TabStop = False
        ' 
        ' purpleUp
        ' 
        purpleUp.Image = My.Resources.Resources.purpleUp
        purpleUp.Location = New Point(785, 467)
        purpleUp.Name = "purpleUp"
        purpleUp.Size = New Size(33, 33)
        purpleUp.TabIndex = 7
        purpleUp.TabStop = False
        ' 
        ' lblScheduled
        ' 
        lblScheduled.Font = New Font("Moulpali", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScheduled.ForeColor = Color.White
        lblScheduled.Location = New Point(451, 35)
        lblScheduled.Name = "lblScheduled"
        lblScheduled.Size = New Size(316, 40)
        lblScheduled.TabIndex = 12
        lblScheduled.Text = "EXTRA FREQUENT MODE (once every 10 minutes)"
        lblScheduled.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLanguage
        ' 
        lblLanguage.Font = New Font("Moulpali", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLanguage.ForeColor = Color.White
        lblLanguage.Location = New Point(451, 264)
        lblLanguage.Name = "lblLanguage"
        lblLanguage.Size = New Size(316, 36)
        lblLanguage.TabIndex = 13
        lblLanguage.Text = "ENGLISH MODE"
        lblLanguage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStartup
        ' 
        lblStartup.Font = New Font("Moulpali", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStartup.ForeColor = Color.White
        lblStartup.Location = New Point(451, 479)
        lblStartup.Name = "lblStartup"
        lblStartup.Size = New Size(316, 36)
        lblStartup.TabIndex = 14
        lblStartup.Text = "START NORMAL"
        lblStartup.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(lblStartup)
        Controls.Add(lblLanguage)
        Controls.Add(lblScheduled)
        Controls.Add(purpleDown)
        Controls.Add(purpleUp)
        Controls.Add(redDown)
        Controls.Add(redUp)
        Controls.Add(blueDown)
        Controls.Add(blueUp)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "frmSettings"
        Size = New Size(889, 683)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(blueUp, ComponentModel.ISupportInitialize).EndInit()
        CType(blueDown, ComponentModel.ISupportInitialize).EndInit()
        CType(redUp, ComponentModel.ISupportInitialize).EndInit()
        CType(redDown, ComponentModel.ISupportInitialize).EndInit()
        CType(purpleDown, ComponentModel.ISupportInitialize).EndInit()
        CType(purpleUp, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents blueUp As PictureBox
    Friend WithEvents blueDown As PictureBox
    Friend WithEvents redUp As PictureBox
    Friend WithEvents redDown As PictureBox
    Friend WithEvents purpleDown As PictureBox
    Friend WithEvents purpleUp As PictureBox
    Friend WithEvents lblScheduled As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents lblStartup As Label

End Class
