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
        Me.MyGuitarShopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgServices = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyGuitarShopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Ordered Products:"
        '
        'dgOrders
        '
        Me.dgOrders.AllowUserToAddRows = False
        Me.dgOrders.AllowUserToDeleteRows = False
        Me.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrders.Location = New System.Drawing.Point(45, 46)
        Me.dgOrders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgOrders.Name = "dgOrders"
        Me.dgOrders.ReadOnly = True
        Me.dgOrders.Size = New System.Drawing.Size(1281, 188)
        Me.dgOrders.TabIndex = 1
        '
        'dgServices
        '
        Me.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServices.Location = New System.Drawing.Point(45, 286)
        Me.dgServices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgServices.Name = "dgServices"
        Me.dgServices.Size = New System.Drawing.Size(1281, 185)
        Me.dgServices.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 252)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Ordered Services:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(45, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Change Addresses"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrderItemsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgServices)
        Me.Controls.Add(Me.dgOrders)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "OrderItemsForm"
        Me.Text = "OrderItemsForm"
        CType(Me.dgOrders, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button1 As Button
End Class
