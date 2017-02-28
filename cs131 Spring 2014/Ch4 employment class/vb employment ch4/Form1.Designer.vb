<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.experienceCheckBox = New System.Windows.Forms.CheckBox()
        Me.yearsTextBox = New System.Windows.Forms.TextBox()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'experienceCheckBox
        '
        Me.experienceCheckBox.AutoSize = True
        Me.experienceCheckBox.Location = New System.Drawing.Point(46, 106)
        Me.experienceCheckBox.Margin = New System.Windows.Forms.Padding(6)
        Me.experienceCheckBox.Name = "experienceCheckBox"
        Me.experienceCheckBox.Size = New System.Drawing.Size(713, 29)
        Me.experienceCheckBox.TabIndex = 0
        Me.experienceCheckBox.Text = "Check here if you have professional social media marketing experience"
        Me.experienceCheckBox.UseVisualStyleBackColor = True
        '
        'yearsTextBox
        '
        Me.yearsTextBox.Location = New System.Drawing.Point(464, 187)
        Me.yearsTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.yearsTextBox.Name = "yearsTextBox"
        Me.yearsTextBox.Size = New System.Drawing.Size(78, 31)
        Me.yearsTextBox.TabIndex = 1
        '
        'outputLabel
        '
        Me.outputLabel.Location = New System.Drawing.Point(144, 265)
        Me.outputLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(446, 138)
        Me.outputLabel.TabIndex = 3
        Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 190)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Years"
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(430, 434)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(150, 44)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'enterButton
        '
        Me.enterButton.Location = New System.Drawing.Point(225, 434)
        Me.enterButton.Margin = New System.Windows.Forms.Padding(6)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(150, 44)
        Me.enterButton.TabIndex = 4
        Me.enterButton.Text = "&Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Miriam", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Application - II Experience"
        '
        'Form1
        '
        Me.AcceptButton = Me.enterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(804, 562)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.yearsTextBox)
        Me.Controls.Add(Me.experienceCheckBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents experienceCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents yearsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents outputLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
