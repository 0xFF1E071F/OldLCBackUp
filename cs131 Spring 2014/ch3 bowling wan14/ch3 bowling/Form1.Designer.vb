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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shoerentalTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gamesTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.calcButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.total_cost_Label4 = New System.Windows.Forms.Label()
        Me.summary_Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ch3_bowling.My.Resources.Resources.amf_bowling
        Me.PictureBox1.Location = New System.Drawing.Point(238, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 225)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shoe Rentals"
        '
        'shoerentalTextBox1
        '
        Me.shoerentalTextBox1.Location = New System.Drawing.Point(163, 222)
        Me.shoerentalTextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.shoerentalTextBox1.Name = "shoerentalTextBox1"
        Me.shoerentalTextBox1.Size = New System.Drawing.Size(196, 31)
        Me.shoerentalTextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(417, 225)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Games"
        '
        'gamesTextBox2
        '
        Me.gamesTextBox2.Location = New System.Drawing.Point(524, 222)
        Me.gamesTextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.gamesTextBox2.Name = "gamesTextBox2"
        Me.gamesTextBox2.Size = New System.Drawing.Size(196, 31)
        Me.gamesTextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 293)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cutomer Total is:"
        '
        'calcButton1
        '
        Me.calcButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calcButton1.Location = New System.Drawing.Point(44, 411)
        Me.calcButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.calcButton1.Name = "calcButton1"
        Me.calcButton1.Size = New System.Drawing.Size(150, 44)
        Me.calcButton1.TabIndex = 4
        Me.calcButton1.Text = "Calculate "
        Me.calcButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton2.Location = New System.Drawing.Point(298, 411)
        Me.clearButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(150, 44)
        Me.clearButton2.TabIndex = 7
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'total_cost_Label4
        '
        Me.total_cost_Label4.AutoSize = True
        Me.total_cost_Label4.Location = New System.Drawing.Point(397, 293)
        Me.total_cost_Label4.Name = "total_cost_Label4"
        Me.total_cost_Label4.Size = New System.Drawing.Size(0, 25)
        Me.total_cost_Label4.TabIndex = 6
        '
        'summary_Button1
        '
        Me.summary_Button1.Location = New System.Drawing.Point(548, 412)
        Me.summary_Button1.Name = "summary_Button1"
        Me.summary_Button1.Size = New System.Drawing.Size(150, 44)
        Me.summary_Button1.TabIndex = 8
        Me.summary_Button1.Text = "&Summary"
        Me.summary_Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.calcButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton2
        Me.ClientSize = New System.Drawing.Size(770, 498)
        Me.Controls.Add(Me.summary_Button1)
        Me.Controls.Add(Me.total_cost_Label4)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.calcButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gamesTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.shoerentalTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bowling Program"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents shoerentalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gamesTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents calcButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button
    Friend WithEvents total_cost_Label4 As System.Windows.Forms.Label
    Friend WithEvents summary_Button1 As System.Windows.Forms.Button

End Class
