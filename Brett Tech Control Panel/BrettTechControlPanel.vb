Public Class BrettTech
    Private Sub Clock_Tick(sender As Object, e As EventArgs) Handles Clock.Tick
        Time.Text = (TimeOfDay)
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MsgBox("Created By Brett Hudson (Founder)
           Brett Tech Networking
Some Design Ideas - Mitchell (Brother)", MsgBoxStyle.Information, Title:="Credits")
    End Sub

    Private Sub IPTesterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IPTesterToolStripMenuItem.Click
        IP_Tester.Show()
    End Sub


    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        System_Info.Show()
    End Sub

    Private Sub ProcessManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcessManagerToolStripMenuItem.Click
        Process_Manager.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process_Manager.Show()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        System_Info.Show()
    End Sub

    Private Sub CPUBETAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CPU.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process_Manager.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System_Info.Show()
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        Process.Start("control", "mmsys.cpl sounds")
    End Sub

    Private Sub MouseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MouseToolStripMenuItem.Click
        Process.Start("control", "main.cpl")
    End Sub

    Private Sub MaroonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaroonToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed
    End Sub

    Private Sub NavyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavyToolStripMenuItem.Click
        Me.BackColor = Color.Navy
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("control.exe", "/name Microsoft.Troubleshooting")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start("control.exe", "/name Microsoft.UserAccounts")
    End Sub

    Private Sub AdvancedUserControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedUserControlToolStripMenuItem.Click
        Process.Start("netplwiz")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Process.Start("timedate.cpl")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Process.Start("hdwwiz.cpl")
    End Sub

    Private Sub DeviceManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceManagerToolStripMenuItem.Click
        Process.Start("hdwwiz.cpl")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Process.Start("gpedit.msc")
    End Sub

    Private Sub GroupPolicyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GroupPolicyToolStripMenuItem.Click
        Process.Start("gpedit.msc")

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Shutdown
        If ComboBox1.SelectedItem = ("Shutdown") Then
            Process.Start("Shutdown", "-s -t 15")
            MsgBox("COMPUTER WILL SHUTDOWN IN 15 SEC", MsgBoxStyle.Information, Title:="SHUTDOWN")

            'Hibernate
            If ComboBox1.SelectedItem = ("Hibernate") Then
                Process.Start("Shutdown", "-h -t 00")
                MsgBox("COMPUTER WILL Hibernate IN 0 SEC")

                'Reboot
                If ComboBox1.SelectedItem = ("Reboot") Then
                    Process.Start("Shutdown", "-r -t 15")
                    MsgBox("COMPUTER WILL REBOOT IN 15 SEC", MsgBoxStyle.Critical, Title:="REBOOT")

                    'Cancel 
                    If ComboBox1.SelectedItem = ("Cancel") Then
                        Process.Start("Shutdown", "-a")
                        MsgBox("Shutdown Canceled", MsgBoxStyle.Information, Title:="CANCELED")

                    Else
                        MsgBox("ERROR")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub ShutdownToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShutdownToolStripMenuItem1.Click
        MsgBox("Are You Sure You Want To Shutdown ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            Process.Start("Shutdown", "-s -t 20")
        Else
            If MsgBoxResult.No Then
                MsgBox("ok")
            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Virus_Scan.Show()
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("control", "/name Microsoft.AddHardware")
    End Sub

    Private Sub SleepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SleepToolStripMenuItem.Click
        Process.Start("rundll32.exe powrprof.dll,SetSuspendState 0,1,0")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BrettTech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("Control")
    End Sub

    Private Sub CreditsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        Credits.Show()
    End Sub

    Private Sub HibernateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HibernateToolStripMenuItem.Click
        MsgBox("Are You Sure You Want To hibernate ?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            Process.Start("Shutdown", "-h -t 00")
        Else
            If MsgBoxResult.No Then
                MsgBox("ok")
            End If
        End If
    End Sub
End Class
