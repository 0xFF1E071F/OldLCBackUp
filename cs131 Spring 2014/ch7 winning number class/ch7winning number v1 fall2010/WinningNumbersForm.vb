Public Class WinningNumbersForm

    Private Sub addButton1_Click(sender As System.Object, e As System.EventArgs) Handles addButton1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub removeButton2_Click(sender As System.Object, e As System.EventArgs) Handles removeButton2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class