<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summaryForm
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
        Me.total_ticket_Label3 = New System.Windows.Forms.Label()
        Me.total_sale_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Ticket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total sale"
        '
        'total_ticket_Label3
        '
        Me.total_ticket_Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total_ticket_Label3.Location = New System.Drawing.Point(140, 74)
        Me.total_ticket_Label3.Name = "total_ticket_Label3"
        Me.total_ticket_Label3.Size = New System.Drawing.Size(100, 23)
        Me.total_ticket_Label3.TabIndex = 2
        '
        'total_sale_Label
        '
        Me.total_sale_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total_sale_Label.Location = New System.Drawing.Point(140, 135)
        Me.total_sale_Label.Name = "total_sale_Label"
        Me.total_sale_Label.Size = New System.Drawing.Size(100, 24)
        Me.total_sale_Label.TabIndex = 3
        '
        'summaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 217)
        Me.Controls.Add(Me.total_sale_Label)
        Me.Controls.Add(Me.total_ticket_Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "summaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents total_ticket_Label3 As System.Windows.Forms.Label
    Friend WithEvents total_sale_Label As System.Windows.Forms.Label
End Class
