Imports System.Data.SqlClient

Public Class EmployeeListForm
    Dim connection As New SqlConnection("Server = JACOB; Database = DataBase_Final; Integrated Security = true")
    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub newEmployeeButton_Click(sender As Object, e As EventArgs) Handles newEmployeeButton.Click
        NewEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim Adpt As New SqlDataAdapter("Select * From Employee", connection)

        Dim ds As New DataSet()

        Adpt.Fill(ds, "Emp")

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub dataGridViewButton_Click(sender As Object, e As EventArgs) Handles dataGridViewButton.Click
        Dim adapter As New SqlDataAdapter
        Dim table As New DataTable
        Dim binding As New BindingSource

        connection.Open()

        Dim command As New SqlCommand("Select * From Employee", connection)
        adapter.SelectCommand = command
        adapter.Fill(table)
        binding.DataSource = table
        DataGridView1.DataSource = binding
        adapter.Update(table)

        connection.Close()
    End Sub
End Class