Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class UpdateAddressForm

    Dim flag = False
    Dim boxShown = False

    'THIS NEEDS FORM BEFORE IT DONE BEFORE TESTING
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub UpdateAddressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
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
            flag = True
        End Try
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        connection.Open()

        Dim command2 As New SqlCommand("UPDATE Addresses SET Line1 = @line1, Line2 = @line2, City = @city, State = @state, ZipCode = @zip, Phone = @phone WHERE CustomerID = @cid AND AddressID = @aid", connection)
        command2.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = custID
        command2.Parameters.Add(New SqlParameter("@aid", SqlDbType.Int)).Value = addressID
        command2.Parameters.Add("@line1", SqlDbType.VarChar).Value = ShippingLine1_TB.Text
        command2.Parameters.Add("@line2", SqlDbType.VarChar).Value = ShippingLine2_TB.Text
        command2.Parameters.Add("@city", SqlDbType.VarChar).Value = ShippingCity_TB.Text
        command2.Parameters.Add("@state", SqlDbType.VarChar).Value = ShippingState_TB.Text.ToUpper
        command2.Parameters.Add("@zip", SqlDbType.Int).Value = ShippingZip_TB.Text
        command2.Parameters.Add("@phone", SqlDbType.VarChar).Value = ShippingPhone_TB.Text

        Try
            command2.ExecuteNonQuery()
            boxShown = False
        Catch ex As FormatException
            If (BillingZip_TB.Text = String.Empty) Then

            Else
                MessageBox.Show("Invalid Zip Code. Only integers are allowed at 10 length.")
                boxShown = True
            End If

        End Try

        If (flag = True) Then
            Dim command4 As New SqlCommand("insert into Addresses(AddressID, CustomerID, Line1, Line2, City, State, ZipCode, Phone) values(@aid,@cid,@line1,@line2,@city,@state,@zip,@phone)", connection)
            command4.Parameters.Add(New SqlParameter("@aid", SqlDbType.Int)).Value = addressID + 1
            command4.Parameters.Add(New SqlParameter("@cid", SqlDbType.Int)).Value = custID
            command4.Parameters.Add("@line1", SqlDbType.VarChar).Value = BillingLine1_TB.Text
            command4.Parameters.Add("@line2", SqlDbType.VarChar).Value = BillingLine2_TB.Text
            command4.Parameters.Add("@city", SqlDbType.VarChar).Value = BillingCity_TB.Text
            command4.Parameters.Add("@state", SqlDbType.VarChar).Value = BillingState_TB.Text.ToUpper
            command4.Parameters.Add("@zip", SqlDbType.Int).Value = BillingZip_TB.Text
            command4.Parameters.Add("@phone", SqlDbType.VarChar).Value = BillingPhone_TB.Text
            Try
                command4.ExecuteNonQuery()
                boxShown = False
            Catch ex As FormatException
                If (BillingZip_TB.Text = String.Empty) Then

                Else
                    MessageBox.Show("Invalid Zip Code. Only integers are allowed at 10 length.")
                    boxShown = True
                End If
            End Try
        Else
            Dim command3 As New SqlCommand("UPDATE Addresses SET Line1 = @Bline1, Line2 = @Bline2, City = @Bcity, State = @Bstate, ZipCode = @Bzip, Phone = @Bphone WHERE CustomerID = @Bcid AND AddressID = @aid + 1", connection)
            command3.Parameters.Add(New SqlParameter("@Bcid", SqlDbType.Int)).Value = custID
            command3.Parameters.Add(New SqlParameter("@aid", SqlDbType.Int)).Value = addressID
            command3.Parameters.Add("@Bline1", SqlDbType.VarChar).Value = BillingLine1_TB.Text
            command3.Parameters.Add("@Bline2", SqlDbType.VarChar).Value = BillingLine2_TB.Text
            command3.Parameters.Add("@Bcity", SqlDbType.VarChar).Value = BillingCity_TB.Text
            command3.Parameters.Add("@Bstate", SqlDbType.VarChar).Value = BillingState_TB.Text.ToUpper
            command3.Parameters.Add("@Bzip", SqlDbType.Int).Value = BillingZip_TB.Text
            command3.Parameters.Add("@Bphone", SqlDbType.VarChar).Value = BillingPhone_TB.Text
            Try
                command3.ExecuteNonQuery()
                boxShown = False
            Catch ex As FormatException
                If (BillingZip_TB.Text = String.Empty) Then

                Else
                    MessageBox.Show("Invalid Zip Code. Only integers are allowed at 10 length.")
                    boxShown = True
                End If
            End Try
        End If

        connection.Close()

        If (boxShown = True) Then

        Else
            OrderItemsForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        OrderItemsForm.Show()
        Me.Close()
    End Sub
End Class