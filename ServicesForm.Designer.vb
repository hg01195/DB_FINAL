<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ServicesForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Database_FinalDataSet = New DB_FINAL.Database_FinalDataSet()
        Me.SERVICESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERVICESTableAdapter = New DB_FINAL.Database_FinalDataSetTableAdapters.SERVICESTableAdapter()
        Me.TableAdapterManager = New DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager()
        Me.ToProducts = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SERVICESDataGridView = New System.Windows.Forms.DataGridView()
        Me.ServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICESDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database_FinalDataSet
        '
        Me.Database_FinalDataSet.DataSetName = "Database_FinalDataSet"
        Me.Database_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SERVICESBindingSource
        '
        Me.SERVICESBindingSource.DataMember = "SERVICES"
        Me.SERVICESBindingSource.DataSource = Me.Database_FinalDataSet
        '
        'SERVICESTableAdapter
        '
        Me.SERVICESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ADDRESSESTableAdapter = Nothing
        Me.TableAdapterManager.ADMINSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CUSTOMERSTableAdapter = Nothing
        Me.TableAdapterManager.EMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.ORDER_ITEMSTableAdapter = Nothing
        Me.TableAdapterManager.ORDERSTableAdapter = Nothing
        Me.TableAdapterManager.PRODUCTSTableAdapter = Nothing
        Me.TableAdapterManager.REWARDS_MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.REWARDS_SPECIFICATIONTableAdapter = Nothing
        Me.TableAdapterManager.SERVICESTableAdapter = Me.SERVICESTableAdapter
        Me.TableAdapterManager.STAFFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToProducts
        '
        Me.ToProducts.Location = New System.Drawing.Point(1667, 703)
        Me.ToProducts.Name = "ToProducts"
        Me.ToProducts.Size = New System.Drawing.Size(195, 49)
        Me.ToProducts.TabIndex = 1
        Me.ToProducts.Text = "To Products"
        Me.ToProducts.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1667, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SERVICESDataGridView
        '
        Me.SERVICESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SERVICESDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceID, Me.ServiceName, Me.Description, Me.ListPrice, Me.City, Me.DiscountAmount, Me.EmployeeID, Me.Amount})
        Me.SERVICESDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.SERVICESDataGridView.Name = "SERVICESDataGridView"
        Me.SERVICESDataGridView.RowTemplate.Height = 33
        Me.SERVICESDataGridView.Size = New System.Drawing.Size(1649, 740)
        Me.SERVICESDataGridView.TabIndex = 0
        '
        'ServiceID
        '
        Me.ServiceID.HeaderText = "ServiceID"
        Me.ServiceID.Name = "ServiceID"
        '
        'ServiceName
        '
        Me.ServiceName.HeaderText = "ServiceName"
        Me.ServiceName.Name = "ServiceName"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'ListPrice
        '
        Me.ListPrice.HeaderText = "ListPrice"
        Me.ListPrice.Name = "ListPrice"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'DiscountAmount
        '
        Me.DiscountAmount.HeaderText = "DiscountAmount"
        Me.DiscountAmount.Name = "DiscountAmount"
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1667, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add To Orders"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1667, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(195, 46)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1667, 639)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 46)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "To Orders"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ServicesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1874, 782)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToProducts)
        Me.Controls.Add(Me.SERVICESDataGridView)
        Me.Name = "ServicesForm"
        Me.Text = "ServicesForm"
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICESDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database_FinalDataSet As Database_FinalDataSet
    Friend WithEvents SERVICESBindingSource As BindingSource
    Friend WithEvents SERVICESTableAdapter As Database_FinalDataSetTableAdapters.SERVICESTableAdapter
    Friend WithEvents TableAdapterManager As Database_FinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToProducts As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SERVICESDataGridView As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents ListPrice As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
