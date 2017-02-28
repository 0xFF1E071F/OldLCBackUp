Public Class Form1

    Private Sub Start_Button1_Click(sender As System.Object, e As System.EventArgs) Handles Start_Button1.Click
        'control variable
        Dim n, limit As Integer
        'the initial value is zero
        limit = Integer.Parse(Limit_TextBox1.Text)

        Do Until n > limit
            If n > 25 Then
                Exit Do
            End If

            ListBox1.Items.Add(n)
            n += 1
        Loop


    End Sub
End Class
