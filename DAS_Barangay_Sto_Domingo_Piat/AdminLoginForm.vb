Imports Microsoft.Data.SqlClient

Public Class AdminLoginForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim username As String = txtAdminUsername.Text.Trim()
        Dim password As String = txtAdminPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Admin Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(dbconstring.Connection)
                con.Open()

                Dim sql As String =
                    "SELECT UserCode, UserType, Status FROM tbl_Users " &
                    "WHERE Username = @Username AND PasswordHash = @Password AND UserType = 'Admin'"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim status As String = reader("Status").ToString()

                            If status = "Inactive" Then
                                reader.Close()
                                ActivityLogger.Log(username, "Failed",
                                    "Admin login failed — account is inactive.")
                                MessageBox.Show("Your account is inactive. Please contact the system administrator.",
                                                "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Store session
                            SessionManager.Username = username
                            SessionManager.UserType = reader("UserType").ToString()
                            SessionManager.UserCode = reader("UserCode").ToString()
                            reader.Close()

                            ActivityLogger.Log(username, "Success", "Admin logged in successfully.")

                            Dim dashboard As New AdminDashboardForm()
                            Me.Hide()
                            dashboard.ShowDialog()
                            Me.Show()
                            SessionManager.Clear()
                            txtAdminUsername.Clear()
                            txtAdminPassword.Clear()
                            txtAdminUsername.Focus()
                        Else
                            reader.Close()
                            ActivityLogger.Log(username, "Failed",
                                "Admin login failed — invalid username or password.")
                            MessageBox.Show("Invalid username or password.",
                                            "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message,
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdminForgotPassword_Click(sender As Object, e As EventArgs) Handles btnAdminForgotPassword.Click
        Dim forgotPw As New AdminForgotPasswordForm()
        Me.Hide()
        forgotPw.ShowDialog()
        Me.Show()
    End Sub

End Class
