Imports System.Media
Imports Guna.UI2.WinForms

Public Class GamePlay
    Private speedSpam As Double = 700
    Private speedMove As Double = 20

    Private basket As PictureBox
    Public score As Integer = 0
    Private random As New Random()
    Private ball As New List(Of PictureBox)()

    Public Sub Game_Load()
        Setting.backgoundSound.Stop()

        basket = New PictureBox()
        basket.Image = My.Resources.basket
        basket.SizeMode = PictureBoxSizeMode.StretchImage
        basket.Size = New Size(200, 112)
        'basket.BackColor = Color.Transparent
        basket.Location = New Point((Me.ClientSize.Width - basket.Width) / 2, Me.ClientSize.Height - basket.Height - 10)
        Me.Controls.Add(basket)
        Me.DoubleBuffered = True

        TimerSpam.Interval = Convert.ToInt32(speedSpam)
        TimerMove.Interval = Convert.ToInt32(speedMove)
        TimerSpam.Start()
        TimerMove.Start()

        score = 0

        lblScore.Text = "Điểm : " & score.ToString()

        pnlPause.Visible = False

        btnPause.Visible = True
    End Sub


    Private Sub TimerSpam_Tick(sender As Object, e As EventArgs) Handles TimerSpam.Tick
        Dim newBall As New Guna2CirclePictureBox()

        newBall.Image = My.Resources.ball
        newBall.SizeMode = PictureBoxSizeMode.StretchImage
        newBall.Size = New Size(100, 100)

        newBall.Location = New Point(random.Next(0, Me.ClientSize.Width - newBall.Width), 0)
        Me.Controls.Add(newBall)
        ball.Add(newBall)
    End Sub



    Private Sub GamePlay_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim mouseX As Integer = e.X - (basket.Size.Width / 2)

        basket.Left = mouseX

    End Sub

    Private Sub TimerMove_Tick(sender As Object, e As EventArgs) Handles TimerMove.Tick

        For Each item As PictureBox In ball

            item.Top += 10

            If item.Bounds.IntersectsWith(basket.Bounds) Then
                Setting.hitSound.Play()
                score += 1
                lblScore.Text = "Điểm : " & score.ToString()
                speedMove *= 0.98
                speedSpam *= 0.98

                If speedMove <= 1 Then
                    speedMove = 1
                End If
                If speedSpam <= 1 Then
                    speedSpam = 1
                End If

                TimerSpam.Interval = Convert.ToInt32(speedSpam)
                TimerMove.Interval = Convert.ToInt32(speedMove)
                Me.Controls.Remove(item)
                ball.Remove(item)
                Exit For
            End If


            If item.Top >= Me.ClientSize.Height Then
                My.Computer.Audio.Play(My.Resources.hit, AudioPlayMode.Background)

                EndGame()


                GameOver.lbScore.Text = "Điểm Của Bạn là : " & score.ToString()
                Form1.SwitchForm(GameOver)

                Setting.gameOverSound.PlaySync()
                Setting.backgoundSound.PlayLooping()
                Exit For
            End If
        Next
    End Sub

    Private Sub EndGame()
        TimerSpam.Stop()
        TimerMove.Stop()
        speedSpam = 700
        speedMove = 20

        For Each item As PictureBox In ball

            Me.Controls.Remove(item)
        Next
        ball.Clear()
        Me.Controls.Remove(basket)

    End Sub


    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        TimerSpam.Stop()
        TimerMove.Stop()

        btnPause.Visible = False

        pnlPause.Visible = True
    End Sub



    Private Sub btnResume_Click_1(sender As Object, e As EventArgs) Handles btnResume.Click
        TimerSpam.Start()
        TimerMove.Start()

        pnlPause.Visible = False

        btnPause.Visible = True
    End Sub

    Private Sub btnHome_Click_1(sender As Object, e As EventArgs) Handles btnHome.Click
        EndGame()
        Form1.SwitchForm(MenuForm)
    End Sub

    Private Sub pnlPause_Paint(sender As Object, e As PaintEventArgs) Handles pnlPause.Paint

    End Sub
End Class
