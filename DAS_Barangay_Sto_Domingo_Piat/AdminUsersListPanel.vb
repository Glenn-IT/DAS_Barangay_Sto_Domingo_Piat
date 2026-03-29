Public Class AdminUsersListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminUsersListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
    End Sub

    Private Sub LoadPlaceholderData()
        dgvUsersList.Rows.Clear()
        dgvUsersList.Rows.Add("USR-0001", "admin",    "Admin", "Active")
        dgvUsersList.Rows.Add("USR-0002", "jdela",    "User",  "Active")
        dgvUsersList.Rows.Add("USR-0003", "mreyes",   "User",  "Active")
        dgvUsersList.Rows.Add("USR-0004", "rsantos",  "User",  "Inactive")
        dgvUsersList.Rows.Add("USR-0005", "bcruz",    "User",  "Active")
        dgvUsersList.Rows.Add("USR-0006", "lgarcia",  "Admin", "Active")
        dgvUsersList.Rows.Add("USR-0007", "ptorres",  "User",  "Inactive")
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim frm As New AdminAddAccountForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If dgvUsersList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.", "Update Account",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm As New AdminUpdateAccountForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsersList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "Delete User",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm As New AdminDeleteUserForm()
        frm.ShowDialog()
    End Sub

End Class
