Imports System.Data.SqlClient

Public Class OrderItemsForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub OrderItemsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        connection.Open()

        Dim command As New SqlCommand("select distinct oi.Quantity, p.ProductName, oi.ItemPrice, a.Line1,a.City,a.State,a.ZipCode,o.OrderDate,o.ShipDate
        from ORDERS o join ORDER_ITEMS oi on o.OrderID = oi.orderid
        join PRODUCTS p on oi.ProductID = p.ProductID join ADDRESSES a on o.CustomerID = a.CustomerID
        where o.CustomerID = @CustomerID", connection)
        command.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int)).Value = custID
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        dgOrders.DataSource = table

        Dim command2 As New SqlCommand("select distinct oi.Quantity, s.ServiceName, oi.ItemPrice, a.Line1,a.City,a.State,a.ZipCode,o.OrderDate
        from ORDERS o join ORDER_ITEMS oi on o.OrderID = oi.orderid
        join SERVICES s on oi.ServiceID = s.ServiceID join ADDRESSES a on o.CustomerID = a.CustomerID
        where o.CustomerID = @CustomerID", connection)
        command2.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int)).Value = custID
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        dgServices.DataSource = table2

        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateAddressForm.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HelloCustomerForm.Show()
        Me.Close()
    End Sub
End Class