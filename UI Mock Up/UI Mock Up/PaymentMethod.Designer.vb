<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentMethod
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
        Me.PayPal = New System.Windows.Forms.Button()
        Me.CardPay = New System.Windows.Forms.Button()
        Me.BitCoin = New System.Windows.Forms.Button()
        Me.PayOnDelivery = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PayPal
        '
        Me.PayPal.Location = New System.Drawing.Point(69, 41)
        Me.PayPal.Name = "PayPal"
        Me.PayPal.Size = New System.Drawing.Size(75, 23)
        Me.PayPal.TabIndex = 0
        Me.PayPal.Text = "PayPal"
        Me.PayPal.UseVisualStyleBackColor = True
        '
        'CardPay
        '
        Me.CardPay.Location = New System.Drawing.Point(58, 112)
        Me.CardPay.Name = "CardPay"
        Me.CardPay.Size = New System.Drawing.Size(101, 23)
        Me.CardPay.TabIndex = 1
        Me.CardPay.Text = "Credit/Debit Card"
        Me.CardPay.UseVisualStyleBackColor = True
        '
        'BitCoin
        '
        Me.BitCoin.Location = New System.Drawing.Point(69, 184)
        Me.BitCoin.Name = "BitCoin"
        Me.BitCoin.Size = New System.Drawing.Size(75, 23)
        Me.BitCoin.TabIndex = 2
        Me.BitCoin.Text = "BitCoin"
        Me.BitCoin.UseVisualStyleBackColor = True
        '
        'PayOnDelivery
        '
        Me.PayOnDelivery.Location = New System.Drawing.Point(58, 262)
        Me.PayOnDelivery.Name = "PayOnDelivery"
        Me.PayOnDelivery.Size = New System.Drawing.Size(101, 21)
        Me.PayOnDelivery.TabIndex = 3
        Me.PayOnDelivery.Text = "Pay on Delivery"
        Me.PayOnDelivery.UseVisualStyleBackColor = True
        '
        'PaymentMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(213, 341)
        Me.Controls.Add(Me.PayOnDelivery)
        Me.Controls.Add(Me.BitCoin)
        Me.Controls.Add(Me.CardPay)
        Me.Controls.Add(Me.PayPal)
        Me.Name = "PaymentMethod"
        Me.Text = "PaymentMethod"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PayPal As Button
    Friend WithEvents CardPay As Button
    Friend WithEvents BitCoin As Button
    Friend WithEvents PayOnDelivery As Button
End Class
