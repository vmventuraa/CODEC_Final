<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscolhaFornecedorConsultas
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
        Me.BtnConCod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConCod
        '
        Me.BtnConCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnConCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BtnConCod.ForeColor = System.Drawing.Color.White
        Me.BtnConCod.Location = New System.Drawing.Point(27, 38)
        Me.BtnConCod.Name = "BtnConCod"
        Me.BtnConCod.Size = New System.Drawing.Size(376, 82)
        Me.BtnConCod.TabIndex = 2
        Me.BtnConCod.Text = "Consultar Fornecedor por Código/Nome"
        Me.BtnConCod.UseVisualStyleBackColor = False
        '
        'EscolhaFornecedorConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 186)
        Me.Controls.Add(Me.BtnConCod)
        Me.Name = "EscolhaFornecedorConsultas"
        Me.Text = "Consultas de Fornecedor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConCod As System.Windows.Forms.Button
End Class
