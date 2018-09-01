<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewProductInfo
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InStockAmount = New System.Windows.Forms.Label()
        Me.ExpiraryDate = New System.Windows.Forms.DateTimePicker()
        Me.PrintInvoice = New System.Windows.Forms.Button()
        Me.ReturnProfileWorker = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Product:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Caged Eggs", "Free Range Eggs", "Chicken"})
        Me.ComboBox1.Location = New System.Drawing.Point(151, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ExpiraryDate)
        Me.GroupBox1.Controls.Add(Me.InStockAmount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 92)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(16, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Currently InStock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(16, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Next Expirary Date"
        '
        'InStockAmount
        '
        Me.InStockAmount.AutoSize = True
        Me.InStockAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InStockAmount.Location = New System.Drawing.Point(175, 19)
        Me.InStockAmount.Name = "InStockAmount"
        Me.InStockAmount.Size = New System.Drawing.Size(13, 13)
        Me.InStockAmount.TabIndex = 2
        Me.InStockAmount.Text = "5"
        '
        'ExpiraryDate
        '
        Me.ExpiraryDate.Location = New System.Drawing.Point(125, 59)
        Me.ExpiraryDate.Name = "ExpiraryDate"
        Me.ExpiraryDate.Size = New System.Drawing.Size(126, 20)
        Me.ExpiraryDate.TabIndex = 3
        '
        'PrintInvoice
        '
        Me.PrintInvoice.Location = New System.Drawing.Point(9, 228)
        Me.PrintInvoice.Name = "PrintInvoice"
        Me.PrintInvoice.Size = New System.Drawing.Size(118, 23)
        Me.PrintInvoice.TabIndex = 16
        Me.PrintInvoice.Text = "Print Product Info"
        Me.PrintInvoice.UseVisualStyleBackColor = True
        '
        'ReturnProfileWorker
        '
        Me.ReturnProfileWorker.Location = New System.Drawing.Point(151, 227)
        Me.ReturnProfileWorker.Name = "ReturnProfileWorker"
        Me.ReturnProfileWorker.Size = New System.Drawing.Size(118, 23)
        Me.ReturnProfileWorker.TabIndex = 15
        Me.ReturnProfileWorker.Text = "Return to Profile"
        Me.ReturnProfileWorker.UseVisualStyleBackColor = True
        '
        'ReviewProductInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PrintInvoice)
        Me.Controls.Add(Me.ReturnProfileWorker)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReviewProductInfo"
        Me.Text = "ReviewProductInfo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExpiraryDate As DateTimePicker
    Friend WithEvents InStockAmount As Label
    Friend WithEvents PrintInvoice As Button
    Friend WithEvents ReturnProfileWorker As Button
End Class
