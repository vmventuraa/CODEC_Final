<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadCliente
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
        Me.MskCel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEma = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnomeraz = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtRg = New System.Windows.Forms.TextBox()
        Me.lblrrginc = New System.Windows.Forms.Label()
        Me.lblcpfcnpj = New System.Windows.Forms.Label()
        Me.ChkJur = New System.Windows.Forms.CheckBox()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.MskCEP = New System.Windows.Forms.MaskedTextBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.CBXest = New System.Windows.Forms.ComboBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GRPEND = New System.Windows.Forms.GroupBox()
        Me.GRPGERAL = New System.Windows.Forms.GroupBox()
        Me.GrpLoc.SuspendLayout()
        Me.GRPEND.SuspendLayout()
        Me.GRPGERAL.SuspendLayout()
        Me.SuspendLayout()
        '
        'MskCel
        '
        Me.MskCel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCel.Location = New System.Drawing.Point(84, 72)
        Me.MskCel.Mask = "(99) 00000-0000"
        Me.MskCel.Name = "MskCel"
        Me.MskCel.Size = New System.Drawing.Size(131, 26)
        Me.MskCel.TabIndex = 1
        '
        'TxtEma
        '
        Me.TxtEma.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEma.Location = New System.Drawing.Point(302, 76)
        Me.TxtEma.Name = "TxtEma"
        Me.TxtEma.Size = New System.Drawing.Size(430, 26)
        Me.TxtEma.TabIndex = 2
        Me.TxtEma.Tag = ""
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(352, 40)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(380, 26)
        Me.TxtNom.TabIndex = 0
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(84, 43)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(63, 26)
        Me.TxtCod.TabIndex = 2
        Me.TxtCod.Tag = "x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(234, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "E-mail:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Celular:"
        '
        'lblnomeraz
        '
        Me.lblnomeraz.AutoSize = True
        Me.lblnomeraz.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeraz.ForeColor = System.Drawing.Color.White
        Me.lblnomeraz.Location = New System.Drawing.Point(234, 43)
        Me.lblnomeraz.Name = "lblnomeraz"
        Me.lblnomeraz.Size = New System.Drawing.Size(60, 19)
        Me.lblnomeraz.TabIndex = 7
        Me.lblnomeraz.Text = "Nome:"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.ForeColor = System.Drawing.Color.White
        Me.lblcod.Location = New System.Drawing.Point(13, 47)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(65, 19)
        Me.lblcod.TabIndex = 5
        Me.lblcod.Text = "Código"
        '
        'TxtEnd
        '
        Me.TxtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEnd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnd.Location = New System.Drawing.Point(281, 21)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(588, 26)
        Me.TxtEnd.TabIndex = 6
        Me.TxtEnd.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(186, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Endereço:"
        '
        'TxtNum
        '
        Me.TxtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNum.Location = New System.Drawing.Point(86, 56)
        Me.TxtNum.Name = "TxtNum"
        Me.TxtNum.Size = New System.Drawing.Size(87, 26)
        Me.TxtNum.TabIndex = 7
        Me.TxtNum.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MintCream
        Me.Label6.Location = New System.Drawing.Point(11, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Número:"
        '
        'TxtCom
        '
        Me.TxtCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCom.Location = New System.Drawing.Point(302, 56)
        Me.TxtCom.Name = "TxtCom"
        Me.TxtCom.Size = New System.Drawing.Size(144, 26)
        Me.TxtCom.TabIndex = 8
        Me.TxtCom.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(177, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Complemento:"
        '
        'TxtBai
        '
        Me.TxtBai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBai.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBai.Location = New System.Drawing.Point(520, 56)
        Me.TxtBai.Name = "TxtBai"
        Me.TxtBai.Size = New System.Drawing.Size(349, 26)
        Me.TxtBai.TabIndex = 9
        Me.TxtBai.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(452, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Bairro:"
        '
        'TxtCid
        '
        Me.TxtCid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCid.Location = New System.Drawing.Point(86, 93)
        Me.TxtCid.Name = "TxtCid"
        Me.TxtCid.Size = New System.Drawing.Size(250, 26)
        Me.TxtCid.TabIndex = 10
        Me.TxtCid.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MintCream
        Me.Label10.Location = New System.Drawing.Point(13, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 19)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Cidade:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(349, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 19)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Estado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.MintCream
        Me.Label12.Location = New System.Drawing.Point(12, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 19)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "CEP:"
        '
        'TxtRg
        '
        Me.TxtRg.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtRg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRg.Location = New System.Drawing.Point(503, 107)
        Me.TxtRg.Name = "TxtRg"
        Me.TxtRg.Size = New System.Drawing.Size(229, 26)
        Me.TxtRg.TabIndex = 4
        Me.TxtRg.Tag = ""
        '
        'lblrrginc
        '
        Me.lblrrginc.AutoSize = True
        Me.lblrrginc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrrginc.ForeColor = System.Drawing.Color.White
        Me.lblrrginc.Location = New System.Drawing.Point(352, 110)
        Me.lblrrginc.Name = "lblrrginc"
        Me.lblrrginc.Size = New System.Drawing.Size(39, 19)
        Me.lblrrginc.TabIndex = 31
        Me.lblrrginc.Text = "RG:"
        '
        'lblcpfcnpj
        '
        Me.lblcpfcnpj.AutoSize = True
        Me.lblcpfcnpj.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpfcnpj.ForeColor = System.Drawing.Color.White
        Me.lblcpfcnpj.Location = New System.Drawing.Point(13, 110)
        Me.lblcpfcnpj.Name = "lblcpfcnpj"
        Me.lblcpfcnpj.Size = New System.Drawing.Size(48, 19)
        Me.lblcpfcnpj.TabIndex = 33
        Me.lblcpfcnpj.Text = "CPF:"
        '
        'ChkJur
        '
        Me.ChkJur.AutoSize = True
        Me.ChkJur.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkJur.Location = New System.Drawing.Point(883, 19)
        Me.ChkJur.Name = "ChkJur"
        Me.ChkJur.Size = New System.Drawing.Size(124, 33)
        Me.ChkJur.TabIndex = 35
        Me.ChkJur.Tag = "x"
        Me.ChkJur.Text = "Jurídica"
        Me.ChkJur.UseVisualStyleBackColor = True
        Me.ChkJur.Visible = False
        '
        'BtnSai
        '
        Me.BtnSai.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(1045, 276)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(100, 50)
        Me.BtnSai.TabIndex = 43
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoc.ForeColor = System.Drawing.Color.White
        Me.BtnLoc.Location = New System.Drawing.Point(1045, 108)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(100, 50)
        Me.BtnLoc.TabIndex = 42
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(1045, 164)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(100, 50)
        Me.BtnImp.TabIndex = 41
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(1045, 220)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(100, 50)
        Me.BtnCan.TabIndex = 40
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExc.ForeColor = System.Drawing.Color.White
        Me.BtnExc.Location = New System.Drawing.Point(344, 430)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(100, 50)
        Me.BtnExc.TabIndex = 39
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(238, 430)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(100, 50)
        Me.BtnAlt.TabIndex = 38
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(132, 430)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(100, 50)
        Me.BtnGra.TabIndex = 12
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(26, 430)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(100, 50)
        Me.BtnNov.TabIndex = 37
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(708, 430)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(325, 82)
        Me.GrpLoc.TabIndex = 44
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Tag = "x"
        Me.GrpLoc.Text = "Localizar por Código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Enabled = False
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(257, 29)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(48, 26)
        Me.BtnOk.TabIndex = 1
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'TxtLoc
        '
        Me.TxtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoc.Location = New System.Drawing.Point(14, 29)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(243, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'MskCEP
        '
        Me.MskCEP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskCEP.Location = New System.Drawing.Point(86, 24)
        Me.MskCEP.Mask = "00000-999"
        Me.MskCEP.Name = "MskCEP"
        Me.MskCEP.Size = New System.Drawing.Size(89, 26)
        Me.MskCEP.TabIndex = 5
        '
        'mskcpf
        '
        Me.mskcpf.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskcpf.Location = New System.Drawing.Point(84, 101)
        Me.mskcpf.Mask = "000,000,000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(173, 26)
        Me.mskcpf.TabIndex = 3
        '
        'CBXest
        '
        Me.CBXest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBXest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBXest.FormattingEnabled = True
        Me.CBXest.Items.AddRange(New Object() {"SP", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC ", "SE", "TO"})
        Me.CBXest.Location = New System.Drawing.Point(426, 92)
        Me.CBXest.Name = "CBXest"
        Me.CBXest.Size = New System.Drawing.Size(88, 28)
        Me.CBXest.TabIndex = 11
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(24, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(288, 31)
        Me.LblTitulo.TabIndex = 45
        Me.LblTitulo.Text = "Cadastro de Clientes"
        '
        'GRPEND
        '
        Me.GRPEND.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GRPEND.Controls.Add(Me.Label12)
        Me.GRPEND.Controls.Add(Me.Label1)
        Me.GRPEND.Controls.Add(Me.CBXest)
        Me.GRPEND.Controls.Add(Me.TxtEnd)
        Me.GRPEND.Controls.Add(Me.Label6)
        Me.GRPEND.Controls.Add(Me.MskCEP)
        Me.GRPEND.Controls.Add(Me.TxtNum)
        Me.GRPEND.Controls.Add(Me.Label7)
        Me.GRPEND.Controls.Add(Me.TxtCom)
        Me.GRPEND.Controls.Add(Me.Label8)
        Me.GRPEND.Controls.Add(Me.TxtBai)
        Me.GRPEND.Controls.Add(Me.Label10)
        Me.GRPEND.Controls.Add(Me.TxtCid)
        Me.GRPEND.Controls.Add(Me.Label11)
        Me.GRPEND.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRPEND.ForeColor = System.Drawing.Color.White
        Me.GRPEND.Location = New System.Drawing.Point(26, 262)
        Me.GRPEND.Name = "GRPEND"
        Me.GRPEND.Size = New System.Drawing.Size(1013, 162)
        Me.GRPEND.TabIndex = 46
        Me.GRPEND.TabStop = False
        Me.GRPEND.Text = "Endereço"
        '
        'GRPGERAL
        '
        Me.GRPGERAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.GRPGERAL.Controls.Add(Me.lblcod)
        Me.GRPGERAL.Controls.Add(Me.lblnomeraz)
        Me.GRPGERAL.Controls.Add(Me.Label3)
        Me.GRPGERAL.Controls.Add(Me.mskcpf)
        Me.GRPGERAL.Controls.Add(Me.Label4)
        Me.GRPGERAL.Controls.Add(Me.TxtCod)
        Me.GRPGERAL.Controls.Add(Me.TxtNom)
        Me.GRPGERAL.Controls.Add(Me.TxtEma)
        Me.GRPGERAL.Controls.Add(Me.MskCel)
        Me.GRPGERAL.Controls.Add(Me.lblrrginc)
        Me.GRPGERAL.Controls.Add(Me.TxtRg)
        Me.GRPGERAL.Controls.Add(Me.lblcpfcnpj)
        Me.GRPGERAL.Controls.Add(Me.ChkJur)
        Me.GRPGERAL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRPGERAL.ForeColor = System.Drawing.Color.White
        Me.GRPGERAL.Location = New System.Drawing.Point(26, 96)
        Me.GRPGERAL.Name = "GRPGERAL"
        Me.GRPGERAL.Size = New System.Drawing.Size(1013, 160)
        Me.GRPGERAL.TabIndex = 47
        Me.GRPGERAL.TabStop = False
        Me.GRPGERAL.Text = "Geral"
        '
        'FrmCadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1268, 554)
        Me.Controls.Add(Me.GRPGERAL)
        Me.Controls.Add(Me.GRPEND)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Name = "FrmCadCliente"
        Me.Text = "Cadastro de Clientes"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.GRPEND.ResumeLayout(False)
        Me.GRPEND.PerformLayout()
        Me.GRPGERAL.ResumeLayout(False)
        Me.GRPGERAL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MskCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtEma As System.Windows.Forms.TextBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnomeraz As System.Windows.Forms.Label
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents TxtEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtCom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtBai As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCid As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtRg As System.Windows.Forms.TextBox
    Friend WithEvents lblrrginc As System.Windows.Forms.Label
    Friend WithEvents lblcpfcnpj As System.Windows.Forms.Label
    Friend WithEvents ChkJur As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents MskCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CBXest As System.Windows.Forms.ComboBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GRPEND As System.Windows.Forms.GroupBox
    Friend WithEvents GRPGERAL As System.Windows.Forms.GroupBox

End Class
