Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class AddProduct

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Public Sub load_table()
        Dim connection As New SqlConnection(SQLcONN)
        Dim pid, pname, desc, discpct, lp, stkno
        connection.Open()
        Using getServices As New SqlCommand("SELECT * FROM products", connection)

            Dim readServices As SqlDataReader

            readServices = getServices.ExecuteReader()
            DataGridView1.Rows.Clear()
            While readServices.Read
                pid = readServices("ProductID").ToString()
                pname = readServices("ProductName").ToString()
                desc = readServices("Description").ToString()
                discpct = readServices("DiscountPercent").ToString()
                lp = readServices("ListPrice").ToString()
                stkno = readServices("StockNo").ToString()
                DataGridView1.Rows.Add(New String() {pid, pname, desc, discpct, lp, stkno})
            End While

        End Using
        connection.Close()
    End Sub

    Dim connection As New SqlConnection(SQLcONN)
    'Execution to open the sql and adjust
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    'Insert
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (String.IsNullOrEmpty(ProductName_TB.Text)) Then
        '    MessageBox.Show("Please at least enter a product name")
        'Else
        ' Dim insertQuery As String = "INSERT INTO PRODUCTS (ProductID,ProductName,Description,DiscountPercent,ListPrice,StockNo) 
        'VALUES ('" & ProductID_TB.Text & "','" & ProductName_TB.Text & "','" & Description_TB.Text & "','" & DiscountPercent_TB.Text & "','" & ListPrice_TB.Text & "','" & StockNo_TB.Text & "')"

        Dim insertQuery As New SqlCommand("SET IDENTITY_INSERT Products on;insert into Products(ProductID,ProductName, Description, DiscountPercent, ListPrice, StockNo) values(@pid,@pn,@desc,@dp,@lp,@sn)", connection)

        insertQuery.Parameters.Add("@pid", SqlDbType.Int).Value = ProductID_TB.Text
        insertQuery.Parameters.Add("@pn", SqlDbType.VarChar).Value = ProductName_TB.Text
        insertQuery.Parameters.Add("@desc", SqlDbType.VarChar).Value = Description_TB.Text
        insertQuery.Parameters.Add("@dp", SqlDbType.Int).Value = DiscountPercent_TB.Text
        insertQuery.Parameters.Add("@lp", SqlDbType.Int).Value = ListPrice_TB.Text
        insertQuery.Parameters.Add("@sn", SqlDbType.Int).Value = StockNo_TB.Text

            connection.Open()
        Try
            If insertQuery.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Product Added")
            Else
                MessageBox.Show("Product not added")
            End If
        Catch ex As FormatException
            MessageBox.Show("Invalid format")
        End Try


        connection.Close()

        'End If
        load_table()
    End Sub

    'Update
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (String.IsNullOrEmpty(ProductID_TB.Text)) Then
            MessageBox.Show("Please enter a Product ID")

        Else
            Dim updateQuery As New SqlCommand("UPDATE Products SET ProductName = @pn, Description = @desc, 
                DiscountPercent = @dc, ListPrice = @ls, StockNo = @sn WHERE ProductID = @pid", connection)
            updateQuery.Parameters.Add(New SqlParameter("@pid", SqlDbType.Int)).Value = ProductID_TB.Text
            updateQuery.Parameters.Add("@pn", SqlDbType.VarChar).Value = ProductName_TB.Text
            updateQuery.Parameters.Add("@Desc", SqlDbType.VarChar).Value = Description_TB.Text
            updateQuery.Parameters.Add("@dc", SqlDbType.Int).Value = DiscountPercent_TB.Text
            updateQuery.Parameters.Add("@ls", SqlDbType.Int).Value = ListPrice_TB.Text.ToUpper
            updateQuery.Parameters.Add("@sn", SqlDbType.Int).Value = StockNo_TB.Text


            connection.Open()
            Try
                If updateQuery.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Product Updated")
                Else
                    MessageBox.Show("Product not updated")
                End If
            Catch ex As FormatException
                MessageBox.Show("Invalid format")
            End Try


            connection.Close()
        End If
        load_table()
    End Sub

    'Delete
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (String.IsNullOrEmpty(ProductID_TB.Text)) Then
            MessageBox.Show("Please enter a Product ID")
        Else
            Dim deleteQuery1 As New SqlCommand("Delete from Products WHERE ProductID = @pid", connection)
            Dim deleteQUERY2 As New SqlCommand("Delete from Order_Items WHERE ProductID = @pid", connection)

            deleteQuery1.Parameters.Add(New SqlParameter("@pid", SqlDbType.Int)).Value = ProductID_TB.Text
            deleteQUERY2.Parameters.Add(New SqlParameter("@Pid", SqlDbType.Int)).Value = ProductID_TB.Text
            connection.Open()

            deleteQUERY2.ExecuteNonQuery()
            deleteQuery1.ExecuteNonQuery()

            'If deleteQuery1.ExecuteNonQuery() And deleteQUERY2.ExecuteNonQuery() = 1 Then
            '    MessageBox.Show("Product Deleted")
            'Else
            '    MessageBox.Show("Product Not Deleted")
            'End If

            connection.Close()
            load_table()
        End If
        load_table()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub
End Class