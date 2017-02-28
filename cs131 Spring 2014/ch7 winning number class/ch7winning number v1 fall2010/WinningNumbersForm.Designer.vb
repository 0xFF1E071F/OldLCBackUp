<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinningNumbersForm
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.addButton1 = New System.Windows.Forms.Button()
        Me.removeButton2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Items.AddRange(New Object() {"1234", "2345", "3456", "4567"})
        Me.ListBox1.Location = New System.Drawing.Point(276, 106)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(236, 179)
        Me.ListBox1.TabIndex = 0
        '
        'addButton1
        '
        Me.addButton1.Location = New System.Drawing.Point(60, 427)
        Me.addButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.addButton1.Name = "addButton1"
        Me.addButton1.Size = New System.Drawing.Size(150, 44)
        Me.addButton1.TabIndex = 1
        Me.addButton1.Text = "Add"
        Me.addButton1.UseVisualStyleBackColor = True
        '
        'removeButton2
        '
        Me.removeButton2.Location = New System.Drawing.Point(356, 427)
        Me.removeButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.removeButton2.Name = "removeButton2"
        Me.removeButton2.Size = New System.Drawing.Size(150, 44)
        Me.removeButton2.TabIndex = 2
        Me.removeButton2.Text = "Delete"
        Me.removeButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add a new number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 379)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox1.TabIndex = 4
        '
        'WinningNumbersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 512)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.removeButton2)
        Me.Controls.Add(Me.addButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "WinningNumbersForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents addButton1 As System.Windows.Forms.Button
    Friend WithEvents removeButton2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
