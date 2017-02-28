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
        Me.onedayshipRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.twodayshipRadioButton2 = New System.Windows.Forms.RadioButton()
        Me.stdshipRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.number_of_booksTextBox = New System.Windows.Forms.TextBox()
        Me.kindle_costTextBox = New System.Windows.Forms.TextBox()
        Me.shipping_costTextBox = New System.Windows.Forms.TextBox()
        Me.total_costTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calculateButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.onedayshipRadioButton3)
        Me.GroupBox1.Controls.Add(Me.twodayshipRadioButton2)
        Me.GroupBox1.Controls.Add(Me.stdshipRadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(403, 172)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(227, 210)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Shipping"
        '
        'onedayshipRadioButton3
        '
        Me.onedayshipRadioButton3.AutoSize = True
        Me.onedayshipRadioButton3.Location = New System.Drawing.Point(27, 167)
        Me.onedayshipRadioButton3.Name = "onedayshipRadioButton3"
        Me.onedayshipRadioButton3.Size = New System.Drawing.Size(204, 29)
        Me.onedayshipRadioButton3.TabIndex = 2
        Me.onedayshipRadioButton3.TabStop = True
        Me.onedayshipRadioButton3.Text = "One Day Shipping"
        Me.onedayshipRadioButton3.UseVisualStyleBackColor = True
        '
        'twodayshipRadioButton2
        '
        Me.twodayshipRadioButton2.AutoSize = True
        Me.twodayshipRadioButton2.Location = New System.Drawing.Point(23, 111)
        Me.twodayshipRadioButton2.Name = "twodayshipRadioButton2"
        Me.twodayshipRadioButton2.Size = New System.Drawing.Size(204, 29)
        Me.twodayshipRadioButton2.TabIndex = 1
        Me.twodayshipRadioButton2.TabStop = True
        Me.twodayshipRadioButton2.Text = "Two Day Shipping"
        Me.twodayshipRadioButton2.UseVisualStyleBackColor = True
        '
        'stdshipRadioButton1
        '
        Me.stdshipRadioButton1.AutoSize = True
        Me.stdshipRadioButton1.Location = New System.Drawing.Point(23, 60)
        Me.stdshipRadioButton1.Name = "stdshipRadioButton1"
        Me.stdshipRadioButton1.Size = New System.Drawing.Size(207, 29)
        Me.stdshipRadioButton1.TabIndex = 0
        Me.stdshipRadioButton1.TabStop = True
        Me.stdshipRadioButton1.Text = "Standard Shipping"
        Me.stdshipRadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Dozen"
        '
        'number_of_booksTextBox
        '
        Me.number_of_booksTextBox.Location = New System.Drawing.Point(575, 106)
        Me.number_of_booksTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.number_of_booksTextBox.Name = "number_of_booksTextBox"
        Me.number_of_booksTextBox.Size = New System.Drawing.Size(69, 29)
        Me.number_of_booksTextBox.TabIndex = 3
        '
        'kindle_costTextBox
        '
        Me.kindle_costTextBox.Location = New System.Drawing.Point(97, 444)
        Me.kindle_costTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.kindle_costTextBox.Name = "kindle_costTextBox"
        Me.kindle_costTextBox.Size = New System.Drawing.Size(180, 29)
        Me.kindle_costTextBox.TabIndex = 4
        '
        'shipping_costTextBox
        '
        Me.shipping_costTextBox.Location = New System.Drawing.Point(328, 444)
        Me.shipping_costTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.shipping_costTextBox.Name = "shipping_costTextBox"
        Me.shipping_costTextBox.Size = New System.Drawing.Size(180, 29)
        Me.shipping_costTextBox.TabIndex = 5
        '
        'total_costTextBox
        '
        Me.total_costTextBox.Location = New System.Drawing.Point(560, 439)
        Me.total_costTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.total_costTextBox.Name = "total_costTextBox"
        Me.total_costTextBox.Size = New System.Drawing.Size(180, 29)
        Me.total_costTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Golf BallCost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(342, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Shipping Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Cost"
        '
        'calculateButton1
        '
        Me.calculateButton1.Location = New System.Drawing.Point(135, 494)
        Me.calculateButton1.Name = "calculateButton1"
        Me.calculateButton1.Size = New System.Drawing.Size(124, 55)
        Me.calculateButton1.TabIndex = 10
        Me.calculateButton1.Text = "Calculate"
        Me.calculateButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.Location = New System.Drawing.Point(548, 483)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(124, 55)
        Me.clearButton2.TabIndex = 11
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ch4_Kindle_Class.My.Resources.Resources.AAAADPJBZSwAAAAAAbLFvg
        Me.PictureBox1.Location = New System.Drawing.Point(32, 109)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(299, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 34)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Golf Ball City"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 561)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.calculateButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.total_costTextBox)
        Me.Controls.Add(Me.shipping_costTextBox)
        Me.Controls.Add(Me.kindle_costTextBox)
        Me.Controls.Add(Me.number_of_booksTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents onedayshipRadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents twodayshipRadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents stdshipRadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents number_of_booksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents kindle_costTextBox As System.Windows.Forms.TextBox
    Friend WithEvents shipping_costTextBox As System.Windows.Forms.TextBox
    Friend WithEvents total_costTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents calculateButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
