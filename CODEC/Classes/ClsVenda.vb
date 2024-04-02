Public Class ClsVenda
    Dim m_cod As Integer
    Dim m_cli As Integer
    Dim m_dta As Date
    Dim m_ger As Single
    Dim m_fin As Boolean
    Dim m_com As Date

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

    Public Property Cliente() As Integer
        Get
            Return m_cli
        End Get
        Set(ByVal value As Integer)
            m_cli = value
        End Set
    End Property


    Public Property Data() As Date
        Get
            Return m_dta
        End Get
        Set(ByVal value As Date)
            m_dta = value
        End Set
    End Property

    Public Property Geral() As Single
        Get
            Return m_ger
        End Get
        Set(ByVal value As Single)
            m_ger = value
        End Set
    End Property


    Public Property Final() As Boolean
        Get
            Return m_fin
        End Get
        Set(ByVal value As Boolean)
            m_fin = value
        End Set
    End Property
    Public Property Combinado() As Date
        Get
            Return m_com
        End Get
        Set(ByVal value As Date)
            m_com = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabvenda " & _
            "(cliven" & _
            ",datven" & _
            ",totven" & _
            ",finalven" & _
             ",comven" & _
            ") values " & _
            "('" & m_cli & "'" & _
            ",'" & m_dta & "'" & _
            ",'" & m_ger & "'" & _
            "," & m_fin & "" & _
            ",'" & m_com & "'" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codven) as codigo from tabvenda"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub
    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabvenda where codven=" & campo
        Else
            sql = "select * from tabvenda where tabvenda like '" & campo & "%' order by nomcli"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function consultatotal() As DataTable
        sql = "Select *"
        sql = sql + "FROM tabvenda"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function Localizar_Codigo(campo As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicialCodigo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar_chave(campo As Integer) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabvenda where codven=" & campo & " and tabvenda.finalven"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function localizar_grade(campo As Integer) As DataTable
        If IsNumeric(campo) Then
            sql = "SELECT tabitem.proite, tabproduto.nompro, tabitem.qtdite, tabitem.preite, tabitem.qtdite * tabitem.preite as subtot "
            sql = sql + " FROM tabitem INNER JOIN tabproduto ON tabproduto.codpro = tabitem.proite "
            sql = sql + " WHERE tabitem.venite = " & campo
        End If

        Return objBanco.localizar(sql)

    End Function
    Public Sub mostrar_dadosvindosDoBanco()
        m_cod = objDtLocal.Rows(0).Item(0)
        m_dta = objDtLocal.Rows(0).Item(1)
        m_cli = objDtLocal.Rows(0).Item(2)
        m_ger = objDtLocal.Rows(0).Item(3)
        m_fin = objDtLocal.Rows(0).Item(4)
        m_com = objDtLocal.Rows(0).Item(5)
    End Sub
    Public Function ItemVenda(campo As Integer) As Boolean

        sql = " SELECT tabvenda.codven, tabvenda.datven, tabvenda.cliven, tabvenda.totven, tabvenda.finalven, tabvenda.comven "
        sql = sql + " FROM tabvenda "
        sql = sql + " WHERE tabvenda.codven =  " & campo

        objDtLocal = objBanco.localizar(sql)
        If objDtLocal.Rows.Count = 0 Then
            MessageBox.Show("Registro " & campo & " não foi encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Call mostrar_dadosvindosDoBanco()
            Return True
        End If

    End Function

    Public Function Atualizar(campo As Integer)
        sql = "update tabvenda set finalven=true where codven=" & campo
        objBanco.Executar_comando(sql)

    End Function

    Public Function Localizar_porData(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicialGeralPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar_porDataInicial(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicial_AbertaPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function Localizar_porDataFinal(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicial_FechadaPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabvenda where codven=" & campo

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
    
    Public Function LocalizarVendaAberta_COUNT(ByVal dataini As Date, ByVal datafim As Date) As Integer
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicialAberta_COUNT", objBanco.objcon))
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

    Public Function LocalizarVendaFechada_COUNT(ByVal dataini As Date, ByVal datafim As Date) As Integer
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaInicialFechada_COUNT", objBanco.objcon))
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
End Class
