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
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.inweeksTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.outperpersoncostTextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.outtotalcostTextBox5 = New System.Windows.Forms.TextBox()
        Me.outinitiationfeeTextBox6 = New System.Windows.Forms.TextBox()
        Me.summaryButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip5 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Waive_CheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(51, 317)
        Me.calculateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(122, 36)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.calculateButton, "Click to get result of Total fees")
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(262, 317)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(122, 36)
        Me.clearButton.TabIndex = 6
        Me.clearButton.Text = "Clea&r"
        Me.ToolTip2.SetToolTip(Me.clearButton, "Click to clean all type in")
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'inweeksTextBox1
        '
        Me.inweeksTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.inweeksTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inweeksTextBox1.Location = New System.Drawing.Point(228, 107)
        Me.inweeksTextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.inweeksTextBox1.Name = "inweeksTextBox1"
        Me.inweeksTextBox1.Size = New System.Drawing.Size(47, 31)
        Me.inweeksTextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number of Weeks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(295, 38)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Olympic Health Club"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Per Person Cost"
        Me.ToolTip5.SetToolTip(Me.Label5, "The weekly fees are $20")
        '
        'outperpersoncostTextBox4
        '
        Me.outperpersoncostTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outperpersoncostTextBox4.Location = New System.Drawing.Point(481, 151)
        Me.outperpersoncostTextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.outperpersoncostTextBox4.Name = "outperpersoncostTextBox4"
        Me.outperpersoncostTextBox4.Size = New System.Drawing.Size(99, 31)
        Me.outperpersoncostTextBox4.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 209)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 25)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "+  Initiation Fee"
        Me.ToolTip4.SetToolTip(Me.Label6, "initation Fee should be $50 each")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(287, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total Cost "
        '
        'outtotalcostTextBox5
        '
        Me.outtotalcostTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outtotalcostTextBox5.Location = New System.Drawing.Point(481, 252)
        Me.outtotalcostTextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.outtotalcostTextBox5.Name = "outtotalcostTextBox5"
        Me.outtotalcostTextBox5.Size = New System.Drawing.Size(99, 31)
        Me.outtotalcostTextBox5.TabIndex = 1
        '
        'outinitiationfeeTextBox6
        '
        Me.outinitiationfeeTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outinitiationfeeTextBox6.Location = New System.Drawing.Point(481, 202)
        Me.outinitiationfeeTextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.outinitiationfeeTextBox6.Name = "outinitiationfeeTextBox6"
        Me.outinitiationfeeTextBox6.Size = New System.Drawing.Size(99, 31)
        Me.outinitiationfeeTextBox6.TabIndex = 1
        '
        'summaryButton
        '
        Me.summaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryButton.Location = New System.Drawing.Point(459, 317)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(176, 70)
        Me.summaryButton.TabIndex = 7
        Me.summaryButton.Text = "Manager's &Summary"
        Me.ToolTip3.SetToolTip(Me.summaryButton, "Click to get Manager Summary")
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'Waive_CheckBox
        '
        Me.Waive_CheckBox.AutoSize = True
        Me.Waive_CheckBox.Location = New System.Drawing.Point(50, 252)
        Me.Waive_CheckBox.Name = "Waive_CheckBox"
        Me.Waive_CheckBox.Size = New System.Drawing.Size(144, 17)
        Me.Waive_CheckBox.TabIndex = 11
        Me.Waive_CheckBox.Text = "Waive the Initiantion Fee"
        Me.Waive_CheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ch3_Health_Club.Resources.friends_running_in_health_club
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(646, 398)
        Me.Controls.Add(Me.Waive_CheckBox)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.outinitiationfeeTextBox6)
        Me.Controls.Add(Me.outtotalcostTextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.outperpersoncostTextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inweeksTextBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents outperpersoncostTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents outtotalcostTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents outinitiationfeeTextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip5 As System.Windows.Forms.ToolTip
    Friend WithEvents Waive_CheckBox As System.Windows.Forms.CheckBox

End Class
