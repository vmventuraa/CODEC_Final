Public Class FrmCadLançamentoDespesa
    Dim objControle As New ClsControle
    Dim objDespesa As New ClsDespesa
    Dim objLanDespesa As New ClsLançamentoDespesa
    Dim novo As Boolean
    Private Sub BtnNov_Click(sender As Object, e As EventArgs)
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCodEnt.Enabled = False
        TxtNcl.Enabled = False
        txtDes.Focus()
        novo = True
    End Sub

    Private Sub txtCodPro_TextChanged(sender As Object, e As EventArgs) Handles txtDes.TextChanged

    End Sub

    Private Sub txtCodPro_Validated(sender As Object, e As EventArgs) Handles txtDes.Validated
        If txtDes.Text <> "" Then
            If objDespesa.localizarComFiltro(txtDes.Text) = True Then
                TxtNcl.Text = objDespesa.Nome
            Else
                txtDes.Clear()
                TxtNcl.Clear()
                txtDes.Focus()
            End If
        End If
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs)
        If objControle.Testar_vazio(Me) = False Then
            objLanDespesa.Codigo = Val(txtCodEnt.Text)
            objLanDespesa.CodigoDespesa = txtDes.Text
            objLanDespesa.Data = txtData.Text
            objLanDespesa.Descricao = txtDesc.Text
            objLanDespesa.Valor = txtValor.Text

            objLanDespesa.gravar(novo)
            txtCodEnt.Text = objLanDespesa.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs)
        If objLanDespesa.excluir(txtCodEnt.Text) = True Then
            objControle.Limpar_tela(Me)

            BtnExc.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs)
        BtnLoc.Enabled = False

        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs)
        Call FrmCadLançamentoDespesa_Load(Nothing, Nothing)
    End Sub

    Private Sub FrmCadLançamentoDespesa_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmCadLançamentoDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        BtnExc.Enabled = False
        GrpLoc.Visible = False

    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs)
        If objLanDespesa.localizarComFiltro(TxtLoc.Text) Then
            Call mostrar_dadosDaClasse()
            TxtLoc.Clear()
            GrpLoc.Visible = False
            BtnLoc.Enabled = True
            BtnAlt.Enabled = True

        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
        If txtDes.Text <> "" Then
            If objDespesa.localizarComFiltro(txtDes.Text) = True Then
                TxtNcl.Text = objDespesa.Nome
            Else
                txtDes.Clear()
                TxtNcl.Clear()
                txtDes.Focus()
            End If
        End If
    End Sub
    Private Sub mostrar_dadosDaClasse()
        txtCodEnt.Text = objLanDespesa.Codigo
        txtDes.Text = objLanDespesa.CodigoDespesa
        txtData.Value = objLanDespesa.Data
        txtDesc.Text = objLanDespesa.Descricao
        txtValor.Text = objLanDespesa.Valor
        txtpag.Text = objLanDespesa.Pagamento

        BtnExc.Enabled = True
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs)
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub GrpLoc_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAlt_Click_1(sender As Object, e As EventArgs)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCodEnt.Enabled = False
        TxtNcl.Enabled = False

        novo = False
    End Sub

    Private Sub BtnNov_Click_1(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCodEnt.Enabled = False
        TxtNcl.Enabled = False
        txtDes.Focus()
        novo = True
        objControle.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub BtnGra_Click_1(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(GRPGERAL) = False Then
            objLanDespesa.Codigo = Val(txtCodEnt.Text)
            objLanDespesa.CodigoDespesa = txtDes.Text
            objLanDespesa.Data = txtData.Text
            objLanDespesa.Descricao = txtDesc.Text
            objLanDespesa.Valor = txtValor.Text
            objLanDespesa.Pagamento = txtpag.Text

            objLanDespesa.gravar(novo)
            txtCodEnt.Text = objLanDespesa.Codigo

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnExc_Click_1(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objLanDespesa.excluir(txtCodEnt.Text) = True Then
            objControle.Limpar_tela(Me)

            BtnExc.Enabled = False
        End If
    End Sub

    Private Sub BtnAlt_Click_2(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtCodEnt.Enabled = False
        TxtNcl.Enabled = False

        novo = False
    End Sub

    Private Sub BtnLoc_Click_1(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False

        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click_1(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadLançamentoDespesa_Load(Nothing, Nothing)
        objControle.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub BtnSai_Click_1(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click_1(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objLanDespesa.localizarComFiltro(TxtLoc.Text) Then
            Call mostrar_dadosDaClasse()
            TxtLoc.Clear()
            GrpLoc.Visible = False
            BtnLoc.Enabled = True
            BtnAlt.Enabled = True


        Else
            TxtLoc.Clear()
            TxtLoc.Focus()
        End If
        If txtDes.Text <> "" Then
            If objDespesa.localizarComFiltro(txtDes.Text) = True Then
                TxtNcl.Text = objDespesa.Nome

            Else
                txtDes.Clear()
                TxtNcl.Clear()
                txtDes.Focus()
            End If
        End If
    End Sub

    Private Sub TxtLoc_TextChanged_1(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged

    End Sub

    Private Sub txtValor_Validated(sender As Object, e As EventArgs) Handles txtValor.Validated

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpLanDespesa
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objLanDespesa.consultadespesa)
        rpt.SummaryInfo.ReportTitle = "Relatório de Lançamentos"
        FrmImp.ShowDialog()
    End Sub

    Private Sub GRPGERAL_Enter(sender As Object, e As EventArgs) Handles GRPGERAL.Enter

    End Sub
End Class