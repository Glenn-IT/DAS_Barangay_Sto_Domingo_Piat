<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminArchiveListPanel
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
        dgvArchiveList    = New System.Windows.Forms.DataGridView()
        colDocID          = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDocTitle       = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colUploadedBy     = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDateTime       = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colStatus         = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlTop            = New System.Windows.Forms.Panel()
        lblTitle          = New System.Windows.Forms.Label()
        pnlSearch         = New System.Windows.Forms.Panel()
        lblSearchIcon     = New System.Windows.Forms.Label()
        txtSearch         = New System.Windows.Forms.TextBox()
        btnSearch         = New System.Windows.Forms.Button()
        pnlActions        = New System.Windows.Forms.Panel()
        btnAddDocument    = New System.Windows.Forms.Button()
        btnUpdateDocument = New System.Windows.Forms.Button()
        btnDeleteDocument = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)
        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = mid
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Archive List"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill
        lblTitle.Padding   = New System.Windows.Forms.Padding(16, 0, 0, 0)
        lblTitle.Name      = "lblTitle"

        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlSearch ?????????????????????????????????????????????
        pnlSearch.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)
        pnlSearch.Dock      = System.Windows.Forms.DockStyle.Top
        pnlSearch.Height    = 52
        pnlSearch.Name      = "pnlSearch"

        lblSearchIcon.AutoSize  = False
        lblSearchIcon.Text      = "??"
        lblSearchIcon.Font      = New System.Drawing.Font("Segoe UI", 11)
        lblSearchIcon.ForeColor = dark
        lblSearchIcon.BackColor = System.Drawing.Color.Transparent
        lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblSearchIcon.Size      = New System.Drawing.Size(32, 32)
        lblSearchIcon.Location  = New System.Drawing.Point(16, 10)
        lblSearchIcon.Name      = "lblSearchIcon"

        txtSearch.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtSearch.Height          = 32
        txtSearch.Location        = New System.Drawing.Point(52, 10)
        txtSearch.BackColor       = cream
        txtSearch.ForeColor       = dark
        txtSearch.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtSearch.PlaceholderText = "Type to search documents..."
        txtSearch.Anchor          = System.Windows.Forms.AnchorStyles.Top Or
                                    System.Windows.Forms.AnchorStyles.Left Or
                                    System.Windows.Forms.AnchorStyles.Right
        txtSearch.Name            = "txtSearch"
        txtSearch.TabIndex        = 0

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
        pnlSearch.Controls.Add(txtSearch)
        pnlSearch.Controls.Add(btnSearch)

        ' ?? pnlActions ????????????????????????????????????????????
        pnlActions.BackColor = cream
        pnlActions.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlActions.Height    = 60
        pnlActions.Name      = "pnlActions"
        pnlActions.Padding   = New System.Windows.Forms.Padding(12, 10, 12, 10)

        Dim btnSize As New System.Drawing.Size(120, 38)
        Dim btnFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)

        btnAddDocument.Text                              = "Add"
        btnAddDocument.Font                              = btnFont
        btnAddDocument.BackColor                         = dark
        btnAddDocument.ForeColor                         = cream
        btnAddDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAddDocument.FlatAppearance.BorderSize         = 0
        btnAddDocument.FlatAppearance.MouseOverBackColor = mid
        btnAddDocument.Size                              = btnSize
        btnAddDocument.Location                          = New System.Drawing.Point(12, 11)
        btnAddDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAddDocument.Name                              = "btnAddDocument"
        btnAddDocument.TabIndex                          = 2

        btnUpdateDocument.Text                              = "Update"
        btnUpdateDocument.Font                              = btnFont
        btnUpdateDocument.BackColor                         = mid
        btnUpdateDocument.ForeColor                         = System.Drawing.Color.White
        btnUpdateDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUpdateDocument.FlatAppearance.BorderSize         = 0
        btnUpdateDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUpdateDocument.Size                              = btnSize
        btnUpdateDocument.Location                          = New System.Drawing.Point(144, 11)
        btnUpdateDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUpdateDocument.Name                              = "btnUpdateDocument"
        btnUpdateDocument.TabIndex                          = 3

        btnDeleteDocument.Text                              = "Delete"
        btnDeleteDocument.Font                              = btnFont
        btnDeleteDocument.BackColor                         = System.Drawing.Color.FromArgb(192, 57, 43)
        btnDeleteDocument.ForeColor                         = System.Drawing.Color.White
        btnDeleteDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnDeleteDocument.FlatAppearance.BorderSize         = 0
        btnDeleteDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 60)
        btnDeleteDocument.Size                              = btnSize
        btnDeleteDocument.Location                          = New System.Drawing.Point(276, 11)
        btnDeleteDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnDeleteDocument.Name                              = "btnDeleteDocument"
        btnDeleteDocument.TabIndex                          = 4

        pnlActions.Controls.Add(btnAddDocument)
        pnlActions.Controls.Add(btnUpdateDocument)
        pnlActions.Controls.Add(btnDeleteDocument)

        ' ?? dgvArchiveList ????????????????????????????????????????
        dgvArchiveList.Dock                  = System.Windows.Forms.DockStyle.Fill
        dgvArchiveList.Name                  = "dgvArchiveList"
        dgvArchiveList.ReadOnly              = True
        dgvArchiveList.AllowUserToAddRows    = False
        dgvArchiveList.AllowUserToDeleteRows = False
        dgvArchiveList.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvArchiveList.MultiSelect           = False
        dgvArchiveList.RowHeadersVisible     = False
        dgvArchiveList.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvArchiveList.BackgroundColor       = cream
        dgvArchiveList.BorderStyle           = System.Windows.Forms.BorderStyle.None
        dgvArchiveList.GridColor             = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvArchiveList.Font                  = New System.Drawing.Font("Segoe UI", 9)
        dgvArchiveList.TabIndex              = 5

        dgvArchiveList.ColumnHeadersDefaultCellStyle.BackColor  = dark
        dgvArchiveList.ColumnHeadersDefaultCellStyle.ForeColor  = cream
        dgvArchiveList.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvArchiveList.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvArchiveList.ColumnHeadersHeight                      = 36
        dgvArchiveList.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvArchiveList.EnableHeadersVisualStyles                = False

        dgvArchiveList.DefaultCellStyle.BackColor          = cream
        dgvArchiveList.DefaultCellStyle.ForeColor          = dark
        dgvArchiveList.DefaultCellStyle.SelectionBackColor = mid
        dgvArchiveList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvArchiveList.DefaultCellStyle.Alignment         = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvArchiveList.RowTemplate.Height                 = 32
        dgvArchiveList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        colDocID.Name          = "colDocID"      : colDocID.HeaderText      = "Document ID"    : colDocID.FillWeight      = 15
        colDocTitle.Name       = "colDocTitle"   : colDocTitle.HeaderText   = "Document Title"  : colDocTitle.FillWeight   = 35
        colDocTitle.DefaultCellStyle.Alignment   = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        colUploadedBy.Name     = "colUploadedBy" : colUploadedBy.HeaderText = "Uploaded By"     : colUploadedBy.FillWeight = 20
        colDateTime.Name       = "colDateTime"   : colDateTime.HeaderText   = "Date and Time"   : colDateTime.FillWeight   = 20
        colStatus.Name         = "colStatus"     : colStatus.HeaderText     = "Status"          : colStatus.FillWeight     = 10

        dgvArchiveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colDocID, colDocTitle, colUploadedBy, colDateTime, colStatus
        })

        Me.Controls.Add(dgvArchiveList)
        Me.Controls.Add(pnlActions)
        Me.Controls.Add(pnlSearch)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = cream
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "AdminArchiveListPanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvArchiveList    As System.Windows.Forms.DataGridView
    Friend WithEvents colDocID          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDocTitle       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUploadedBy     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateTime       As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTop            As System.Windows.Forms.Panel
    Friend WithEvents lblTitle          As System.Windows.Forms.Label
    Friend WithEvents pnlSearch         As System.Windows.Forms.Panel
    Friend WithEvents lblSearchIcon     As System.Windows.Forms.Label
    Friend WithEvents txtSearch         As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch         As System.Windows.Forms.Button
    Friend WithEvents pnlActions        As System.Windows.Forms.Panel
    Friend WithEvents btnAddDocument    As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDocument As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDocument As System.Windows.Forms.Button

End Class
