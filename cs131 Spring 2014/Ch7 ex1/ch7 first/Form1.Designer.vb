<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Color_comboBox1 = New System.Windows.Forms.ComboBox()
        Me.States_ListBox1 = New System.Windows.Forms.ListBox()
        Me.Add_Button1 = New System.Windows.Forms.Button()
        Me.Content_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Remove_Button1 = New System.Windows.Forms.Button()
        Me.location_TextBox1 = New System.Windows.Forms.TextBox()
        Me.insert_Button1 = New System.Windows.Forms.Button()
        Me.remove_both_Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Color_comboBox1
        '
        Me.Color_comboBox1.FormattingEnabled = True
        Me.Color_comboBox1.Items.AddRange(New Object() {"Blue", "Red", "Green", "Orange", "Yellow"})
        Me.Color_comboBox1.Location = New System.Drawing.Point(347, 73)
        Me.Color_comboBox1.Name = "Color_comboBox1"
        Me.Color_comboBox1.Size = New System.Drawing.Size(121, 33)
        Me.Color_comboBox1.TabIndex = 0
        '
        'States_ListBox1
        '
        Me.States_ListBox1.FormattingEnabled = True
        Me.States_ListBox1.ItemHeight = 25
        Me.States_ListBox1.Items.AddRange(New Object() {"Virginia ", "Connecticut", "North Carolina", "Massachusetts", "Colorado"})
        Me.States_ListBox1.Location = New System.Drawing.Point(77, 50)
        Me.States_ListBox1.Name = "States_ListBox1"
        Me.States_ListBox1.Size = New System.Drawing.Size(145, 204)
        Me.States_ListBox1.TabIndex = 1
        '
        'Add_Button1
        '
        Me.Add_Button1.Location = New System.Drawing.Point(399, 262)
        Me.Add_Button1.Name = "Add_Button1"
        Me.Add_Button1.Size = New System.Drawing.Size(113, 46)
        Me.Add_Button1.TabIndex = 2
        Me.Add_Button1.Text = "Add"
        Me.Add_Button1.UseVisualStyleBackColor = True
        '
        'Content_TextBox1
        '
        Me.Content_TextBox1.Location = New System.Drawing.Point(55, 320)
        Me.Content_TextBox1.Name = "Content_TextBox1"
        Me.Content_TextBox1.Size = New System.Drawing.Size(139, 31)
        Me.Content_TextBox1.TabIndex = 3
        '
        'Remove_Button1
        '
        Me.Remove_Button1.Location = New System.Drawing.Point(363, 345)
        Me.Remove_Button1.Name = "Remove_Button1"
        Me.Remove_Button1.Size = New System.Drawing.Size(130, 44)
        Me.Remove_Button1.TabIndex = 4
        Me.Remove_Button1.Text = "Remove"
        Me.Remove_Button1.UseVisualStyleBackColor = True
        '
        'location_TextBox1
        '
        Me.location_TextBox1.Location = New System.Drawing.Point(69, 372)
        Me.location_TextBox1.Name = "location_TextBox1"
        Me.location_TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.location_TextBox1.TabIndex = 5
        '
        'insert_Button1
        '
        Me.insert_Button1.Location = New System.Drawing.Point(415, 416)
        Me.insert_Button1.Name = "insert_Button1"
        Me.insert_Button1.Size = New System.Drawing.Size(130, 44)
        Me.insert_Button1.TabIndex = 6
        Me.insert_Button1.Text = "Insert"
        Me.insert_Button1.UseVisualStyleBackColor = True
        '
        'remove_both_Button1
        '
        Me.remove_both_Button1.Location = New System.Drawing.Point(179, 454)
        Me.remove_both_Button1.Name = "remove_both_Button1"
        Me.remove_both_Button1.Size = New System.Drawing.Size(130, 44)
        Me.remove_both_Button1.TabIndex = 7
        Me.remove_both_Button1.Text = "Remove BothButton1"
        Me.remove_both_Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.remove_both_Button1)
        Me.Controls.Add(Me.insert_Button1)
        Me.Controls.Add(Me.location_TextBox1)
        Me.Controls.Add(Me.Remove_Button1)
        Me.Controls.Add(Me.Content_TextBox1)
        Me.Controls.Add(Me.Add_Button1)
        Me.Controls.Add(Me.States_ListBox1)
        Me.Controls.Add(Me.Color_comboBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Color_comboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents States_ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Add_Button1 As System.Windows.Forms.Button
    Friend WithEvents Content_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Remove_Button1 As System.Windows.Forms.Button
    Friend WithEvents location_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents insert_Button1 As System.Windows.Forms.Button
    Friend WithEvents remove_both_Button1 As System.Windows.Forms.Button

End Class
