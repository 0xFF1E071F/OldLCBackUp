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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.name_label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.name_TextBox = New System.Windows.Forms.TextBox()
        Me.promotion_code_TextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Shirt1_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Shirt2_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Shirt3_RadioButton = New System.Windows.Forms.RadioButton()
        Me.shop_botton = New System.Windows.Forms.Button()
        Me.exit_botton = New System.Windows.Forms.Button()
        Me.output_PictureBox = New System.Windows.Forms.PictureBox()
        Me.output = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.output_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_label
        '
        Me.name_label.AutoSize = True
        Me.name_label.Location = New System.Drawing.Point(9, 153)
        Me.name_label.Name = "name_label"
        Me.name_label.Size = New System.Drawing.Size(35, 13)
        Me.name_label.TabIndex = 0
        Me.name_label.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Promotion Code"
        '
        'name_TextBox
        '
        Me.name_TextBox.Location = New System.Drawing.Point(127, 150)
        Me.name_TextBox.Name = "name_TextBox"
        Me.name_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.name_TextBox.TabIndex = 2
        '
        'promotion_code_TextBox
        '
        Me.promotion_code_TextBox.Location = New System.Drawing.Point(127, 191)
        Me.promotion_code_TextBox.Name = "promotion_code_TextBox"
        Me.promotion_code_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.promotion_code_TextBox.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Shirt1_RadioButton
        '
        Me.Shirt1_RadioButton.AutoSize = True
        Me.Shirt1_RadioButton.Location = New System.Drawing.Point(127, 300)
        Me.Shirt1_RadioButton.Name = "Shirt1_RadioButton"
        Me.Shirt1_RadioButton.Size = New System.Drawing.Size(61, 17)
        Me.Shirt1_RadioButton.TabIndex = 7
        Me.Shirt1_RadioButton.TabStop = True
        Me.Shirt1_RadioButton.Text = "Shirt1 $"
        Me.Shirt1_RadioButton.UseVisualStyleBackColor = True
        '
        'Shirt2_RadioButton
        '
        Me.Shirt2_RadioButton.AutoSize = True
        Me.Shirt2_RadioButton.Location = New System.Drawing.Point(127, 342)
        Me.Shirt2_RadioButton.Name = "Shirt2_RadioButton"
        Me.Shirt2_RadioButton.Size = New System.Drawing.Size(67, 17)
        Me.Shirt2_RadioButton.TabIndex = 8
        Me.Shirt2_RadioButton.TabStop = True
        Me.Shirt2_RadioButton.Text = "Shirt2 $$"
        Me.Shirt2_RadioButton.UseVisualStyleBackColor = True
        '
        'Shirt3_RadioButton
        '
        Me.Shirt3_RadioButton.AutoSize = True
        Me.Shirt3_RadioButton.Location = New System.Drawing.Point(127, 388)
        Me.Shirt3_RadioButton.Name = "Shirt3_RadioButton"
        Me.Shirt3_RadioButton.Size = New System.Drawing.Size(73, 17)
        Me.Shirt3_RadioButton.TabIndex = 9
        Me.Shirt3_RadioButton.TabStop = True
        Me.Shirt3_RadioButton.Text = "Shirt3 $$$"
        Me.Shirt3_RadioButton.UseVisualStyleBackColor = True
        '
        'shop_botton
        '
        Me.shop_botton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.shop_botton.Location = New System.Drawing.Point(258, 419)
        Me.shop_botton.Name = "shop_botton"
        Me.shop_botton.Size = New System.Drawing.Size(75, 40)
        Me.shop_botton.TabIndex = 10
        Me.shop_botton.Text = "Shop"
        Me.shop_botton.UseVisualStyleBackColor = True
        '
        'exit_botton
        '
        Me.exit_botton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exit_botton.Location = New System.Drawing.Point(445, 419)
        Me.exit_botton.Name = "exit_botton"
        Me.exit_botton.Size = New System.Drawing.Size(75, 40)
        Me.exit_botton.TabIndex = 11
        Me.exit_botton.Text = "E&xit"
        Me.exit_botton.UseVisualStyleBackColor = True
        '
        'output_PictureBox
        '
        Me.output_PictureBox.Location = New System.Drawing.Point(258, 251)
        Me.output_PictureBox.Name = "output_PictureBox"
        Me.output_PictureBox.Size = New System.Drawing.Size(262, 154)
        Me.output_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.output_PictureBox.TabIndex = 12
        Me.output_PictureBox.TabStop = False
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Location = New System.Drawing.Point(255, 198)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(0, 13)
        Me.output.TabIndex = 13
        '
        'Form1
        '
        Me.AcceptButton = Me.shop_botton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exit_botton
        Me.ClientSize = New System.Drawing.Size(551, 484)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.output_PictureBox)
        Me.Controls.Add(Me.exit_botton)
        Me.Controls.Add(Me.shop_botton)
        Me.Controls.Add(Me.Shirt3_RadioButton)
        Me.Controls.Add(Me.Shirt2_RadioButton)
        Me.Controls.Add(Me.Shirt1_RadioButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.promotion_code_TextBox)
        Me.Controls.Add(Me.name_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.name_label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.output_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_label As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents promotion_code_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Shirt1_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Shirt2_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Shirt3_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents shop_botton As System.Windows.Forms.Button
    Friend WithEvents exit_botton As System.Windows.Forms.Button
    Friend WithEvents output_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents output As System.Windows.Forms.Label

End Class
