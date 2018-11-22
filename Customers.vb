Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class CustomerForm
    'This opens the connection to the database. If you use it change the server name to your server name
    Dim connection As New SqlConnection(SQLcONN)

    'SUBMIT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim command As New SqlCommand("SET IDENTITY_INSERT Customers on;insert into Customers(CustomerID, EmailAddress, Password, FirstName, LastName, ShippingAddressID, BillingAddressID) values(@cid,@pas,@email,@fn,@ln,@billing,@shipping)", connection)

        command.Parameters.Add("@cid", SqlDbType.Int).Value = CustomerID_TB.Text
        command.Parameters.Add("@pas", SqlDbType.VarChar).Value = Password_TB.Text
        command.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailAddress_TB.Text
        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FirstName_TB.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LastName_TB.Text
        command.Parameters.Add("@billing", SqlDbType.Int).Value = BillingAddressID_TB.Text
        command.Parameters.Add("@shipping", SqlDbType.Int).Value = ShippingAddressID_TB.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Customer Added")

        Else

            MessageBox.Show("Customer Not Added")

        End If

        connection.Close()
    End Sub

    'EXIT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'DELETE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim command As New SqlCommand("DELETE from Customers where CustomerID = @cid", connection)

        ' The first attribute in the add function is what you put as the values in the insert statement
        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = CustomerID_TB.Text

        'This line is used to actually open the connection to the database 
        connection.Open()

        ''ExecuteNonQuery() executes the sql query you wrote out above
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Customer Deleted")

        Else

            MessageBox.Show("Customer Not Deleted")

        End If
    End Sub

    'GET
    Private Sub GetButton_Click(sender As Object, e As EventArgs) Handles GetButton.Click

        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM CUSTOMERS WHERE CustomerID = @cid", connection)
        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = CustomerID_TB.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim rowCount As Integer = table.Columns.Count
        Console.WriteLine(rowCount.ToString)

        Password_TB.Text = table.Rows(0)(1).ToString()
        EmailAddress_TB.Text = table.Rows(0)(2).ToString()
        FirstName_TB.Text = table.Rows(0)(3).ToString()
        LastName_TB.Text = table.Rows(0)(4).ToString()
        ShippingAddressID_TB.Text = table.Rows(0)(5).ToString()
        BillingAddressID_TB.Text = table.Rows(0)(6).ToString()

        connection.Close()

    End Sub

    Private Function Int() As Object
        Throw New NotImplementedException()
    End Function

    'UPDATE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim command As New SqlCommand("UPDATE CUSTOMERS SET Password = @pas, EmailAddress = @email, FirstName = @fn,LastName = @ln, BillingAddressID = @billing, ShippingAddressID = @shipping WHERE CustomerID = @cid", connection)

        command.Parameters.Add("@pas", SqlDbType.VarChar).Value = Password_TB.Text
        command.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailAddress_TB.Text
        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FirstName_TB.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LastName_TB.Text
        command.Parameters.Add("@billing", SqlDbType.Int).Value = BillingAddressID_TB.Text
        command.Parameters.Add("@shipping", SqlDbType.Int).Value = ShippingAddressID_TB.Text
        command.Parameters.Add("@cid", SqlDbType.Int).Value = CustomerID_TB.Text


        'This line is used to actually open the connection to the database 
        connection.Open()

        ''ExecuteNonQuery() executes the sql query you wrote out above
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Customer Updated")

        Else

            MessageBox.Show("Customer Not Updated")

        End If

        'Closes the database connection
        connection.Close()
    End Sub

    Private Sub AddressGuiButton_Click(sender As Object, e As EventArgs) Handles AddressGuiButton.Click
        AddressForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        OrdersForm.Show()
    End Sub

    Private Sub btnTemp_Click(sender As Object, e As EventArgs) Handles btnTemp.Click
        OrderItemsForm.Show()
    End Sub
End Class

