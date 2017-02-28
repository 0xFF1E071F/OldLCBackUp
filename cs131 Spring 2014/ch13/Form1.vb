Public Class Form1

    Private Sub PictureBox1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Dim gr As Graphics = e.Graphics
        Dim red_pen As New Pen(Color.Red)
        Dim blue_pen As New Pen(Color.Blue)
        Dim green_brush As New SolidBrush(Color.GreenYellow)
        gr.DrawLine(red_pen, 0, 0, 300, 300)
        gr.DrawLine(blue_pen, 0, 300, 300, 0)
    End Sub

    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim gr As Graphics = e.Graphics
        Dim green_brush As New SolidBrush(Color.GreenYellow)
        gr.FillRectangle(green_brush, 10, 10, 200, 200)
        gr.FillEllipse(Brushes.Green, 10, 10, 200, 200)
    End Sub
End Class
