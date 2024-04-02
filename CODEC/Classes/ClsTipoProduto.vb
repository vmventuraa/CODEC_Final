Public Class ClsTipoProduto
    Dim c_cod As Integer
    Dim c_nom As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable


    Public Property Codigo() As Integer
        Get
            Return c_cod
        End Get
        Set(ByVal value As Integer)
            c_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return c_nom
        End Get
        Set(ByVal value As String)
            c_nom = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabtipoproduto (nomtip) values ('" & c_nom & "')"


            objBanco.Executar_comando(sql)
            sql = "select max(codtip) as codigo from tabtipoproduto"
            c_cod = objBanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabtipoproduto set " &
                 " nomtip='" & c_nom & "'" & _
                 "" & " where codtip=" & c_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabtipoproduto where codtip=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabtipoproduto where codtip=" & campo
        Else
            sql = "Select * from tabtipoproduto where nomtip='" & campo & " '"
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosVindosDoBanco()
            Return True
        End If
    End Function
    Public Function consultatotal() As DataTable
        sql = "Select * from tabtipoproduto order by nomtip"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Sub mostrar_dadosVindosDoBanco()
        c_cod = objDtLocal.Rows(0).Item(0)
        c_nom = objDtLocal.Rows(0).Item(1)

    End Sub
    Public Function Localizar_tipo() As DataTable
        sql = "select * from tabtipoproduto order by nomtip"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Function TipoMaisVendido(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("TiposMaisVendidos", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function


End Class
