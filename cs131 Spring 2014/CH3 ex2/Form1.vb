' Yu Fu
Option Strict On

Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Loan_TextBox.Text = ""
        interestrate_TextBox.Text = ""
        interest_Label.Text = ""
        payback_Label.Text = ""

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim loan, rate, total_interest, Total_payment As Decimal
        loan = Decimal.Parse(Loan_TextBox.Text)
        rate = Decimal.Parse(interestrate_TextBox.Text)

        total_interest = loan * rate
        Total_payment = total_interest + loan

        interest_Label.Text = total_interest.ToString("C")
        payback_Label.Text = Total_payment.ToString("C")

    End Sub
End Class
