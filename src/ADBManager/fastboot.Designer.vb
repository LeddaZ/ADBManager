﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fastboot
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
        Me.BtnTheme = New System.Windows.Forms.Button()
        Me.LblLink = New System.Windows.Forms.LinkLabel()
        Me.LblSource = New System.Windows.Forms.Label()
        Me.LblVersion = New System.Windows.Forms.Label()
        Me.LblAuthor = New System.Windows.Forms.Label()
        Me.BtnAdbSwitch = New System.Windows.Forms.Button()
        Me.BtnListFastboot = New System.Windows.Forms.Button()
        Me.BtnBootloader = New System.Windows.Forms.Button()
        Me.BtnFReboot = New System.Windows.Forms.Button()
        Me.BtnFlash = New System.Windows.Forms.Button()
        Me.BtnBootImage = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblMode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTheme
        '
        Me.BtnTheme.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTheme.Location = New System.Drawing.Point(231, 12)
        Me.BtnTheme.Name = "BtnTheme"
        Me.BtnTheme.Size = New System.Drawing.Size(101, 23)
        Me.BtnTheme.TabIndex = 30
        Me.BtnTheme.Text = "Light theme"
        Me.BtnTheme.UseVisualStyleBackColor = True
        '
        'LblLink
        '
        Me.LblLink.AutoSize = True
        Me.LblLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLink.LinkColor = System.Drawing.Color.Yellow
        Me.LblLink.Location = New System.Drawing.Point(93, 233)
        Me.LblLink.Name = "LblLink"
        Me.LblLink.Size = New System.Drawing.Size(245, 17)
        Me.LblLink.TabIndex = 28
        Me.LblLink.TabStop = True
        Me.LblLink.Tag = "https://github.com/LeddaZ/ADBManager"
        Me.LblLink.Text = "https://github.com/LeddaZ/ADBManager"
        '
        'LblSource
        '
        Me.LblSource.AutoSize = True
        Me.LblSource.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSource.ForeColor = System.Drawing.Color.White
        Me.LblSource.Location = New System.Drawing.Point(11, 233)
        Me.LblSource.Name = "LblSource"
        Me.LblSource.Size = New System.Drawing.Size(88, 17)
        Me.LblSource.TabIndex = 22
        Me.LblSource.Text = "Source code: "
        '
        'LblVersion
        '
        Me.LblVersion.AutoSize = True
        Me.LblVersion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ForeColor = System.Drawing.Color.White
        Me.LblVersion.Location = New System.Drawing.Point(419, 10)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(0, 21)
        Me.LblVersion.TabIndex = 19
        '
        'LblAuthor
        '
        Me.LblAuthor.AutoSize = True
        Me.LblAuthor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAuthor.ForeColor = System.Drawing.Color.White
        Me.LblAuthor.Location = New System.Drawing.Point(15, 46)
        Me.LblAuthor.Name = "LblAuthor"
        Me.LblAuthor.Size = New System.Drawing.Size(122, 21)
        Me.LblAuthor.TabIndex = 18
        Me.LblAuthor.Text = "By LeddaZ - v16"
        '
        'BtnAdbSwitch
        '
        Me.BtnAdbSwitch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdbSwitch.Location = New System.Drawing.Point(11, 104)
        Me.BtnAdbSwitch.Name = "BtnAdbSwitch"
        Me.BtnAdbSwitch.Size = New System.Drawing.Size(101, 55)
        Me.BtnAdbSwitch.TabIndex = 32
        Me.BtnAdbSwitch.Text = "Switch to adb commands"
        Me.BtnAdbSwitch.UseVisualStyleBackColor = True
        '
        'BtnListFastboot
        '
        Me.BtnListFastboot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListFastboot.Location = New System.Drawing.Point(117, 165)
        Me.BtnListFastboot.Name = "BtnListFastboot"
        Me.BtnListFastboot.Size = New System.Drawing.Size(105, 55)
        Me.BtnListFastboot.TabIndex = 33
        Me.BtnListFastboot.Text = "List connected devices"
        Me.BtnListFastboot.UseVisualStyleBackColor = True
        '
        'BtnBootloader
        '
        Me.BtnBootloader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBootloader.Location = New System.Drawing.Point(118, 104)
        Me.BtnBootloader.Name = "BtnBootloader"
        Me.BtnBootloader.Size = New System.Drawing.Size(105, 55)
        Me.BtnBootloader.TabIndex = 34
        Me.BtnBootloader.Text = "Check bootloader status"
        Me.BtnBootloader.UseVisualStyleBackColor = True
        '
        'BtnFReboot
        '
        Me.BtnFReboot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFReboot.Location = New System.Drawing.Point(11, 165)
        Me.BtnFReboot.Name = "BtnFReboot"
        Me.BtnFReboot.Size = New System.Drawing.Size(100, 55)
        Me.BtnFReboot.TabIndex = 36
        Me.BtnFReboot.Text = "Reboot"
        Me.BtnFReboot.UseVisualStyleBackColor = True
        '
        'BtnFlash
        '
        Me.BtnFlash.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFlash.Location = New System.Drawing.Point(229, 104)
        Me.BtnFlash.Name = "BtnFlash"
        Me.BtnFlash.Size = New System.Drawing.Size(105, 55)
        Me.BtnFlash.TabIndex = 37
        Me.BtnFlash.Text = "Flash an image"
        Me.BtnFlash.UseVisualStyleBackColor = True
        '
        'BtnBootImage
        '
        Me.BtnBootImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBootImage.Location = New System.Drawing.Point(228, 165)
        Me.BtnBootImage.Name = "BtnBootImage"
        Me.BtnBootImage.Size = New System.Drawing.Size(105, 55)
        Me.BtnBootImage.TabIndex = 38
        Me.BtnBootImage.Text = "Boot an image"
        Me.BtnBootImage.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.ForeColor = System.Drawing.Color.White
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(174, 37)
        Me.LblTitle.TabIndex = 39
        Me.LblTitle.Text = "ADBManager"
        '
        'LblMode
        '
        Me.LblMode.AutoSize = True
        Me.LblMode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMode.ForeColor = System.Drawing.Color.White
        Me.LblMode.Location = New System.Drawing.Point(15, 67)
        Me.LblMode.Name = "LblMode"
        Me.LblMode.Size = New System.Drawing.Size(111, 21)
        Me.LblMode.TabIndex = 40
        Me.LblMode.Text = "fastboot mode"
        '
        'Fastboot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(344, 267)
        Me.Controls.Add(Me.LblMode)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnBootImage)
        Me.Controls.Add(Me.BtnFlash)
        Me.Controls.Add(Me.BtnFReboot)
        Me.Controls.Add(Me.BtnBootloader)
        Me.Controls.Add(Me.BtnListFastboot)
        Me.Controls.Add(Me.BtnAdbSwitch)
        Me.Controls.Add(Me.BtnTheme)
        Me.Controls.Add(Me.LblLink)
        Me.Controls.Add(Me.LblSource)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblAuthor)
        Me.Name = "Fastboot"
        Me.Text = "ADBManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTheme As Button
    Friend WithEvents LblLink As LinkLabel
    Friend WithEvents LblSource As Label
    Friend WithEvents LblVersion As Label
    Friend WithEvents LblAuthor As Label
    Friend WithEvents BtnAdbSwitch As Button
    Friend WithEvents BtnListFastboot As Button
    Friend WithEvents BtnBootloader As Button
    Friend WithEvents BtnFReboot As Button
    Friend WithEvents BtnFlash As Button
    Friend WithEvents BtnBootImage As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblMode As Label
End Class
