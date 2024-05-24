<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlEventLog
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
        btnClear = New PictureBox()
        eventLog = New ListBox()
        Panel1.SuspendLayout()
        CType(btnClear, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.Event_log1
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(eventLog)
        Panel1.Location = New Point(21, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 608)
        Panel1.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.Image = My.Resources.Resources.clearBtn
        btnClear.Location = New Point(709, 66)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(81, 44)
        btnClear.TabIndex = 2
        btnClear.TabStop = False
        ' 
        ' eventLog
        ' 
        eventLog.BackColor = Color.FromArgb(CByte(40), CByte(35), CByte(70))
        eventLog.BorderStyle = BorderStyle.None
        eventLog.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventLog.ForeColor = Color.White
        eventLog.FormattingEnabled = True
        eventLog.HorizontalScrollbar = True
        eventLog.ItemHeight = 20
        eventLog.Location = New Point(57, 119)
        eventLog.Name = "eventLog"
        eventLog.RightToLeft = RightToLeft.No
        eventLog.Size = New Size(726, 420)
        eventLog.TabIndex = 1
        ' 
        ' ctlEventLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.backGround
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "ctlEventLog"
        Size = New Size(889, 683)
        Panel1.ResumeLayout(False)
        CType(btnClear, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents eventLog As ListBox
    Friend WithEvents btnClear As PictureBox

End Class
