'Yu Fu
'This program requires a nested if construction
'The user needs to be a premium member (check box) and have a member number > 2000.
'Use Case structure to calculate the price for the songs - constants are below
'Use a dialog result variable to be sure the user wants to use the clear routine.

Option Strict On
Public Class Form1


    Const song_price As Decimal = 1D            '0 to 5 songs
    Const disc_song_price As Decimal = 0.5D    '6 - 10 songs
    Const deep_disc_song As Decimal = 0.333D      'more than 10 songs
    Dim counter As Integer          'counts for summary
    Dim accumulator As Decimal
    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        Dim feedback As DialogResult
        feedback = MessageBox.Show("If you clear, the data will be lost. Clear?", "clear/caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If feedback = Windows.Forms.DialogResult.Yes Then
            SONGTextBox.Clear()
            OutputLabel.Text = ""
            SONGTextBox.Focus()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

   
    Private Sub calculateButton_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton.Click
        Dim num_songs As Decimal
        Dim totalPrice As Decimal

            Try
                num_songs = Decimal.Parse(SONGTextBox.Text)
                Select Case num_songs
                    Case Is <= 0
                        OutputLabel.Text = "The number of songs should upper than 0"
                    Case Is <= 5
                        totalPrice = song_price * num_songs
                        OutputLabel.Text = totalPrice.ToString("C")
                    Case Is <= 10
                        totalPrice = disc_song_price * num_songs
                        OutputLabel.Text = totalPrice.ToString("C")
                    Case Is > 10
                        totalPrice = deep_disc_song * num_songs
                        OutputLabel.Text = totalPrice.ToString("C")
                    Case Else
                        OutputLabel.Text = "Please type in correct decimal number"
                End Select
                counter += 1
                accumulator += totalPrice
            Catch ex As Exception
                MessageBox.Show("Data should be numeric", _
                                "Error", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            SONGTextBox.Clear()
            OutputLabel.Text = ""
            SONGTextBox.Focus()
            End Try
    End Sub

    Private Sub summaryButton2_Click(sender As System.Object, e As System.EventArgs) Handles summaryButton2.Click
        Dim MSG1 As String = "The total number of transaction is " & counter.ToString
        Dim MSG2 As String = "Total sales is " & accumulator.ToString("C")
        MessageBox.Show(MSG1 & ControlChars.NewLine & MSG2, "Summary report", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub qualifyButton3_Click(sender As System.Object, e As System.EventArgs) Handles qualifyButton3.Click
        If premium_member_CheckBox1.Checked = True Then
            Try
                If Decimal.Parse(member_code_TextBox1.Text) > 2000 Then
                    MessageBox.Show("You have the qualify.", "Report", _
                               MessageBoxButtons.OK, MessageBoxIcon.None)
                    calculateButton.Enabled = True
                    clearButton.Enabled = True
                    summaryButton2.Enabled = True
                    SONGTextBox.Focus()
                    premium_member_CheckBox1.Enabled = False
                    member_code_TextBox1.Enabled = False
                    Else
                        MessageBox.Show("You need a correct member code.", "Report", _
                                   MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            Catch ex As Exception
                MessageBox.Show("Member code should be numeric", _
                              "Error", _
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                member_code_TextBox1.Text = ""
                member_code_TextBox1.Focus()
            End Try
        Else
            MessageBox.Show("You must be the premium meber.", "Errot", _
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class