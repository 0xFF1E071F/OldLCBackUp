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
        Me.calcButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.summarybutton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.summarynumcustLabel7 = New System.Windows.Forms.Label()
        Me.summarysalesLabel8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.quantityTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.totalLabel11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcButton1
        '
        Me.calcButton1.Location = New System.Drawing.Point(22, 190)
        Me.calcButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.calcButton1.Name = "calcButton1"
        Me.calcButton1.Size = New System.Drawing.Size(138, 42)
        Me.calcButton1.TabIndex = 6
        Me.calcButton1.Text = "Calculate"
        Me.calcButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton2.Location = New System.Drawing.Point(229, 190)
        Me.clearButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(138, 42)
        Me.clearButton2.TabIndex = 7
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Fuchsia
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 161)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Accumulating Sales"
        '
        'summarybutton
        '
        Me.summarybutton.Location = New System.Drawing.Point(430, 190)
        Me.summarybutton.Name = "summarybutton"
        Me.summarybutton.Size = New System.Drawing.Size(138, 42)
        Me.summarybutton.TabIndex = 8
        Me.summarybutton.Text = "&Summary"
        Me.summarybutton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(84, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Counting Customers"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(301, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Fuchsia
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(301, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 40)
        Me.Label4.TabIndex = 5
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Summary - Total Number Customers"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Summary - Accumulated sales"
        '
        'summarynumcustLabel7
        '
        Me.summarynumcustLabel7.AutoSize = True
        Me.summarynumcustLabel7.Location = New System.Drawing.Point(426, 255)
        Me.summarynumcustLabel7.Name = "summarynumcustLabel7"
        Me.summarynumcustLabel7.Size = New System.Drawing.Size(115, 24)
        Me.summarynumcustLabel7.TabIndex = 10
        Me.summarynumcustLabel7.Text = "# Customers"
        Me.summarynumcustLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'summarysalesLabel8
        '
        Me.summarysalesLabel8.AutoSize = True
        Me.summarysalesLabel8.Location = New System.Drawing.Point(423, 294)
        Me.summarysalesLabel8.Name = "summarysalesLabel8"
        Me.summarysalesLabel8.Size = New System.Drawing.Size(141, 24)
        Me.summarysalesLabel8.TabIndex = 12
        Me.summarysalesLabel8.Text = "Summary Sales"
        Me.summarysalesLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Quantity"
        '
        'quantityTextBox1
        '
        Me.quantityTextBox1.Location = New System.Drawing.Point(300, 61)
        Me.quantityTextBox1.Name = "quantityTextBox1"
        Me.quantityTextBox1.Size = New System.Drawing.Size(100, 29)
        Me.quantityTextBox1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(164, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 24)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Total"
        '
        'totalLabel11
        '
        Me.totalLabel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel11.Location = New System.Drawing.Point(296, 111)
        Me.totalLabel11.Name = "totalLabel11"
        Me.totalLabel11.Size = New System.Drawing.Size(104, 36)
        Me.totalLabel11.TabIndex = 14
        Me.totalLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(58, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(372, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Below is happening inside of the computer:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 247)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer"
        '
        'Form1
        '
        Me.AcceptButton = Me.calcButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton2
        Me.ClientSize = New System.Drawing.Size(627, 612)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.totalLabel11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.quantityTextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.summarysalesLabel8)
        Me.Controls.Add(Me.summarynumcustLabel7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.summarybutton)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.calcButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Counting and Accumulating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents summarybutton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents summarynumcustLabel7 As System.Windows.Forms.Label
    Friend WithEvents summarysalesLabel8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents quantityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents totalLabel11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
