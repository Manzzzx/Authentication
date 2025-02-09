Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
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
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim name As String = txtName.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        'Validasi agar kolom terisi semua
        For Each item As Control In Me.Controls
            If (TypeOf item Is TextBox) Then
                If (item.Text = "") Then
                    MsgBox("Semua kolom harus diisi", vbExclamation)
                    Return
                Else
                    'Masukan ke database
                    MsgBox("Itu berhasil", vbInformation)

                End If

                Exit For
            End If
        Next
    End Sub
End Class