Imports System.Data.SqlClient

Public Class UserLoginForm
    Dim connection As New SqlConnection(SQLcONN)

    Private Sub NewUser_Click(sender As Object, e As EventArgs) Handles newUserButton.Click
        NewUserForm.Show()
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        Dim custQuery As String = "select * from customers where FirstName = @fname and Password = @password"
        Dim staffQuery As String = "select * from employee e left join staff s on e.employeeID = s.employeeID where EmpFirstName = @fname and Password = @password"
        Dim adminQuery As String = "select * from employee e left join admins a on e.employeeID = a.employeeID where EmpFirstName = @fname and AdminPassword = @password"

        Using command As New SqlCommand(custQuery, connection)
            Using command2 As New SqlCommand(staffQuery, connection)
                Using command3 As New SqlCommand(adminQuery, connection)
                    connection.Open()

                    'Customer Query
                    command.Parameters.AddWithValue("@fname", fNameTextBox.Text)
                    command.Parameters.AddWithValue("@password", passwordTextBox.Text)
                    'Staff Query
                    command2.Parameters.AddWithValue("@fname", fNameTextBox.Text)
                    command2.Parameters.AddWithValue("@password", passwordTextBox.Text)
                    'Admin Query
                    command3.Parameters.AddWithValue("@fname", fNameTextBox.Text)
                    command3.Parameters.AddWithValue("@password", passwordTextBox.Text)

                    FirstName = fNameTextBox.Text
                    custID = command.ExecuteScalar
                    staffID = command2.ExecuteScalar
                    adminID = command3.ExecuteScalar

                    'takes you to the customer form if they are a customer
                    If custID > 0 Then

                        CustomerForm.Show()
                        Me.Close()
                        'takes you to the staff form if they are staff
                    ElseIf staffID > 0 Then
                        StaffForm.Show()
                        Me.Close()
                        'takes you to the admin form if they are an admin
                    ElseIf adminID > 0 Then
                        AdminForm.Show()
                        Me.Close()
                    End If

                End Using
            End Using
        End Using
    End Sub
End Class