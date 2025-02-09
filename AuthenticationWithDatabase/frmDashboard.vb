Public Class frmDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Login.Show()

        Login.txtUsername.Clear()
        Login.txtPassword.Clear()

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub
End Class