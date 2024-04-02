Public Class FrmConVendaData
    Dim objven As New ClsVenda
    Dim objfin As New ClsVendaFinal
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If chkfinal.Checked = True And chkini.Checked = True Then
            DgdGrade.DataSource = objven.Localizar_porData(DtpIni.Text, DtpFim.Text)
            txtfechado.Text = objven.LocalizarVendaFechada_COUNT(DtpIni.Text, DtpFim.Text)
            txtaberto.Text = objven.LocalizarVendaAberta_COUNT(DtpIni.Text, DtpFim.Text)
            lblfechado.Visible = True
            txtfechado.Visible = True
            txtaberto.Visible = True
            lblaberto.Visible = True
        ElseIf chkfinal.Checked = True And chkini.Checked = False Then
            DgdGrade.DataSource = objven.Localizar_porDataFinal(DtpIni.Text, DtpFim.Text)
            txtfechado.Text = objven.LocalizarVendaFechada_COUNT(DtpIni.Text, DtpFim.Text)
            lblfechado.Visible = True
            txtfechado.Visible = True
            txtaberto.Visible = False
            lblaberto.Visible = False
        ElseIf chkfinal.Checked = False And chkini.Checked = True Then
            DgdGrade.DataSource = objven.Localizar_porDataInicial(DtpIni.Text, DtpFim.Text)
            txtaberto.Text = objven.LocalizarVendaAberta_COUNT(DtpIni.Text, DtpFim.Text)
            lblfechado.Visible = False
            txtfechado.Visible = False
            txtaberto.Visible = True
            lblaberto.Visible = True
        Else
            MessageBox.Show("Por Favor, selecione que tipo de venda deseja exibir")
            lblfechado.Visible = False
            txtfechado.Visible = False
            txtaberto.Visible = False
            lblaberto.Visible = False
        End If

    End Sub

    Private Sub BtnOk_Validated(sender As Object, e As EventArgs) Handles BtnOk.Validated

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub FrmConVendaData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txtfechado.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As New CrpGraVendasFinalizadas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(DgdGrade.DataSource)
        rpt.SummaryInfo.ReportTitle = "Gráfico Venda Finalizadas"
        FrmImp.ShowDialog()
    End Sub
End Class