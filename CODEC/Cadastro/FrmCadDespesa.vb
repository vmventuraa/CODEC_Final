Public Class FrmCadDespesa
    Dim objControle As New ClsControle
    Dim objdes As New ClsDespesa
    Dim novo As Boolean
    Private Sub BtnNov_Click(sender As Object, e As EventArgs)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        Txtnom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs)
        If objControle.Testar_vazio(Me) = False Then
            objdes.Codigo = Val(TxtCod.Text)
            objdes.Nome = Txtnom.Text
            objdes.gravar(novo)
            TxtCod.Text = objdes.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs)
        Call FrmCadDespesa_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs)
        If objdes.excluir(TxtCod.Text) Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmCadDespesa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmCadDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        GrpLoc.Visible = False
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objdes.localizarComFiltro(TxtLoc.Text) = True Then
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
        TxtCod.Text = objdes.Codigo
        Txtnom.Text = objdes.Nome

        BtnAlt.Enabled = True
        BtnExc.Enabled = True
        BtnImp.Enabled = True
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs)
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        Txtnom.Focus()
        novo = False
    End Sub

    Private Sub BtnNov_Click_1(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        Txtnom.Focus()
        novo = True
    End Sub

    Private Sub BtnGra_Click_1(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(Me) = False Then
            objdes.Codigo = Val(TxtCod.Text)
            objdes.Nome = Txtnom.Text
            objdes.gravar(novo)
            TxtCod.Text = objdes.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnAlt_Click_1(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        Txtnom.Focus()
        novo = False
    End Sub

    Private Sub BtnExc_Click_1(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objdes.excluir(TxtCod.Text) Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
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
        Call FrmCadDespesa_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnSai_Click_1(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs)
        Dim rpt As New CrpDespesas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SummaryInfo.ReportTitle = "Relatório de Despesas"
        FrmImp.ShowDialog()
    End Sub

    Private Sub BtnImp_Click_1(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpDespesas
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objdes.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Despesas"
        FrmImp.ShowDialog()
    End Sub
End Class