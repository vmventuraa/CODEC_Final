Public Class FrmConDespesa
    Dim objlan As New ClsLançamentoDespesa
    Dim objdes As New ClsDespesa

    Private Sub DgdGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtProIni.Text = "" And txtProFim.Text = "" Then
            Dgdgrade.DataSource = objlan.Localizar_porDataGeral(DtpIni.Text, DtpFim.Text)
            txttotal.Text = objlan.Localizar_porDataGeralTOT(DtpIni.Text, DtpFim.Text)
            lbltot.Visible = True
            txttotal.Visible = True
        ElseIf TxtProIni.Text <> "" And txtProFim.Text <> "" Then
            Dgdgrade.DataSource = objlan.Localizar_porData(DtpIni.Text, DtpFim.Text, TxtProIni.Text, txtProFim.Text)
            txttotal.Text = objlan.Localizar_porDataTOT(DtpIni.Text, DtpFim.Text, TxtProIni.Text, txtProFim.Text)
            lbltot.Visible = True
            txttotal.Visible = True
        Else
            MessageBox.Show("Preencha todos os campos")
        End If
    End Sub

    Private Sub TxtProIni_TextChanged(sender As Object, e As EventArgs) Handles TxtProIni.TextChanged

    End Sub

    Private Sub TxtProIni_Validated(sender As Object, e As EventArgs) Handles TxtProIni.Validated
        If TxtProIni.Text <> "" Then
            If objdes.localizarComFiltro(TxtProIni.Text) = True Then
                TxtNcl.Text = objdes.Nome
            Else
                TxtProIni.Clear()
                TxtNcl.Clear()
                TxtProIni.Focus()
            End If
        End If
    End Sub

    Private Sub txtProFim_Validated(sender As Object, e As EventArgs) Handles txtProFim.Validated
        If txtProFim.Text <> "" Then
            If objdes.localizarComFiltro(txtProFim.Text) = True Then
                txtx.Text = objdes.Nome
            Else
                txtProFim.Clear()
                txtx.Clear()
                txtProFim.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNcl_TextChanged(sender As Object, e As EventArgs) Handles TxtNcl.TextChanged

    End Sub

    Private Sub DtpIni_ValueChanged(sender As Object, e As EventArgs) Handles DtpIni.ValueChanged

    End Sub

    Private Sub DtpFim_ValueChanged(sender As Object, e As EventArgs) Handles DtpFim.ValueChanged

    End Sub

    Private Sub FrmConDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Dgdgrade_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Dgdgrade.CellContentClick

    End Sub

    Private Sub txtProFim_TextChanged(sender As Object, e As EventArgs) Handles txtProFim.TextChanged

    End Sub
End Class