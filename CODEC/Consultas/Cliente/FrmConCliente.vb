Public Class FrmConCliente
    Dim objcli As New ClsCliente

    Private Sub FrmConCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmConCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellContentClick

      

    End Sub

    Private Sub TxtCampo_TextChanged(sender As Object, e As EventArgs) Handles TxtCampo.TextChanged
        DgdGrade.DataSource = objcli.Localizar(TxtCampo.Text)
    End Sub

    Private Sub DgdGrade_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgdGrade.CellDoubleClick
        If MdiParent Is FrmMenu Then
            FrmCadCliente.Show()
            FrmCadCliente.TxtCod.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmCadCliente.TxtNom.Text = DgdGrade.CurrentRow.Cells(1).Value
            FrmCadCliente.MskCel.Text = DgdGrade.CurrentRow.Cells(2).Value
            FrmCadCliente.TxtEma.Text = DgdGrade.CurrentRow.Cells(3).Value
            FrmCadCliente.TxtEnd.Text = DgdGrade.CurrentRow.Cells(4).Value
            FrmCadCliente.TxtNum.Text = DgdGrade.CurrentRow.Cells(5).Value
            FrmCadCliente.TxtCom.Text = DgdGrade.CurrentRow.Cells(6).Value
            FrmCadCliente.TxtBai.Text = DgdGrade.CurrentRow.Cells(7).Value
            FrmCadCliente.TxtCid.Text = DgdGrade.CurrentRow.Cells(8).Value
            FrmCadCliente.CBXest.Text = DgdGrade.CurrentRow.Cells(9).Value
            FrmCadCliente.MskCEP.Text = DgdGrade.CurrentRow.Cells(10).Value
            FrmCadCliente.TxtRg.Text = DgdGrade.CurrentRow.Cells(11).Value
            FrmCadCliente.mskcpf.Text = DgdGrade.CurrentRow.Cells(12).Value
            FrmCadCliente.ChkJur.Checked = DgdGrade.CurrentRow.Cells(13).Value



            Me.Close()


        ElseIf Owner Is FrmVenda Then
            FrmVenda.TxtCli.Text = DgdGrade.CurrentRow.Cells(0).Value
            FrmVenda.TxtNcl.Text = DgdGrade.CurrentRow.Cells(1).Value

            Me.Close()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class