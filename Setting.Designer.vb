<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.imgLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnBackToMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBatTat = New System.Windows.Forms.Button()
        Me.btnTang = New System.Windows.Forms.Button()
        Me.btnGiam = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.FillColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.catch_the_ball_vb.My.Resources.Resources.setting1
        Me.imgLogo.ImageRotate = 0!
        Me.imgLogo.Location = New System.Drawing.Point(444, 74)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(391, 143)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogo.TabIndex = 2
        Me.imgLogo.TabStop = False
        '
        'btnBackToMenu
        '
        Me.btnBackToMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackToMenu.AutoRoundedCorners = True
        Me.btnBackToMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnBackToMenu.BorderRadius = 20
        Me.btnBackToMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackToMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackToMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackToMenu.FillColor = System.Drawing.Color.Black
        Me.btnBackToMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnBackToMenu.ForeColor = System.Drawing.Color.White
        Me.btnBackToMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnBackToMenu.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnBackToMenu.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnBackToMenu.Location = New System.Drawing.Point(496, 596)
        Me.btnBackToMenu.Name = "btnBackToMenu"
        Me.btnBackToMenu.Size = New System.Drawing.Size(287, 42)
        Me.btnBackToMenu.TabIndex = 16
        Me.btnBackToMenu.Text = "MÀN HÌNH CHÍNH"
        '
        'btnBatTat
        '
        Me.btnBatTat.Location = New System.Drawing.Point(496, 323)
        Me.btnBatTat.Name = "btnBatTat"
        Me.btnBatTat.Size = New System.Drawing.Size(75, 23)
        Me.btnBatTat.TabIndex = 17
        Me.btnBatTat.Text = "Bật Tắt Âm"
        Me.btnBatTat.UseVisualStyleBackColor = True
        '
        'btnTang
        '
        Me.btnTang.Location = New System.Drawing.Point(496, 374)
        Me.btnTang.Name = "btnTang"
        Me.btnTang.Size = New System.Drawing.Size(75, 23)
        Me.btnTang.TabIndex = 20
        Me.btnTang.Text = "Tăng Âm"
        Me.btnTang.UseVisualStyleBackColor = True
        '
        'btnGiam
        '
        Me.btnGiam.Location = New System.Drawing.Point(496, 430)
        Me.btnGiam.Name = "btnGiam"
        Me.btnGiam.Size = New System.Drawing.Size(75, 23)
        Me.btnGiam.TabIndex = 21
        Me.btnGiam.Text = "Giảm Âm"
        Me.btnGiam.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnGiam)
        Me.Controls.Add(Me.btnTang)
        Me.Controls.Add(Me.btnBatTat)
        Me.Controls.Add(Me.btnBackToMenu)
        Me.Controls.Add(Me.imgLogo)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Setting"
        Me.Text = "Setting"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents imgLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnBackToMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTang As Button
    Friend WithEvents btnBatTat As Button
    Friend WithEvents btnGiam As Button
End Class
