Public Class ClsFornecedor
    Dim c_cod As Integer
    Dim c_raz As String
    Dim c_cnpj As String
    Dim c_ins As String
    Dim c_num As String
    Dim c_comp As String
    Dim c_bai As String
    Dim c_ema As String
    Dim c_tel As String
    Dim c_con As String
    Dim c_cep As String
    Dim c_cid As String

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

    Public Property Razao() As String
        Get
            Return c_raz
        End Get
        Set(ByVal value As String)
            c_raz = value
        End Set
    End Property

    Public Property Cnpj() As String
        Get
            Return c_cnpj
        End Get
        Set(ByVal value As String)
            c_cnpj = value
        End Set
    End Property

    Public Property Inscricao() As String
        Get
            Return c_ins
        End Get
        Set(ByVal value As String)
            c_ins = value
        End Set
    End Property

    Public Property Numero() As String
        Get
            Return c_num
        End Get
        Set(ByVal value As String)
            c_num = value
        End Set
    End Property

    Public Property Complemento() As String
        Get
            Return c_comp
        End Get
        Set(ByVal value As String)
            c_comp = value
        End Set
    End Property

    Public Property Bairro() As String
        Get
            Return c_bai
        End Get
        Set(ByVal value As String)
            c_bai = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return c_ema
        End Get
        Set(ByVal value As String)
            c_ema = value
        End Set
    End Property

    Public Property Telefone() As String
        Get
            Return c_tel
        End Get
        Set(ByVal value As String)
            c_tel = value
        End Set
    End Property
    Public Property Contato() As String
        Get
            Return c_con
        End Get
        Set(ByVal value As String)
            c_con = value
        End Set
    End Property

    Public Property CEP() As String
        Get
            Return c_cep
        End Get
        Set(ByVal value As String)
            c_cep = value
        End Set
    End Property

    Public Property Cidade() As String
        Get
            Return c_cid
        End Get
        Set(ByVal value As String)
            c_cid = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then

            sql = "insert into tabfornecedor  " &
               "(razfor" & _
                ",cnpjfor" & _
                ",insfor" & _
                ",numfor" & _
                ",compfor" & _
                ",baifor" & _
                ",emafor" & _
                ",telfor" & _
                ",confor" & _
                ",cidfor" & _
                ",cepfor" & _
                ") values " &
                "('" & c_raz & "'" &
                ",'" & c_cnpj & "'" &
                ",'" & c_ins & "'" &
                ",'" & c_num & "'" &
                ",'" & c_comp & "'" &
                ",'" & c_bai & "'" &
                ",'" & c_ema & "'" &
                ",'" & c_tel & "'" &
                ",'" & c_con & "'" &
                ",'" & c_cid & "'" &
                ",'" & c_cep & "'" &
               ")"
            objBanco.Executar_comando(sql)
            sql = "select max(codfor) as codigo from tabfornecedor"
            c_cod = objBanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabfornecedor set " &
                           "razfor='" & c_raz & "'" & _
                           ",cnpjfor='" & c_cnpj & "'" & _
                           ",insfor='" & c_ins & "'" & _
                           ",numfor='" & c_num & "'" & _
                           ",compfor='" & c_comp & "'" & _
                           ",baifor='" & c_bai & "'" & _
                           ",emafor='" & c_ema & "'" & _
                           ",telfor='" & c_tel & "'" & _
                           ",confor='" & c_con & "'" & _
                           ",cidfor='" & c_cid & "'" & _
                           ",cepfor='" & c_cep & "'" & _
                           " where codfor=" & c_cod

            objBanco.Executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabfornecedor where codfor=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabfornecedor where codfor=" & campo
        Else
            sql = "Select * from tabfornecedor where razfor='" & campo & " '"
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
    Public Function Localizar(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabfornecedor where codfor=" & campo
        Else
            sql = "select * from tabfornecedor where razfor like '" & campo & "%' order by razfor"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function consultatotal() As DataTable
        sql = "Select * from tabfornecedor order by razfor"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Sub mostrar_dadosVindosDoBanco()
        c_cod = objDtLocal.Rows(0).Item(0)
        c_raz = objDtLocal.Rows(0).Item(1)
        c_cnpj = objDtLocal.Rows(0).Item(2)
        c_ins = objDtLocal.Rows(0).Item(3)
        c_num = objDtLocal.Rows(0).Item(4)
        c_comp = objDtLocal.Rows(0).Item(5)
        c_bai = objDtLocal.Rows(0).Item(6)
        c_ema = objDtLocal.Rows(0).Item(7)
        c_tel = objDtLocal.Rows(0).Item(8)
        c_con = objDtLocal.Rows(0).Item(9)
        c_cid = objDtLocal.Rows(0).Item(10)
        c_cep = objDtLocal.Rows(0).Item(11)
    End Sub
End Class

