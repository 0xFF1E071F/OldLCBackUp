Public Class summaryForm

    Private Sub summaryForm_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        total_ticket_Label3.Text = SoccerTixForm.ticket_counter.ToString()
        total_sale_Label.Text = SoccerTixForm.ticket_accum.ToString("C")
    End Sub
End Class