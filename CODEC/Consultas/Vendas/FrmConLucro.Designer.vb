<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConLucro
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
        Me.TxtTotVen = New System.Windows.Forms.TextBox()
        Me.LblTotVenda = New System.Windows.Forms.Label()
        Me.TxtQntdVenda = New System.Windows.Forms.TextBox()
        Me.LblQntdVenda = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgdGradeVenda = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotDesp = New System.Windows.Forms.TextBox()
        Me.LblTotDesp = New System.Windows.Forms.Label()
        Me.DgdGradeDespesa = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtQntdDesp = New System.Windows.Forms.TextBox()
        Me.LblQntdDesp = New System.Windows.Forms.Label()
        Me.TxtLucro = New System.Windows.Forms.TextBox()
        Me.LblLucro = New System.Windows.Forms.Label()
        CType(Me.DgdGradeVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgdGradeDespesa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTotVen
        '
        Me.TxtTotVen.Enabled = False
        Me.TxtTotVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotVen.Location = New System.Drawing.Point(795, 221)
        Me.TxtTotVen.Name = "TxtTotVen"
        Me.TxtTotVen.Size = New System.Drawing.Size(82, 24)
        Me.TxtTotVen.TabIndex = 116
        Me.TxtTotVen.Visible = False
        '
        'LblTotVenda
        '
        Me.LblTotVenda.AutoSize = True
        Me.LblTotVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotVenda.ForeColor = System.Drawing.Color.White
        Me.LblTotVenda.Location = New System.Drawing.Point(790, 198)
        Me.LblTotVenda.Name = "LblTotVenda"
        Me.LblTotVenda.Size = New System.Drawing.Size(145, 20)
        Me.LblTotVenda.TabIndex = 115
        Me.LblTotVenda.Tag = "x"
        Me.LblTotVenda.Text = "Total de Vendas:"
        Me.LblTotVenda.Visible = False
        '
        'TxtQntdVenda
        '
        Me.TxtQntdVenda.Enabled = False
        Me.TxtQntdVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQntdVenda.Location = New System.Drawing.Point(795, 139)
        Me.TxtQntdVenda.Name = "TxtQntdVenda"
        Me.TxtQntdVenda.Size = New System.Drawing.Size(82, 24)
        Me.TxtQntdVenda.TabIndex = 114
        Me.TxtQntdVenda.Visible = False
        '
        'LblQntdVenda
        '
        Me.LblQntdVenda.AutoSize = True
        Me.LblQntdVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblQntdVenda.ForeColor = System.Drawing.Color.White
        Me.LblQntdVenda.Location = New System.Drawing.Point(787, 116)
        Me.LblQntdVenda.Name = "LblQntdVenda"
        Me.LblQntdVenda.Size = New System.Drawing.Size(198, 20)
        Me.LblQntdVenda.TabIndex = 113
        Me.LblQntdVenda.Tag = "x"
        Me.LblQntdVenda.Text = "Quantidade de Vendas:"
        Me.LblQntdVenda.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(495, 44)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(96, 35)
        Me.BtnOk.TabIndex = 112
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(373, 46)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(99, 26)
        Me.DtpFim.TabIndex = 111
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(149, 47)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(99, 26)
        Me.DtpIni.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(270, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Tag = "x"
        Me.Label1.Text = "Data Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 108
        Me.Label2.Tag = "x"
        Me.Label2.Text = "Data Inicial:"
        '
        'DgdGradeVenda
        '
        Me.DgdGradeVenda.AllowUserToAddRows = False
        Me.DgdGradeVenda.AllowUserToDeleteRows = False
        Me.DgdGradeVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGradeVenda.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DgdGradeVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradeVenda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.DgdGradeVenda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGradeVenda.Location = New System.Drawing.Point(24, 116)
        Me.DgdGradeVenda.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGradeVenda.Name = "DgdGradeVenda"
        Me.DgdGradeVenda.RowTemplate.Height = 24
        Me.DgdGradeVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGradeVenda.Size = New System.Drawing.Size(693, 226)
        Me.DgdGradeVenda.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codfin"
        Me.Column1.HeaderText = "Código da Venda"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 105
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "clifin"
        Me.Column6.HeaderText = "Código do Cliente"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 105
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomcli"
        Me.Column2.HeaderText = "Cliente"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 64
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "datfin"
        Me.Column3.HeaderText = "Data"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 55
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "totfin"
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 56
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "nomfor"
        Me.Column5.HeaderText = "Forma de Pagamento"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 122
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "venfin"
        Me.Column7.HeaderText = "Código da Venda Inicial"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 107
        '
        'TxtTotDesp
        '
        Me.TxtTotDesp.Enabled = False
        Me.TxtTotDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotDesp.Location = New System.Drawing.Point(792, 443)
        Me.TxtTotDesp.Name = "TxtTotDesp"
        Me.TxtTotDesp.Size = New System.Drawing.Size(61, 24)
        Me.TxtTotDesp.TabIndex = 119
        Me.TxtTotDesp.Visible = False
        '
        'LblTotDesp
        '
        Me.LblTotDesp.AutoSize = True
        Me.LblTotDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTotDesp.ForeColor = System.Drawing.Color.White
        Me.LblTotDesp.Location = New System.Drawing.Point(789, 422)
        Me.LblTotDesp.Name = "LblTotDesp"
        Me.LblTotDesp.Size = New System.Drawing.Size(155, 20)
        Me.LblTotDesp.TabIndex = 118
        Me.LblTotDesp.Tag = "x"
        Me.LblTotDesp.Text = "Tota de Despesas"
        Me.LblTotDesp.Visible = False
        '
        'DgdGradeDespesa
        '
        Me.DgdGradeDespesa.AllowUserToAddRows = False
        Me.DgdGradeDespesa.AllowUserToDeleteRows = False
        Me.DgdGradeDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGradeDespesa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DgdGradeDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGradeDespesa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DgdGradeDespesa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGradeDespesa.Location = New System.Drawing.Point(26, 361)
        Me.DgdGradeDespesa.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGradeDespesa.Name = "DgdGradeDespesa"
        Me.DgdGradeDespesa.RowTemplate.Height = 24
        Me.DgdGradeDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGradeDespesa.Size = New System.Drawing.Size(691, 222)
        Me.DgdGradeDespesa.TabIndex = 117
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "codlan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código do Lançamento "
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 132
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "deslan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número da Despesa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 118
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nomdes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nome da Despesa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "datlan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data da Despesa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 105
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "desclan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descricçao da Despesa"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "vallan"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Valor da Despesa"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 106
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "paglan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Forma de Pagamento"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 122
        '
        'TxtQntdDesp
        '
        Me.TxtQntdDesp.Enabled = False
        Me.TxtQntdDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQntdDesp.Location = New System.Drawing.Point(795, 391)
        Me.TxtQntdDesp.Name = "TxtQntdDesp"
        Me.TxtQntdDesp.Size = New System.Drawing.Size(82, 24)
        Me.TxtQntdDesp.TabIndex = 121
        Me.TxtQntdDesp.Visible = False
        '
        'LblQntdDesp
        '
        Me.LblQntdDesp.AutoSize = True
        Me.LblQntdDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblQntdDesp.ForeColor = System.Drawing.Color.White
        Me.LblQntdDesp.Location = New System.Drawing.Point(789, 361)
        Me.LblQntdDesp.Name = "LblQntdDesp"
        Me.LblQntdDesp.Size = New System.Drawing.Size(245, 20)
        Me.LblQntdDesp.TabIndex = 120
        Me.LblQntdDesp.Tag = "x"
        Me.LblQntdDesp.Text = "Quantidade de Lançamentos:"
        Me.LblQntdDesp.Visible = False
        '
        'TxtLucro
        '
        Me.TxtLucro.Enabled = False
        Me.TxtLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLucro.Location = New System.Drawing.Point(793, 559)
        Me.TxtLucro.Name = "TxtLucro"
        Me.TxtLucro.Size = New System.Drawing.Size(107, 24)
        Me.TxtLucro.TabIndex = 123
        Me.TxtLucro.Visible = False
        '
        'LblLucro
        '
        Me.LblLucro.AutoSize = True
        Me.LblLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblLucro.ForeColor = System.Drawing.Color.White
        Me.LblLucro.Location = New System.Drawing.Point(788, 532)
        Me.LblLucro.Name = "LblLucro"
        Me.LblLucro.Size = New System.Drawing.Size(104, 20)
        Me.LblLucro.TabIndex = 122
        Me.LblLucro.Tag = "x"
        Me.LblLucro.Text = "Lucro Total:"
        Me.LblLucro.Visible = False
        '
        'FrmConLucro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1045, 643)
        Me.Controls.Add(Me.TxtLucro)
        Me.Controls.Add(Me.LblLucro)
        Me.Controls.Add(Me.TxtQntdDesp)
        Me.Controls.Add(Me.LblQntdDesp)
        Me.Controls.Add(Me.TxtTotDesp)
        Me.Controls.Add(Me.LblTotDesp)
        Me.Controls.Add(Me.DgdGradeDespesa)
        Me.Controls.Add(Me.TxtTotVen)
        Me.Controls.Add(Me.LblTotVenda)
        Me.Controls.Add(Me.TxtQntdVenda)
        Me.Controls.Add(Me.LblQntdVenda)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgdGradeVenda)
        Me.Name = "FrmConLucro"
        Me.Text = "Consulta do Faturamento por Período"
        CType(Me.DgdGradeVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgdGradeDespesa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTotVen As System.Windows.Forms.TextBox
    Friend WithEvents LblTotVenda As System.Windows.Forms.Label
    Friend WithEvents TxtQntdVenda As System.Windows.Forms.TextBox
    Friend WithEvents LblQntdVenda As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgdGradeVenda As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtTotDesp As System.Windows.Forms.TextBox
    Friend WithEvents LblTotDesp As System.Windows.Forms.Label
    Friend WithEvents DgdGradeDespesa As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtQntdDesp As System.Windows.Forms.TextBox
    Friend WithEvents LblQntdDesp As System.Windows.Forms.Label
    Friend WithEvents TxtLucro As System.Windows.Forms.TextBox
    Friend WithEvents LblLucro As System.Windows.Forms.Label
End Class
