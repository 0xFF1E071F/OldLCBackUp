Public Class loginForm

    Private Sub closebutton_Click(sender As System.Object, e As System.EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles login_Button.Click
        If usernameTextBox.Text.ToLower = "admin" Then
            If passwordTextBox.Text.ToLower = "admin" Then
                siteForm.Button1.Enabled = False
                purchaseForm1.Show()
                Me.Close()
            Else
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please input correct username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class