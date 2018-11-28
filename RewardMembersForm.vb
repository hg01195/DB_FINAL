Imports System.Data.SqlClient

Public Class RewardMembersForm


    Private Sub Showcustomers_Click(sender As Object, e As EventArgs) Handles Showcustomers.Click

        'This opens the connection to the database. If you use it change the server name to your server name

        Dim conSQL As New SqlConnection(SQLcONN)

        conSQL.Open()

            Dim sql As String = "SELECT * FROM Rewards_Specification;"

            Dim cmd As New SqlCommand(sql, conSQL)

            Dim myreader As SqlDataReader = cmd.ExecuteReader()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HelloCustomerForm.Show()
        Me.Close()
    End Sub

    Private Sub AddToCart_Rewards_Click(sender As Object, e As EventArgs) Handles AddToCart_Rewards.Click
        If gold.Checked = True And platinum.Checked = True Then
            MessageBox.Show("Do not check both boxes")
        ElseIf gold.Checked Then
            custRe = 1
            MessageBox.Show("Added")
        ElseIf platinum.Checked Then
            custRe = 2
            MessageBox.Show("Added")
        ElseIf Employee.Checked Then
            If (GlobalVariables.adminID Is Nothing And GlobalVariables.staffID Is Nothing) Then
                    MessageBox.Show("You cannot add an employee reward because 
                    you are not an employee!")
                End If
            End If
        Else CustRe = 3
        End If
    End Sub
End Class