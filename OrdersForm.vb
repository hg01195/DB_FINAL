Imports System.Data.SqlClient

Public Class OrdersForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub btnGet_Click(sender As Object, e As EventArgs)
        connection.Open()

        'Dim command As New SqlCommand("SELECT * FROM ORDERS WHERE OrderID = @OrderID", connection)
        'command.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = tbOID.Text
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        'adapter.Fill(table)

        'Dim rowCount As Integer = table.Rows.Count
        'Console.WriteLine(rowCount.ToString)

        'tbCID.Text = table.Rows(0)(1).ToString()

        'tbSAdd.Text = table.Rows(0)(4).ToString()
        'tbCType.Text = table.Rows(0)(5).ToString()
        'tbCNum.Text = table.Rows(0)(6).ToString()
        'tbCExp.Text = table.Rows(0)(7).ToString()
        'tbBAdd.Text = table.Rows(0)(8).ToString()

        connection.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim command As New SqlCommand("
        insert into ORDERS(OrderID, CustomerID, OrderDate, ShipAddressID, CardType, CardNumber, CardExpires, BillingAddressID) 
        values(@oid,@cid,@od,@said,@ct,@cn,@ce,@baid)", connection)

        Dim rowNum As New SqlCommand("select count(OrderID) as num from ORDERS", connection)
        Dim rowA As New SqlDataAdapter(rowNum)
        Dim tableNum As New DataTable()
        rowA.Fill(tableNum)
        Dim orNum As Int16 = Convert.ToInt16(tableNum.Rows(0)(0)) + 1

        Dim addressid As New SqlCommand("select ShippingAddressID,BillingAddressID from CUSTOMERS where CustomerID = @CustomerID", connection)
        addressid.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int)).Value = custID
        Dim addi As New SqlDataAdapter(addressid)
        Dim addT As New DataTable()
        addi.Fill(addT)

        command.Parameters.Add("@oid", SqlDbType.Int).Value = orNum
        command.Parameters.Add("@cid", SqlDbType.Int).Value = custID
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        command.Parameters.Add("@od", SqlDbType.DateTime).Value = strDate  'String.Format("{0:dd/MM/yyyy}", DateTime.Now) 'should get current date
        'command.Parameters.Add("@sd", SqlDbType.DateTime).Value =  'might not work
        command.Parameters.Add("@said", SqlDbType.Int).Value = addT.Rows(0)(0).ToString()
        command.Parameters.Add("@ct", SqlDbType.VarChar).Value = tbCType.Text
        command.Parameters.Add("@cn", SqlDbType.Char).Value = tbCNum.Text
        command.Parameters.Add("@ce", SqlDbType.Char).Value = tbCExp.Text
        command.Parameters.Add("@baid", SqlDbType.Int).Value = addT.Rows(0)(1).ToString()

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Order Added")

        Else

            MessageBox.Show("Order Not Added")

        End If

        'to be removed and reworked when data of what is to be ordered is there
        'Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        'command2.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = orNum
        'Dim adapter As New SqlDataAdapter(command2)
        'Dim table As New DataTable()
        'adapter.Fill(table)

        'Dim disTotal As Double = 0
        'Dim grandTotal As Double = 0

        'txtRe.AppendText("Order Number: " + orNum.ToString())
        'txtRe.AppendText(Environment.NewLine)
        'txtRe.AppendText(Environment.NewLine)
        'txtRe.AppendText("Items Ordered: ")
        'For i As Int16 = 0 To table.Rows.Count - 1

        '    txtRe.AppendText(table.Rows(i)(1).ToString() + " " + table.Rows(i)(0).ToString() + "  $" + Math.Round(table.Rows(i)(2), 2).ToString())
        '    txtRe.AppendText(Environment.NewLine)
        '    txtRe.AppendText("                        ")
        '    disTotal += table.Rows(i)(3)
        '    grandTotal += table.Rows(i)(4)

        'Next

        'Dim command3 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        'command3.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = orNum
        'Dim adapter3 As New SqlDataAdapter(command3)
        'Dim table3 As New DataTable()
        'adapter.Fill(table3)

        'For i As Int16 = 0 To table.Rows.Count - 1

        '    txtRe.AppendText(table.Rows(i)(1).ToString() + " " + table.Rows(i)(0).ToString() + "  $" + Math.Round(table.Rows(i)(2), 2).ToString())
        '    txtRe.AppendText(Environment.NewLine)
        '    txtRe.AppendText("                        ")
        '    disTotal += table.Rows(i)(3)
        '    grandTotal += table.Rows(i)(4)

        'Next
        'txtRe.AppendText(Environment.NewLine)
        'txtRe.AppendText("Total Discount: $" + Math.Round(disTotal, 2).ToString())
        'txtRe.AppendText(Environment.NewLine)
        'txtRe.AppendText("Total Amount: $" + Math.Round(grandTotal, 2).ToString())


        connection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) 
        Dim command As New SqlCommand("DELETE from ORDERS where OrderID = @oid", connection)

        'command.Parameters.Add(New SqlParameter("@oid", SqlDbType.Int)).Value = tbOID.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Order Deleted")

        Else

            MessageBox.Show("Order Not Deleted")

            connection.Close()

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        connection.Open()
        'prints a receipt still a work in progress only prints 1 receipt
        Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        command2.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = 1
        Dim adapter As New SqlDataAdapter(command2)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim disTotal As Double = 0
        Dim grandTotal As Double = 0

        'txtRe.AppendText("Order Number: " + 13.ToString())
        txtRe.AppendText(table.Rows.Count)
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Items Ordered: ")
        For i As Int16 = 0 To table.Rows.Count - 1

            txtRe.AppendText(table.Rows(i)(1).ToString() + " " + table.Rows(i)(0).ToString() + "  $" + Math.Round(table.Rows(i)(2), 2).ToString())
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
            disTotal += table.Rows(i)(3)
            grandTotal += table.Rows(i)(4)

        Next
        txtRe.AppendText(Environment.NewLine)
        'txtRe.AppendText("Items Ordered: " + table.Rows(0)(1).ToString() + " " + table.Rows(0)(0).ToString() + "  $" + Math.Round(table.Rows(0)(2), 2).ToString())
        'txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Total Discount: $" + Math.Round(disTotal, 2).ToString())
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Total Amount: $" + Math.Round(grandTotal, 2).ToString())
        connection.Close()

    End Sub

    Private Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        command2.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = 7
        Dim adapter As New SqlDataAdapter(command2)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim disTotal As Double = 0
        Dim grandTotal As Double = 0

        txtRe.AppendText("Order Number: " + 7.ToString())
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Items Ordered: ")
        For i As Int16 = 0 To table.Rows.Count - 1

            txtRe.AppendText(table.Rows(i)(1).ToString() + " " + table.Rows(i)(0).ToString() + "  $" + Math.Round(table.Rows(i)(2), 2).ToString())
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
            disTotal += table.Rows(i)(3)
            grandTotal += table.Rows(i)(4)

        Next

        'Dim command3 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        'command3.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = 7
        'Dim adapter3 As New SqlDataAdapter(command3)
        'Dim table3 As New DataTable()
        'adapter3.Fill(table3)

        'For i As Int16 = 0 To table3.Rows.Count - 1

        '    txtRe.AppendText(table3.Rows(i)(1).ToString() + " " + table3.Rows(i)(0).ToString() + "  $" + Math.Round(table3.Rows(i)(2), 2).ToString())
        '    txtRe.AppendText(Environment.NewLine)
        '    txtRe.AppendText("                        ")
        '    disTotal += table3.Rows(i)(3)
        '    grandTotal += table3.Rows(i)(4)

        'Next

        Dim command4 As New SqlCommand("select s.ServiceName, Quantity, ItemPrice, oi.DiscountAmount, (ItemPrice - oi.DiscountAmount) as Total from ORDER_ITEMS oi, SERVICES s where oi.ServiceID = s.ServiceID and OrderID = @OrderID", connection)
        command4.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = 7
        Dim adapter4 As New SqlDataAdapter(command4)
        Dim table4 As New DataTable()
        adapter4.Fill(table4)

        For i As Int16 = 0 To table4.Rows.Count - 1

            txtRe.AppendText(table4.Rows(i)(1).ToString() + " " + table4.Rows(i)(0).ToString() + "  $" + Math.Round(table4.Rows(i)(2), 2).ToString())
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
            disTotal += table4.Rows(i)(3)
            grandTotal += table4.Rows(i)(4)

        Next

        If custRe = 1 Then
            txtRe.AppendText("Gold Rewards Membership $100")
            grandTotal += 100
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
        ElseIf custRe = 2 Then
            txtRe.AppendText("Platinum Rewards Membership $80")
            grandTotal += 80
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
        End If

        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Total Discount: $" + Math.Round(disTotal, 2).ToString())
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Total Amount: $" + Math.Round(grandTotal, 2).ToString())

        connection.Close()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub
End Class