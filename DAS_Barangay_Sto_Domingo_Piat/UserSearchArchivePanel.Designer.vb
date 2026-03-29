<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSearchArchivePanel
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvSearchResults = New System.Windows.Forms.DataGridView()
        colDocID         = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDocTitle      = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDateTime      = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colRemarks       = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colStatus        = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlTop           = New System.Windows.Forms.Panel()
        lblTitle         = New System.Windows.Forms.Label()
        pnlSearch        = New System.Windows.Forms.Panel()
        txtSearchQuery   = New System.Windows.Forms.TextBox()
        btnSearch        = New System.Windows.Forms.Button()
        lblSearchIcon    = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)

        ' ?? pnlTop (title bar) ????????????????????????????????????
        pnlTop.BackColor = mid
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Search Archive"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill
        lblTitle.Padding   = New System.Windows.Forms.Padding(16, 0, 0, 0)
        lblTitle.Name      = "lblTitle"

        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlSearch (dedicated search row below title) ??????????
        pnlSearch.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)
        pnlSearch.Dock      = System.Windows.Forms.DockStyle.Top
        pnlSearch.Height    = 52
        pnlSearch.Name      = "pnlSearch"
        pnlSearch.Padding   = New System.Windows.Forms.Padding(16, 10, 16, 10)

        lblSearchIcon.AutoSize  = False
        lblSearchIcon.Text      = "??"
        lblSearchIcon.Font      = New System.Drawing.Font("Segoe UI", 11)
        lblSearchIcon.ForeColor = dark
        lblSearchIcon.BackColor = System.Drawing.Color.Transparent
        lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblSearchIcon.Size      = New System.Drawing.Size(32, 32)
        lblSearchIcon.Location  = New System.Drawing.Point(16, 10)
        lblSearchIcon.Name      = "lblSearchIcon"

        txtSearchQuery.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtSearchQuery.Height          = 32
        txtSearchQuery.Location        = New System.Drawing.Point(52, 10)
        txtSearchQuery.BackColor       = cream
        txtSearchQuery.ForeColor       = dark
        txtSearchQuery.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtSearchQuery.PlaceholderText = "Type to search documents..."
        txtSearchQuery.Anchor          = System.Windows.Forms.AnchorStyles.Top Or
                                         System.Windows.Forms.AnchorStyles.Left Or
                                         System.Windows.Forms.AnchorStyles.Right
        txtSearchQuery.Name            = "txtSearchQuery"
        txtSearchQuery.TabIndex        = 0

        btnSearch.Text                              = "Search"
        btnSearch.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        btnSearch.BackColor                         = dark
        btnSearch.ForeColor                         = cream
        btnSearch.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnSearch.FlatAppearance.BorderSize         = 0
        btnSearch.FlatAppearance.MouseOverBackColor = mid
        btnSearch.Size                              = New System.Drawing.Size(90, 32)
        btnSearch.Anchor                            = System.Windows.Forms.AnchorStyles.Top Or
                                                      System.Windows.Forms.AnchorStyles.Right
        btnSearch.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnSearch.Name                              = "btnSearch"
        btnSearch.TabIndex                          = 1

        pnlSearch.Controls.Add(lblSearchIcon)
        pnlSearch.Controls.Add(txtSearchQuery)
        pnlSearch.Controls.Add(btnSearch)

        ' ?? dgvSearchResults ??????????????????????????????????????
        dgvSearchResults.Dock                  = System.Windows.Forms.DockStyle.Fill
        dgvSearchResults.Name                  = "dgvSearchResults"
        dgvSearchResults.ReadOnly              = True
        dgvSearchResults.AllowUserToAddRows    = False
        dgvSearchResults.AllowUserToDeleteRows = False
        dgvSearchResults.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvSearchResults.MultiSelect           = False
        dgvSearchResults.RowHeadersVisible     = False
        dgvSearchResults.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvSearchResults.BackgroundColor       = cream
        dgvSearchResults.BorderStyle           = System.Windows.Forms.BorderStyle.None
        dgvSearchResults.GridColor             = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvSearchResults.Font                  = New System.Drawing.Font("Segoe UI", 9)
        dgvSearchResults.TabIndex              = 2

        dgvSearchResults.ColumnHeadersDefaultCellStyle.BackColor  = dark
        dgvSearchResults.ColumnHeadersDefaultCellStyle.ForeColor  = cream
        dgvSearchResults.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvSearchResults.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvSearchResults.ColumnHeadersHeight                      = 36
        dgvSearchResults.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvSearchResults.EnableHeadersVisualStyles                = False

        dgvSearchResults.DefaultCellStyle.BackColor          = cream
        dgvSearchResults.DefaultCellStyle.ForeColor          = dark
        dgvSearchResults.DefaultCellStyle.SelectionBackColor = mid
        dgvSearchResults.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvSearchResults.DefaultCellStyle.Alignment         = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvSearchResults.RowTemplate.Height                 = 32
        dgvSearchResults.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        colDocID.Name    = "colDocID"    : colDocID.HeaderText    = "Document ID"    : colDocID.FillWeight    = 14
        colDocTitle.Name = "colDocTitle" : colDocTitle.HeaderText = "Document Title"  : colDocTitle.FillWeight = 34
        colDocTitle.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        colDateTime.Name = "colDateTime" : colDateTime.HeaderText = "Date and Time"   : colDateTime.FillWeight = 20
        colRemarks.Name  = "colRemarks"  : colRemarks.HeaderText  = "Remarks"          : colRemarks.FillWeight  = 18
        colStatus.Name   = "colStatus"   : colStatus.HeaderText   = "Status"           : colStatus.FillWeight   = 14

        dgvSearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colDocID, colDocTitle, colDateTime, colRemarks, colStatus
        })

        Me.Controls.Add(dgvSearchResults)
        Me.Controls.Add(pnlSearch)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = cream
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "UserSearchArchivePanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvSearchResults As System.Windows.Forms.DataGridView
    Friend WithEvents colDocID         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemarks       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus        As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTop           As System.Windows.Forms.Panel
    Friend WithEvents lblTitle         As System.Windows.Forms.Label
    Friend WithEvents pnlSearch        As System.Windows.Forms.Panel
    Friend WithEvents lblSearchIcon    As System.Windows.Forms.Label
    Friend WithEvents txtSearchQuery   As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch        As System.Windows.Forms.Button

End Class
