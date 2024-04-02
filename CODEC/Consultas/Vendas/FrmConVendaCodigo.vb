Public Class FrmConVendaCodigo
    Dim objven As New ClsVenda
    Private Sub FrmConVendaCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txtcampo_TextChanged(sender As Object, e As EventArgs) Handles Txtcampo.TextChanged
        If Txtcampo.Text <> "" Then
            DgdGrade.DataSource = objven.Localizar_Codigo(Txtcampo.Text)
        End If
    End Sub
End Class