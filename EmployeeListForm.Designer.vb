<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.logOut = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RewardID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newAdminButton = New System.Windows.Forms.Button()
        Me.newStaffButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logOut
        '
        Me.logOut.Location = New System.Drawing.Point(663, 6)
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(75, 23)
        Me.logOut.TabIndex = 0
        Me.logOut.Text = "Log Out"
        Me.logOut.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(663, 426)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 1
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.RewardID, Me.CustomerID, Me.FirstName, Me.LastName})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(726, 385)
        Me.DataGridView1.TabIndex = 4
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'RewardID
        '
        Me.RewardID.HeaderText = "RewardID"
        Me.RewardID.Name = "RewardID"
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "CustomerID"
        Me.CustomerID.Name = "CustomerID"
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'newAdminButton
        '
        Me.newAdminButton.Location = New System.Drawing.Point(117, 426)
        Me.newAdminButton.Name = "newAdminButton"
        Me.newAdminButton.Size = New System.Drawing.Size(99, 23)
        Me.newAdminButton.TabIndex = 6
        Me.newAdminButton.Text = "New Admin"
        Me.newAdminButton.UseVisualStyleBackColor = True
        '
        'newStaffButton
        '
        Me.newStaffButton.Location = New System.Drawing.Point(12, 426)
        Me.newStaffButton.Name = "newStaffButton"
        Me.newStaffButton.Size = New System.Drawing.Size(99, 23)
        Me.newStaffButton.TabIndex = 5
        Me.newStaffButton.Text = "New Staff"
        Me.newStaffButton.UseVisualStyleBackColor = True
        '
        'EmployeeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 458)
        Me.Controls.Add(Me.newAdminButton)
        Me.Controls.Add(Me.newStaffButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.logOut)
        Me.Name = "EmployeeListForm"
        Me.Text = "EmployeeListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logOut As Button
    Friend WithEvents back As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents newAdminButton As Button
    Friend WithEvents newStaffButton As Button
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents RewardID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
End Class
