Public Class AdminArchiveListPanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AdminArchiveListPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
        LayoutSearchBar()
    End Sub

    Private Sub AdminArchiveListPanel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutSearchBar()
    End Sub

    Private Sub LayoutSearchBar()
        Dim margin As Integer = 16
        Dim btnW   As Integer = 90
        Dim iconW  As Integer = 36
        Dim barH   As Integer = 32
        Dim topOff As Integer = (pnlSearch.Height - barH) \ 2


        btnSearch.SetBounds(pnlSearch.Width - margin - btnW, topOff, btnW, barH)
        txtSearch.SetBounds(margin + iconW + 4, topOff,
                            pnlSearch.Width - margin - btnW - 4 - iconW - margin - 4, barH)
    End Sub

    Private Sub LoadPlaceholderData()
        dgvArchiveList.Rows.Clear()
        dgvArchiveList.Rows.Add("DOC-0001", "Barangay Resolution No. 01",  "admin",   "2025-01-10 08:30", "Active")
        dgvArchiveList.Rows.Add("DOC-0002", "Community Development Plan",   "jdela",   "2025-01-15 09:00", "Active")
        dgvArchiveList.Rows.Add("DOC-0003", "Infrastructure Project Docs",  "mreyes",  "2025-02-03 10:15", "Active")
        dgvArchiveList.Rows.Add("DOC-0004", "Health Program Report 2024",   "admin",   "2025-02-20 11:00", "Archived")
        dgvArchiveList.Rows.Add("DOC-0005", "Livelihood Program Proposal",  "rsantos", "2025-03-05 14:30", "Active")
        dgvArchiveList.Rows.Add("DOC-0006", "Solid Waste Management Plan",  "jdela",   "2025-03-18 09:45", "Archived")
        dgvArchiveList.Rows.Add("DOC-0007", "Barangay Budget FY 2025",      "admin",   "2025-04-01 08:00", "Active")
    End Sub

    Private Sub FilterArchive(query As String)
        LoadPlaceholderData()
        If query.Trim() = "" Then Return
        Dim q As String = query.Trim().ToLower()
        For i As Integer = dgvArchiveList.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dgvArchiveList.Rows(i)
            Dim match As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(q) Then
                    match = True : Exit For
                End If
            Next
            If Not match Then dgvArchiveList.Rows.RemoveAt(i)
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        FilterArchive(txtSearch.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterArchive(txtSearch.Text)
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
