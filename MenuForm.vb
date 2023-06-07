Imports System.Media

Public Class MenuForm


    Private Sub btnPlay_Click_1(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form1.SwitchForm(GamePlay)
        GamePlay.Game_Load()
    End Sub

    Private Sub btnHighScore_Click_1(sender As Object, e As EventArgs) Handles btnHighScore.Click
        Form1.LoadData()

        Form1.SwitchForm(HighScore)
    End Sub

    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click


        Form1.Quit()


    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        Form1.SwitchForm(Setting)

    End Sub


End Class

