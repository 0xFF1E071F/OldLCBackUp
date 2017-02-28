Option Strict On
'Nov 1 '13
Public Class SoccerTixForm
    Const PRICE As Decimal = 3D '$3 per ticket
    Friend ticket_counter, ticket_accum As Decimal

    Private Sub calcButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton.Click

        Dim num_tkts As Decimal
        num_tkts = Decimal.Parse(numTextBox.Text)
        totalreceiptsLabel.Text = (num_tkts * PRICE).ToString("C")
        ticket_counter += num_tkts
        ticket_accum += num_tkts * PRICE

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click

        totalreceiptsLabel.Text = ""
        numTextBox.Text = ""
        numTextBox.Focus()

    End Sub

    Private Sub SummaryButton_Click(sender As System.Object, e As System.EventArgs) Handles SummaryButton.Click
        summaryForm.ShowDialog()
    End Sub
End Class
