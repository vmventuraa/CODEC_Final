Public Class ClsCliente
    Dim c_cod As Integer
    Dim c_nom As String
    Dim c_cel As String
    Dim c_ema As String
    Dim c_end As String
    Dim c_num As String
    Dim c_com As String
    Dim c_bai As String
    Dim c_cid As String
    Dim c_est As String
    Dim c_cep As String
    Dim c_rg As String
    Dim c_cnp As String
    Dim c_jur As Boolean

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
    Public Property Celular() As String
        Get
            Return c_cel
        End Get
        Set(ByVal value As String)
            c_cel = value
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
    Public Property Endereco() As String
        Get
            Return c_end
        End Get
        Set(ByVal value As String)
            c_end = value
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
            Return c_com
        End Get
        Set(ByVal value As String)
            c_com = value
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

    Public Property Cidade() As String
        Get
            Return c_cid
        End Get
        Set(ByVal value As String)
            c_cid = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return c_est
        End Get
        Set(ByVal value As String)
            c_est = value
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
    Public Property RG() As String
        Get
            Return c_rg
        End Get
        Set(ByVal value As String)
            c_rg = value
        End Set
    End Property
    Public Property CNPJ() As String
        Get
            Return c_cnp
        End Get
        Set(ByVal value As String)
            c_cnp = value
        End Set
    End Property
   
    Public Property Juridica() As Boolean
        Get
            Return c_jur
        End Get
        Set(ByVal value As Boolean)
            c_jur = value
        End Set
    End Property

    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabcliente  " &
               "(nomcli" & _
                ",telcli" & _
                ",emacli" & _
                ",endcli" & _
                ",numcli" & _
                ",compcli" & _
                ",baicli" & _
                ",cidcli" & _
                ",estcli" & _
                ",cepcli" & _
                ",irgcli" & _
                ",cnpjcpfcli" & _
                ",pescli" & _
                ") values " &
                "('" & c_nom & "'" &
                ",'" & c_cel & "'" &
                ",'" & c_ema & "'" &
                ",'" & c_end & "'" &
                ",'" & c_num & "'" &
                ",'" & c_com & "'" &
                ",'" & c_bai & "'" &
                ",'" & c_cid & "'" &
                ",'" & c_est & "'" &
                ",'" & c_cep & "'" &
                ",'" & c_rg & "'" &
                ",'" & c_cnp & "'" &
                "," & c_jur & "" &
               ")"


            objBanco.Executar_comando(sql)
            sql = "select max(codcli) as codigo from tabcliente"
            c_cod = objBanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabcliente set " &
                 " nomcli='" & c_nom & "'" & _
                 ",telcli='" & c_cel & "'" & _
                 ",emacli='" & c_ema & "'" & _
                 ",endcli='" & c_end & "'" & _
                 ",numcli='" & c_num & "'" & _
                 ",compcli='" & c_com & "'" & _
                 ",baicli='" & c_bai & "'" & _
                 ",cidcli='" & c_cid & "'" & _
                 ",estcli='" & c_est & "'" & _
                 ",cepcli='" & c_cep & "'" & _
                 ",irgcli='" & c_rg & "'" & _
                 ",cnpjcpfcli='" & c_cnp & "'" & _
                 ",pescli=" & c_jur & "" & _
                 " where codcli=" & c_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabcliente where codcli=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabcliente where codcli=" & campo
        Else
            sql = "Select * from tabcliente where nomcli='" & campo & " '"
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
            sql = "Select * from tabcliente where codcli=" & campo
        Else
            sql = "select * from tabcliente where nomcli like '" & campo & "%' order by nomcli"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function consultatotal() As DataTable
        sql = "Select * from tabcliente order by nomcli"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function

    Public Sub mostrar_dadosVindosDoBanco()
        c_cod = objDtLocal.Rows(0).Item(0)
        c_nom = objDtLocal.Rows(0).Item(1)
        c_cel = objDtLocal.Rows(0).Item(2)
        c_ema = objDtLocal.Rows(0).Item(3)
        c_end = objDtLocal.Rows(0).Item(4)
        c_num = objDtLocal.Rows(0).Item(5)
        c_com = objDtLocal.Rows(0).Item(6)
        c_bai = objDtLocal.Rows(0).Item(7)
        c_cid = objDtLocal.Rows(0).Item(8)
        c_est = objDtLocal.Rows(0).Item(9)
        c_cep = objDtLocal.Rows(0).Item(10)
        c_rg = objDtLocal.Rows(0).Item(11)
        c_cnp = objDtLocal.Rows(0).Item(12)
        c_jur = objDtLocal.Rows(0).Item(13)

    End Sub
End Class
