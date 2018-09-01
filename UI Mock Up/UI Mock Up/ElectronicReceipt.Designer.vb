<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectronicReceipt
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
        Me.ReturnProfileCustomer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'ReturnProfileCustomer
        '
        Me.ReturnProfileCustomer.Location = New System.Drawing.Point(132, 268)
        Me.ReturnProfileCustomer.Name = "ReturnProfileCustomer"
        Me.ReturnProfileCustomer.Size = New System.Drawing.Size(118, 23)
        Me.ReturnProfileCustomer.TabIndex = 28
        Me.ReturnProfileCustomer.Text = "Return to Profile"
        Me.ReturnProfileCustomer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(58, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Data:"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(61, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(260, 227)
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ElectronicReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(383, 346)
        Me.Controls.Add(Me.ReturnProfileCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ElectronicReceipt"
        Me.Text = "ElectronicReceipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReturnProfileCustomer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListView1 As ListView
End Class
