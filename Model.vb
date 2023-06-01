Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class Model
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource
    Private dbName As String = "database.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & "; Version=3 ;PRAGMA legacy_file_format = TRUE; Integrated Security=true"
    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)

    Dim table As New DataTable

    Public Sub Load()
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT * FROM player"
            Dim rdr As SQLiteDataReader = command.ExecuteReader

            table.Load(rdr)
            HighScore.Guna2DataGridView1.DataSource = table
        End If
        connection.Close()
    End Sub


    Public Sub SaveData(name As String, score As Integer)
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "insert into player(name,score) values (@name,@score)"
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@score", score)
            command.ExecuteNonQuery()
        End If
        connection.Close()

    End Sub

End Class
