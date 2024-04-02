Public Class FrmConPagamento
    Dim objformas As New clsPagamento
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DgdGrade.DataSource = objformas.FormaUtilizadaGeral_COUNT(DtpIni.Text, DtpFim.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rpt As New CrpGraFormasMaisUtilizadas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(DgdGrade.DataSource)
        rpt.SummaryInfo.ReportTitle = "Gráfico Formas mais utilizadas"
        FrmImp.ShowDialog()
    End Sub
End Class