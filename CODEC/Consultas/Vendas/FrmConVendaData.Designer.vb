<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVendaData
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
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkini = New System.Windows.Forms.CheckBox()
        Me.chkfinal = New System.Windows.Forms.CheckBox()
        Me.lblfechado = New System.Windows.Forms.Label()
        Me.txtfechado = New System.Windows.Forms.TextBox()
        Me.txtaberto = New System.Windows.Forms.TextBox()
        Me.lblaberto = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(78, 127)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(687, 339)
        Me.DgdGrade.TabIndex = 56
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(508, 32)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(41, 31)
        Me.BtnOk.TabIndex = 88
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(380, 34)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(105, 26)
        Me.DtpFim.TabIndex = 87
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(153, 35)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(105, 26)
        Me.DtpIni.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(277, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Data Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Data Inicial:"
        '
        'chkini
        '
        Me.chkini.AutoSize = True
        Me.chkini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkini.ForeColor = System.Drawing.Color.White
        Me.chkini.Location = New System.Drawing.Point(78, 72)
        Me.chkini.Name = "chkini"
        Me.chkini.Size = New System.Drawing.Size(218, 24)
        Me.chkini.TabIndex = 89
        Me.chkini.Text = "Empréstimos em aberto"
        Me.chkini.UseVisualStyleBackColor = True
        '
        'chkfinal
        '
        Me.chkfinal.AutoSize = True
        Me.chkfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkfinal.ForeColor = System.Drawing.Color.White
        Me.chkfinal.Location = New System.Drawing.Point(78, 98)
        Me.chkfinal.Name = "chkfinal"
        Me.chkfinal.Size = New System.Drawing.Size(211, 24)
        Me.chkfinal.TabIndex = 90
        Me.chkfinal.Text = "Empréstimos fechados"
        Me.chkfinal.UseVisualStyleBackColor = True
        '
        'lblfechado
        '
        Me.lblfechado.AutoSize = True
        Me.lblfechado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechado.ForeColor = System.Drawing.Color.White
        Me.lblfechado.Location = New System.Drawing.Point(75, 483)
        Me.lblfechado.Name = "lblfechado"
        Me.lblfechado.Size = New System.Drawing.Size(264, 18)
        Me.lblfechado.TabIndex = 91
        Me.lblfechado.Text = "Total de Empréstimos já vendidos"
        Me.lblfechado.Visible = False
        '
        'txtfechado
        '
        Me.txtfechado.Enabled = False
        Me.txtfechado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfechado.Location = New System.Drawing.Point(393, 483)
        Me.txtfechado.Name = "txtfechado"
        Me.txtfechado.Size = New System.Drawing.Size(100, 24)
        Me.txtfechado.TabIndex = 92
        Me.txtfechado.Visible = False
        '
        'txtaberto
        '
        Me.txtaberto.Enabled = False
        Me.txtaberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaberto.Location = New System.Drawing.Point(393, 525)
        Me.txtaberto.Name = "txtaberto"
        Me.txtaberto.Size = New System.Drawing.Size(100, 24)
        Me.txtaberto.TabIndex = 94
        Me.txtaberto.Visible = False
        '
        'lblaberto
        '
        Me.lblaberto.AutoSize = True
        Me.lblaberto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaberto.ForeColor = System.Drawing.Color.White
        Me.lblaberto.Location = New System.Drawing.Point(75, 528)
        Me.lblaberto.Name = "lblaberto"
        Me.lblaberto.Size = New System.Drawing.Size(255, 18)
        Me.lblaberto.TabIndex = 93
        Me.lblaberto.Text = "Total de Empréstimos em aberto"
        Me.lblaberto.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(737, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 46)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Gráfico"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codven"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "cliven"
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
        Me.Column3.DataPropertyName = "datven"
        Me.Column3.HeaderText = "Data"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 55
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "totven"
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 56
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "finalven"
        Me.Column5.HeaderText = "Venda Fechada"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 99
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "comven"
        Me.Column7.HeaderText = "Data de Devolução"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 114
        '
        'FrmConVendaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 615)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtaberto)
        Me.Controls.Add(Me.lblaberto)
        Me.Controls.Add(Me.txtfechado)
        Me.Controls.Add(Me.lblfechado)
        Me.Controls.Add(Me.chkfinal)
        Me.Controls.Add(Me.chkini)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgdGrade)
        Me.Name = "FrmConVendaData"
        Me.Text = "Consulta de Venda Inicial por Período e Tipo"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkini As System.Windows.Forms.CheckBox
    Friend WithEvents chkfinal As System.Windows.Forms.CheckBox
    Friend WithEvents lblfechado As System.Windows.Forms.Label
    Friend WithEvents txtfechado As System.Windows.Forms.TextBox
    Friend WithEvents txtaberto As System.Windows.Forms.TextBox
    Friend WithEvents lblaberto As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
