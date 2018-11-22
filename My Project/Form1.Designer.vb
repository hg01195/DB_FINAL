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
        Me.ProductsButton = New System.Windows.Forms.Button()
        Me.ServicesButton = New System.Windows.Forms.Button()
        Me.RewardsProgramButton = New System.Windows.Forms.Button()
        Me.AccountInformationButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProductsButton
        '
        Me.ProductsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProductsButton.Location = New System.Drawing.Point(114, 63)
        Me.ProductsButton.Name = "ProductsButton"
        Me.ProductsButton.Size = New System.Drawing.Size(150, 75)
        Me.ProductsButton.TabIndex = 0
        Me.ProductsButton.Text = "Products"
        Me.ProductsButton.UseVisualStyleBackColor = True
        '
        'ServicesButton
        '
        Me.ServicesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ServicesButton.Location = New System.Drawing.Point(340, 63)
        Me.ServicesButton.Name = "ServicesButton"
        Me.ServicesButton.Size = New System.Drawing.Size(150, 75)
        Me.ServicesButton.TabIndex = 1
        Me.ServicesButton.Text = "Services"
        Me.ServicesButton.UseVisualStyleBackColor = True
        '
        'RewardsProgramButton
        '
        Me.RewardsProgramButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RewardsProgramButton.Location = New System.Drawing.Point(114, 197)
        Me.RewardsProgramButton.Name = "RewardsProgramButton"
        Me.RewardsProgramButton.Size = New System.Drawing.Size(150, 75)
        Me.RewardsProgramButton.TabIndex = 2
        Me.RewardsProgramButton.Text = "Rewards Program"
        Me.RewardsProgramButton.UseVisualStyleBackColor = True
        '
        'AccountInformationButton
        '
        Me.AccountInformationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.AccountInformationButton.Location = New System.Drawing.Point(340, 197)
        Me.AccountInformationButton.Name = "AccountInformationButton"
        Me.AccountInformationButton.Size = New System.Drawing.Size(150, 75)
        Me.AccountInformationButton.TabIndex = 3
        Me.AccountInformationButton.Text = "Account Information"
        Me.AccountInformationButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 347)
        Me.Controls.Add(Me.AccountInformationButton)
        Me.Controls.Add(Me.RewardsProgramButton)
        Me.Controls.Add(Me.ServicesButton)
        Me.Controls.Add(Me.ProductsButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProductsButton As Button
    Friend WithEvents ServicesButton As Button
    Friend WithEvents RewardsProgramButton As Button
    Friend WithEvents AccountInformationButton As Button
End Class
