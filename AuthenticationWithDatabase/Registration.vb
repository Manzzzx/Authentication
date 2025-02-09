Imports MySql.Data.MySqlClient

Public Class Registration
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click

    End Sub
End Class