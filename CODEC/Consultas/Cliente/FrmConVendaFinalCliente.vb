Public Class FrmConVendaFinalCliente
    Dim objfin As New ClsVendaFinal
    Private Sub BtnOk_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Txtcampo_TextChanged(sender As Object, e As EventArgs) Handles Txtcampo.TextChanged
        If Txtcampo.Text <> "" Then
            If IsNumeric(Txtcampo.Text) Then
                DgdGrade.DataSource = objfin.LocalizarCliente_Codigo(Txtcampo.Text)
            Else
                DgdGrade.DataSource = objfin.LocalizarCliente_Nome(Txtcampo.Text)
            End If
        End If
    End Sub
End Class