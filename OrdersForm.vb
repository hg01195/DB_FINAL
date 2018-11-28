Imports System.Data.SqlClient

Public Class OrdersForm
    Dim connection As New SqlConnection(SQLcONN)
    Dim orNum As Int16

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim command As New SqlCommand("
        insert into ORDERS(OrderID, CustomerID, OrderDate, ShipAddressID, CardType, CardNumber, CardExpires, BillingAddressID) 
        values(@oid,@cid,@od,@said,@ct,@cn,@ce,@baid)", connection)

        Dim addressid As New SqlCommand("select ShippingAddressID,BillingAddressID from CUSTOMERS where CustomerID = @CustomerID", connection)
        addressid.Parameters.Add(New SqlParameter("@CustomerID", SqlDbType.Int)).Value = 1
        Dim addi As New SqlDataAdapter(addressid)
        Dim addT As New DataTable()
        addi.Fill(addT)

        Try

            command.Parameters.Add("@oid", SqlDbType.Int).Value = orNum
            command.Parameters.Add("@cid", SqlDbType.Int).Value = custID
            Dim regDate As DateTime = DateTime.Now
            Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
            command.Parameters.Add("@od", SqlDbType.DateTime).Value = strDate 'should get current date
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

            Dim rowNum As New SqlCommand("select count(*) as num from ORDER_ITEMS", connection)
            Dim rowA As New SqlDataAdapter(rowNum)
            Dim tableNum As New DataTable()
            rowA.Fill(tableNum)
            Dim iNum As Int16 = Convert.ToInt16(tableNum.Rows(0)(0)) + 1

            For i As Int16 = 0 To 9
                If psale1(i) > 0 Then
                    Dim command2 As New SqlCommand("
                    insert into ORDER_ITEMS(ItemID,OrderID, ProductID, ItemPrice, DiscountAmount, Quantity) 
                    values(@iID,@oID,@pID,@ip,@da,@qa)", connection)

                    Dim command3 As New SqlCommand("select ListPrice, (ListPrice * DiscountPercent/100) as DiscountAmount from PRODUCTS p where  p.ProductID = @ProductID", connection)
                    command3.Parameters.Add(New SqlParameter("@ProductID", SqlDbType.Int)).Value = psale1(i)
                    Dim adapter3 As New SqlDataAdapter(command3)
                    Dim table3 As New DataTable()
                    adapter3.Fill(table3)

                    command2.Parameters.Add("@iID", SqlDbType.Int).Value = iNum
                    iNum += 1
                    command2.Parameters.Add("@oID", SqlDbType.Int).Value = orNum
                    command2.Parameters.Add("@pID", SqlDbType.Int).Value = psale1(i)
                    command2.Parameters.Add("@ip", SqlDbType.Money).Value = table3.Rows(0)(0).ToString()
                    command2.Parameters.Add("@da", SqlDbType.Money).Value = table3.Rows(0)(1).ToString()
                    command2.Parameters.Add("@qa", SqlDbType.Int).Value = psale2(i)

                    If command2.ExecuteNonQuery() = 1 Then



                    Else

                        MessageBox.Show("Error adding Order")

                    End If
                End If

            Next

            For i As Int16 = 0 To 9
                If ssale1(i) > 0 Then
                    Dim command2 As New SqlCommand("
                insert into ORDER_ITEMS(ItemID,OrderID, ServiceID, ItemPrice, DiscountAmount, Quantity) 
                values(@iID,@oID,@sID,@ip,@da,@qa)", connection)

                    Dim command3 As New SqlCommand("select ListPrice, DiscountAmount from SERVICES s where  s.ServiceID = @ServiceID", connection)
                    command3.Parameters.Add(New SqlParameter("@ServiceID", SqlDbType.Int)).Value = ssale1(i)
                    Dim adapter3 As New SqlDataAdapter(command3)
                    Dim table3 As New DataTable()
                    adapter3.Fill(table3)

                    command2.Parameters.Add("@iID", SqlDbType.Int).Value = iNum
                    iNum += 1
                    command2.Parameters.Add("@oID", SqlDbType.Int).Value = orNum
                    command2.Parameters.Add("@sID", SqlDbType.Int).Value = ssale1(i)
                    command2.Parameters.Add("@ip", SqlDbType.Money).Value = table3.Rows(0)(0).ToString()
                    command2.Parameters.Add("@da", SqlDbType.Money).Value = table3.Rows(0)(1).ToString()
                    command2.Parameters.Add("@qa", SqlDbType.Int).Value = ssale2(i)

                    If command2.ExecuteNonQuery() = 1 Then



                    Else

                        MessageBox.Show("Error adding Order")

                    End If
                End If

            Next

        Catch ex As FormatException
            MessageBox.Show("Error! Please make sure the info you are entering is correct")
        End Try


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

    Private Sub OrdersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim rowNum As New SqlCommand("select count(OrderID) as num from ORDERS", connection)
        Dim rowA As New SqlDataAdapter(rowNum)
        Dim tableNum As New DataTable()
        rowA.Fill(tableNum)
        orNum = Convert.ToInt16(tableNum.Rows(0)(0)) + 1

        'Dim command2 As New SqlCommand("select ProductName, Quantity, ItemPrice, DiscountAmount, (ItemPrice - DiscountAmount) as Total from ORDER_ITEMS oi, PRODUCTS p where oi.ProductID = p.ProductID and OrderID = @OrderID", connection)
        'command2.Parameters.Add(New SqlParameter("@OrderID", SqlDbType.Int)).Value = orNum
        'Dim adapter As New SqlDataAdapter(command2)
        'Dim table As New DataTable()
        'adapter.Fill(table)

        Dim disTotal As Double = 0
        Dim grandTotal As Double = 0

        txtRe.AppendText("Order Number: " + orNum.ToString())
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText(Environment.NewLine)
        txtRe.AppendText("Items Ordered: ")

        For i As Int16 = 0 To 9
            If psale1(i) > 0 Then
                Dim command2 As New SqlCommand("select ProductName, ListPrice, (ListPrice * DiscountPercent) as DiscountAmount, (ListPrice - (ListPrice * DiscountPercent/100)) as Total from PRODUCTS p where  p.ProductID = @ProductID", connection)
                command2.Parameters.Add(New SqlParameter("@ProductID", SqlDbType.Int)).Value = psale1(i).ToString()
                Dim adapter As New SqlDataAdapter(command2)
                Dim table As New DataTable()
                adapter.Fill(table)


                txtRe.AppendText(psale2(i).ToString() + " " + table.Rows(0)(0).ToString() + "  $" + Math.Round(table.Rows(0)(3), 2).ToString())
                'txtRe.AppendText(1.ToString() + " " + table.Rows(0)(0).ToString() + "  $" + Math.Round(table.Rows(0)(1), 2).ToString())
                txtRe.AppendText(Environment.NewLine)
                txtRe.AppendText("                        ")
                disTotal += table.Rows(0)(1)
                grandTotal += table.Rows(0)(2)
            End If

        Next

        For i As Int16 = 0 To 9
            If ssale1(i) > 0 Then
                Dim command2 As New SqlCommand("select ServiceName, ListPrice, DiscountAmount, (ListPrice - DiscountAmount) as Total from SERVICES s where s.ServiceID = @ServiceID", connection)
                command2.Parameters.Add(New SqlParameter("@ServiceID", SqlDbType.Int)).Value = ssale1(i)
                Dim adapter As New SqlDataAdapter(command2)
                Dim table As New DataTable()
                adapter.Fill(table)


                txtRe.AppendText(ssale2(i).ToString() + " " + table.Rows(0)(0).ToString() + "  $" + Math.Round(table.Rows(0)(1), 2).ToString())
                txtRe.AppendText(Environment.NewLine)
                txtRe.AppendText("                        ")
                disTotal += table.Rows(0)(2)
                grandTotal += table.Rows(0)(3)
            End If


        Next

        If CustRe = 1 Then
            txtRe.AppendText("Gold Rewards Membership $100")
            grandTotal += 100
            txtRe.AppendText(Environment.NewLine)
            txtRe.AppendText("                        ")
        ElseIf CustRe = 2 Then
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ServicesForm.Show()
        Me.Close()
    End Sub
End Class