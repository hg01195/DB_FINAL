Imports System.Data.SqlClient

Public Class OrdersForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM ORDERS WHERE OrderID = @OrderID", connection)
        command.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = tbOID.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        'Dim rowCount As Integer = table.Rows.Count
        'Console.WriteLine(rowCount.ToString)

        tbCID.Text = table.Rows(0)(1).ToString()
        tbODate.Text = table.Rows(0)(2).ToString()
        tbSDate.Text = table.Rows(0)(3).ToString()
        tbSAdd.Text = table.Rows(0)(4).ToString()
        tbCType.Text = table.Rows(0)(5).ToString()
        tbCNum.Text = table.Rows(0)(6).ToString()
        tbCExp.Text = table.Rows(0)(7).ToString()
        tbBAdd.Text = table.Rows(0)(8).ToString()

        connection.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim command As New SqlCommand("
        insert into ORDERS(OrderID, CustomerID, OrderDate, ShipDate, ShipAddressID, CardType, CardNumber, CardExpires, BillingAddressID) 
        values(@oid,@cid,@od,@sd,@said,@ct,@cn,@ce,@baid)", connection)

        Dim rowNum As New SqlCommand("select count(OrderID) as num from ORDERS", connection)
        Dim rowA As New SqlDataAdapter(rowNum)
        Dim tableNum As New DataTable()
        rowA.Fill(tableNum)
        Dim orNum As Int16 = Convert.ToInt16(tableNum.Rows(0)(0)) + 1

        command.Parameters.Add("@oid", SqlDbType.Int).Value = orNum
        command.Parameters.Add("@cid", SqlDbType.Int).Value = custID
        command.Parameters.Add("@od", SqlDbType.DateTime).Value = tbODate.Text 'found out how to get current date
        command.Parameters.Add("@sd", SqlDbType.DateTime).Value = vbNull 'might not work
        command.Parameters.Add("@said", SqlDbType.Int).Value = 1 'testing need to write a something to get these
        command.Parameters.Add("@ct", SqlDbType.VarChar).Value = tbCType.Text
        command.Parameters.Add("@cn", SqlDbType.Char).Value = tbCNum.Text
        command.Parameters.Add("@ce", SqlDbType.Char).Value = tbCExp.Text
        command.Parameters.Add("@baid", SqlDbType.Int).Value = 1

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Order Added")

        Else

            MessageBox.Show("Order Not Added")

        End If

        'prints a receipt still a work in progress only prints 1 receipt
        Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = 3", connection)
        command2.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = orNum
        Dim adapter As New SqlDataAdapter(command2)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim disTotal As Double = 0
        Dim grandTotal As Double = 0

        txtRe.AppendText("Order Number: " + orNum.ToString())
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
        txtRe.AppendText("Total Discount: $" + Math.Round(disTotal, 2).ToString())
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Total Amount: $" + Math.Round(grandTotal, 2).ToString())
        connection.Close()

        connection.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim command As New SqlCommand("DELETE from ORDERS where OrderID = @oid", connection)

        command.Parameters.Add(New SqlParameter("@oid", SqlDbType.Int)).Value = tbOID.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Order Deleted")

        Else

            MessageBox.Show("Order Not Deleted")

            connection.Close()

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        connection.Open()
        'prints a receipt still a work in progress only prints 1 receipt
        Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = 3", connection)
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
End Class