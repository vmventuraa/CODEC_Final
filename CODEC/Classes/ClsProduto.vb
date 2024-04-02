Public Class ClsProduto
    Dim c_cod As Long
    Dim c_nom As String
    Dim c_for As Integer
    Dim c_pre As Single
    Dim c_atu As Integer
    Dim c_ncm As String
    Dim c_imp As String
    Dim c_mat As String
    Dim c_tip As Integer
    Dim c_desc As String
   

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable


    Public Property Codigo() As Long
        Get
            Return c_cod
        End Get
        Set(value As Long)
            c_cod = value
        End Set
    End Property


    Public Property Nome() As String
        Get
            Return c_nom
        End Get
        Set(value As String)
            c_nom = value
        End Set
    End Property

    Public Property Fornecedor() As Integer
        Get
            Return c_for
        End Get
        Set(value As Integer)
            c_for = value
        End Set
    End Property

    Public Property Preço() As Single
        Get
            Return c_pre
        End Get
        Set(value As Single)
            c_pre = value
        End Set
    End Property

    Public Property Atual() As Integer
        Get
            Return c_atu
        End Get
        Set(value As Integer)
            c_atu = value
        End Set
    End Property

    Public Property NCM() As Integer
        Get
            Return c_ncm
        End Get
        Set(value As Integer)
            c_ncm = value
        End Set
    End Property

    Public Property Imposto() As String
        Get
            Return c_imp
        End Get
        Set(value As String)
            c_imp = value
        End Set
    End Property

    Public Property Material() As String
        Get
            Return c_mat
        End Get
        Set(value As String)
            c_mat = value
        End Set
    End Property

    Public Property Tipo() As Integer
        Get
            Return c_tip
        End Get
        Set(value As Integer)
            c_tip = value
        End Set
    End Property

    Public Property Descrição() As String
        Get
            Return c_desc
        End Get
        Set(value As String)
            c_desc = value
        End Set
    End Property


    Public Sub gravar(novo As Boolean)
        If novo Then
            sql = "insert into tabproduto " & _
               "(codpro" & _
                ",nompro " & _
                ",fornpro" & _
                ",prepro" & _
                ",atupro" & _
                ",descpro" & _
                ",ncmpro" & _
                ",imppro" & _
                ",matpro" & _
                ",tippro" & _
                ") values " &
                 "('" & c_cod & "'" & _
                ",'" & c_nom & "'" & _
                ",'" & c_for & "'" & _
                ",'" & c_pre & "'" & _
                ",'" & c_atu & "'" & _
                ",'" & c_desc & "'" & _
                ",'" & c_ncm & "'" & _
                ",'" & c_imp & "'" & _
                ",'" & c_mat & "'" & _
                ",'" & c_tip & "'" & _
                  ")"

            objBanco.Executar_comando(sql)

        Else
            sql = "update tabproduto set " &
             " nompro='" & c_nom & "'" & _
              ",fornpro='" & c_for & "'" & _
              ",prepro='" & c_pre & "'" & _
              ",atupro='" & c_atu & "'" & _
              ",descpro='" & c_desc & "'" & _
              ",ncmpro='" & c_ncm & "'" & _
              ",imppro='" & c_imp & "'" & _
              ",matpro='" & c_mat & "'" & _
              ",tippro='" & c_tip & "'" & _
              " where codpro=" & c_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub

    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabproduto where codpro=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizar(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabproduto where codpro=" & campo
        Else
            sql = "Select * from tabproduto where nompro='" & campo & " '"
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

   
    Private Sub mostrar_dadosVindosDoBanco()
        c_cod = objDtLocal.Rows(0).Item(0)
        c_nom = objDtLocal.Rows(0).Item(1)
        c_for = objDtLocal.Rows(0).Item(2)
        c_pre = objDtLocal.Rows(0).Item(3)
        c_atu = objDtLocal.Rows(0).Item(4)
        c_desc = objDtLocal.Rows(0).Item(5)
        c_ncm = objDtLocal.Rows(0).Item(6)
        c_imp = objDtLocal.Rows(0).Item(7)
        c_mat = objDtLocal.Rows(0).Item(8)
        c_tip = objDtLocal.Rows(0).Item(9)
    End Sub
    Public Sub baixar_estoque(codpro As Long, qtd As Integer)
        sql = "update tabproduto set atupro=atupro-" & qtd & " where codpro=" & codpro
        objBanco.Executar_comando(sql)
    End Sub

    Public Sub devolver_estoque(codpro As Long, qtd As Integer)
        sql = "update tabproduto set atupro=atupro+" & qtd & " where codpro=" & codpro
        objBanco.Executar_comando(sql)
    End Sub
    Public Function Localizar_consulta(campo As String) As DataTable
        If IsNumeric(campo) Then
            sql = "Select * from tabproduto where codpro=" & campo
        Else
            sql = "select * from tabproduto where nompro like '" & campo & "%' order by nompro"
        End If
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Function consultaprodutos() As DataTable
        sql = "Select tabproduto.* from tabproduto"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
End Class
