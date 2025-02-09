Public Class Login
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblDaftar_Click(sender As Object, e As EventArgs) Handles lblDaftar.Click
        Me.Close()
        Registration.Show()
    End Sub
End Class