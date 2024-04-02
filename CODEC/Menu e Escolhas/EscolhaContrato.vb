Public Class EscolhaContrato

    Private Sub BtnConCod_Click(sender As Object, e As EventArgs) Handles BtnConTranp.Click
        Dim rpt As New CrpContratoTransporte
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Contrato de Transporte"
        FrmImp.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BtnConSeg_Click(sender As Object, e As EventArgs) Handles BtnConSeg.Click
        Dim rpt As New CrpContratoSegurança
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Contrato de Segurança"
        FrmImp.ShowDialog()
        Me.Close()
    End Sub
End Class