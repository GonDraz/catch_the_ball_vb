Public Class GameOver
    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        Form1.SwitchForm(GamePlay)

        GamePlay.Game_Load()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.SwitchForm(MenuForm)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Debug.Print("name : " & tbPlayer.Text)
        Debug.Print("GamePlay.score: " & GamePlay.score.ToString)

        'save file
    End Sub
End Class