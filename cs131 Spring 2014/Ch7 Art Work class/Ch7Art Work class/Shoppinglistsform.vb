Public Class Shoppinglistsform

    
    Private Sub deleteButton_Click(sender As System.Object, e As System.EventArgs) Handles deleteButton.Click
        ArtForm.total_cost -= priceListBox.Items(artworkListBox.SelectedItem)
        'If artworkListBox.SelectedItem.Then Then
        priceListBox.Items.RemoveAt(artworkListBox.SelectedIndex)
        artworkListBox.Items.Remove(artworkListBox.SelectedItem)
        totalcostLabel.Text = ArtForm.total_cost.ToString("C")
        'Else
        'MessageBox.Show("Please select an item")
        'End If

    End Sub

    Private Sub Shoppinglistsform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class