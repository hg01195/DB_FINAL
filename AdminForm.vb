Public Class AdminForm
    Private Sub logOutButton_Click(sender As Object, e As EventArgs) Handles logOutButton.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

    Private Sub employeeListButton_Click(sender As Object, e As EventArgs) Handles employeeListButton.Click
        EmployeeListForm.Show()
        Me.Close()
    End Sub

    Private Sub productListButton_Click(sender As Object, e As EventArgs) Handles productListButton.Click
        ProductListForm.Show()
        Me.Close()
    End Sub

    Private Sub customerLsitButton_Click(sender As Object, e As EventArgs) Handles customerLsitButton.Click
        CustomerListForm.Show()
        Me.Close()
    End Sub
End Class