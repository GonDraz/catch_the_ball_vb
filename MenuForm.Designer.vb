﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnSetting = New Guna.UI2.WinForms.Guna2Button()
        Me.haiha = New System.Windows.Forms.LinkLabel()
        Me.haidang = New System.Windows.Forms.LinkLabel()
        Me.duc = New System.Windows.Forms.LinkLabel()
        Me.binh = New System.Windows.Forms.LinkLabel()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.FillColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.catch_the_ball_vb.My.Resources.Resources.logo
        Me.imgLogo.ImageRotate = 0!
        Me.imgLogo.Location = New System.Drawing.Point(369, 71)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(542, 199)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.AutoRoundedCorners = True
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BorderRadius = 33
        Me.btnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPlay.FillColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPlay.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnPlay.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnPlay.Location = New System.Drawing.Point(545, 327)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(190, 69)
        Me.btnPlay.TabIndex = 15
        Me.btnPlay.Text = "CHƠI"
        '
        'btnHighScore
        '
        Me.btnHighScore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHighScore.AutoRoundedCorners = True
        Me.btnHighScore.BackColor = System.Drawing.Color.Transparent
        Me.btnHighScore.BorderRadius = 33
        Me.btnHighScore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHighScore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHighScore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHighScore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHighScore.FillColor = System.Drawing.Color.Black
        Me.btnHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.ForeColor = System.Drawing.Color.White
        Me.btnHighScore.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHighScore.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnHighScore.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnHighScore.Location = New System.Drawing.Point(545, 521)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(190, 69)
        Me.btnHighScore.TabIndex = 16
        Me.btnHighScore.Text = "ĐIỂM CAO"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.AutoRoundedCorners = True
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BorderRadius = 33
        Me.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnQuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnQuit.FillColor = System.Drawing.Color.Black
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnQuit.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnQuit.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnQuit.Location = New System.Drawing.Point(545, 618)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(190, 69)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.Text = "THOÁT"
        '
        'btnSetting
        '
        Me.btnSetting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSetting.AutoRoundedCorners = True
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BorderRadius = 33
        Me.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSetting.FillColor = System.Drawing.Color.Black
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSetting.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnSetting.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnSetting.Location = New System.Drawing.Point(545, 424)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(190, 69)
        Me.btnSetting.TabIndex = 18
        Me.btnSetting.Text = "CÀI ĐẶT"
        '
        'haiha
        '
        Me.haiha.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.haiha.AutoSize = True
        Me.haiha.BackColor = System.Drawing.Color.Transparent
        Me.haiha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.haiha.LinkColor = System.Drawing.Color.Black
        Me.haiha.Location = New System.Drawing.Point(1104, 584)
        Me.haiha.Name = "haiha"
        Me.haiha.Size = New System.Drawing.Size(161, 24)
        Me.haiha.TabIndex = 19
        Me.haiha.TabStop = True
        Me.haiha.Text = "Vũ Ngọc Hải Hà"
        '
        'haidang
        '
        Me.haidang.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.haidang.AutoSize = True
        Me.haidang.BackColor = System.Drawing.Color.Transparent
        Me.haidang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.haidang.LinkColor = System.Drawing.Color.Black
        Me.haidang.Location = New System.Drawing.Point(1104, 618)
        Me.haidang.Name = "haidang"
        Me.haidang.Size = New System.Drawing.Size(164, 24)
        Me.haidang.TabIndex = 20
        Me.haidang.TabStop = True
        Me.haidang.Text = "Dương Hải Đăng"
        '
        'duc
        '
        Me.duc.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.duc.AutoSize = True
        Me.duc.BackColor = System.Drawing.Color.Transparent
        Me.duc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duc.LinkColor = System.Drawing.Color.Black
        Me.duc.Location = New System.Drawing.Point(1104, 653)
        Me.duc.Name = "duc"
        Me.duc.Size = New System.Drawing.Size(170, 24)
        Me.duc.TabIndex = 21
        Me.duc.TabStop = True
        Me.duc.Text = "Nguyễn Anh Đức"
        '
        'binh
        '
        Me.binh.ActiveLinkColor = System.Drawing.Color.Aqua
        Me.binh.AutoSize = True
        Me.binh.BackColor = System.Drawing.Color.Transparent
        Me.binh.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.binh.LinkColor = System.Drawing.Color.Black
        Me.binh.Location = New System.Drawing.Point(1104, 686)
        Me.binh.Name = "binh"
        Me.binh.Size = New System.Drawing.Size(147, 24)
        Me.binh.TabIndex = 22
        Me.binh.TabStop = True
        Me.binh.Text = "Lê Thanh Bình"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.binh)
        Me.Controls.Add(Me.duc)
        Me.Controls.Add(Me.haidang)
        Me.Controls.Add(Me.haiha)
        Me.Controls.Add(Me.btnSetting)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnPlay As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHighScore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSetting As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents haiha As LinkLabel
    Friend WithEvents haidang As LinkLabel
    Friend WithEvents duc As LinkLabel
    Friend WithEvents binh As LinkLabel
End Class
