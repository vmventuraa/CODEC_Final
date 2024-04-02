Public Class FrmCadProduto
    Dim objcontrole As New ClsControle
    Dim objpro As New ClsProduto
    Dim objtip As New ClsTipoProduto
    Dim objforn As New ClsFornecedor
    Dim novo As Boolean


    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoes(Me, False)
        'txtfor.Enabled = False
        'cbotip.Enabled = False
        txtfor.Enabled = False
        GrpLoc.Visible = False
        BtnLocForn.Enabled = True
        CboTip.Enabled = True
        TxtCod.Focus()
        novo = True
        objcontrole.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objcontrole.Testar_vazio(GRPGERAL) = False Then
            objpro.Codigo = Val(TxtCod.Text)

            objpro.Nome = TxtNom.Text
            objpro.Fornecedor = txtcodfor.Text
            objpro.Preço = txtpre.Text
            objpro.Atual = txtqntd.Text
            objpro.Descrição = txtdesc.Text
            objpro.NCM = mskncm.Text
            objpro.Imposto = txtimp.Text
            objpro.Material = txtmat.Text
            objpro.Tipo = CboTip.SelectedValue

            objpro.gravar(novo)
            TxtCod.Text = objpro.Codigo
            objcontrole.Habilitar_tela(Me, False)
            objcontrole.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub FrmCadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Limpar_tela(Me)
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoes(Me, True)
        BtnLocForn.Enabled = False


        CboTip.DisplayMember = "NOMTIP"
        CboTip.ValueMember = "CODTIP"
        CboTip.DataSource = objtip.Localizar_tipo()



        CboTip.Text = ""
        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        GrpLoc.Visible = False
    End Sub
    Private Sub FrmCadProduto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objcontrole.Habilitar_tela(Me, True)
        objcontrole.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = False
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objpro.excluir(TxtCod.Text) Then
            objcontrole.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadProduto_Load(Nothing, Nothing)
        objcontrole.Limpar_tela(Me)
        objcontrole.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objpro.localizar(TxtLoc.Text) = True Then
            Call mostrar_dadosDaClasse()
            TxtLoc.Clear()
            GrpLoc.Visible = False
            BtnLoc.Enabled = True
        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
        If txtcodfor.Text <> "" Then
            If objforn.localizarComFiltro(txtcodfor.Text) = True Then
                txtfor.Text = objforn.Razao
            Else
                txtcodfor.Clear()
                txtfor.Clear()
                txtcodfor.Focus()
            End If
        End If
    End Sub
    Private Sub mostrar_dadosDaClasse()
       
       




        TxtCod.Text = objpro.Codigo
        TxtNom.Text = objpro.Nome
        txtcodfor.Text = objpro.Fornecedor
        Call txtcodfor_Validated(Nothing, Nothing)


        txtpre.Text = objpro.Preço
        txtqntd.Text = objpro.Atual
        txtdesc.Text = objpro.Descrição
        mskncm.Text = objpro.NCM
        txtimp.Text = objpro.Imposto
        txtmat.Text = objpro.Material
        CboTip.SelectedValue = objpro.Tipo








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

    Private Sub mskncm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskncm.KeyPress, txtqntd.KeyPress
        e.Handled = objcontrole.So_numeros(e.KeyChar)
    End Sub

    Private Sub mskncm_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskncm.MaskInputRejected

    End Sub

    Private Sub txtpre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpre.KeyPress, txtimp.KeyPress
        e.Handled = objcontrole.So_numeroseVirgula(e.KeyChar)
    End Sub


    Private Sub txtpre_TextChanged(sender As Object, e As EventArgs) Handles txtpre.TextChanged

    End Sub

    Private Sub BtnLocForn_Click(sender As Object, e As EventArgs) Handles BtnLocForn.Click
        FrmConFornecedores.Owner = Me
        FrmConFornecedores.ShowDialog()
    End Sub

    Private Sub txtfor_TextChanged(sender As Object, e As EventArgs) Handles txtfor.TextChanged

    End Sub

    Private Sub TxtCod_TextChanged(sender As Object, e As EventArgs) Handles TxtCod.TextChanged

    End Sub

    Private Sub CboVdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTip.SelectedIndexChanged

    End Sub

    Private Sub txtcodfor_TextChanged(sender As Object, e As EventArgs) Handles txtcodfor.TextChanged

    End Sub

    Private Sub txtcodfor_Validated(sender As Object, e As EventArgs) Handles txtcodfor.Validated
        If txtcodfor.Text <> "" Then
            If objforn.localizarComFiltro(txtcodfor.Text) = True Then
                txtfor.Text = objforn.Razao
            Else
                txtcodfor.Clear()
                txtfor.Clear()
                txtcodfor.Focus()
            End If
        End If
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpProdutos
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objpro.consultaprodutos)
        rpt.SummaryInfo.ReportTitle = "Relatório de Produtos"
        FrmImp.ShowDialog()
    End Sub
End Class