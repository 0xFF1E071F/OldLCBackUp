<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vote
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
        Me.uconnraidobutton = New System.Windows.Forms.RadioButton()
        Me.floridaradiobutton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.uconnraidobutton)
        Me.GroupBox1.Controls.Add(Me.floridaradiobutton)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 214)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Teams"
        '
        'uconnraidobutton
        '
        Me.uconnraidobutton.AutoSize = True
        Me.uconnraidobutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uconnraidobutton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.uconnraidobutton.Location = New System.Drawing.Point(79, 119)
        Me.uconnraidobutton.Name = "uconnraidobutton"
        Me.uconnraidobutton.Size = New System.Drawing.Size(100, 33)
        Me.uconnraidobutton.TabIndex = 1
        Me.uconnraidobutton.TabStop = True
        Me.uconnraidobutton.Text = "uconn"
        Me.uconnraidobutton.UseVisualStyleBackColor = True
        '
        'floridaradiobutton
        '
        Me.floridaradiobutton.AutoSize = True
        Me.floridaradiobutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.floridaradiobutton.ForeColor = System.Drawing.Color.Chartreuse
        Me.floridaradiobutton.Location = New System.Drawing.Point(79, 58)
        Me.floridaradiobutton.Name = "floridaradiobutton"
        Me.floridaradiobutton.Size = New System.Drawing.Size(100, 33)
        Me.floridaradiobutton.TabIndex = 0
        Me.floridaradiobutton.TabStop = True
        Me.floridaradiobutton.Text = "florida"
        Me.floridaradiobutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Who goes to the finals?"
        '
        'resultButton
        '
        Me.resultButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.resultButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultButton.ForeColor = System.Drawing.SystemColors.Info
        Me.resultButton.Location = New System.Drawing.Point(311, 358)
        Me.resultButton.Name = "resultButton"
        Me.resultButton.Size = New System.Drawing.Size(92, 43)
        Me.resultButton.TabIndex = 2
        Me.resultButton.Text = "result"
        Me.resultButton.UseVisualStyleBackColor = False
        '
        'vote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 435)
        Me.Controls.Add(Me.resultButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "vote"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents uconnraidobutton As System.Windows.Forms.RadioButton
    Friend WithEvents floridaradiobutton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents resultButton As System.Windows.Forms.Button

End Class
