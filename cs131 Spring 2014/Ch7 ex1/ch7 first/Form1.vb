Public Class Form1

    Private Sub Add_Button1_Click(sender As System.Object, e As System.EventArgs) Handles Add_Button1.Click
        'States_ListBox1.Items.Add("South Carolina")
        'States_ListBox1.Items.Add(Content_TextBox1.Text)

        Color_comboBox1.Items.Add(Content_TextBox1.Text)

        Content_TextBox1.Clear()
    End Sub

    Private Sub Remove_Button1_Click(sender As System.Object, e As System.EventArgs) Handles Remove_Button1.Click
        'States_ListBox1.Items.Remove(Content_TextBox1.Text)
        If location_TextBox1.Text <= States_ListBox1.Items.Count - 1 Then
            States_ListBox1.Items.RemoveAt(location_TextBox1.Text)
        Else
            MessageBox.Show("Check location", "Index error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub insert_Button1_Click(sender As System.Object, e As System.EventArgs) Handles insert_Button1.Click
        If location_TextBox1.Text <= Color_comboBox1.Items.Count Then
            Color_comboBox1.Items.Insert(location_TextBox1.Text, Content_TextBox1.Text)
        Else
            Content_TextBox1.Text = "Check Location"
        End If
    End Sub

    Private Sub remove_both_Button1_Click(sender As System.Object, e As System.EventArgs) Handles remove_both_Button1.Click
        'Content_TextBox1.Text = States_ListBox1.SelectedItem.ToString
        'location_TextBox1.Text = States_ListBox1.SelectedIndex.ToString

        'like removing both username and password

        States_ListBox1.Items.Remove(States_ListBox1.SelectedItem.ToString)
        Color_comboBox1.Items.RemoveAt(States_ListBox1.SelectedIndex)
    End Sub
End Class
