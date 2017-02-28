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
        Me.Signin_group = New System.Windows.Forms.GroupBox()
        Me.submit_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FormColor_GroupBox = New System.Windows.Forms.GroupBox()
        Me.FormColor_Gray = New System.Windows.Forms.RadioButton()
        Me.FormColor_Yellow = New System.Windows.Forms.RadioButton()
        Me.FormColor_Blue = New System.Windows.Forms.RadioButton()
        Me.FormColor_Beige = New System.Windows.Forms.RadioButton()
        Me.visiable_color_box = New System.Windows.Forms.CheckBox()
        Me.TextColor_GroupBox = New System.Windows.Forms.GroupBox()
        Me.TextColor_White = New System.Windows.Forms.RadioButton()
        Me.TextColor_black = New System.Windows.Forms.RadioButton()
        Me.exit_botton = New System.Windows.Forms.Button()
        Me.author = New System.Windows.Forms.Label()
        Me.Signin_group.SuspendLayout()
        Me.FormColor_GroupBox.SuspendLayout()
        Me.TextColor_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Signin_group
        '
        Me.Signin_group.Controls.Add(Me.submit_Button)
        Me.Signin_group.Controls.Add(Me.Label2)
        Me.Signin_group.Controls.Add(Me.Label1)
        Me.Signin_group.Controls.Add(Me.TextBox2)
        Me.Signin_group.Controls.Add(Me.TextBox1)
        Me.Signin_group.Location = New System.Drawing.Point(240, 86)
        Me.Signin_group.Name = "Signin_group"
        Me.Signin_group.Size = New System.Drawing.Size(200, 127)
        Me.Signin_group.TabIndex = 0
        Me.Signin_group.TabStop = False
        Me.Signin_group.Text = "Sign In"
        '
        'submit_Button
        '
        Me.submit_Button.Location = New System.Drawing.Point(93, 98)
        Me.submit_Button.Name = "submit_Button"
        Me.submit_Button.Size = New System.Drawing.Size(75, 23)
        Me.submit_Button.TabIndex = 4
        Me.submit_Button.Text = "&Submit "
        Me.submit_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'FormColor_GroupBox
        '
        Me.FormColor_GroupBox.Controls.Add(Me.FormColor_Gray)
        Me.FormColor_GroupBox.Controls.Add(Me.FormColor_Yellow)
        Me.FormColor_GroupBox.Controls.Add(Me.FormColor_Blue)
        Me.FormColor_GroupBox.Controls.Add(Me.FormColor_Beige)
        Me.FormColor_GroupBox.Enabled = False
        Me.FormColor_GroupBox.Location = New System.Drawing.Point(26, 35)
        Me.FormColor_GroupBox.Name = "FormColor_GroupBox"
        Me.FormColor_GroupBox.Size = New System.Drawing.Size(200, 132)
        Me.FormColor_GroupBox.TabIndex = 2
        Me.FormColor_GroupBox.TabStop = False
        Me.FormColor_GroupBox.Text = "Select Form Color"
        Me.FormColor_GroupBox.Visible = False
        '
        'FormColor_Gray
        '
        Me.FormColor_Gray.AutoSize = True
        Me.FormColor_Gray.Location = New System.Drawing.Point(19, 97)
        Me.FormColor_Gray.Name = "FormColor_Gray"
        Me.FormColor_Gray.Size = New System.Drawing.Size(47, 17)
        Me.FormColor_Gray.TabIndex = 3
        Me.FormColor_Gray.TabStop = True
        Me.FormColor_Gray.Text = "&Gray"
        Me.FormColor_Gray.UseVisualStyleBackColor = True
        '
        'FormColor_Yellow
        '
        Me.FormColor_Yellow.AutoSize = True
        Me.FormColor_Yellow.Location = New System.Drawing.Point(19, 74)
        Me.FormColor_Yellow.Name = "FormColor_Yellow"
        Me.FormColor_Yellow.Size = New System.Drawing.Size(56, 17)
        Me.FormColor_Yellow.TabIndex = 2
        Me.FormColor_Yellow.TabStop = True
        Me.FormColor_Yellow.Text = "&Yellow"
        Me.FormColor_Yellow.UseVisualStyleBackColor = True
        '
        'FormColor_Blue
        '
        Me.FormColor_Blue.AutoSize = True
        Me.FormColor_Blue.Location = New System.Drawing.Point(19, 51)
        Me.FormColor_Blue.Name = "FormColor_Blue"
        Me.FormColor_Blue.Size = New System.Drawing.Size(46, 17)
        Me.FormColor_Blue.TabIndex = 1
        Me.FormColor_Blue.TabStop = True
        Me.FormColor_Blue.Text = "B&lue"
        Me.FormColor_Blue.UseVisualStyleBackColor = True
        '
        'FormColor_Beige
        '
        Me.FormColor_Beige.AutoSize = True
        Me.FormColor_Beige.Location = New System.Drawing.Point(19, 28)
        Me.FormColor_Beige.Name = "FormColor_Beige"
        Me.FormColor_Beige.Size = New System.Drawing.Size(52, 17)
        Me.FormColor_Beige.TabIndex = 0
        Me.FormColor_Beige.TabStop = True
        Me.FormColor_Beige.Text = "&Beige"
        Me.FormColor_Beige.UseVisualStyleBackColor = True
        '
        'visiable_color_box
        '
        Me.visiable_color_box.AutoSize = True
        Me.visiable_color_box.Checked = True
        Me.visiable_color_box.CheckState = System.Windows.Forms.CheckState.Checked
        Me.visiable_color_box.Enabled = False
        Me.visiable_color_box.Location = New System.Drawing.Point(26, 12)
        Me.visiable_color_box.Name = "visiable_color_box"
        Me.visiable_color_box.Size = New System.Drawing.Size(110, 17)
        Me.visiable_color_box.TabIndex = 1
        Me.visiable_color_box.Text = "&Visiable Color Box"
        Me.visiable_color_box.UseVisualStyleBackColor = True
        '
        'TextColor_GroupBox
        '
        Me.TextColor_GroupBox.Controls.Add(Me.TextColor_White)
        Me.TextColor_GroupBox.Controls.Add(Me.TextColor_black)
        Me.TextColor_GroupBox.Enabled = False
        Me.TextColor_GroupBox.Location = New System.Drawing.Point(26, 173)
        Me.TextColor_GroupBox.Name = "TextColor_GroupBox"
        Me.TextColor_GroupBox.Size = New System.Drawing.Size(200, 141)
        Me.TextColor_GroupBox.TabIndex = 2
        Me.TextColor_GroupBox.TabStop = False
        Me.TextColor_GroupBox.Text = "Select Text Color"
        '
        'TextColor_White
        '
        Me.TextColor_White.AutoSize = True
        Me.TextColor_White.Location = New System.Drawing.Point(19, 58)
        Me.TextColor_White.Name = "TextColor_White"
        Me.TextColor_White.Size = New System.Drawing.Size(53, 17)
        Me.TextColor_White.TabIndex = 1
        Me.TextColor_White.Text = "&White"
        Me.TextColor_White.UseVisualStyleBackColor = True
        '
        'TextColor_black
        '
        Me.TextColor_black.AutoSize = True
        Me.TextColor_black.Checked = True
        Me.TextColor_black.Location = New System.Drawing.Point(19, 35)
        Me.TextColor_black.Name = "TextColor_black"
        Me.TextColor_black.Size = New System.Drawing.Size(52, 17)
        Me.TextColor_black.TabIndex = 0
        Me.TextColor_black.TabStop = True
        Me.TextColor_black.Text = "Blac&k"
        Me.TextColor_black.UseVisualStyleBackColor = True
        '
        'exit_botton
        '
        Me.exit_botton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exit_botton.Location = New System.Drawing.Point(288, 291)
        Me.exit_botton.Name = "exit_botton"
        Me.exit_botton.Size = New System.Drawing.Size(75, 23)
        Me.exit_botton.TabIndex = 3
        Me.exit_botton.Text = "E&xit"
        Me.exit_botton.UseVisualStyleBackColor = True
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Location = New System.Drawing.Point(405, 301)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(35, 13)
        Me.author.TabIndex = 6
        Me.author.Text = "Yu Fu"
        '
        'Form1
        '
        Me.AcceptButton = Me.submit_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exit_botton
        Me.ClientSize = New System.Drawing.Size(464, 330)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.exit_botton)
        Me.Controls.Add(Me.TextColor_GroupBox)
        Me.Controls.Add(Me.visiable_color_box)
        Me.Controls.Add(Me.FormColor_GroupBox)
        Me.Controls.Add(Me.Signin_group)
        Me.Name = "Form1"
        Me.Text = "Change Colors"
        Me.Signin_group.ResumeLayout(False)
        Me.Signin_group.PerformLayout()
        Me.FormColor_GroupBox.ResumeLayout(False)
        Me.FormColor_GroupBox.PerformLayout()
        Me.TextColor_GroupBox.ResumeLayout(False)
        Me.TextColor_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Signin_group As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FormColor_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents visiable_color_box As System.Windows.Forms.CheckBox
    Friend WithEvents submit_Button As System.Windows.Forms.Button
    Friend WithEvents FormColor_Yellow As System.Windows.Forms.RadioButton
    Friend WithEvents FormColor_Blue As System.Windows.Forms.RadioButton
    Friend WithEvents FormColor_Beige As System.Windows.Forms.RadioButton
    Friend WithEvents FormColor_Gray As System.Windows.Forms.RadioButton
    Friend WithEvents TextColor_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TextColor_White As System.Windows.Forms.RadioButton
    Friend WithEvents TextColor_black As System.Windows.Forms.RadioButton
    Friend WithEvents exit_botton As System.Windows.Forms.Button
    Friend WithEvents author As System.Windows.Forms.Label

End Class
