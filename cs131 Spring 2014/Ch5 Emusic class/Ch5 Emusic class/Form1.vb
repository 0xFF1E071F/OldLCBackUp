Public Class Form1
    Const SONG_PRICE As Decimal = 0.6D
    Const CD_PRICE As Decimal = 5D


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

        Catch ex As Exception
            Dim msg As String
            msg = "Please enter numbers only."
            MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearButton_Click(sender, e)
        End Try

    End Sub

    Private Sub clearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton.Click
        songTextBox.Clear()
        songTextBox.Focus()
        cdTextBox.Clear()
        totalpriceLabel.Text = ""
    End Sub

    Private Sub BackColorSongsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackColorSongsToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        songTextBox.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ForecolorCdToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ForecolorCdToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        cdTextBox.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        calculateButton_Click(sender, e)
    End Sub

    Private Sub TotalFrontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TotalFrontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        totalpriceLabel.Font = FontDialog1.Font
    End Sub

    Private Sub OldToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OldToolStripMenuItem.Click
        If OldToolStripMenuItem.Checked Then
            Me.BackgroundImage = Nothing
            OldToolStripMenuItem.Checked = False
        Else
            OldToolStripMenuItem.Checked = True
            Me.BackgroundImage = My.Resources.blues
            NewToolStripMenuItem.Checked = False
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If NewToolStripMenuItem.Checked Then
            NewToolStripMenuItem.Checked = False
            Me.BackgroundImage = Nothing
        Else
            NewToolStripMenuItem.Checked = True
            Me.BackgroundImage = My.Resources.ipod_wideweb__470x340_2
            OldToolStripMenuItem.Checked = False
        End If
    End Sub
End Class