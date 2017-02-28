<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.passwordTextBox2 = New System.Windows.Forms.TextBox()
        Me.registerButton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Unername"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Password"
        '
        'usernameTextBox1
        '
        Me.usernameTextBox1.Location = New System.Drawing.Point(324, 81)
        Me.usernameTextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.usernameTextBox1.Name = "usernameTextBox1"
        Me.usernameTextBox1.Size = New System.Drawing.Size(196, 31)
        Me.usernameTextBox1.TabIndex = 2
        '
        'passwordTextBox2
        '
        Me.passwordTextBox2.Location = New System.Drawing.Point(306, 206)
        Me.passwordTextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.passwordTextBox2.Name = "passwordTextBox2"
        Me.passwordTextBox2.Size = New System.Drawing.Size(196, 31)
        Me.passwordTextBox2.TabIndex = 3
        '
        'registerButton1
        '
        Me.registerButton1.Location = New System.Drawing.Point(217, 402)
        Me.registerButton1.Name = "registerButton1"
        Me.registerButton1.Size = New System.Drawing.Size(127, 49)
        Me.registerButton1.TabIndex = 4
        Me.registerButton1.Text = "Register"
        Me.registerButton1.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AcceptButton = Me.registerButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.registerButton1)
        Me.Controls.Add(Me.passwordTextBox2)
        Me.Controls.Add(Me.usernameTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents passwordTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents registerButton1 As System.Windows.Forms.Button
End Class
