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
        scheduledScanning = New DomainUpDown()
        Panel1 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        ListView1 = New ListView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' scheduledScanning
        ' 
        scheduledScanning.BackColor = Color.CornflowerBlue
        scheduledScanning.BorderStyle = BorderStyle.FixedSingle
        scheduledScanning.Font = New Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        scheduledScanning.ForeColor = Color.Snow
        scheduledScanning.Items.Add("Extra frequent scanning (once every 5 minutes)")
        scheduledScanning.Items.Add("Frequent scanning (once every 10 minutes)")
        scheduledScanning.Items.Add("Normal scanning (once every 30 minutes)")
        scheduledScanning.Items.Add("Seldom scanning (once every 2 hour)")
        scheduledScanning.Items.Add("Extra seldom scanning (once a day)")
        scheduledScanning.Items.Add("OFF")
        scheduledScanning.Location = New Point(405, 91)
        scheduledScanning.Name = "scheduledScanning"
        scheduledScanning.ReadOnly = True
        scheduledScanning.Size = New Size(600, 31)
        scheduledScanning.TabIndex = 3
        scheduledScanning.Text = "Normal scanning (once every 30 minutes)"
        scheduledScanning.TextAlign = HorizontalAlignment.Center
        scheduledScanning.Wrap = True
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(scheduledScanning)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1026, 606)
        Panel1.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Gill Sans Ultra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(584, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(421, 26)
        Label6.TabIndex = 8
        Label6.Text = "Change how often we do these scans"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Gill Sans Ultra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(13, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(258, 29)
        Label5.TabIndex = 7
        Label5.Text = "Scheduled scanning"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(13, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(369, 23)
        Label4.TabIndex = 6
        Label4.Text = "to be assured of your devices safety"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(13, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(376, 23)
        Label3.TabIndex = 5
        Label3.Text = "background check-up scans in order"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(13, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 23)
        Label2.TabIndex = 4
        Label2.Text = "luDefender is designed to do regular"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 179)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1024, 425)
        Panel2.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(58), CByte(67), CByte(95))
        Panel3.Controls.Add(ListView1)
        Panel3.Location = New Point(384, 19)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(620, 380)
        Panel3.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.Snow
        ListView1.Location = New Point(18, 14)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(584, 350)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ctlScanning
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        Controls.Add(Panel1)
        Name = "ctlScanning"
        Size = New Size(1026, 606)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents scheduledScanning As DomainUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListView1 As ListView

End Class
