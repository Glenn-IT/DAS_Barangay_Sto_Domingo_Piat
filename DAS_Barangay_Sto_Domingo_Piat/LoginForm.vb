Imports Microsoft.Data.SqlClient

Public Class LoginForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con As New SqlConnection(dbconstring.Connection)
                con.Open()

                Dim sql As String =
                    "SELECT UserCode, UserType, Status FROM tbl_Users " &
                    "WHERE Username = @Username AND PasswordHash = @Password"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim userType As String = reader("UserType").ToString()
                            Dim status   As String = reader("Status").ToString()

                            If status = "Inactive" Then
                                reader.Close()
                                ActivityLogger.Log(username, "Failed",
                                    $"{userType} login failed — account is inactive.")
                                MessageBox.Show("Your account is inactive. Please contact the system administrator.",
                                                "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Store session
                            SessionManager.Username = username
                            SessionManager.UserType  = userType
                            SessionManager.UserCode  = reader("UserCode").ToString()
                            reader.Close()

                            ActivityLogger.Log(username, "Success",
                                $"{userType} logged in successfully.")

                            Me.Hide()

                            If userType = "Admin" Then
                                Dim dashboard As New AdminDashboardForm()
                                dashboard.ShowDialog()
                            Else
                                Dim dashboard As New UserDashboardForm()
                                dashboard.ShowDialog()
                            End If

                            SessionManager.Clear()
                            Me.Show()
                            txtUsername.Clear()
                            txtPassword.Clear()
                            txtUsername.Focus()
                        Else
                            reader.Close()
                            ActivityLogger.Log(username, "Failed",
                                "Login failed — invalid username or password.")
                            MessageBox.Show("Invalid username or password.",
                                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message,
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim forgotPw As New AdminForgotPasswordForm()
        Me.Hide()
        forgotPw.ShowDialog()
        Me.Show()
    End Sub

    ' Allow pressing Enter on the password field to trigger login
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

End Class
