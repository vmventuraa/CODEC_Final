Public Class ClsItemFinal
    Dim m_ven, m_seq, m_pro, m_qtd As Integer
    Dim m_pre As Single
    Dim objbanco As New ClsBanco
    Dim sql As String


    Public Property Venda() As Integer
        Get
            Return m_ven
        End Get
        Set(ByVal value As Integer)
            m_ven = value
        End Set
    End Property

    Public Property Sequencia() As Integer
        Get
            Return m_seq
        End Get
        Set(ByVal value As Integer)
            m_seq = value
        End Set
    End Property
    Public Property Produto() As Integer
        Get
            Return m_pro
        End Get
        Set(ByVal value As Integer)
            m_pro = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return m_qtd
        End Get
        Set(ByVal value As Integer)
            m_qtd = value
        End Set
    End Property

    Public Property Preco() As Single
        Get
            Return m_pre
        End Get
        Set(ByVal value As Single)
            m_pre = value
        End Set
    End Property

    Public Sub gravar()
        sql = "insert into tabitemfinal " & _
        "(venitf" & _
        ",seqitf" & _
        ",proitf" & _
        ",qtditf" & _
        ",preitf" & _
        ") values " & _
        "('" & m_ven & "'" & _
        ",'" & m_seq & "'" & _
        ",'" & m_pro & "'" & _
        ",'" & m_qtd & "'" & _
        ",'" & m_pre & "'" & _
        ")"
        objbanco.Executar_comando(sql)
    End Sub

End Class
