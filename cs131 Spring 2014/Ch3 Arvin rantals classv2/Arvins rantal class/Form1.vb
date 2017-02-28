' Yu Fu
'ch 3 work will include:
'1. milage charge = total milage * milage fee ($0.10)
'2. total charges = milage charge + (number of days * daily rental fee ($20))
Option Strict On

Public Class Form1

    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click

        ' convert text to number
        Dim totalmile, days, milagecharge, totalcharge As Decimal

        Try
            totalmile = Decimal.Parse(totalmiTextBox.Text)
            days = Decimal.Parse(daysTextBox.Text)
            ' get total of each
            milagecharge = totalmile / 10
            totalcharge = milagecharge + days * 20
            ' output to label ( in unit of $ )
            outmilagechargeslabel.Text = milagecharge.ToString("C")
            totalchargesLabel.Text = totalcharge.ToString("C")

        Catch ex As Exception
            MessageBox.Show("Check your data, please. It should be numeric",
                            "Data Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            'call clear unstead this get rid of redurdent code
            Call clear(sender, e)
        End Try

    End Sub

    Private Sub clear(sender As System.Object, e As System.EventArgs) Handles clearButton.Click

        'clear all things
        totalmiTextBox.Clear()
        daysTextBox.Clear()
        outmilagechargeslabel.Text = ""
        totalchargesLabel.Text = ""

    End Sub
End Class
