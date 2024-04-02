Public Class TiposMaisVendidos
    Dim objtipo As New ClsTipoProduto
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dgdgrade.DataSource = objtipo.TipoMaisVendido(DtpIni.Text, DtpFim.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New CrpGraTiposMaisVendidos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(Dgdgrade.DataSource)
        rpt.SummaryInfo.ReportTitle = "Gráfico Tipos mais Vendidos"
        FrmImp.ShowDialog()
    End Sub
End Class