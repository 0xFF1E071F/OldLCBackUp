Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles exit_Button.Click
        Close()
    End Sub

    Private Sub Image_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Image_CheckBox.CheckedChanged
        PictureBox.Visible = Image_CheckBox.Checked
    End Sub

    Private Sub Book_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Book_RadioButton.CheckedChanged
        PictureBox.Image = My.Resources.book
        info_label.Text = "books are cheaper"
    End Sub

    Private Sub Signin_Button_Click(sender As System.Object, e As System.EventArgs) Handles Signin_Button.Click
        department_GroupBox.Enabled = True
        CheckIN_GroupBox.Visible = False
        Image_CheckBox.Enabled = True
        Image_CheckBox.Checked = True
        output_label.Text = "Welcome back, " & Name_TextBox.Text & " ID: " & Id_TextBox.Text & "."
        Signin_Button.Enabled = False
        info_label.Visible = True
        info_label.Enabled = True

    End Sub

    Private Sub Music_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Music_RadioButton.CheckedChanged
        PictureBox.Image = My.Resources.music
        info_label.Text = "Music has good"
    End Sub

    Private Sub Periogicals_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Periogicals_RadioButton.CheckedChanged
        PictureBox.Image = My.Resources.Periodicals
        info_label.Text = "Periodicals"
    End Sub

    Private Sub coffee_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles coffee_RadioButton.CheckedChanged
        PictureBox.Image = My.Resources.coffeebar
        info_label.Text = "coffeebar"
    End Sub
End Class
