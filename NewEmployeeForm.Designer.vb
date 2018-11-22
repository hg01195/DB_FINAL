<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEmployeeForm
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
        Me.newStaffButton = New System.Windows.Forms.Button()
        Me.newAdminButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'newStaffButton
        '
        Me.newStaffButton.Location = New System.Drawing.Point(78, 88)
        Me.newStaffButton.Name = "newStaffButton"
        Me.newStaffButton.Size = New System.Drawing.Size(99, 23)
        Me.newStaffButton.TabIndex = 0
        Me.newStaffButton.Text = "New Staff"
        Me.newStaffButton.UseVisualStyleBackColor = True
        '
        'newAdminButton
        '
        Me.newAdminButton.Location = New System.Drawing.Point(218, 88)
        Me.newAdminButton.Name = "newAdminButton"
        Me.newAdminButton.Size = New System.Drawing.Size(99, 23)
        Me.newAdminButton.TabIndex = 1
        Me.newAdminButton.Text = "New Admin"
        Me.newAdminButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(324, 191)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(75, 23)
        Me.backButton.TabIndex = 2
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Location = New System.Drawing.Point(324, 12)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(75, 23)
        Me.logOutButton.TabIndex = 3
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'NewEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 226)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.newAdminButton)
        Me.Controls.Add(Me.newStaffButton)
        Me.Name = "NewEmployeeForm"
        Me.Text = "NewEmployeeForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newStaffButton As Button
    Friend WithEvents newAdminButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents logOutButton As Button
End Class
