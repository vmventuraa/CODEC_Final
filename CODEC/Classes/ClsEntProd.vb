Public Class ClsEntProd
    Dim c_cod As Integer
    Dim c_codPro As Long
    Dim c_preco As Single
    Dim c_qtd As Integer
    Dim c_data As Date

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable


    Public Property CodigoEnt() As Integer
        Get
            Return c_cod
        End Get
        Set(ByVal value As Integer)
            c_cod = value
        End Set
    End Property


    Public Property CodigoProduto() As Long
        Get
            Return c_codPro
        End Get
        Set(ByVal value As Long)
            c_codPro = value
        End Set
    End Property

    Public Property Preco() As Single
        Get
            Return c_preco
        End Get
        Set(ByVal value As Single)
            c_preco = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return c_qtd
        End Get
        Set(ByVal value As Integer)
            c_qtd = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return c_data
        End Get
        Set(ByVal value As Date)
            c_data = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabentradaproduto " &
                "(proent" &
                ",preent" &
                ",qtdent" &
                ",datent" &
                ") values " &
                "('" & c_codPro & "'" &
                ",'" & c_preco & "'" &
                ",'" & c_qtd & "'" &
                ",'" & c_data & "'" &
                ")"

            objBanco.Executar_comando(sql)
            sql = "select max(codent) as codigo from tabEntradaProduto"
            c_cod = objBanco.buscar_ultimoRegistro(sql)
        End If
    End Sub
    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabEntradaProduto where codent=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function
    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabEntradaProduto where codent=" & campo
        End If
        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosvindosDoBanco()
            Return True
        End If
    End Function
    Public Function consultatotal() As DataTable
        sql = "Select * from tabentradaproduto order by datent"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Sub mostrar_dadosvindosDoBanco()
        c_cod = objDtLocal.Rows(0).Item(0)
        c_codPro = objDtLocal.Rows(0).Item(1)
        c_preco = objDtLocal.Rows(0).Item(2)
        c_qtd = objDtLocal.Rows(0).Item(3)
        c_data = objDtLocal.Rows(0).Item(4)
    End Sub

    Public Function Localizar_porData(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("EntradaProdutoPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function LocalizarEntradaNome(campo As String) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("EntradaProdutoNome", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.BSTR))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function LocalizarEntradaCodigo(campo As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("EntradaProdutoCodigo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

End Class
