<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressForm
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
        Me.components = New System.ComponentModel.Container()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BillingPhone_TB = New System.Windows.Forms.TextBox()
        Me.BillingZip_TB = New System.Windows.Forms.TextBox()
        Me.BillingState_TB = New System.Windows.Forms.TextBox()
        Me.BillingCity_TB = New System.Windows.Forms.TextBox()
        Me.BillingLine2_TB = New System.Windows.Forms.TextBox()
        Me.BillingLine1_TB = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShippingPhone_TB = New System.Windows.Forms.TextBox()
        Me.ShippingZip_TB = New System.Windows.Forms.TextBox()
        Me.ShippingState_TB = New System.Windows.Forms.TextBox()
        Me.ShippingCity_TB = New System.Windows.Forms.TextBox()
        Me.ShippingLine2_TB = New System.Windows.Forms.TextBox()
        Me.ShippingLine1_TB = New System.Windows.Forms.TextBox()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.ZipCode = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.Label()
        Me.AddressTwo = New System.Windows.Forms.Label()
        Me.AddressOne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UpdateButton
        '
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.UpdateButton.Location = New System.Drawing.Point(185, 248)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(100, 42)
        Me.UpdateButton.TabIndex = 17
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ExitButton.Location = New System.Drawing.Point(352, 248)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(104, 42)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(419, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Billing Address"
        Me.Label5.Visible = False
        '
        'BillingPhone_TB
        '
        Me.BillingPhone_TB.Location = New System.Drawing.Point(423, 192)
        Me.BillingPhone_TB.Name = "BillingPhone_TB"
        Me.BillingPhone_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingPhone_TB.TabIndex = 68
        Me.BillingPhone_TB.Visible = False
        '
        'BillingZip_TB
        '
        Me.BillingZip_TB.Location = New System.Drawing.Point(423, 164)
        Me.BillingZip_TB.Name = "BillingZip_TB"
        Me.BillingZip_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingZip_TB.TabIndex = 67
        Me.BillingZip_TB.Visible = False
        '
        'BillingState_TB
        '
        Me.BillingState_TB.Location = New System.Drawing.Point(423, 136)
        Me.BillingState_TB.Name = "BillingState_TB"
        Me.BillingState_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingState_TB.TabIndex = 66
        Me.BillingState_TB.Visible = False
        '
        'BillingCity_TB
        '
        Me.BillingCity_TB.Location = New System.Drawing.Point(423, 106)
        Me.BillingCity_TB.Name = "BillingCity_TB"
        Me.BillingCity_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingCity_TB.TabIndex = 65
        Me.BillingCity_TB.Visible = False
        '
        'BillingLine2_TB
        '
        Me.BillingLine2_TB.Location = New System.Drawing.Point(423, 79)
        Me.BillingLine2_TB.Name = "BillingLine2_TB"
        Me.BillingLine2_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingLine2_TB.TabIndex = 64
        Me.BillingLine2_TB.Visible = False
        '
        'BillingLine1_TB
        '
        Me.BillingLine1_TB.Location = New System.Drawing.Point(423, 52)
        Me.BillingLine1_TB.Name = "BillingLine1_TB"
        Me.BillingLine1_TB.Size = New System.Drawing.Size(100, 22)
        Me.BillingLine1_TB.TabIndex = 63
        Me.BillingLine1_TB.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(291, 54)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 21)
        Me.CheckBox1.TabIndex = 62
        Me.CheckBox1.Text = "Different Billing"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(117, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Shipping Address"
        '
        'ShippingPhone_TB
        '
        Me.ShippingPhone_TB.Location = New System.Drawing.Point(185, 192)
        Me.ShippingPhone_TB.Name = "ShippingPhone_TB"
        Me.ShippingPhone_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingPhone_TB.TabIndex = 60
        '
        'ShippingZip_TB
        '
        Me.ShippingZip_TB.Location = New System.Drawing.Point(185, 164)
        Me.ShippingZip_TB.Name = "ShippingZip_TB"
        Me.ShippingZip_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingZip_TB.TabIndex = 59
        '
        'ShippingState_TB
        '
        Me.ShippingState_TB.Location = New System.Drawing.Point(185, 136)
        Me.ShippingState_TB.Name = "ShippingState_TB"
        Me.ShippingState_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingState_TB.TabIndex = 58
        '
        'ShippingCity_TB
        '
        Me.ShippingCity_TB.Location = New System.Drawing.Point(185, 108)
        Me.ShippingCity_TB.Name = "ShippingCity_TB"
        Me.ShippingCity_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingCity_TB.TabIndex = 57
        '
        'ShippingLine2_TB
        '
        Me.ShippingLine2_TB.Location = New System.Drawing.Point(185, 80)
        Me.ShippingLine2_TB.Name = "ShippingLine2_TB"
        Me.ShippingLine2_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingLine2_TB.TabIndex = 56
        '
        'ShippingLine1_TB
        '
        Me.ShippingLine1_TB.Location = New System.Drawing.Point(185, 52)
        Me.ShippingLine1_TB.Name = "ShippingLine1_TB"
        Me.ShippingLine1_TB.Size = New System.Drawing.Size(100, 22)
        Me.ShippingLine1_TB.TabIndex = 55
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(60, 195)
        Me.PhoneNumber.MinimumSize = New System.Drawing.Size(100, 0)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.PhoneNumber.TabIndex = 54
        Me.PhoneNumber.Text = "Phone Number"
        Me.PhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ZipCode
        '
        Me.ZipCode.AutoSize = True
        Me.ZipCode.Location = New System.Drawing.Point(63, 167)
        Me.ZipCode.MinimumSize = New System.Drawing.Size(100, 0)
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.Size = New System.Drawing.Size(100, 17)
        Me.ZipCode.TabIndex = 53
        Me.ZipCode.Text = "Zip Code"
        Me.ZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(63, 138)
        Me.State.MinimumSize = New System.Drawing.Size(100, 0)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(100, 17)
        Me.State.TabIndex = 52
        Me.State.Text = "State"
        Me.State.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(63, 111)
        Me.City.MinimumSize = New System.Drawing.Size(100, 0)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(100, 17)
        Me.City.TabIndex = 51
        Me.City.Text = "City"
        Me.City.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressTwo
        '
        Me.AddressTwo.AutoSize = True
        Me.AddressTwo.Location = New System.Drawing.Point(65, 83)
        Me.AddressTwo.MinimumSize = New System.Drawing.Size(100, 0)
        Me.AddressTwo.Name = "AddressTwo"
        Me.AddressTwo.Size = New System.Drawing.Size(100, 17)
        Me.AddressTwo.TabIndex = 50
        Me.AddressTwo.Text = "Address Two"
        Me.AddressTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressOne
        '
        Me.AddressOne.AutoSize = True
        Me.AddressOne.Location = New System.Drawing.Point(65, 55)
        Me.AddressOne.MinimumSize = New System.Drawing.Size(100, 0)
        Me.AddressOne.Name = "AddressOne"
        Me.AddressOne.Size = New System.Drawing.Size(100, 17)
        Me.AddressOne.TabIndex = 49
        Me.AddressOne.Text = "Address One"
        Me.AddressOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 351)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BillingPhone_TB)
        Me.Controls.Add(Me.BillingZip_TB)
        Me.Controls.Add(Me.BillingState_TB)
        Me.Controls.Add(Me.BillingCity_TB)
        Me.Controls.Add(Me.BillingLine2_TB)
        Me.Controls.Add(Me.BillingLine1_TB)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShippingPhone_TB)
        Me.Controls.Add(Me.ShippingZip_TB)
        Me.Controls.Add(Me.ShippingState_TB)
        Me.Controls.Add(Me.ShippingCity_TB)
        Me.Controls.Add(Me.ShippingLine2_TB)
        Me.Controls.Add(Me.ShippingLine1_TB)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.ZipCode)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.AddressTwo)
        Me.Controls.Add(Me.AddressOne)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Name = "AddressForm"
        Me.Text = "AddressForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label5 As Label
    Friend WithEvents BillingPhone_TB As TextBox
    Friend WithEvents BillingZip_TB As TextBox
    Friend WithEvents BillingState_TB As TextBox
    Friend WithEvents BillingCity_TB As TextBox
    Friend WithEvents BillingLine2_TB As TextBox
    Friend WithEvents BillingLine1_TB As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ShippingPhone_TB As TextBox
    Friend WithEvents ShippingZip_TB As TextBox
    Friend WithEvents ShippingState_TB As TextBox
    Friend WithEvents ShippingCity_TB As TextBox
    Friend WithEvents ShippingLine2_TB As TextBox
    Friend WithEvents ShippingLine1_TB As TextBox
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents ZipCode As Label
    Friend WithEvents State As Label
    Friend WithEvents City As Label
    Friend WithEvents AddressTwo As Label
    Friend WithEvents AddressOne As Label
End Class
