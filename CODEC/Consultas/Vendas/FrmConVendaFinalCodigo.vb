Public Class FrmConVendaFinalCodigo
    Dim objfin As New ClsVendaFinal
    Private Sub BtnOk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txtcampo_TextChanged(sender As Object, e As EventArgs) Handles Txtcampo.TextChanged
        If Txtcampo.Text <> "" Then
            DgdGrade.DataSource = objfin.Localizar_Codigo(Txtcampo.Text)
        End If

    End Sub
End Class