Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class UpdateAddressForm

    'THIS NEEDS FORM BEFORE IT DONE BEFORE TESTING
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub UpdateAddressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM Addresses WHERE CustomerID = @cid", connection)
        command.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = custID
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        addressID = table.Rows(0)(0)
        ShippingLine1_TB.Text = table.Rows(0)(2).ToString()
        ShippingLine2_TB.Text = table.Rows(0)(3).ToString()
        ShippingCity_TB.Text = table.Rows(0)(4).ToString()
        ShippingState_TB.Text = table.Rows(0)(5).ToString()
        ShippingZip_TB.Text = table.Rows(0)(6).ToString()
        ShippingPhone_TB.Text = table.Rows(0)(7).ToString()

        Try
            BillingLine1_TB.Text = table.Rows(1)(2)
            BillingLine2_TB.Text = table.Rows(1)(3).ToString()
            BillingCity_TB.Text = table.Rows(1)(4).ToString()
            BillingState_TB.Text = table.Rows(1)(5).ToString()
            BillingZip_TB.Text = table.Rows(1)(6).ToString()
            BillingPhone_TB.Text = table.Rows(1)(7).ToString()
        Catch ex As Exception
        End Try

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        connection.Open()

        Dim command2 As New SqlCommand("UPDATE Addresses SET Line1 = @line1, Line2 = @line2, City = @city, State = @state, ZipCode = @zip, Phone = @phone WHERE CustomerID = @cid AND AddressID = @aid", connection)
        command2.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = custID
        command2.Parameters.Add(New SqlParameter("@aid", SqlDbType.Int)).Value = addressID
        'addressID += 1
        Console.WriteLine(addressID)

        command2.Parameters.Add("@line1", SqlDbType.VarChar).Value = ShippingLine1_TB.Text
        command2.Parameters.Add("@line2", SqlDbType.VarChar).Value = ShippingLine2_TB.Text
        command2.Parameters.Add("@city", SqlDbType.VarChar).Value = ShippingCity_TB.Text
        command2.Parameters.Add("@state", SqlDbType.VarChar).Value = ShippingState_TB.Text.ToUpper
        command2.Parameters.Add("@zip", SqlDbType.Int).Value = ShippingZip_TB.Text
        command2.Parameters.Add("@phone", SqlDbType.VarChar).Value = ShippingPhone_TB.Text

        command2.ExecuteNonQuery()

        Dim command3 As New SqlCommand("UPDATE Addresses SET Line1 = @Bline1, Line2 = @Bline2, City = @Bcity, State = @Bstate, ZipCode = @Bzip, Phone = @Bphone WHERE CustomerID = @Bcid AND AddressID = @aid + 1", connection)
        command3.Parameters.Add(New SqlParameter("@Bcid", SqlDbType.Int)).Value = custID
        command3.Parameters.Add(New SqlParameter("@aid", SqlDbType.Int)).Value = addressID
        Console.WriteLine(addressID)

        command3.Parameters.Add("@Bline1", SqlDbType.VarChar).Value = BillingLine1_TB.Text
        command3.Parameters.Add("@Bline2", SqlDbType.VarChar).Value = BillingLine2_TB.Text
        command3.Parameters.Add("@Bcity", SqlDbType.VarChar).Value = BillingCity_TB.Text
        command3.Parameters.Add("@Bstate", SqlDbType.VarChar).Value = BillingState_TB.Text.ToUpper
        command3.Parameters.Add("@Bzip", SqlDbType.Int).Value = BillingZip_TB.Text
        command3.Parameters.Add("@Bphone", SqlDbType.VarChar).Value = BillingPhone_TB.Text

        command3.ExecuteNonQuery()

        OrderItemsForm.Show()
        Me.Close()

        connection.Close()

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        OrderItemsForm.Show()
        Me.Close()
    End Sub
End Class