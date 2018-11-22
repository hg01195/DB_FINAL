Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class AddCustomerWithAddress
    Dim connection As New SqlConnection("Server= DESKTOP-IGRIGM7; Database = Database_Final; Integrated Security = true")

    'ADD CUSTOMER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddCustomerButton.Click
        Dim command As New SqlCommand("SET IDENTITY_INSERT Customers on;insert into Customers(CustomerID, FirstName, LastName, Password, EmailAddress, ShippingAddressID, BillingAddressID) values(@customerid,@firstname,@lastname,@password,@email,@sid,@bid)", connection)
        Dim findNextCustomerID As New SqlCommand("SELECT COUNT(*) + 1 FROM CUSTOMERS", connection)
        Dim findNextShippingID As New SqlCommand("SELECT TOP 1 BillingAddressID + 1 FROM Customers ORDER BY ShippingAddressID DESC", connection)
        Dim findNextBillingID As New SqlCommand("SELECT TOP 1 BillingAddressID + 1 FROM Customers ORDER BY BillingAddressID DESC", connection)
        Dim findAddressID As New SqlCommand("SELECT TOP 1 AddressID + 1 FROM Addresses ORDER BY AddressID DESC", connection)

        connection.Open()

        Dim findSID As Integer = findNextShippingID.ExecuteScalar
        Dim findCID As Integer = findNextCustomerID.ExecuteScalar
        Dim findBID As Integer = findNextBillingID.ExecuteScalar
        Dim findAID As Integer = findAddressID.ExecuteScalar

        command.Parameters.Add("@customerid", SqlDbType.Int).Value = findCID
        command.Parameters.Add("@firstname", SqlDbType.VarChar).Value = FirstName_TB.Text
        command.Parameters.Add("@lastname", SqlDbType.VarChar).Value = LastName_TB.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Password_TB.Text
        command.Parameters.Add("@email", SqlDbType.VarChar).Value = EmailAddress_TB.Text
        command.Parameters.Add("@sid", SqlDbType.Int).Value = findSID
        command.Parameters.Add("@bid", SqlDbType.Int).Value = findBID

        Dim command2 As New SqlCommand("insert into Addresses(AddressID, CustomerID, Line1, Line2, City, State, ZipCode, Phone) values(@aid,@cid,@line1,@line2,@city,@state,@zip,@phone)", connection)

        command2.Parameters.Add("@aid", SqlDbType.Int).Value = findAID
        command2.Parameters.Add("@cid", SqlDbType.Int).Value = findCID
        command2.Parameters.Add("@line1", SqlDbType.VarChar).Value = ShippingLine1_TB.Text
        command2.Parameters.Add("@line2", SqlDbType.VarChar).Value = ShippingLine2_TB.Text
        command2.Parameters.Add("@city", SqlDbType.VarChar).Value = ShippingCity_TB.Text
        command2.Parameters.Add("@state", SqlDbType.VarChar).Value = ShippingState_TB.Text.ToUpper
        command2.Parameters.Add("@zip", SqlDbType.Int).Value = ShippingZip_TB.Text
        command2.Parameters.Add("@phone", SqlDbType.VarChar).Value = ShippingPhone_TB.Text

        command.ExecuteNonQuery()
        command2.ExecuteNonQuery()
        If (CheckBox1.Checked) Then
            Dim command3 As New SqlCommand("insert into Addresses(AddressID, CustomerID, Line1, Line2, City, State, ZipCode, Phone) values(@aid,@cid,@line1,@line2,@city,@state,@zip,@phone)", connection)
            Dim command4 As New SqlCommand("UPDATE CUSTOMERS SET BillingAddressID = @billing WHERE CustomerID = @cid", connection)
            Dim findNextBillingIDPLusOne As New SqlCommand("SELECT TOP 1 BillingAddressID + 1 FROM Customers ORDER BY BillingAddressID DESC", connection)

            findSID = findNextShippingID.ExecuteScalar
            findBID = findNextBillingIDPlusOne.ExecuteScalar
            Console.writeLine(findBID)
            findAID = findAddressID.ExecuteScalar
    
            command4.Parameters.Add("@cid", SqlDbType.Int).Value = findCID  
            command4.Parameters.Add("@billing", SqlDbType.Int).Value = findBID

            command3.Parameters.Add("@aid", SqlDbType.Int).Value = findAID
            command3.Parameters.Add("@cid", SqlDbType.Int).Value = findCID
            command3.Parameters.Add("@line1", SqlDbType.VarChar).Value = BillingLine1_TB.Text
            command3.Parameters.Add("@line2", SqlDbType.VarChar).Value = BillingLine2_Tb.Text
            command3.Parameters.Add("@city", SqlDbType.VarChar).Value = BillingCity_TB.Text
            command3.Parameters.Add("@state", SqlDbType.VarChar).Value = BillingState_TB.Text.ToUpper
            command3.Parameters.Add("@zip", SqlDbType.Int).Value = BillingZip_TB.Text
            command3.Parameters.Add("@phone", SqlDbType.VarChar).Value = BillingPhone_TB.Text

            command4.ExecuteNonQuery()
            command3.ExecuteNonQuery()
        End If
        connection.Close()
    End Sub

    'EXIT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Function Int() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Label5.Show()
            BillingLine1_TB.Show()
            BillingLine2_TB.Show()
            BillingCity_TB.Show()
            BillingState_TB.Show()
            BillingZip_TB.Show()
            BillingPhone_TB.Show()
        End If

        If (CheckBox1.Checked = False) Then
            Label5.Hide()
            BillingLine1_TB.Hide()
            BillingLine2_TB.Hide()
            BillingCity_TB.Hide()
            BillingState_TB.Hide()
            BillingZip_TB.Hide()
            BillingPhone_TB.Hide()
        End If
    End Sub

    Private Sub AddCustomerWithAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class