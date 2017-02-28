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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Start_Button1 = New System.Windows.Forms.Button()
        Me.Limit_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(288, 73)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(272, 254)
        Me.ListBox1.TabIndex = 0
        '
        'Start_Button1
        '
        Me.Start_Button1.Location = New System.Drawing.Point(414, 433)
        Me.Start_Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Start_Button1.Name = "Start_Button1"
        Me.Start_Button1.Size = New System.Drawing.Size(150, 44)
        Me.Start_Button1.TabIndex = 1
        Me.Start_Button1.Text = "Start"
        Me.Start_Button1.UseVisualStyleBackColor = True
        '
        'Limit_TextBox1
        '
        Me.Limit_TextBox1.Location = New System.Drawing.Point(88, 437)
        Me.Limit_TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Limit_TextBox1.Name = "Limit_TextBox1"
        Me.Limit_TextBox1.Size = New System.Drawing.Size(196, 31)
        Me.Limit_TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Limit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 644)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Limit_TextBox1)
        Me.Controls.Add(Me.Start_Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Start_Button1 As System.Windows.Forms.Button
    Friend WithEvents Limit_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
