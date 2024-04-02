Public Class EscolhaProdutoConsultas

    Private Sub BtnConCod_Click(sender As Object, e As EventArgs) Handles BtnConCod.Click
        FrmConProduto.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmConEntradaProdutoPeríodo.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmConEntradaProdutoCodigoNome.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        VendaClienteTipo.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TiposMaisVendidos.Show()
        Me.Close()
    End Sub
End Class