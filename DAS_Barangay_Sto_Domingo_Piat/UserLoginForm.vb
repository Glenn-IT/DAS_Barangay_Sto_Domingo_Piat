Public Class UserLoginForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        Dim username As String = txtUserUsername.Text.Trim()
        Dim password As String = txtUserPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter your username and password.", "Login",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dashboard As New UserDashboardForm()
        Me.Hide()
        dashboard.ShowDialog()
        Me.Show()
        txtUserUsername.Clear()
        txtUserPassword.Clear()
        txtUserUsername.Focus()
    End Sub

    Private Sub btnUserForgotPassword_Click(sender As Object, e As EventArgs) Handles btnUserForgotPassword.Click
        Dim forgotPw As New UserForgotPasswordForm()
        Me.Hide()
        forgotPw.ShowDialog()
        Me.Show()
    End Sub

End Class
