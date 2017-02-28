Option Strict Off

Public Class Form1



    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        outputLabel.Text = ""
        TextBox1.Focus()

    End Sub


    Private Sub sortButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortButton.Click
        'Example1 sorting numeric data
        'Dim first, second As Decimal
        'first = Decimal.Parse(TextBox1.Text)
        'second = Decimal.Parse(TextBox2.Text)

        'If first > second Then
        '    outputLabel.Text = "Low " & second.ToString & ControlChars.NewLine & "High " & first.ToString
        'Else
        '    outputLabel.Text = "Low " & first.ToString & ControlChars.NewLine & "High " & second.ToString

        'End If

        'example 2 comparing alphabetical data - use .ToUpper or .ToLower
        'example 3 numeric dat as string - unpredictable; use numeric variables

        If TextBox1.Text.ToUpper > TextBox2.Text Then
            outputLabel.Text = TextBox2.Text & " Low" & ControlChars.NewLine & TextBox1.Text & " High"
        Else
            outputLabel.Text = TextBox1.Text & " Low" & ControlChars.NewLine & TextBox2.Text & " High"
        End If




    End Sub
End Class
