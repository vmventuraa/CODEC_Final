Public Class FrmVenda
    Dim objCli As New ClsCliente
    Dim objPro As New ClsProduto
    Dim objven As New ClsVenda
    Dim objitem As New ClsItem
    Dim objControle As New ClsControle
    Dim objformas As New clsPagamento

    Dim qtd, estoque As Integer
    Dim pre, subtot As Single
    Dim geral As Single
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Habilitar_botoes(Me, False)
        objControle.Limpar_tela(Me)
        DgdItem.Rows.Clear()
        TxtCli.Enabled = True
        TxtPro.Enabled = True
        TxtQtd.Enabled = True
        DgdItem.Enabled = True
        BtnLocCli.Enabled = True
        BtnLocPro.Enabled = True
        ' ChkFinal.Enabled = True
        dtpdevolução.Enabled = True
        DtpDat.Enabled = False
        TxtCli.Focus()
        TxtGer.Text = 0
        objControle.Limpar_tela(GRP1)
        objControle.Limpar_tela(GRP2)
        GRP1.Enabled = True
        GRP2.Enabled = True
        Label10.Enabled = True

    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        If DgdItem.Rows.Count > 0 And DgdItem.Enabled = True Then
            MessageBox.Show("Antes de cancelar, exclua todos os produtos na grade, clicando duas vezes sobre cada item", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call FrmVenda_Load(Nothing, Nothing)
            objControle.Limpar_tela(GRP2)
            ' CboPag.Text = ""
        End If
    End Sub

    Private Sub FrmVenda_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)
        objControle.Limpar_tela(Me)
        DgdItem.Rows.Clear()

        'CboPag.DisplayMember = "NOMFOR"
        ' CboPag.ValueMember = "CODFOR"
        ' CboPag.DataSource = objformas.Localizar_formas()

        BtnLocCli.Enabled = False
        BtnLocPro.Enabled = False
        BtnOk.Enabled = False
        ' CboPag.Enabled = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        If DgdItem.Rows.Count > 0 And DgdItem.Enabled = True Then
            MessageBox.Show("Antes de cancelar, exclua todos os produtos na grade, clicando duas vezes sobre cada item", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TxtCli_TextChanged(sender As Object, e As EventArgs) Handles TxtCli.TextChanged

    End Sub

    Private Sub TxtCli_Validated(sender As Object, e As EventArgs) Handles TxtCli.Validated
        If TxtCli.Text <> "" Then
            If objCli.localizarComFiltro(TxtCli.Text) = True Then
                TxtNcl.Text = objCli.Nome
            Else
                TxtCli.Clear()
                TxtNcl.Clear()
                TxtCli.Focus()
            End If
        End If
    End Sub

    Private Sub BtnLocCli_Click(sender As Object, e As EventArgs) Handles BtnLocCli.Click
        FrmConCliente.Owner = Me
        FrmConCliente.ShowDialog()
    End Sub

    Private Sub TxtNpr_TextChanged(sender As Object, e As EventArgs) Handles TxtNpr.TextChanged

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

    Private Sub TxtPre_TextChanged(sender As Object, e As EventArgs) Handles TxtPre.TextChanged

    End Sub

    Private Sub DgdItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdItem.CellContentClick

    End Sub

    Private Sub DgdItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdItem.CellDoubleClick
        If DgdItem.Rows.Count >= 1 Then

            subtot = DgdItem.CurrentRow.Cells(4).Value
            geral = geral - subtot
            TxtGer.Text = Format(geral, "0.00")

            objPro.devolver_estoque(DgdItem.CurrentRow.Cells(0).Value, DgdItem.CurrentRow.Cells(3).Value)

            DgdItem.Rows.RemoveAt(DgdItem.CurrentCell.RowIndex)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtPro.Text <> "" And TxtSub.Text <> "" Then
            DgdItem.Rows.Add(TxtPro.Text, TxtNpr.Text, TxtPre.Text, TxtQtd.Text, TxtSub.Text)

            subtot = TxtSub.Text
            geral = TxtGer.Text
            geral = geral + subtot
            TxtGer.Text = Format(geral, "0.00")
            objPro.baixar_estoque(TxtPro.Text, TxtQtd.Text)
            TxtPro.Clear()
            TxtNpr.Clear()
            TxtPre.Clear()
            TxtQtd.Clear()
            TxtSub.Clear()
            TxtPro.Focus()
        End If
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If TxtCli.Text = "" Then
            MessageBox.Show("Por favor digite o código do cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCli.Focus()
        ElseIf TxtGer.Text = 0 Then
            MessageBox.Show("Por favor informe pelo menos um produto para a venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPro.Focus()
        Else
            objven.Data = DtpDat.Text
            objven.Cliente = TxtCli.Text
            objven.Geral = TxtGer.Text
            objven.Combinado = dtpdevolução.Text

            objven.Gravar()
            TxtVen.Text = objven.Codigo

            For x = 0 To DgdItem.Rows.Count - 1
                objitem.Venda = TxtVen.Text
                objitem.sequencia = x
                objitem.Produto = DgdItem.Rows(x).Cells(0).Value
                objitem.Quantidade = DgdItem.Rows(x).Cells(3).Value
                objitem.Preco = DgdItem.Rows(x).Cells(2).Value
                objitem.gravar()
            Next

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
            BtnLocCli.Enabled = False
            BtnLocPro.Enabled = False

        End If
    End Sub

    Private Sub TxtSub_TextChanged(sender As Object, e As EventArgs) Handles TxtSub.TextChanged

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

    Private Sub BtnLocPro_Click(sender As Object, e As EventArgs) Handles BtnLocPro.Click
        FrmConProduto.Owner = Me
        FrmConProduto.ShowDialog()
    End Sub

    Private Sub ChkFinal_CheckedChanged(sender As Object, e As EventArgs)
        ' If ChkFinal.Checked = True Then
        '  CboPag.Enabled = True
        ' Else
        '  CboPag.Enabled = False
        ' End If
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpVendaInicial
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objven.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Vendas Iniciais"
        FrmImp.ShowDialog()
    End Sub
End Class