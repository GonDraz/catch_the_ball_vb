
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchForm(MenuForm)
    End Sub

    Public Sub Quit()
        GamePlay.Close()
        GameOver.Close()
        HighScore.Close()
        MenuForm.Close()
        Me.Close()
    End Sub

    Public Sub SwitchForm(form As Form)
        pnlMain.Controls.Clear()
        form.TopLevel = False
        pnlMain.Controls.Add(form)
        form.Show()
    End Sub
End Class
