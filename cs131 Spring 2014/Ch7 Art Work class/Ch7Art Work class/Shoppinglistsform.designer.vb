<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shoppinglistsform
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
        Me.artworkListBox = New System.Windows.Forms.ListBox()
        Me.priceListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.totalcostLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'artworkListBox
        '
        Me.artworkListBox.FormattingEnabled = True
        Me.artworkListBox.Location = New System.Drawing.Point(18, 77)
        Me.artworkListBox.Name = "artworkListBox"
        Me.artworkListBox.Size = New System.Drawing.Size(155, 147)
        Me.artworkListBox.TabIndex = 0
        '
        'priceListBox
        '
        Me.priceListBox.FormattingEnabled = True
        Me.priceListBox.Location = New System.Drawing.Point(186, 77)
        Me.priceListBox.Name = "priceListBox"
        Me.priceListBox.Size = New System.Drawing.Size(94, 147)
        Me.priceListBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selected Work"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "You have selected the following items.  Please check carefully before pressing th" & _
    "e ""Buy"" button"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 31)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Click on an ART WORK and then the ""Delete"" button to delete it"
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(205, 319)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteButton.TabIndex = 6
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total Cost of items  is"
        '
        'totalcostLabel
        '
        Me.totalcostLabel.AutoSize = True
        Me.totalcostLabel.Location = New System.Drawing.Point(152, 266)
        Me.totalcostLabel.Name = "totalcostLabel"
        Me.totalcostLabel.Size = New System.Drawing.Size(0, 13)
        Me.totalcostLabel.TabIndex = 8
        '
        'Shoppinglistsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 374)
        Me.Controls.Add(Me.totalcostLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.priceListBox)
        Me.Controls.Add(Me.artworkListBox)
        Me.Name = "Shoppinglistsform"
        Me.Text = "Shoppinglistsform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents artworkListBox As System.Windows.Forms.ListBox
    Friend WithEvents priceListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents totalcostLabel As System.Windows.Forms.Label
End Class
