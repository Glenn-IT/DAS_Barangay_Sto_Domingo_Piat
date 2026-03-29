Public Class UserSearchArchivePanel
    Inherits System.Windows.Forms.UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserSearchArchivePanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadPlaceholderData()
        LayoutSearchBar()
    End Sub

    Private Sub UserSearchArchivePanel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        LayoutSearchBar()
    End Sub

    Private Sub LayoutSearchBar()
        Dim margin  As Integer = 16
        Dim btnW    As Integer = 90
        Dim iconW   As Integer = 36
        Dim barH    As Integer = 32
        Dim topOff  As Integer = (pnlSearch.Height - barH) \ 2

        lblSearchIcon.SetBounds(margin, topOff, iconW, barH)
        btnSearch.SetBounds(pnlSearch.Width - margin - btnW, topOff, btnW, barH)
        txtSearchQuery.SetBounds(margin + iconW + 4, topOff,
                                 pnlSearch.Width - margin - btnW - 4 - iconW - margin - 4, barH)
    End Sub

    Private Sub LoadPlaceholderData()
        dgvSearchResults.Rows.Clear()
        dgvSearchResults.Rows.Add("DOC-0001", "Barangay Budget Report 2024",    "2024-11-15 09:00", "Approved",   "Active")
        dgvSearchResults.Rows.Add("DOC-0002", "Health Program Summary",         "2024-12-01 14:30", "For Review", "Active")
        dgvSearchResults.Rows.Add("DOC-0003", "Infrastructure Project Docs",    "2025-02-03 10:15", "Approved",   "Active")
        dgvSearchResults.Rows.Add("DOC-0004", "Solid Waste Management Plan",    "2025-01-20 08:45", "Archived",   "Archived")
        dgvSearchResults.Rows.Add("DOC-0005", "Livelihood Program 2025",        "2025-03-05 11:00", "For Review", "Active")
        dgvSearchResults.Rows.Add("DOC-0006", "Barangay Assembly Minutes — Q1", "2025-03-12 13:00", "Approved",   "Active")
        dgvSearchResults.Rows.Add("DOC-0007", "Disaster Risk Reduction Plan",   "2025-03-20 09:30", "For Review", "Active")
    End Sub

    Private Sub FilterResults(query As String)
        LoadPlaceholderData()
        If query.Trim() = "" Then Return
        Dim q As String = query.Trim().ToLower()
        For i As Integer = dgvSearchResults.Rows.Count - 1 To 0 Step -1
            Dim row As DataGridViewRow = dgvSearchResults.Rows(i)
            Dim match As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(q) Then
                    match = True : Exit For
                End If
            Next
            If Not match Then dgvSearchResults.Rows.RemoveAt(i)
        Next
    End Sub

    ' Real-time search as user types
    Private Sub txtSearchQuery_TextChanged(sender As Object, e As EventArgs) Handles txtSearchQuery.TextChanged
        FilterResults(txtSearchQuery.Text)
    End Sub

    ' Button search (also works)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FilterResults(txtSearchQuery.Text)
    End Sub

End Class
