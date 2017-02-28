' Yu Fu
Public Class Form1

    Const adult_fee As Decimal = 90D
    Const student_fee As Decimal = 70D
    Const under11_fee As Decimal = 50D
    Const pool_fee As Decimal = 20D
    Const Yoga_fee As Decimal = 40D


    Private Sub calculateButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton1.Click
        Dim type_fee, activity_fee, total_fee As Decimal
        If adultRadioButton1.Checked Then
            type_fee = adult_fee
        ElseIf studentRadioButton2.Checked Then
            type_fee = student_fee
        ElseIf under11RadioButton3.Checked Then
            type_fee = under11_fee
        End If

        If poolCheckBox2.Checked Then
            activity_fee += pool_fee
        End If
        If yogaCheckBox3.Checked Then
            activity_fee += Yoga_fee
        End If

        If DiscountToolStripMenuItem.Checked = True Then
            total_fee = type_fee
        ElseIf Discount2ToolStripMenuItem.Checked = True Then
            total_fee = type_fee + activity_fee
            total_fee *= 0.9
        Else
            total_fee = type_fee + activity_fee
        End If

        outputLabel3.Text = total_fee.ToString("C")
    End Sub

    Private Sub clearButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearButton2.Click
        outputLabel3.Text = ""
        poolCheckBox2.Checked = False
        yogaCheckBox3.Checked = False
        adultRadioButton1.Checked = False
        studentRadioButton2.Checked = False
        under11RadioButton3.Checked = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculateToolStripMenuItem.Click
        calculateButton1_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        Dim feedback As DialogResult
        feedback = MessageBox.Show("Do you want to clean all data?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If feedback = Windows.Forms.DialogResult.Yes Then
            clearButton2_Click(sender, e)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This program made by Yu Fu", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackgroundImageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundImageToolStripMenuItem.Click
        If BackgroundImageToolStripMenuItem.Checked = True Then
            BackgroundImageToolStripMenuItem.Checked = False
            Me.BackgroundImage = Nothing
        Else
            BackgroundImageToolStripMenuItem.Checked = True
            BackgroundImage2ToolStripMenuItem.Checked = False
            Me.BackgroundImage = My.Resources._1

        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        membershiptypeBox.Font = FontDialog1.Font
    End Sub

    Private Sub BackgroundImage2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundImage2ToolStripMenuItem.Click
        If BackgroundImage2ToolStripMenuItem.Checked = True Then
            BackgroundImage2ToolStripMenuItem.Checked = False
            Me.BackgroundImage = Nothing
        Else
            BackgroundImage2ToolStripMenuItem.Checked = True
            BackgroundImageToolStripMenuItem.Checked = False
            Me.BackgroundImage = My.Resources._2
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub DiscountToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DiscountToolStripMenuItem.Click
        If DiscountToolStripMenuItem.Checked = True Then
            DiscountToolStripMenuItem.Checked = False
        Else
            DiscountToolStripMenuItem.Checked = True
            Discount2ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub Discount2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Discount2ToolStripMenuItem.Click
        If Discount2ToolStripMenuItem.Checked = True Then
            Discount2ToolStripMenuItem.Checked = False
        Else
            Discount2ToolStripMenuItem.Checked = True
            DiscountToolStripMenuItem.Checked = False
        End If
    End Sub
End Class
