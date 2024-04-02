<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadProduto
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
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnExc = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.lblcpfcnpj = New System.Windows.Forms.Label()
        Me.lblrrginc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtqntd = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnomeraz = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.txtfor = New System.Windows.Forms.TextBox()
        Me.mskncm = New System.Windows.Forms.MaskedTextBox()
        Me.txtpre = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtimp = New System.Windows.Forms.TextBox()
        Me.BtnLocForn = New System.Windows.Forms.Button()
        Me.CboTip = New System.Windows.Forms.ComboBox()
        Me.txtcodfor = New System.Windows.Forms.TextBox()
        Me.GRPGERAL = New System.Windows.Forms.GroupBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.GRPGERAL.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(473, 359)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(325, 73)
        Me.GrpLoc.TabIndex = 80
        Me.GrpLoc.TabStop = False
        Me.GrpLoc.Tag = "x"
        Me.GrpLoc.Text = "Localizar por Código ou Nome"
        Me.GrpLoc.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Enabled = False
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
        'BtnSai
        '
        Me.BtnSai.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(730, 303)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(100, 50)
        Me.BtnSai.TabIndex = 79
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoc.ForeColor = System.Drawing.Color.White
        Me.BtnLoc.Location = New System.Drawing.Point(730, 135)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(100, 50)
        Me.BtnLoc.TabIndex = 78
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(730, 191)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(100, 50)
        Me.BtnImp.TabIndex = 77
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(730, 247)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(100, 50)
        Me.BtnCan.TabIndex = 76
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExc.ForeColor = System.Drawing.Color.White
        Me.BtnExc.Location = New System.Drawing.Point(351, 359)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(100, 50)
        Me.BtnExc.TabIndex = 75
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(245, 359)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(100, 50)
        Me.BtnAlt.TabIndex = 74
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(139, 359)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(100, 50)
        Me.BtnGra.TabIndex = 12
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(33, 359)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(100, 50)
        Me.BtnNov.TabIndex = 73
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'lblcpfcnpj
        '
        Me.lblcpfcnpj.AutoSize = True
        Me.lblcpfcnpj.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpfcnpj.ForeColor = System.Drawing.Color.White
        Me.lblcpfcnpj.Location = New System.Drawing.Point(379, 174)
        Me.lblcpfcnpj.Name = "lblcpfcnpj"
        Me.lblcpfcnpj.Size = New System.Drawing.Size(92, 19)
        Me.lblcpfcnpj.TabIndex = 71
        Me.lblcpfcnpj.Text = "Descrição:"
        '
        'lblrrginc
        '
        Me.lblrrginc.AutoSize = True
        Me.lblrrginc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrrginc.ForeColor = System.Drawing.Color.White
        Me.lblrrginc.Location = New System.Drawing.Point(475, 104)
        Me.lblrrginc.Name = "lblrrginc"
        Me.lblrrginc.Size = New System.Drawing.Size(52, 19)
        Me.lblrrginc.TabIndex = 70
        Me.lblrrginc.Text = "NCM:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(36, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 19)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Imposto:"
        '
        'txtqntd
        '
        Me.txtqntd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtqntd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqntd.Location = New System.Drawing.Point(348, 97)
        Me.txtqntd.Name = "txtqntd"
        Me.txtqntd.Size = New System.Drawing.Size(121, 26)
        Me.txtqntd.TabIndex = 5
        Me.txtqntd.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(244, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Qntd. Atual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Tipo:"
        '
        'txtmat
        '
        Me.txtmat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmat.Location = New System.Drawing.Point(348, 134)
        Me.txtmat.Name = "txtmat"
        Me.txtmat.Size = New System.Drawing.Size(307, 26)
        Me.txtmat.TabIndex = 8
        Me.txtmat.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(259, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Materiais:"
        '
        'TxtNom
        '
        Me.TxtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(275, 25)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(380, 26)
        Me.TxtNom.TabIndex = 1
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(119, 25)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(93, 26)
        Me.TxtCod.TabIndex = 0
        Me.TxtCod.Tag = "x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Preço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fornecedor:"
        '
        'lblnomeraz
        '
        Me.lblnomeraz.AutoSize = True
        Me.lblnomeraz.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeraz.ForeColor = System.Drawing.Color.White
        Me.lblnomeraz.Location = New System.Drawing.Point(209, 28)
        Me.lblnomeraz.Name = "lblnomeraz"
        Me.lblnomeraz.Size = New System.Drawing.Size(60, 19)
        Me.lblnomeraz.TabIndex = 55
        Me.lblnomeraz.Text = "Nome:"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.ForeColor = System.Drawing.Color.White
        Me.lblcod.Location = New System.Drawing.Point(48, 28)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(65, 19)
        Me.lblcod.TabIndex = 51
        Me.lblcod.Text = "Código"
        '
        'txtfor
        '
        Me.txtfor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfor.Location = New System.Drawing.Point(275, 61)
        Me.txtfor.Name = "txtfor"
        Me.txtfor.Size = New System.Drawing.Size(229, 26)
        Me.txtfor.TabIndex = 2
        Me.txtfor.Tag = "x"
        '
        'mskncm
        '
        Me.mskncm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskncm.Location = New System.Drawing.Point(533, 101)
        Me.mskncm.Mask = "00000000"
        Me.mskncm.Name = "mskncm"
        Me.mskncm.Size = New System.Drawing.Size(83, 26)
        Me.mskncm.TabIndex = 6
        '
        'txtpre
        '
        Me.txtpre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpre.Location = New System.Drawing.Point(118, 93)
        Me.txtpre.Name = "txtpre"
        Me.txtpre.Size = New System.Drawing.Size(121, 26)
        Me.txtpre.TabIndex = 4
        '
        'txtdesc
        '
        Me.txtdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(477, 171)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(178, 26)
        Me.txtdesc.TabIndex = 11
        '
        'txtimp
        '
        Me.txtimp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtimp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimp.Location = New System.Drawing.Point(118, 130)
        Me.txtimp.Name = "txtimp"
        Me.txtimp.Size = New System.Drawing.Size(121, 26)
        Me.txtimp.TabIndex = 7
        '
        'BtnLocForn
        '
        Me.BtnLocForn.Enabled = False
        Me.BtnLocForn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLocForn.Location = New System.Drawing.Point(223, 61)
        Me.BtnLocForn.Name = "BtnLocForn"
        Me.BtnLocForn.Size = New System.Drawing.Size(41, 26)
        Me.BtnLocForn.TabIndex = 3
        Me.BtnLocForn.Tag = ""
        Me.BtnLocForn.Text = "..."
        Me.BtnLocForn.UseVisualStyleBackColor = True
        '
        'CboTip
        '
        Me.CboTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTip.FormattingEnabled = True
        Me.CboTip.Location = New System.Drawing.Point(118, 165)
        Me.CboTip.Margin = New System.Windows.Forms.Padding(2)
        Me.CboTip.Name = "CboTip"
        Me.CboTip.Size = New System.Drawing.Size(256, 28)
        Me.CboTip.TabIndex = 81
        '
        'txtcodfor
        '
        Me.txtcodfor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodfor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodfor.Location = New System.Drawing.Point(119, 62)
        Me.txtcodfor.Name = "txtcodfor"
        Me.txtcodfor.Size = New System.Drawing.Size(98, 26)
        Me.txtcodfor.TabIndex = 82
        Me.txtcodfor.Tag = "x"
        '
        'GRPGERAL
        '
        Me.GRPGERAL.Controls.Add(Me.lblcod)
        Me.GRPGERAL.Controls.Add(Me.txtcodfor)
        Me.GRPGERAL.Controls.Add(Me.lblnomeraz)
        Me.GRPGERAL.Controls.Add(Me.CboTip)
        Me.GRPGERAL.Controls.Add(Me.Label3)
        Me.GRPGERAL.Controls.Add(Me.BtnLocForn)
        Me.GRPGERAL.Controls.Add(Me.Label4)
        Me.GRPGERAL.Controls.Add(Me.txtimp)
        Me.GRPGERAL.Controls.Add(Me.TxtCod)
        Me.GRPGERAL.Controls.Add(Me.txtdesc)
        Me.GRPGERAL.Controls.Add(Me.TxtNom)
        Me.GRPGERAL.Controls.Add(Me.txtpre)
        Me.GRPGERAL.Controls.Add(Me.Label1)
        Me.GRPGERAL.Controls.Add(Me.mskncm)
        Me.GRPGERAL.Controls.Add(Me.txtmat)
        Me.GRPGERAL.Controls.Add(Me.txtfor)
        Me.GRPGERAL.Controls.Add(Me.Label6)
        Me.GRPGERAL.Controls.Add(Me.Label7)
        Me.GRPGERAL.Controls.Add(Me.txtqntd)
        Me.GRPGERAL.Controls.Add(Me.Label12)
        Me.GRPGERAL.Controls.Add(Me.lblrrginc)
        Me.GRPGERAL.Controls.Add(Me.lblcpfcnpj)
        Me.GRPGERAL.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GRPGERAL.ForeColor = System.Drawing.Color.White
        Me.GRPGERAL.Location = New System.Drawing.Point(25, 123)
        Me.GRPGERAL.Name = "GRPGERAL"
        Me.GRPGERAL.Size = New System.Drawing.Size(699, 230)
        Me.GRPGERAL.TabIndex = 83
        Me.GRPGERAL.TabStop = False
        Me.GRPGERAL.Text = "Geral"
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(19, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(298, 31)
        Me.LblTitulo.TabIndex = 84
        Me.LblTitulo.Text = "Cadastro de Produtos"
        '
        'FrmCadProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 480)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.GRPGERAL)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Name = "FrmCadProduto"
        Me.Text = "Cadastro de Produtos"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.GRPGERAL.ResumeLayout(False)
        Me.GRPGERAL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnExc As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents lblcpfcnpj As System.Windows.Forms.Label
    Friend WithEvents lblrrginc As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtqntd As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtmat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnomeraz As System.Windows.Forms.Label
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents txtfor As System.Windows.Forms.TextBox
    Friend WithEvents mskncm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtpre As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtimp As System.Windows.Forms.TextBox
    Friend WithEvents BtnLocForn As System.Windows.Forms.Button
    Friend WithEvents CboTip As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodfor As System.Windows.Forms.TextBox
    Friend WithEvents GRPGERAL As System.Windows.Forms.GroupBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
End Class
