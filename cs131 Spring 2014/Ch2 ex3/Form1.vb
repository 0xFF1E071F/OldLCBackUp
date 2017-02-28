Public Class Form1

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub find_botton_Click(sender As System.Object, e As System.EventArgs) Handles find_botton.Click
        PictureBox1.Visible = True
    End Sub

    Private Sub us_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles us_RadioButton.CheckedChanged
        PictureBox1.Image = My.Resources.us
        output_label.Text = "United States"
    End Sub

    Private Sub Japan_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Japan_RadioButton.CheckedChanged
        PictureBox1.Image = My.Resources.japan
        output_label.Text = "Japan"
    End Sub

    Private Sub canda_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles canda_RadioButton.CheckedChanged
        PictureBox1.Image = My.Resources.canda
        output_label.Text = "Canda"
    End Sub

    Private Sub British_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles British_RadioButton.CheckedChanged
        PictureBox1.Image = My.Resources.uk
        output_label.Text = "British"
    End Sub

    Private Sub title_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs)
        Title.Visible = TitleCheckBox.Checked

    End Sub

    Private Sub name_CheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs)

        output_label.Visible = CountryCheckBox.Checked
    End Sub

    Private Sub programmer_checkbox_CheckedChanged(sender As System.Object, e As System.EventArgs)

        programmer_label.Text = "Yu Fu" = ProgrammerCheckBox.Checked

    End Sub

    Private Sub exit_botton_Click(sender As System.Object, e As System.EventArgs) Handles exit_botton.Click
        Close()
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TitleCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TitleCheckBox.CheckedChanged
        Title.Enabled = TitleCheckBox.Checked = True
    End Sub
End Class
