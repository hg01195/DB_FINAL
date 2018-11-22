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

End Class