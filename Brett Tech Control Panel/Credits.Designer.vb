<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credits
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FaderMinimalTheme1 = New Fader_Theme.FaderMinimalTheme()
        Me.OnlyklControlBox1 = New onlykl_theme.OnlyklControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FaderMinimalTheme1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FaderMinimalTheme1
        '
        Me.FaderMinimalTheme1.Controls.Add(Me.Label2)
        Me.FaderMinimalTheme1.Controls.Add(Me.OnlyklControlBox1)
        Me.FaderMinimalTheme1.Controls.Add(Me.Label1)
        Me.FaderMinimalTheme1.Controls.Add(Me.PictureBox1)
        Me.FaderMinimalTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaderMinimalTheme1.Location = New System.Drawing.Point(0, 0)
        Me.FaderMinimalTheme1.Name = "FaderMinimalTheme1"
        Me.FaderMinimalTheme1.Size = New System.Drawing.Size(634, 190)
        Me.FaderMinimalTheme1.TabIndex = 0
        Me.FaderMinimalTheme1.Text = "FaderMinimalTheme1"
        '
        'OnlyklControlBox1
        '
        Me.OnlyklControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OnlyklControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.OnlyklControlBox1.Location = New System.Drawing.Point(534, 25)
        Me.OnlyklControlBox1.MaximumDisable = True
        Me.OnlyklControlBox1.MinimumDisable = True
        Me.OnlyklControlBox1.Name = "OnlyklControlBox1"
        Me.OnlyklControlBox1.Size = New System.Drawing.Size(85, 30)
        Me.OnlyklControlBox1.TabIndex = 1
        Me.OnlyklControlBox1.Text = "OnlyklControlBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("AR JULIAN", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(305, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Support@Brett-TechRepair.Com"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Brett_Tech_Control_Panel.My.Resources.Resources.imageedit_42_2308305446
        Me.PictureBox1.Location = New System.Drawing.Point(31, -88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(576, 338)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(359, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "https://github.com/hudson1740"
        '
        'Credits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 190)
        Me.Controls.Add(Me.FaderMinimalTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Credits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credits"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FaderMinimalTheme1.ResumeLayout(False)
        Me.FaderMinimalTheme1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FaderMinimalTheme1 As Fader_Theme.FaderMinimalTheme
    Friend WithEvents OnlyklControlBox1 As onlykl_theme.OnlyklControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
