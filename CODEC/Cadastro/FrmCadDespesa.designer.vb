<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadDespesa
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
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.lblcod = New System.Windows.Forms.Label()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.GrpLoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(201, 81)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(63, 26)
        Me.TxtCod.TabIndex = 6
        Me.TxtCod.Tag = "x"
        '
        'lblcod
        '
        Me.lblcod.AutoSize = True
        Me.lblcod.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcod.ForeColor = System.Drawing.Color.White
        Me.lblcod.Location = New System.Drawing.Point(124, 84)
        Me.lblcod.Name = "lblcod"
        Me.lblcod.Size = New System.Drawing.Size(71, 19)
        Me.lblcod.TabIndex = 7
        Me.lblcod.Text = "Código:"
        '
        'Txtnom
        '
        Me.Txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtnom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnom.Location = New System.Drawing.Point(201, 134)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(225, 26)
        Me.Txtnom.TabIndex = 22
        Me.Txtnom.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Nome da despesa:"
        '
        'GrpLoc
        '
        Me.GrpLoc.Controls.Add(Me.BtnOk)
        Me.GrpLoc.Controls.Add(Me.TxtLoc)
        Me.GrpLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLoc.ForeColor = System.Drawing.Color.White
        Me.GrpLoc.Location = New System.Drawing.Point(524, 274)
        Me.GrpLoc.Name = "GrpLoc"
        Me.GrpLoc.Size = New System.Drawing.Size(325, 73)
        Me.GrpLoc.TabIndex = 45
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
        Me.BtnSai.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSai.ForeColor = System.Drawing.Color.White
        Me.BtnSai.Location = New System.Drawing.Point(749, 190)
        Me.BtnSai.Name = "BtnSai"
        Me.BtnSai.Size = New System.Drawing.Size(100, 50)
        Me.BtnSai.TabIndex = 87
        Me.BtnSai.Text = "&Sair"
        Me.BtnSai.UseVisualStyleBackColor = False
        '
        'BtnLoc
        '
        Me.BtnLoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnLoc.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoc.ForeColor = System.Drawing.Color.White
        Me.BtnLoc.Location = New System.Drawing.Point(749, 22)
        Me.BtnLoc.Name = "BtnLoc"
        Me.BtnLoc.Size = New System.Drawing.Size(100, 50)
        Me.BtnLoc.TabIndex = 86
        Me.BtnLoc.Text = "&Localizar"
        Me.BtnLoc.UseVisualStyleBackColor = False
        '
        'BtnImp
        '
        Me.BtnImp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnImp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImp.ForeColor = System.Drawing.Color.White
        Me.BtnImp.Location = New System.Drawing.Point(749, 78)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(100, 50)
        Me.BtnImp.TabIndex = 85
        Me.BtnImp.Text = "&Imprimir"
        Me.BtnImp.UseVisualStyleBackColor = False
        '
        'BtnCan
        '
        Me.BtnCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnCan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCan.ForeColor = System.Drawing.Color.White
        Me.BtnCan.Location = New System.Drawing.Point(749, 134)
        Me.BtnCan.Name = "BtnCan"
        Me.BtnCan.Size = New System.Drawing.Size(100, 50)
        Me.BtnCan.TabIndex = 84
        Me.BtnCan.Text = "&Cancelar"
        Me.BtnCan.UseVisualStyleBackColor = False
        '
        'BtnExc
        '
        Me.BtnExc.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnExc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnExc.ForeColor = System.Drawing.Color.White
        Me.BtnExc.Location = New System.Drawing.Point(367, 190)
        Me.BtnExc.Name = "BtnExc"
        Me.BtnExc.Size = New System.Drawing.Size(100, 50)
        Me.BtnExc.TabIndex = 83
        Me.BtnExc.Text = "&Excluir"
        Me.BtnExc.UseVisualStyleBackColor = False
        '
        'BtnAlt
        '
        Me.BtnAlt.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAlt.ForeColor = System.Drawing.Color.White
        Me.BtnAlt.Location = New System.Drawing.Point(261, 190)
        Me.BtnAlt.Name = "BtnAlt"
        Me.BtnAlt.Size = New System.Drawing.Size(100, 50)
        Me.BtnAlt.TabIndex = 82
        Me.BtnAlt.Text = "&Alterar"
        Me.BtnAlt.UseVisualStyleBackColor = False
        '
        'BtnGra
        '
        Me.BtnGra.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnGra.ForeColor = System.Drawing.Color.White
        Me.BtnGra.Location = New System.Drawing.Point(155, 190)
        Me.BtnGra.Name = "BtnGra"
        Me.BtnGra.Size = New System.Drawing.Size(100, 50)
        Me.BtnGra.TabIndex = 80
        Me.BtnGra.Text = "&Gravar"
        Me.BtnGra.UseVisualStyleBackColor = False
        '
        'BtnNov
        '
        Me.BtnNov.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnNov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNov.ForeColor = System.Drawing.Color.White
        Me.BtnNov.Location = New System.Drawing.Point(47, 190)
        Me.BtnNov.Name = "BtnNov"
        Me.BtnNov.Size = New System.Drawing.Size(100, 50)
        Me.BtnNov.TabIndex = 81
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
        Me.LblTitulo.Size = New System.Drawing.Size(311, 31)
        Me.LblTitulo.TabIndex = 88
        Me.LblTitulo.Text = "Cadastro de Despesas"
        '
        'FrmCadDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 363)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSai)
        Me.Controls.Add(Me.BtnLoc)
        Me.Controls.Add(Me.BtnImp)
        Me.Controls.Add(Me.BtnCan)
        Me.Controls.Add(Me.BtnExc)
        Me.Controls.Add(Me.BtnAlt)
        Me.Controls.Add(Me.BtnGra)
        Me.Controls.Add(Me.BtnNov)
        Me.Controls.Add(Me.GrpLoc)
        Me.Controls.Add(Me.Txtnom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCod)
        Me.Controls.Add(Me.lblcod)
        Me.Name = "FrmCadDespesa"
        Me.Text = "Cadastro de Despesas"
        Me.GrpLoc.ResumeLayout(False)
        Me.GrpLoc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents lblcod As System.Windows.Forms.Label
    Friend WithEvents Txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
End Class
