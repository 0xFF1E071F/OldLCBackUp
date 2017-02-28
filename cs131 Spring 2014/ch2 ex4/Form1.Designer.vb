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
        Me.Book_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Music_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Periogicals_RadioButton = New System.Windows.Forms.RadioButton()
        Me.coffee_RadioButton = New System.Windows.Forms.RadioButton()
        Me.department_GroupBox = New System.Windows.Forms.GroupBox()
        Me.CheckIN_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Id_TextBox = New System.Windows.Forms.TextBox()
        Me.Signin_Button = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Image_CheckBox = New System.Windows.Forms.CheckBox()
        Me.output_label = New System.Windows.Forms.Label()
        Me.info_label = New System.Windows.Forms.Label()
        Me.department_GroupBox.SuspendLayout()
        Me.CheckIN_GroupBox.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Book_RadioButton
        '
        Me.Book_RadioButton.AutoSize = True
        Me.Book_RadioButton.Location = New System.Drawing.Point(26, 41)
        Me.Book_RadioButton.Name = "Book_RadioButton"
        Me.Book_RadioButton.Size = New System.Drawing.Size(55, 17)
        Me.Book_RadioButton.TabIndex = 0
        Me.Book_RadioButton.TabStop = True
        Me.Book_RadioButton.Text = "Books"
        Me.Book_RadioButton.UseVisualStyleBackColor = True
        '
        'Music_RadioButton
        '
        Me.Music_RadioButton.AutoSize = True
        Me.Music_RadioButton.Location = New System.Drawing.Point(26, 74)
        Me.Music_RadioButton.Name = "Music_RadioButton"
        Me.Music_RadioButton.Size = New System.Drawing.Size(53, 17)
        Me.Music_RadioButton.TabIndex = 1
        Me.Music_RadioButton.TabStop = True
        Me.Music_RadioButton.Text = "Music"
        Me.Music_RadioButton.UseVisualStyleBackColor = True
        '
        'Periogicals_RadioButton
        '
        Me.Periogicals_RadioButton.AutoSize = True
        Me.Periogicals_RadioButton.Location = New System.Drawing.Point(26, 107)
        Me.Periogicals_RadioButton.Name = "Periogicals_RadioButton"
        Me.Periogicals_RadioButton.Size = New System.Drawing.Size(76, 17)
        Me.Periogicals_RadioButton.TabIndex = 2
        Me.Periogicals_RadioButton.TabStop = True
        Me.Periogicals_RadioButton.Text = "Periogicals"
        Me.Periogicals_RadioButton.UseVisualStyleBackColor = True
        '
        'coffee_RadioButton
        '
        Me.coffee_RadioButton.AutoSize = True
        Me.coffee_RadioButton.Location = New System.Drawing.Point(26, 140)
        Me.coffee_RadioButton.Name = "coffee_RadioButton"
        Me.coffee_RadioButton.Size = New System.Drawing.Size(75, 17)
        Me.coffee_RadioButton.TabIndex = 3
        Me.coffee_RadioButton.TabStop = True
        Me.coffee_RadioButton.Text = "Coffee Bar"
        Me.coffee_RadioButton.UseVisualStyleBackColor = True
        '
        'department_GroupBox
        '
        Me.department_GroupBox.Controls.Add(Me.Music_RadioButton)
        Me.department_GroupBox.Controls.Add(Me.coffee_RadioButton)
        Me.department_GroupBox.Controls.Add(Me.Book_RadioButton)
        Me.department_GroupBox.Controls.Add(Me.Periogicals_RadioButton)
        Me.department_GroupBox.Enabled = False
        Me.department_GroupBox.Location = New System.Drawing.Point(24, 38)
        Me.department_GroupBox.Name = "department_GroupBox"
        Me.department_GroupBox.Size = New System.Drawing.Size(200, 189)
        Me.department_GroupBox.TabIndex = 3
        Me.department_GroupBox.TabStop = False
        Me.department_GroupBox.Text = "Department"
        '
        'CheckIN_GroupBox
        '
        Me.CheckIN_GroupBox.Controls.Add(Me.Id_TextBox)
        Me.CheckIN_GroupBox.Controls.Add(Me.Name_TextBox)
        Me.CheckIN_GroupBox.Controls.Add(Me.Label2)
        Me.CheckIN_GroupBox.Controls.Add(Me.Label1)
        Me.CheckIN_GroupBox.Location = New System.Drawing.Point(275, 38)
        Me.CheckIN_GroupBox.Name = "CheckIN_GroupBox"
        Me.CheckIN_GroupBox.Size = New System.Drawing.Size(353, 189)
        Me.CheckIN_GroupBox.TabIndex = 0
        Me.CheckIN_GroupBox.TabStop = False
        Me.CheckIN_GroupBox.Text = "Elite Member Check In"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Member ID:"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(141, 61)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(146, 20)
        Me.Name_TextBox.TabIndex = 2
        '
        'Id_TextBox
        '
        Me.Id_TextBox.Location = New System.Drawing.Point(141, 91)
        Me.Id_TextBox.Name = "Id_TextBox"
        Me.Id_TextBox.Size = New System.Drawing.Size(146, 20)
        Me.Id_TextBox.TabIndex = 3
        '
        'Signin_Button
        '
        Me.Signin_Button.Location = New System.Drawing.Point(500, 333)
        Me.Signin_Button.Name = "Signin_Button"
        Me.Signin_Button.Size = New System.Drawing.Size(75, 23)
        Me.Signin_Button.TabIndex = 1
        Me.Signin_Button.Text = "Sign In"
        Me.Signin_Button.UseVisualStyleBackColor = True
        '
        'exit_Button
        '
        Me.exit_Button.Location = New System.Drawing.Point(500, 384)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.exit_Button.TabIndex = 5
        Me.exit_Button.Text = "&Exit"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Location = New System.Drawing.Point(24, 243)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(200, 164)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 6
        Me.PictureBox.TabStop = False
        Me.PictureBox.Visible = False
        '
        'Image_CheckBox
        '
        Me.Image_CheckBox.AutoCheck = False
        Me.Image_CheckBox.AutoSize = True
        Me.Image_CheckBox.Enabled = False
        Me.Image_CheckBox.Location = New System.Drawing.Point(306, 390)
        Me.Image_CheckBox.Name = "Image_CheckBox"
        Me.Image_CheckBox.Size = New System.Drawing.Size(88, 17)
        Me.Image_CheckBox.TabIndex = 4
        Me.Image_CheckBox.Text = "Image Visible"
        Me.Image_CheckBox.UseVisualStyleBackColor = True
        '
        'output_label
        '
        Me.output_label.BackColor = System.Drawing.Color.White
        Me.output_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output_label.Location = New System.Drawing.Point(275, 253)
        Me.output_label.Name = "output_label"
        Me.output_label.Size = New System.Drawing.Size(353, 47)
        Me.output_label.TabIndex = 2
        Me.output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'info_label
        '
        Me.info_label.BackColor = System.Drawing.Color.White
        Me.info_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.info_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_label.Location = New System.Drawing.Point(24, 431)
        Me.info_label.Name = "info_label"
        Me.info_label.Size = New System.Drawing.Size(240, 31)
        Me.info_label.TabIndex = 7
        Me.info_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info_label.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 487)
        Me.Controls.Add(Me.info_label)
        Me.Controls.Add(Me.output_label)
        Me.Controls.Add(Me.Image_CheckBox)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.CheckIN_GroupBox)
        Me.Controls.Add(Me.Signin_Button)
        Me.Controls.Add(Me.department_GroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.department_GroupBox.ResumeLayout(False)
        Me.department_GroupBox.PerformLayout()
        Me.CheckIN_GroupBox.ResumeLayout(False)
        Me.CheckIN_GroupBox.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Book_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Music_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Periogicals_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents coffee_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents department_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CheckIN_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Id_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Signin_Button As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Image_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents output_label As System.Windows.Forms.Label
    Friend WithEvents info_label As System.Windows.Forms.Label

End Class
