Public Class Form1

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exit_botton_Click(sender As System.Object, e As System.EventArgs) Handles exit_botton.Click
        Close()
    End Sub

    Private Sub shop_botton_Click(sender As System.Object, e As System.EventArgs) Handles shop_botton.Click
        output.Text = "Hello " & name_TextBox.Text & ", enjoy shopping."
    End Sub

    Private Sub Shirt1_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Shirt1_RadioButton.CheckedChanged
        output_PictureBox.Image = My.Resources.shirt
    End Sub

    Private Sub Shirt2_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Shirt2_RadioButton.CheckedChanged
        output_PictureBox.Image = My.Resources.t1
    End Sub

    Private Sub Shirt3_RadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Shirt3_RadioButton.CheckedChanged
        output_PictureBox.Image = My.Resources.t2
    End Sub
End Class
