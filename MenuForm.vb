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

    Private Sub haiha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haiha.LinkClicked
        Process.Start("https://linktr.ee/gondraz")
    End Sub
    Private Sub haidang_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles haidang.LinkClicked
        Process.Start("https://www.facebook.com/100030858582028")
    End Sub
    Private Sub duc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles duc.LinkClicked
        Process.Start("https://www.facebook.com/profile.php?id=100050403167759")
    End Sub
    Private Sub binh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles binh.LinkClicked
        Process.Start("https://www.facebook.com/100086835542617")
    End Sub

End Class

