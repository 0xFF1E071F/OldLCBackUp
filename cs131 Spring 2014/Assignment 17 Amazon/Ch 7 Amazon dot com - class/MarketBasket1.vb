Public Class MarketBasket1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Do Until descriptionListBox.Items.Count = 0
            descriptionListBox.Items.RemoveAt(descriptionListBox.Items.Count - 1)
            costlistbox.Items.RemoveAt(costlistbox.Items.Count - 1)
            itemcodeListBox.Items.RemoveAt(itemcodeListBox.Items.Count - 1)
        Loop
        Shopping.leafCheckBox1.Checked = False
        Shopping.triplestrandCheckBox2.Checked = False
        Shopping.cloisonneCheckBox3.Checked = False
        Shopping.CheckBox4.Checked = False
        Shopping.CheckBox5.Checked = False
        Shopping.CheckBox6.Checked = False

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim match As Boolean
        Dim price As Integer

        For i = 0 To itemcodeListBox.Items.Count - 1
            If TextBox1.Text.ToUpper = itemcodeListBox.Items(i) Then
                price = costlistbox.Items(i)
                itemcodeListBox.Items.RemoveAt(i)
                descriptionListBox.Items.RemoveAt(i)
                costlistbox.Items.RemoveAt(i)
                match = True
                Exit For
            End If
        Next

        If match = True Then
            Shopping.total_cost -= price
            Label1.Text = Shopping.total_cost.ToString("C")
        Else
            MessageBox.Show("Please input a correct item code", "Error")
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub MarketBasket1_Load(sender As System.Object, e As System.EventArgs) Handles Me.FormClosed
        Do Until descriptionListBox.Items.Count = 0
            descriptionListBox.Items.RemoveAt(descriptionListBox.Items.Count - 1)
            costlistbox.Items.RemoveAt(costlistbox.Items.Count - 1)
            itemcodeListBox.Items.RemoveAt(itemcodeListBox.Items.Count - 1)
        Loop
        Shopping.leafCheckBox1.Checked = False
        Shopping.triplestrandCheckBox2.Checked = False
        Shopping.cloisonneCheckBox3.Checked = False
        Shopping.CheckBox4.Checked = False
        Shopping.CheckBox5.Checked = False
        Shopping.CheckBox6.Checked = False
    End Sub
End Class