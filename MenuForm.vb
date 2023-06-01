Public Class MenuForm
    Private md As New Model
    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form1.SwitchForm(GamePlay)
        GamePlay.Game_Load()
    End Sub

    Private Sub btnHighScore_Click_1(sender As Object, e As EventArgs) Handles btnHighScore.Click
        md.Load()

        Form1.SwitchForm(HighScore)
    End Sub

    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        Form1.Quit()
    End Sub
End Class

