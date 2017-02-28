Public Class Shopping

    Friend total_cost As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        total_cost = 0
        If leafCheckBox1.Checked = True Then
            total_cost += 35
            MarketBasket1.descriptionListBox.Items.Add("Single Leaf Necklace with Copper Chain")
            MarketBasket1.costlistbox.Items.Add("$35")
            MarketBasket1.itemcodeListBox.Items.Add("A")
        End If

        If triplestrandCheckBox2.Checked = True Then
            total_cost += 57
            MarketBasket1.descriptionListBox.Items.Add("Blue Triple Strand Crystal Necklace")
            MarketBasket1.costlistbox.Items.Add("$57")
            MarketBasket1.itemcodeListBox.Items.Add("B")
        End If

        If cloisonneCheckBox3.Checked = True Then
            total_cost += 99
            MarketBasket1.descriptionListBox.Items.Add("Silver Cloisonne Necklace")
            MarketBasket1.costlistbox.Items.Add("$99")
            MarketBasket1.itemcodeListBox.Items.Add("C")
        End If

        If CheckBox4.Checked = True Then
            total_cost += 350
            MarketBasket1.descriptionListBox.Items.Add("Sapphire White Gold ring")
            MarketBasket1.costlistbox.Items.Add("$350")
            MarketBasket1.itemcodeListBox.Items.Add("D")
        End If

        If CheckBox5.Checked = True Then
            total_cost += 250
            MarketBasket1.descriptionListBox.Items.Add("Handmade Sterling Silver with Inlaid Turquoise")
            MarketBasket1.costlistbox.Items.Add("$250")
            MarketBasket1.itemcodeListBox.Items.Add("E")
        End If

        If CheckBox6.Checked = True Then
            total_cost += 95
            MarketBasket1.descriptionListBox.Items.Add("Urban Tibetan Ring with Coral Stone")
            MarketBasket1.costlistbox.Items.Add("$95")
            MarketBasket1.itemcodeListBox.Items.Add("F")
        End If
        MarketBasket1.Label1.Text = total_cost.ToString("C")
        MarketBasket1.ShowDialog()
    End Sub
End Class
