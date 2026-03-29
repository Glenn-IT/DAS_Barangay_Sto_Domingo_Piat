Public Class AdminAddAccountForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminAddAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbUserType.Items.AddRange(New String() {"Admin", "User"})
        cmbUserType.SelectedIndex = 1

        cmbSecurityQuestion.Items.AddRange(New String() {
            "What is your mother's maiden name?",
            "What was the name of your first pet?",
            "What is your elementary school name?",
            "What city were you born in?",
            "What is your favorite childhood nickname?"
        })
        cmbSecurityQuestion.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text.Trim() = "" OrElse txtNewPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields.", "Add Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Add Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show("Account added successfully!", "Add Account",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
