Public Class Voting_Form
    Friend total, Uconn_votes, Florida_votes As Integer
    Friend loc_fl As Decimal
    Friend loc_ct As Decimal
    Private Sub Florida_RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Florida_RadioButton1.Click
        total += 1
        Florida_votes += 1
    End Sub

    Private Sub UConn_RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles UConn_RadioButton2.Click
        total += 1
        Uconn_votes += 1
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'Results_Form.Total_TextBox3.Text = total.ToString
        'Results_Form.Florida_TextBox1.Text = (Florida_votes / total).ToString("p0")
        'Results_Form.UConn_TextBox2.Text = (Uconn_votes / total).ToString("p0")
        Results_Form.Show()
        loc_fl = (Florida_votes / total) * 300
        loc_ct = (Uconn_votes / total) * 300
    End Sub
End Class
