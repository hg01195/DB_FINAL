Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class ProductsForm

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        load_table()
    End Sub

    Public Sub load_table()
        Dim connection As New SqlConnection(SQLcONN)
        Dim pid, pname, desc, discpct, lp, stkno
        connection.Open()
        Using getServices As New SqlCommand("SELECT * FROM products", connection)

            Dim readServices As SqlDataReader

            readServices = getServices.ExecuteReader()
            PRODUCTSDataGridView.Rows.Clear()
            While readServices.Read
                pid = readServices("ProductID").ToString()
                pname = readServices("ProductName").ToString()
                desc = readServices("Description").ToString()
                discpct = readServices("DiscountPercent").ToString()
                lp = readServices("ListPrice").ToString()
                stkno = readServices("StockNo")
                PRODUCTSDataGridView.Rows.Add(New String() {pid, pname, desc, discpct, lp, stkno})
            End While

        End Using
        connection.Close()
    End Sub

    Private Sub ToServices_Click(sender As Object, e As EventArgs) Handles ToServices.Click
        ServicesForm.Show()
        Me.Close()
    End Sub

    'Log out button handler
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub PRODUCTSDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUCTSDataGridView.CellDoubleClick
        Dim Message, Title, DefaultQ As String
        Message = "Quantity?"
        Title = "Enter Quantity"
        DefaultQ = "0"

        Dim selectedRowIndex As Integer

        selectedRowIndex = e.RowIndex()

        Dim rows As New DataGridViewRow()

        rows = PRODUCTSDataGridView.Rows(selectedRowIndex)

        Dim quantity As String

        quantity = InputBox(Message, Title, DefaultQ)
        Try
            rows.Cells(6).Value = Integer.Parse(quantity)
        Catch ex As FormatException
            MessageBox.Show("Invalid input")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To PRODUCTSDataGridView.RowCount - 1
            If String.IsNullOrEmpty(PRODUCTSDataGridView.Rows(i).Cells(6).Value) = False And PRODUCTSDataGridView.Rows(i).Cells(6).Value > 0 Then
                psale1(i) = PRODUCTSDataGridView.Rows(i).Cells(0).Value
                psale2(i) = PRODUCTSDataGridView.Rows(i).Cells(6).Value
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrdersForm.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelloCustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub
End Class