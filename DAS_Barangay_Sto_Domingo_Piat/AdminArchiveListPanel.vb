Public Class AdminArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
    End Sub

    Private Sub LoadPlaceholderData()
        dgvArchiveList.Rows.Clear()
        dgvArchiveList.Rows.Add("DOC-0001", "Barangay Resolution No. 01",  "admin",     "2025-01-10 08:30", "Active")
        dgvArchiveList.Rows.Add("DOC-0002", "Community Development Plan",   "jdela",     "2025-01-15 09:00", "Active")
        dgvArchiveList.Rows.Add("DOC-0003", "Infrastructure Project Docs",  "mreyes",    "2025-02-03 10:15", "Active")
        dgvArchiveList.Rows.Add("DOC-0004", "Health Program Report 2024",   "admin",     "2025-02-20 11:00", "Archived")
        dgvArchiveList.Rows.Add("DOC-0005", "Livelihood Program Proposal",  "rsantos",   "2025-03-05 14:30", "Active")
        dgvArchiveList.Rows.Add("DOC-0006", "Solid Waste Management Plan",  "jdela",     "2025-03-18 09:45", "Archived")
        dgvArchiveList.Rows.Add("DOC-0007", "Barangay Budget FY 2025",      "admin",     "2025-04-01 08:00", "Active")
    End Sub

    Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
        Dim frm As New AdminNewDocumentForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnUpdateDocument_Click(sender As Object, e As EventArgs) Handles btnUpdateDocument.Click
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to update.", "Update Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm As New AdminUpdateDocumentForm()
        frm.ShowDialog()
    End Sub

    Private Sub btnDeleteDocument_Click(sender As Object, e As EventArgs) Handles btnDeleteDocument.Click
        If dgvArchiveList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a document to delete.", "Delete Document",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim frm As New AdminDeleteDocumentForm()
        frm.ShowDialog()
    End Sub

End Class
