<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerListForm
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
        Me.back = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rewards = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(520, 314)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(56, 19)
        Me.back.TabIndex = 0
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = True
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(520, 34)
        Me.logout.Margin = New System.Windows.Forms.Padding(2)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(69, 23)
        Me.logout.TabIndex = 1
        Me.logout.Text = "LOGOUT"
        Me.logout.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerID, Me.Rewards, Me.email, Me.fname, Me.lastname})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 299)
        Me.DataGridView1.TabIndex = 3
        '
        'CustomerID
        '
        Me.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CustomerID.Frozen = True
        Me.CustomerID.HeaderText = "ID"
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomerID.Width = 43
        '
        'Rewards
        '
        Me.Rewards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Rewards.FillWeight = 20.0!
        Me.Rewards.Frozen = True
        Me.Rewards.HeaderText = "Rewards"
        Me.Rewards.Name = "Rewards"
        Me.Rewards.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Rewards.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Rewards.Width = 55
        '
        'email
        '
        Me.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.email.Frozen = True
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.email.Width = 57
        '
        'fname
        '
        Me.fname.Frozen = True
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        Me.fname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'lastname
        '
        Me.lastname.Frozen = True
        Me.lastname.HeaderText = "Last Name"
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        Me.lastname.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CustomerListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.back)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CustomerListForm"
        Me.Text = "CustomerListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents logout As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents Rewards As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
End Class
