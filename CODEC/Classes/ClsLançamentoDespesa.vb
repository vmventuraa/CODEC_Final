Public Class ClsLançamentoDespesa
    Dim m_cod As Integer
    Dim m_codDes As Long
    Dim m_data As Date
    Dim m_desc As String
    Dim m_valor As Single
    Dim m_pag As String


    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(ByVal value As Integer)
            m_cod = value
        End Set
    End Property

    Public Property CodigoDespesa() As Long
        Get
            Return m_codDes
        End Get
        Set(ByVal value As Long)
            m_codDes = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return m_data
        End Get
        Set(ByVal value As Date)
            m_data = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property



    Public Property Valor() As Single
        Get
            Return m_valor
        End Get
        Set(ByVal value As Single)
            m_valor = value
        End Set
    End Property
    Public Property Pagamento() As String
        Get
            Return m_pag
        End Get
        Set(value As String)
            m_pag = value
        End Set
    End Property


    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tablandesp " &
                "(deslan" &
                ",datlan" &
                ",desclan" &
                ",vallan" &
                ",paglan" &
                ") values " &
                "('" & m_codDes & "'" &
                ",'" & m_data & "'" &
                ",'" & m_desc & "'" &
                ",'" & m_valor & "'" &
                 ",'" & m_pag & "'" &
                ")"

            objBanco.Executar_comando(sql)
            sql = "select max(codlan) as codigo from tablandesp"
            m_cod = objBanco.buscar_ultimoRegistro(sql)
        Else
            sql = "update tablandesp set " &
                " deslan='" & m_codDes & "'" & _
                ",datlan='" & m_data & "'" & _
                ",desclan='" & m_desc & "'" & _
                ",vallan='" & m_valor & "'" & _
                ",paglan='" & m_pag & "'" & _
               " where codlan=" & m_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabEntradaProduto where codent=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If

    End Function
   
    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tablandesp where codlan=" & campo
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
    Public Function Localizar_porData(ByVal dataini As Date, ByVal datafim As Date, ByVal codini As Integer, ByVal codfim As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("DespesaPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo4", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim
        objda.SelectCommand.Parameters("campo3").Value = codini
        objda.SelectCommand.Parameters("campo4").Value = codfim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Sub mostrar_dadosvindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_codDes = objDtLocal.Rows(0).Item(1)
        m_data = objDtLocal.Rows(0).Item(2)
        m_desc = objDtLocal.Rows(0).Item(3)
        m_valor = objDtLocal.Rows(0).Item(4)
        m_pag = objDtLocal.Rows(0).Item(5)
    End Sub
    Public Function Localizar_porDataTOT(ByVal dataini As Date, ByVal datafim As Date, ByVal codini As Integer, ByVal codfim As Integer) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("DespesaPeriodo_TOT", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo3", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo4", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim
        objda.SelectCommand.Parameters("campo3").Value = codini
        objda.SelectCommand.Parameters("campo4").Value = codfim


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0).Rows(0).Item(0)
    End Function
    Public Function Localizar_porDataGeral(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("DespesaPeriodoGeral", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function Localizar_porDataGeralTOT(ByVal dataini As Date, ByVal datafim As Date) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("DespesaPeriodoGeral_TOT", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim


        objds.Tables.Clear()
        objda.Fill(objds)
        If Not IsDBNull(objds.Tables(0).Rows(0).Item(0)) Then
            Return objds.Tables(0).Rows(0).Item(0)
        End If
    End Function

    Public Function Despesa_COUNT(ByVal dataini As Date, ByVal datafim As Date) As Integer
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("Despesa_COUNT", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0).Rows(0).Item(0)
    End Function
    Public Function consultadespesa() As DataTable
        sql = "Select * from tablandesp"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

End Class


