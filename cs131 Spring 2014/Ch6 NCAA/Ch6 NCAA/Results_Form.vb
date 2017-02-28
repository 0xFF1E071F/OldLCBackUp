Public Class Results_Form

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Total_TextBox3.Text = Voting_Form.total
        Florida_TextBox1.Text = (Voting_Form.Florida_votes / Voting_Form.total).ToString("p0")
        UConn_TextBox2.Text = (Voting_Form.Uconn_votes / Voting_Form.total).ToString("p0")
    End Sub

    Private Sub PictureBox3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox3.Paint
        Dim gr As Graphics = e.Graphics
        Dim red_pen As New Pen(Color.Red)
        gr.DrawLine(red_pen, 0, 0, Voting_Form.loc_fl, 0)
    End Sub

    Private Sub PictureBox4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PictureBox4.Paint
        Dim gr As Graphics = e.Graphics
        Dim green_pen As New Pen(Color.Green)
        gr.DrawLine(green_pen, 0, 0, Voting_Form.loc_ct, 0)
    End Sub
End Class