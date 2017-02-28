'Yu Fu
'ASST 2 Change Colors

Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles visiable_color_box.CheckedChanged
        FormColor_GroupBox.Visible = visiable_color_box.Checked
        TextColor_GroupBox.Visible = visiable_color_box.Checked
    End Sub

    Private Sub Log_Button_Click(sender As System.Object, e As System.EventArgs) Handles submit_Button.Click

        Signin_group.Visible = False    ' dis visiable log in group
        visiable_color_box.Enabled = True   ' enable all color group
        FormColor_GroupBox.Enabled = True
        TextColor_GroupBox.Enabled = True

    End Sub

    Private Sub FormColor_Beige_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FormColor_Beige.CheckedChanged
        Me.BackColor = Color.Beige  'change background color to Beige
    End Sub

    Private Sub FormColor_Blue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FormColor_Blue.CheckedChanged
        Me.BackColor = Color.Blue   'change background color to Blue
    End Sub

    Private Sub FormColor_Yellow_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FormColor_Yellow.CheckedChanged
        Me.BackColor = Color.Yellow     'change background color to Yellow
    End Sub

    Private Sub FormColor_Grey_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles FormColor_Gray.CheckedChanged
        Me.BackColor = Color.Gray   'change background color to gray
    End Sub

    Private Sub TextColor_black_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TextColor_black.CheckedChanged
        Me.ForeColor = Color.Black  ' change text color to black (default)
    End Sub

    Private Sub TextColor_White_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles TextColor_White.CheckedChanged
        Me.ForeColor = Color.White 'change text color to white
    End Sub

    Private Sub exit_botton_Click(sender As System.Object, e As System.EventArgs) Handles exit_botton.Click
        Close()  ' close this app
    End Sub
End Class
