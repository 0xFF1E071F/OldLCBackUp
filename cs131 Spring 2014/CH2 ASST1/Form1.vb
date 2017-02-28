'Yu Fu
Public Class Form1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Show_botton_Click(sender As System.Object, e As System.EventArgs) Handles Show_botton.Click
        output_label.Text = input_TextBox.Text
        input_TextBox.Clear() 'clear the text from input
    End Sub

    Private Sub exit_Button_Click(sender As System.Object, e As System.EventArgs) Handles exit_Button.Click
        Close() 'Close is a method
    End Sub

    Private Sub Visiable_checkbox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Visiable_checkbox.CheckedChanged
        output_label.Visible = Visiable_checkbox.Checked
    End Sub

    Private Sub RED_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RED.CheckedChanged
        output_label.ForeColor = Color.Red
    End Sub

    Private Sub BLUE_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BLUE.CheckedChanged
        output_label.ForeColor = Color.Blue
    End Sub

    Private Sub Log_botton_Click(sender As System.Object, e As System.EventArgs) Handles Log_botton.Click
        log_GroupBox.Visible = False
        Color_Group_Box.Enabled = True
        Color_Group_Box.Enabled = True
        input_TextBox.Enabled = True
        Show_botton.Enabled = True
    End Sub
End Class
