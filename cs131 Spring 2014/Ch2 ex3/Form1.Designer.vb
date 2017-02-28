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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.British_RadioButton = New System.Windows.Forms.RadioButton()
        Me.canda_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Japan_RadioButton = New System.Windows.Forms.RadioButton()
        Me.us_RadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.find_botton = New System.Windows.Forms.Button()
        Me.exit_botton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.output_label = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.programmer_label = New System.Windows.Forms.Label()
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox()
        Me.CountryCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.British_RadioButton)
        Me.GroupBox1.Controls.Add(Me.canda_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Japan_RadioButton)
        Me.GroupBox1.Controls.Add(Me.us_RadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 132)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Country"
        '
        'British_RadioButton
        '
        Me.British_RadioButton.AutoSize = True
        Me.British_RadioButton.Location = New System.Drawing.Point(33, 96)
        Me.British_RadioButton.Name = "British_RadioButton"
        Me.British_RadioButton.Size = New System.Drawing.Size(53, 17)
        Me.British_RadioButton.TabIndex = 1
        Me.British_RadioButton.TabStop = True
        Me.British_RadioButton.Text = "British"
        Me.British_RadioButton.UseVisualStyleBackColor = True
        '
        'canda_RadioButton
        '
        Me.canda_RadioButton.AutoSize = True
        Me.canda_RadioButton.Location = New System.Drawing.Point(33, 74)
        Me.canda_RadioButton.Name = "canda_RadioButton"
        Me.canda_RadioButton.Size = New System.Drawing.Size(56, 17)
        Me.canda_RadioButton.TabIndex = 1
        Me.canda_RadioButton.TabStop = True
        Me.canda_RadioButton.Text = "Canda"
        Me.canda_RadioButton.UseVisualStyleBackColor = True
        '
        'Japan_RadioButton
        '
        Me.Japan_RadioButton.AutoSize = True
        Me.Japan_RadioButton.Location = New System.Drawing.Point(33, 52)
        Me.Japan_RadioButton.Name = "Japan_RadioButton"
        Me.Japan_RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Japan_RadioButton.TabIndex = 1
        Me.Japan_RadioButton.TabStop = True
        Me.Japan_RadioButton.Text = "Japan"
        Me.Japan_RadioButton.UseVisualStyleBackColor = True
        '
        'us_RadioButton
        '
        Me.us_RadioButton.AutoSize = True
        Me.us_RadioButton.Location = New System.Drawing.Point(33, 30)
        Me.us_RadioButton.Name = "us_RadioButton"
        Me.us_RadioButton.Size = New System.Drawing.Size(89, 17)
        Me.us_RadioButton.TabIndex = 1
        Me.us_RadioButton.TabStop = True
        Me.us_RadioButton.Text = "United States"
        Me.us_RadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgrammerCheckBox)
        Me.GroupBox2.Controls.Add(Me.CountryCheckBox)
        Me.GroupBox2.Controls.Add(Me.TitleCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(384, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 132)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display"
        '
        'find_botton
        '
        Me.find_botton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.find_botton.Location = New System.Drawing.Point(373, 298)
        Me.find_botton.Name = "find_botton"
        Me.find_botton.Size = New System.Drawing.Size(75, 23)
        Me.find_botton.TabIndex = 2
        Me.find_botton.Text = "&Find"
        Me.find_botton.UseVisualStyleBackColor = True
        '
        'exit_botton
        '
        Me.exit_botton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exit_botton.Location = New System.Drawing.Point(466, 298)
        Me.exit_botton.Name = "exit_botton"
        Me.exit_botton.Size = New System.Drawing.Size(75, 23)
        Me.exit_botton.TabIndex = 4
        Me.exit_botton.Text = "E&xit"
        Me.exit_botton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(213, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'output_label
        '
        Me.output_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.output_label.Location = New System.Drawing.Point(213, 214)
        Me.output_label.Name = "output_label"
        Me.output_label.Size = New System.Drawing.Size(157, 23)
        Me.output_label.TabIndex = 5
        Me.output_label.Visible = False
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(210, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(160, 40)
        Me.Title.TabIndex = 6
        Me.Title.Text = "Flag Viewer"
        Me.Title.Visible = False
        '
        'programmer_label
        '
        Me.programmer_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.programmer_label.Location = New System.Drawing.Point(42, 279)
        Me.programmer_label.Name = "programmer_label"
        Me.programmer_label.Size = New System.Drawing.Size(157, 23)
        Me.programmer_label.TabIndex = 6
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Location = New System.Drawing.Point(25, 30)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(46, 17)
        Me.TitleCheckBox.TabIndex = 0
        Me.TitleCheckBox.Text = "Title"
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'CountryCheckBox
        '
        Me.CountryCheckBox.AutoSize = True
        Me.CountryCheckBox.Location = New System.Drawing.Point(25, 53)
        Me.CountryCheckBox.Name = "CountryCheckBox"
        Me.CountryCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.CountryCheckBox.TabIndex = 1
        Me.CountryCheckBox.Text = "Country Name"
        Me.CountryCheckBox.UseVisualStyleBackColor = True
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(25, 76)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.ProgrammerCheckBox.TabIndex = 2
        Me.ProgrammerCheckBox.Text = "Programmer"
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.find_botton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exit_botton
        Me.ClientSize = New System.Drawing.Size(577, 372)
        Me.Controls.Add(Me.programmer_label)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.output_label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exit_botton)
        Me.Controls.Add(Me.find_botton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents find_botton As System.Windows.Forms.Button
    Friend WithEvents exit_botton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents output_label As System.Windows.Forms.Label
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents programmer_label As System.Windows.Forms.Label
    Friend WithEvents British_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents canda_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Japan_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents us_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox

End Class
