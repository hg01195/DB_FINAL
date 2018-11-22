<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstN = New System.Windows.Forms.TextBox()
        Me.LastN = New System.Windows.Forms.TextBox()
        Me.EmailA = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ShippingA = New System.Windows.Forms.TextBox()
        Me.BillingA = New System.Windows.Forms.TextBox()
        Me.AddNewUser = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Shipping Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Billing Address"
        '
        'FirstN
        '
        Me.FirstN.Location = New System.Drawing.Point(157, 25)
        Me.FirstN.Name = "FirstN"
        Me.FirstN.Size = New System.Drawing.Size(100, 22)
        Me.FirstN.TabIndex = 6
        '
        'LastN
        '
        Me.LastN.Location = New System.Drawing.Point(157, 53)
        Me.LastN.Name = "LastN"
        Me.LastN.Size = New System.Drawing.Size(100, 22)
        Me.LastN.TabIndex = 7
        '
        'EmailA
        '
        Me.EmailA.Location = New System.Drawing.Point(157, 81)
        Me.EmailA.Name = "EmailA"
        Me.EmailA.Size = New System.Drawing.Size(100, 22)
        Me.EmailA.TabIndex = 8
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(157, 111)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 22)
        Me.Password.TabIndex = 9
        '
        'ShippingA
        '
        Me.ShippingA.Location = New System.Drawing.Point(157, 142)
        Me.ShippingA.Name = "ShippingA"
        Me.ShippingA.Size = New System.Drawing.Size(100, 22)
        Me.ShippingA.TabIndex = 10
        '
        'BillingA
        '
        Me.BillingA.Location = New System.Drawing.Point(157, 170)
        Me.BillingA.Name = "BillingA"
        Me.BillingA.Size = New System.Drawing.Size(100, 22)
        Me.BillingA.TabIndex = 11
        '
        'AddNewUser
        '
        Me.AddNewUser.Location = New System.Drawing.Point(101, 209)
        Me.AddNewUser.Name = "AddNewUser"
        Me.AddNewUser.Size = New System.Drawing.Size(111, 23)
        Me.AddNewUser.TabIndex = 12
        Me.AddNewUser.Text = "Add New User"
        Me.AddNewUser.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(117, 238)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'NewCustForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 293)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.AddNewUser)
        Me.Controls.Add(Me.BillingA)
        Me.Controls.Add(Me.ShippingA)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.EmailA)
        Me.Controls.Add(Me.LastN)
        Me.Controls.Add(Me.FirstN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewCustForm"
        Me.Text = "NewCustForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstN As TextBox
    Friend WithEvents LastN As TextBox
    Friend WithEvents EmailA As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents ShippingA As TextBox
    Friend WithEvents BillingA As TextBox
    Friend WithEvents AddNewUser As Button
    Friend WithEvents Cancel As Button
End Class
