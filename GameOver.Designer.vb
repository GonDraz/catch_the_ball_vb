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
        Me.lbScore = New System.Windows.Forms.Label()
        Me.tbPlayer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReplay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbScore
        '
        Me.lbScore.AutoSize = True
        Me.lbScore.BackColor = System.Drawing.Color.Transparent
        Me.lbScore.Font = New System.Drawing.Font("FS Angry Birds Movie", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore.Location = New System.Drawing.Point(478, 302)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(324, 52)
        Me.lbScore.TabIndex = 4
        Me.lbScore.Text = "ĐIỂM CỦA BẠN LÀ :"
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
        Me.tbPlayer.Location = New System.Drawing.Point(488, 409)
        Me.tbPlayer.Name = "tbPlayer"
        Me.tbPlayer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPlayer.PlaceholderText = ""
        Me.tbPlayer.SelectedText = ""
        Me.tbPlayer.Size = New System.Drawing.Size(305, 42)
        Me.tbPlayer.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 20
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.Black
        Me.btnSave.Font = New System.Drawing.Font("FS Angry Birds Movie", 11.25!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnSave.Location = New System.Drawing.Point(823, 409)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(156, 42)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "LƯU ĐIỂM"
        '
        'btnReplay
        '
        Me.btnReplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReplay.AutoRoundedCorners = True
        Me.btnReplay.BackColor = System.Drawing.Color.Transparent
        Me.btnReplay.BorderRadius = 20
        Me.btnReplay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReplay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReplay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReplay.FillColor = System.Drawing.Color.Black
        Me.btnReplay.Font = New System.Drawing.Font("FS Angry Birds Movie", 11.25!)
        Me.btnReplay.ForeColor = System.Drawing.Color.White
        Me.btnReplay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReplay.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnReplay.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnReplay.Location = New System.Drawing.Point(517, 502)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(246, 42)
        Me.btnReplay.TabIndex = 15
        Me.btnReplay.Text = "CHƠI LẠI"
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.AutoRoundedCorners = True
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BorderRadius = 20
        Me.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenu.FillColor = System.Drawing.Color.Black
        Me.btnMenu.Font = New System.Drawing.Font("FS Angry Birds Movie", 11.25!)
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMenu.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnMenu.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnMenu.Location = New System.Drawing.Point(517, 564)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(246, 42)
        Me.btnMenu.TabIndex = 16
        Me.btnMenu.Text = "MÀN HÌNH CHÍNH"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.catch_the_ball_vb.My.Resources.Resources.gameover
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(334, 39)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(612, 202)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.tbPlayer)
        Me.Controls.Add(Me.lbScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GameOver"
        Me.Text = "GameOver"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbScore As Label
    Friend WithEvents tbPlayer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReplay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
