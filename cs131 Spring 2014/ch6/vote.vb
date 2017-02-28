Public Class vote
    Friend total, uconn_votes, florida_votes As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles resultButton.Click

        'result_Form2.totalTextBox3.Text = total.ToString
        ' result_Form2.floridaTextBox1.Text = (florida_votes / total).ToString("p0")
        ' result_Form2.uconnTextBox2.Text = (uconn_votes / total).ToString("p0")
        result_Form2.ShowDialog()
    End Sub

    Private Sub floridaradiobutton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles floridaradiobutton.MouseClick
        total += 1
        florida_votes += 1
    End Sub

    Private Sub uconnraidobutton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles uconnraidobutton.MouseClick
        total += 1
        uconn_votes += 1
    End Sub
End Class
