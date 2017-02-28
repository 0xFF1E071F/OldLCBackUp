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
        Me.Calculate_Button1 = New System.Windows.Forms.Button()
        Me.Exit_Button2 = New System.Windows.Forms.Button()
        Me.Clear_Button3 = New System.Windows.Forms.Button()
        Me.Song_TextBox = New System.Windows.Forms.TextBox()
        Me.CDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Summary = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calculate_Button1
        '
        Me.Calculate_Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate_Button1.Location = New System.Drawing.Point(40, 595)
        Me.Calculate_Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Calculate_Button1.Name = "Calculate_Button1"
        Me.Calculate_Button1.Size = New System.Drawing.Size(182, 63)
        Me.Calculate_Button1.TabIndex = 6
        Me.Calculate_Button1.Text = "Calculate"
        Me.Calculate_Button1.UseVisualStyleBackColor = True
        '
        'Exit_Button2
        '
        Me.Exit_Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button2.Location = New System.Drawing.Point(231, 595)
        Me.Exit_Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Exit_Button2.Name = "Exit_Button2"
        Me.Exit_Button2.Size = New System.Drawing.Size(182, 63)
        Me.Exit_Button2.TabIndex = 7
        Me.Exit_Button2.Text = "E&xit"
        Me.Exit_Button2.UseVisualStyleBackColor = True
        '
        'Clear_Button3
        '
        Me.Clear_Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Clear_Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear_Button3.Location = New System.Drawing.Point(422, 595)
        Me.Clear_Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Clear_Button3.Name = "Clear_Button3"
        Me.Clear_Button3.Size = New System.Drawing.Size(182, 63)
        Me.Clear_Button3.TabIndex = 8
        Me.Clear_Button3.Text = "Clear"
        Me.Clear_Button3.UseVisualStyleBackColor = True
        '
        'Song_TextBox
        '
        Me.Song_TextBox.Location = New System.Drawing.Point(158, 392)
        Me.Song_TextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Song_TextBox.Name = "Song_TextBox"
        Me.Song_TextBox.Size = New System.Drawing.Size(67, 26)
        Me.Song_TextBox.TabIndex = 0
        '
        'CDTextBox
        '
        Me.CDTextBox.Location = New System.Drawing.Point(562, 392)
        Me.CDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CDTextBox.Name = "CDTextBox"
        Me.CDTextBox.Size = New System.Drawing.Size(67, 26)
        Me.CDTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 463)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Your Cost:"
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.Location = New System.Drawing.Point(320, 463)
        Me.totalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(106, 39)
        Me.totalLabel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 325)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number of Songs?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 325)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Number of CD's?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CH3_Music_Class.My.Resources.Resources.cd_front
        Me.PictureBox2.Location = New System.Drawing.Point(471, 43)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(261, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CH3_Music_Class.My.Resources.Resources.MPR_The_Current_Song_of_the_Day_logo
        Me.PictureBox1.Location = New System.Drawing.Point(82, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(18, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.Summary.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Summary.Location = New System.Drawing.Point(613, 595)
        Me.Summary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(182, 63)
        Me.Summary.TabIndex = 9
        Me.Summary.Text = "Summary"
        Me.Summary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.Calculate_Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Clear_Button3
        Me.ClientSize = New System.Drawing.Size(813, 697)
        Me.Controls.Add(Me.Summary)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CDTextBox)
        Me.Controls.Add(Me.Song_TextBox)
        Me.Controls.Add(Me.Clear_Button3)
        Me.Controls.Add(Me.Exit_Button2)
        Me.Controls.Add(Me.Calculate_Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calculate_Button1 As System.Windows.Forms.Button
    Friend WithEvents Exit_Button2 As System.Windows.Forms.Button
    Friend WithEvents Clear_Button3 As System.Windows.Forms.Button
    Friend WithEvents Song_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Summary As System.Windows.Forms.Button

End Class
