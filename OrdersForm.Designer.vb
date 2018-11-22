<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbOID = New System.Windows.Forms.TextBox()
        Me.tbCID = New System.Windows.Forms.TextBox()
        Me.tbODate = New System.Windows.Forms.TextBox()
        Me.tbSDate = New System.Windows.Forms.TextBox()
        Me.tbCType = New System.Windows.Forms.TextBox()
        Me.tbCNum = New System.Windows.Forms.TextBox()
        Me.tbCExp = New System.Windows.Forms.TextBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbSAdd = New System.Windows.Forms.TextBox()
        Me.tbBAdd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRe = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(656, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OrderID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(638, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CustomerID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-4, 397)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Order Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ship Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Card Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Card Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Card Expires"
        '
        'tbOID
        '
        Me.tbOID.Location = New System.Drawing.Point(700, 9)
        Me.tbOID.Name = "tbOID"
        Me.tbOID.Size = New System.Drawing.Size(100, 20)
        Me.tbOID.TabIndex = 7
        '
        'tbCID
        '
        Me.tbCID.Location = New System.Drawing.Point(700, 28)
        Me.tbCID.Name = "tbCID"
        Me.tbCID.Size = New System.Drawing.Size(100, 20)
        Me.tbCID.TabIndex = 8
        '
        'tbODate
        '
        Me.tbODate.Location = New System.Drawing.Point(61, 390)
        Me.tbODate.Name = "tbODate"
        Me.tbODate.Size = New System.Drawing.Size(141, 20)
        Me.tbODate.TabIndex = 9
        '
        'tbSDate
        '
        Me.tbSDate.Location = New System.Drawing.Point(61, 418)
        Me.tbSDate.Name = "tbSDate"
        Me.tbSDate.Size = New System.Drawing.Size(141, 20)
        Me.tbSDate.TabIndex = 10
        '
        'tbCType
        '
        Me.tbCType.Location = New System.Drawing.Point(81, 61)
        Me.tbCType.Name = "tbCType"
        Me.tbCType.Size = New System.Drawing.Size(100, 20)
        Me.tbCType.TabIndex = 11
        '
        'tbCNum
        '
        Me.tbCNum.Location = New System.Drawing.Point(81, 87)
        Me.tbCNum.Name = "tbCNum"
        Me.tbCNum.Size = New System.Drawing.Size(140, 20)
        Me.tbCNum.TabIndex = 12
        '
        'tbCExp
        '
        Me.tbCExp.Location = New System.Drawing.Point(81, 113)
        Me.tbCExp.Name = "tbCExp"
        Me.tbCExp.Size = New System.Drawing.Size(140, 20)
        Me.tbCExp.TabIndex = 13
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(575, 6)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(75, 23)
        Me.btnGet.TabIndex = 14
        Me.btnGet.Text = "Get"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(171, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(725, 421)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(725, 392)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(97, 139)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbSAdd
        '
        Me.tbSAdd.Location = New System.Drawing.Point(688, 162)
        Me.tbSAdd.Name = "tbSAdd"
        Me.tbSAdd.Size = New System.Drawing.Size(100, 20)
        Me.tbSAdd.TabIndex = 19
        '
        'tbBAdd
        '
        Me.tbBAdd.Location = New System.Drawing.Point(688, 277)
        Me.tbBAdd.Name = "tbBAdd"
        Me.tbBAdd.Size = New System.Drawing.Size(100, 20)
        Me.tbBAdd.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(272, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Please Enter Payment Info:"
        '
        'txtRe
        '
        Me.txtRe.Location = New System.Drawing.Point(303, 61)
        Me.txtRe.Multiline = True
        Me.txtRe.Name = "txtRe"
        Me.txtRe.Size = New System.Drawing.Size(379, 354)
        Me.txtRe.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 25)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Receipt:"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(222, 392)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 24
        Me.btnPrint.Text = "Test"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbBAdd)
        Me.Controls.Add(Me.tbSAdd)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.tbCExp)
        Me.Controls.Add(Me.tbCNum)
        Me.Controls.Add(Me.tbCType)
        Me.Controls.Add(Me.tbSDate)
        Me.Controls.Add(Me.tbODate)
        Me.Controls.Add(Me.tbCID)
        Me.Controls.Add(Me.tbOID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OrdersForm"
        Me.Text = "OrdersForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbOID As TextBox
    Friend WithEvents tbCID As TextBox
    Friend WithEvents tbODate As TextBox
    Friend WithEvents tbSDate As TextBox
    Friend WithEvents tbCType As TextBox
    Friend WithEvents tbCNum As TextBox
    Friend WithEvents tbCExp As TextBox
    Friend WithEvents btnGet As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents tbSAdd As TextBox
    Friend WithEvents tbBAdd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRe As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPrint As Button
End Class
