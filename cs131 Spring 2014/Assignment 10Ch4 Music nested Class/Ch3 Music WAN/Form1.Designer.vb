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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.SONGTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.summaryButton2 = New System.Windows.Forms.Button()
        Me.qualifyButton3 = New System.Windows.Forms.Button()
        Me.premium_member_CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.member_code_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Enabled = False
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(79, 339)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(113, 49)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Enabled = False
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(261, 339)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(99, 49)
        Me.clearButton.TabIndex = 9
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ch3_Music_WAN.My.Resources.Resources.MPR_The_Current_Song_of_the_Day_logo
        Me.PictureBox1.Location = New System.Drawing.Point(443, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number of songs?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Your Cost: "
        '
        'OutputLabel
        '
        Me.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OutputLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputLabel.Location = New System.Drawing.Point(210, 255)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(437, 64)
        Me.OutputLabel.TabIndex = 6
        Me.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SONGTextBox
        '
        Me.SONGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SONGTextBox.Location = New System.Drawing.Point(488, 210)
        Me.SONGTextBox.Name = "SONGTextBox"
        Me.SONGTextBox.Size = New System.Drawing.Size(45, 29)
        Me.SONGTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(420, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'summaryButton2
        '
        Me.summaryButton2.Enabled = False
        Me.summaryButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton2.Location = New System.Drawing.Point(584, 339)
        Me.summaryButton2.Name = "summaryButton2"
        Me.summaryButton2.Size = New System.Drawing.Size(113, 49)
        Me.summaryButton2.TabIndex = 11
        Me.summaryButton2.Text = "&Summary"
        Me.summaryButton2.UseVisualStyleBackColor = True
        '
        'qualifyButton3
        '
        Me.qualifyButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualifyButton3.Location = New System.Drawing.Point(21, 160)
        Me.qualifyButton3.Name = "qualifyButton3"
        Me.qualifyButton3.Size = New System.Drawing.Size(119, 49)
        Me.qualifyButton3.TabIndex = 3
        Me.qualifyButton3.Text = "&Qualified? "
        Me.qualifyButton3.UseVisualStyleBackColor = True
        '
        'premium_member_CheckBox1
        '
        Me.premium_member_CheckBox1.AutoSize = True
        Me.premium_member_CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.premium_member_CheckBox1.Location = New System.Drawing.Point(21, 22)
        Me.premium_member_CheckBox1.Name = "premium_member_CheckBox1"
        Me.premium_member_CheckBox1.Size = New System.Drawing.Size(242, 28)
        Me.premium_member_CheckBox1.TabIndex = 0
        Me.premium_member_CheckBox1.Text = "Premium Member, check"
        Me.premium_member_CheckBox1.UseVisualStyleBackColor = True
        '
        'member_code_TextBox1
        '
        Me.member_code_TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.member_code_TextBox1.Location = New System.Drawing.Point(40, 101)
        Me.member_code_TextBox1.Name = "member_code_TextBox1"
        Me.member_code_TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.member_code_TextBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Enter member code"
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(740, 433)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.member_code_TextBox1)
        Me.Controls.Add(Me.premium_member_CheckBox1)
        Me.Controls.Add(Me.qualifyButton3)
        Me.Controls.Add(Me.summaryButton2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SONGTextBox)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISCOUNT MUSIC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents SONGTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents summaryButton2 As System.Windows.Forms.Button
    Friend WithEvents qualifyButton3 As System.Windows.Forms.Button
    Friend WithEvents premium_member_CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents member_code_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
