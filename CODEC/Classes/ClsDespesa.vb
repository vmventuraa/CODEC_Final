Public Class ClsDespesa
    Dim d_cod As Integer
    Dim d_nom As String

    Dim sql As String
    Dim objBanco As New ClsBanco
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return d_cod
        End Get
        Set(ByVal value As Integer)
            d_cod = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return d_nom
        End Get
        Set(ByVal value As String)
            d_nom = value
        End Set
    End Property
Public Sub gravar(novo As Boolean)
        If novo Then

            sql = "insert into tabdespesa (nomdes) values ('" & d_nom & "')"
            objBanco.Executar_comando(sql)
            sql = "select max(coddes) as codigo from tabdespesa"
            d_cod = objBanco.buscar_ultimoRegistro(sql)
        Else

            sql = "update tabdespesa set nomdes='" & d_nom & "' where coddes=" & d_cod
            objBanco.Executar_comando(sql)
        End If
    End Sub
    Public Function excluir(chave As Integer) As Boolean
        If MessageBox.Show("Deseja excluir o registro " & chave & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from tabdespesa where coddes=" & chave
            objBanco.Executar_comando(sql)
            Return True
        End If
    End Function

    Public Function localizarComFiltro(campo As String) As Boolean
        If IsNumeric(campo) Then
            sql = "Select * from tabdespesa where coddes=" & campo
        Else
            sql = "Select * from tabdespesa where nomdes='" & campo & " '"
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
        sql = "Select * from tabdespesa order by nomdes"
        objDtLocal = objBanco.localizar(sql)
        Return objDtLocal
    End Function
    Public Sub mostrar_dadosVindosDoBanco()
        d_cod = objDtLocal.Rows(0).Item(0)
        d_nom = objDtLocal.Rows(0).Item(1)

    End Sub
End Class