Imports Microsoft.Data.SqlClient

''' <summary>
''' Shared helper — writes a row to tbl_ActivityLogs.
''' Call this after every login attempt (success or failure).
''' </summary>
Public Class ActivityLogger

    Public Shared Sub Log(username As String,
                          result As String,
                          description As String)
        Try
            Using con As New SqlConnection(dbconstring.Connection)
                con.Open()

                ' Generate next LogCode (LOG-0001, LOG-0002, …)
                Dim logCode As String = "LOG-0001"
                Dim cmdCode As New SqlCommand(
                    "SELECT TOP 1 LogCode FROM tbl_ActivityLogs ORDER BY LogID DESC", con)
                Dim lastCode As Object = cmdCode.ExecuteScalar()
                If lastCode IsNot Nothing AndAlso lastCode IsNot DBNull.Value Then
                    Dim lastNum As Integer = Integer.Parse(lastCode.ToString().Replace("LOG-", ""))
                    logCode = "LOG-" & (lastNum + 1).ToString("D4")
                End If

                Dim sql As String =
                    "INSERT INTO tbl_ActivityLogs (LogCode, Username, LogDate, Result, Description) " &
                    "VALUES (@LogCode, @Username, GETDATE(), @Result, @Description)"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@LogCode",     logCode)
                    cmd.Parameters.AddWithValue("@Username",    username)
                    cmd.Parameters.AddWithValue("@Result",      result)
                    cmd.Parameters.AddWithValue("@Description", description)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch
            ' Logging failure should never crash the app — silently swallow
        End Try
    End Sub

End Class
