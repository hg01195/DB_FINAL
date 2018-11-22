<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffForm
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.serviceid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.listprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderid2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.heystaff = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serviceid, Me.ServiceName, Me.fname1, Me.city, Me.listprice, Me.orderid2, Me.Quant})
        Me.DataGridView2.Location = New System.Drawing.Point(34, 144)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(490, 239)
        Me.DataGridView2.TabIndex = 0
        '
        'serviceid
        '
        Me.serviceid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.serviceid.HeaderText = "ID"
        Me.serviceid.Name = "serviceid"
        Me.serviceid.Width = 43
        '
        'ServiceName
        '
        Me.ServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ServiceName.HeaderText = "Service Name"
        Me.ServiceName.Name = "ServiceName"
        Me.ServiceName.Width = 99
        '
        'fname1
        '
        Me.fname1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fname1.HeaderText = "First Name"
        Me.fname1.Name = "fname1"
        Me.fname1.Width = 82
        '
        'city
        '
        Me.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.city.HeaderText = "City"
        Me.city.Name = "city"
        Me.city.Width = 49
        '
        'listprice
        '
        Me.listprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.listprice.HeaderText = "Price"
        Me.listprice.Name = "listprice"
        Me.listprice.Width = 56
        '
        'orderid2
        '
        Me.orderid2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.orderid2.HeaderText = "Order ID"
        Me.orderid2.Name = "orderid2"
        Me.orderid2.Width = 72
        '
        'Quant
        '
        Me.Quant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Quant.HeaderText = "Quantity"
        Me.Quant.Name = "Quant"
        Me.Quant.Width = 71
        '
        'heystaff
        '
        Me.heystaff.AutoSize = True
        Me.heystaff.Font = New System.Drawing.Font("Microsoft JhengHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heystaff.Location = New System.Drawing.Point(44, 26)
        Me.heystaff.Name = "heystaff"
        Me.heystaff.Size = New System.Drawing.Size(137, 47)
        Me.heystaff.TabIndex = 1
        Me.heystaff.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Here are your current orders!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(622, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StaffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.heystaff)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "StaffForm"
        Me.Text = "StaffForm"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents heystaff As Label
    Friend WithEvents serviceid As DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As DataGridViewTextBoxColumn
    Friend WithEvents fname1 As DataGridViewTextBoxColumn
    Friend WithEvents city As DataGridViewTextBoxColumn
    Friend WithEvents listprice As DataGridViewTextBoxColumn
    Friend WithEvents orderid2 As DataGridViewTextBoxColumn
    Friend WithEvents Quant As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
