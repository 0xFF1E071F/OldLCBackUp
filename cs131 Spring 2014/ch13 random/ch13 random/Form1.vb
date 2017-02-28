Public Class Form1

    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim gr As Graphics = e.Graphics

        Dim p1 As New Pen(Color.White)
        Dim b1 As New SolidBrush(Color.White)

        With gr
            .FillEllipse(b1, 220, 200, 60, 60)
            .FillEllipse(b1, 210, 260, 80, 80)
            .FillEllipse(b1, 200, 340, 100, 100)
        End With
        'snow
        Dim x_loc, y_loc As Integer
        Dim rnd_num As Random = New Random(DateTime.Now.Millisecond)
        For i = 1 To 1000
            x_loc = rnd_num.Next(1, 500)
            y_loc = rnd_num.Next(1, 500)
            gr.DrawLine(p1, x_loc, y_loc, x_loc + 1, y_loc + 1)
        Next
    End Sub
End Class
