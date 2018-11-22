<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLoginForm
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
        Me.submitButton = New System.Windows.Forms.Button()
        Me.newUserButton = New System.Windows.Forms.Button()
        Me.fName = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.fNameTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'submitButton
        '
        Me.submitButton.Location = New System.Drawing.Point(51, 101)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(75, 23)
        Me.submitButton.TabIndex = 0
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'newUserButton
        '
        Me.newUserButton.Location = New System.Drawing.Point(152, 101)
        Me.newUserButton.Name = "newUserButton"
        Me.newUserButton.Size = New System.Drawing.Size(78, 23)
        Me.newUserButton.TabIndex = 1
        Me.newUserButton.Text = "New User"
        Me.newUserButton.UseVisualStyleBackColor = True
        '
        'fName
        '
        Me.fName.AutoSize = True
        Me.fName.Location = New System.Drawing.Point(48, 42)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(76, 17)
        Me.fName.TabIndex = 2
        Me.fName.Text = "First Name"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(48, 70)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 17)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password"
        '
        'fNameTextBox
        '
        Me.fNameTextBox.Location = New System.Drawing.Point(130, 42)
        Me.fNameTextBox.Name = "fNameTextBox"
        Me.fNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.fNameTextBox.TabIndex = 4
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(130, 70)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.passwordTextBox.TabIndex = 5
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(155, 130)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 6
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'UserLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 161)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.fNameTextBox)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.newUserButton)
        Me.Controls.Add(Me.submitButton)
        Me.Name = "UserLoginForm"
        Me.Text = "UserLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submitButton As Button
    Friend WithEvents newUserButton As Button
    Friend WithEvents fName As Label
    Friend WithEvents Password As Label
    Friend WithEvents fNameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents closeButton As Button
End Class
