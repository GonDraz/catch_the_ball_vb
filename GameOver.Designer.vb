<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
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
        Me.btnReplay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.lbScore = New System.Windows.Forms.Label()
        Me.tbPlayer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'btnReplay
        '
        Me.btnReplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReplay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReplay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReplay.ForeColor = System.Drawing.Color.White
        Me.btnReplay.Location = New System.Drawing.Point(442, 542)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(394, 64)
        Me.btnReplay.TabIndex = 2
        Me.btnReplay.Text = "Replay"
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(442, 623)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(394, 63)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu"
        '
        'lbScore
        '
        Me.lbScore.AutoSize = True
        Me.lbScore.BackColor = System.Drawing.Color.Transparent
        Me.lbScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore.Location = New System.Drawing.Point(459, 312)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(295, 37)
        Me.lbScore.TabIndex = 4
        Me.lbScore.Text = "Score Của Bạn là : "
        '
        'tbPlayer
        '
        Me.tbPlayer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPlayer.DefaultText = ""
        Me.tbPlayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPlayer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPlayer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPlayer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbPlayer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPlayer.Location = New System.Drawing.Point(442, 408)
        Me.tbPlayer.Name = "tbPlayer"
        Me.tbPlayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPlayer.PlaceholderText = ""
        Me.tbPlayer.SelectedText = ""
        Me.tbPlayer.Size = New System.Drawing.Size(200, 36)
        Me.tbPlayer.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(675, 399)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 45)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Guna2Button1"
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbPlayer)
        Me.Controls.Add(Me.lbScore)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.btnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameOver"
        Me.Text = "GameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReplay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbScore As Label
    Friend WithEvents tbPlayer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
