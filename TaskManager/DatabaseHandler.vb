Imports System.IO
Imports System.Data.SQLite

Public Class DatabaseHandler
    Private Shared ReadOnly DatabaseFileName As String = "database.db"
    Private Shared ReadOnly ConnectionString As String = $"Data Source={DatabaseFileName};Version=3;"
    Public Shared Sub InitializeDatabase()
        ' Check if the database file exists
        If Not File.Exists(DatabaseFileName) Then
            ' If the file doesn't exist, create a new database and table
            SQLiteConnection.CreateFile(DatabaseFileName)
            CreateTaskTable()
        End If
    End Sub
    Private Shared Sub CreateTaskTable()
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()

            Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS Tasks (
                                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                TaskName TEXT NOT NULL,
                                                Description TEXT,
                                                Priority TEXT,
                                                DueDate DATE,
                                                Status TEXT
                                              );"

            Using command As New SQLiteCommand(createTableQuery, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
