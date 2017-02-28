<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voting_Form
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
        Me.UConn_RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Florida_RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UConn_RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Florida_RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(130, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(328, 312)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teams"
        '
        'UConn_RadioButton2
        '
        Me.UConn_RadioButton2.AutoSize = True
        Me.UConn_RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UConn_RadioButton2.ForeColor = System.Drawing.Color.Blue
        Me.UConn_RadioButton2.Location = New System.Drawing.Point(52, 156)
        Me.UConn_RadioButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.UConn_RadioButton2.Name = "UConn_RadioButton2"
        Me.UConn_RadioButton2.Size = New System.Drawing.Size(117, 35)
        Me.UConn_RadioButton2.TabIndex = 1
        Me.UConn_RadioButton2.TabStop = True
        Me.UConn_RadioButton2.Text = "UConn"
        Me.UConn_RadioButton2.UseVisualStyleBackColor = True
        '
        'Florida_RadioButton1
        '
        Me.Florida_RadioButton1.AutoSize = True
        Me.Florida_RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Florida_RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Florida_RadioButton1.Location = New System.Drawing.Point(52, 65)
        Me.Florida_RadioButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.Florida_RadioButton1.Name = "Florida_RadioButton1"
        Me.Florida_RadioButton1.Size = New System.Drawing.Size(115, 35)
        Me.Florida_RadioButton1.TabIndex = 0
        Me.Florida_RadioButton1.TabStop = True
        Me.Florida_RadioButton1.Text = "Florida"
        Me.Florida_RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(382, 537)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Results"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Who goes to the Finals?"
        '
        'Voting_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 629)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Voting_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UConn_RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Florida_RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
