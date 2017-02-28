<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listForm1
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
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.User_ListBox1 = New System.Windows.Forms.ListBox()
        Me.Password_ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(209, 348)
        Me.SearchButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(150, 72)
        Me.SearchButton1.TabIndex = 1
        Me.SearchButton1.Text = "Return to logon"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'User_ListBox1
        '
        Me.User_ListBox1.FormattingEnabled = True
        Me.User_ListBox1.ItemHeight = 25
        Me.User_ListBox1.Items.AddRange(New Object() {"NORKO", "WINTER", "SPRING"})
        Me.User_ListBox1.Location = New System.Drawing.Point(78, 65)
        Me.User_ListBox1.Name = "User_ListBox1"
        Me.User_ListBox1.Size = New System.Drawing.Size(120, 179)
        Me.User_ListBox1.TabIndex = 3
        '
        'Password_ListBox2
        '
        Me.Password_ListBox2.FormattingEnabled = True
        Me.Password_ListBox2.ItemHeight = 25
        Me.Password_ListBox2.Items.AddRange(New Object() {"1234", "2345", "3456"})
        Me.Password_ListBox2.Location = New System.Drawing.Point(394, 66)
        Me.Password_ListBox2.Name = "Password_ListBox2"
        Me.Password_ListBox2.Size = New System.Drawing.Size(120, 179)
        Me.Password_ListBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "UserNames"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Passwords"
        '
        'listForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password_ListBox2)
        Me.Controls.Add(Me.User_ListBox1)
        Me.Controls.Add(Me.SearchButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "listForm1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SearchButton1 As System.Windows.Forms.Button
    Friend WithEvents User_ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Password_ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
