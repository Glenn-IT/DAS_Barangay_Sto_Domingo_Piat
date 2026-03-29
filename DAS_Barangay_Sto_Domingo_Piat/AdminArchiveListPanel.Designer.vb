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
        pnlActions        = New System.Windows.Forms.Panel()
        btnAddDocument    = New System.Windows.Forms.Button()
        btnUpdateDocument = New System.Windows.Forms.Button()
        btnDeleteDocument = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' ?? pnlTop  (Mid Green title bar) ?????????????????????????
        pnlTop.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Archive List"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size      = New System.Drawing.Size(400, 52)
        lblTitle.Location  = New System.Drawing.Point(16, 0)
        lblTitle.Name      = "lblTitle"

        pnlTop.Controls.Add(lblTitle)

        ' ?? pnlActions  (Cream action bar) ????????????????????????
        pnlActions.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlActions.Dock      = System.Windows.Forms.DockStyle.Bottom
        pnlActions.Height    = 60
        pnlActions.Name      = "pnlActions"
        pnlActions.Padding   = New System.Windows.Forms.Padding(12, 10, 12, 10)

        Dim btnSize As New System.Drawing.Size(120, 38)
        Dim btnFont As New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)

        ' ?? btnAddDocument  (#346739 bg) ??????????????????????????
        btnAddDocument.Text                              = "Add"
        btnAddDocument.Font                              = btnFont
        btnAddDocument.BackColor                         = System.Drawing.Color.FromArgb(52, 103, 57)
        btnAddDocument.ForeColor                         = System.Drawing.Color.FromArgb(242, 237, 194)
        btnAddDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAddDocument.FlatAppearance.BorderSize         = 0
        btnAddDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAddDocument.Size                              = btnSize
        btnAddDocument.Location                          = New System.Drawing.Point(12, 11)
        btnAddDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAddDocument.Name                              = "btnAddDocument"
        btnAddDocument.TabIndex                          = 0

        ' ?? btnUpdateDocument  (#79AE6F bg) ???????????????????????
        btnUpdateDocument.Text                              = "Update"
        btnUpdateDocument.Font                              = btnFont
        btnUpdateDocument.BackColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnUpdateDocument.ForeColor                         = System.Drawing.Color.White
        btnUpdateDocument.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUpdateDocument.FlatAppearance.BorderSize         = 0
        btnUpdateDocument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUpdateDocument.Size                              = btnSize
        btnUpdateDocument.Location                          = New System.Drawing.Point(144, 11)
        btnUpdateDocument.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUpdateDocument.Name                              = "btnUpdateDocument"
        btnUpdateDocument.TabIndex                          = 1

        ' ?? btnDeleteDocument  (Red bg) ???????????????????????????
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
        btnDeleteDocument.TabIndex                          = 2

        pnlActions.Controls.Add(btnAddDocument)
        pnlActions.Controls.Add(btnUpdateDocument)
        pnlActions.Controls.Add(btnDeleteDocument)

        ' ?? dgvArchiveList ????????????????????????????????????????
        dgvArchiveList.Dock                        = System.Windows.Forms.DockStyle.Fill
        dgvArchiveList.Name                        = "dgvArchiveList"
        dgvArchiveList.ReadOnly                    = True
        dgvArchiveList.AllowUserToAddRows          = False
        dgvArchiveList.AllowUserToDeleteRows       = False
        dgvArchiveList.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvArchiveList.MultiSelect                 = False
        dgvArchiveList.RowHeadersVisible           = False
        dgvArchiveList.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvArchiveList.BackgroundColor             = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvArchiveList.BorderStyle                 = System.Windows.Forms.BorderStyle.None
        dgvArchiveList.GridColor                   = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvArchiveList.Font                        = New System.Drawing.Font("Segoe UI", 9)
        dgvArchiveList.TabIndex                    = 3

        ' Column header style
        dgvArchiveList.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvArchiveList.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvArchiveList.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvArchiveList.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvArchiveList.ColumnHeadersHeight                      = 36
        dgvArchiveList.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvArchiveList.EnableHeadersVisualStyles                = False

        ' Row style
        dgvArchiveList.DefaultCellStyle.BackColor    = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvArchiveList.DefaultCellStyle.ForeColor    = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvArchiveList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        dgvArchiveList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvArchiveList.DefaultCellStyle.Alignment   = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvArchiveList.RowTemplate.Height            = 32

        ' Alternate row color
        dgvArchiveList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        ' ?? Columns ???????????????????????????????????????????????
        colDocID.Name          = "colDocID"
        colDocID.HeaderText    = "Document ID"
        colDocID.FillWeight    = 15

        colDocTitle.Name       = "colDocTitle"
        colDocTitle.HeaderText = "Document Title"
        colDocTitle.FillWeight = 35

        colUploadedBy.Name       = "colUploadedBy"
        colUploadedBy.HeaderText = "Uploaded By"
        colUploadedBy.FillWeight = 20

        colDateTime.Name       = "colDateTime"
        colDateTime.HeaderText = "Date and Time"
        colDateTime.FillWeight = 20

        colStatus.Name       = "colStatus"
        colStatus.HeaderText = "Status"
        colStatus.FillWeight = 10

        dgvArchiveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colDocID, colDocTitle, colUploadedBy, colDateTime, colStatus
        })

        ' ?? Assemble UserControl ??????????????????????????????????
        Me.Controls.Add(dgvArchiveList)
        Me.Controls.Add(pnlActions)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = System.Drawing.Color.FromArgb(242, 237, 194)
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
    Friend WithEvents pnlActions        As System.Windows.Forms.Panel
    Friend WithEvents btnAddDocument    As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDocument As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDocument As System.Windows.Forms.Button

End Class
