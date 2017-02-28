'Yu Fu
'Nested If Statements
Option Strict On
Public Class Form1
   
    Private Sub enterButton_Click(sender As System.Object, e As System.EventArgs) Handles enterButton.Click
        If experienceCheckBox.Checked = True Then
            Dim years As Decimal
            years = Decimal.Parse(yearsTextBox.Text)
            If years >= 50 Then
                MessageBox.Show("Hi, please us a call to follow up", "good news", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Sorry the position of years ", "good news", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Sorry the position of years ", "good news", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
