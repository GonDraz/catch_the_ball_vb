﻿Public Class GameOver

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If tbPlayer.Text = "" Then
            MsgBox("vui lòng điền đầy đủ thông tin!")
        Else

            Form1.SaveData(tbPlayer.Text, GamePlay.score)
            Form1.SwitchForm(MenuForm)
            Setting.saveSound.PlaySync()
            MsgBox("Đã Lưu thông tin!")
            Setting.backgoundSound.PlayLooping()
        End If
    End Sub

    Private Sub btnReplay_Click_1(sender As Object, e As EventArgs) Handles btnReplay.Click
        Form1.SwitchForm(GamePlay)

        GamePlay.Game_Load()
    End Sub

    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        Form1.SwitchForm(MenuForm)
    End Sub


End Class