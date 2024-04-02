Public Class FrmConEntradaProdutoCodigoNome
    Dim objent As New ClsEntProd
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        If IsNumeric(TxtCampo.Text) Then
            DgdGrade.DataSource = objent.LocalizarEntradaCodigo(TxtCampo.Text)
        Else
            DgdGrade.DataSource = objent.LocalizarEntradaNome(TxtCampo.Text)
        End If
    End Sub
End Class