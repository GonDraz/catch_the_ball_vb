Public Class Setting
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackToMenu_Click(sender As Object, e As EventArgs) Handles btnBackToMenu.Click
        Form1.SwitchForm(MenuForm)
    End Sub
End Class