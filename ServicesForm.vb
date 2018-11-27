Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Net.Mime.MediaTypeNames

Public Class ServicesForm

    Private Sub ServicesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Public Sub load_table()
        Dim connection As New SqlConnection(SQLcONN)
        Dim sid, sname, desc, LPrice, c, discamt, eid
        connection.Open()
        Using getServices As New SqlCommand("SELECT * FROM Services", connection)

            Dim readServices As SqlDataReader

            readServices = getServices.ExecuteReader()
            SERVICESDataGridView.Rows.Clear()
            While readServices.Read
                sid = readServices("ServiceID").ToString()
                sname = readServices("ServiceName").ToString()
                desc = readServices("Description").ToString()
                LPrice = readServices("ListPrice").ToString()
                c = readServices("City").ToString()
                discamt = readServices("DiscountAmount")
                eid = readServices("EmployeeID")
                SERVICESDataGridView.Rows.Add(New String() {sid, sname, desc, LPrice, c, discamt, eid})
            End While

        End Using
        connection.Close()
    End Sub

    Private Sub ToProducts_Click(sender As Object, e As EventArgs) Handles ToProducts.Click
        ProductsForm.Show()
        Me.Close()
    End Sub

    'Log out button handler
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub SERVICESDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SERVICESDataGridView.CellDoubleClick
        Dim Message, Title, DefaultQ As String
        Message = "Quantity?"
        Title = "Enter Quantity"
        DefaultQ = "0"

        Dim selectedRowIndex As Integer

        selectedRowIndex = e.RowIndex()

        Dim rows As New DataGridViewRow()

        rows = SERVICESDataGridView.Rows(selectedRowIndex)

        Dim quantity As String

        quantity = InputBox(Message, Title, DefaultQ)
        rows.Cells(7).Value = Integer.Parse(quantity)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To SERVICESDataGridView.RowCount - 1
            If String.IsNullOrEmpty(SERVICESDataGridView.Rows(i).Cells(7).Value) = False And SERVICESDataGridView.Rows(i).Cells(6).Value > 0 Then
                ssale1(i) = SERVICESDataGridView.Rows(i).Cells(0).Value
                ssale2(i) = SERVICESDataGridView.Rows(i).Cells(7).Value
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HelloCustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrdersForm.Show()
        Me.Close()
    End Sub
End Class