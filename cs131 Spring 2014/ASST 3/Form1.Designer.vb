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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.print_Button = New System.Windows.Forms.Button()
        Me.exit_Button = New System.Windows.Forms.Button()
        Me.out_Label = New System.Windows.Forms.Label()
        Me.ColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.greenRadioButton = New System.Windows.Forms.RadioButton()
        Me.redRadioButton = New System.Windows.Forms.RadioButton()
        Me.blueRadioButton = New System.Windows.Forms.RadioButton()
        Me.blackRadioButton = New System.Windows.Forms.RadioButton()
        Me.name_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Black_RadioButton = New System.Windows.Forms.RadioButton()
        Me.blue_RadioButton = New System.Windows.Forms.RadioButton()
        Me.red_RadioButton = New System.Windows.Forms.RadioButton()
        Me.green_RadioButton = New System.Windows.Forms.RadioButton()
        Me.lightonPictureBox = New System.Windows.Forms.PictureBox()
        Me.lightoffPictureBox = New System.Windows.Forms.PictureBox()
        Me.Color_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorGroupBox.SuspendLayout()
        CType(Me.lightonPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightoffPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Color_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'print_Button
        '
        Me.print_Button.Location = New System.Drawing.Point(297, 319)
        Me.print_Button.Name = "print_Button"
        Me.print_Button.Size = New System.Drawing.Size(75, 23)
        Me.print_Button.TabIndex = 0
        Me.print_Button.Text = "&Print"
        Me.ToolTip4.SetToolTip(Me.print_Button, "Click to print")
        Me.print_Button.UseVisualStyleBackColor = True
        '
        'exit_Button
        '
        Me.exit_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exit_Button.Location = New System.Drawing.Point(436, 319)
        Me.exit_Button.Name = "exit_Button"
        Me.exit_Button.Size = New System.Drawing.Size(75, 23)
        Me.exit_Button.TabIndex = 1
        Me.exit_Button.Text = "&Exit"
        Me.ToolTip3.SetToolTip(Me.exit_Button, "Click to exit")
        Me.exit_Button.UseVisualStyleBackColor = True
        '
        'out_Label
        '
        Me.out_Label.BackColor = System.Drawing.Color.White
        Me.out_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.out_Label.Location = New System.Drawing.Point(297, 273)
        Me.out_Label.Name = "out_Label"
        Me.out_Label.Size = New System.Drawing.Size(214, 23)
        Me.out_Label.TabIndex = 2
        Me.out_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.out_Label.Visible = False
        '
        'ColorGroupBox
        '
        Me.ColorGroupBox.Controls.Add(Me.greenRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.redRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.blueRadioButton)
        Me.ColorGroupBox.Controls.Add(Me.blackRadioButton)
        Me.ColorGroupBox.Enabled = False
        Me.ColorGroupBox.Location = New System.Drawing.Point(33, 65)
        Me.ColorGroupBox.Name = "ColorGroupBox"
        Me.ColorGroupBox.Size = New System.Drawing.Size(200, 188)
        Me.ColorGroupBox.TabIndex = 3
        Me.ColorGroupBox.TabStop = False
        Me.ColorGroupBox.Text = "Choose a color"
        '
        'greenRadioButton
        '
        Me.greenRadioButton.AutoSize = True
        Me.greenRadioButton.Location = New System.Drawing.Point(15, 157)
        Me.greenRadioButton.Name = "greenRadioButton"
        Me.greenRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.greenRadioButton.TabIndex = 3
        Me.greenRadioButton.TabStop = True
        Me.greenRadioButton.Text = "&Green"
        Me.greenRadioButton.UseVisualStyleBackColor = True
        '
        'redRadioButton
        '
        Me.redRadioButton.AutoSize = True
        Me.redRadioButton.Location = New System.Drawing.Point(15, 114)
        Me.redRadioButton.Name = "redRadioButton"
        Me.redRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.redRadioButton.TabIndex = 2
        Me.redRadioButton.TabStop = True
        Me.redRadioButton.Text = "&Red"
        Me.redRadioButton.UseVisualStyleBackColor = True
        '
        'blueRadioButton
        '
        Me.blueRadioButton.AutoSize = True
        Me.blueRadioButton.Location = New System.Drawing.Point(15, 71)
        Me.blueRadioButton.Name = "blueRadioButton"
        Me.blueRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.blueRadioButton.TabIndex = 1
        Me.blueRadioButton.TabStop = True
        Me.blueRadioButton.Text = "&Blue"
        Me.blueRadioButton.UseVisualStyleBackColor = True
        '
        'blackRadioButton
        '
        Me.blackRadioButton.AutoSize = True
        Me.blackRadioButton.Location = New System.Drawing.Point(15, 28)
        Me.blackRadioButton.Name = "blackRadioButton"
        Me.blackRadioButton.Size = New System.Drawing.Size(52, 17)
        Me.blackRadioButton.TabIndex = 0
        Me.blackRadioButton.TabStop = True
        Me.blackRadioButton.Text = "B&lack"
        Me.blackRadioButton.UseVisualStyleBackColor = True
        '
        'name_TextBox
        '
        Me.name_TextBox.Location = New System.Drawing.Point(309, 39)
        Me.name_TextBox.Name = "name_TextBox"
        Me.name_TextBox.Size = New System.Drawing.Size(202, 20)
        Me.name_TextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "name:"
        '
        'Black_RadioButton
        '
        Me.Black_RadioButton.AutoSize = True
        Me.Black_RadioButton.Location = New System.Drawing.Point(30, 31)
        Me.Black_RadioButton.Name = "Black_RadioButton"
        Me.Black_RadioButton.Size = New System.Drawing.Size(52, 17)
        Me.Black_RadioButton.TabIndex = 0
        Me.Black_RadioButton.TabStop = True
        Me.Black_RadioButton.Text = "Black"
        Me.Black_RadioButton.UseVisualStyleBackColor = True
        '
        'blue_RadioButton
        '
        Me.blue_RadioButton.AutoSize = True
        Me.blue_RadioButton.Location = New System.Drawing.Point(30, 73)
        Me.blue_RadioButton.Name = "blue_RadioButton"
        Me.blue_RadioButton.Size = New System.Drawing.Size(46, 17)
        Me.blue_RadioButton.TabIndex = 1
        Me.blue_RadioButton.TabStop = True
        Me.blue_RadioButton.Text = "Blue"
        Me.blue_RadioButton.UseVisualStyleBackColor = True
        '
        'red_RadioButton
        '
        Me.red_RadioButton.AutoSize = True
        Me.red_RadioButton.Location = New System.Drawing.Point(30, 115)
        Me.red_RadioButton.Name = "red_RadioButton"
        Me.red_RadioButton.Size = New System.Drawing.Size(45, 17)
        Me.red_RadioButton.TabIndex = 2
        Me.red_RadioButton.TabStop = True
        Me.red_RadioButton.Text = "Red"
        Me.red_RadioButton.UseVisualStyleBackColor = True
        '
        'green_RadioButton
        '
        Me.green_RadioButton.AutoSize = True
        Me.green_RadioButton.Location = New System.Drawing.Point(30, 157)
        Me.green_RadioButton.Name = "green_RadioButton"
        Me.green_RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.green_RadioButton.TabIndex = 3
        Me.green_RadioButton.TabStop = True
        Me.green_RadioButton.Text = "Green"
        Me.green_RadioButton.UseVisualStyleBackColor = True
        '
        'lightonPictureBox
        '
        Me.lightonPictureBox.Image = CType(resources.GetObject("lightonPictureBox.Image"), System.Drawing.Image)
        Me.lightonPictureBox.Location = New System.Drawing.Point(345, 65)
        Me.lightonPictureBox.Name = "lightonPictureBox"
        Me.lightonPictureBox.Size = New System.Drawing.Size(132, 200)
        Me.lightonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightonPictureBox.TabIndex = 6
        Me.lightonPictureBox.TabStop = False
        Me.ToolTip2.SetToolTip(Me.lightonPictureBox, "Click light to Turn Off")
        Me.lightonPictureBox.Visible = False
        '
        'lightoffPictureBox
        '
        Me.lightoffPictureBox.Image = CType(resources.GetObject("lightoffPictureBox.Image"), System.Drawing.Image)
        Me.lightoffPictureBox.Location = New System.Drawing.Point(345, 65)
        Me.lightoffPictureBox.Name = "lightoffPictureBox"
        Me.lightoffPictureBox.Size = New System.Drawing.Size(132, 200)
        Me.lightoffPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lightoffPictureBox.TabIndex = 7
        Me.lightoffPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lightoffPictureBox, "Click light to Turn On")
        Me.lightoffPictureBox.Visible = False
        '
        'Color_GroupBox
        '
        Me.Color_GroupBox.Controls.Add(Me.green_RadioButton)
        Me.Color_GroupBox.Controls.Add(Me.red_RadioButton)
        Me.Color_GroupBox.Controls.Add(Me.blue_RadioButton)
        Me.Color_GroupBox.Controls.Add(Me.Black_RadioButton)
        Me.Color_GroupBox.Location = New System.Drawing.Point(40, 39)
        Me.Color_GroupBox.Name = "Color_GroupBox"
        Me.Color_GroupBox.Size = New System.Drawing.Size(200, 205)
        Me.Color_GroupBox.TabIndex = 3
        Me.Color_GroupBox.TabStop = False
        Me.Color_GroupBox.Text = "Choose a color"
        '
        'ToolTip1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Programmer: Yu Fu"
        '
        'Form1
        '
        Me.AcceptButton = Me.print_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exit_Button
        Me.ClientSize = New System.Drawing.Size(530, 355)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lightoffPictureBox)
        Me.Controls.Add(Me.lightonPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name_TextBox)
        Me.Controls.Add(Me.ColorGroupBox)
        Me.Controls.Add(Me.out_Label)
        Me.Controls.Add(Me.exit_Button)
        Me.Controls.Add(Me.print_Button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ColorGroupBox.ResumeLayout(False)
        Me.ColorGroupBox.PerformLayout()
        CType(Me.lightonPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightoffPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Color_GroupBox.ResumeLayout(False)
        Me.Color_GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents print_Button As System.Windows.Forms.Button
    Friend WithEvents exit_Button As System.Windows.Forms.Button
    Friend WithEvents out_Label As System.Windows.Forms.Label
    Friend WithEvents ColorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents green_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents red_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blue_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Black_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents lightonPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lightoffPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Color_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents greenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents redRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blueRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents blackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip

End Class
