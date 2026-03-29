Public Class AdminForgotPasswordForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Populate security questions
        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is the name of the city where you were born?",
            "What was the name of your elementary school?",
            "What is your favorite childhood nickname?"
        })
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim answer As String = txtSecurityAnswer.Text.Trim()
        Dim newPass As String = txtNewPassword.Text.Trim()
        Dim confirmPass As String = txtConfirmPassword.Text.Trim()

        If answer = "" OrElse newPass = "" OrElse confirmPass = "" Then
            MessageBox.Show("Please fill in all fields.", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("Passwords do not match. Please try again.", "Forgot Password",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Placeholder success — no backend logic
        MessageBox.Show("Password has been reset successfully!", "Forgot Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim loginForm As New AdminLoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        Dim loginForm As New AdminLoginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class
