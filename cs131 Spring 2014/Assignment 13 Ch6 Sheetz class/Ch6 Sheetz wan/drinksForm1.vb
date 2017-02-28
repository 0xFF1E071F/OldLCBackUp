Public Class drinksForm

    Const med_cofee As Decimal = 1D
    Const lg_coffee As Decimal = 2D
    Const sm_oj As Decimal = 1D
    Const lg_oj As Decimal = 1.5D
    Friend drink_price As Decimal
    Dim ij_price As Decimal
    Dim coffee_price As Decimal
   
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If med_cofRadioButton.Checked = True Then
            coffee_price = med_cofee
        ElseIf lg_cofRadioButton.Checked = True Then
            coffee_price = lg_coffee
        End If
        If smojRadioButton.Checked = True Then
            ij_price = sm_oj
        ElseIf lgojRadioButton.Checked = True Then
            ij_price = lg_oj
        End If
        drink_price = ij_price + coffee_price
        SandwichForm.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If med_cofRadioButton.Checked = True Then
            coffee_price = med_cofee
        ElseIf lg_cofRadioButton.Checked = True Then
            coffee_price = lg_coffee
        End If

        
        If smojRadioButton.Checked = True Then
            ij_price = sm_oj
        ElseIf lgojRadioButton.Checked = True Then
            ij_price = lg_oj
        End If
        drink_price = ij_price + coffee_price

        FinishForm.PriceLabel.Text = (SandwichForm.price + drink_price).ToString("C")
        FinishForm.ShowDialog()
    End Sub

End Class