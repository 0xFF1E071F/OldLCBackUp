Public Class Form1

    Private Sub addButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton1.Click
        'add a weather feature and date from the textboxes. 
        'Clear the textboxes
        weather_ListBox1.Items.Add(weather_content_TextBox1.Text)
        Date_ListBox1.Items.Add(date_content_TextBox1.Text)
        weather_content_TextBox1.Clear()
        date_content_TextBox1.Clear()

    End Sub

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        ' remove the weather item selected by the user and
        'remove the associated date from the date listbox
        Dim index As Integer
        index = weather_ListBox1.SelectedIndex
        weather_ListBox1.Items.Remove(weather_ListBox1.SelectedItem)
        Date_ListBox1.Items.RemoveAt(index)

    End Sub

    Private Sub insertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertButton.Click
        'insert the weather item and date item from the textboxes 
        'at the location in location textbox
        'then clear the textboxes

        'Check to see that the location is within range
        If location_TextBox.Text <= weather_ListBox1.Items.Count Then
            weather_ListBox1.Items.Insert(location_TextBox.Text, weather_content_TextBox1.Text)
            Date_ListBox1.Items.Insert(location_TextBox.Text, date_content_TextBox1.Text)
            location_TextBox.Clear()
            weather_content_TextBox1.Clear()
            date_content_TextBox1.Clear()
        Else
            MessageBox.Show("Please type in correct index number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub removeat_Button1_Click(sender As System.Object, e As System.EventArgs) Handles removeat_Button1.Click
        If location_TextBox.Text <= weather_ListBox1.Items.Count Then
            weather_ListBox1.Items.RemoveAt(location_TextBox.Text)
            Date_ListBox1.Items.RemoveAt(location_TextBox.Text)
            location_TextBox.Clear()
            weather_content_TextBox1.Clear()
            date_content_TextBox1.Clear()
        Else
            MessageBox.Show("Please type in correct index number", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
