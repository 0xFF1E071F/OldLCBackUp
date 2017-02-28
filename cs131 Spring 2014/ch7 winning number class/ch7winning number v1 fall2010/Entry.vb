Public Class Entry

    Private Sub enterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click
        Dim n As Integer
        n = 0
        Do Until n = WinningNumbersForm.ListBox1.Items.Count
            If inTextBox.Text = WinningNumbersForm.ListBox1.Items(n) Then
                outLabel.Text = "Congratulation"
                n = WinningNumbersForm.ListBox1.Items.Count
            Else
                n += 1
                outLabel.Text = "Sorry"
            End If
        Loop
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ADMINToolStripMenuItem.Click
        WinningNumbersForm.Show()
    End Sub
End Class
