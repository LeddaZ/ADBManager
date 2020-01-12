Public Class main

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
        source = InputBox("Enter the source file path", "Copy file from PC to device")
        If source = Nothing Then
            MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
        Else
            dest = InputBox("Enter the destination path", "Copy file from Pc to device")
            If dest = Nothing Then
                MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
            Else
                Dim adb As New Process
                Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
                    .FileName = "cmd.exe",
                    .UseShellExecute = True,
                    .CreateNoWindow = False,
                    .Arguments = "/c adb push -a " + source + " " + dest + " && pause"
                }
                adb.StartInfo = adbinfo
                adb.Start()
            End If
        End If
    End Sub

    Private Sub BtnCopyTo_Click(sender As Object, e As EventArgs) Handles BtnCopyTo.Click
        Dim source As String
        Dim dest As String
        source = InputBox("Enter the source file path", "Copy file from device to PC")
        If source = Nothing Then
            MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
        Else
            dest = InputBox("Enter the destination path", "Copy file from device to PC")
            If dest = Nothing Then
                MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
            Else
                Dim adb As New Process
                Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
                    .FileName = "cmd.exe",
                    .UseShellExecute = True,
                    .CreateNoWindow = False,
                    .Arguments = "/c adb pull -a " + source + " " + dest + " && pause"
                }
                adb.StartInfo = adbinfo
                adb.Start()
            End If
        End If
    End Sub

    Private Sub BtnRecord_Click(sender As Object, e As EventArgs) Handles BtnRecord.Click
        Dim name As String
        name = InputBox("Enter the filename without the extension", "Record screen")
        If name = Nothing Then
            MsgBox("You have entered an empty filename.", MsgBoxStyle.Critical, "Error")
        Else
            Dim adb As New Process
            Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
                .FileName = "cmd.exe",
                .UseShellExecute = True,
                .CreateNoWindow = False,
                .Arguments = "/c echo Press Ctrl+C to stop recording. && adb shell screenrecord /sdcard/" + name + ".mp4"}
            adb.StartInfo = adbinfo
            adb.Start()
        End If
    End Sub

    Private Sub BtnReboot_Click(sender As Object, e As EventArgs) Handles BtnReboot.Click
        reboot.Visible = True
    End Sub

    Private Sub LblLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblLink.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/LeddaZ/ADBManager")
    End Sub

    Private Sub BtnTheme_Click(sender As Object, e As EventArgs) Handles BtnTheme.Click
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
            reboot.BackColor = Color.White
            fastboot.BackColor = Color.White
            LblTitle.ForeColor = Color.Black
            LblAuthor.ForeColor = Color.Black
            LblSource.ForeColor = Color.Black
            LblLink.LinkColor = Color.Blue
            LblVer.ForeColor = Color.Black
            BtnTheme.Text = "Black theme"
        ElseIf Me.BackColor = Color.White Then
            Me.BackColor = Color.Black
            reboot.BackColor = Color.Black
            fastboot.BackColor = Color.Black
            LblTitle.ForeColor = Color.White
            LblAuthor.ForeColor = Color.White
            LblSource.ForeColor = Color.White
            LblLink.LinkColor = Color.Yellow
            LblVer.ForeColor = Color.White
            BtnTheme.Text = "White theme"
        End If
    End Sub

    Private Sub BtnFastbootSwitch_Click(sender As Object, e As EventArgs) Handles BtnFastbootSwitch.Click
        Me.Visible = False
        fastboot.Visible = True
    End Sub

    Private Sub BtnInstall_Click(sender As Object, e As EventArgs) Handles BtnInstall.Click
        Dim apk As String
        apk = InputBox("Enter the APK file path", "Install APK file")
        If apk = Nothing Then
            MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
        Else
            Dim adb As New Process
            Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
                .FileName = "cmd.exe",
                .UseShellExecute = True,
                .CreateNoWindow = False,
                .Arguments = "/c adb install " + apk + " && pause"
            }
            adb.StartInfo = adbinfo
            adb.Start()
        End If
    End Sub

    Private Sub BtnKillServer_Click(sender As Object, e As EventArgs) Handles BtnKillServer.Click
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb kill-server && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnLogcat_Click(sender As Object, e As EventArgs) Handles BtnLogcat.Click
        Dim log As String
        log = InputBox("Enter the logcat filename without the extension. Press Ctrl+C to stop.", "Grab a logcat")
        If log = Nothing Then
            MsgBox("You have entered an empty filename.", MsgBoxStyle.Critical, "Error")
        Else
            Dim adb As New Process
            Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
                .FileName = "cmd.exe",
                .UseShellExecute = True,
                .CreateNoWindow = False,
                .Arguments = "/c adb logcat > " + log + ".txt"
            }
            adb.StartInfo = adbinfo
            adb.Start()
        End If
    End Sub
End Class
