
'Name etc here
'Instructions:  1. songs cost $1 for 0 to 5; $0.50 for 6 - 10; $0.333 for more than 10
'               2. Add try/catch block with messagebox for error dialog
'               3. Add a counter for number of transactions (each time the calculate button is clicked)
'               4. Add an accumulator for the total sales for the day 
'               5. Add a Manager's Summary Button.  When clicked this gives a report of transactions and sales in a message box.
Option Strict On


Public Class Form1
    Const deep_disc As Decimal = CDec(0.333)
    Const deep As Decimal = CDec(0.5)
    Const standard As Decimal = 1
    Dim counter As Integer
    Dim accumulator As Decimal

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculate_Button1.Click
        Dim num_songs, total As Decimal

        Try
            num_songs = Decimal.Parse(Song_TextBox.Text)
            If num_songs > 10 Then
                total = num_songs * deep_disc
            Else
                If num_songs >= 6 Then
                    total = num_songs * deep
                Else
                    total = num_songs * standard
                End If
            End If
            counter = counter + 1
            accumulator += total
            totalLabel.Text = total.ToString("C")
        Catch ex As Exception
            MessageBox.Show("You shoule type in correct decimal number for numbers of songs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call clear(sender, e)
        End Try

        Try
            Select Case num_songs
                Case 0 To 5
                    totalLabel.Text = (num_songs * standard).ToString("C")
                Case 6, 7, 9, 10
                    totalLabel.Text = (num_songs * deep).ToString("C")
                Case Is > 10
                    totalLabel.Text = (num_songs * deep_disc).ToString("C")
                Case Else
                    totalLabel.Text = "Congratiulation, this purchase is"
            End Select
        Catch ex As Exception
            MessageBox.Show("You shoule type in correct decimal number for numbers of songs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call clear(sender, e)
        End Try
    End Sub
    Private Sub clear(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button3.Click
        Song_TextBox.Clear()

        totalLabel.Text = ""
        Song_TextBox.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button2.Click
        Close()
    End Sub

    Private Sub summary_button2_Click(sender As System.Object, e As System.EventArgs) Handles summary_button2.Click
        Dim MSG1 As String = "The total number of transaction is " & counter.ToString
        Dim MSG2 As String = "Total sales is " & accumulator.ToString("C")
        MessageBox.Show(MSG1 & ControlChars.NewLine & MSG2, "Manager's report", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
