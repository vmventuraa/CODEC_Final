<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadPagamento
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
        Me.txtnompag = New System.Windows.Forms.TextBox()
        Me.txtcodpag = New System.Windows.Forms.TextBox()
        Me.lblcodpag = New System.Windows.Forms.Label()
        Me.lblforma = New System.Windows.Forms.Label()
        Me.GrpLoc = New System.Windows.Forms.GroupBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.BtnSai = New System.Windows.Forms.Button()
        Me.BtnLoc = New System.Windows.Forms.Button()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnCan = New System.Windows.Forms.Button()
        Me.BtnAlt = New System.Windows.Forms.Button()
        Me.BtnGra = New System.Windows.Forms.Button()
        Me.BtnNov = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnompag
        '
        Me.txtnompag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnompag.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnompag.Location = New System.Drawing.Point(283, 145)
        Me.txtnompag.Name = "txtnompag"
        Me.txtnompag.Size = New System.Drawing.Size(154, 26)
        Me.txtnompag.TabIndex = 0
        '
        'txtcodpag
        '
        Me.txtcodpag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodpag.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodpag.Location = New System.Drawing.Point(283, 109)
        Me.txtcodpag.Name = "txtcodpag"
        Me.txtcodpag.Size = New System.Drawing.Size(154, 26)
        Me.txtcodpag.TabIndex = 1
        Me.txtcodpag.Tag = "x"
        '
        'lblcodpag
        '
        Me.lblcodpag.AutoSize = True
        Me.lblcodpag.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblcodpag.ForeColor = System.Drawing.Color.White
        Me.lblcodpag.Location = New System.Drawing.Point(12, 109)
        Me.lblcodpag.Name = "lblcodpag"
        Me.lblcodpag.Size = New System.Drawing.Size(265, 19)
        Me.lblcodpag.TabIndex = 2
        Me.lblcodpag.Text = "Codigo da Forma de Pagamento :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblforma
        '
        Me.lblforma.AutoSize = True
        Me.lblforma.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblforma.ForeColor = System.Drawing.Color.White
        Me.lblforma.Location = New System.Drawing.Point(12, 144)
        Me.lblforma.Name = "lblforma"
        Me.lblforma.Size = New System.Drawing.Size(254, 19)
        Me.lblforma.TabIndex = 3
        Me.lblforma.Text = "Nome da Forma de Pagamento :"
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(454, 252)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(310, 63)
        Me.GrpLoc.TabIndex = 57
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
        Me.BtnSai.Location = New System.Drawing.Point(676, 190)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(100, 50)
        Me.BtnSai.TabIndex = 95
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLoc.ForeColor = System.Drawing.Color.White
        Me.BtnLoc.Location = New System.Drawing.Point(676, 22)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(100, 50)
        Me.BtnLoc.TabIndex = 94
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(676, 78)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(100, 50)
        Me.BtnImp.TabIndex = 93
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(676, 134)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(100, 50)
        Me.BtnCan.TabIndex = 92
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(224, 265)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(100, 50)
        Me.BtnAlt.TabIndex = 90
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(118, 265)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(100, 50)
        Me.BtnGra.TabIndex = 88
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(12, 265)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(100, 50)
        Me.BtnNov.TabIndex = 89
        Me.BtnNov.Text = "&Novo"
        Me.BtnNov.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(459, 31)
        Me.LblTitulo.TabIndex = 96
        Me.LblTitulo.Text = "Cadastro de Forma de Pagamento"
        '
        'FrmCadPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(788, 327)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.lblforma)
        Me.Controls.Add(Me.lblcodpag)
        Me.Controls.Add(Me.txtcodpag)
        Me.Controls.Add(Me.txtnompag)
        Me.Name = "FrmCadPagamento"
        Me.Text = "Cadastro de Formas de Pagamento"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnompag As System.Windows.Forms.TextBox
    Friend WithEvents txtcodpag As System.Windows.Forms.TextBox
    Friend WithEvents lblcodpag As System.Windows.Forms.Label
    Friend WithEvents lblforma As System.Windows.Forms.Label
    Friend WithEvents GrpLoc As System.Windows.Forms.GroupBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents TxtLoc As System.Windows.Forms.TextBox
    Friend WithEvents BtnSai As System.Windows.Forms.Button
    Friend WithEvents BtnLoc As System.Windows.Forms.Button
    Friend WithEvents BtnImp As System.Windows.Forms.Button
    Friend WithEvents BtnCan As System.Windows.Forms.Button
    Friend WithEvents BtnAlt As System.Windows.Forms.Button
    Friend WithEvents BtnGra As System.Windows.Forms.Button
    Friend WithEvents BtnNov As System.Windows.Forms.Button
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
End Class
