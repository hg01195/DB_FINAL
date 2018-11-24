Public Class HelloCustomerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ProductsButton.Click
        ProductsForm.Show()
        Me.Close()
    End Sub

    Private Sub ServicesButton_Click(sender As Object, e As EventArgs) Handles ServicesButton.Click
        ServicesForm.Show()
        Me.Close()
    End Sub

    Private Sub AccountInformationButton_Click(sender As Object, e As EventArgs) Handles AccountInformationButton.Click
        OrderItemsForm.Show()
        Me.Close()
    End Sub

    Private Sub RewardsProgramButton_Click(sender As Object, e As EventArgs) Handles RewardsProgramButton.Click
        RewardMembersForm.Show()
        Me.Close()
    End Sub
End Class