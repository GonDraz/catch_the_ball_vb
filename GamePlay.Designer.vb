<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamePlay
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
        Me.components = New System.ComponentModel.Container()
        Me.btnPause = New Guna.UI2.WinForms.Guna2Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.TimerSpam = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMove = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPause = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResume = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlPause.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.AutoRoundedCorners = True
        Me.btnPause.BorderRadius = 20
        Me.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPause.FillColor = System.Drawing.Color.Black
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPause.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnPause.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnPause.Location = New System.Drawing.Point(36, 111)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(127, 42)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Tạm dừng"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(36, 41)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(136, 37)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "Điểm : 0"
        '
        'TimerSpam
        '
        '
        'TimerMove
        '
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.Color.Transparent
        Me.pnlPause.BackgroundImage = Global.catch_the_ball_vb.My.Resources.Resources.background
        Me.pnlPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPause.Controls.Add(Me.btnHome)
        Me.pnlPause.Controls.Add(Me.btnResume)
        Me.pnlPause.Location = New System.Drawing.Point(285, 152)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(700, 400)
        Me.pnlPause.TabIndex = 11
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHome.AutoRoundedCorners = True
        Me.btnHome.BorderRadius = 20
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.Black
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnHome.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnHome.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnHome.Location = New System.Drawing.Point(271, 220)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(156, 42)
        Me.btnHome.TabIndex = 13
        Me.btnHome.Text = "màn hình chính"
        '
        'btnResume
        '
        Me.btnResume.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResume.AutoRoundedCorners = True
        Me.btnResume.BorderRadius = 20
        Me.btnResume.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResume.FillColor = System.Drawing.Color.Black
        Me.btnResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResume.HoverState.CustomBorderColor = System.Drawing.Color.Black
        Me.btnResume.HoverState.FillColor = System.Drawing.Color.Gray
        Me.btnResume.Location = New System.Drawing.Point(286, 163)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(127, 42)
        Me.btnResume.TabIndex = 12
        Me.btnResume.Text = "TIẾP TỤC"
        '
        'GamePlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.pnlPause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GamePlay"
        Me.Text = "GamePlay"
        Me.pnlPause.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPause As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblScore As Label
    Friend WithEvents TimerSpam As Timer
    Friend WithEvents TimerMove As Timer
    Friend WithEvents pnlPause As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnResume As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
End Class
