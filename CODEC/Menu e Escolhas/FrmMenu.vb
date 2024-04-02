Public Class FrmMenu

  

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmMenu_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate

    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub SAIRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs)
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = False
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Físico"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmCadProduto.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FrmCadFornecedor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FrmCadDespesa.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        FrmVenda.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        FrmCadPagamento.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        EscolhaVendasConsultas.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        FrmVendaFinal.Show()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        FrmCadLançamentoDespesa.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        EscolhaDespesasConsultas.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        EscolhaFornecedorConsultas.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = True
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Jurídico"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        EscolhaClienteConsultas.Show()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        FrmCadEntradaDeProduto.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        EscolhaProdutoConsultas.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        EscolhaPagamentoConsultas.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BTNCADFIS.Click
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = False
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Físico"
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = True
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Jurídico"
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs)
        EscolhaClienteConsultas.Show()
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs)
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = True
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Jurídico"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles BtnClientes.Click


        If BTNCADFIS.Visible = True Then
            BTNCADFIS.Visible = False

        Else
            BTNCADFIS.Visible = True

        End If

        If BTNCADJUR.Visible = True Then
            BTNCADJUR.Visible = False

        Else
            BTNCADJUR.Visible = True

        End If

        If BTNCLICON.Visible = True Then
            BTNCLICON.Visible = False

        Else
            BTNCLICON.Visible = True

        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles BtnDespesas.Click
        If BTNCADDES.Visible = True Then
            BTNCADDES.Visible = False

        Else
            BTNCADDES.Visible = True

        End If

        If BTNCADLAN.Visible = True Then
            BTNCADLAN.Visible = False

        Else
            BTNCADLAN.Visible = True

        End If

        If BTNCONDES.Visible = True Then
            BTNCONDES.Visible = False

        Else
            BTNCONDES.Visible = True

        End If

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles BtnProdutos.Click
        If BTNCADPRO.Visible = True Then
            BTNCADPRO.Visible = False

        Else
            BTNCADPRO.Visible = True

        End If

        If BTNENTPRO.Visible = True Then
            BTNENTPRO.Visible = False

        Else
            BTNENTPRO.Visible = True

        End If

        If BTNCAPTIP.Visible = True Then
            BTNCAPTIP.Visible = False

        Else
            BTNCAPTIP.Visible = True

        End If

        If BTNCONPRO.Visible = True Then
            BTNCONPRO.Visible = False

        Else
            BTNCONPRO.Visible = True

        End If
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles BtnVendas.Click
        If BTNVENINI.Visible = True Then
            BTNVENINI.Visible = False

        Else
            BTNVENINI.Visible = True

        End If

        If BTNVENFIN.Visible = True Then
            BTNVENFIN.Visible = False

        Else
            BTNVENFIN.Visible = True

        End If

        If BTNCONFIN.Visible = True Then
            BTNCONFIN.Visible = False

        Else
            BTNCONFIN.Visible = True

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnFornecedores.Click
        If BTNCADFOR.Visible = True Then
            BTNCADFOR.Visible = False

        Else
            BTNCADFOR.Visible = True

        End If

        If BTNFORCON.Visible = True Then
            BTNFORCON.Visible = False

        Else
            BTNFORCON.Visible = True

        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles BtnFormas.Click
        If BTNCADPAG.Visible = True Then
            BTNCADPAG.Visible = False

        Else
            BTNCADPAG.Visible = True

        End If

        If BTNCONPAG.Visible = True Then
            BTNCONPAG.Visible = False

        Else
            BTNCONPAG.Visible = True

        End If

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = True
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Jurídico"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        EscolhaClienteConsultas.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles BTNCADDES.Click
        FrmCadDespesa.Show()
    End Sub

    Private Sub Button7_Click_3(sender As Object, e As EventArgs) Handles BTNCADLAN.Click
        FrmCadLançamentoDespesa.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles BTNCONDES.Click
        EscolhaDespesasConsultas.Show()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles BTNCADPRO.Click
        FrmCadProduto.Show()
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles BTNENTPRO.Click
        FrmCadEntradaDeProduto.Show()
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles BTNCONPRO.Click
        EscolhaProdutoConsultas.Show()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles BTNCAPTIP.Click
        FrmTipoProduto.Show()
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles BTNVENINI.Click
        FrmVenda.Show()
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles BTNVENFIN.Click
        FrmVendaFinal.Show()
    End Sub

    Private Sub Button14_Click_2(sender As Object, e As EventArgs) Handles BTNCONFIN.Click
        EscolhaVendasConsultas.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles BTNCADFOR.Click
        FrmCadFornecedor.Show()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BTNFORCON.Click
        EscolhaFornecedorConsultas.Show()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles BTNCADPAG.Click
        FrmCadPagamento.Show()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles BTNCONPAG.Click
        EscolhaPagamentoConsultas.Show()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles BTNCADJUR.Click
        FrmCadCliente.Show()
        FrmCadCliente.ChkJur.Checked = True
        FrmCadCliente.LblTitulo.Text = "Cadastro de Cliente Jurídico"
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles BTNCLICON.Click
        EscolhaClienteConsultas.Show()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles Button1.Click
        EscolhaContrato.Show()
    End Sub
End Class