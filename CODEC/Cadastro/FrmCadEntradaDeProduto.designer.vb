<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadEntradaDeProduto
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
        Me.TxtQnt = New System.Windows.Forms.TextBox()
        Me.TxtCodPro = New System.Windows.Forms.TextBox()
        Me.TxtCodEnt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnomeraz = New System.Windows.Forms.Label()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.TxtPrec = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.DtpEnt = New System.Windows.Forms.DateTimePicker()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(524, 305)
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
        Me.TxtLoc.Location = New System.Drawing.Point(8, 29)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(243, 26)
        Me.TxtLoc.TabIndex = 0
        '
        'BtnSai
        '
        Me.BtnSai.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnSai.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(688, 198)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(100, 50)
        Me.BtnSai.TabIndex = 79
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.ForeColor = System.Drawing.Color.White
        Me.BtnLoc.Location = New System.Drawing.Point(688, 30)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(100, 50)
        Me.BtnLoc.TabIndex = 78
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(688, 86)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(100, 50)
        Me.BtnImp.TabIndex = 77
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(688, 142)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(100, 50)
        Me.BtnCan.TabIndex = 76
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnExc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExc.ForeColor = System.Drawing.Color.White
        Me.BtnExc.Location = New System.Drawing.Point(351, 305)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(100, 50)
        Me.BtnExc.TabIndex = 75
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnAlt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(245, 305)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(100, 50)
        Me.BtnAlt.TabIndex = 74
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(139, 305)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(100, 50)
        Me.BtnGra.TabIndex = 62
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(33, 305)
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
        Me.lblcpfcnpj.Location = New System.Drawing.Point(39, 198)
        Me.lblcpfcnpj.Name = "lblcpfcnpj"
        Me.lblcpfcnpj.Size = New System.Drawing.Size(50, 19)
        Me.lblcpfcnpj.TabIndex = 71
        Me.lblcpfcnpj.Text = "Data:"
        '
        'TxtQnt
        '
        Me.TxtQnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtQnt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtQnt.Location = New System.Drawing.Point(389, 163)
        Me.TxtQnt.Name = "TxtQnt"
        Me.TxtQnt.Size = New System.Drawing.Size(165, 26)
        Me.TxtQnt.TabIndex = 48
        Me.TxtQnt.Tag = ""
        '
        'TxtCodPro
        '
        Me.TxtCodPro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodPro.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodPro.Location = New System.Drawing.Point(196, 128)
        Me.TxtCodPro.Name = "TxtCodPro"
        Me.TxtCodPro.Size = New System.Drawing.Size(101, 26)
        Me.TxtCodPro.TabIndex = 45
        '
        'TxtCodEnt
        '
        Me.TxtCodEnt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodEnt.Location = New System.Drawing.Point(193, 57)
        Me.TxtCodEnt.Name = "TxtCodEnt"
        Me.TxtCodEnt.Size = New System.Drawing.Size(63, 26)
        Me.TxtCodEnt.TabIndex = 47
        Me.TxtCodEnt.Tag = "x"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(196, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 19)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Quantidade Comprada:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Preço:"
        '
        'lblnomeraz
        '
        Me.lblnomeraz.AutoSize = True
        Me.lblnomeraz.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomeraz.ForeColor = System.Drawing.Color.White
        Me.lblnomeraz.Location = New System.Drawing.Point(29, 132)
        Me.lblnomeraz.Name = "lblnomeraz"
        Me.lblnomeraz.Size = New System.Drawing.Size(161, 19)
        Me.lblnomeraz.TabIndex = 55
        Me.lblnomeraz.Text = "Código do Produto:"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.ForeColor = System.Drawing.Color.White
        Me.lblcod.Location = New System.Drawing.Point(29, 61)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(158, 19)
        Me.lblcod.TabIndex = 51
        Me.lblcod.Text = "Código da Entrada:"
        '
        'TxtPrec
        '
        Me.TxtPrec.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrec.Location = New System.Drawing.Point(90, 160)
        Me.TxtPrec.Name = "TxtPrec"
        Me.TxtPrec.Size = New System.Drawing.Size(100, 26)
        Me.TxtPrec.TabIndex = 81
        '
        'TxtNom
        '
        Me.TxtNom.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNom.Location = New System.Drawing.Point(303, 129)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(251, 26)
        Me.TxtNom.TabIndex = 83
        '
        'DtpEnt
        '
        Me.DtpEnt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpEnt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEnt.Location = New System.Drawing.Point(90, 192)
        Me.DtpEnt.Name = "DtpEnt"
        Me.DtpEnt.Size = New System.Drawing.Size(122, 26)
        Me.DtpEnt.TabIndex = 84
        '
        'FrmCadEntradaDeProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(879, 453)
        Me.Controls.Add(Me.DtpEnt)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtPrec)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.lblcpfcnpj)
        Me.Controls.Add(Me.TxtQnt)
        Me.Controls.Add(Me.TxtCodPro)
        Me.Controls.Add(Me.TxtCodEnt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnomeraz)
        Me.Controls.Add(Me.lblcod)
        Me.Name = "FrmCadEntradaDeProduto"
        Me.Text = "Entrada de Produtos"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
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
    Friend WithEvents TxtQnt As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodPro As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodEnt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnomeraz As System.Windows.Forms.Label
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents TxtPrec As System.Windows.Forms.TextBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents DtpEnt As System.Windows.Forms.DateTimePicker
End Class
