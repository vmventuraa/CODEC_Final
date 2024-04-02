<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscolhaContrato
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
        Me.BtnConTranp = New System.Windows.Forms.Button()
        Me.BtnConSeg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnConTranp
        '
        Me.BtnConTranp.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnConTranp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BtnConTranp.ForeColor = System.Drawing.Color.White
        Me.BtnConTranp.Location = New System.Drawing.Point(12, 12)
        Me.BtnConTranp.Name = "BtnConTranp"
        Me.BtnConTranp.Size = New System.Drawing.Size(396, 82)
        Me.BtnConTranp.TabIndex = 2
        Me.BtnConTranp.Text = "Contrato Transporte"
        Me.BtnConTranp.UseVisualStyleBackColor = False
        '
        'BtnConSeg
        '
        Me.BtnConSeg.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.BtnConSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BtnConSeg.ForeColor = System.Drawing.Color.White
        Me.BtnConSeg.Location = New System.Drawing.Point(12, 139)
        Me.BtnConSeg.Name = "BtnConSeg"
        Me.BtnConSeg.Size = New System.Drawing.Size(396, 82)
        Me.BtnConSeg.TabIndex = 3
        Me.BtnConSeg.Text = "Contrato Segurança"
        Me.BtnConSeg.UseVisualStyleBackColor = False
        '
        'EscolhaContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 261)
        Me.Controls.Add(Me.BtnConSeg)
        Me.Controls.Add(Me.BtnConTranp)
        Me.Name = "EscolhaContrato"
        Me.Text = "EscolhaContrato"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnConTranp As System.Windows.Forms.Button
    Friend WithEvents BtnConSeg As System.Windows.Forms.Button
End Class
