'name here
Option Strict On
Public Class Purchase_form

    Const weekly_fee As Decimal = 20D
    Dim accumulator As Decimal

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim weeks As Integer
        Dim total As Decimal

        'calculate
        weeks = Integer.Parse(inweeksTextBox1.Text)
        total = (weeks * weekly_fee)

        'output
        outtotalcostTextBox5.Text = total.ToString("C")

        'add accumulator
        accumulator += total


    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        inweeksTextBox1.Clear()
        inweeksTextBox1.Focus()
        outtotalcostTextBox5.Clear()


    End Sub

    
End Class
