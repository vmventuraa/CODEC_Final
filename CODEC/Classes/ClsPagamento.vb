Public Class clsPagamento
    Dim p_cod As Integer
    Dim p_nom As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return p_cod
        End Get
        Set(ByVal value As Integer)
            p_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return p_nom
        End Get
        Set(ByVal value As String)
            p_nom = value
        End Set
    End Property
    Public Sub gravar(novo As Boolean)
        If novo Then

            sql = "insert into tabformas (nomfor) values ('" & p_nom & "')"
            objBanco.Executar_comando(sql)
            sql = "select max(codfor) as codigo from tabformas"
            p_cod = objBanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabformas set nomfor='" & p_nom & "' where codfor=" & p_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub
    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabformas where codfor=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabformas where codfor=" & campo
        Else
            sql = "Select * from tabformas where nomfor='" & campo & " '"
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

    Public Sub mostrar_dadosVindosDoBanco()
        p_cod = objDtLocal.Rows(0).Item(0)
        p_nom = objDtLocal.Rows(0).Item(1)

    End Sub
    Public Function consultatotal() As DataTable
        sql = "Select * from tabformas order by nomfor"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function Localizar_formas() As DataTable
        sql = "select * from tabformas order by nomfor"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    
    Public Function FormasUtiizadas_COUNT() As DataTable

        sql = "SELECT tabformas.codfor, tabformas.nomfor, COUNT(codfin) AS total "
        sql = sql + "FROM tabvendafinal INNER JOIN tabformas ON tabvendafinal.pagfin = tabformas.codfor"
        sql = sql + " GROUP BY codfor, nomfor"
        Return objBanco.localizar(sql)

    End Function
    Public Function FormaUtilizadaGeral_COUNT(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("FormaPagamento_COUNT", objBanco.objcon))
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
