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
        Me.calcultaeButton1 = New System.Windows.Forms.Button()
        Me.celarButton2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.manicureCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.massageCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.hairCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.twentyRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.tenRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.zeroRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.outputLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'calcultaeButton1
        '
        Me.calcultaeButton1.Location = New System.Drawing.Point(128, 445)
        Me.calcultaeButton1.Name = "calcultaeButton1"
        Me.calcultaeButton1.Size = New System.Drawing.Size(138, 49)
        Me.calcultaeButton1.TabIndex = 0
        Me.calcultaeButton1.Text = "Calculate"
        Me.calcultaeButton1.UseVisualStyleBackColor = True
        '
        'celarButton2
        '
        Me.celarButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.celarButton2.Location = New System.Drawing.Point(386, 445)
        Me.celarButton2.Name = "celarButton2"
        Me.celarButton2.Size = New System.Drawing.Size(140, 59)
        Me.celarButton2.TabIndex = 1
        Me.celarButton2.Text = "Clear"
        Me.celarButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.manicureCheckBox3)
        Me.GroupBox1.Controls.Add(Me.massageCheckBox2)
        Me.GroupBox1.Controls.Add(Me.hairCheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 237)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Type"
        '
        'manicureCheckBox3
        '
        Me.manicureCheckBox3.AutoSize = True
        Me.manicureCheckBox3.Location = New System.Drawing.Point(20, 167)
        Me.manicureCheckBox3.Name = "manicureCheckBox3"
        Me.manicureCheckBox3.Size = New System.Drawing.Size(131, 33)
        Me.manicureCheckBox3.TabIndex = 2
        Me.manicureCheckBox3.Text = "Manicure"
        Me.manicureCheckBox3.UseVisualStyleBackColor = True
        '
        'massageCheckBox2
        '
        Me.massageCheckBox2.AutoSize = True
        Me.massageCheckBox2.Location = New System.Drawing.Point(22, 102)
        Me.massageCheckBox2.Name = "massageCheckBox2"
        Me.massageCheckBox2.Size = New System.Drawing.Size(130, 33)
        Me.massageCheckBox2.TabIndex = 1
        Me.massageCheckBox2.Text = "Massage"
        Me.massageCheckBox2.UseVisualStyleBackColor = True
        '
        'hairCheckBox1
        '
        Me.hairCheckBox1.AutoSize = True
        Me.hairCheckBox1.Location = New System.Drawing.Point(19, 38)
        Me.hairCheckBox1.Name = "hairCheckBox1"
        Me.hairCheckBox1.Size = New System.Drawing.Size(76, 33)
        Me.hairCheckBox1.TabIndex = 0
        Me.hairCheckBox1.Text = "Hair"
        Me.hairCheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.twentyRadioButton3)
        Me.GroupBox2.Controls.Add(Me.tenRadioButton2)
        Me.GroupBox2.Controls.Add(Me.zeroRadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(371, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 225)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount"
        '
        'twentyRadioButton3
        '
        Me.twentyRadioButton3.AutoSize = True
        Me.twentyRadioButton3.Location = New System.Drawing.Point(35, 179)
        Me.twentyRadioButton3.Name = "twentyRadioButton3"
        Me.twentyRadioButton3.Size = New System.Drawing.Size(79, 33)
        Me.twentyRadioButton3.TabIndex = 2
        Me.twentyRadioButton3.TabStop = True
        Me.twentyRadioButton3.Text = "20%"
        Me.twentyRadioButton3.UseVisualStyleBackColor = True
        '
        'tenRadioButton2
        '
        Me.tenRadioButton2.AutoSize = True
        Me.tenRadioButton2.Location = New System.Drawing.Point(36, 116)
        Me.tenRadioButton2.Name = "tenRadioButton2"
        Me.tenRadioButton2.Size = New System.Drawing.Size(79, 33)
        Me.tenRadioButton2.TabIndex = 1
        Me.tenRadioButton2.TabStop = True
        Me.tenRadioButton2.Text = "10%"
        Me.tenRadioButton2.UseVisualStyleBackColor = True
        '
        'zeroRadioButton1
        '
        Me.zeroRadioButton1.AutoSize = True
        Me.zeroRadioButton1.Checked = True
        Me.zeroRadioButton1.Location = New System.Drawing.Point(34, 50)
        Me.zeroRadioButton1.Name = "zeroRadioButton1"
        Me.zeroRadioButton1.Size = New System.Drawing.Size(90, 33)
        Me.zeroRadioButton1.TabIndex = 0
        Me.zeroRadioButton1.TabStop = True
        Me.zeroRadioButton1.Text = "None"
        Me.zeroRadioButton1.UseVisualStyleBackColor = True
        '
        'outputLabel1
        '
        Me.outputLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputLabel1.Location = New System.Drawing.Point(224, 348)
        Me.outputLabel1.Name = "outputLabel1"
        Me.outputLabel1.Size = New System.Drawing.Size(224, 55)
        Me.outputLabel1.TabIndex = 4
        Me.outputLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.calcultaeButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.celarButton2
        Me.ClientSize = New System.Drawing.Size(685, 594)
        Me.Controls.Add(Me.outputLabel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.celarButton2)
        Me.Controls.Add(Me.calcultaeButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents calcultaeButton1 As System.Windows.Forms.Button
    Friend WithEvents celarButton2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents manicureCheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents massageCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents hairCheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents twentyRadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents tenRadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents zeroRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents outputLabel1 As System.Windows.Forms.Label

End Class
