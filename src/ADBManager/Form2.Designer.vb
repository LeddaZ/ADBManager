<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BtnNormal = New System.Windows.Forms.Button()
        Me.BtnRecovery = New System.Windows.Forms.Button()
        Me.BtnFastboot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnNormal
        '
        Me.BtnNormal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNormal.ForeColor = System.Drawing.Color.Black
        Me.BtnNormal.Location = New System.Drawing.Point(12, 12)
        Me.BtnNormal.Name = "BtnNormal"
        Me.BtnNormal.Size = New System.Drawing.Size(111, 52)
        Me.BtnNormal.TabIndex = 0
        Me.BtnNormal.Text = "Normal"
        Me.BtnNormal.UseVisualStyleBackColor = True
        '
        'BtnRecovery
        '
        Me.BtnRecovery.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecovery.ForeColor = System.Drawing.Color.Black
        Me.BtnRecovery.Location = New System.Drawing.Point(129, 12)
        Me.BtnRecovery.Name = "BtnRecovery"
        Me.BtnRecovery.Size = New System.Drawing.Size(111, 52)
        Me.BtnRecovery.TabIndex = 1
        Me.BtnRecovery.Text = "Recovery"
        Me.BtnRecovery.UseVisualStyleBackColor = True
        '
        'BtnFastboot
        '
        Me.BtnFastboot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFastboot.ForeColor = System.Drawing.Color.Black
        Me.BtnFastboot.Location = New System.Drawing.Point(246, 12)
        Me.BtnFastboot.Name = "BtnFastboot"
        Me.BtnFastboot.Size = New System.Drawing.Size(111, 52)
        Me.BtnFastboot.TabIndex = 2
        Me.BtnFastboot.Text = "Fastboot"
        Me.BtnFastboot.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(369, 84)
        Me.Controls.Add(Me.BtnFastboot)
        Me.Controls.Add(Me.BtnRecovery)
        Me.Controls.Add(Me.BtnNormal)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "How do you want to reboot?"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNormal As Button
    Friend WithEvents BtnRecovery As Button
    Friend WithEvents BtnFastboot As Button
End Class
