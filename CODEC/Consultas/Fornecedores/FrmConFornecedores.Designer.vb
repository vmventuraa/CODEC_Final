<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConFornecedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column11, Me.Column10, Me.Column8, Me.Column9, Me.Column12})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(190, 145)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(973, 414)
        Me.DgdGrade.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codfor"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "razfor"
        Me.Column2.HeaderText = "Razão Social"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 87
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "cnpjfor"
        Me.Column3.HeaderText = "CNPJ"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 59
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "insfor"
        Me.Column4.HeaderText = "Inscrição Estadual"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 109
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "telfor"
        Me.Column5.HeaderText = "Telefone"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 74
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "confor"
        Me.Column6.HeaderText = "Contato"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 69
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "numfor"
        Me.Column7.HeaderText = "Número do Endereço"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 122
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "baifor"
        Me.Column11.HeaderText = "Bairro"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 59
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "cidfor"
        Me.Column10.HeaderText = "Cidade"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 65
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "compfor"
        Me.Column8.HeaderText = "Complemento"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 96
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "emafor"
        Me.Column9.HeaderText = "Email"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 57
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "cepfor"
        Me.Column12.HeaderText = "CEP"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 53
        '
        'TxtCampo
        '
        Me.TxtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(652, 89)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(367, 31)
        Me.TxtCampo.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(293, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 25)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Digite a Razão Social ou Código"
        '
        'FrmConFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1268, 629)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmConFornecedores"
        Me.Text = "Consulta de Fornecedores por Código/Nome"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
