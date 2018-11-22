Imports System.Data.SqlClient
Imports Customer_GUI_MKI.GlobalVariables

Public Class StaffForm


    Private Sub StaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New SqlConnection(SQLcONN)
        Dim id, sname, fistname, city, price, oid, quantity
        connection.Open()
        ' Dim g = "Hey, " & staffID " here are your orders!"

        heystaff.Text = "Hey, " & FirstName
        Using getStaffOrders As New SqlCommand("SELECT S.ServiceID, S.ServiceName, cust.FirstName, s.City, s.ListPrice, oi.OrderID, OI.Quantity FROM SERVICES AS s
        JOIN STAFF as ss
        ON s.EmployeeID = ss.EmployeeID
        JOIN ORDER_ITEMS as oi
        ON s.ServiceID = oi.ServiceID
        JOIN ORDERS AS orr
        ON oi.OrderID = orr.OrderID
        JOIN CUSTOMERS as cust
        ON orr.CustomerID = cust.CustomerID
        WHERE ss.EmployeeID = @ide ",connection)

            Dim readOrders As SqlDataReader
            getStaffOrders.Parameters.AddWithValue("@ide", staffID)
            readOrders = getStaffOrders.ExecuteReader()
            While readOrders.Read
                id = readOrders("serviceid").ToString()
                sname = readOrders("ServiceName").ToString()
                fistname = readOrders("firstname").ToString()
                city = readOrders("city").ToString()
                price = readOrders("listprice").ToString()
                oid = readOrders("orderid").ToString()
                quantity = readOrders("Quantity").ToString()
                DataGridView2.Rows.Add(New String() {id, sname, fistname, city, price, oid, quantity})
            End While

            connection.Close()

        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub
End Class