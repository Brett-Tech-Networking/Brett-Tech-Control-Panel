Imports System.Net.NetworkInformation
Public Class System_Info


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'System Info
        Label1.Text = "Computer Name:  " & My.User.Name
        Label2.Text = "Operating System:  " & My.Computer.Info.OSFullName
        Label3.Text = "Platform:  " & My.Computer.Info.OSPlatform

        'Network Information'

        'Processor
        Dim name As String
        name = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", Nothing)
        Label5.Text = "Processor:   " & name

        'Owner
        Dim owner As String
        owner = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", Nothing)
        Label4.Text = "Registerd Owner:   " & owner

        'Product ID
        Dim productid As String
        productid = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion", "ProductId", Nothing)
        Label10.Text = "ProductID:   " & productid

        'Network Adapter
        Dim netcard As String
        netcard = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002bE10318}\0013", "AdapterModel", Nothing)
        Label6.Text = "Network Adapter:  " & netcard

        'Memory Info
        Label9.Text = "Total RAM:   " & My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024 & " GB"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

