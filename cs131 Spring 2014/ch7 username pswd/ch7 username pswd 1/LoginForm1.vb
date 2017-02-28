Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim match As Boolean = False
        Dim i As Integer
        For i = 0 To listForm1.User_ListBox1.Items.Count - 1
            If UsernameTextBox.Text = listForm1.User_ListBox1.Items(i) Then
                match = True
                Exit For
            End If
        Next

        If match = True Then
            If PasswordTextBox.Text.ToUpper = listForm1.Password_ListBox2.Items(i) Then
                website.Show()
            End If
        Else
            Dim feedback As DialogResult
            feedback = MessageBox.Show("Username is not correct , do you want register", "Username error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            If feedback = Windows.Forms.DialogResult.OK Then
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                Registration.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

    End Sub

End Class
