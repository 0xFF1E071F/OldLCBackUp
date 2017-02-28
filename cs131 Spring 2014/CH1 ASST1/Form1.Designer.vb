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
        Me.author = New System.Windows.Forms.Label()
        Me.Customer_relations = New System.Windows.Forms.Button()
        Me.Marketing = New System.Windows.Forms.Button()
        Me.Order_processing = New System.Windows.Forms.Button()
        Me.shipping = New System.Windows.Forms.Button()
        Me.de = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.department_contract = New System.Windows.Forms.Label()
        Me.telephone = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Location = New System.Drawing.Point(509, 297)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(35, 13)
        Me.author.TabIndex = 0
        Me.author.Text = "Yu Fu"
        '
        'Customer_relations
        '
        Me.Customer_relations.Location = New System.Drawing.Point(63, 237)
        Me.Customer_relations.Name = "Customer_relations"
        Me.Customer_relations.Size = New System.Drawing.Size(81, 43)
        Me.Customer_relations.TabIndex = 1
        Me.Customer_relations.Text = "Customer Relations"
        Me.Customer_relations.UseVisualStyleBackColor = True
        '
        'Marketing
        '
        Me.Marketing.Location = New System.Drawing.Point(184, 237)
        Me.Marketing.Name = "Marketing"
        Me.Marketing.Size = New System.Drawing.Size(75, 43)
        Me.Marketing.TabIndex = 2
        Me.Marketing.Text = "Marketing"
        Me.Marketing.UseVisualStyleBackColor = True
        '
        'Order_processing
        '
        Me.Order_processing.Location = New System.Drawing.Point(299, 237)
        Me.Order_processing.Name = "Order_processing"
        Me.Order_processing.Size = New System.Drawing.Size(75, 43)
        Me.Order_processing.TabIndex = 3
        Me.Order_processing.Text = "Order Processing"
        Me.Order_processing.UseVisualStyleBackColor = True
        '
        'shipping
        '
        Me.shipping.Location = New System.Drawing.Point(414, 237)
        Me.shipping.Name = "shipping"
        Me.shipping.Size = New System.Drawing.Size(75, 43)
        Me.shipping.TabIndex = 4
        Me.shipping.Text = "Shipping"
        Me.shipping.UseVisualStyleBackColor = True
        '
        'de
        '
        Me.de.Location = New System.Drawing.Point(91, 87)
        Me.de.Name = "de"
        Me.de.Size = New System.Drawing.Size(69, 33)
        Me.de.TabIndex = 5
        Me.de.Text = "Departnebt Contract :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(91, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Telephone Number:"
        '
        'department_contract
        '
        Me.department_contract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.department_contract.Location = New System.Drawing.Point(299, 87)
        Me.department_contract.Name = "department_contract"
        Me.department_contract.Size = New System.Drawing.Size(161, 33)
        Me.department_contract.TabIndex = 7
        Me.department_contract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'telephone
        '
        Me.telephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.telephone.Location = New System.Drawing.Point(299, 152)
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(161, 30)
        Me.telephone.TabIndex = 8
        Me.telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "VB Mail Order"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 319)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.telephone)
        Me.Controls.Add(Me.department_contract)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.de)
        Me.Controls.Add(Me.shipping)
        Me.Controls.Add(Me.Order_processing)
        Me.Controls.Add(Me.Marketing)
        Me.Controls.Add(Me.Customer_relations)
        Me.Controls.Add(Me.author)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents author As System.Windows.Forms.Label
    Friend WithEvents Customer_relations As System.Windows.Forms.Button
    Friend WithEvents Marketing As System.Windows.Forms.Button
    Friend WithEvents Order_processing As System.Windows.Forms.Button
    Friend WithEvents shipping As System.Windows.Forms.Button
    Friend WithEvents de As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents department_contract As System.Windows.Forms.Label
    Friend WithEvents telephone As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
