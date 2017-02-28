Public Class SandwichForm
    Const english_sandwich As Decimal = 2D
    Const croissant_sandwich As Decimal = 2.5D
    Const banana As Decimal = 1D
    Const burrito As Decimal = 2.5D

    Friend price As Decimal

    Private Sub drinksLabel3_Click(sender As System.Object, e As System.EventArgs) Handles drinksLabel3.Click
        Me.Close()
        drinksForm.Show()

    End Sub

    Private Sub sandwichPictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles sandwichPictureBox1.MouseClick
        price += croissant_sandwich
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseClick
        price += english_sandwich
    End Sub

    Private Sub banana_PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles banana_PictureBox2.MouseClick
        price += banana
    End Sub

    Private Sub burrito_PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles burrito_PictureBox3.MouseClick
        price += burrito
    End Sub


    Private Sub finishLabel2_Click_1(sender As System.Object, e As System.EventArgs) Handles finishLabel2.Click
        Me.Close()
        FinishForm.PriceLabel.Text = (drinksForm.drink_price + price).ToString("C")
        FinishForm.ShowDialog()
    End Sub
End Class
