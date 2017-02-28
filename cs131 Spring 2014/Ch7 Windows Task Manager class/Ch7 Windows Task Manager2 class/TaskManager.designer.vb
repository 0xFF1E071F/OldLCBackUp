<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskManager
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
        Me.taskListBox = New System.Windows.Forms.ListBox()
        Me.statusListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.endtaskButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'taskListBox
        '
        Me.taskListBox.FormattingEnabled = True
        Me.taskListBox.ItemHeight = 25
        Me.taskListBox.Items.AddRange(New Object() {"Winamp 5.601"})
        Me.taskListBox.Location = New System.Drawing.Point(18, 88)
        Me.taskListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.taskListBox.Name = "taskListBox"
        Me.taskListBox.Size = New System.Drawing.Size(272, 304)
        Me.taskListBox.TabIndex = 0
        '
        'statusListBox
        '
        Me.statusListBox.FormattingEnabled = True
        Me.statusListBox.ItemHeight = 25
        Me.statusListBox.Items.AddRange(New Object() {"Running"})
        Me.statusListBox.Location = New System.Drawing.Point(302, 88)
        Me.statusListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.statusListBox.Name = "statusListBox"
        Me.statusListBox.Size = New System.Drawing.Size(156, 304)
        Me.statusListBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Task"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(302, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Status"
        '
        'endtaskButton
        '
        Me.endtaskButton.Location = New System.Drawing.Point(90, 404)
        Me.endtaskButton.Margin = New System.Windows.Forms.Padding(4)
        Me.endtaskButton.Name = "endtaskButton"
        Me.endtaskButton.Size = New System.Drawing.Size(144, 37)
        Me.endtaskButton.TabIndex = 4
        Me.endtaskButton.Text = "End Task"
        Me.endtaskButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.closeButton.Location = New System.Drawing.Point(276, 404)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(112, 37)
        Me.closeButton.TabIndex = 5
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'TaskManager
        '
        Me.AcceptButton = Me.endtaskButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.closeButton
        Me.ClientSize = New System.Drawing.Size(492, 452)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.endtaskButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.statusListBox)
        Me.Controls.Add(Me.taskListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TaskManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Task Manager"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents taskListBox As System.Windows.Forms.ListBox
    Friend WithEvents statusListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents endtaskButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
End Class
