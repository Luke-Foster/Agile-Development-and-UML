<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CancelPurchase = New System.Windows.Forms.Button()
        Me.Pay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(13, 24)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Caged Eggs"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(152, 24)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 1
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(152, 69)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 3
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox2.Location = New System.Drawing.Point(13, 69)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(109, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Free Range Eggs"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(152, 121)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown3.TabIndex = 5
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox3.Location = New System.Drawing.Point(13, 121)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Chicken"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CancelPurchase
        '
        Me.CancelPurchase.Location = New System.Drawing.Point(12, 227)
        Me.CancelPurchase.Name = "CancelPurchase"
        Me.CancelPurchase.Size = New System.Drawing.Size(75, 23)
        Me.CancelPurchase.TabIndex = 6
        Me.CancelPurchase.Text = "Cancel"
        Me.CancelPurchase.UseVisualStyleBackColor = True
        '
        'Pay
        '
        Me.Pay.Location = New System.Drawing.Point(197, 227)
        Me.Pay.Name = "Pay"
        Me.Pay.Size = New System.Drawing.Size(75, 23)
        Me.Pay.TabIndex = 7
        Me.Pay.Text = "Pay"
        Me.Pay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(194, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total:"
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pay)
        Me.Controls.Add(Me.CancelPurchase)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CancelPurchase As Button
    Friend WithEvents Pay As Button
    Friend WithEvents Label1 As Label
End Class
