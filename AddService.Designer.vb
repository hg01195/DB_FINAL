<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddService
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DiscountAmount_TB = New System.Windows.Forms.TextBox()
        Me.City_TB = New System.Windows.Forms.TextBox()
        Me.ListPrice_TB = New System.Windows.Forms.TextBox()
        Me.Description_TB = New System.Windows.Forms.TextBox()
        Me.ServiceName_TB = New System.Windows.Forms.TextBox()
        Me.ServiceID_TB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SERVICESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_FinalDataSet = New DB_FINAL.Database_FinalDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SERVICESTableAdapter = New DB_FINAL.Database_FinalDataSetTableAdapters.SERVICESTableAdapter()
        Me.TableAdapterManager = New DB_FINAL.Database_FinalDataSetTableAdapters.TableAdapterManager()
        Me.EmployeeID_TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.SERVICESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(420, 648)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 42)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 42)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DiscountAmount_TB
        '
        Me.DiscountAmount_TB.Location = New System.Drawing.Point(227, 437)
        Me.DiscountAmount_TB.Name = "DiscountAmount_TB"
        Me.DiscountAmount_TB.Size = New System.Drawing.Size(150, 31)
        Me.DiscountAmount_TB.TabIndex = 30
        '
        'City_TB
        '
        Me.City_TB.Location = New System.Drawing.Point(227, 398)
        Me.City_TB.Name = "City_TB"
        Me.City_TB.Size = New System.Drawing.Size(150, 31)
        Me.City_TB.TabIndex = 29
        '
        'ListPrice_TB
        '
        Me.ListPrice_TB.Location = New System.Drawing.Point(227, 361)
        Me.ListPrice_TB.Name = "ListPrice_TB"
        Me.ListPrice_TB.Size = New System.Drawing.Size(150, 31)
        Me.ListPrice_TB.TabIndex = 28
        '
        'Description_TB
        '
        Me.Description_TB.Location = New System.Drawing.Point(227, 152)
        Me.Description_TB.Multiline = True
        Me.Description_TB.Name = "Description_TB"
        Me.Description_TB.Size = New System.Drawing.Size(331, 187)
        Me.Description_TB.TabIndex = 27
        '
        'ServiceName_TB
        '
        Me.ServiceName_TB.Location = New System.Drawing.Point(227, 110)
        Me.ServiceName_TB.Name = "ServiceName_TB"
        Me.ServiceName_TB.Size = New System.Drawing.Size(150, 31)
        Me.ServiceName_TB.TabIndex = 26
        '
        'ServiceID_TB
        '
        Me.ServiceID_TB.Location = New System.Drawing.Point(227, 70)
        Me.ServiceID_TB.Name = "ServiceID_TB"
        Me.ServiceID_TB.Size = New System.Drawing.Size(150, 31)
        Me.ServiceID_TB.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 42)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SERVICESBindingSource
        '
        Me.SERVICESBindingSource.DataMember = "SERVICES"
        Me.SERVICESBindingSource.DataSource = Me.Database_FinalDataSet
        '
        'Database_FinalDataSet
        '
        Me.Database_FinalDataSet.DataSetName = "Database_FinalDataSet"
        Me.Database_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 25)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Discount Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 398)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "List Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Service Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ServiceID:"
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
        'EmployeeID_TB
        '
        Me.EmployeeID_TB.Location = New System.Drawing.Point(227, 475)
        Me.EmployeeID_TB.Name = "EmployeeID_TB"
        Me.EmployeeID_TB.Size = New System.Drawing.Size(150, 31)
        Me.EmployeeID_TB.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "EmployeeID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceID, Me.ServiceName, Me.Description, Me.ListPrice, Me.City, Me.DiscountAmount, Me.EmployeeID})
        Me.DataGridView1.Location = New System.Drawing.Point(607, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1156, 665)
        Me.DataGridView1.TabIndex = 35
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(35, 711)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 44)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(420, 711)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(168, 44)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AddService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1823, 1037)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EmployeeID_TB)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DiscountAmount_TB)
        Me.Controls.Add(Me.City_TB)
        Me.Controls.Add(Me.ListPrice_TB)
        Me.Controls.Add(Me.Description_TB)
        Me.Controls.Add(Me.ServiceName_TB)
        Me.Controls.Add(Me.ServiceID_TB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddService"
        Me.Text = "Services"
        CType(Me.SERVICESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DiscountAmount_TB As TextBox
    Friend WithEvents City_TB As TextBox
    Friend WithEvents ListPrice_TB As TextBox
    Friend WithEvents Description_TB As TextBox
    Friend WithEvents ServiceName_TB As TextBox
    Friend WithEvents ServiceID_TB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Database_FinalDataSet As Database_FinalDataSet
    Friend WithEvents SERVICESBindingSource As BindingSource
    Friend WithEvents SERVICESTableAdapter As Database_FinalDataSetTableAdapters.SERVICESTableAdapter
    Friend WithEvents TableAdapterManager As Database_FinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeID_TB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents ServiceName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents ListPrice As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmount As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
