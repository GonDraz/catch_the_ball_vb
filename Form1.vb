Imports Guna.UI2.WinForms



Public Class Form1
    Private speedMove As Double = 5
    Private speedSpam As Double = 700


    Private basket As PictureBox
    Private score As Integer = 0
    Private random As New Random()
    Private ball As New List(Of PictureBox)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        basket = New PictureBox()
        basket.Image = My.Resources.basket
        basket.SizeMode = PictureBoxSizeMode.StretchImage
        basket.Size = New Size(200, 112)
        'basket.BackColor = Color.Transparent
        basket.Location = New Point((Me.ClientSize.Width - basket.Width) / 2, Me.ClientSize.Height - basket.Height - 10)
        Me.Controls.Add(basket)
        Me.DoubleBuffered = True
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        TimerSpam.Interval = Convert.ToInt32(speedSpam)
        TimerSpam.Start()
        TimerMove.Start()

        imgLogo.Visible = False
        btnPlay.Visible = False
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




    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim mouseX As Integer = e.X - (basket.Size.Width / 2)

        basket.Left = mouseX

    End Sub

    Private Sub TimerMove_Tick(sender As Object, e As EventArgs) Handles TimerMove.Tick

        For Each item As PictureBox In ball
            item.Top += Convert.ToInt32(speedMove)

            If item.Bounds.IntersectsWith(basket.Bounds) Then
                score += 1
                lblScore.Text = "Score : " & score.ToString()
                speedMove *= 1.05
                speedSpam *= 0.98
                If speedSpam <= 300 Then
                    speedSpam = 300
                End If
                TimerSpam.Interval = Convert.ToInt32(speedSpam)
                Me.Controls.Remove(item)
                ball.Remove(item)
                Exit For
            End If

            If item.Top >= Me.ClientSize.Height Then
                EndGame()
                Exit For
            End If
        Next
    End Sub


    Private Sub EndGame()
        TimerSpam.Stop()
        TimerMove.Stop()
        speedMove = 5
        speedSpam = 700


        imgLogo.Visible = True
        btnPlay.Visible = True
        For Each item As PictureBox In ball
            Me.Controls.Remove(item)
        Next
        ball.Clear()
    End Sub


End Class
