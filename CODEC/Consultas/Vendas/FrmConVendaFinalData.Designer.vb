﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVendaFinalData
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
        Me.txttot = New System.Windows.Forms.TextBox()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.txtqntd = New System.Windows.Forms.TextBox()
        Me.lblqntd = New System.Windows.Forms.Label()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.DtpFim = New System.Windows.Forms.DateTimePicker()
        Me.DtpIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgdGrade = New System.Windows.Forms.DataGridView()
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
        'txttot
        '
        Me.txttot.Enabled = False
        Me.txttot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttot.Location = New System.Drawing.Point(360, 535)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(100, 24)
        Me.txttot.TabIndex = 106
        Me.txttot.Visible = False
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.ForeColor = System.Drawing.Color.White
        Me.lbltot.Location = New System.Drawing.Point(303, 538)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(51, 18)
        Me.lbltot.TabIndex = 105
        Me.lbltot.Text = "Total:"
        Me.lbltot.Visible = False
        '
        'txtqntd
        '
        Me.txtqntd.Enabled = False
        Me.txtqntd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqntd.Location = New System.Drawing.Point(360, 496)
        Me.txtqntd.Name = "txtqntd"
        Me.txtqntd.Size = New System.Drawing.Size(100, 24)
        Me.txtqntd.TabIndex = 104
        Me.txtqntd.Visible = False
        '
        'lblqntd
        '
        Me.lblqntd.AutoSize = True
        Me.lblqntd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqntd.ForeColor = System.Drawing.Color.White
        Me.lblqntd.Location = New System.Drawing.Point(173, 496)
        Me.lblqntd.Name = "lblqntd"
        Me.lblqntd.Size = New System.Drawing.Size(181, 18)
        Me.lblqntd.TabIndex = 103
        Me.lblqntd.Text = "Quantidade de Vendas:"
        Me.lblqntd.Visible = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOk.ForeColor = System.Drawing.Color.White
        Me.BtnOk.Location = New System.Drawing.Point(606, 45)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(41, 31)
        Me.BtnOk.TabIndex = 100
        Me.BtnOk.Text = "&Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'DtpFim
        '
        Me.DtpFim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFim.Location = New System.Drawing.Point(489, 47)
        Me.DtpFim.Name = "DtpFim"
        Me.DtpFim.Size = New System.Drawing.Size(105, 26)
        Me.DtpFim.TabIndex = 99
        '
        'DtpIni
        '
        Me.DtpIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpIni.Location = New System.Drawing.Point(249, 48)
        Me.DtpIni.Name = "DtpIni"
        Me.DtpIni.Size = New System.Drawing.Size(105, 26)
        Me.DtpIni.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(386, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Data Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(138, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Data Inicial:"
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
        Me.DgdGrade.Location = New System.Drawing.Point(142, 136)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(687, 339)
        Me.DgdGrade.TabIndex = 95
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
        'FrmConVendaFinalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 606)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.txtqntd)
        Me.Controls.Add(Me.lblqntd)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.DtpFim)
        Me.Controls.Add(Me.DtpIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgdGrade)
        Me.Name = "FrmConVendaFinalData"
        Me.Text = "Consulta de Venda Final por Período"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents txtqntd As System.Windows.Forms.TextBox
    Friend WithEvents lblqntd As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
