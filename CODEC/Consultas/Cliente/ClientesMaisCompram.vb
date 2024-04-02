Public Class ClientesMaisCompram
    Dim objfinal As New ClsVendaFinal
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dgdgrade.DataSource = objfinal.ClientesMaisCompram(DtpIni.Text, DtpFim.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New CrpVendaCliente
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(Dgdgrade.DataSource)
        rpt.SummaryInfo.ReportTitle = "Gráfico Vendas por clientes"
        FrmImp.ShowDialog()
    End Sub
End Class