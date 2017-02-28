Public Class StartMenu

    
    Private Sub startButton_Click(sender As System.Object, e As System.EventArgs) Handles startButton.Click
        If startmenuListBox.SelectedIndex = 3 Then
            TaskManager.taskListBox.Items.Add(startmenuListBox.SelectedItem)
            TaskManager.statusListBox.Items.Add("Not responding")
        Else
            TaskManager.taskListBox.Items.Add(startmenuListBox.SelectedItem)
            TaskManager.statusListBox.Items.Add("Running")
        End If
        TaskManager.Show()
    End Sub
End Class
