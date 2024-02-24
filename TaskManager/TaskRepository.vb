Imports System.Data.SQLite

Public Class TaskRepository

    Private Shared ReadOnly ConnectionString As String = "Data Source=database.db;Version=3;"
    Public Shared Function GetAllTasks() As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Using command As New SQLiteCommand("SELECT * FROM Tasks", connection)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function
    Public Shared Sub AddTask(taskName As String, description As String, priority As String, dueDate As Date, status As String)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Dim query As String = "INSERT INTO Tasks (TaskName, Description, Priority, DueDate, Status) VALUES (@TaskName, @Description, @Priority, @DueDate, @Status);"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@TaskName", taskName)
                command.Parameters.AddWithValue("@Description", description)
                command.Parameters.AddWithValue("@Priority", priority)
                command.Parameters.AddWithValue("@DueDate", dueDate)
                command.Parameters.AddWithValue("@Status", status)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Shared Sub DeleteTask(TaskID As Integer)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Dim query As String = "DELETE FROM Tasks WHERE ID =@TaskID"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@TaskID", TaskID)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Shared Sub UpdateTask(TaskID As Integer, taskName As String, description As String, priority As String, dueDate As Date, status As String)
        Using connection As New SQLiteConnection(ConnectionString)
            connection.Open()
            Dim query As String = "UPDATE Tasks Set TaskName=@TaskName, Description=@Description, Priority=@Priority, dueDate=@DueDate,Status=@Status WHERE ID=@TaskID;"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@TaskID", TaskID)
                command.Parameters.AddWithValue("@TaskName", taskName)
                command.Parameters.AddWithValue("@Description", description)
                command.Parameters.AddWithValue("@Priority", priority)
                command.Parameters.AddWithValue("@DueDate", dueDate)
                command.Parameters.AddWithValue("@Status", status)
                command.ExecuteNonQuery()

            End Using
        End Using
    End Sub

End Class
