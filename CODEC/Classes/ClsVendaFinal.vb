Public Class ClsVendaFinal
    Dim m_cod As Integer
    Dim m_cli As Integer
    Dim m_dta As Date
    Dim m_ger As Single
    Dim m_fin As Integer
    Dim m_pag As Integer

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


    Public Property Final() As Integer
        Get
            Return m_fin
        End Get
        Set(ByVal value As Integer)
            m_fin = value
        End Set
    End Property
    Public Property Pagamento As Integer
        Get
            Return m_pag
        End Get
        Set(value As Integer)
            m_pag = value
        End Set
    End Property

    Public Sub Gravar()

        sql = "insert into tabvendafinal " & _
            "(clifin" & _
            ",datfin" & _
            ",totfin" & _
            ",pagfin" & _
            ",venfin" & _
            ") values " & _
            "('" & m_cli & "'" & _
            ",'" & m_dta & "'" & _
            ",'" & m_ger & "'" & _
            "," & m_pag & "" & _
            "," & m_fin & "" & _
            ")"

        objBanco.Executar_comando(sql)

        sql = "select max(codfin) as codigo from tabvendafinal"
        m_cod = objBanco.buscar_ultimoRegistro(sql)

    End Sub
    Public Function consultatotal() As DataTable
        sql = "Select * from tabvendafinal order by datfin"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function Localizar_VendaFinalPeriodo(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaFinalPeriodo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function


    Public Function LocalizarVendaFinal_COUNT(ByVal dataini As Date, ByVal datafim As Date) As Integer
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaFinal_COUNT", objBanco.objcon))
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

    Public Function LocalizarVendafinal_TOT(ByVal dataini As Date, ByVal datafim As Date) As Single
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaFinal_TOT", objBanco.objcon))
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
    Public Function Localizar_Codigo(campo As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaFinalCodigo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function LocalizarCliente_Codigo(campo As Integer) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("TotalCliente_Codigo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function LocalizarCliente_Nome(campo As String) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("TotalCliente_Nome", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.BSTR))
        objda.SelectCommand.Parameters("campo1").Value = campo


        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function
    Public Function VendaClienteTipo(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("VendaClienteTipo", objBanco.objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo1", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("campo2", OleDb.OleDbType.Date))
        objda.SelectCommand.Parameters("campo1").Value = dataini
        objda.SelectCommand.Parameters("campo2").Value = datafim

        objds.Tables.Clear()
        objda.Fill(objds)
        Return objds.Tables(0)
    End Function

    Public Function ClientesMaisCompram(ByVal dataini As Date, ByVal datafim As Date) As DataTable
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter("ClientesMaisCompram_Periodo", objBanco.objcon))
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