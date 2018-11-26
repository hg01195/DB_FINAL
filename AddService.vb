Imports System.Data.SqlClient

Public Class AddService
    Dim STR As String
    Dim lid As String
    Private Sub AddService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub


    Public Sub load_table()
        'Try
        '    Str = "SELECT * FROM SERVICES"
        '    connection.Open()
        '    Dim Search As New SqlDataAdapter(STR, connection)
        '    Dim ds As DataSet = New DataSet
        '    Search.Fill(ds, "SERVICES")
        '    DataGridView1.DataSource = ds.Tables("SERVICES")
        '    connection.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    connection.Close()
        'End Try

        Dim connection As New SqlConnection(SQLcONN)
        Dim sid, sname, desc, LPrice, c, discamt, eid
        connection.Open()
        Using getServices As New SqlCommand("SELECT * FROM Services", connection)

            Dim readServices As SqlDataReader

            readServices = getServices.ExecuteReader()
            DataGridView1.Rows.Clear()
            While readServices.Read
                sid = readServices("ServiceID").ToString()
                sname = readServices("ServiceName").ToString()
                desc = readServices("Description").ToString()
                LPrice = readServices("ListPrice").ToString()
                c = readServices("City").ToString()
                discamt = readServices("DiscountAmount")
                eid = readServices("EmployeeID")
                DataGridView1.Rows.Add(New String() {sid, sname, desc, LPrice, c, discamt, eid})
            End While

        End Using
        connection.Close()
    End Sub

    Dim connection As New SqlConnection(SQLcONN)
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Dim insertQuery As String = "INSERT INTO SERVICES (ServiceID,ServiceName,Description,ListPrice,City,DiscountAmount,EmployeeID) 
        '    VALUES ('" & ServiceID_TB.Text & "','" & ServiceName_TB.Text & "','" & Description_TB.Text & "','" & ListPrice_TB.Text & "','" & City_TB.Text & "','" & DiscountAmount_TB.Text & "','" & EmployeeID_TB.Text & "')"

        '        ExecuteQuery(insertQuery)
        '        MessageBox.Show("New Product Added")

        Dim insertQuery As New SqlCommand("SET IDENTITY_INSERT Services on;insert into Services(ServiceID,ServiceName, Description, ListPrice, City, DiscountAmount, EmployeeID) values(@sid,@sn,@desc,@lp,@c,@dm,@eid)", connection)

        insertQuery.Parameters.Add("@sid", SqlDbType.Int).Value = ServiceID_TB.Text
        insertQuery.Parameters.Add("@sn", SqlDbType.VarChar).Value = ServiceName_TB.Text
        insertQuery.Parameters.Add("@desc", SqlDbType.VarChar).Value = Description_TB.Text
        insertQuery.Parameters.Add("@lp", SqlDbType.Int).Value = ListPrice_TB.Text
        insertQuery.Parameters.Add("@c", SqlDbType.VarChar).Value = City_TB.Text
        insertQuery.Parameters.Add("@dm", SqlDbType.Int).Value = DiscountAmount_TB.Text
        insertQuery.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID_TB.Text

        connection.Open()
        Try
            If insertQuery.ExecuteNonQuery() = 1 Then
                MessageBox.Show("New Service Added")
            Else
                MessageBox.Show("Service not added")
            End If
        Catch ex As FormatException
            MessageBox.Show("Invalid format")
        End Try
        connection.Close()
        load_table()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (String.IsNullOrEmpty(ServiceID_TB.Text)) Then
            MessageBox.Show("Please enter a Service ID")

        Else
            Dim updateQuery As New SqlCommand("UPDATE Services SET ServiceName = @sn, Description = @desc, 
                ListPrice = @lp, City = @c, DiscountAmount = @dm, EmployeeID = @eid WHERE ServiceID = @sid", connection)
            updateQuery.Parameters.Add(New SqlParameter("@sid", SqlDbType.Int)).Value = ServiceID_TB.Text
            updateQuery.Parameters.Add("@sn", SqlDbType.VarChar).Value = ServiceName_TB.Text
            updateQuery.Parameters.Add("@desc", SqlDbType.VarChar).Value = Description_TB.Text
            updateQuery.Parameters.Add("@lp", SqlDbType.Int).Value = ListPrice_TB.Text
            updateQuery.Parameters.Add("@c", SqlDbType.VarChar).Value = City_TB.Text
            updateQuery.Parameters.Add("@dm", SqlDbType.Int).Value = DiscountAmount_TB.Text
            updateQuery.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID_TB.Text


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (String.IsNullOrEmpty(ServiceID_TB.Text)) Then
            MessageBox.Show("Please enter a Product ID")
        Else
            Dim deleteQuery1 As New SqlCommand("Delete from Services WHERE ServiceID = @sid", connection)
            Dim deleteQUERY2 As New SqlCommand("Delete from Order_Items WHERE ServiceID = @sid", connection)

            deleteQuery1.Parameters.Add(New SqlParameter("@sid", SqlDbType.Int)).Value = ServiceID_TB.Text
            deleteQUERY2.Parameters.Add(New SqlParameter("@sid", SqlDbType.Int)).Value = ServiceID_TB.Text
            connection.Open()

            deleteQUERY2.ExecuteNonQuery()
            deleteQuery1.ExecuteNonQuery()
            MessageBox.Show("Successfully deleted")

            connection.Close()
            load_table()
        End If
        load_table()
    End Sub
End Class