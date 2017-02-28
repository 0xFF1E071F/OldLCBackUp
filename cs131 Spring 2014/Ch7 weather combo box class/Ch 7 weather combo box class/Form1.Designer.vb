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
        Me.addButton1 = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.insertButton = New System.Windows.Forms.Button()
        Me.location_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Date_ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_content_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.weather_ListBox1 = New System.Windows.Forms.ListBox()
        Me.weather_content_TextBox1 = New System.Windows.Forms.TextBox()
        Me.removeat_Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'addButton1
        '
        Me.addButton1.BackColor = System.Drawing.SystemColors.Control
        Me.addButton1.Location = New System.Drawing.Point(16, 428)
        Me.addButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.addButton1.Name = "addButton1"
        Me.addButton1.Size = New System.Drawing.Size(150, 44)
        Me.addButton1.TabIndex = 3
        Me.addButton1.Text = "Add"
        Me.addButton1.UseVisualStyleBackColor = False
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(209, 428)
        Me.removeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(150, 44)
        Me.removeButton.TabIndex = 4
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'insertButton
        '
        Me.insertButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.insertButton.Location = New System.Drawing.Point(409, 428)
        Me.insertButton.Margin = New System.Windows.Forms.Padding(6)
        Me.insertButton.Name = "insertButton"
        Me.insertButton.Size = New System.Drawing.Size(150, 44)
        Me.insertButton.TabIndex = 5
        Me.insertButton.Text = "Insert"
        Me.insertButton.UseVisualStyleBackColor = False
        '
        'location_TextBox
        '
        Me.location_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.location_TextBox.Location = New System.Drawing.Point(44, 140)
        Me.location_TextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.location_TextBox.Name = "location_TextBox"
        Me.location_TextBox.Size = New System.Drawing.Size(78, 31)
        Me.location_TextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Weather"
        '
        'Date_ListBox1
        '
        Me.Date_ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Date_ListBox1.FormattingEnabled = True
        Me.Date_ListBox1.ItemHeight = 25
        Me.Date_ListBox1.Items.AddRange(New Object() {"August 13th", "October 18th", "November 1st"})
        Me.Date_ListBox1.Location = New System.Drawing.Point(620, 112)
        Me.Date_ListBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Date_ListBox1.Name = "Date_ListBox1"
        Me.Date_ListBox1.Size = New System.Drawing.Size(236, 179)
        Me.Date_ListBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(704, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date"
        '
        'date_content_TextBox1
        '
        Me.date_content_TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.date_content_TextBox1.Location = New System.Drawing.Point(16, 353)
        Me.date_content_TextBox1.Name = "date_content_TextBox1"
        Me.date_content_TextBox1.Size = New System.Drawing.Size(150, 31)
        Me.date_content_TextBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Content"
        '
        'weather_ListBox1
        '
        Me.weather_ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.weather_ListBox1.FormattingEnabled = True
        Me.weather_ListBox1.ItemHeight = 25
        Me.weather_ListBox1.Items.AddRange(New Object() {"Very Hot", "Sunny and Nice", "Getting colder"})
        Me.weather_ListBox1.Location = New System.Drawing.Point(323, 112)
        Me.weather_ListBox1.Name = "weather_ListBox1"
        Me.weather_ListBox1.Size = New System.Drawing.Size(236, 179)
        Me.weather_ListBox1.TabIndex = 6
        '
        'weather_content_TextBox1
        '
        Me.weather_content_TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.weather_content_TextBox1.Location = New System.Drawing.Point(16, 277)
        Me.weather_content_TextBox1.Name = "weather_content_TextBox1"
        Me.weather_content_TextBox1.Size = New System.Drawing.Size(150, 31)
        Me.weather_content_TextBox1.TabIndex = 0
        '
        'removeat_Button1
        '
        Me.removeat_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.removeat_Button1.Location = New System.Drawing.Point(645, 428)
        Me.removeat_Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.removeat_Button1.Name = "removeat_Button1"
        Me.removeat_Button1.Size = New System.Drawing.Size(150, 44)
        Me.removeat_Button1.TabIndex = 12
        Me.removeat_Button1.Text = "Remove at"
        Me.removeat_Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 508)
        Me.Controls.Add(Me.removeat_Button1)
        Me.Controls.Add(Me.weather_content_TextBox1)
        Me.Controls.Add(Me.weather_ListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_content_TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Date_ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.location_TextBox)
        Me.Controls.Add(Me.insertButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather TextBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addButton1 As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents insertButton As System.Windows.Forms.Button
    Friend WithEvents location_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Date_ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents date_content_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents weather_ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents weather_content_TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents removeat_Button1 As System.Windows.Forms.Button

End Class
