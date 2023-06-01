Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class Model
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource
    Private dbName As String = "database.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private connString As String = "Data Source=" & dbPath & ";Verison =3"
    Private connection As New SQLiteConnection(connString)
    Private command As New SQLiteCommand("", connection)


    Dim table As New DataTable

    Public Sub Load()
        connection.Open()

        If connection.State = ConnectionState.Open Then
            command.Connection = connection
            command.CommandText = "SELECT * FROM player"
            Try
                command.ExecuteNonQuery()
            Catch ex As Exception
                Dim createTableQuery As String = " CREATE TABLE player (id INTEGER PRIMARY KEY NOT NULL UNIQUE, name TEXT NOT NULL, score INTEGER   );"
                command.CommandText = createTableQuery
                command.ExecuteNonQuery()
            Finally
                command.CommandText = "SELECT * FROM player"
                Dim rdr As SQLiteDataReader = command.ExecuteReader

                table.Load(rdr)
                HighScore.Guna2DataGridView1.DataSource = table
            End Try
        End If


        connection.Close()



    End Sub


    Public Sub SaveData(name As String, score As Integer)

        Debug.Print("name : " & name)
        Debug.Print("score : " & score)

        Try
            Dim con As New SQLiteConnection(connString)
            Dim cmd As New SQLiteCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into player(name,score) values (@name,@score)"
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@score", score)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class
