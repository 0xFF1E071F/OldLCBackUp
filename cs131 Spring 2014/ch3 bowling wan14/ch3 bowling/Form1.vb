'Yu FU
'cl 2-const and format specifier codes
'cl 3-try/catch, messagebox, call clear
'cl 4-count & accum & Summary
Public Class Form1
    Const scost As Decimal = 4D
    Const gcost As Decimal = 6D
    Dim ctr, accum As Decimal

    Private Sub calcButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calcButton1.Click
        Dim nums, numg, final_total As Decimal

        Try
            nums = Decimal.Parse(shoerentalTextBox1.Text)
            numg = Decimal.Parse(gamesTextBox2.Text)
            final_total = (nums * scost) + (numg * gcost)
            total_cost_Label4.Text = final_total.ToString("C")
            ctr += 1
            accum = accum + final_total

        Catch ex As Exception
            MessageBox.Show("Re-enter data, please.  It should be numeric",
                         "Data Error", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            'call Clear instead, this gets rid of redundent code
            Call Clear(sender, e)
        End Try



       
    End Sub

    Private Sub Clear(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton2.Click

        shoerentalTextBox1.Clear()
        gamesTextBox2.Clear()
        total_cost_Label4.Text = ""
        shoerentalTextBox1.Focus()
        'control report - # charged and # cleared

    End Sub

    Private Sub summary_Button1_Click(sender As System.Object, e As System.EventArgs) Handles summary_Button1.Click
        Dim MSG1 As String = "The total number of transactions is " & ctr.ToString
        Dim MSG2 As String = "Total sales is " & accum.ToString("C")
        MessageBox.Show(MSG1 & ControlChars.NewLine & MSG2, _
                        "manager's report", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        'MessageBox.Show("The total number of transactions is " & ctr.ToString & " and the total sales is " & accum.ToString("C"), "Managers report", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
