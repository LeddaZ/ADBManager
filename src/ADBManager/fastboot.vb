Public Class fastboot
    Private Sub BtnAdbSwitch_Click(sender As Object, e As EventArgs) Handles BtnAdbSwitch.Click
        Me.Visible = False
        main.Visible = True
    End Sub

    Private Sub BtnListFastboot_Click(sender As Object, e As EventArgs) Handles BtnListFastboot.Click
        Dim fastboot As New Process
        Dim fastbootinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c fastboot devices && pause"
        }
        fastboot.StartInfo = fastbootinfo
        fastboot.Start()
    End Sub

    Private Sub BtnBootloader_Click(sender As Object, e As EventArgs) Handles BtnBootloader.Click
        Dim fastboot As New Process
        Dim fastbootinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c fastboot oem device-info && pause"
        }
        fastboot.StartInfo = fastbootinfo
        fastboot.Start()
    End Sub
End Class