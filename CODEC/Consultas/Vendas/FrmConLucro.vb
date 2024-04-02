Public Class FrmConLucro
    Dim objfin As New ClsVendaFinal
    Dim objlan As New ClsLançamentoDespesa

    Private Sub FrmConLucro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        DgdGradeVenda.DataSource = objfin.Localizar_VendaFinalPeriodo(DtpIni.Text, DtpFim.Text)
        TxtQntdVenda.Text = objfin.LocalizarVendaFinal_COUNT(DtpIni.Text, DtpFim.Text)
        TxtTotVen.Text = objfin.LocalizarVendafinal_TOT(DtpIni.Text, DtpFim.Text)
        LblQntdVenda.Visible = True
        LblTotVenda.Visible = True
        TxtQntdVenda.Visible = True
        TxtTotVen.Visible = True

        DgdGradeDespesa.DataSource = objlan.Localizar_porDataGeral(DtpIni.Text, DtpFim.Text)
        TxtQntdDesp.Text = objlan.Despesa_COUNT(DtpIni.Text, DtpFim.Text)
        TxtTotDesp.Text = objlan.Localizar_porDataGeralTOT(DtpIni.Text, DtpFim.Text)
        LblQntdDesp.Visible = True
        LblTotDesp.Visible = True
        TxtQntdDesp.Visible = True
        TxtTotDesp.Visible = True

        LblLucro.Visible = True
        TxtLucro.Visible = True
        TxtLucro.Text = TxtTotVen.Text - TxtTotDesp.Text
    End Sub
End Class