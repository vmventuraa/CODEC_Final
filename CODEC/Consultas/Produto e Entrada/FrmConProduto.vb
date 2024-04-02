Public Class FrmConProduto
    Dim objpro As New ClsProduto
    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objpro.Localizar_consulta(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadProduto.Show()
            FrmCadProduto.TxtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadProduto.TxtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadProduto.txtcodfor.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadProduto.txtpre.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadProduto.txtqntd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadProduto.txtdesc.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadProduto.mskncm.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadProduto.txtimp.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadProduto.txtmat.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadProduto.CboTip.Text = DgdGrade.CurrentRow.Cells(9).Value

           



            Me.Close()


        ElseIf Owner Is FrmVenda Then
            FrmVenda.TxtPro.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmVenda.TxtNpr.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmVenda.TxtPre.Text = DgdGrade.CurrentRow.Cells(3).Value

            Me.Close()
        End If
    End Sub
End Class