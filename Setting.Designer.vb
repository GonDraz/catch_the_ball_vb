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
        Me.btnOnOff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTurnUp = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTurnDown = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'btnOnOff
        '
        Me.btnOnOff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOnOff.AutoRoundedCorners = True
        Me.btnOnOff.BorderRadius = 11
        Me.btnOnOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOnOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOnOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOnOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOnOff.FillColor = System.Drawing.Color.Black
        Me.btnOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnOnOff.ForeColor = System.Drawing.Color.White
        Me.btnOnOff.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnOnOff.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnOnOff.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnOnOff.Location = New System.Drawing.Point(656, 377)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.Size = New System.Drawing.Size(54, 25)
        Me.btnOnOff.TabIndex = 22
        Me.btnOnOff.Text = "Bật Tắt"
        '
        'btnTurnUp
        '
        Me.btnTurnUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTurnUp.AutoRoundedCorners = True
        Me.btnTurnUp.BorderRadius = 11
        Me.btnTurnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTurnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTurnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTurnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTurnUp.FillColor = System.Drawing.Color.Black
        Me.btnTurnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnTurnUp.ForeColor = System.Drawing.Color.White
        Me.btnTurnUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTurnUp.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTurnUp.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTurnUp.Location = New System.Drawing.Point(665, 346)
        Me.btnTurnUp.Name = "btnTurnUp"
        Me.btnTurnUp.Size = New System.Drawing.Size(36, 25)
        Me.btnTurnUp.TabIndex = 23
        Me.btnTurnUp.Text = "+"
        '
        'btnTurnDown
        '
        Me.btnTurnDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTurnDown.AutoRoundedCorners = True
        Me.btnTurnDown.BorderRadius = 11
        Me.btnTurnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTurnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTurnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTurnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTurnDown.FillColor = System.Drawing.Color.Black
        Me.btnTurnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnTurnDown.ForeColor = System.Drawing.Color.White
        Me.btnTurnDown.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTurnDown.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnTurnDown.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnTurnDown.Location = New System.Drawing.Point(665, 408)
        Me.btnTurnDown.Name = "btnTurnDown"
        Me.btnTurnDown.Size = New System.Drawing.Size(36, 25)
        Me.btnTurnDown.TabIndex = 24
        Me.btnTurnDown.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(406, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 46)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Âm thanh :"
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTurnDown)
        Me.Controls.Add(Me.btnTurnUp)
        Me.Controls.Add(Me.btnOnOff)
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
    Friend WithEvents btnTurnDown As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTurnUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOnOff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
