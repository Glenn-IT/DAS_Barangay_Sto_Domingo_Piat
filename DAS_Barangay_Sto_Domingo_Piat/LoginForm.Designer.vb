<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm

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
        pnlBackground    = New System.Windows.Forms.Panel()
        pnlCard          = New System.Windows.Forms.Panel()
        pnlHeader        = New System.Windows.Forms.Panel()
        lblSubTitle      = New System.Windows.Forms.Label()
        lblSystemTitle   = New System.Windows.Forms.Label()
        lblWelcome       = New System.Windows.Forms.Label()
        lblUsername      = New System.Windows.Forms.Label()
        txtUsername      = New System.Windows.Forms.TextBox()
        lblPassword      = New System.Windows.Forms.Label()
        txtPassword      = New System.Windows.Forms.TextBox()
        btnLogin         = New System.Windows.Forms.Button()
        btnForgotPassword = New System.Windows.Forms.Button()
        lblFooter        = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        ' ?? pnlBackground ?????????????????????????????????????????
        pnlBackground.BackColor = dark
        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Location  = New System.Drawing.Point(0, 0)
        pnlBackground.Name      = "pnlBackground"
        pnlBackground.Size      = New System.Drawing.Size(900, 657)
        pnlBackground.TabIndex  = 0

        ' ?? pnlCard ???????????????????????????????????????????????
        pnlCard.BackColor = cream
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtPassword)
        pnlCard.Controls.Add(btnLogin)
        pnlCard.Controls.Add(btnForgotPassword)
        pnlCard.Location = New System.Drawing.Point(250, 79)
        pnlCard.Name     = "pnlCard"
        pnlCard.Size     = New System.Drawing.Size(400, 487)
        pnlCard.TabIndex = 0

        ' ?? pnlHeader ?????????????????????????????????????????????
        pnlHeader.BackColor = mid
        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)
        pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top
        pnlHeader.Location = New System.Drawing.Point(0, 0)
        pnlHeader.Name     = "pnlHeader"
        pnlHeader.Padding  = New System.Windows.Forms.Padding(10, 11, 10, 11)
        pnlHeader.Size     = New System.Drawing.Size(400, 113)
        pnlHeader.TabIndex = 0

        lblSystemTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblSystemTitle.ForeColor = System.Drawing.Color.White
        lblSystemTitle.Location  = New System.Drawing.Point(10, 11)
        lblSystemTitle.Name      = "lblSystemTitle"
        lblSystemTitle.Size      = New System.Drawing.Size(380, 57)
        lblSystemTitle.TabIndex  = 1
        lblSystemTitle.Text      = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter

        lblSubTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSubTitle.Font      = New System.Drawing.Font("Segoe UI", 8.5)
        lblSubTitle.ForeColor = cream
        lblSubTitle.Location  = New System.Drawing.Point(10, 68)
        lblSubTitle.Name      = "lblSubTitle"
        lblSubTitle.Size      = New System.Drawing.Size(380, 32)
        lblSubTitle.TabIndex  = 0
        lblSubTitle.Text      = "Piat, Cagayan"
        lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter

        ' ?? lblWelcome ????????????????????????????????????????????
        lblWelcome.AutoSize  = False
        lblWelcome.BackColor = System.Drawing.Color.Transparent
        lblWelcome.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblWelcome.ForeColor = dark
        lblWelcome.Location  = New System.Drawing.Point(30, 131)
        lblWelcome.Name      = "lblWelcome"
        lblWelcome.Size      = New System.Drawing.Size(340, 43)
        lblWelcome.TabIndex  = 1
        lblWelcome.Text      = "Login"
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ?? lblUsername ???????????????????????????????????????????
        lblUsername.AutoSize  = False
        lblUsername.BackColor = System.Drawing.Color.Transparent
        lblUsername.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblUsername.ForeColor = dark
        lblUsername.Location  = New System.Drawing.Point(30, 193)
        lblUsername.Name      = "lblUsername"
        lblUsername.Size      = New System.Drawing.Size(340, 23)
        lblUsername.TabIndex  = 2
        lblUsername.Text      = "Username"

        ' ?? txtUsername ???????????????????????????????????????????
        txtUsername.BackColor       = cream
        txtUsername.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtUsername.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtUsername.ForeColor       = dark
        txtUsername.Location        = New System.Drawing.Point(30, 218)
        txtUsername.Name            = "txtUsername"
        txtUsername.PlaceholderText = "Enter username"
        txtUsername.Size            = New System.Drawing.Size(340, 27)
        txtUsername.TabIndex        = 0

        ' ?? lblPassword ???????????????????????????????????????????
        lblPassword.AutoSize  = False
        lblPassword.BackColor = System.Drawing.Color.Transparent
        lblPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblPassword.ForeColor = dark
        lblPassword.Location  = New System.Drawing.Point(30, 274)
        lblPassword.Name      = "lblPassword"
        lblPassword.Size      = New System.Drawing.Size(340, 23)
        lblPassword.TabIndex  = 3
        lblPassword.Text      = "Password"

        ' ?? txtPassword ???????????????????????????????????????????
        txtPassword.BackColor       = cream
        txtPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtPassword.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtPassword.ForeColor       = dark
        txtPassword.Location        = New System.Drawing.Point(30, 299)
        txtPassword.Name            = "txtPassword"
        txtPassword.PasswordChar    = "*"c
        txtPassword.PlaceholderText = "Enter password"
        txtPassword.Size            = New System.Drawing.Size(340, 27)
        txtPassword.TabIndex        = 1

        ' ?? btnLogin ??????????????????????????????????????????????
        btnLogin.BackColor                         = dark
        btnLogin.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnLogin.FlatAppearance.BorderSize         = 0
        btnLogin.FlatAppearance.MouseOverBackColor = mid
        btnLogin.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnLogin.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnLogin.ForeColor                         = cream
        btnLogin.Location                          = New System.Drawing.Point(30, 365)
        btnLogin.Name                              = "btnLogin"
        btnLogin.Size                              = New System.Drawing.Size(340, 48)
        btnLogin.TabIndex                          = 2
        btnLogin.Text                              = "LOGIN"
        btnLogin.UseVisualStyleBackColor           = False

        ' ?? btnForgotPassword ?????????????????????????????????????
        btnForgotPassword.BackColor                         = System.Drawing.Color.Transparent
        btnForgotPassword.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnForgotPassword.FlatAppearance.BorderSize         = 0
        btnForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnForgotPassword.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnForgotPassword.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
        btnForgotPassword.ForeColor                         = mid
        btnForgotPassword.Location                          = New System.Drawing.Point(30, 428)
        btnForgotPassword.Name                              = "btnForgotPassword"
        btnForgotPassword.Size                              = New System.Drawing.Size(340, 32)
        btnForgotPassword.TabIndex                          = 3
        btnForgotPassword.Text                              = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor           = False

        ' ?? lblFooter ?????????????????????????????????????????????
        lblFooter.AutoSize  = False
        lblFooter.BackColor = System.Drawing.Color.Transparent
        lblFooter.Font      = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblFooter.Location  = New System.Drawing.Point(0, 621)
        lblFooter.Name      = "lblFooter"
        lblFooter.Size      = New System.Drawing.Size(900, 29)
        lblFooter.TabIndex  = 1
        lblFooter.Text      = "© 2025 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(900, 657)
        Me.Controls.Add(pnlBackground)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.Name                = "LoginForm"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Document Archiving System — Login"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBackground     As System.Windows.Forms.Panel
    Friend WithEvents pnlCard           As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader         As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle    As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle       As System.Windows.Forms.Label
    Friend WithEvents lblWelcome        As System.Windows.Forms.Label
    Friend WithEvents lblUsername       As System.Windows.Forms.Label
    Friend WithEvents txtUsername       As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword       As System.Windows.Forms.Label
    Friend WithEvents txtPassword       As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin          As System.Windows.Forms.Button
    Friend WithEvents btnForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblFooter         As System.Windows.Forms.Label

End Class
