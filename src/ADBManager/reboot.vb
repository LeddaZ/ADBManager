Public Class reboot
    Private Sub BtnNormal_Click(sender As Object, e As EventArgs) Handles BtnNormal.Click
        Me.Visible = False
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb reboot && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnRecovery_Click(sender As Object, e As EventArgs) Handles BtnRecovery.Click
        Me.Visible = False
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb reboot recovery && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub

    Private Sub BtnFastboot_Click(sender As Object, e As EventArgs) Handles BtnFastboot.Click
        Me.Visible = False
        Dim adb As New Process
        Dim adbinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c adb reboot bootloader && pause"
        }
        adb.StartInfo = adbinfo
        adb.Start()
    End Sub
End Class