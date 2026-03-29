Public Class AdminUpdateAccountForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUpdateAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbUserType.Items.AddRange(New String() {"Admin", "User"})
        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })

        ' Pre-fill with placeholder selected user data
        txtUsername.Text            = "jdela"
        cmbUserType.SelectedItem    = "User"
        cmbSecurityQuestion.SelectedIndex = 1
        txtSecurityAnswer.Text      = "Brownie"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtNewPassword.Text.Trim() <> "" AndAlso txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Account updated successfully!", "Update Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
