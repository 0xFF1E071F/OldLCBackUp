Public Class Form1
    Const high_pay As Decimal = 35D
    Const pay As Decimal = 20D
   
   
    Private Sub run_Button1_Click(sender As System.Object, e As System.EventArgs) Handles run_Button1.Click
        Dim n As Integer
        Dim payroll As Decimal
        Do While n <= Hours_ListBox1.Items.Count - 1
            If Hours_ListBox1.Items(n) >= 40 Then
                payroll = Hours_ListBox1.Items(n) * high_pay
            Else
                payroll = Hours_ListBox1.Items(n) * pay
            End If
            Payday_ListBox2.Items.Insert(n, payroll)
            n += 1
        Loop
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim match As Boolean = False

        For i = 0 To Hours_ListBox1.Items.Count - 1
            If search_TextBox1.Text = Hours_ListBox1.Items(i) Then
                'out_Label1.Text = "Match"
                match = True
                Exit For
            Else
                out_Label1.Text = "Non-Match"
            End If
        Next
        If match Then
            MessageBox.Show("check overtime status for employees")
        Else
            out_Label1.Text = "Sorry, no match"
        End If
    End Sub
End Class
