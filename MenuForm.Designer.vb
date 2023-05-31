<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.imgLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnPlay = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHighScore = New Guna.UI2.WinForms.Guna2Button()
        Me.btnQuit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.FillColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.catch_the_ball_vb.My.Resources.Resources.logo
        Me.imgLogo.ImageRotate = 0!
        Me.imgLogo.Location = New System.Drawing.Point(395, 72)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(517, 199)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(539, 447)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(180, 69)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        '
        'btnHighScore
        '
        Me.btnHighScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHighScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHighScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHighScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHighScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHighScore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHighScore.ForeColor = System.Drawing.Color.White
        Me.btnHighScore.Location = New System.Drawing.Point(539, 533)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(180, 69)
        Me.btnHighScore.TabIndex = 3
        Me.btnHighScore.Text = "High Score"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(539, 625)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(180, 69)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "T"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnHighScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPlay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHighScore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuit As Guna.UI2.WinForms.Guna2Button
End Class
