Public Class purchaseForm1
    Const SONG_PRICE As Decimal = 0.6D
    Const CD_PRICE As Decimal = 5D
    Dim accum As Decimal


    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        Dim num_songs, num_cds As Integer
        Dim total_song, total_cd, total_total As Decimal

        Try
            num_songs = Integer.Parse(songTextBox.Text)
            num_cds = Integer.Parse(cdTextBox.Text)

            total_song = num_songs * SONG_PRICE
            total_cd = num_cds * CD_PRICE

            total_total = total_song + total_cd

            totalpriceLabel.Text = total_total.ToString("C")
            accum += total_total
            siteForm.outputLabel.Text = "you’ve spent " & accum.ToString("C")
        Catch ex As Exception
            Dim msg As String
            msg = "Please enter numbers only."
            MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    
    Private Sub purchaseForm1_Load(sender As System.Object, e As System.EventArgs) Handles Me.FormClosed
        siteForm.Button1.Enabled = True
    End Sub
End Class
