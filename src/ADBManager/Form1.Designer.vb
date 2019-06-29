<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.BtnListDevices = New System.Windows.Forms.Button()
        Me.BtnShell = New System.Windows.Forms.Button()
        Me.BtnRootShell = New System.Windows.Forms.Button()
        Me.LblSourceLink = New System.Windows.Forms.Label()
        Me.BtnNetwork = New System.Windows.Forms.Button()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnCopyTo = New System.Windows.Forms.Button()
        Me.BtnRecord = New System.Windows.Forms.Button()
        Me.LnkLblSrc = New System.Windows.Forms.LinkLabel()
        Me.BtnReboot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(146, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(174, 37)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "ADBManager"
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.Color.White
        Me.LblAuthor.Location = New System.Drawing.Point(192, 46)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(82, 21)
        Me.LblAuthor.TabIndex = 1
        Me.LblAuthor.Text = "By LeddaZ"
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ForeColor = System.Drawing.Color.White
        Me.LblVersion.Location = New System.Drawing.Point(405, 306)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(43, 21)
        Me.LblVersion.TabIndex = 2
        Me.LblVersion.Text = "1.0.5"
        '
        'BtnListDevices
        '
        Me.BtnListDevices.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListDevices.Location = New System.Drawing.Point(12, 103)
        Me.BtnListDevices.Name = "BtnListDevices"
        Me.BtnListDevices.Size = New System.Drawing.Size(105, 55)
        Me.BtnListDevices.TabIndex = 3
        Me.BtnListDevices.Text = "List avaliable devices"
        Me.BtnListDevices.UseVisualStyleBackColor = True
        '
        'BtnShell
        '
        Me.BtnShell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShell.Location = New System.Drawing.Point(123, 103)
        Me.BtnShell.Name = "BtnShell"
        Me.BtnShell.Size = New System.Drawing.Size(105, 55)
        Me.BtnShell.TabIndex = 4
        Me.BtnShell.Text = "Open shell"
        Me.BtnShell.UseVisualStyleBackColor = True
        '
        'BtnRootShell
        '
        Me.BtnRootShell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRootShell.Location = New System.Drawing.Point(234, 103)
        Me.BtnRootShell.Name = "BtnRootShell"
        Me.BtnRootShell.Size = New System.Drawing.Size(105, 55)
        Me.BtnRootShell.TabIndex = 5
        Me.BtnRootShell.Text = "Open root shell"
        Me.BtnRootShell.UseVisualStyleBackColor = True
        '
        'LblSourceLink
        '
        Me.LblSourceLink.AutoSize = True
        Me.LblSourceLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSourceLink.ForeColor = System.Drawing.Color.White
        Me.LblSourceLink.Location = New System.Drawing.Point(9, 310)
        Me.LblSourceLink.Name = "LblSourceLink"
        Me.LblSourceLink.Size = New System.Drawing.Size(88, 17)
        Me.LblSourceLink.TabIndex = 6
        Me.LblSourceLink.Text = "Source code: "
        '
        'BtnNetwork
        '
        Me.BtnNetwork.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNetwork.Location = New System.Drawing.Point(345, 103)
        Me.BtnNetwork.Name = "BtnNetwork"
        Me.BtnNetwork.Size = New System.Drawing.Size(103, 55)
        Me.BtnNetwork.TabIndex = 7
        Me.BtnNetwork.Text = "Connect over network"
        Me.BtnNetwork.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconnect.Location = New System.Drawing.Point(345, 164)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(103, 55)
        Me.BtnDisconnect.TabIndex = 8
        Me.BtnDisconnect.Text = "Disconnect from network"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopy.Location = New System.Drawing.Point(12, 164)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(105, 55)
        Me.BtnCopy.TabIndex = 9
        Me.BtnCopy.Text = "Copy file to internal storage"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnCopyTo
        '
        Me.BtnCopyTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopyTo.Location = New System.Drawing.Point(123, 164)
        Me.BtnCopyTo.Name = "BtnCopyTo"
        Me.BtnCopyTo.Size = New System.Drawing.Size(105, 55)
        Me.BtnCopyTo.TabIndex = 10
        Me.BtnCopyTo.Text = "Copy file to Desktop"
        Me.BtnCopyTo.UseVisualStyleBackColor = True
        '
        'BtnRecord
        '
        Me.BtnRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecord.Location = New System.Drawing.Point(234, 164)
        Me.BtnRecord.Name = "BtnRecord"
        Me.BtnRecord.Size = New System.Drawing.Size(105, 55)
        Me.BtnRecord.TabIndex = 12
        Me.BtnRecord.Text = "Record screen"
        Me.BtnRecord.UseVisualStyleBackColor = True
        '
        'LnkLblSrc
        '
        Me.LnkLblSrc.AutoSize = True
        Me.LnkLblSrc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblSrc.LinkColor = System.Drawing.Color.Yellow
        Me.LnkLblSrc.Location = New System.Drawing.Point(87, 311)
        Me.LnkLblSrc.Name = "LnkLblSrc"
        Me.LnkLblSrc.Size = New System.Drawing.Size(249, 16)
        Me.LnkLblSrc.TabIndex = 13
        Me.LnkLblSrc.TabStop = True
        Me.LnkLblSrc.Tag = "https://github.com/LeddaZ/ADBManager"
        Me.LnkLblSrc.Text = "https://github.com/LeddaZ/ADBManager"
        '
        'BtnReboot
        '
        Me.BtnReboot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReboot.Location = New System.Drawing.Point(12, 225)
        Me.BtnReboot.Name = "BtnReboot"
        Me.BtnReboot.Size = New System.Drawing.Size(105, 55)
        Me.BtnReboot.TabIndex = 14
        Me.BtnReboot.Text = "Reboot"
        Me.BtnReboot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(459, 336)
        Me.Controls.Add(Me.BtnReboot)
        Me.Controls.Add(Me.LnkLblSrc)
        Me.Controls.Add(Me.BtnRecord)
        Me.Controls.Add(Me.BtnCopyTo)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Controls.Add(Me.BtnNetwork)
        Me.Controls.Add(Me.LblSourceLink)
        Me.Controls.Add(Me.BtnRootShell)
        Me.Controls.Add(Me.BtnShell)
        Me.Controls.Add(Me.BtnListDevices)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.LblTitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "ADBManager by LeddaZ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents BtnListDevices As Button
    Friend WithEvents BtnShell As Button
    Friend WithEvents BtnRootShell As Button
    Friend WithEvents LblSourceLink As Label
    Friend WithEvents BtnNetwork As Button
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnCopyTo As Button
    Friend WithEvents BtnRecord As Button
    Friend WithEvents LnkLblSrc As LinkLabel
    Friend WithEvents BtnReboot As Button
End Class
