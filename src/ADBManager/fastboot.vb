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

    Private Sub BtnTheme_Click(sender As Object, e As EventArgs) Handles BtnTheme.Click
        If Me.BackColor = Color.Black Then
            main.BackColor = Color.White
            reboot.BackColor = Color.White
            Me.BackColor = Color.White
            LblTitle.ForeColor = Color.Black
            LblAuthor.ForeColor = Color.Black
            LblSource.ForeColor = Color.Black
            LblLink.LinkColor = Color.Blue
            LblVer.ForeColor = Color.Black
            BtnTheme.Text = "Black theme"
        ElseIf Me.BackColor = Color.White Then
            main.BackColor = Color.Black
            reboot.BackColor = Color.Black
            Me.BackColor = Color.Black
            LblTitle.ForeColor = Color.White
            LblAuthor.ForeColor = Color.White
            LblSource.ForeColor = Color.White
            LblLink.LinkColor = Color.Yellow
            LblVer.ForeColor = Color.White
            BtnTheme.Text = "White theme"
        End If
    End Sub
End Class