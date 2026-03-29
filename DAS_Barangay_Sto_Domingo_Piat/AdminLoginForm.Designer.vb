<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLoginForm

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
        ' ?? Controls ??????????????????????????????????????????????
        pnlBackground          = New System.Windows.Forms.Panel()
        pnlCard                = New System.Windows.Forms.Panel()
        pnlHeader              = New System.Windows.Forms.Panel()
        lblSystemTitle         = New System.Windows.Forms.Label()
        lblSubTitle            = New System.Windows.Forms.Label()
        lblWelcome             = New System.Windows.Forms.Label()
        lblUsername            = New System.Windows.Forms.Label()
        txtAdminUsername       = New System.Windows.Forms.TextBox()
        lblPassword            = New System.Windows.Forms.Label()
        txtAdminPassword       = New System.Windows.Forms.TextBox()
        btnAdminLogin          = New System.Windows.Forms.Button()
        btnAdminForgotPassword = New System.Windows.Forms.Button()
        lblFooter              = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        ' ?? pnlBackground  (#346739 — Dark Green) ?????????????????
        pnlBackground.BackColor = System.Drawing.Color.FromArgb(52, 103, 57)
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Name      = "pnlBackground"
        pnlBackground.TabIndex  = 0

        ' ?? pnlHeader  (#79AE6F — Mid Green) ??????????????????????
        pnlHeader.BackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 100
        pnlHeader.Name      = "pnlHeader"
        pnlHeader.Padding   = New System.Windows.Forms.Padding(10)

        ' ?? lblSystemTitle  (White on Mid Green) ??????????????????
        lblSystemTitle.AutoSize  = False
        lblSystemTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.ForeColor = System.Drawing.Color.White
        lblSystemTitle.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblSystemTitle.Text      = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        lblSystemTitle.Height    = 50
        lblSystemTitle.Name      = "lblSystemTitle"

        ' ?? lblSubTitle  (#F2EDC2 — Cream on Mid Green) ???????????
        lblSubTitle.AutoSize   = False
        lblSubTitle.Dock       = System.Windows.Forms.DockStyle.Top
        lblSubTitle.ForeColor  = System.Drawing.Color.FromArgb(242, 237, 194)
        lblSubTitle.Font       = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Regular)
        lblSubTitle.Text       = "Piat, Cagayan"
        lblSubTitle.TextAlign  = System.Drawing.ContentAlignment.TopCenter
        lblSubTitle.Height     = 28
        lblSubTitle.Name       = "lblSubTitle"

        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        ' ?? lblWelcome  (#346739 — Dark Green text on Cream card) ?
        lblWelcome.AutoSize  = False
        lblWelcome.Text      = "Admin Login"
        lblWelcome.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblWelcome.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblWelcome.Size      = New System.Drawing.Size(340, 38)
        lblWelcome.Location  = New System.Drawing.Point(30, 116)
        lblWelcome.Name      = "lblWelcome"
        lblWelcome.BackColor = System.Drawing.Color.Transparent

        ' ?? lblUsername  (#346739) ?????????????????????????????????
        lblUsername.AutoSize  = False
        lblUsername.Text      = "Username"
        lblUsername.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblUsername.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblUsername.Size      = New System.Drawing.Size(340, 20)
        lblUsername.Location  = New System.Drawing.Point(30, 170)
        lblUsername.Name      = "lblUsername"
        lblUsername.BackColor = System.Drawing.Color.Transparent

        ' ?? txtAdminUsername  (Cream bg, Dark Green border) ???????
        txtAdminUsername.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtAdminUsername.Size            = New System.Drawing.Size(340, 34)
        txtAdminUsername.Location        = New System.Drawing.Point(30, 192)
        txtAdminUsername.Name            = "txtAdminUsername"
        txtAdminUsername.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtAdminUsername.BackColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        txtAdminUsername.ForeColor       = System.Drawing.Color.FromArgb(52, 103, 57)
        txtAdminUsername.PlaceholderText = "Enter username"
        txtAdminUsername.TabIndex        = 0

        ' ?? lblPassword  (#346739) ?????????????????????????????????
        lblPassword.AutoSize  = False
        lblPassword.Text      = "Password"
        lblPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblPassword.ForeColor = System.Drawing.Color.FromArgb(52, 103, 57)
        lblPassword.Size      = New System.Drawing.Size(340, 20)
        lblPassword.Location  = New System.Drawing.Point(30, 242)
        lblPassword.Name      = "lblPassword"
        lblPassword.BackColor = System.Drawing.Color.Transparent

        ' ?? txtAdminPassword  (Cream bg, Dark Green text) ?????????
        txtAdminPassword.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtAdminPassword.Size            = New System.Drawing.Size(340, 34)
        txtAdminPassword.Location        = New System.Drawing.Point(30, 264)
        txtAdminPassword.Name            = "txtAdminPassword"
        txtAdminPassword.PasswordChar    = "*"c
        txtAdminPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtAdminPassword.BackColor       = System.Drawing.Color.FromArgb(242, 237, 194)
        txtAdminPassword.ForeColor       = System.Drawing.Color.FromArgb(52, 103, 57)
        txtAdminPassword.PlaceholderText = "Enter password"
        txtAdminPassword.TabIndex        = 1

        ' ?? btnAdminLogin  (#346739 bg, Cream text) ???????????????
        btnAdminLogin.Text                      = "LOGIN"
        btnAdminLogin.Font                      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnAdminLogin.BackColor                 = System.Drawing.Color.FromArgb(52, 103, 57)
        btnAdminLogin.ForeColor                 = System.Drawing.Color.FromArgb(242, 237, 194)
        btnAdminLogin.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat
        btnAdminLogin.FlatAppearance.BorderSize = 0
        btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAdminLogin.Size                      = New System.Drawing.Size(340, 42)
        btnAdminLogin.Location                  = New System.Drawing.Point(30, 322)
        btnAdminLogin.Name                      = "btnAdminLogin"
        btnAdminLogin.Cursor                    = System.Windows.Forms.Cursors.Hand
        btnAdminLogin.TabIndex                  = 2

        ' ?? btnAdminForgotPassword  (#79AE6F underline link) ??????
        btnAdminForgotPassword.Text                              = "Forgot Password?"
        btnAdminForgotPassword.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
        btnAdminForgotPassword.ForeColor                         = System.Drawing.Color.FromArgb(121, 174, 111)
        btnAdminForgotPassword.BackColor                         = System.Drawing.Color.Transparent
        btnAdminForgotPassword.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAdminForgotPassword.FlatAppearance.BorderSize         = 0
        btnAdminForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnAdminForgotPassword.Size                              = New System.Drawing.Size(340, 28)
        btnAdminForgotPassword.Location                          = New System.Drawing.Point(30, 378)
        btnAdminForgotPassword.Name                              = "btnAdminForgotPassword"
        btnAdminForgotPassword.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAdminForgotPassword.TabIndex                          = 3

        ' ?? pnlCard  (#F2EDC2 — Cream card) ???????????????????????
        pnlCard.BackColor = System.Drawing.Color.FromArgb(242, 237, 194)
        pnlCard.Location  = New System.Drawing.Point(250, 70)
        pnlCard.Name      = "pnlCard"
        pnlCard.Size      = New System.Drawing.Size(400, 430)
        pnlCard.TabIndex  = 0
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtAdminUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtAdminPassword)
        pnlCard.Controls.Add(btnAdminLogin)
        pnlCard.Controls.Add(btnAdminForgotPassword)

        ' ?? lblFooter  (#9FCB98 — Light Green on Dark bg) ?????????
        lblFooter.AutoSize  = False
        lblFooter.Text      = "© 2025 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.Font      = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblFooter.Size      = New System.Drawing.Size(900, 26)
        lblFooter.Location  = New System.Drawing.Point(0, 548)
        lblFooter.Name      = "lblFooter"
        lblFooter.BackColor = System.Drawing.Color.Transparent

        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(900, 580)
        Me.Controls.Add(pnlBackground)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.Name                = "AdminLoginForm"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Document Archiving System — Admin Login"

        Me.ResumeLayout(False)
    End Sub

    ' ?? Control Declarations ???????????????????????????????????????
    Friend WithEvents pnlBackground As System.Windows.Forms.Panel
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtAdminUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnAdminLogin As System.Windows.Forms.Button
    Friend WithEvents btnAdminForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label

End Class
