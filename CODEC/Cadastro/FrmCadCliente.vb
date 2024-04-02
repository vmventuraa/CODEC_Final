Public Class FrmCadCliente
    Dim objControle As New ClsControle
    Dim objcli As New ClsCliente
    Dim novo As Boolean

  

    Private Sub BtnNov_Click(sender As Object, e As EventArgs) Handles BtnNov.Click
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, True)
        objControle.Habilitar_botoes(Me, False)
        TxtCod.Enabled = False
        TxtNom.Focus()
        novo = True
        ChkJur.Enabled = False
        objControle.Limpar_tela(GRPEND)
        objControle.Limpar_tela(GRPGERAL)



    End Sub

    Private Sub BtnGra_Click(sender As Object, e As EventArgs) Handles BtnGra.Click
        If objControle.Testar_vazio(GRPGERAL) = False And objControle.Testar_vazio(GRPEND) = False Then
            objcli.Codigo = Val(TxtCod.Text)
            objcli.Nome = TxtNom.Text
            objcli.Celular = MskCel.Text
            objcli.Email = TxtEma.Text
            objcli.Endereco = TxtEnd.Text
            objcli.Numero = TxtNum.Text
            objcli.Complemento = TxtCom.Text
            objcli.Bairro = TxtBai.Text
            objcli.Cidade = TxtCid.Text
            objcli.Estado = CBXest.Text
            objcli.CEP = MskCEP.Text
            objcli.RG = TxtRg.Text
            objcli.CNPJ = mskcpf.Text
            objcli.Juridica = ChkJur.Checked

            objcli.gravar(novo)
            TxtCod.Text = objcli.Codigo
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
        If objcli.excluir(TxtCod.Text) Then
            objControle.Limpar_tela(Me)
            BtnExc.Enabled = False
            BtnAlt.Enabled = False
            BtnImp.Enabled = False
            objControle.Limpar_tela(GRPEND)
            objControle.Limpar_tela(GRPGERAL)
        End If

    End Sub


    Private Sub BtnLoc_Click(sender As Object, e As EventArgs) Handles BtnLoc.Click
        BtnLoc.Enabled = False
        GrpLoc.Visible = True
        TxtLoc.Focus()
    End Sub

    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Call FrmCadCliente_Load(Nothing, Nothing)
        objControle.Limpar_tela(GRPEND)
        objControle.Limpar_tela(GRPGERAL)


    End Sub

    Private Sub FrmCadCliente_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Top = 0
        Me.Left = 0
      

    End Sub

    Private Sub FrmCadCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objControle.Limpar_tela(Me)
        objControle.Habilitar_tela(Me, False)
        objControle.Habilitar_botoes(Me, True)

        BtnExc.Enabled = False
        BtnAlt.Enabled = False
        BtnImp.Enabled = True
        GrpLoc.Visible = False



    End Sub

    Private Sub BtnSai_Click(sender As Object, e As EventArgs) Handles BtnSai.Click
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If objcli.localizarComFiltro(TxtLoc.Text) = True Then
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
        TxtCod.Text = objcli.Codigo
        TxtNom.Text = objcli.Nome
        MskCel.Text = objcli.Celular
        TxtEma.Text = objcli.Email
        TxtEnd.Text = objcli.Endereco
        TxtNum.Text = objcli.Numero
        TxtCom.Text = objcli.Complemento
        TxtBai.Text = objcli.Bairro
        TxtCid.Text = objcli.Cidade
        CBXest.Text = objcli.Estado
        MskCEP.Text = objcli.CEP
        TxtRg.Text = objcli.RG
        ChkJur.Checked = objcli.Juridica
        mskcpf.Text = objcli.CNPJ



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

    Private Sub MskCel_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskCel.MaskInputRejected

    End Sub

    Private Sub ChkJur_CheckedChanged(sender As Object, e As EventArgs) Handles ChkJur.CheckedChanged
        If ChkJur.Checked = True Then
            lblcpfcnpj.Text = "CNPJ:"
            lblrrginc.Text = "Insc. Estadual:"
            mskcpf.Mask = "00,000,000,0000-00"
            lblnomeraz.Text = "Razão Social:"
        Else
            lblcpfcnpj.Text = "CPF:"
            lblrrginc.Text = "RG:"
            mskcpf.Mask = "000,000,000-00"
            lblnomeraz.Text = "Nome:"
        End If
    End Sub

    Private Sub TxtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNum.KeyPress, MskCel.KeyPress, MskCEP.KeyPress
        e.Handled = objControle.So_numeros(e.KeyChar)
    End Sub

    Private Sub mskcpf_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskcpf.MaskInputRejected

    End Sub

    Private Sub MskCEP_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskCEP.MaskInputRejected

    End Sub

    Private Sub TxtRg_TextChanged(sender As Object, e As EventArgs) Handles TxtRg.TextChanged

    End Sub

    Private Sub CBXest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXest.SelectedIndexChanged

    End Sub

    Private Sub TxtEnd_TextChanged(sender As Object, e As EventArgs) Handles TxtEnd.TextChanged

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim rpt As New CrpClientes
        FrmImp.CrystalReportViewer1.ReportSource = rpt
        rpt.SetDataSource(objcli.consultatotal)
        rpt.SummaryInfo.ReportTitle = "Relatório de Clientes"
        FrmImp.ShowDialog()
    End Sub
End Class
