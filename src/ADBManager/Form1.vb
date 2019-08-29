Public Class Form1

    Private Sub BtnListDevices_Click(sender As Object, e As EventArgs) Handles BtnListDevices.Click
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb devices && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnShell_Click(sender As Object, e As EventArgs) Handles BtnShell.Click
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb shell"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnNetwork_Click(sender As Object, e As EventArgs) Handles BtnNetwork.Click
        Dim ip As String
        ip = InputBox("Enter your device's IP address:", "Connect over the network")
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb connect " + ip + ":5555 && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb disconnect && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Dim source As String
        Dim dest As String
        source = InputBox("Enter the source file path:", "Copy file from PC to device")
        dest = InputBox("Enter the destination path:", "Copy file from PC to device")
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb push -a " + source + " " + dest + " && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnCopyTo_Click(sender As Object, e As EventArgs) Handles BtnCopyTo.Click
        Dim source As String
        Dim dest As String
        source = InputBox("Enter the source file path:", "Copy file from device to PC")
        dest = InputBox("Enter the destination path:", "Copy file from device to PC")
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb pull -a " + source + " " + dest + " && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles BtnRecord.Click
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c echo Press Ctrl+C to stop recording. && adb shell screenrecord /sdcard/ADBManager.mp4"}
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnReboot_Click(sender As Object, e As EventArgs) Handles BtnReboot.Click
        Form2.Visible = True
    End Sub

    Private Sub LblLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLink.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/LeddaZ/ADBManager")
    End Sub

    Private Sub BtnTheme_Click(sender As Object, e As EventArgs) Handles BtnTheme.Click
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
            Form2.BackColor = Color.White
            LblTitle.ForeColor = Color.Black
            LblAuthor.ForeColor = Color.Black
            LblSource.ForeColor = Color.Black
            LblLink.LinkColor = Color.Blue
        ElseIf Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
            Form2.BackColor = Color.Black
            LblTitle.ForeColor = Color.White
            LblAuthor.ForeColor = Color.White
            LblSource.ForeColor = Color.White
            LblLink.LinkColor = Color.Yellow
        End If
    End Sub
End Class
