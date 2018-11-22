<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.Password = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.EmailAddress = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.CustomerID = New System.Windows.Forms.Label()
        Me.ShippingAddressID = New System.Windows.Forms.Label()
        Me.BillingAddressID = New System.Windows.Forms.Label()
        Me.Password_TB = New System.Windows.Forms.TextBox()
        Me.LastName_TB = New System.Windows.Forms.TextBox()
        Me.FirstName_TB = New System.Windows.Forms.TextBox()
        Me.EmailAddress_TB = New System.Windows.Forms.TextBox()
        Me.BillingAddressID_TB = New System.Windows.Forms.TextBox()
        Me.ShippingAddressID_TB = New System.Windows.Forms.TextBox()
        Me.CustomerID_TB = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.GetButton = New System.Windows.Forms.Button()
        Me.AddressGuiButton = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.btnTemp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(28, 64)
        Me.Password.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 0
        Me.Password.Text = "Password"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(28, 110)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(57, 13)
        Me.FirstName.TabIndex = 1
        Me.FirstName.Text = "First Name"
        '
        'EmailAddress
        '
        Me.EmailAddress.AutoSize = True
        Me.EmailAddress.Location = New System.Drawing.Point(28, 87)
        Me.EmailAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmailAddress.Name = "EmailAddress"
        Me.EmailAddress.Size = New System.Drawing.Size(73, 13)
        Me.EmailAddress.TabIndex = 2
        Me.EmailAddress.Text = "Email Address"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(28, 132)
        Me.LastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(58, 13)
        Me.LastName.TabIndex = 3
        Me.LastName.Text = "Last Name"
        '
        'CustomerID
        '
        Me.CustomerID.AutoSize = True
        Me.CustomerID.Location = New System.Drawing.Point(28, 44)
        Me.CustomerID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(65, 13)
        Me.CustomerID.TabIndex = 6
        Me.CustomerID.Text = "Customer ID"
        '
        'ShippingAddressID
        '
        Me.ShippingAddressID.AutoSize = True
        Me.ShippingAddressID.Location = New System.Drawing.Point(28, 155)
        Me.ShippingAddressID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ShippingAddressID.Name = "ShippingAddressID"
        Me.ShippingAddressID.Size = New System.Drawing.Size(103, 13)
        Me.ShippingAddressID.TabIndex = 7
        Me.ShippingAddressID.Text = "Shipping Address ID"
        '
        'BillingAddressID
        '
        Me.BillingAddressID.AutoSize = True
        Me.BillingAddressID.Location = New System.Drawing.Point(28, 178)
        Me.BillingAddressID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BillingAddressID.Name = "BillingAddressID"
        Me.BillingAddressID.Size = New System.Drawing.Size(89, 13)
        Me.BillingAddressID.TabIndex = 8
        Me.BillingAddressID.Text = "Billing Address ID"
        '
        'Password_TB
        '
        Me.Password_TB.Location = New System.Drawing.Point(130, 64)
        Me.Password_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.Password_TB.Name = "Password_TB"
        Me.Password_TB.Size = New System.Drawing.Size(103, 20)
        Me.Password_TB.TabIndex = 9
        '
        'LastName_TB
        '
        Me.LastName_TB.Location = New System.Drawing.Point(130, 132)
        Me.LastName_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.LastName_TB.Name = "LastName_TB"
        Me.LastName_TB.Size = New System.Drawing.Size(103, 20)
        Me.LastName_TB.TabIndex = 10
        '
        'FirstName_TB
        '
        Me.FirstName_TB.Location = New System.Drawing.Point(130, 110)
        Me.FirstName_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstName_TB.Name = "FirstName_TB"
        Me.FirstName_TB.Size = New System.Drawing.Size(103, 20)
        Me.FirstName_TB.TabIndex = 11
        '
        'EmailAddress_TB
        '
        Me.EmailAddress_TB.Location = New System.Drawing.Point(130, 87)
        Me.EmailAddress_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailAddress_TB.Name = "EmailAddress_TB"
        Me.EmailAddress_TB.Size = New System.Drawing.Size(103, 20)
        Me.EmailAddress_TB.TabIndex = 12
        '
        'BillingAddressID_TB
        '
        Me.BillingAddressID_TB.Location = New System.Drawing.Point(130, 178)
        Me.BillingAddressID_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.BillingAddressID_TB.Name = "BillingAddressID_TB"
        Me.BillingAddressID_TB.Size = New System.Drawing.Size(103, 20)
        Me.BillingAddressID_TB.TabIndex = 13
        '
        'ShippingAddressID_TB
        '
        Me.ShippingAddressID_TB.Location = New System.Drawing.Point(130, 155)
        Me.ShippingAddressID_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.ShippingAddressID_TB.Name = "ShippingAddressID_TB"
        Me.ShippingAddressID_TB.Size = New System.Drawing.Size(103, 20)
        Me.ShippingAddressID_TB.TabIndex = 14
        '
        'CustomerID_TB
        '
        Me.CustomerID_TB.Location = New System.Drawing.Point(130, 40)
        Me.CustomerID_TB.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomerID_TB.Name = "CustomerID_TB"
        Me.CustomerID_TB.Size = New System.Drawing.Size(103, 20)
        Me.CustomerID_TB.TabIndex = 16
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(29, 210)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(56, 19)
        Me.SubmitButton.TabIndex = 17
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(90, 234)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(56, 19)
        Me.ExitButton.TabIndex = 18
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(29, 234)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(56, 19)
        Me.DeleteButton.TabIndex = 19
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(90, 210)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(56, 19)
        Me.UpdateButton.TabIndex = 20
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'GetButton
        '
        Me.GetButton.Location = New System.Drawing.Point(238, 40)
        Me.GetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.GetButton.Name = "GetButton"
        Me.GetButton.Size = New System.Drawing.Size(77, 19)
        Me.GetButton.TabIndex = 22
        Me.GetButton.Text = "Get Customer"
        Me.GetButton.UseVisualStyleBackColor = True
        '
        'AddressGuiButton
        '
        Me.AddressGuiButton.Location = New System.Drawing.Point(238, 258)
        Me.AddressGuiButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressGuiButton.Name = "AddressGuiButton"
        Me.AddressGuiButton.Size = New System.Drawing.Size(76, 19)
        Me.AddressGuiButton.TabIndex = 23
        Me.AddressGuiButton.Text = "To Address:"
        Me.AddressGuiButton.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(238, 234)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(74, 19)
        Me.btnOrder.TabIndex = 24
        Me.btnOrder.Text = "To Orders"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'btnTemp
        '
        Me.btnTemp.Location = New System.Drawing.Point(238, 210)
        Me.btnTemp.Name = "btnTemp"
        Me.btnTemp.Size = New System.Drawing.Size(74, 19)
        Me.btnTemp.TabIndex = 25
        Me.btnTemp.Text = "To Orders2"
        Me.btnTemp.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 287)
        Me.Controls.Add(Me.btnTemp)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.AddressGuiButton)
        Me.Controls.Add(Me.GetButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.CustomerID_TB)
        Me.Controls.Add(Me.ShippingAddressID_TB)
        Me.Controls.Add(Me.BillingAddressID_TB)
        Me.Controls.Add(Me.EmailAddress_TB)
        Me.Controls.Add(Me.FirstName_TB)
        Me.Controls.Add(Me.LastName_TB)
        Me.Controls.Add(Me.Password_TB)
        Me.Controls.Add(Me.BillingAddressID)
        Me.Controls.Add(Me.ShippingAddressID)
        Me.Controls.Add(Me.CustomerID)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.EmailAddress)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Password)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CustomerForm"
        Me.Text = "Customer GUI MKI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Password As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents EmailAddress As Label
    Friend WithEvents LastName As Label
    Friend WithEvents CustomerID As Label
    Friend WithEvents ShippingAddressID As Label
    Friend WithEvents BillingAddressID As Label
    Friend WithEvents Password_TB As TextBox
    Friend WithEvents LastName_TB As TextBox
    Friend WithEvents FirstName_TB As TextBox
    Friend WithEvents EmailAddress_TB As TextBox
    Friend WithEvents BillingAddressID_TB As TextBox
    Friend WithEvents ShippingAddressID_TB As TextBox
    Friend WithEvents CustomerID_TB As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents GetButton As Button
    Friend WithEvents AddressGuiButton As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents btnTemp As Button
End Class
