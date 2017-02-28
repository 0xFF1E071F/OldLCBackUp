'Yu FU
'Assignment 6: 1. use constants for initiation fee = $50 and weekly fee = $20
'2. Per person cost = number of weeks * weekly fee  AND
'2. total cost = per person cost + initiation fee
'3. add try/catch block to catch data errors from the user, use messagebox to dialog about the error
'4. call the clear routing when there is an error
'5. add a counter to count the number of estimates given
'6. add an accumulator to capture the amount of potential business
'7. Program the manager's summary button to report on the number of estimates and the potential business opportunity
' 
Option Strict On

Public Class Form1

    Const WFee As Decimal = 20D
    Dim allFees As Decimal = 0
    Dim count As Decimal = 0

    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        Dim MFee As Decimal
        Dim Weeks As Decimal
        Dim TotalFee As Decimal
        Dim initFee As Decimal

        Try
            Weeks = Decimal.Parse(inweeksTextBox1.Text)
            MFee = WFee * Weeks

            If Waive_CheckBox.Checked = False Then
                initFee = 50D
            Else
                initFee = 0D
            End If

            TotalFee = MFee + initFee
            outperpersoncostTextBox4.Text = MFee.ToString("C")
            outinitiationfeeTextBox6.Text = initFee.ToString("C")
            outtotalcostTextBox5.Text = TotalFee.ToString("C")
            allFees += TotalFee
            count += 1

        Catch ex As Exception
            MessageBox.Show("Re-enter data, please.  It should be numeric",
                        "Data Error", MessageBoxButtons.OK, _
                           MessageBoxIcon.Error)
            clear(sender, e)

        End Try


    End Sub

    Private Sub clear(sender As System.Object, e As System.EventArgs) Handles clearButton.Click

        outperpersoncostTextBox4.Clear()
        outinitiationfeeTextBox6.Clear()
        outtotalcostTextBox5.Clear()
        inweeksTextBox1.Clear()
        inweeksTextBox1.Focus()
    End Sub

    Private Sub summaryButton_Click(sender As System.Object, e As System.EventArgs) Handles summaryButton.Click

        Dim Msg1 As String = "we got " & count.ToString & " times transfer,"
        Dim Msg2 As String = "and the Total fees are" & allFees.ToString("C") & "."
        MessageBox.Show(Msg1 & ControlChars.NewLine & Msg2, "Summary", _ 
						MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
