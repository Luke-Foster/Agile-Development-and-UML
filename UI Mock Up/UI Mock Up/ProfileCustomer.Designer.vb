<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileCustomer
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
        Me.CustomerChangePasswordButton = New System.Windows.Forms.Button()
        Me.ReviewOrdersButton = New System.Windows.Forms.Button()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.ElectronicReceiptButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CustomerChangePasswordButton
        '
        Me.CustomerChangePasswordButton.Location = New System.Drawing.Point(109, 12)
        Me.CustomerChangePasswordButton.Name = "CustomerChangePasswordButton"
        Me.CustomerChangePasswordButton.Size = New System.Drawing.Size(130, 23)
        Me.CustomerChangePasswordButton.TabIndex = 3
        Me.CustomerChangePasswordButton.Text = "Change Password"
        Me.CustomerChangePasswordButton.UseVisualStyleBackColor = True
        '
        'ReviewOrdersButton
        '
        Me.ReviewOrdersButton.Location = New System.Drawing.Point(109, 78)
        Me.ReviewOrdersButton.Name = "ReviewOrdersButton"
        Me.ReviewOrdersButton.Size = New System.Drawing.Size(130, 23)
        Me.ReviewOrdersButton.TabIndex = 4
        Me.ReviewOrdersButton.Text = "Review/Amend Orders"
        Me.ReviewOrdersButton.UseVisualStyleBackColor = True
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(109, 146)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(130, 23)
        Me.PurchaseButton.TabIndex = 5
        Me.PurchaseButton.Text = "Purchase"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'ElectronicReceiptButton
        '
        Me.ElectronicReceiptButton.Location = New System.Drawing.Point(109, 215)
        Me.ElectronicReceiptButton.Name = "ElectronicReceiptButton"
        Me.ElectronicReceiptButton.Size = New System.Drawing.Size(130, 23)
        Me.ElectronicReceiptButton.TabIndex = 6
        Me.ElectronicReceiptButton.Text = "Electronic Receipt"
        Me.ElectronicReceiptButton.UseVisualStyleBackColor = True
        '
        'ProfileCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(339, 286)
        Me.Controls.Add(Me.ElectronicReceiptButton)
        Me.Controls.Add(Me.PurchaseButton)
        Me.Controls.Add(Me.ReviewOrdersButton)
        Me.Controls.Add(Me.CustomerChangePasswordButton)
        Me.Name = "ProfileCustomer"
        Me.Text = "ProfileCustomer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerChangePasswordButton As Button
    Friend WithEvents ReviewOrdersButton As Button
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents ElectronicReceiptButton As Button
End Class
