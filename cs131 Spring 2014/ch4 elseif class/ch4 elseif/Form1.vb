Option Strict On
Public Class Form1
    Const hair_fee As Integer = 120
    Const massage_fee As Integer = 50
    Const manicure_fee As Integer = 30


    
    Private Sub calcultaeButton1_Click(sender As System.Object, e As System.EventArgs) Handles calcultaeButton1.Click

        Dim cust_cost As Decimal
        Dim disc_cust_cost As Double

        If hairCheckBox1.Checked Then
            cust_cost += hair_fee
        End If
        If massageCheckBox2.Checked Then
            cust_cost += massage_fee
        End If
        If manicureCheckBox3.Checked Then
            cust_cost += manicure_fee
        End If

        If zeroRadioButton1.Checked Then
            outputLabel1.Text = cust_cost.ToString("C")

        End If
        If tenRadioButton2.Checked Then
            disc_cust_cost = cust_cost * 0.9
            outputLabel1.Text = disc_cust_cost.ToString("C")
        End If
        If twentyRadioButton3.Checked Then
            disc_cust_cost = cust_cost * 0.8
            outputLabel1.Text = disc_cust_cost.ToString("C")
        End If
    End Sub
End Class
