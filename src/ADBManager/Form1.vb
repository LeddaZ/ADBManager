﻿Public Class Form1

    Private Sub BtnListDevices_Click(sender As Object, e As EventArgs) Handles BtnListDevices.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\list.bat")
    End Sub

    Private Sub BtnShell_Click(sender As Object, e As EventArgs) Handles BtnShell.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\shell.bat")
    End Sub

    Private Sub BtnNetwork_Click(sender As Object, e As EventArgs) Handles BtnNetwork.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\net.bat")
    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\disconnect.bat")
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\copyfrom.bat")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCopyTo.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\copyto.bat")
    End Sub

    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles BtnRecord.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\record.bat")
    End Sub

    Private Sub BtnReboot_Click(sender As Object, e As EventArgs) Handles BtnReboot.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\reboot.bat")
    End Sub

    Private Sub LnkLblSrc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkLblSrc.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/LeddaZ/ADBManager")
    End Sub

End Class
