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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.price_TextBox = New System.Windows.Forms.TextBox()
        Me.qualitity_TextBox = New System.Windows.Forms.TextBox()
        Me.Cal_Button = New System.Windows.Forms.Button()
        Me.clear_Button = New System.Windows.Forms.Button()
        Me.total_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'price_TextBox
        '
        Me.price_TextBox.Location = New System.Drawing.Point(119, 81)
        Me.price_TextBox.Name = "price_TextBox"
        Me.price_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.price_TextBox.TabIndex = 3
        '
        'qualitity_TextBox
        '
        Me.qualitity_TextBox.Location = New System.Drawing.Point(119, 49)
        Me.qualitity_TextBox.Name = "qualitity_TextBox"
        Me.qualitity_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.qualitity_TextBox.TabIndex = 5
        '
        'Cal_Button
        '
        Me.Cal_Button.Location = New System.Drawing.Point(144, 172)
        Me.Cal_Button.Name = "Cal_Button"
        Me.Cal_Button.Size = New System.Drawing.Size(75, 30)
        Me.Cal_Button.TabIndex = 6
        Me.Cal_Button.Text = "Calculate"
        Me.Cal_Button.UseVisualStyleBackColor = True
        '
        'clear_Button
        '
        Me.clear_Button.Location = New System.Drawing.Point(144, 218)
        Me.clear_Button.Name = "clear_Button"
        Me.clear_Button.Size = New System.Drawing.Size(75, 30)
        Me.clear_Button.TabIndex = 8
        Me.clear_Button.Text = "Clear"
        Me.clear_Button.UseVisualStyleBackColor = True
        '
        'total_Label
        '
        Me.total_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total_Label.Location = New System.Drawing.Point(119, 117)
        Me.total_Label.Name = "total_Label"
        Me.total_Label.Size = New System.Drawing.Size(100, 20)
        Me.total_Label.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 287)
        Me.Controls.Add(Me.total_Label)
        Me.Controls.Add(Me.clear_Button)
        Me.Controls.Add(Me.Cal_Button)
        Me.Controls.Add(Me.qualitity_TextBox)
        Me.Controls.Add(Me.price_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents price_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents qualitity_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cal_Button As System.Windows.Forms.Button
    Friend WithEvents clear_Button As System.Windows.Forms.Button
    Friend WithEvents total_Label As System.Windows.Forms.Label

End Class
