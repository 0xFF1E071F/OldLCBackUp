'Yu FU
Option Strict On
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Cal_Button.Click
        'cant artihmetic with text-string data
        'total_Label.Text = qualitity_TextBox.Text * price_TextBox.Text
        'dim creats storage for the numeric variable

        Dim quanlity As Integer
        Dim price, total As Decimal

        'convert the string data and put it into the stroage space
        quanlity = Integer.Parse(qualitity_TextBox.Text)
        price = Decimal.Parse(price_TextBox.Text)
        total = quanlity * price

        'put tge numertic date into the string location
        total_Label.Text = total.ToString("C")

    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles clear_Button.Click
        total_Label.Text = ""
        qualitity_TextBox.Text = ""
        price_TextBox.Text = ""
    End Sub
End Class
