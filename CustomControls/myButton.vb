Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class myButton
    Inherits Button

    Dim myCol As myColors = New myColors

    Private topCol As Color = myCol.topColor
    Private botCol As Color = myCol.panelColor

    Public Property TopColor As Color
        Get
            Return topCol
        End Get
        Set(value As Color)
            topCol = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BotColor As Color
        Get
            Return botCol
        End Get
        Set(value As Color)
            botCol = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Using lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, topCol, botCol, 90.0F)
            Using textBrush As SolidBrush = New SolidBrush(Me.ForeColor)
                Using format As StringFormat = New StringFormat()
                    format.Alignment = GetHorizontalAlignment()
                    format.LineAlignment = GetVerticalAlignment()
                    e.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                    e.Graphics.DrawString(Me.Text, Me.Font, textBrush, Me.ClientRectangle, format)

                End Using
            End Using
        End Using
    End Sub

    Private Function GetVerticalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) / 4, StringAlignment)
    End Function

    Private Function GetHorizontalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) Mod 4, StringAlignment)
    End Function

End Class
