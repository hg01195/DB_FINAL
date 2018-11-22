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
        Me.newEmployeeButton = New System.Windows.Forms.Button()
        Me.dataGridViewButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logOut
        '
        Me.logOut.Location = New System.Drawing.Point(713, 12)
        Me.logOut.Name = "logOut"
        Me.logOut.Size = New System.Drawing.Size(75, 23)
        Me.logOut.TabIndex = 0
        Me.logOut.Text = "Log Out"
        Me.logOut.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(713, 415)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 1
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'newEmployeeButton
        '
        Me.newEmployeeButton.Location = New System.Drawing.Point(13, 414)
        Me.newEmployeeButton.Name = "newEmployeeButton"
        Me.newEmployeeButton.Size = New System.Drawing.Size(115, 23)
        Me.newEmployeeButton.TabIndex = 2
        Me.newEmployeeButton.Text = "New Employee"
        Me.newEmployeeButton.UseVisualStyleBackColor = True
        '
        'dataGridViewButton
        '
        Me.dataGridViewButton.Location = New System.Drawing.Point(512, 414)
        Me.dataGridViewButton.Name = "dataGridViewButton"
        Me.dataGridViewButton.Size = New System.Drawing.Size(93, 23)
        Me.dataGridViewButton.TabIndex = 3
        Me.dataGridViewButton.Text = "Load Table"
        Me.dataGridViewButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(583, 385)
        Me.DataGridView1.TabIndex = 4
        '
        'EmployeeListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 458)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dataGridViewButton)
        Me.Controls.Add(Me.newEmployeeButton)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.logOut)
        Me.Name = "EmployeeListForm"
        Me.Text = "EmployeeListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logOut As Button
    Friend WithEvents back As Button
    Friend WithEvents newEmployeeButton As Button
    Friend WithEvents dataGridViewButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
