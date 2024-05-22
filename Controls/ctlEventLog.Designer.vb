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
        detectedThreats = New ListBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.eventLogWallp1
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(detectedThreats)
        Panel1.Location = New Point(21, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(827, 596)
        Panel1.TabIndex = 1
        ' 
        ' detectedThreats
        ' 
        detectedThreats.BackColor = Color.FromArgb(CByte(40), CByte(35), CByte(70))
        detectedThreats.BorderStyle = BorderStyle.None
        detectedThreats.Font = New Font("Moulpali", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        detectedThreats.ForeColor = Color.White
        detectedThreats.FormattingEnabled = True
        detectedThreats.ItemHeight = 46
        detectedThreats.Location = New Point(56, 118)
        detectedThreats.Name = "detectedThreats"
        detectedThreats.RightToLeft = RightToLeft.No
        detectedThreats.Size = New Size(726, 414)
        detectedThreats.TabIndex = 1
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents detectedThreats As ListBox

End Class
