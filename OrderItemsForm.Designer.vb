<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderItemsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgOrders = New System.Windows.Forms.DataGridView()
        'Me.MyGuitarShopDataSet = New Customer_GUI_MKI.MyGuitarShopDataSet()
        Me.MyGuitarShopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgServices = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.MyGuitarShopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGuitarShopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Ordered Products:"
        '
        'dgOrders
        '
        Me.dgOrders.AllowUserToAddRows = False
        Me.dgOrders.AllowUserToDeleteRows = False
        Me.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrders.Location = New System.Drawing.Point(34, 37)
        Me.dgOrders.Name = "dgOrders"
        Me.dgOrders.ReadOnly = True
        Me.dgOrders.Size = New System.Drawing.Size(961, 153)
        Me.dgOrders.TabIndex = 1
        '
        'MyGuitarShopDataSet
        '
        'Me.MyGuitarShopDataSet.DataSetName = "MyGuitarShopDataSet"
        'Me.MyGuitarShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MyGuitarShopDataSetBindingSource
        '
        'Me.MyGuitarShopDataSetBindingSource.DataSource = Me.MyGuitarShopDataSet
        Me.MyGuitarShopDataSetBindingSource.Position = 0
        '
        'dgServices
        '
        Me.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServices.Location = New System.Drawing.Point(34, 232)
        Me.dgServices.Name = "dgServices"
        Me.dgServices.Size = New System.Drawing.Size(961, 150)
        Me.dgServices.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Ordered Services:"
        '
        'OrderItemsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgServices)
        Me.Controls.Add(Me.dgOrders)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrderItemsForm"
        Me.Text = "OrderItemsForm"
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.MyGuitarShopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyGuitarShopDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgOrders As DataGridView
    'Friend WithEvents MyGuitarShopDataSet As MyGuitarShopDataSet
    Friend WithEvents MyGuitarShopDataSetBindingSource As BindingSource
    Friend WithEvents dgServices As DataGridView
    Friend WithEvents Label2 As Label
End Class
