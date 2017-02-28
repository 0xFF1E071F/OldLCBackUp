Option Strict On
Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles cal_button.Click
        Dim qty As Integer

        qty = Integer.Parse(TextBox1.Text)
        If qty <= 500D Then
            output.Text = (qty * 10D).ToString("C")
        Else
            If qty <= 1000D Then
                output.Text = (qty * 5D).ToString("C")
            Else
                output.Text = (qty * 1D).ToString("C")
            End If
        End If
    End Sub
End Class
