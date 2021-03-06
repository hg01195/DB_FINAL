﻿Imports System.Data.SqlClient

Public Class NewAdminForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmployeeListForm.Show()
        Me.Close()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim command As New SqlCommand("set IDENTITY_INSERT Employee ON; insert into Employee(EmployeeID, CustomerID, RewardsID, EmpFirstName, EmpLastName) values(@employeeid, @custid, @rewardsid, @fn, @ln);set IDENTITY_INSERT Employee OFF;", connection)
        Dim command2 As New SqlCommand("insert into Admins(AdminPassword, EmployeeID) values(@password, @employeeid);", connection)

        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fNameTextBox.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lNameTextBox.Text
        command.Parameters.Add("@employeeid", SqlDbType.Int).Value = employeeIDTextBox.Text
        command.Parameters.Add("@custid", SqlDbType.Int).Value = custIDTextBox.Text
        command.Parameters.Add("@rewardsid", SqlDbType.Int).Value = rewardsIDTextBox.Text
        command2.Parameters.Add("@employeeid", SqlDbType.Int).Value = employeeIDTextBox.Text
        command2.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text


        connection.Open()
        Try
            If command.ExecuteNonQuery() = 1 And command2.ExecuteNonQuery() = 1 Then

                MessageBox.Show("New Admin Added")

            End If
        Catch exception As FormatException
            MessageBox.Show("Invalid Input")

        End Try
        connection.Close()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim command As New SqlCommand("DELETE from Services where EmployeeID = @eid", connection)
        Dim command2 As New SqlCommand("DELETE from Admins where EmployeeID = @eid", connection)
        Dim command3 As New SqlCommand("DELETE from Employee Where EmployeeID = @eid", connection)

        ' The first attribute in the add function is what you put as the values in the insert statement
        command.Parameters.Add(New SqlParameter("@eid", SqlDbType.Int)).Value = employeeIDTextBox.Text
        command2.Parameters.Add(New SqlParameter("@eid", SqlDbType.Int)).Value = employeeIDTextBox.Text
        command3.Parameters.Add(New SqlParameter("@eid", SqlDbType.Int)).Value = employeeIDTextBox.Text

        'This line is used to actually open the connection to the database 
        connection.Open()

        Try
            command.ExecuteNonQuery()
            command2.ExecuteNonQuery()

            ''ExecuteNonQuery() executes the sql query you wrote out above
            command3.ExecuteNonQuery()

            MessageBox.Show("Admin Deleted")

        Catch exception As FormatException
            MessageBox.Show("Done")

        End Try
        connection.Close()
    End Sub

    Private Sub getButton_Click(sender As Object, e As EventArgs) Handles getButton.Click
        connection.Open()

        Dim command As New SqlCommand("SELECT * FROM Admins a join Employee e on a.EmployeeID = e.EmployeeID WHERE a.EmployeeID = @eid", connection)
        command.Parameters.Add(New SqlParameter("@eid", SqlDbType.Int)).Value = employeeIDTextBox.Text
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        Dim rowCount As Integer = table.Columns.Count
        Console.WriteLine(rowCount.ToString)
        Try
            custIDTextBox.Text = table.Rows(0)(3).ToString()
            employeeIDTextBox.Text = table.Rows(0)(1).ToString()
            rewardsIDTextBox.Text = table.Rows(0)(4).ToString()
            fNameTextBox.Text = table.Rows(0)(5).ToString()
            lNameTextBox.Text = table.Rows(0)(6).ToString()
            passwordTextBox.Text = table.Rows(0)(0).ToString()
        Catch excpetion As IndexOutOfRangeException
            MessageBox.Show("Employee Not Found")

        End Try
        connection.Close()
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        Dim command As New SqlCommand("UPDATE Admins SET AdminPassword = @pas WHERE EmployeeID = @empID", connection)
        Dim command2 As New SqlCommand("UPDATE Employee SET CustomerID = @custID, RewardsID = @rewardID, EmpFirstName = @fn, EmpLastName = @ln  WHERE EmployeeID = @empID", connection)

        command.Parameters.Add("@pas", SqlDbType.VarChar).Value = passwordTextBox.Text
        command2.Parameters.Add("@rewardID", SqlDbType.Int).Value = rewardsIDTextBox.Text
        command2.Parameters.Add("@fn", SqlDbType.VarChar).Value = fNameTextBox.Text
        command2.Parameters.Add("@ln", SqlDbType.VarChar).Value = lNameTextBox.Text
        command2.Parameters.Add("@custID", SqlDbType.Int).Value = custIDTextBox.Text
        command2.Parameters.Add("@empID", SqlDbType.Int).Value = employeeIDTextBox.Text
        command.Parameters.Add("@empID", SqlDbType.Int).Value = employeeIDTextBox.Text

        'This line is used to actually open the connection to the database 
        connection.Open()
        Try
            If command.ExecuteNonQuery() = 1 And command2.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Admin Updated")

            End If
        Catch excpetion As FormatException
            MessageBox.Show("Nothing To Update Or Employee Not Found")

        End Try

        'Closes the database connection
        connection.Close()
    End Sub

    Private Sub NewAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class