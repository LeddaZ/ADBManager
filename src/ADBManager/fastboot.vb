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
            LblVerF.ForeColor = Color.Black
            BtnTheme.Text = "Black theme"
        ElseIf Me.BackColor = Color.White Then
            main.BackColor = Color.Black
            reboot.BackColor = Color.Black
            Me.BackColor = Color.Black
            LblTitle.ForeColor = Color.White
            LblAuthor.ForeColor = Color.White
            LblSource.ForeColor = Color.White
            LblLink.LinkColor = Color.Yellow
            LblVerF.ForeColor = Color.White
            BtnTheme.Text = "White theme"
        End If
    End Sub

    Private Sub BtnFReboot_Click(sender As Object, e As EventArgs) Handles BtnFReboot.Click
        Dim fastboot As New Process
        Dim fastbootinfo As New System.Diagnostics.ProcessStartInfo With {
            .FileName = "cmd.exe",
            .UseShellExecute = True,
            .CreateNoWindow = False,
            .Arguments = "/c fastboot reboot && pause"
        }
        fastboot.StartInfo = fastbootinfo
        fastboot.Start()
    End Sub

    Private Sub BtnFlash_Click(sender As Object, e As EventArgs) Handles BtnFlash.Click
        Dim img As String
        Dim part As String
        img = InputBox("Enter the image path", "Flash an image")
        If img = Nothing Then
            MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
        Else
            part = InputBox("Enter the destination partition", "Flash an image")
            If part = Nothing Then
                MsgBox("You have entered an empty partition.", MsgBoxStyle.Critical, "Error")
            Else
                Dim fastboot As New Process
                Dim fastbootinfo As New System.Diagnostics.ProcessStartInfo With {
                    .FileName = "cmd.exe",
                    .UseShellExecute = True,
                    .CreateNoWindow = False,
                    .Arguments = "/c fastboot flash " + part + " " + img + " && pause"
                }
                fastboot.StartInfo = fastbootinfo
                fastboot.Start()
            End If
        End If
    End Sub

    Private Sub BtnBootImage_Click(sender As Object, e As EventArgs) Handles BtnBootImage.Click
        Dim boot As String
        boot = InputBox("Enter the image path", "Boot an image")
        If boot = Nothing Then
            MsgBox("You have entered an empty path.", MsgBoxStyle.Critical, "Error")
        Else
            Dim fastboot As New Process
            Dim fastbootinfo As New System.Diagnostics.ProcessStartInfo With {
                .FileName = "cmd.exe",
                .UseShellExecute = True,
                .CreateNoWindow = False,
                .Arguments = "/c fastboot boot " + boot + " && pause"
            }
            fastboot.StartInfo = fastbootinfo
            fastboot.Start()
        End If
    End Sub
End Class