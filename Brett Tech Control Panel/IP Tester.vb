Imports System.Net.NetworkInformation
Public Class IP_Tester
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        status1.Text = "STATUS"
        status1.ForeColor = Color.Gray
        TextBox1.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If My.Computer.Network.Ping(TextBox1.Text) Then
                status1.Text = (TextBox1.Text & "  is ONLINE ")
                status1.ForeColor = Color.Lime
            Else
                status1.Text = (TextBox1.Text & "  is OFFLINE ")
                status1.ForeColor = Color.Red
            End If
        Catch
            MsgBox("Please Enter A Valid IP Address", MsgBoxStyle.Critical, Title:="Invalid IP Address")

        End Try
    End Sub

    Private Sub IP_Tester_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class