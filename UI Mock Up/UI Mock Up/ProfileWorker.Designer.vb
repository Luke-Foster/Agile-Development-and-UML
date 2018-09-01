<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileWorker
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
        Me.ReviewProduct = New System.Windows.Forms.Button()
        Me.FarmerChangePassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReviewProduct
        '
        Me.ReviewProduct.Location = New System.Drawing.Point(77, 160)
        Me.ReviewProduct.Name = "ReviewProduct"
        Me.ReviewProduct.Size = New System.Drawing.Size(130, 23)
        Me.ReviewProduct.TabIndex = 3
        Me.ReviewProduct.Text = "Review Product Info"
        Me.ReviewProduct.UseVisualStyleBackColor = True
        '
        'FarmerChangePassword
        '
        Me.FarmerChangePassword.Location = New System.Drawing.Point(77, 80)
        Me.FarmerChangePassword.Name = "FarmerChangePassword"
        Me.FarmerChangePassword.Size = New System.Drawing.Size(130, 23)
        Me.FarmerChangePassword.TabIndex = 2
        Me.FarmerChangePassword.Text = "Change Password"
        Me.FarmerChangePassword.UseVisualStyleBackColor = True
        '
        'ProfileWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ReviewProduct)
        Me.Controls.Add(Me.FarmerChangePassword)
        Me.Name = "ProfileWorker"
        Me.Text = "ProfileWorker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReviewProduct As Button
    Friend WithEvents FarmerChangePassword As Button
End Class
