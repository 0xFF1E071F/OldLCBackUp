Public Class Registration

   
    Private Sub registerButton1_Click(sender As System.Object, e As System.EventArgs) Handles registerButton1.Click
        listForm1.User_ListBox1.Items.Add(usernameTextBox1.Text.ToUpper)
        listForm1.Password_ListBox2.Items.Add(passwordTextBox2.Text.ToUpper)
        listForm1.ShowDialog()
    End Sub
End Class