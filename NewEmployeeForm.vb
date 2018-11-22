Public Class NewEmployeeForm
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        EmployeeListForm.Show()
        Me.Close()
    End Sub

    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        UserLoginForm.Show()
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
End Class