Public Class FrmCadFornecedor
    Dim objControle As New ClsControle
    Dim objfor As New ClsFornecedor
    Dim novo As Boolean

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        novo = True
        objControle.Limpar_tela(GRPEND)
        objControle.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub BtnExc_Click(sender As Object, e As EventArgs) Handles BtnExc.Click
        If objfor.excluir(txtcod.Text) Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
            objControle.Limpar_tela(GRPEND)
            objControle.Limpar_tela(GRPGERAL)
        End If
    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(GRPGERAL) = False And objControle.Testar_vazio(GRPEND) = False Then
            objfor.Codigo = Val(txtcod.Text)
            objfor.Razao = txtraz.Text
            objfor.Cnpj = mskcnpj.Text
            objfor.Inscricao = txtins.Text
            objfor.Numero = txtnum.Text
            objfor.Complemento = txtcomp.Text
            objfor.Bairro = txtbai.Text
            objfor.Email = txtema.Text
            objfor.Telefone = txttel.Text
            objfor.Contato = txtcon.Text
            objfor.CEP = MskCEP.Text
            objfor.Cidade = txtcid.Text

            objfor.gravar(novo)
            txtcod.Text = objfor.Codigo
            objControle.Habilitar_tela(Me, False)
            objControle.Habilitar_botoes(Me, True)
        End If
    End Sub

    Private Sub BtnAlt_Click(sender As Object, e As EventArgs) Handles BtnAlt.Click
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        txtcod.Enabled = False
        novo = False
    End Sub

    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadFornecedor_Load(Nothing, Nothing)
        objControle.Limpar_tela(GRPEND)
        objControle.Limpar_tela(GRPGERAL)
    End Sub

    Private Sub FrmCadFornecedor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
    End Sub

    Private Sub FrmCadFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        BtnAlt.Enabled = False

        GrpLoc.Visible = False
    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objfor.localizarComFiltro(TxtLoc.Text) = True Then
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
        txtcod.Text = objfor.Codigo
        txtraz.Text = objfor.Razao
        mskcnpj.Text = objfor.Cnpj
        txtins.Text = objfor.Inscricao
        txtnum.Text = objfor.Numero
        txtcomp.Text = objfor.Complemento
        txtbai.Text = objfor.Bairro
        txtema.Text = objfor.Email
        txttel.Text = objfor.Telefone
        txtcon.Text = objfor.Contato
        MskCEP.Text = objfor.CEP
        txtcid.Text = objfor.Cidade

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

    Private Sub txtcid_TextChanged(sender As Object, e As EventArgs) Handles txtcid.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress, txtins.KeyPress, txtnum.KeyPress, txttel.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub txttel_TextChanged(sender As Object, e As EventArgs) Handles txttel.TextChanged

    End Sub

    Private Sub txtnum_TextChanged(sender As Object, e As EventArgs) Handles txtnum.TextChanged

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpFornecedores
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objfor.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Fornecedores"
        FrmImp.ShowDialog()
    End Sub
End Class
