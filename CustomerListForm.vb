﻿Imports System.Data.SqlClient

Public Class CustomerListForm
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim connection As New SqlConnection(SQLcONN)
        Dim id, rew, email, pass, firstname, lastname
        connection.Open()
        Using getCustomers As New SqlCommand("SELECT c.CustomerID,r.Type AS 'Rewards', 
        EmailAddress, Password, FirstName, LastName FROM CUSTOMERS AS c LEFT JOIN REWARDS_MEMBER AS r
        ON c.CustomerID = r.CustomerID;", connection)

            Dim readCustomers As SqlDataReader

            readCustomers = getCustomers.ExecuteReader()
            While readCustomers.Read
                id = readCustomers("CustomerID").ToString()
                rew = readCustomers("Rewards").ToString()
                email = readCustomers("EmailAddress").ToString()
                pass = readCustomers("Password").ToString()
                firstname = readCustomers("FirstName").ToString()
                lastname = readCustomers("LastName").ToString()
                DataGridView1.Rows.Add(New String() {id, rew, email, pass, firstname, lastname})
            End While

        End Using

    End Sub




    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        UserLoginForm.Show()
        Me.Close()
    End Sub

End Class