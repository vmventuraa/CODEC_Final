Public Class FrmCadPagamento
    Dim objControle As New ClsControle
    Dim objformas As New clsPagamento
    Dim novo As Boolean

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtcodpag.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblforma.Click

    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtcodpag.Enabled = False
        txtnompag.Focus()
        novo = True
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs)
        Call FrmCadPagamento_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs)
        If objformas.excluir(txtcodpag.Text) Then
            objControle.Limpar_tela(Me)

            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub



    Private Sub txtnompag_TextChanged(sender As Object, e As EventArgs) Handles txtnompag.TextChanged

    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs)
        If objControle.Testar_vazio(Me) = False Then
            objformas.Codigo = Val(txtcodpag.Text)
            objformas.Nome = txtnompag.Text
            objformas.gravar(novo)
            txtcodpag.Text = objformas.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub
    Private Sub FrmCadPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)


        BtnAlt.Enabled = False

        GrpLoc.Visible = False
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs)
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtcodpag.Enabled = False
        txtnompag.Focus()
        novo = False
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objformas.localizarComFiltro(TxtLoc.Text) = True Then
            Call mostrar_dadosDaClasse()
            TxtLoc.Clear()
            GrpLoc.Visible = False
            BtnLoc.Enabled = True
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub
    Private Sub mostrar_dadosDaClasse()
        txtcodpag.Text = objformas.Codigo
        txtnompag.Text = objformas.Nome

        BtnAlt.Enabled = True

        BtnImp.Enabled = True
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnNov_Click_1(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtcodpag.Enabled = False
        txtnompag.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click_1(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(Me) = False Then
            objformas.Codigo = Val(txtcodpag.Text)
            objformas.Nome = txtnompag.Text
            objformas.gravar(novo)
            txtcodpag.Text = objformas.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnAlt_Click_1(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtcodpag.Enabled = False
        txtnompag.Focus()
        novo = False
    End Sub

    Private Sub BtnExc_Click_1(sender As Object, e As EventArgs)
        If objformas.excluir(txtcodpag.Text) Then
            objControle.Limpar_tela(Me)
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click_1(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click_1(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadPagamento_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click_1(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpFormas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objformas.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Formas de Pagamento"
        FrmImp.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim rpt As New CrpGraFormasMaisUtilizadas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Relatório de Formas de Pagamento"
        FrmImp.ShowDialog()
    End Sub
End Class