Public Class result_Form2

    Private Sub showresultButton1_Click(sender As System.Object, e As System.EventArgs) Handles showresultButton1.Click
        totalTextBox3.Text = vote.total.ToString
        floridaTextBox1.Text = (vote.florida_votes / vote.total).ToString("p0")
        uconnTextBox2.Text = (vote.uconn_votes / vote.total).ToString("p0")
    End Sub
End Class