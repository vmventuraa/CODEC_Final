<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConVendaCodigo
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
        Me.Txtcampo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'Txtcampo
        '
        Me.Txtcampo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcampo.Location = New System.Drawing.Point(423, 81)
        Me.Txtcampo.Name = "Txtcampo"
        Me.Txtcampo.Size = New System.Drawing.Size(248, 26)
        Me.Txtcampo.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(176, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 25)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Código do Empéstimo"
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
        Me.DgdGrade.Location = New System.Drawing.Point(109, 124)
        Me.DgdGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.DgdGrade.Name = "DgdGrade"
        Me.DgdGrade.RowTemplate.Height = 24
        Me.DgdGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgdGrade.Size = New System.Drawing.Size(973, 414)
        Me.DgdGrade.TabIndex = 94
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "codven"
        Me.Column1.HeaderText = "Código da Venda"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 105
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
        'FrmConVendaCodigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1268, 629)
        Me.Controls.Add(Me.DgdGrade)
        Me.Controls.Add(Me.Txtcampo)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmConVendaCodigo"
        Me.Text = "Consulta de Empréstimos"
        CType(Me.DgdGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtcampo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgdGrade As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
