
Imports System.Environment
Imports System.IO
Imports System.Json
Imports Newtonsoft.Json


Public Class Form1

    Dim playerPathfile As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\catch_the_ball_data.json"
    Dim content As String = "{""player"":[]}"

    Dim json As String

    Dim model As Model

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.Print("playerPathfile" & playerPathfile)
        LoadData()
        SwitchForm(MenuForm)

    End Sub



    Public Sub LoadData()

        If My.Computer.FileSystem.FileExists(playerPathfile) = False Then
            My.Computer.FileSystem.WriteAllText(playerPathfile, content, False)
        End If

        json = My.Computer.FileSystem.ReadAllText(playerPathfile)

        model = JsonConvert.DeserializeObject(Of Model)(json)
        Dim table As New DataTable

        table.Columns.Add("Tên", GetType(String))
        table.Columns.Add("Điểm", GetType(Integer))

        For Each p As Player In model.Player
            table.Rows.Add(p.Name, p.Score)
        Next

        HighScore.Guna2DataGridView1.DataSource = table
    End Sub


    Public Sub SaveData(name As String, score As Integer)
        Dim newPlayer As New Player
        newPlayer.Name = name
        newPlayer.Score = score

        model.Player.Add(newPlayer)

        json = JsonConvert.SerializeObject(model)
        My.Computer.FileSystem.WriteAllText(playerPathfile, json, False)
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
