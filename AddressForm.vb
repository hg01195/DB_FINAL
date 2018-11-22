Imports System.Data.SqlClient

Public Class AddressForm
    'OVERALL CONNECTION
    Dim connection As New SqlConnection(SQLcONN)

    'SELECT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click


        Dim command As New SqlCommand("SET IDENTITY_INSERT Addresses on;insert into Addresses(AddressID, CustomerID, Line1, Line2, City, State, ZipCode, PhoneNumber) values(@AddressID,@CustomerID,@Line1,@Line2,@City,@State,@ZipCode,@PhoneNumber)", connection)

        command.Parameters.Add("@AddressID", SqlDbType.Int).Value = AddressID_TB.Text
        command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID_TB.Text
        command.Parameters.Add("@Line1", SqlDbType.VarChar).Value = AddressOne_TB.Text
        command.Parameters.Add("@Line2", SqlDbType.VarChar).Value = AddressTwo_TB.Text
        command.Parameters.Add("@City", SqlDbType.VarChar).Value = City_TB.Text
        command.Parameters.Add("@State", SqlDbType.VarChar).Value = State_TB.Text
        command.Parameters.Add("@ZipCode", SqlDbType.Int).Value = ZipCode_TB.Text
        command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber_TB.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Customer Added")

        Else

            MessageBox.Show("Customer Not Added")

        End If

        connection.Close()
    End Sub


    'EXIT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Close()
    End Sub

    'DELETE
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        Dim command As New SqlCommand("DELETE from Customers where AddressID = @AddressID", connection)

        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = CustomerID_TB.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Customer Deleted")

        Else

            MessageBox.Show("Customer Not Deleted")

            connection.Close()

        End If
    End Sub

    'GET W/ ADDRESS ID
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles GetAddressIDButton.Click
        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM ADDRESSES WHERE AddressID = @AddressID", connection)
        command.Parameters.Add(New SqlParameter("@AddressID", SqlDbType.Int)).Value = AddressID_TB.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        'Dim rowCount As Integer = table.Rows.Count
        'Console.WriteLine(rowCount.ToString)

        CustomerID_TB.Text = table.Rows(0)(1).ToString()
        AddressOne_TB.Text = table.Rows(0)(2).ToString()
        AddressTwo_TB.Text = table.Rows(0)(3).ToString()
        City_TB.Text = table.Rows(0)(4).ToString()
        State_TB.Text = table.Rows(0)(5).ToString()
        ZipCode_TB.Text = table.Rows(0)(6).ToString()
        PhoneNumber_TB.Text = table.Rows(0)(7).ToString()

        connection.Close()
    End Sub


    'GET W/ CUSTOMER ID
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles GetCustomerIDButton.Click
        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM ADDRESSES WHERE CustomerID = @CustomerID", connection)
        command.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int)).Value = CustomerID_TB.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        AddressID_TB.Text = table.Rows(0)(0).ToString()
        AddressOne_TB.Text = table.Rows(0)(2).ToString()
        AddressTwo_TB.Text = table.Rows(0)(3).ToString()
        City_TB.Text = table.Rows(0)(4).ToString()
        State_TB.Text = table.Rows(0)(5).ToString()
        ZipCode_TB.Text = table.Rows(0)(6).ToString()
        PhoneNumber_TB.Text = table.Rows(0)(7).ToString()

        connection.Close()
    End Sub

    'DELETE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class

