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
        Me.membershiptypeBox = New System.Windows.Forms.GroupBox()
        Me.under11RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.studentRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.adultRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.yogaCheckBox3 = New System.Windows.Forms.CheckBox()
        Me.poolCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outputLabel3 = New System.Windows.Forms.Label()
        Me.calculateButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.membershiptypeBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Health Club Calculator"
        '
        'membershiptypeBox
        '
        Me.membershiptypeBox.Controls.Add(Me.under11RadioButton3)
        Me.membershiptypeBox.Controls.Add(Me.studentRadioButton2)
        Me.membershiptypeBox.Controls.Add(Me.adultRadioButton1)
        Me.membershiptypeBox.Location = New System.Drawing.Point(44, 152)
        Me.membershiptypeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.membershiptypeBox.Name = "membershiptypeBox"
        Me.membershiptypeBox.Padding = New System.Windows.Forms.Padding(4)
        Me.membershiptypeBox.Size = New System.Drawing.Size(208, 246)
        Me.membershiptypeBox.TabIndex = 0
        Me.membershiptypeBox.TabStop = False
        Me.membershiptypeBox.Text = "Membership Type"
        '
        'under11RadioButton3
        '
        Me.under11RadioButton3.AutoSize = True
        Me.under11RadioButton3.Location = New System.Drawing.Point(8, 171)
        Me.under11RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.under11RadioButton3.Name = "under11RadioButton3"
        Me.under11RadioButton3.Size = New System.Drawing.Size(124, 29)
        Me.under11RadioButton3.TabIndex = 2
        Me.under11RadioButton3.TabStop = True
        Me.under11RadioButton3.Text = "Under 11 "
        Me.under11RadioButton3.UseVisualStyleBackColor = True
        '
        'studentRadioButton2
        '
        Me.studentRadioButton2.AutoSize = True
        Me.studentRadioButton2.Location = New System.Drawing.Point(8, 112)
        Me.studentRadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.studentRadioButton2.Name = "studentRadioButton2"
        Me.studentRadioButton2.Size = New System.Drawing.Size(104, 29)
        Me.studentRadioButton2.TabIndex = 0
        Me.studentRadioButton2.TabStop = True
        Me.studentRadioButton2.Text = "Student"
        Me.studentRadioButton2.UseVisualStyleBackColor = True
        '
        'adultRadioButton1
        '
        Me.adultRadioButton1.AutoSize = True
        Me.adultRadioButton1.Location = New System.Drawing.Point(8, 52)
        Me.adultRadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.adultRadioButton1.Name = "adultRadioButton1"
        Me.adultRadioButton1.Size = New System.Drawing.Size(172, 29)
        Me.adultRadioButton1.TabIndex = 2
        Me.adultRadioButton1.Text = "Standard Adult"
        Me.adultRadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.yogaCheckBox3)
        Me.GroupBox2.Controls.Add(Me.poolCheckBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 160)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(220, 237)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional activities"
        '
        'yogaCheckBox3
        '
        Me.yogaCheckBox3.AutoSize = True
        Me.yogaCheckBox3.Location = New System.Drawing.Point(28, 131)
        Me.yogaCheckBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.yogaCheckBox3.Name = "yogaCheckBox3"
        Me.yogaCheckBox3.Size = New System.Drawing.Size(82, 29)
        Me.yogaCheckBox3.TabIndex = 2
        Me.yogaCheckBox3.Text = "Yoga"
        Me.yogaCheckBox3.UseVisualStyleBackColor = True
        '
        'poolCheckBox2
        '
        Me.poolCheckBox2.AutoSize = True
        Me.poolCheckBox2.Location = New System.Drawing.Point(28, 69)
        Me.poolCheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.poolCheckBox2.Name = "poolCheckBox2"
        Me.poolCheckBox2.Size = New System.Drawing.Size(74, 29)
        Me.poolCheckBox2.TabIndex = 1
        Me.poolCheckBox2.Text = "Pool"
        Me.poolCheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 467)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Fee"
        '
        'outputLabel3
        '
        Me.outputLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outputLabel3.Location = New System.Drawing.Point(282, 453)
        Me.outputLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.outputLabel3.Name = "outputLabel3"
        Me.outputLabel3.Size = New System.Drawing.Size(138, 52)
        Me.outputLabel3.TabIndex = 5
        Me.outputLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calculateButton1
        '
        Me.calculateButton1.Location = New System.Drawing.Point(162, 537)
        Me.calculateButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.calculateButton1.Name = "calculateButton1"
        Me.calculateButton1.Size = New System.Drawing.Size(112, 37)
        Me.calculateButton1.TabIndex = 3
        Me.calculateButton1.Text = "Calculate"
        Me.calculateButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton2.Location = New System.Drawing.Point(366, 531)
        Me.clearButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(112, 37)
        Me.clearButton2.TabIndex = 6
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton2
        Me.ClientSize = New System.Drawing.Size(592, 594)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.calculateButton1)
        Me.Controls.Add(Me.outputLabel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.membershiptypeBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.membershiptypeBox.ResumeLayout(False)
        Me.membershiptypeBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents membershiptypeBox As System.Windows.Forms.GroupBox
    Friend WithEvents under11RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents studentRadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents adultRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents yogaCheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents poolCheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents outputLabel3 As System.Windows.Forms.Label
    Friend WithEvents calculateButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button

End Class
