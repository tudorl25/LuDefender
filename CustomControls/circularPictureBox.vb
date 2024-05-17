Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class circularPictureBox
    Inherits PictureBox

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim grpath As GraphicsPath = New GraphicsPath()
        grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grpath)
        MyBase.OnPaint(pe)
    End Sub

End Class
