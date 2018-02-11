Imports System.Diagnostics

Public Class Process_Manager

    'Proccess Manager Box
    Private Sub LoadProcesses()
        Processes.Items.Clear()
        For Each p As Process In Process.GetProcesses
            If Not Processes.Items.Contains(p.ProcessName) Then
                Processes.Items.Add(p.ProcessName)
            End If
        Next

        Processes.Sorted = True

        'End Of Proccess Manager Box
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub NewTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTaskToolStripMenuItem.Click
    End Sub

    Private Sub Process_Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Process_Manager_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        LoadProcesses()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each P As Process In Process.GetProcessesByName(Processes.SelectedItem)
            P.Kill()
            P.Close()

            MsgBox("Proccess Killed Successfully", MsgBoxStyle.Information, Title:="SUCCESS")
            Processes.Items.Clear()
            LoadProcesses()
        Next

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Processes.Items.Clear()
        LoadProcesses()
    End Sub

    Private Sub Processes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Processes.SelectedIndexChanged
        If Processes.Items.Contains("Explorer") Then
            MsgBox("ERROR")
        End If
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub Processes_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Processes.DrawItem

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub
End Class