<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscolhaClienteConsultas
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConCod
        '
        Me.BtnConCod.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnConCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BtnConCod.ForeColor = System.Drawing.Color.White
        Me.BtnConCod.Location = New System.Drawing.Point(37, 37)
        Me.BtnConCod.Name = "BtnConCod"
        Me.BtnConCod.Size = New System.Drawing.Size(376, 82)
        Me.BtnConCod.TabIndex = 0
        Me.BtnConCod.Text = "Consultar Cliente por Código ou Nome"
        Me.BtnConCod.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(37, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(376, 82)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Consultar Total Vendido por Cliente"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(376, 82)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clientes que mais Compram"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(37, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(376, 82)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cliente por Tipo de Produto"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'EscolhaClienteConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(475, 573)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.BtnConCod)
        Me.Name = "EscolhaClienteConsultas"
        Me.Text = "Consultas de Cliente"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConCod As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
