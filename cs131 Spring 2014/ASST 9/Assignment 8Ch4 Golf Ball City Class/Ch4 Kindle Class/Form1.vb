
'Yu Fu

Option Strict On
'1. use "elseif" to determine shipping costs
'I've included the shipping cost constants below.

'AND

'2. use "nested if" structure for the price break code
'price breaks as follows:1 or 2 dozen @ $50
'3 to 5 dozen @ $40
'more than 5 dozen @ $30
'make these constants

' then

'user enters the number of dozen
'golf ball cost is price times number of dozen.

'3. total cost is, of course, the sum of golf ball cost and shipping cost.
Public Class Form1
    Const standard_shipping_charges As Decimal = 10D
    Const one_day_shipping_charges As Decimal = 30D
    Const two_day_shipping_charges As Decimal = 20D
    Const dozen1 As Decimal = 50D
    Const dozen3 As Decimal = 40D
    Const dozen5 As Decimal = 30D



   
    Private Sub calculateButton1_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton1.Click
        Dim dozen_total As Decimal
        Dim num_dozen As Decimal
        Dim total As Decimal

        num_dozen = Decimal.Parse(number_of_booksTextBox.Text)

        If num_dozen <= 2 Then
            dozen_total = num_dozen * dozen1
        Else
            If num_dozen <= 5 Then
                dozen_total = num_dozen * dozen3
            Else
                dozen_total = num_dozen * dozen5
            End If
        End If

        If stdshipRadioButton1.Checked = True Then
            shipping_costTextBox.Text = standard_shipping_charges.ToString("C")
            total = dozen_total + standard_shipping_charges
        ElseIf twodayshipRadioButton2.Checked = True Then
            shipping_costTextBox.Text = two_day_shipping_charges.ToString("C")
            total = dozen_total + two_day_shipping_charges
        ElseIf onedayshipRadioButton3.Checked = True Then
            shipping_costTextBox.Text = one_day_shipping_charges.ToString("C")
            total = dozen_total + one_day_shipping_charges
        End If
       

        kindle_costTextBox.Text = dozen_total.ToString("C")
        total_costTextBox.Text = total.ToString("C")
    End Sub

    Private Sub clearButton2_Click(sender As System.Object, e As System.EventArgs) Handles clearButton2.Click
        number_of_booksTextBox.Clear()
        number_of_booksTextBox.Focus()
        kindle_costTextBox.Text = ""
        total_costTextBox.Text = ""
        shipping_costTextBox.Text = ""
    End Sub
End Class
