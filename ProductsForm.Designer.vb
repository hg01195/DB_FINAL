<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
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
        Me.ToServices = New System.Windows.Forms.Button()
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_FinalDataSet = New DB_FINAL.Database_FinalDataSet()
        Me.MyGuitarShopDataSet1 = New DB_FINAL.Database_FinalDataSet()
        Me.MyGuitarShopDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTSTableAdapter = New DB_FINAL.Database_FinalDataSetTableAdapters.PRODUCTSTableAdapter()
        Me.TableAdapterManager = New DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager()
        Me.PRODUCTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGuitarShopDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGuitarShopDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToServices
        '
        Me.ToServices.Location = New System.Drawing.Point(1012, 450)
        Me.ToServices.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ToServices.Name = "ToServices"
        Me.ToServices.Size = New System.Drawing.Size(129, 31)
        Me.ToServices.TabIndex = 1
        Me.ToServices.Text = "To Services"
        Me.ToServices.UseVisualStyleBackColor = True
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.Database_FinalDataSet
        '
        'Database_FinalDataSet
        '
        Me.Database_FinalDataSet.DataSetName = "Database_FinalDataSet"
        Me.Database_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyGuitarShopDataSet1
        '
        Me.MyGuitarShopDataSet1.DataSetName = "MyGuitarShopDataSet"
        Me.MyGuitarShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyGuitarShopDataSet1BindingSource
        '
        Me.MyGuitarShopDataSet1BindingSource.DataSource = Me.MyGuitarShopDataSet1
        Me.MyGuitarShopDataSet1BindingSource.Position = 0
        '
        'PRODUCTSTableAdapter
        '
        Me.PRODUCTSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PRODUCTSTableAdapter = Me.PRODUCTSTableAdapter
        Me.TableAdapterManager.REWARDS_MEMBERTableAdapter = Nothing
        Me.TableAdapterManager.REWARDS_SPECIFICATIONTableAdapter = Nothing
        Me.TableAdapterManager.SERVICESTableAdapter = Nothing
        Me.TableAdapterManager.STAFFTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PRODUCTSDataGridView
        '
        Me.PRODUCTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PRODUCTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.Description, Me.DiscountPercent, Me.ListPrice, Me.StockNo, Me.Amount})
        Me.PRODUCTSDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PRODUCTSDataGridView.Location = New System.Drawing.Point(8, 8)
        Me.PRODUCTSDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PRODUCTSDataGridView.Name = "PRODUCTSDataGridView"
        Me.PRODUCTSDataGridView.RowTemplate.Height = 33
        Me.PRODUCTSDataGridView.Size = New System.Drawing.Size(1000, 474)
        Me.PRODUCTSDataGridView.TabIndex = 1
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "ProductName"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'DiscountPercent
        '
        Me.DiscountPercent.HeaderText = "DiscountPercent"
        Me.DiscountPercent.Name = "DiscountPercent"
        Me.DiscountPercent.ReadOnly = True
        '
        'ListPrice
        '
        Me.ListPrice.HeaderText = "ListPrice"
        Me.ListPrice.Name = "ListPrice"
        Me.ListPrice.ReadOnly = True
        '
        'StockNo
        '
        Me.StockNo.HeaderText = "StockNo"
        Me.StockNo.Name = "StockNo"
        Me.StockNo.ReadOnly = True
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1012, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1012, 370)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add to Orders"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1012, 51)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1012, 412)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 26)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "To Orders"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1149, 500)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToServices)
        Me.Controls.Add(Me.PRODUCTSDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ProductsForm"
        Me.Text = "ProductsForm"
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyGuitarShopDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyGuitarShopDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyGuitarShopDataSet1 As Database_FinalDataSet
    Friend WithEvents MyGuitarShopDataSet1BindingSource As BindingSource
    Friend WithEvents ToServices As Button
    Friend WithEvents Database_FinalDataSet As Database_FinalDataSet
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents PRODUCTSTableAdapter As Database_FinalDataSetTableAdapters.PRODUCTSTableAdapter
    Friend WithEvents TableAdapterManager As Database_FinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PRODUCTSDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As DataGridViewTextBoxColumn
    Friend WithEvents ListPrice As DataGridViewTextBoxColumn
    Friend WithEvents StockNo As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
