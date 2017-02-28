<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_form
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
        Me.inweeksTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.outtotalcostTextBox5 = New System.Windows.Forms.TextBox()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.manager_Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(68, 390)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(163, 44)
        Me.calculateButton.TabIndex = 4
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(349, 390)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(163, 44)
        Me.clearButton.TabIndex = 5
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'inweeksTextBox1
        '
        Me.inweeksTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inweeksTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inweeksTextBox1.Location = New System.Drawing.Point(304, 132)
        Me.inweeksTextBox1.Name = "inweeksTextBox1"
        Me.inweeksTextBox1.Size = New System.Drawing.Size(62, 31)
        Me.inweeksTextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Number of Weeks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 38)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Olympic Health Club"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(342, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Cost "
        '
        'outtotalcostTextBox5
        '
        Me.outtotalcostTextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.outtotalcostTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outtotalcostTextBox5.Location = New System.Drawing.Point(570, 221)
        Me.outtotalcostTextBox5.Name = "outtotalcostTextBox5"
        Me.outtotalcostTextBox5.Size = New System.Drawing.Size(130, 31)
        Me.outtotalcostTextBox5.TabIndex = 14
        '
        'summaryButton
        '
        Me.summaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton.Location = New System.Drawing.Point(612, 390)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(235, 86)
        Me.summaryButton.TabIndex = 15
        Me.summaryButton.Text = "Manager's &Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'manager_Label2
        '
        Me.manager_Label2.BackColor = System.Drawing.Color.Transparent
        Me.manager_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manager_Label2.ForeColor = System.Drawing.Color.Yellow
        Me.manager_Label2.Location = New System.Drawing.Point(127, 293)
        Me.manager_Label2.Name = "manager_Label2"
        Me.manager_Label2.Size = New System.Drawing.Size(573, 34)
        Me.manager_Label2.TabIndex = 16
        Me.manager_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Purchase_form
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ch3_Health_Club.Resources.friends_running_in_health_club
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(861, 480)
        Me.Controls.Add(Me.manager_Label2)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.outtotalcostTextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inweeksTextBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Purchase_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents inweeksTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents outtotalcostTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents manager_Label2 As System.Windows.Forms.Label

End Class
