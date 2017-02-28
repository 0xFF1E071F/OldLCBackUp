Public Class TaskManager

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        'Close()
        Hide()
    End Sub

    Private Sub endtaskButton_Click(sender As System.Object, e As System.EventArgs) Handles endtaskButton.Click
        Dim index As Integer
        index = taskListBox.SelectedIndex
        If index >= 0 Then
            taskListBox.Items.RemoveAt(index)
            statusListBox.Items.RemoveAt(index)
        Else
            MessageBox.Show("Please select a task", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class