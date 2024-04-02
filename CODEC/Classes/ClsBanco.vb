Public Class ClsBanco
    Dim conexao As String = "Provider=microsoft.ace.oledb.12.0;data source=PTIDBrelatorio.mdb"
    Public objcon As New OleDb.OleDbConnection(conexao)

    Private Sub Abrir_banco()
        objcon.Open()
    End Sub

    Private Sub Fechar_banco()
        If objcon.State = ConnectionState.Open Then
            objcon.Close()
        End If
    End Sub

    Public Sub Executar_comando(sql As String)
        Abrir_banco()
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()
        Fechar_banco()
    End Sub

    Public Function buscar_ultimoRegistro(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt.Rows(0).Item(0)
    End Function

    Public Function localizar(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt
    End Function
End Class
