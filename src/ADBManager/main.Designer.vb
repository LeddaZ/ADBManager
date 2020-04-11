<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.LblReboot = New System.Windows.Forms.Label()
        Me.BtnListDevices = New System.Windows.Forms.Button()
        Me.BtnShell = New System.Windows.Forms.Button()
        Me.LblSource = New System.Windows.Forms.Label()
        Me.BtnNetwork = New System.Windows.Forms.Button()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnCopyTo = New System.Windows.Forms.Button()
        Me.BtnRecord = New System.Windows.Forms.Button()
        Me.LblLink = New System.Windows.Forms.LinkLabel()
        Me.BtnTheme = New System.Windows.Forms.Button()
        Me.BtnFastbootSwitch = New System.Windows.Forms.Button()
        Me.BtnInstall = New System.Windows.Forms.Button()
        Me.BtnKillServer = New System.Windows.Forms.Button()
        Me.BtnLogcat = New System.Windows.Forms.Button()
        Me.BtnSideload = New System.Windows.Forms.Button()
        Me.BtnNormal = New System.Windows.Forms.Button()
        Me.BtnRecovery = New System.Windows.Forms.Button()
        Me.BtnFastboot = New System.Windows.Forms.Button()
        Me.LblMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
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
        Me.LblAuthor.Location = New System.Drawing.Point(15, 46)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(122, 21)
        Me.LblAuthor.TabIndex = 1
        Me.LblAuthor.Text = "By LeddaZ - v16"
        '
        'LblReboot
        '
        Me.LblReboot.AutoSize = True
        Me.LblReboot.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReboot.ForeColor = System.Drawing.Color.White
        Me.LblReboot.Location = New System.Drawing.Point(478, 79)
        Me.LblReboot.Name = "LblReboot"
        Me.LblReboot.Size = New System.Drawing.Size(60, 21)
        Me.LblReboot.TabIndex = 2
        Me.LblReboot.Text = "Reboot"
        '
        'BtnListDevices
        '
        Me.BtnListDevices.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListDevices.Location = New System.Drawing.Point(123, 103)
        Me.BtnListDevices.Name = "BtnListDevices"
        Me.BtnListDevices.Size = New System.Drawing.Size(105, 55)
        Me.BtnListDevices.TabIndex = 3
        Me.BtnListDevices.Text = "List connected devices"
        Me.BtnListDevices.UseVisualStyleBackColor = True
        '
        'BtnShell
        '
        Me.BtnShell.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShell.Location = New System.Drawing.Point(12, 164)
        Me.BtnShell.Name = "BtnShell"
        Me.BtnShell.Size = New System.Drawing.Size(105, 55)
        Me.BtnShell.TabIndex = 4
        Me.BtnShell.Text = "Open shell"
        Me.BtnShell.UseVisualStyleBackColor = True
        '
        'LblSource
        '
        Me.LblSource.AutoSize = True
        Me.LblSource.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSource.ForeColor = System.Drawing.Color.White
        Me.LblSource.Location = New System.Drawing.Point(12, 303)
        Me.LblSource.Name = "LblSource"
        Me.LblSource.Size = New System.Drawing.Size(88, 17)
        Me.LblSource.TabIndex = 6
        Me.LblSource.Text = "Source code: "
        '
        'BtnNetwork
        '
        Me.BtnNetwork.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNetwork.Location = New System.Drawing.Point(123, 225)
        Me.BtnNetwork.Name = "BtnNetwork"
        Me.BtnNetwork.Size = New System.Drawing.Size(105, 55)
        Me.BtnNetwork.TabIndex = 7
        Me.BtnNetwork.Text = "Connect over network"
        Me.BtnNetwork.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisconnect.Location = New System.Drawing.Point(123, 164)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(105, 55)
        Me.BtnDisconnect.TabIndex = 8
        Me.BtnDisconnect.Text = "Disconnect from network"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopy.Location = New System.Drawing.Point(345, 164)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(105, 55)
        Me.BtnCopy.TabIndex = 9
        Me.BtnCopy.Text = "Copy file to device"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnCopyTo
        '
        Me.BtnCopyTo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopyTo.Location = New System.Drawing.Point(345, 225)
        Me.BtnCopyTo.Name = "BtnCopyTo"
        Me.BtnCopyTo.Size = New System.Drawing.Size(105, 55)
        Me.BtnCopyTo.TabIndex = 10
        Me.BtnCopyTo.Text = "Copy file to PC"
        Me.BtnCopyTo.UseVisualStyleBackColor = True
        '
        'BtnRecord
        '
        Me.BtnRecord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecord.Location = New System.Drawing.Point(345, 103)
        Me.BtnRecord.Name = "BtnRecord"
        Me.BtnRecord.Size = New System.Drawing.Size(105, 55)
        Me.BtnRecord.TabIndex = 12
        Me.BtnRecord.Text = "Record screen"
        Me.BtnRecord.UseVisualStyleBackColor = True
        '
        'LblLink
        '
        Me.LblLink.AutoSize = True
        Me.LblLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLink.LinkColor = System.Drawing.Color.Yellow
        Me.LblLink.Location = New System.Drawing.Point(94, 303)
        Me.LblLink.Name = "LblLink"
        Me.LblLink.Size = New System.Drawing.Size(245, 17)
        Me.LblLink.TabIndex = 13
        Me.LblLink.TabStop = True
        Me.LblLink.Tag = "https://github.com/LeddaZ/ADBManager"
        Me.LblLink.Text = "https://github.com/LeddaZ/ADBManager"
        '
        'BtnTheme
        '
        Me.BtnTheme.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTheme.Location = New System.Drawing.Point(456, 301)
        Me.BtnTheme.Name = "BtnTheme"
        Me.BtnTheme.Size = New System.Drawing.Size(105, 23)
        Me.BtnTheme.TabIndex = 15
        Me.BtnTheme.Text = "Light theme"
        Me.BtnTheme.UseVisualStyleBackColor = True
        '
        'BtnFastbootSwitch
        '
        Me.BtnFastbootSwitch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFastbootSwitch.Location = New System.Drawing.Point(12, 103)
        Me.BtnFastbootSwitch.Name = "BtnFastbootSwitch"
        Me.BtnFastbootSwitch.Size = New System.Drawing.Size(105, 55)
        Me.BtnFastbootSwitch.TabIndex = 16
        Me.BtnFastbootSwitch.Text = "Switch to fastboot commands"
        Me.BtnFastbootSwitch.UseVisualStyleBackColor = True
        '
        'BtnInstall
        '
        Me.BtnInstall.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInstall.Location = New System.Drawing.Point(234, 164)
        Me.BtnInstall.Name = "BtnInstall"
        Me.BtnInstall.Size = New System.Drawing.Size(105, 55)
        Me.BtnInstall.TabIndex = 18
        Me.BtnInstall.Text = "Install APK file"
        Me.BtnInstall.UseVisualStyleBackColor = True
        '
        'BtnKillServer
        '
        Me.BtnKillServer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKillServer.Location = New System.Drawing.Point(12, 225)
        Me.BtnKillServer.Name = "BtnKillServer"
        Me.BtnKillServer.Size = New System.Drawing.Size(105, 55)
        Me.BtnKillServer.TabIndex = 19
        Me.BtnKillServer.Text = "Terminate ADB"
        Me.BtnKillServer.UseVisualStyleBackColor = True
        '
        'BtnLogcat
        '
        Me.BtnLogcat.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogcat.Location = New System.Drawing.Point(234, 225)
        Me.BtnLogcat.Name = "BtnLogcat"
        Me.BtnLogcat.Size = New System.Drawing.Size(105, 55)
        Me.BtnLogcat.TabIndex = 20
        Me.BtnLogcat.Text = "Grab a logcat"
        Me.BtnLogcat.UseVisualStyleBackColor = True
        '
        'BtnSideload
        '
        Me.BtnSideload.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSideload.Location = New System.Drawing.Point(234, 103)
        Me.BtnSideload.Name = "BtnSideload"
        Me.BtnSideload.Size = New System.Drawing.Size(105, 55)
        Me.BtnSideload.TabIndex = 21
        Me.BtnSideload.Text = "Sideload a ZIP file"
        Me.BtnSideload.UseVisualStyleBackColor = True
        '
        'BtnNormal
        '
        Me.BtnNormal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNormal.Location = New System.Drawing.Point(456, 103)
        Me.BtnNormal.Name = "BtnNormal"
        Me.BtnNormal.Size = New System.Drawing.Size(105, 55)
        Me.BtnNormal.TabIndex = 22
        Me.BtnNormal.Text = "Reboot"
        Me.BtnNormal.UseVisualStyleBackColor = True
        '
        'BtnRecovery
        '
        Me.BtnRecovery.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecovery.Location = New System.Drawing.Point(456, 164)
        Me.BtnRecovery.Name = "BtnRecovery"
        Me.BtnRecovery.Size = New System.Drawing.Size(105, 55)
        Me.BtnRecovery.TabIndex = 23
        Me.BtnRecovery.Text = "Reboot to recovery"
        Me.BtnRecovery.UseVisualStyleBackColor = True
        '
        'BtnFastboot
        '
        Me.BtnFastboot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFastboot.Location = New System.Drawing.Point(456, 225)
        Me.BtnFastboot.Name = "BtnFastboot"
        Me.BtnFastboot.Size = New System.Drawing.Size(105, 55)
        Me.BtnFastboot.TabIndex = 24
        Me.BtnFastboot.Text = "Reboot to fastboot"
        Me.BtnFastboot.UseVisualStyleBackColor = True
        '
        'LblMode
        '
        Me.LblMode.AutoSize = True
        Me.LblMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMode.ForeColor = System.Drawing.Color.White
        Me.LblMode.Location = New System.Drawing.Point(15, 67)
        Me.LblMode.Name = "LblMode"
        Me.LblMode.Size = New System.Drawing.Size(80, 21)
        Me.LblMode.TabIndex = 25
        Me.LblMode.Text = "adb mode"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(573, 336)
        Me.Controls.Add(Me.LblMode)
        Me.Controls.Add(Me.BtnFastboot)
        Me.Controls.Add(Me.BtnRecovery)
        Me.Controls.Add(Me.BtnNormal)
        Me.Controls.Add(Me.BtnSideload)
        Me.Controls.Add(Me.BtnLogcat)
        Me.Controls.Add(Me.BtnKillServer)
        Me.Controls.Add(Me.BtnInstall)
        Me.Controls.Add(Me.BtnFastbootSwitch)
        Me.Controls.Add(Me.BtnTheme)
        Me.Controls.Add(Me.LblLink)
        Me.Controls.Add(Me.BtnRecord)
        Me.Controls.Add(Me.BtnCopyTo)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Controls.Add(Me.BtnNetwork)
        Me.Controls.Add(Me.LblSource)
        Me.Controls.Add(Me.BtnShell)
        Me.Controls.Add(Me.BtnListDevices)
        Me.Controls.Add(Me.LblReboot)
        Me.Controls.Add(Me.LblAuthor)
        Me.Controls.Add(Me.LblTitle)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "ADBManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents LblReboot As Label
    Friend WithEvents BtnListDevices As Button
    Friend WithEvents BtnShell As Button
    Friend WithEvents LblSource As Label
    Friend WithEvents BtnNetwork As Button
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnCopyTo As Button
    Friend WithEvents BtnRecord As Button
    Friend WithEvents LblLink As LinkLabel
    Friend WithEvents BtnTheme As Button
    Friend WithEvents BtnFastbootSwitch As Button
    Friend WithEvents BtnInstall As Button
    Friend WithEvents BtnKillServer As Button
    Friend WithEvents BtnLogcat As Button
    Friend WithEvents BtnSideload As Button
    Friend WithEvents BtnNormal As Button
    Friend WithEvents BtnRecovery As Button
    Friend WithEvents BtnFastboot As Button
    Friend WithEvents LblMode As Label
End Class
