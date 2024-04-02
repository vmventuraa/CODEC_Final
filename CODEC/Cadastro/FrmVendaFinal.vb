Public Class FrmVendaFinal
    Dim objCli As New ClsCliente
    Dim objPro As New ClsProduto
    Dim objven As New ClsVenda
    Dim objitem As New ClsItem
    Dim objControle As New ClsControle
    Dim objformas As New clsPagamento
    Dim objfim As New ClsVendaFinal
    Dim objitemfim As New ClsItemFinal

    Dim qtd, estoque As Integer
    Dim pre, subtot As Single
    Dim geral As Single


    Private Sub FrmVendaFinal_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub
    Private Sub FrmVendaFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objcontrole.Habilitar_tela(Me, False)
        objcontrole.Habilitar_botoes(Me, True)
        objcontrole.Limpar_tela(Me)
        If DgdGrade.Rows.Count >= 1 Then
            DgdGrade.Rows.Clear()
        End If

        CboPag.DisplayMember = "NOMFOR"
        CboPag.ValueMember = "CODFOR"
        CboPag.DataSource = objformas.Localizar_formas()

        BtnLocPro.Enabled = False
        BtnOk.Enabled = False
        btnconf.Enabled = False
        DtpDat.Enabled = False
        CboPag.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnconf.Click


        Dim prod, nomprod As String
        Dim pre, subtotp As Single
        Dim qntd As Integer
        Dim objdtprovisorio = objven.localizar_grade(TxtCampo.Text)
        If objdtprovisorio.Rows.Count > 0 Then
            For x = 0 To objdtprovisorio.Rows.Count - 1
                prod = objdtprovisorio.Rows(x).Item(0)
                nomprod = objdtprovisorio.Rows(x).Item(1)
                qntd = objdtprovisorio.Rows(x).Item(2)
                pre = objdtprovisorio.Rows(x).Item(3)
                subtotp = objdtprovisorio.Rows(x).Item(4)
                DgdGrade.Rows.Add(prod, nomprod, pre, qntd, subtotp)
                subtot = subtotp
                geral = TxtGer.Text
                geral = geral + subtot
                TxtGer.Text = Format(geral, "0.00")

            Next



        End If

        If objven.ItemVenda(TxtCampo.Text) = True Then
            mostrar_dadosDaClasse()
            TxtPro.Enabled = True
            BtnLocPro.Enabled = True
            TxtQtd.Enabled = True
            BtnOk.Enabled = True
            CboPag.Enabled = True
            GRPGERAL.Enabled = True
            TxtPro.Focus()
        End If
        If ChkFinal.Checked = True Then
            BtnGra.Enabled = False
            TxtPro.Enabled = False
            TxtQtd.Enabled = False
            BtnOk.Enabled = False
            DgdGrade.Enabled = False
            CboPag.Enabled = False
            BtnLocPro.Enabled = False
        End If
    End Sub
    Private Sub TxtCli_Validated(sender As Object, e As EventArgs) Handles TxtCli.Validated
        If TxtCli.Text <> "" Then
            If objcli.localizarComFiltro(TxtCli.Text) = True Then
                TxtNcl.Text = objcli.Nome
            Else
                TxtCli.Clear()
                TxtNcl.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPro.Text <> "" And TxtSub.Text <> "" Then
            DgdGrade.Rows.Add(TxtPro.Text, TxtNpr.Text, TxtPre.Text, TxtQtd.Text, TxtSub.Text)

            subtot = TxtSub.Text
            geral = TxtGer.Text
            geral = geral + subtot
            TxtGer.Text = Format(geral, "0.00")
            objpro.baixar_estoque(TxtPro.Text, TxtQtd.Text)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub
    Private Sub mostrar_dadosDaClasse()


        TxtCli.Text = objven.Cliente
        Call TxtCli_Validated(Nothing, Nothing)
        TxtGer.Text = objven.Geral
        DtpDat.Text = objven.Data
        ChkFinal.Checked = objven.Final

    End Sub

    Private Sub TxtCli_TextChanged(sender As Object, e As EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub TxtCli_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCli.Validating

    End Sub

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_botoes(Me, False)
        objControle.Limpar_tela(Me)
        If DgdGrade.Rows.Count >= 1 Then
            DgdGrade.Rows.Clear()
        End If

        TxtCli.Enabled = True
      
        DgdGrade.Enabled = True
        TxtCampo.Enabled = True



        TxtCli.Enabled = False
        TxtNcl.Enabled = False
        DtpDat.Enabled = False

        TxtCampo.Focus()
        TxtGer.Text = 0
        objControle.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        If TxtCampo.Text = "" Then
            btnconf.Enabled = False
        Else
            btnconf.Enabled = True
        End If
    End Sub

    Private Sub TxtPro_TextChanged(sender As Object, e As EventArgs) Handles TxtPro.TextChanged

    End Sub

    Private Sub TxtPro_Validated(sender As Object, e As EventArgs) Handles TxtPro.Validated
        If TxtPro.Text <> "" Then
            If objPro.localizar(TxtPro.Text) = True Then
                TxtNpr.Text = objPro.Nome
                TxtPre.Text = Format(objPro.Preço, "0.00")
                estoque = objPro.Atual '
                TxtQtd.Clear()
                TxtQtd.Focus()
            Else
                TxtPro.Clear()
                TxtNpr.Clear()
                TxtPre.Clear()
                TxtQtd.Clear()
                TxtSub.Clear()
                TxtPro.Focus()
            End If
        End If
    End Sub

    Private Sub BtnLocPro_Click(sender As Object, e As EventArgs) Handles BtnLocPro.Click
        FrmConProduto.Owner = Me
        FrmConProduto.ShowDialog()
    End Sub

    Private Sub TxtPre_TextChanged(sender As Object, e As EventArgs) Handles TxtPre.TextChanged

    End Sub

    Private Sub TxtQtd_TextChanged(sender As Object, e As EventArgs) Handles TxtQtd.TextChanged
        If TxtPre.Text = "" And TxtQtd.Text <> "" Then
            MessageBox.Show("Antes de digitar a quantidade, digite o código do produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtQtd.Clear()
            TxtPro.Focus()
            BtnOk.Enabled = False
        ElseIf TxtQtd.Text <> "" And TxtPre.Text <> "" Then
            If Int(TxtQtd.Text) > estoque Then
                MessageBox.Show("Quantidade insuficiente, temos apenas " & estoque & " itens", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtQtd.Clear()
                TxtQtd.Focus()
                BtnOk.Enabled = False
            Else
                qtd = TxtQtd.Text
                pre = TxtPre.Text
                subtot = qtd * pre
                TxtSub.Text = Format(subtot, "0.00")
                BtnOk.Enabled = True
            End If
        Else
            TxtSub.Text = ""
        End If
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If DgdGrade.Rows.Count >= 1 Then

            subtot = DgdGrade.CurrentRow.Cells(4).Value
            geral = geral - subtot
            TxtGer.Text = Format(geral, "0.00")

            objpro.devolver_estoque(DgdGrade.CurrentRow.Cells(0).Value, DgdGrade.CurrentRow.Cells(3).Value)

            DgdGrade.Rows.RemoveAt(DgdGrade.CurrentCell.RowIndex)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click


        If CboPag.Text = "" Then
            MessageBox.Show("Por favor informe a forma de pagamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CboPag.Focus()
        Else
            objfim.Cliente = TxtCli.Text
            objfim.Data = DtpDat.Text
            objfim.Geral = TxtGer.Text
            objfim.Pagamento = CboPag.SelectedValue
            objfim.Final = TxtCampo.Text

            objfim.Gravar()
            txtCodven.Text = objfim.Codigo
            ChkFinal.Visible = True


            For x = 0 To DgdGrade.Rows.Count - 1
                objitemfim.Venda = txtCodven.Text
                objitemfim.Sequencia = x
                objitemfim.Produto = DgdGrade.Rows(x).Cells(0).Value
                objitemfim.Quantidade = DgdGrade.Rows(x).Cells(3).Value
                objitemfim.Preco = DgdGrade.Rows(x).Cells(2).Value
                objitemfim.gravar()
            Next
            objven.Atualizar(TxtCampo.Text)
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            BtnLocPro.Enabled = False
            ChkFinal.Checked = True
            ChkFinal.Enabled = True
            btnconf.Enabled = False
        End If
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        If DgdGrade.Rows.Count > 0 And DgdGrade.Enabled = True Then
            MessageBox.Show("Antes de cancelar, termine a venda final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call FrmVendaFinal_Load(Nothing, Nothing)
            objControle.Limpar_tela(GRPGERAL)
        End If
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        If DgdGrade.Rows.Count > 0 And DgdGrade.Enabled = True Then
            MessageBox.Show("Antes de sair, termine a venda final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TxtCampo_Validated(sender As Object, e As EventArgs) Handles TxtCampo.Validated
       
    End Sub

    Private Sub CboPag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPag.SelectedIndexChanged

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpVendaFinal
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objfim.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Vendas Finais"
        FrmImp.ShowDialog()
    End Sub
End Class