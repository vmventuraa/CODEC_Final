<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConCliente
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
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtCampo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.DgdGrade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.DgdGrade.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgdGrade.Location = New System.Drawing.Point(37, 80)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(1081, 263)
        Me.DgdGrade.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codcli"
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 65
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nomcli"
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "telcli"
        Me.Column3.HeaderText = "Telefone"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 74
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "emacli"
        Me.Column4.HeaderText = "E-mail"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "endcli"
        Me.Column5.HeaderText = "Endereço"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 78
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "numcli"
        Me.Column6.HeaderText = "Número"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 69
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "compcli"
        Me.Column7.HeaderText = "Complemento"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 96
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "baicli"
        Me.Column8.HeaderText = "Bairro"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 59
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "cidcli"
        Me.Column9.HeaderText = "Cidade"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 65
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "estcli"
        Me.Column10.HeaderText = "Estado"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 65
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "cepcli"
        Me.Column11.HeaderText = "CEP"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 53
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "irgcli"
        Me.Column12.HeaderText = "Insc.Estadual/RG"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 117
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "cnpjcpfcli"
        Me.Column13.HeaderText = "CPF/CNPJ"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 84
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "pescli"
        Me.Column14.HeaderText = "Jurídica"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 70
        '
        'TxtCampo
        '
        Me.TxtCampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCampo.Location = New System.Drawing.Point(382, 39)
        Me.TxtCampo.Name = "TxtCampo"
        Me.TxtCampo.Size = New System.Drawing.Size(367, 26)
        Me.TxtCampo.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 31)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Digite o Nome ou Código"
        '
        'FrmConCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1190, 401)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.TxtCampo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmConCliente"
        Me.Text = "Consula de Cliente por Código/Nome"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCampo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
