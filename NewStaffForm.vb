Imports System.Data.SqlClient

Public Class NewStaffForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        NewEmployeeForm.Show()
        Me.Close()
    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim command As New SqlCommand("set IDENTITY_INSERT Employee ON; insert into Employee(EmployeeID, CustomerID, RewardsID, EmpFirstName, EmpLastName) values(@employeeid, @custid, @rewardsid, @fn, @ln);set IDENTITY_INSERT Employee OFF;", connection)
        Dim command2 As New SqlCommand("insert into Staff(Password, EmployeeID, City) values(@password, @employeeid, @city);", connection)

        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fNameTextBox.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lNameTextBox.Text
        command.Parameters.Add("@employeeid", SqlDbType.Int).Value = employeeIDTextBox.Text
        command.Parameters.Add("@custid", SqlDbType.Int).Value = custIDTextBox.Text
        command.Parameters.Add("@rewardsid", SqlDbType.Int).Value = rewardsIDTextBox.Text
        command2.Parameters.Add("@employeeid", SqlDbType.Int).Value = employeeIDTextBox.Text
        command2.Parameters.Add("@password", SqlDbType.VarChar).Value = passwordTextBox.Text
        command2.Parameters.Add("@city", SqlDbType.VarChar).Value = cityTextBox.Text


        connection.Open()

        If command.ExecuteNonQuery() = 1 And command2.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New Staff Added")

        Else

            MessageBox.Show("Staff Not Added")

        End If

        connection.Close()
    End Sub
End Class