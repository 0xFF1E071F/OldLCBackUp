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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gradeTextBox1 = New System.Windows.Forms.TextBox()
        Me.messageLabel2 = New System.Windows.Forms.Label()
        Me.DisplayButton1 = New System.Windows.Forms.Button()
        Me.clearButton2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grade"
        '
        'gradeTextBox1
        '
        Me.gradeTextBox1.Location = New System.Drawing.Point(302, 60)
        Me.gradeTextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.gradeTextBox1.Name = "gradeTextBox1"
        Me.gradeTextBox1.Size = New System.Drawing.Size(62, 31)
        Me.gradeTextBox1.TabIndex = 1
        '
        'messageLabel2
        '
        Me.messageLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageLabel2.Location = New System.Drawing.Point(120, 187)
        Me.messageLabel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.messageLabel2.Name = "messageLabel2"
        Me.messageLabel2.Size = New System.Drawing.Size(326, 81)
        Me.messageLabel2.TabIndex = 2
        Me.messageLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayButton1
        '
        Me.DisplayButton1.Location = New System.Drawing.Point(100, 363)
        Me.DisplayButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.DisplayButton1.Name = "DisplayButton1"
        Me.DisplayButton1.Size = New System.Drawing.Size(150, 44)
        Me.DisplayButton1.TabIndex = 3
        Me.DisplayButton1.Text = "Display"
        Me.DisplayButton1.UseVisualStyleBackColor = True
        '
        'clearButton2
        '
        Me.clearButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton2.Location = New System.Drawing.Point(320, 362)
        Me.clearButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.clearButton2.Name = "clearButton2"
        Me.clearButton2.Size = New System.Drawing.Size(150, 44)
        Me.clearButton2.TabIndex = 4
        Me.clearButton2.Text = "Clear"
        Me.clearButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.DisplayButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton2
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.clearButton2)
        Me.Controls.Add(Me.DisplayButton1)
        Me.Controls.Add(Me.messageLabel2)
        Me.Controls.Add(Me.gradeTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gradeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents messageLabel2 As System.Windows.Forms.Label
    Friend WithEvents DisplayButton1 As System.Windows.Forms.Button
    Friend WithEvents clearButton2 As System.Windows.Forms.Button

End Class
