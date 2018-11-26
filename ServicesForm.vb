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

    End Sub
End Class