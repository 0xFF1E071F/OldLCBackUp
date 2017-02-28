Option Strict On

Public Class Form1

    Const cost As Decimal = 100
    Dim counter As Integer
    Dim accumulator As Decimal


   
    Private Sub calcButton1_Click(sender As System.Object, e As System.EventArgs) Handles calcButton1.Click

        Dim quanlity, total As Decimal

        Try
            quanlity = Decimal.Parse(quantityTextBox1.Text)
            total = quanlity * cost
            totalLabel11.Text = total.ToString
            counter = counter + 1
            Label3.Text = counter.ToString

            accumulator = accumulator + total
            Label4.Text = accumulator.ToString
        Catch ex As Exception
            MessageBox.Show("Data should be numeric", _
                            "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call clear(sender, e)
        End Try

      

    End Sub

    Private Sub clear(sender As System.Object, e As System.EventArgs) Handles clearButton2.Click
        quantityTextBox1.Clear()
        quantityTextBox1.Focus()
        totalLabel11.Text = ""

    End Sub

    Private Sub summarybutton_Click(sender As System.Object, e As System.EventArgs) Handles summarybutton.Click
        Dim MSG1 As String = "The total number of transaction is " & counter.ToString
        Dim MSG2 As String = "Total sales is " & accumulator.ToString("C")
        MessageBox.Show(MSG1 & ControlChars.NewLine & MSG2, "Manager's report", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        'MessageBox.Show("Total number of transaction is " & counter.ToString & "and the total sales is " & accumulator.ToString("C"), "Managers report", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
