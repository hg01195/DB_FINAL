<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.employeeListButton = New System.Windows.Forms.Button()
        Me.productListButton = New System.Windows.Forms.Button()
        Me.employeeList = New System.Windows.Forms.Label()
        Me.productList = New System.Windows.Forms.Label()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.serviceList = New System.Windows.Forms.Label()
        Me.serviceListButton = New System.Windows.Forms.Button()
        Me.customerLsitButton = New System.Windows.Forms.Button()
        Me.customerList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'employeeListButton
        '
        Me.employeeListButton.Location = New System.Drawing.Point(128, 78)
        Me.employeeListButton.Name = "employeeListButton"
        Me.employeeListButton.Size = New System.Drawing.Size(82, 23)
        Me.employeeListButton.TabIndex = 0
        Me.employeeListButton.Text = "Go"
        Me.employeeListButton.UseVisualStyleBackColor = True
        '
        'productListButton
        '
        Me.productListButton.Location = New System.Drawing.Point(128, 107)
        Me.productListButton.Name = "productListButton"
        Me.productListButton.Size = New System.Drawing.Size(82, 23)
        Me.productListButton.TabIndex = 1
        Me.productListButton.Text = "Go"
        Me.productListButton.UseVisualStyleBackColor = True
        '
        'employeeList
        '
        Me.employeeList.AutoSize = True
        Me.employeeList.Location = New System.Drawing.Point(26, 84)
        Me.employeeList.Name = "employeeList"
        Me.employeeList.Size = New System.Drawing.Size(96, 17)
        Me.employeeList.TabIndex = 2
        Me.employeeList.Text = "Employee List"
        '
        'productList
        '
        Me.productList.AutoSize = True
        Me.productList.Location = New System.Drawing.Point(26, 113)
        Me.productList.Name = "productList"
        Me.productList.Size = New System.Drawing.Size(83, 17)
        Me.productList.TabIndex = 3
        Me.productList.Text = "Product List"
        '
        'logOutButton
        '
        Me.logOutButton.Location = New System.Drawing.Point(238, 12)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(75, 23)
        Me.logOutButton.TabIndex = 5
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'serviceList
        '
        Me.serviceList.AutoSize = True
        Me.serviceList.Location = New System.Drawing.Point(26, 139)
        Me.serviceList.Name = "serviceList"
        Me.serviceList.Size = New System.Drawing.Size(81, 17)
        Me.serviceList.TabIndex = 6
        Me.serviceList.Text = "Service List"
        '
        'serviceListButton
        '
        Me.serviceListButton.Location = New System.Drawing.Point(128, 136)
        Me.serviceListButton.Name = "serviceListButton"
        Me.serviceListButton.Size = New System.Drawing.Size(82, 23)
        Me.serviceListButton.TabIndex = 7
        Me.serviceListButton.Text = "Go"
        Me.serviceListButton.UseVisualStyleBackColor = True
        '
        'customerLsitButton
        '
        Me.customerLsitButton.Location = New System.Drawing.Point(128, 49)
        Me.customerLsitButton.Name = "customerLsitButton"
        Me.customerLsitButton.Size = New System.Drawing.Size(82, 23)
        Me.customerLsitButton.TabIndex = 8
        Me.customerLsitButton.Text = "Go"
        Me.customerLsitButton.UseVisualStyleBackColor = True
        '
        'customerList
        '
        Me.customerList.AutoSize = True
        Me.customerList.Location = New System.Drawing.Point(26, 52)
        Me.customerList.Name = "customerList"
        Me.customerList.Size = New System.Drawing.Size(94, 17)
        Me.customerList.TabIndex = 9
        Me.customerList.Text = "Customer List"
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 191)
        Me.Controls.Add(Me.customerList)
        Me.Controls.Add(Me.customerLsitButton)
        Me.Controls.Add(Me.serviceListButton)
        Me.Controls.Add(Me.serviceList)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.productList)
        Me.Controls.Add(Me.employeeList)
        Me.Controls.Add(Me.productListButton)
        Me.Controls.Add(Me.employeeListButton)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employeeListButton As Button
    Friend WithEvents productListButton As Button
    Friend WithEvents employeeList As Label
    Friend WithEvents productList As Label
    Friend WithEvents logOutButton As Button
    Friend WithEvents serviceList As Label
    Friend WithEvents serviceListButton As Button
    Friend WithEvents customerLsitButton As Button
    Friend WithEvents customerList As Label
End Class
