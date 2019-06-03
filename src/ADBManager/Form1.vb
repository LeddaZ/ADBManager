Public Class Form1
    Private Sub BtnListDevices_Click(sender As Object, e As EventArgs) Handles BtnListDevices.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\list.bat")
    End Sub

    Private Sub BtnShell_Click(sender As Object, e As EventArgs) Handles BtnShell.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\shell.bat")
    End Sub

    Private Sub BtnRootShell_Click(sender As Object, e As EventArgs) Handles BtnRootShell.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\root.bat")
    End Sub

    Private Sub BtnNetwork_Click(sender As Object, e As EventArgs) Handles BtnNetwork.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\net.bat")
    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\disconnect.bat")
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Process.Start("C:\Windows\system32\cmd.exe", "/C cmds\copy.bat")
    End Sub
End Class
