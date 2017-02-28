<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Me.startmenuListBox = New System.Windows.Forms.ListBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startmenuListBox
        '
        Me.startmenuListBox.FormattingEnabled = True
        Me.startmenuListBox.ItemHeight = 25
        Me.startmenuListBox.Items.AddRange(New Object() {"Pandora Radio", "Turbo Tax 2013", "Google Chrome", "Microsoft Word", "Skype", "Microsoft Visual Studio"})
        Me.startmenuListBox.Location = New System.Drawing.Point(24, 25)
        Me.startmenuListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.startmenuListBox.Name = "startmenuListBox"
        Me.startmenuListBox.Size = New System.Drawing.Size(246, 304)
        Me.startmenuListBox.TabIndex = 0
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(88, 344)
        Me.startButton.Margin = New System.Windows.Forms.Padding(4)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(112, 37)
        Me.startButton.TabIndex = 1
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'StartMenu
        '
        Me.AcceptButton = Me.startButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 398)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.startmenuListBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StartMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startmenuListBox As System.Windows.Forms.ListBox
    Friend WithEvents startButton As System.Windows.Forms.Button

End Class
