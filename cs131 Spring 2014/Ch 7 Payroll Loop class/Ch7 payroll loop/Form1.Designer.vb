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
        Me.run_Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Hours_ListBox1 = New System.Windows.Forms.ListBox()
        Me.Payday_ListBox2 = New System.Windows.Forms.ListBox()
        Me.search_TextBox1 = New System.Windows.Forms.TextBox()
        Me.out_Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'run_Button1
        '
        Me.run_Button1.Location = New System.Drawing.Point(260, 374)
        Me.run_Button1.Name = "run_Button1"
        Me.run_Button1.Size = New System.Drawing.Size(151, 39)
        Me.run_Button1.TabIndex = 0
        Me.run_Button1.Text = "Run Payroll"
        Me.run_Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(262, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Hours_ListBox1
        '
        Me.Hours_ListBox1.FormattingEnabled = True
        Me.Hours_ListBox1.ItemHeight = 25
        Me.Hours_ListBox1.Items.AddRange(New Object() {"10", "20", "30", "40", "32", "25", "19", "50"})
        Me.Hours_ListBox1.Location = New System.Drawing.Point(70, 41)
        Me.Hours_ListBox1.Name = "Hours_ListBox1"
        Me.Hours_ListBox1.Size = New System.Drawing.Size(138, 254)
        Me.Hours_ListBox1.TabIndex = 2
        '
        'Payday_ListBox2
        '
        Me.Payday_ListBox2.FormattingEnabled = True
        Me.Payday_ListBox2.ItemHeight = 25
        Me.Payday_ListBox2.Location = New System.Drawing.Point(284, 44)
        Me.Payday_ListBox2.Name = "Payday_ListBox2"
        Me.Payday_ListBox2.Size = New System.Drawing.Size(138, 254)
        Me.Payday_ListBox2.TabIndex = 3
        '
        'search_TextBox1
        '
        Me.search_TextBox1.Location = New System.Drawing.Point(44, 390)
        Me.search_TextBox1.Name = "search_TextBox1"
        Me.search_TextBox1.Size = New System.Drawing.Size(100, 31)
        Me.search_TextBox1.TabIndex = 4
        '
        'out_Label1
        '
        Me.out_Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.out_Label1.Location = New System.Drawing.Point(51, 457)
        Me.out_Label1.Name = "out_Label1"
        Me.out_Label1.Size = New System.Drawing.Size(130, 38)
        Me.out_Label1.TabIndex = 5
        Me.out_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.out_Label1)
        Me.Controls.Add(Me.search_TextBox1)
        Me.Controls.Add(Me.Payday_ListBox2)
        Me.Controls.Add(Me.Hours_ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.run_Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents run_Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Hours_ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Payday_ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents search_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents out_Label1 As System.Windows.Forms.Label

End Class
