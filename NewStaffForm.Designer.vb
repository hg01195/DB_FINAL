<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStaffForm
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
        Me.backButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.fName = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.Label()
        Me.empID = New System.Windows.Forms.Label()
        Me.custID = New System.Windows.Forms.Label()
        Me.rewardsID = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.Label()
        Me.fNameTextBox = New System.Windows.Forms.TextBox()
        Me.lNameTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.employeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.custIDTextBox = New System.Windows.Forms.TextBox()
        Me.rewardsIDTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(365, 271)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 0
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Location = New System.Drawing.Point(365, 12)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(75, 23)
        Me.logOutButton.TabIndex = 1
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(12, 271)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 2
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'fName
        '
        Me.fName.AutoSize = True
        Me.fName.Location = New System.Drawing.Point(117, 52)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(76, 17)
        Me.fName.TabIndex = 3
        Me.fName.Text = "First Name"
        '
        'lName
        '
        Me.lName.AutoSize = True
        Me.lName.Location = New System.Drawing.Point(117, 80)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(76, 17)
        Me.lName.TabIndex = 4
        Me.lName.Text = "Last Name"
        '
        'empID
        '
        Me.empID.AutoSize = True
        Me.empID.Location = New System.Drawing.Point(117, 136)
        Me.empID.Name = "empID"
        Me.empID.Size = New System.Drawing.Size(87, 17)
        Me.empID.TabIndex = 5
        Me.empID.Text = "Employee ID"
        '
        'custID
        '
        Me.custID.AutoSize = True
        Me.custID.Location = New System.Drawing.Point(117, 164)
        Me.custID.Name = "custID"
        Me.custID.Size = New System.Drawing.Size(85, 17)
        Me.custID.TabIndex = 6
        Me.custID.Text = "Customer ID"
        '
        'rewardsID
        '
        Me.rewardsID.AutoSize = True
        Me.rewardsID.Location = New System.Drawing.Point(117, 192)
        Me.rewardsID.Name = "rewardsID"
        Me.rewardsID.Size = New System.Drawing.Size(80, 17)
        Me.rewardsID.TabIndex = 7
        Me.rewardsID.Text = "Rewards ID"
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(117, 220)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(69, 17)
        Me.password.TabIndex = 8
        Me.password.Text = "Password"
        '
        'city
        '
        Me.city.AutoSize = True
        Me.city.Location = New System.Drawing.Point(117, 108)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(31, 17)
        Me.city.TabIndex = 9
        Me.city.Text = "City"
        '
        'fNameTextBox
        '
        Me.fNameTextBox.Location = New System.Drawing.Point(226, 52)
        Me.fNameTextBox.Name = "fNameTextBox"
        Me.fNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.fNameTextBox.TabIndex = 10
        '
        'lNameTextBox
        '
        Me.lNameTextBox.Location = New System.Drawing.Point(226, 80)
        Me.lNameTextBox.Name = "lNameTextBox"
        Me.lNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.lNameTextBox.TabIndex = 11
        '
        'cityTextBox
        '
        Me.cityTextBox.Location = New System.Drawing.Point(226, 108)
        Me.cityTextBox.MaxLength = 25
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(100, 22)
        Me.cityTextBox.TabIndex = 12
        '
        'employeeIDTextBox
        '
        Me.employeeIDTextBox.Location = New System.Drawing.Point(226, 136)
        Me.employeeIDTextBox.Name = "employeeIDTextBox"
        Me.employeeIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.employeeIDTextBox.TabIndex = 13
        '
        'custIDTextBox
        '
        Me.custIDTextBox.Location = New System.Drawing.Point(226, 164)
        Me.custIDTextBox.Name = "custIDTextBox"
        Me.custIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.custIDTextBox.TabIndex = 14
        '
        'rewardsIDTextBox
        '
        Me.rewardsIDTextBox.Location = New System.Drawing.Point(226, 192)
        Me.rewardsIDTextBox.Name = "rewardsIDTextBox"
        Me.rewardsIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.rewardsIDTextBox.TabIndex = 15
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(226, 220)
        Me.passwordTextBox.MaxLength = 255
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.passwordTextBox.TabIndex = 16
        '
        'NewStaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 307)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.rewardsIDTextBox)
        Me.Controls.Add(Me.custIDTextBox)
        Me.Controls.Add(Me.employeeIDTextBox)
        Me.Controls.Add(Me.cityTextBox)
        Me.Controls.Add(Me.lNameTextBox)
        Me.Controls.Add(Me.fNameTextBox)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.rewardsID)
        Me.Controls.Add(Me.custID)
        Me.Controls.Add(Me.empID)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.backButton)
        Me.Name = "NewStaffForm"
        Me.Text = "NewStaffForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents fName As Label
    Friend WithEvents lName As Label
    Friend WithEvents empID As Label
    Friend WithEvents custID As Label
    Friend WithEvents rewardsID As Label
    Friend WithEvents password As Label
    Friend WithEvents city As Label
    Friend WithEvents fNameTextBox As TextBox
    Friend WithEvents lNameTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents employeeIDTextBox As TextBox
    Friend WithEvents custIDTextBox As TextBox
    Friend WithEvents rewardsIDTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
End Class
