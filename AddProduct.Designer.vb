<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddProduct
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
        Me.PRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTSTableAdapter = New DB_FINAL.Database_FinalDataSetTableAdapters.PRODUCTSTableAdapter()
        Me.TableAdapterManager = New DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductID_TB = New System.Windows.Forms.TextBox()
        Me.ProductName_TB = New System.Windows.Forms.TextBox()
        Me.Description_TB = New System.Windows.Forms.TextBox()
        Me.DiscountPercent_TB = New System.Windows.Forms.TextBox()
        Me.ListPrice_TB = New System.Windows.Forms.TextBox()
        Me.StockNo_TB = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database_FinalDataSet
        '
        Me.Database_FinalDataSet.DataSetName = "Database_FinalDataSet"
        Me.Database_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUCTSBindingSource
        '
        Me.PRODUCTSBindingSource.DataMember = "PRODUCTS"
        Me.PRODUCTSBindingSource.DataSource = Me.Database_FinalDataSet
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ProductID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Discount Percent:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "List Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stock No:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 42)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductID_TB
        '
        Me.ProductID_TB.Location = New System.Drawing.Point(220, 70)
        Me.ProductID_TB.Name = "ProductID_TB"
        Me.ProductID_TB.Size = New System.Drawing.Size(150, 31)
        Me.ProductID_TB.TabIndex = 9
        '
        'ProductName_TB
        '
        Me.ProductName_TB.Location = New System.Drawing.Point(220, 110)
        Me.ProductName_TB.Name = "ProductName_TB"
        Me.ProductName_TB.Size = New System.Drawing.Size(150, 31)
        Me.ProductName_TB.TabIndex = 10
        '
        'Description_TB
        '
        Me.Description_TB.Location = New System.Drawing.Point(220, 152)
        Me.Description_TB.Multiline = True
        Me.Description_TB.Name = "Description_TB"
        Me.Description_TB.Size = New System.Drawing.Size(331, 187)
        Me.Description_TB.TabIndex = 11
        '
        'DiscountPercent_TB
        '
        Me.DiscountPercent_TB.Location = New System.Drawing.Point(220, 361)
        Me.DiscountPercent_TB.Name = "DiscountPercent_TB"
        Me.DiscountPercent_TB.Size = New System.Drawing.Size(150, 31)
        Me.DiscountPercent_TB.TabIndex = 12
        '
        'ListPrice_TB
        '
        Me.ListPrice_TB.Location = New System.Drawing.Point(220, 398)
        Me.ListPrice_TB.Name = "ListPrice_TB"
        Me.ListPrice_TB.Size = New System.Drawing.Size(150, 31)
        Me.ListPrice_TB.TabIndex = 13
        '
        'StockNo_TB
        '
        Me.StockNo_TB.Location = New System.Drawing.Point(220, 437)
        Me.StockNo_TB.Name = "StockNo_TB"
        Me.StockNo_TB.Size = New System.Drawing.Size(150, 31)
        Me.StockNo_TB.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(220, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 42)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(413, 648)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 42)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.Description, Me.DiscountPercent, Me.ListPrice, Me.StockNo})
        Me.DataGridView1.Location = New System.Drawing.Point(593, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1600, 678)
        Me.DataGridView1.TabIndex = 18
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
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(2474, 828)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StockNo_TB)
        Me.Controls.Add(Me.ListPrice_TB)
        Me.Controls.Add(Me.DiscountPercent_TB)
        Me.Controls.Add(Me.Description_TB)
        Me.Controls.Add(Me.ProductName_TB)
        Me.Controls.Add(Me.ProductID_TB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddProduct"
        Me.Text = "Products"
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database_FinalDataSet As Database_FinalDataSet
    Friend WithEvents PRODUCTSBindingSource As BindingSource
    Friend WithEvents PRODUCTSTableAdapter As Database_FinalDataSetTableAdapters.PRODUCTSTableAdapter
    Friend WithEvents TableAdapterManager As Database_FinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProductID_TB As TextBox
    Friend WithEvents ProductName_TB As TextBox
    Friend WithEvents Description_TB As TextBox
    Friend WithEvents DiscountPercent_TB As TextBox
    Friend WithEvents ListPrice_TB As TextBox
    Friend WithEvents StockNo_TB As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As DataGridViewTextBoxColumn
    Friend WithEvents ListPrice As DataGridViewTextBoxColumn
    Friend WithEvents StockNo As DataGridViewTextBoxColumn
End Class
