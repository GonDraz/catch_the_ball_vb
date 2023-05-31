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
        Me.btnResume = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlPause.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPause.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPause.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPause.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPause.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(19, 88)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(138, 35)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Pause"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 48)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(145, 37)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "Score : 0"
        '
        'TimerSpam
        '
        '
        'TimerMove
        '
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPause.Controls.Add(Me.btnHome)
        Me.pnlPause.Controls.Add(Me.btnResume)
        Me.pnlPause.Location = New System.Drawing.Point(300, 107)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(700, 400)
        Me.pnlPause.TabIndex = 11
        '
        'btnResume
        '
        Me.btnResume.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResume.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResume.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResume.ForeColor = System.Drawing.Color.White
        Me.btnResume.Location = New System.Drawing.Point(240, 116)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(180, 45)
        Me.btnResume.TabIndex = 0
        Me.btnResume.Text = "Resume"
        '
        'btnHome
        '
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(240, 200)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(180, 45)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
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
