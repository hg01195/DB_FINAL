Imports System.Data.SqlClient

Public Class EmployeeListForm
    Dim connection As New SqlConnection(SQLcONN)
    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub newStaffButton_Click(sender As Object, e As EventArgs) Handles newStaffButton.Click
        NewStaffForm.Show()
        Me.Close()
    End Sub

    Private Sub newAdminButton_Click(sender As Object, e As EventArgs) Handles newAdminButton.Click
        NewAdminForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim connection As New SqlConnection(SQLcONN)
        Dim id, rewid, custid, firstname, lastname
        connection.Open()
        Using getEmp As New SqlCommand("SELECT e.EmployeeID, e.RewardsID, e.CustomerID, e.EmpFirstName, e.EmpLastName FROM Employee e;", connection)

            Dim readEmp As SqlDataReader

            readEmp = getEmp.ExecuteReader()
            While readEmp.Read
                id = readEmp("EmployeeID").ToString()
                rewid = readEmp("RewardsID").ToString()
                custid = readEmp("CustomerID").ToString()
                firstname = readEmp("EmpFirstName").ToString()
                lastname = readEmp("EmpLastName").ToString()
                DataGridView1.Rows.Add(New String() {id, rewid, custid, firstname, lastname})
            End While
            connection.Close()
        End Using
    End Sub
End Class