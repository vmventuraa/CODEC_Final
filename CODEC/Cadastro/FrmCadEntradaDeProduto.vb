Public Class FrmCadEntradaDeProduto
    Dim objControle As New ClsControle
    Dim novo As Boolean
    Dim objEntPro As New ClsEntProd
    Dim objPro As New ClsProduto
    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCodEnt.Enabled = False
        TxtNom.Enabled = False
        TxtCodPro.Focus()
        novo = True
    End Sub

    Private Sub TxtCodPro_TextChanged(sender As Object, e As EventArgs) Handles TxtCodPro.TextChanged

    End Sub

    Private Sub TxtCodPro_Validated(sender As Object, e As EventArgs) Handles TxtCodPro.Validated
        If TxtCodPro.Text <> "" Then
            If objPro.localizar(TxtCodPro.Text) Then
                txtNom.Text = objPro.Nome
            Else
                TxtCodPro.Clear()
                TxtCodPro.Focus()
            End If
        End If
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(Me) = False Then
            objEntPro.CodigoEnt = Val(TxtCodEnt.Text)
            objEntPro.CodigoProduto = TxtCodPro.Text
            objEntPro.Preco = TxtPrec.Text
            objEntPro.Quantidade = TxtQnt.Text
            objEntPro.Data = DtpEnt.Value

            objEntPro.gravar(novo)
            TxtCodEnt.Text = objEntPro.CodigoEnt

            objPro.devolver_estoque(TxtCodPro.Text, TxtQnt.Text)

            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objEntPro.excluir(TxtCodEnt.Text) = True Then
            objControle.Limpar_tela(Me)

            BtnExc.Enabled = False
        End If
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadEntradaDeProduto_Load(Nothing, Nothing)
    End Sub

    Private Sub FrmCadEntradaDeProduto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmCadEntradaDeProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        GrpLoc.Visible = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub TxtPrec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQnt.KeyPress, TxtCodPro.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub TxtPrec_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles TxtPrec.KeyPress
        e.Handled = objControle.So_numeroseVirgula(e.KeyChar)
    End Sub

    Private Sub TxtPrec_TextChanged(sender As Object, e As EventArgs) Handles TxtPrec.TextChanged

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objEntPro.localizar(TxtLoc.Text) Then
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
        txtCodEnt.Text = objEntPro.CodigoEnt
        txtCodPro.Text = objEntPro.CodigoProduto
        DtpEnt.Value = objEntPro.Data
        TxtPrec.Text = objEntPro.Preco
        TxtQnt.Text = objEntPro.Quantidade

        BtnExc.Enabled = True
    End Sub

    Private Sub TxtLoc_TextChanged(sender As Object, e As EventArgs) Handles TxtLoc.TextChanged
        If TxtLoc.Text = "" Then
            BtnOk.Enabled = False
        Else
            BtnOk.Enabled = True
        End If
    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpEntradaProduto
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objEntPro.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Entradas"
        FrmImp.ShowDialog()
    End Sub
End Class