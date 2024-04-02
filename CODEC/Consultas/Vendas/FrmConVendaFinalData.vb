Public Class FrmConVendaFinalData
    Dim objfin As New ClsVendaFinal
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        DgdGrade.DataSource = objfin.Localizar_VendaFinalPeriodo(DtpIni.Text, DtpFim.Text)
        txtqntd.Text = objfin.LocalizarVendaFinal_COUNT(DtpIni.Text, DtpFim.Text)
        txttot.Text = objfin.LocalizarVendafinal_TOT(DtpIni.Text, DtpFim.Text)
        lblqntd.Visible = True
        lbltot.Visible = True
        txtqntd.Visible = True
        txttot.Visible = True
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub
End Class