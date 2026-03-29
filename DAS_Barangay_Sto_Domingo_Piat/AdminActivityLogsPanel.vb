Public Class AdminActivityLogsPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminActivityLogsPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
    End Sub

    Private Sub LoadPlaceholderData()
        dgvActivityLogs.Rows.Clear()
        dgvActivityLogs.Rows.Add("LOG-0001", "admin", "2025-01-10 08:31", "Success", "Admin logged in successfully.")
        dgvActivityLogs.Rows.Add("LOG-0002", "jdela", "2025-01-15 09:02", "Success", "User uploaded a new document.")
        dgvActivityLogs.Rows.Add("LOG-0003", "mreyes", "2025-02-03 10:20", "Success", "User updated document DOC-0003.")
        dgvActivityLogs.Rows.Add("LOG-0004", "rsantos", "2025-02-18 14:05", "Failed", "Login attempt failed — wrong password.")
        dgvActivityLogs.Rows.Add("LOG-0005", "admin", "2025-02-20 11:10", "Success", "Admin deleted document DOC-0004.")
        dgvActivityLogs.Rows.Add("LOG-0006", "bcruz", "2025-03-01 08:45", "Success", "User logged in successfully.")
        dgvActivityLogs.Rows.Add("LOG-0007", "lgarcia", "2025-03-10 09:30", "Failed", "Login attempt failed — account inactive.")
    End Sub

End Class
