<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminActivityLogsPanel
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
        dgvActivityLogs = New System.Windows.Forms.DataGridView()
        colRefCode      = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colUsername     = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colDate         = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colLogStatus    = New System.Windows.Forms.DataGridViewTextBoxColumn()
        colLog          = New System.Windows.Forms.DataGridViewTextBoxColumn()
        pnlTop          = New System.Windows.Forms.Panel()
        lblTitle        = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' ?? pnlTop ????????????????????????????????????????????????
        pnlTop.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlTop.Dock      = System.Windows.Forms.DockStyle.Top
        pnlTop.Height    = 52
        pnlTop.Name      = "pnlTop"

        lblTitle.AutoSize  = False
        lblTitle.Text      = "Activity Logs"
        lblTitle.Font      = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        lblTitle.ForeColor = System.Drawing.Color.White
        lblTitle.BackColor = System.Drawing.Color.Transparent
        lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        lblTitle.Size      = New System.Drawing.Size(400, 52)
        lblTitle.Location  = New System.Drawing.Point(16, 0)
        lblTitle.Name      = "lblTitle"
        pnlTop.Controls.Add(lblTitle)

        ' ?? dgvActivityLogs ???????????????????????????????????????
        dgvActivityLogs.Dock                  = System.Windows.Forms.DockStyle.Fill
        dgvActivityLogs.Name                  = "dgvActivityLogs"
        dgvActivityLogs.ReadOnly              = True
        dgvActivityLogs.AllowUserToAddRows    = False
        dgvActivityLogs.AllowUserToDeleteRows = False
        dgvActivityLogs.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvActivityLogs.MultiSelect           = False
        dgvActivityLogs.RowHeadersVisible     = False
        dgvActivityLogs.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvActivityLogs.BackgroundColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvActivityLogs.BorderStyle           = System.Windows.Forms.BorderStyle.None
        dgvActivityLogs.GridColor             = System.Drawing.Color.FromArgb(159, 203, 152)
        dgvActivityLogs.Font                  = New System.Drawing.Font("Segoe UI", 9)
        dgvActivityLogs.TabIndex              = 0

        dgvActivityLogs.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvActivityLogs.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvActivityLogs.ColumnHeadersDefaultCellStyle.Font       = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvActivityLogs.ColumnHeadersDefaultCellStyle.Alignment  = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvActivityLogs.ColumnHeadersHeight                      = 36
        dgvActivityLogs.ColumnHeadersHeightSizeMode              = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvActivityLogs.EnableHeadersVisualStyles                = False

        dgvActivityLogs.DefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(242, 237, 194)
        dgvActivityLogs.DefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(52, 103, 57)
        dgvActivityLogs.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        dgvActivityLogs.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        dgvActivityLogs.DefaultCellStyle.Alignment         = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        dgvActivityLogs.RowTemplate.Height                 = 32
        dgvActivityLogs.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(230, 226, 180)

        colRefCode.Name       = "colRefCode"
        colRefCode.HeaderText = "Reference Code"
        colRefCode.FillWeight = 15

        colUsername.Name       = "colUsername"
        colUsername.HeaderText = "Username"
        colUsername.FillWeight = 15

        colDate.Name       = "colDate"
        colDate.HeaderText = "Date"
        colDate.FillWeight = 20

        colLogStatus.Name       = "colLogStatus"
        colLogStatus.HeaderText = "Status"
        colLogStatus.FillWeight = 12

        colLog.Name       = "colLog"
        colLog.HeaderText = "Log"
        colLog.FillWeight = 38
        colLog.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft

        dgvActivityLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            colRefCode, colUsername, colDate, colLogStatus, colLog
        })

        Me.Controls.Add(dgvActivityLogs)
        Me.Controls.Add(pnlTop)
        Me.BackColor     = System.Drawing.Color.FromArgb(242, 237, 194)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name          = "AdminActivityLogsPanel"
        Me.Size          = New System.Drawing.Size(880, 596)

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents dgvActivityLogs As System.Windows.Forms.DataGridView
    Friend WithEvents colRefCode      As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUsername     As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDate         As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLogStatus    As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLog          As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTop          As System.Windows.Forms.Panel
    Friend WithEvents lblTitle        As System.Windows.Forms.Label

End Class
