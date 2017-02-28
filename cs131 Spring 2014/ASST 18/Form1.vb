Public Class Form1
    Private Sub Form1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim gr As Graphics = e.Graphics
        Dim green_brush As New SolidBrush(Color.Green)
        'earth
        gr.DrawLine(Pens.Black, 0, 400, 500, 400)
        gr.FillRectangle(green_brush, 0, 400, 500, 500)
        'sky
        gr.FillRectangle(Brushes.SkyBlue, 0, 0, 500, 200)

        'house
        'layout
        gr.DrawRectangle(Pens.Black, 100, 300, 200, 100)
        gr.DrawLine(Pens.Black, 100, 300, 200, 200)
        gr.DrawLine(Pens.Black, 300, 300, 200, 200)
        'door
        gr.DrawRectangle(Pens.Black, 210, 350, 30, 50)
        'window
        gr.DrawRectangle(Pens.Black, 130, 320, 40, 40)
        gr.DrawLine(Pens.Black, 130, 340, 170, 340)
        gr.DrawLine(Pens.Black, 150, 320, 150, 360)

        'sun
        gr.FillEllipse(Brushes.Red, 380, 50, 50, 50)

        gr.DrawLine(Pens.Yellow, 405, 110, 405, 140)
        gr.DrawLine(Pens.Yellow, 435, 75, 465, 75)
        gr.DrawLine(Pens.Yellow, 430, 100, 445, 117)
        gr.DrawLine(Pens.Yellow, 430, 60, 445, 40)

        gr.DrawLine(Pens.Yellow, 405, 40, 405, 20)
        gr.DrawLine(Pens.Yellow, 375, 75, 345, 75)
        gr.DrawLine(Pens.Yellow, 380, 100, 370, 117)
        gr.DrawLine(Pens.Yellow, 380, 60, 370, 40)


    End Sub
End Class
