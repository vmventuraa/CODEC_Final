Public Class FrmConFornecedores
    Dim objfor As New ClsFornecedor
    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

      
    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objfor.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadFornecedor.Show()

            FrmCadFornecedor.txtcod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadFornecedor.txtraz.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadFornecedor.mskcnpj.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadFornecedor.txtins.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadFornecedor.txtnum.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadFornecedor.txtcomp.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadFornecedor.txtbai.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadFornecedor.txtema.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadFornecedor.txttel.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadFornecedor.txtcon.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadFornecedor.txtcid.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadFornecedor.MskCEP.Text = DgdGrade.CurrentRow.Cells(11).Value
            Me.Close()

            ' If Quemchamou = "vendas" Then
        ElseIf Owner Is FrmCadProduto Then
            FrmCadProduto.txtcodfor.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadProduto.txtfor.Text = DgdGrade.CurrentRow.Cells(1).Value
            'Quemchamou = ""
            Me.Close()
        End If
    End Sub
End Class