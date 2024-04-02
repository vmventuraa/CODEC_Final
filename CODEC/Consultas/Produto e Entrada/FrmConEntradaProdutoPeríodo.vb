Public Class FrmConEntradaProdutoPeríodo
    Dim objent As New ClsEntProd
    Private Sub FrmConEntradaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        DgdGrade.DataSource = objent.Localizar_porData(DtpIni.Text, DtpFim.Text)
    End Sub
End Class