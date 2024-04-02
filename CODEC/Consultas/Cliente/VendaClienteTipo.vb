Public Class VendaClienteTipo
    Dim objvenfinal As New ClsVendaFinal
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dgdgrade.DataSource = objvenfinal.VendaClienteTipo(DtpIni.Text, DtpFim.Text)


    End Sub
End Class