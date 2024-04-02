Public Class FrmTipoProduto
    Dim objControle As New ClsControle
    Dim objtpoprod As New ClsTipoProduto
    Dim novo As Boolean



    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = True

    End Sub

    Private Sub btnloc_Click(sender As Object, e As EventArgs) Handles btnloc.Click
        btnloc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(Me) = False Then
            objtpoprod.Codigo = Val(txtcod.Text)
            objtpoprod.Nome = txtnom.Text
          

            objtpoprod.gravar(novo)
            txtcod.Text = objtpoprod.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objtpoprod.excluir(txtcod.Text) Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If

    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmTipoProduto_Load(Nothing, Nothing)


    End Sub

    Private Sub FrmTipoProduto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmTipoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        BtnAlt.Enabled = False



    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objtpoprod.localizar(TxtLoc.Text) = True Then
            Call mostrar_dadosDaClasse()
            TxtLoc.Clear()
            GrpLoc.Visible = False
            btnloc.Enabled = True
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub mostrar_dadosDaClasse()
        txtcod.Text = objtpoprod.Codigo
        txtnom.Text = objtpoprod.Nome

        BtnAlt.Enabled = True
        BtnExc.Enabled = True
        BtnImp.Enabled = True
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpTipoProduto
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objtpoprod.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Tipos"
        FrmImp.ShowDialog()
    End Sub
End Class
