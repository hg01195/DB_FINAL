<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUserForm
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
        Me.ShippingAddressID_TB = New System.Windows.Forms.TextBox()
        Me.BillingAddressID_TB = New System.Windows.Forms.TextBox()
        Me.EmailAddress_TB = New System.Windows.Forms.TextBox()
        Me.FirstName_TB = New System.Windows.Forms.TextBox()
        Me.LastName_TB = New System.Windows.Forms.TextBox()
        Me.Password_TB = New System.Windows.Forms.TextBox()
        Me.BillingAddressID = New System.Windows.Forms.Label()
        Me.ShippingAddressID = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.EmailAddress = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShippingAddressID_TB
        '
        Me.ShippingAddressID_TB.Location = New System.Drawing.Point(180, 197)
        Me.ShippingAddressID_TB.Name = "ShippingAddressID_TB"
        Me.ShippingAddressID_TB.Size = New System.Drawing.Size(136, 22)
        Me.ShippingAddressID_TB.TabIndex = 35
        '
        'BillingAddressID_TB
        '
        Me.BillingAddressID_TB.Location = New System.Drawing.Point(180, 225)
        Me.BillingAddressID_TB.Name = "BillingAddressID_TB"
        Me.BillingAddressID_TB.Size = New System.Drawing.Size(136, 22)
        Me.BillingAddressID_TB.TabIndex = 34
        '
        'EmailAddress_TB
        '
        Me.EmailAddress_TB.Location = New System.Drawing.Point(180, 113)
        Me.EmailAddress_TB.Name = "EmailAddress_TB"
        Me.EmailAddress_TB.Size = New System.Drawing.Size(136, 22)
        Me.EmailAddress_TB.TabIndex = 33
        '
        'FirstName_TB
        '
        Me.FirstName_TB.Location = New System.Drawing.Point(180, 141)
        Me.FirstName_TB.Name = "FirstName_TB"
        Me.FirstName_TB.Size = New System.Drawing.Size(136, 22)
        Me.FirstName_TB.TabIndex = 32
        '
        'LastName_TB
        '
        Me.LastName_TB.Location = New System.Drawing.Point(180, 169)
        Me.LastName_TB.Name = "LastName_TB"
        Me.LastName_TB.Size = New System.Drawing.Size(136, 22)
        Me.LastName_TB.TabIndex = 31
        '
        'Password_TB
        '
        Me.Password_TB.Location = New System.Drawing.Point(180, 85)
        Me.Password_TB.Name = "Password_TB"
        Me.Password_TB.Size = New System.Drawing.Size(136, 22)
        Me.Password_TB.TabIndex = 30
        '
        'BillingAddressID
        '
        Me.BillingAddressID.AutoSize = True
        Me.BillingAddressID.Location = New System.Drawing.Point(44, 225)
        Me.BillingAddressID.Name = "BillingAddressID"
        Me.BillingAddressID.Size = New System.Drawing.Size(118, 17)
        Me.BillingAddressID.TabIndex = 29
        Me.BillingAddressID.Text = "Billing Address ID"
        '
        'ShippingAddressID
        '
        Me.ShippingAddressID.AutoSize = True
        Me.ShippingAddressID.Location = New System.Drawing.Point(44, 197)
        Me.ShippingAddressID.Name = "ShippingAddressID"
        Me.ShippingAddressID.Size = New System.Drawing.Size(136, 17)
        Me.ShippingAddressID.TabIndex = 28
        Me.ShippingAddressID.Text = "Shipping Address ID"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(44, 169)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(76, 17)
        Me.LastName.TabIndex = 26
        Me.LastName.Text = "Last Name"
        '
        'EmailAddress
        '
        Me.EmailAddress.AutoSize = True
        Me.EmailAddress.Location = New System.Drawing.Point(44, 113)
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Size = New System.Drawing.Size(98, 17)
        Me.EmailAddress.TabIndex = 25
        Me.EmailAddress.Text = "Email Address"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(44, 141)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(76, 17)
        Me.FirstName.TabIndex = 24
        Me.FirstName.Text = "First Name"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(44, 85)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 17)
        Me.Password.TabIndex = 23
        Me.Password.Text = "Password"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(241, 262)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 36
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'NewUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 309)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.ShippingAddressID_TB)
        Me.Controls.Add(Me.BillingAddressID_TB)
        Me.Controls.Add(Me.EmailAddress_TB)
        Me.Controls.Add(Me.FirstName_TB)
        Me.Controls.Add(Me.LastName_TB)
        Me.Controls.Add(Me.Password_TB)
        Me.Controls.Add(Me.BillingAddressID)
        Me.Controls.Add(Me.ShippingAddressID)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.EmailAddress)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Password)
        Me.Name = "NewUserForm"
        Me.Text = "NewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShippingAddressID_TB As TextBox
    Friend WithEvents BillingAddressID_TB As TextBox
    Friend WithEvents EmailAddress_TB As TextBox
    Friend WithEvents FirstName_TB As TextBox
    Friend WithEvents LastName_TB As TextBox
    Friend WithEvents Password_TB As TextBox
    Friend WithEvents BillingAddressID As Label
    Friend WithEvents ShippingAddressID As Label
    Friend WithEvents LastName As Label
    Friend WithEvents EmailAddress As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents Password As Label
    Friend WithEvents submitButton As Button
End Class
