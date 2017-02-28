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
        Me.Color_Group_Box = New System.Windows.Forms.GroupBox()
        Me.BLUE = New System.Windows.Forms.RadioButton()
        Me.RED = New System.Windows.Forms.RadioButton()
        Me.output_label = New System.Windows.Forms.Label()
        Me.Visiable_checkbox = New System.Windows.Forms.CheckBox()
        Me.input_TextBox = New System.Windows.Forms.TextBox()
        Me.Show_botton = New System.Windows.Forms.Button()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.Label()
        Me.log_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Log_botton = New System.Windows.Forms.Button()
        Me.Color_Group_Box.SuspendLayout()
        Me.log_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Color_Group_Box
        '
        Me.Color_Group_Box.Controls.Add(Me.BLUE)
        Me.Color_Group_Box.Controls.Add(Me.RED)
        Me.Color_Group_Box.Enabled = False
        Me.Color_Group_Box.Location = New System.Drawing.Point(63, 40)
        Me.Color_Group_Box.Name = "Color_Group_Box"
        Me.Color_Group_Box.Size = New System.Drawing.Size(200, 128)
        Me.Color_Group_Box.TabIndex = 2
        Me.Color_Group_Box.TabStop = False
        Me.Color_Group_Box.Text = "Color"
        '
        'BLUE
        '
        Me.BLUE.AutoSize = True
        Me.BLUE.Location = New System.Drawing.Point(26, 79)
        Me.BLUE.Name = "BLUE"
        Me.BLUE.Size = New System.Drawing.Size(53, 17)
        Me.BLUE.TabIndex = 1
        Me.BLUE.Text = "BLUE"
        Me.BLUE.UseVisualStyleBackColor = True
        '
        'RED
        '
        Me.RED.AutoSize = True
        Me.RED.Location = New System.Drawing.Point(26, 34)
        Me.RED.Name = "RED"
        Me.RED.Size = New System.Drawing.Size(48, 17)
        Me.RED.TabIndex = 1
        Me.RED.Text = "RED"
        Me.RED.UseVisualStyleBackColor = True
        '
        'output_label
        '
        Me.output_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.output_label.Location = New System.Drawing.Point(311, 52)
        Me.output_label.Name = "output_label"
        Me.output_label.Size = New System.Drawing.Size(204, 116)
        Me.output_label.TabIndex = 3
        Me.output_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Visiable_checkbox
        '
        Me.Visiable_checkbox.AutoSize = True
        Me.Visiable_checkbox.Checked = True
        Me.Visiable_checkbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Visiable_checkbox.Location = New System.Drawing.Point(63, 202)
        Me.Visiable_checkbox.Name = "Visiable_checkbox"
        Me.Visiable_checkbox.Size = New System.Drawing.Size(140, 17)
        Me.Visiable_checkbox.TabIndex = 2
        Me.Visiable_checkbox.Text = "Visiable When Checked"
        Me.Visiable_checkbox.UseVisualStyleBackColor = True
        '
        'input_TextBox
        '
        Me.input_TextBox.Enabled = False
        Me.input_TextBox.Location = New System.Drawing.Point(273, 261)
        Me.input_TextBox.Name = "input_TextBox"
        Me.input_TextBox.Size = New System.Drawing.Size(242, 20)
        Me.input_TextBox.TabIndex = 0
        '
        'Show_botton
        '
        Me.Show_botton.Enabled = False
        Me.Show_botton.Location = New System.Drawing.Point(163, 341)
        Me.Show_botton.Name = "Show_botton"
        Me.Show_botton.Size = New System.Drawing.Size(75, 39)
        Me.Show_botton.TabIndex = 1
        Me.Show_botton.Text = "Show the Massage"
        Me.Show_botton.UseVisualStyleBackColor = True
        '
        'exit_Button
        '
        Me.exit_Button.Location = New System.Drawing.Point(341, 341)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(75, 39)
        Me.exit_Button.TabIndex = 4
        Me.exit_Button.Text = "Exit"
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(153, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Messgae Goes Here :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Output:"
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Location = New System.Drawing.Point(518, 387)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(35, 13)
        Me.Author.TabIndex = 6
        Me.Author.Text = "Yu Fu"
        '
        'log_GroupBox
        '
        Me.log_GroupBox.Controls.Add(Me.Label4)
        Me.log_GroupBox.Controls.Add(Me.Label3)
        Me.log_GroupBox.Controls.Add(Me.TextBox2)
        Me.log_GroupBox.Controls.Add(Me.TextBox1)
        Me.log_GroupBox.Controls.Add(Me.Log_botton)
        Me.log_GroupBox.Location = New System.Drawing.Point(596, 149)
        Me.log_GroupBox.Name = "log_GroupBox"
        Me.log_GroupBox.Size = New System.Drawing.Size(200, 132)
        Me.log_GroupBox.TabIndex = 7
        Me.log_GroupBox.TabStop = False
        Me.log_GroupBox.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Passcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "User"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Log_botton
        '
        Me.Log_botton.Location = New System.Drawing.Point(69, 96)
        Me.Log_botton.Name = "Log_botton"
        Me.Log_botton.Size = New System.Drawing.Size(75, 23)
        Me.Log_botton.TabIndex = 0
        Me.Log_botton.Text = "Log on"
        Me.Log_botton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 418)
        Me.Controls.Add(Me.log_GroupBox)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.Show_botton)
        Me.Controls.Add(Me.input_TextBox)
        Me.Controls.Add(Me.Visiable_checkbox)
        Me.Controls.Add(Me.output_label)
        Me.Controls.Add(Me.Color_Group_Box)
        Me.Name = "Form1"
        Me.Color_Group_Box.ResumeLayout(False)
        Me.Color_Group_Box.PerformLayout()
        Me.log_GroupBox.ResumeLayout(False)
        Me.log_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Color_Group_Box As System.Windows.Forms.GroupBox
    Friend WithEvents BLUE As System.Windows.Forms.RadioButton
    Friend WithEvents RED As System.Windows.Forms.RadioButton
    Friend WithEvents output_label As System.Windows.Forms.Label
    Friend WithEvents Visiable_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents input_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Show_botton As System.Windows.Forms.Button
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Author As System.Windows.Forms.Label
    Friend WithEvents log_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Log_botton As System.Windows.Forms.Button

End Class
