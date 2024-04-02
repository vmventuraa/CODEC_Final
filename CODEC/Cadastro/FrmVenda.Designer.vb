<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenda
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
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.TxtGer = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgdItem = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.BtnLocCli = New System.Windows.Forms.Button()
        Me.TxtCli = New System.Windows.Forms.TextBox()
        Me.DtpDat = New System.Windows.Forms.DateTimePicker()
        Me.TxtNcl = New System.Windows.Forms.TextBox()
        Me.TxtVen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpdevolução = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GRP1 = New System.Windows.Forms.GroupBox()
        Me.GRP2 = New System.Windows.Forms.GroupBox()
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP1.SuspendLayout()
        Me.GRP2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSai
        '
        Me.BtnSai.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(940, 227)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(94, 40)
        Me.BtnSai.TabIndex = 89
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(940, 135)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(94, 40)
        Me.BtnImp.TabIndex = 87
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(940, 181)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(94, 40)
        Me.BtnCan.TabIndex = 86
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(940, 89)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(94, 40)
        Me.BtnGra.TabIndex = 84
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(940, 43)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(94, 40)
        Me.BtnNov.TabIndex = 85
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'TxtGer
        '
        Me.TxtGer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGer.Enabled = False
        Me.TxtGer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGer.Location = New System.Drawing.Point(861, 345)
        Me.TxtGer.Name = "TxtGer"
        Me.TxtGer.Size = New System.Drawing.Size(104, 26)
        Me.TxtGer.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(856, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 25)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Total Geral"
        '
        'DgdItem
        '
        Me.DgdItem.AllowUserToAddRows = False
        Me.DgdItem.AllowUserToDeleteRows = False
        Me.DgdItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgdItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DgdItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgdItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DgdItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdItem.Location = New System.Drawing.Point(21, 234)
        Me.DgdItem.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdItem.Name = "DgdItem"
        Me.DgdItem.RowTemplate.Height = 24
        Me.DgdItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdItem.Size = New System.Drawing.Size(830, 219)
        Me.DgdItem.TabIndex = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome do Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 105
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qtd"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 49
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 72
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Enabled = False
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(809, 80)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(41, 28)
        Me.BtnOk.TabIndex = 79
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'TxtSub
        '
        Me.TxtSub.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSub.Enabled = False
        Me.TxtSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSub.Location = New System.Drawing.Point(693, 82)
        Me.TxtSub.Name = "TxtSub"
        Me.TxtSub.Size = New System.Drawing.Size(104, 26)
        Me.TxtSub.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(691, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Sub Total"
        '
        'TxtQtd
        '
        Me.TxtQtd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtQtd.Enabled = False
        Me.TxtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQtd.Location = New System.Drawing.Point(634, 82)
        Me.TxtQtd.Name = "TxtQtd"
        Me.TxtQtd.Size = New System.Drawing.Size(54, 26)
        Me.TxtQtd.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(632, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Qtde."
        '
        'TxtPre
        '
        Me.TxtPre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPre.Enabled = False
        Me.TxtPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPre.Location = New System.Drawing.Point(524, 82)
        Me.TxtPre.Name = "TxtPre"
        Me.TxtPre.Size = New System.Drawing.Size(104, 26)
        Me.TxtPre.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(505, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Preço Unitário"
        '
        'BtnLocPro
        '
        Me.BtnLocPro.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLocPro.Enabled = False
        Me.BtnLocPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocPro.ForeColor = System.Drawing.Color.White
        Me.BtnLocPro.Location = New System.Drawing.Point(150, 80)
        Me.BtnLocPro.Name = "BtnLocPro"
        Me.BtnLocPro.Size = New System.Drawing.Size(41, 26)
        Me.BtnLocPro.TabIndex = 72
        Me.BtnLocPro.Text = "..."
        Me.BtnLocPro.UseVisualStyleBackColor = False
        '
        'TxtNpr
        '
        Me.TxtNpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNpr.Enabled = False
        Me.TxtNpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNpr.Location = New System.Drawing.Point(197, 82)
        Me.TxtNpr.Name = "TxtNpr"
        Me.TxtNpr.Size = New System.Drawing.Size(322, 26)
        Me.TxtNpr.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(195, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Nome do Produto"
        '
        'TxtPro
        '
        Me.TxtPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPro.Enabled = False
        Me.TxtPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPro.Location = New System.Drawing.Point(20, 82)
        Me.TxtPro.Name = "TxtPro"
        Me.TxtPro.Size = New System.Drawing.Size(126, 26)
        Me.TxtPro.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Código do Produto"
        '
        'BtnLocCli
        '
        Me.BtnLocCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLocCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocCli.ForeColor = System.Drawing.Color.White
        Me.BtnLocCli.Location = New System.Drawing.Point(165, 12)
        Me.BtnLocCli.Name = "BtnLocCli"
        Me.BtnLocCli.Size = New System.Drawing.Size(41, 26)
        Me.BtnLocCli.TabIndex = 67
        Me.BtnLocCli.Text = "..."
        Me.BtnLocCli.UseVisualStyleBackColor = False
        '
        'TxtCli
        '
        Me.TxtCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCli.Location = New System.Drawing.Point(98, 12)
        Me.TxtCli.Name = "TxtCli"
        Me.TxtCli.Size = New System.Drawing.Size(62, 26)
        Me.TxtCli.TabIndex = 66
        '
        'DtpDat
        '
        Me.DtpDat.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DtpDat.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DtpDat.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DtpDat.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DtpDat.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.DtpDat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDat.Location = New System.Drawing.Point(190, 20)
        Me.DtpDat.Name = "DtpDat"
        Me.DtpDat.Size = New System.Drawing.Size(132, 26)
        Me.DtpDat.TabIndex = 61
        '
        'TxtNcl
        '
        Me.TxtNcl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNcl.Location = New System.Drawing.Point(213, 12)
        Me.TxtNcl.Name = "TxtNcl"
        Me.TxtNcl.Size = New System.Drawing.Size(312, 26)
        Me.TxtNcl.TabIndex = 60
        '
        'TxtVen
        '
        Me.TxtVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVen.Location = New System.Drawing.Point(194, 59)
        Me.TxtVen.Name = "TxtVen"
        Me.TxtVen.Size = New System.Drawing.Size(100, 26)
        Me.TxtVen.TabIndex = 59
        Me.TxtVen.Tag = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Data do empréstimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Número do empréstimo"
        '
        'dtpdevolução
        '
        Me.dtpdevolução.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdevolução.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdevolução.Location = New System.Drawing.Point(496, 20)
        Me.dtpdevolução.Name = "dtpdevolução"
        Me.dtpdevolução.Size = New System.Drawing.Size(132, 26)
        Me.dtpdevolução.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(328, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 20)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Data da Devolução"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(15, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(183, 31)
        Me.LblTitulo.TabIndex = 92
        Me.LblTitulo.Text = "Empréstimos"
        '
        'GRP1
        '
        Me.GRP1.Controls.Add(Me.dtpdevolução)
        Me.GRP1.Controls.Add(Me.Label3)
        Me.GRP1.Controls.Add(Me.Label4)
        Me.GRP1.Controls.Add(Me.DtpDat)
        Me.GRP1.Location = New System.Drawing.Point(300, 43)
        Me.GRP1.Name = "GRP1"
        Me.GRP1.Size = New System.Drawing.Size(634, 63)
        Me.GRP1.TabIndex = 93
        Me.GRP1.TabStop = False
        '
        'GRP2
        '
        Me.GRP2.Controls.Add(Me.Label2)
        Me.GRP2.Controls.Add(Me.TxtNcl)
        Me.GRP2.Controls.Add(Me.TxtCli)
        Me.GRP2.Controls.Add(Me.BtnLocCli)
        Me.GRP2.Controls.Add(Me.Label5)
        Me.GRP2.Controls.Add(Me.TxtPro)
        Me.GRP2.Controls.Add(Me.Label6)
        Me.GRP2.Controls.Add(Me.TxtNpr)
        Me.GRP2.Controls.Add(Me.BtnLocPro)
        Me.GRP2.Controls.Add(Me.Label7)
        Me.GRP2.Controls.Add(Me.TxtPre)
        Me.GRP2.Controls.Add(Me.BtnOk)
        Me.GRP2.Controls.Add(Me.Label8)
        Me.GRP2.Controls.Add(Me.TxtSub)
        Me.GRP2.Controls.Add(Me.TxtQtd)
        Me.GRP2.Controls.Add(Me.Label9)
        Me.GRP2.Location = New System.Drawing.Point(21, 112)
        Me.GRP2.Name = "GRP2"
        Me.GRP2.Size = New System.Drawing.Size(913, 117)
        Me.GRP2.TabIndex = 94
        Me.GRP2.TabStop = False
        '
        'FrmVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1041, 508)
        Me.Controls.Add(Me.TxtVen)
        Me.Controls.Add(Me.GRP2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GRP1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.TxtGer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DgdItem)
        Me.Name = "FrmVenda"
        Me.Text = "Realizar Empréstimo"
        CType(Me.DgdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP1.ResumeLayout(False)
        Me.GRP1.PerformLayout()
        Me.GRP2.ResumeLayout(False)
        Me.GRP2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents TxtGer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DgdItem As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents BtnLocCli As System.Windows.Forms.Button
    Friend WithEvents TxtCli As System.Windows.Forms.TextBox
    Friend WithEvents DtpDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNcl As System.Windows.Forms.TextBox
    Friend WithEvents TxtVen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpdevolução As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GRP1 As System.Windows.Forms.GroupBox
    Friend WithEvents GRP2 As System.Windows.Forms.GroupBox
End Class
