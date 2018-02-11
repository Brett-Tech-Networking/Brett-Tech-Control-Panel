Public Class Virus_Scan

    Dim percent = 0
    Dim red
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        percent = (ListBox2.Items.Count / ListBox1.Items.Count) * 100
        If (ListBox1.SelectedIndex < ListBox1.Items.Count - 1) Then
            ProgressBar1.Value = percent
            Label2.Text = "Scanning For: " & ListBox1.SelectedItem
            ListBox2.Items.Add("Scanning: " & ListBox1.SelectedItem)
            Try
                If Dir(ListBox1.SelectedItem.ToString) <> "" Then
                    ListBox3.Items.Add("Threat Found: " & ListBox1.SelectedItem.ToString)
                ElseIf Dir(ListBox1.SelectedItem.ToString, FileAttribute.Hidden) <> "" Then
                    ListBox3.Items.Add("Threat Found: " & ListBox1.SelectedItem.ToString)
                Else
                End If
            Catch ex As Exception

            End Try
            ListBox1.SelectedIndex += 1
        Else
            If ListBox3.Items.Count - 1 >= 1 Then
                ListBox3.SelectedIndex = 0
                Button3.Enabled = True
            End If
            Timer1.Stop()
            ProgressBar1.Value = 100
            Label2.Text = "Finished Scanning. " & ListBox3.Items.Count & "Threat(s) Found!"
            Button2.Enabled = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        ComboBox1.SelectedIndex = 0
        ComboBox1.Items.AddRange(System.IO.Directory.GetLogicalDrives)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        percent = 0
        Button1.Enabled = False
        ListBox1.SelectedIndex = 0
        Timer1.Start()
        Button2.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 1 Then
            ListBox1.Items.Clear()
            TextBox1.Text = My.Resources.virusList.ToString
            For Each line As String In TextBox1.Lines
                ListBox1.Items.Add(ComboBox1.SelectedItem.ToString & line.ToString)
            Next
            If ListBox1.Items.Count = 1 >= 0 Then
                Label1.Text = "Database Loaded!"
                Button1.Enabled = True
            Else
                Label1.Text = "No Database Loaded!"
                Button1.Enabled = False
            End If
        Else
            Button1.Enabled = False
            ListBox1.Items.Clear()
            TextBox1.Text = ""
            Label1.Text = "No Database Loaded!"
        End If
    End Sub
    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        If Label1.Text = "Database Loaded!" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox3.Items.Count - 1 >= 0 Then
            ListBox3.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

