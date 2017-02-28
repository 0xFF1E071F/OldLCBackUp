' Yu Fu
' ASST 3
Public Class Form1

    Private Sub lightoffPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles lightoffPictureBox.Click
        lightonPictureBox.Visible = True
        lightoffPictureBox.Visible = False
        out_Label.Text = "Turn light off, " & name_TextBox.Text
    End Sub

    Private Sub lightonPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles lightonPictureBox.Click
        lightoffPictureBox.Visible = True
        lightonPictureBox.Visible = False
        out_Label.Text = "Turn light on, " & name_TextBox.Text
    End Sub

    Private Sub exit_Button_Click(sender As System.Object, e As System.EventArgs) Handles exit_Button.Click
        Close()
    End Sub

    Private Sub print_Button_Click_1(sender As System.Object, e As System.EventArgs) Handles print_Button.Click
        out_Label.Visible = True
        out_Label.Text = "Turn light off, " & name_TextBox.Text
        lightonPictureBox.Visible = True
        ColorGroupBox.Enabled = True
        print_Button.Enabled = False
        name_TextBox.Enabled = False
    End Sub

    Private Sub blackRadioButton_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles blackRadioButton.CheckedChanged
        out_Label.ForeColor = Color.Black
    End Sub

    Private Sub blueRadioButton_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles blueRadioButton.CheckedChanged
        out_Label.ForeColor = Color.Blue
    End Sub

    Private Sub redRadioButton_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles redRadioButton.CheckedChanged
        out_Label.ForeColor = Color.Red
    End Sub

    Private Sub greenRadioButton_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles greenRadioButton.CheckedChanged
        out_Label.ForeColor = Color.Green
    End Sub

    Private Sub ToolTip1_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class

