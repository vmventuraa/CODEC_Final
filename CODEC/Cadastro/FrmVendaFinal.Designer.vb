<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendaFinal
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
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtGer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtSub = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtQtd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnLocPro = New System.Windows.Forms.Button()
        Me.TxtNpr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.DtpDat = New System.Windows.Forms.DateTimePicker()
        Me.TxtNcl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkFinal = New System.Windows.Forms.CheckBox()
        Me.btnconf = New System.Windows.Forms.Button()
        Me.txtCodven = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboPag = New System.Windows.Forms.ComboBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GRPGERAL = New System.Windows.Forms.GroupBox()
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRPGERAL.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCampo
        '
        Me.TxtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCampo.Enabled = False
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(386, 79)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(172, 31)
        Me.TxtCampo.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(337, 25)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Digite o Código do Empréstimo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(31, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Forma de Pagamento"
        '
        'BtnSai
        '
        Me.BtnSai.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(905, 263)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(94, 40)
        Me.BtnSai.TabIndex = 125
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(905, 171)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(94, 40)
        Me.BtnImp.TabIndex = 124
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(905, 217)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(94, 40)
        Me.BtnCan.TabIndex = 123
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(905, 125)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(94, 40)
        Me.BtnGra.TabIndex = 121
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(905, 79)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(94, 40)
        Me.BtnNov.TabIndex = 122
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'TxtGer
        '
        Me.TxtGer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGer.Enabled = False
        Me.TxtGer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGer.Location = New System.Drawing.Point(879, 381)
        Me.TxtGer.Name = "TxtGer"
        Me.TxtGer.Size = New System.Drawing.Size(104, 26)
        Me.TxtGer.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(874, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 25)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Total Geral"
        '
        'DgdGrade
        '
        Me.DgdGrade.AllowUserToAddRows = False
        Me.DgdGrade.AllowUserToDeleteRows = False
        Me.DgdGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdGrade.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DgdGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3, Me.Column5})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(12, 319)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(857, 219)
        Me.DgdGrade.TabIndex = 118
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "proite"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nompro"
        Me.Column2.HeaderText = "Nome do Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 105
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "qtdite"
        Me.Column4.HeaderText = "Qtd"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 49
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "preite"
        Me.Column3.HeaderText = "Preço"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "subtot"
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 72
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(803, 139)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(41, 28)
        Me.BtnOk.TabIndex = 117
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'TxtSub
        '
        Me.TxtSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSub.Location = New System.Drawing.Point(687, 141)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(104, 26)
        Me.TxtSub.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(685, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Sub Total"
        '
        'TxtQtd
        '
        Me.TxtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(628, 141)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(54, 26)
        Me.TxtQtd.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(626, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Qtde."
        '
        'TxtPre
        '
        Me.TxtPre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPre.Location = New System.Drawing.Point(518, 141)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(104, 26)
        Me.TxtPre.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(502, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Preço Unitário"
        '
        'BtnLocPro
        '
        Me.BtnLocPro.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLocPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocPro.Location = New System.Drawing.Point(144, 141)
        Me.BtnLocPro.Name = "BtnLocPro"
        Me.BtnLocPro.Size = New System.Drawing.Size(41, 26)
        Me.BtnLocPro.TabIndex = 110
        Me.BtnLocPro.Text = "..."
        Me.BtnLocPro.UseVisualStyleBackColor = False
        '
        'TxtNpr
        '
        Me.TxtNpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNpr.Location = New System.Drawing.Point(191, 141)
        Me.TxtNpr.Name = "TxtNpr"
        Me.TxtNpr.Size = New System.Drawing.Size(322, 26)
        Me.TxtNpr.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(189, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Nome do Produto"
        '
        'TxtPro
        '
        Me.TxtPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(14, 141)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(126, 26)
        Me.TxtPro.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Código do Produto"
        '
        'TxtCli
        '
        Me.TxtCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCli.Enabled = False
        Me.TxtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(86, 58)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(62, 26)
        Me.TxtCli.TabIndex = 104
        '
        'DtpDat
        '
        Me.DtpDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDat.Location = New System.Drawing.Point(651, 59)
        Me.DtpDat.Name = "DtpDat"
        Me.DtpDat.Size = New System.Drawing.Size(132, 26)
        Me.DtpDat.TabIndex = 100
        '
        'TxtNcl
        '
        Me.TxtNcl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNcl.Enabled = False
        Me.TxtNcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNcl.Location = New System.Drawing.Point(154, 59)
        Me.TxtNcl.Name = "TxtNcl"
        Me.TxtNcl.Size = New System.Drawing.Size(312, 26)
        Me.TxtNcl.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(472, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Data do Empréstimo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Cliente"
        '
        'ChkFinal
        '
        Me.ChkFinal.AutoSize = True
        Me.ChkFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ChkFinal.Enabled = False
        Me.ChkFinal.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFinal.ForeColor = System.Drawing.Color.White
        Me.ChkFinal.Location = New System.Drawing.Point(608, 81)
        Me.ChkFinal.Name = "ChkFinal"
        Me.ChkFinal.Size = New System.Drawing.Size(223, 33)
        Me.ChkFinal.TabIndex = 128
        Me.ChkFinal.Tag = ""
        Me.ChkFinal.Text = " Venda Efetivada"
        Me.ChkFinal.UseVisualStyleBackColor = False
        Me.ChkFinal.Visible = False
        '
        'btnconf
        '
        Me.btnconf.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.btnconf.Enabled = False
        Me.btnconf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnconf.ForeColor = System.Drawing.Color.White
        Me.btnconf.Location = New System.Drawing.Point(561, 79)
        Me.btnconf.Name = "btnconf"
        Me.btnconf.Size = New System.Drawing.Size(41, 31)
        Me.btnconf.TabIndex = 127
        Me.btnconf.Text = "Ok"
        Me.btnconf.UseVisualStyleBackColor = False
        '
        'txtCodven
        '
        Me.txtCodven.Enabled = False
        Me.txtCodven.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodven.Location = New System.Drawing.Point(212, 25)
        Me.txtCodven.Name = "txtCodven"
        Me.txtCodven.Size = New System.Drawing.Size(100, 26)
        Me.txtCodven.TabIndex = 129
        Me.txtCodven.Tag = "x"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(19, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 19)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "Código da Venda Final:"
        '
        'CboPag
        '
        Me.CboPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPag.FormattingEnabled = True
        Me.CboPag.Location = New System.Drawing.Point(217, 551)
        Me.CboPag.Margin = New System.Windows.Forms.Padding(2)
        Me.CboPag.Name = "CboPag"
        Me.CboPag.Size = New System.Drawing.Size(261, 28)
        Me.CboPag.TabIndex = 97
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(169, 31)
        Me.LblTitulo.TabIndex = 131
        Me.LblTitulo.Text = "Venda Final"
        '
        'GRPGERAL
        '
        Me.GRPGERAL.Controls.Add(Me.Label11)
        Me.GRPGERAL.Controls.Add(Me.Label1)
        Me.GRPGERAL.Controls.Add(Me.txtCodven)
        Me.GRPGERAL.Controls.Add(Me.Label3)
        Me.GRPGERAL.Controls.Add(Me.TxtNcl)
        Me.GRPGERAL.Controls.Add(Me.DtpDat)
        Me.GRPGERAL.Controls.Add(Me.TxtCli)
        Me.GRPGERAL.Controls.Add(Me.Label5)
        Me.GRPGERAL.Controls.Add(Me.TxtPro)
        Me.GRPGERAL.Controls.Add(Me.Label6)
        Me.GRPGERAL.Controls.Add(Me.TxtNpr)
        Me.GRPGERAL.Controls.Add(Me.BtnLocPro)
        Me.GRPGERAL.Controls.Add(Me.Label7)
        Me.GRPGERAL.Controls.Add(Me.TxtPre)
        Me.GRPGERAL.Controls.Add(Me.Label8)
        Me.GRPGERAL.Controls.Add(Me.BtnOk)
        Me.GRPGERAL.Controls.Add(Me.TxtQtd)
        Me.GRPGERAL.Controls.Add(Me.TxtSub)
        Me.GRPGERAL.Controls.Add(Me.Label9)
        Me.GRPGERAL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GRPGERAL.ForeColor = System.Drawing.Color.White
        Me.GRPGERAL.Location = New System.Drawing.Point(12, 125)
        Me.GRPGERAL.Name = "GRPGERAL"
        Me.GRPGERAL.Size = New System.Drawing.Size(857, 189)
        Me.GRPGERAL.TabIndex = 132
        Me.GRPGERAL.TabStop = False
        Me.GRPGERAL.Text = "Venda"
        '
        'FrmVendaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1023, 610)
        Me.Controls.Add(Me.GRPGERAL)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.ChkFinal)
        Me.Controls.Add(Me.btnconf)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.TxtGer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.CboPag)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmVendaFinal"
        Me.Text = "Realizar Venda Final"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRPGERAL.ResumeLayout(False)
        Me.GRPGERAL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtGer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtSub As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtQtd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnLocPro As System.Windows.Forms.Button
    Friend WithEvents TxtNpr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents DtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNcl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkFinal As System.Windows.Forms.CheckBox
    Friend WithEvents btnconf As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodven As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboPag As System.Windows.Forms.ComboBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GRPGERAL As System.Windows.Forms.GroupBox
End Class
