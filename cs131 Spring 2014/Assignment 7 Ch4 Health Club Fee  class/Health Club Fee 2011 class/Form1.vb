'Yu Fu
Public Class Form1

    Const adult_fee As Decimal = 90D
    Const student_fee As Decimal = 70D
    Const under11_fee As Decimal = 50D
    Const pool_fee As Decimal = 20D
    Const Yoga_fee As Decimal = 40D

    Private Sub calculateButton1_Click(sender As System.Object, e As System.EventArgs) Handles calculateButton1.Click

        Dim total_fee As Decimal

        If adultRadioButton1.Checked Then
            total_fee += adult_fee
        ElseIf studentRadioButton2.Checked Then
                total_fee += student_fee
        ElseIf under11RadioButton3.Checked Then
            total_fee += under11_fee
        End If

        If poolCheckBox2.Checked Then
            total_fee += pool_fee
        End If
        If yogaCheckBox3.Checked Then
            total_fee += Yoga_fee
        End If

        outputLabel3.Text = total_fee.ToString("C")

    End Sub

    Private Sub clearButton2_Click(sender As System.Object, e As System.EventArgs) Handles clearButton2.Click
        outputLabel3.Text = ""
        studentRadioButton2.Focus()  'return student as default
    End Sub
End Class