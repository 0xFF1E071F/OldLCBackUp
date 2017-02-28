Public Class Form1

    Private Sub clearButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton2.Click
        Dim feedback As DialogResult
        feedback = MessageBox.Show("If you clear, the data will be lost. Clear?", "clear/caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If feedback = Windows.Forms.DialogResult.Yes Then
            messageLabel2.Text = ""
            gradeTextBox1.Clear()
            gradeTextBox1.Focus()
        End If

    End Sub

    
    Private Sub DisplayButton1_Click(sender As System.Object, e As System.EventArgs) Handles DisplayButton1.Click
        Select Case gradeTextBox1.Text.ToUpper



            Case Is = "A"
                messageLabel2.Text = "Thanks, glad you enjoyed eating with us"
            Case Is = "B"
                messageLabel2.Text = "Thanks, please come back"
            Case Is = "F"
                messageLabel2.Text = " So sad, please stop by to chat with the chef"
            Case Else
                messageLabel2.Text = " Please use A, B or F only"
        End Select
    End Sub
End Class
