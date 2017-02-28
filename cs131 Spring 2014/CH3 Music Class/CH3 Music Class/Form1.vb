
'Yu Fu
'Instructions:  1. change the song price and cd price to constants
'               2. Add try/catch block with messagebox for error dialog
'               3. Add a counter for number of transactions (each time the calculate button is clicked)
'               4. Add an accumulator for the total sales for the day 
'               5. Add a Manager's Summary Button.  When clicked this gives a report of transactions and sales in a message box.
Option Strict On

Public Class Form1
    Dim counter, accum As Decimal

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate_Button1.Click
        Dim song_num, cd_num, total As Decimal

        Try
            song_num = Decimal.Parse(Song_TextBox.Text)
            cd_num = Decimal.Parse(CDTextBox.Text)
            counter += 1
            total = (song_num * 0.6D) + (cd_num * 6D)
            accum += total
            totalLabel.Text = total.ToString("C")
        Catch clearButton_Click As Exception
            MessageBox.Show("Please re-enter input.  It must be numeric", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call ex(sender, e)
        End Try

    End Sub

    Private Sub ex(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button3.Click
        Song_TextBox.Clear()
        CDTextBox.Clear()
        totalLabel.Text = ""
        Song_TextBox.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button2.Click
        Close()
    End Sub

    Private Sub Summary_Click(sender As System.Object, e As System.EventArgs) Handles Summary.Click
        Dim MSG1 As String = "The total transactions is " & counter
        Dim MSG2 As String = "Total sales is " & accum.ToString("C")
        MessageBox.Show(MSG1 & ControlChars.NewLine & MSG2, "Manager report", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
