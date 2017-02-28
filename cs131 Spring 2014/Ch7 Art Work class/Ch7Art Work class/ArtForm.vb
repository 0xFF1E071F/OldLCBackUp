Public Class ArtForm
    Friend total_cost As Integer
    Const one = 1
    Const two = 2
    Const three = 3

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Shoppinglistsform.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Shoppinglistsform.artworkListBox.Items.Add("Salvador Dali")
        Shoppinglistsform.priceListBox.Items.Add(one.ToString("C"))
        total_cost += one
        Shoppinglistsform.totalcostLabel.Text = total_cost.ToString("C")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Shoppinglistsform.artworkListBox.Items.Add("Marc Chagall")
        Shoppinglistsform.priceListBox.Items.Add(two.ToString("C"))
        total_cost += two
        Shoppinglistsform.totalcostLabel.Text = total_cost.ToString("C")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Shoppinglistsform.artworkListBox.Items.Add("Itzchak(Tarkay)")
        Shoppinglistsform.priceListBox.Items.Add(three.ToString("C"))
        total_cost += three
        Shoppinglistsform.totalcostLabel.Text = total_cost.ToString("C")
    End Sub
End Class
