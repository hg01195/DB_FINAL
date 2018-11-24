<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewAdminForm
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
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.rewardsIDTextBox = New System.Windows.Forms.TextBox()
        Me.custIDTextBox = New System.Windows.Forms.TextBox()
        Me.employeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.lNameTextBox = New System.Windows.Forms.TextBox()
        Me.fNameTextBox = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.rewardsID = New System.Windows.Forms.Label()
        Me.custID = New System.Windows.Forms.Label()
        Me.empID = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.getButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(162, 190)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.passwordTextBox.TabIndex = 33
        '
        'rewardsIDTextBox
        '
        Me.rewardsIDTextBox.Location = New System.Drawing.Point(162, 162)
        Me.rewardsIDTextBox.Name = "rewardsIDTextBox"
        Me.rewardsIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.rewardsIDTextBox.TabIndex = 32
        '
        'custIDTextBox
        '
        Me.custIDTextBox.Location = New System.Drawing.Point(162, 134)
        Me.custIDTextBox.Name = "custIDTextBox"
        Me.custIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.custIDTextBox.TabIndex = 31
        '
        'employeeIDTextBox
        '
        Me.employeeIDTextBox.Location = New System.Drawing.Point(162, 50)
        Me.employeeIDTextBox.Name = "employeeIDTextBox"
        Me.employeeIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.employeeIDTextBox.TabIndex = 30
        '
        'lNameTextBox
        '
        Me.lNameTextBox.Location = New System.Drawing.Point(162, 106)
        Me.lNameTextBox.Name = "lNameTextBox"
        Me.lNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.lNameTextBox.TabIndex = 28
        '
        'fNameTextBox
        '
        Me.fNameTextBox.Location = New System.Drawing.Point(162, 78)
        Me.fNameTextBox.Name = "fNameTextBox"
        Me.fNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.fNameTextBox.TabIndex = 27
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.Location = New System.Drawing.Point(53, 190)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(69, 17)
        Me.password.TabIndex = 25
        Me.password.Text = "Password"
        '
        'rewardsID
        '
        Me.rewardsID.AutoSize = True
        Me.rewardsID.Location = New System.Drawing.Point(53, 162)
        Me.rewardsID.Name = "rewardsID"
        Me.rewardsID.Size = New System.Drawing.Size(80, 17)
        Me.rewardsID.TabIndex = 24
        Me.rewardsID.Text = "Rewards ID"
        '
        'custID
        '
        Me.custID.AutoSize = True
        Me.custID.Location = New System.Drawing.Point(53, 134)
        Me.custID.Name = "custID"
        Me.custID.Size = New System.Drawing.Size(85, 17)
        Me.custID.TabIndex = 23
        Me.custID.Text = "Customer ID"
        '
        'empID
        '
        Me.empID.AutoSize = True
        Me.empID.Location = New System.Drawing.Point(53, 50)
        Me.empID.Name = "empID"
        Me.empID.Size = New System.Drawing.Size(87, 17)
        Me.empID.TabIndex = 22
        Me.empID.Text = "Employee ID"
        '
        'lName
        '
        Me.lName.AutoSize = True
        Me.lName.Location = New System.Drawing.Point(53, 106)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(76, 17)
        Me.lName.TabIndex = 21
        Me.lName.Text = "Last Name"
        '
        'fName
        '
        Me.fName.AutoSize = True
        Me.fName.Location = New System.Drawing.Point(53, 78)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(76, 17)
        Me.fName.TabIndex = 20
        Me.fName.Text = "First Name"
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(56, 223)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 19
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Location = New System.Drawing.Point(268, 21)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(86, 23)
        Me.logOutButton.TabIndex = 18
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(137, 252)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 17
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(137, 223)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(75, 23)
        Me.updateButton.TabIndex = 34
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(56, 252)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteButton.TabIndex = 35
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'getButton
        '
        Me.getButton.Location = New System.Drawing.Point(268, 50)
        Me.getButton.Name = "getButton"
        Me.getButton.Size = New System.Drawing.Size(86, 23)
        Me.getButton.TabIndex = 36
        Me.getButton.Text = "Get Admin"
        Me.getButton.UseVisualStyleBackColor = True
        '
        'NewAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 307)
        Me.Controls.Add(Me.getButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.rewardsIDTextBox)
        Me.Controls.Add(Me.custIDTextBox)
        Me.Controls.Add(Me.employeeIDTextBox)
        Me.Controls.Add(Me.lNameTextBox)
        Me.Controls.Add(Me.fNameTextBox)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.rewardsID)
        Me.Controls.Add(Me.custID)
        Me.Controls.Add(Me.empID)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.backButton)
        Me.Name = "NewAdminForm"
        Me.Text = "NewAdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents rewardsIDTextBox As TextBox
    Friend WithEvents custIDTextBox As TextBox
    Friend WithEvents employeeIDTextBox As TextBox
    Friend WithEvents lNameTextBox As TextBox
    Friend WithEvents fNameTextBox As TextBox
    Friend WithEvents password As Label
    Friend WithEvents rewardsID As Label
    Friend WithEvents custID As Label
    Friend WithEvents empID As Label
    Friend WithEvents lName As Label
    Friend WithEvents fName As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents logOutButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents getButton As Button
End Class
