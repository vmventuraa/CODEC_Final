Public Class Login

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtLogin.Text.ToString <> "UPPER" Then

            MessageBox.Show("Login Incorreto")
            TxtLogin.Clear()
            TxtLogin.Focus()
        ElseIf TxtSenha.Text <> "123" Then
            MessageBox.Show("Senha Incorreta")
            TxtSenha.Clear()
            TxtSenha.Focus()
        Else
            FrmMenu.Show()
            Me.Hide()


        End If
    End Sub

    Private Sub TxtLogin_TextChanged(sender As Object, e As EventArgs) Handles TxtLogin.TextChanged

    End Sub
End Class