Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class CustomerForm
    'This opens the connection to the database. If you use it change the server name to your server name
    Dim connection As New SqlConnection("Server= DESKTOP-IGRIGM7; Database = Database_Final; Integrated Security = true")

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

            MessageBox.Show("New Customer Added With Address")

        Else

            MessageBox.Show("Customer Not Added")

        End If

        connection.Close()
    End Sub

    'EXIT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Function Int() As Object
        Throw New NotImplementedException()
    End Function
End Class

