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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AutoGroupBox = New System.Windows.Forms.GroupBox()
        Me.daysTextBox = New System.Windows.Forms.TextBox()
        Me.totalmiTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.outmilagechargeslabel = New System.Windows.Forms.Label()
        Me.totalchargesLabel = New System.Windows.Forms.Label()
        Me.AutoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(12, 415)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 34)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(157, 415)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(120, 34)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Mincho", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Arvin's Auto Rentals"
        '
        'AutoGroupBox
        '
        Me.AutoGroupBox.Controls.Add(Me.daysTextBox)
        Me.AutoGroupBox.Controls.Add(Me.totalmiTextBox)
        Me.AutoGroupBox.Controls.Add(Me.Label10)
        Me.AutoGroupBox.Controls.Add(Me.Label8)
        Me.AutoGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoGroupBox.Location = New System.Drawing.Point(12, 79)
        Me.AutoGroupBox.Name = "AutoGroupBox"
        Me.AutoGroupBox.Size = New System.Drawing.Size(293, 131)
        Me.AutoGroupBox.TabIndex = 0
        Me.AutoGroupBox.TabStop = False
        Me.AutoGroupBox.Text = "Auto"
        '
        'daysTextBox
        '
        Me.daysTextBox.Location = New System.Drawing.Point(188, 93)
        Me.daysTextBox.Name = "daysTextBox"
        Me.daysTextBox.Size = New System.Drawing.Size(100, 31)
        Me.daysTextBox.TabIndex = 5
        '
        'totalmiTextBox
        '
        Me.totalmiTextBox.Location = New System.Drawing.Point(184, 21)
        Me.totalmiTextBox.Name = "totalmiTextBox"
        Me.totalmiTextBox.Size = New System.Drawing.Size(100, 31)
        Me.totalmiTextBox.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Number of Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Milage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Milage Charges"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Charges"
        '
        'outmilagechargeslabel
        '
        Me.outmilagechargeslabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.outmilagechargeslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outmilagechargeslabel.Location = New System.Drawing.Point(495, 100)
        Me.outmilagechargeslabel.Name = "outmilagechargeslabel"
        Me.outmilagechargeslabel.Size = New System.Drawing.Size(100, 31)
        Me.outmilagechargeslabel.TabIndex = 4
        Me.outmilagechargeslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalchargesLabel
        '
        Me.totalchargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalchargesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalchargesLabel.Location = New System.Drawing.Point(495, 172)
        Me.totalchargesLabel.Name = "totalchargesLabel"
        Me.totalchargesLabel.Size = New System.Drawing.Size(100, 31)
        Me.totalchargesLabel.TabIndex = 5
        Me.totalchargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(627, 469)
        Me.Controls.Add(Me.totalchargesLabel)
        Me.Controls.Add(Me.outmilagechargeslabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AutoGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.AutoGroupBox.ResumeLayout(False)
        Me.AutoGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AutoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents outmilagechargeslabel As System.Windows.Forms.Label
    Friend WithEvents totalchargesLabel As System.Windows.Forms.Label
    Friend WithEvents daysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalmiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
