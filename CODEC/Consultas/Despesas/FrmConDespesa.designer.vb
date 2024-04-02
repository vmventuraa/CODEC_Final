<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConDespesa
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
        Me.Dgdgrade = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProFim = New System.Windows.Forms.TextBox()
        Me.txtx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProIni = New System.Windows.Forms.TextBox()
        Me.TxtNcl = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lbltot = New System.Windows.Forms.Label()
        CType(Me.Dgdgrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgdgrade
        '
        Me.Dgdgrade.AllowUserToAddRows = False
        Me.Dgdgrade.AllowUserToDeleteRows = False
        Me.Dgdgrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Dgdgrade.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Dgdgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgdgrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.Dgdgrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgdgrade.Location = New System.Drawing.Point(11, 132)
        Me.Dgdgrade.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgdgrade.Name = "Dgdgrade"
        Me.Dgdgrade.RowTemplate.Height = 24
        Me.Dgdgrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgdgrade.Size = New System.Drawing.Size(873, 226)
        Me.Dgdgrade.TabIndex = 77
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codlan"
        Me.Column1.HeaderText = "Código do Lançamento "
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 132
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "deslan"
        Me.Column2.HeaderText = "Número da Despesa"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 118
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "nomdes"
        Me.Column7.HeaderText = "Nome da Despesa"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 110
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "datlan"
        Me.Column3.HeaderText = "Data da Despesa"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 105
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "desclan"
        Me.Column4.HeaderText = "Descricçao da Despesa"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 96
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "vallan"
        Me.Column5.HeaderText = "Valor da Despesa"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 106
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "paglan"
        Me.Column6.HeaderText = "Forma de Pagamento"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 122
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(496, 8)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(41, 31)
        Me.BtnOk.TabIndex = 76
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(368, 10)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(122, 26)
        Me.DtpFim.TabIndex = 75
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(141, 11)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(117, 26)
        Me.DtpIni.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Data Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(28, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Data Inicial:"
        '
        'txtProFim
        '
        Me.txtProFim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProFim.Location = New System.Drawing.Point(200, 77)
        Me.txtProFim.Name = "txtProFim"
        Me.txtProFim.Size = New System.Drawing.Size(62, 26)
        Me.txtProFim.TabIndex = 83
        '
        'txtx
        '
        Me.txtx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtx.Location = New System.Drawing.Point(268, 77)
        Me.txtx.Name = "txtx"
        Me.txtx.Size = New System.Drawing.Size(312, 26)
        Me.txtx.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Código da Despesa"
        '
        'TxtProIni
        '
        Me.TxtProIni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProIni.Location = New System.Drawing.Point(200, 45)
        Me.TxtProIni.Name = "TxtProIni"
        Me.TxtProIni.Size = New System.Drawing.Size(62, 26)
        Me.TxtProIni.TabIndex = 80
        '
        'TxtNcl
        '
        Me.TxtNcl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNcl.Location = New System.Drawing.Point(268, 45)
        Me.TxtNcl.Name = "TxtNcl"
        Me.TxtNcl.Size = New System.Drawing.Size(312, 26)
        Me.TxtNcl.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Código da Despesa"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(201, 385)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(100, 24)
        Me.txttotal.TabIndex = 94
        Me.txttotal.Visible = False
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbltot.ForeColor = System.Drawing.Color.White
        Me.lbltot.Location = New System.Drawing.Point(29, 389)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(166, 20)
        Me.lbltot.TabIndex = 93
        Me.lbltot.Text = "Custo de Despesas"
        Me.lbltot.Visible = False
        '
        'FrmConDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(911, 444)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.txtProFim)
        Me.Controls.Add(Me.txtx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtProIni)
        Me.Controls.Add(Me.TxtNcl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgdgrade)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmConDespesa"
        Me.Text = "Consulta de Despesas por Período"
        CType(Me.Dgdgrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgdgrade As System.Windows.Forms.DataGridView
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProFim As System.Windows.Forms.TextBox
    Friend WithEvents txtx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtProIni As System.Windows.Forms.TextBox
    Friend WithEvents TxtNcl As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents lbltot As System.Windows.Forms.Label
End Class
