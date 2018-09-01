<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileFarmer
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
        Me.FarmerChangePassword = New System.Windows.Forms.Button()
        Me.GenerateInvoice = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FarmerChangePassword
        '
        Me.FarmerChangePassword.Location = New System.Drawing.Point(68, 36)
        Me.FarmerChangePassword.Name = "FarmerChangePassword"
        Me.FarmerChangePassword.Size = New System.Drawing.Size(130, 23)
        Me.FarmerChangePassword.TabIndex = 0
        Me.FarmerChangePassword.Text = "Change Password"
        Me.FarmerChangePassword.UseVisualStyleBackColor = True
        '
        'GenerateInvoice
        '
        Me.GenerateInvoice.Location = New System.Drawing.Point(68, 116)
        Me.GenerateInvoice.Name = "GenerateInvoice"
        Me.GenerateInvoice.Size = New System.Drawing.Size(130, 23)
        Me.GenerateInvoice.TabIndex = 1
        Me.GenerateInvoice.Text = "Generate Invoice"
        Me.GenerateInvoice.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "View Money due/paid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProfileFarmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GenerateInvoice)
        Me.Controls.Add(Me.FarmerChangePassword)
        Me.Name = "ProfileFarmer"
        Me.Text = "ProfileFarmer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FarmerChangePassword As Button
    Friend WithEvents GenerateInvoice As Button
    Friend WithEvents Button1 As Button
End Class
