<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserLoginForm

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
        pnlBackground      = New System.Windows.Forms.Panel()
        pnlCard            = New System.Windows.Forms.Panel()
        pnlHeader          = New System.Windows.Forms.Panel()
        lblSystemTitle     = New System.Windows.Forms.Label()
        lblSubTitle        = New System.Windows.Forms.Label()
        lblWelcome         = New System.Windows.Forms.Label()
        lblUsername        = New System.Windows.Forms.Label()
        txtUserUsername     = New System.Windows.Forms.TextBox()
        lblPassword        = New System.Windows.Forms.Label()
        txtUserPassword    = New System.Windows.Forms.TextBox()
        btnUserLogin       = New System.Windows.Forms.Button()
        btnUserForgotPassword = New System.Windows.Forms.Button()
        lblFooter          = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        ' ?? pnlBackground ?????????????????????????????????????????
        pnlBackground.BackColor = dark
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Name      = "pnlBackground"

        ' ?? pnlCard ???????????????????????????????????????????????
        pnlCard.BackColor = cream
        pnlCard.Location  = New System.Drawing.Point(250, 79)
        pnlCard.Name      = "pnlCard"
        pnlCard.Size      = New System.Drawing.Size(400, 487)
        pnlCard.TabIndex  = 0

        ' ?? pnlHeader ?????????????????????????????????????????????
        pnlHeader.BackColor = mid
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 113
        pnlHeader.Name      = "pnlHeader"
        pnlHeader.Padding   = New System.Windows.Forms.Padding(10, 11, 10, 11)

        lblSystemTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        lblSystemTitle.ForeColor = System.Drawing.Color.White
        lblSystemTitle.Text      = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        lblSystemTitle.Height    = 57
        lblSystemTitle.Name      = "lblSystemTitle"

        lblSubTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSubTitle.Font      = New System.Drawing.Font("Segoe UI", 8.5)
        lblSubTitle.ForeColor = cream
        lblSubTitle.Text      = "Piat, Cagayan"
        lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        lblSubTitle.Height    = 32
        lblSubTitle.Name      = "lblSubTitle"

        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        ' ?? lblWelcome ????????????????????????????????????????????
        lblWelcome.AutoSize  = False
        lblWelcome.Text      = "User Login"
        lblWelcome.Font      = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        lblWelcome.ForeColor = dark
        lblWelcome.BackColor = System.Drawing.Color.Transparent
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblWelcome.Size      = New System.Drawing.Size(340, 43)
        lblWelcome.Location  = New System.Drawing.Point(30, 131)
        lblWelcome.Name      = "lblWelcome"

        ' ?? lblUsername ???????????????????????????????????????????
        lblUsername.AutoSize  = False
        lblUsername.Text      = "Username"
        lblUsername.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblUsername.ForeColor = dark
        lblUsername.BackColor = System.Drawing.Color.Transparent
        lblUsername.Size      = New System.Drawing.Size(340, 23)
        lblUsername.Location  = New System.Drawing.Point(30, 193)
        lblUsername.Name      = "lblUsername"

        ' ?? txtUserUsername ???????????????????????????????????????
        txtUserUsername.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtUserUsername.Size            = New System.Drawing.Size(340, 27)
        txtUserUsername.Location        = New System.Drawing.Point(30, 218)
        txtUserUsername.BackColor       = cream
        txtUserUsername.ForeColor       = dark
        txtUserUsername.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtUserUsername.PlaceholderText = "Enter username"
        txtUserUsername.Name            = "txtUserUsername"
        txtUserUsername.TabIndex        = 0

        ' ?? lblPassword ???????????????????????????????????????????
        lblPassword.AutoSize  = False
        lblPassword.Text      = "Password"
        lblPassword.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        lblPassword.ForeColor = dark
        lblPassword.BackColor = System.Drawing.Color.Transparent
        lblPassword.Size      = New System.Drawing.Size(340, 23)
        lblPassword.Location  = New System.Drawing.Point(30, 274)
        lblPassword.Name      = "lblPassword"

        ' ?? txtUserPassword ???????????????????????????????????????
        txtUserPassword.Font            = New System.Drawing.Font("Segoe UI", 10)
        txtUserPassword.Size            = New System.Drawing.Size(340, 27)
        txtUserPassword.Location        = New System.Drawing.Point(30, 299)
        txtUserPassword.BackColor       = cream
        txtUserPassword.ForeColor       = dark
        txtUserPassword.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle
        txtUserPassword.PasswordChar    = "*"c
        txtUserPassword.PlaceholderText = "Enter password"
        txtUserPassword.Name            = "txtUserPassword"
        txtUserPassword.TabIndex        = 1

        ' ?? btnUserLogin ??????????????????????????????????????????
        btnUserLogin.Text                              = "LOGIN"
        btnUserLogin.Font                              = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        btnUserLogin.BackColor                         = dark
        btnUserLogin.ForeColor                         = cream
        btnUserLogin.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUserLogin.FlatAppearance.BorderSize         = 0
        btnUserLogin.FlatAppearance.MouseOverBackColor = mid
        btnUserLogin.Size                              = New System.Drawing.Size(340, 48)
        btnUserLogin.Location                          = New System.Drawing.Point(30, 365)
        btnUserLogin.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUserLogin.Name                              = "btnUserLogin"
        btnUserLogin.TabIndex                          = 2

        ' ?? btnUserForgotPassword ?????????????????????????????????
        btnUserForgotPassword.Text                              = "Forgot Password?"
        btnUserForgotPassword.Font                              = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Underline)
        btnUserForgotPassword.ForeColor                         = mid
        btnUserForgotPassword.BackColor                         = System.Drawing.Color.Transparent
        btnUserForgotPassword.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUserForgotPassword.FlatAppearance.BorderSize         = 0
        btnUserForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        btnUserForgotPassword.Size                              = New System.Drawing.Size(340, 32)
        btnUserForgotPassword.Location                          = New System.Drawing.Point(30, 428)
        btnUserForgotPassword.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUserForgotPassword.Name                              = "btnUserForgotPassword"
        btnUserForgotPassword.TabIndex                          = 3

        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUserUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtUserPassword)
        pnlCard.Controls.Add(btnUserLogin)
        pnlCard.Controls.Add(btnUserForgotPassword)

        ' ?? lblFooter ?????????????????????????????????????????????
        lblFooter.AutoSize  = False
        lblFooter.Text      = "© 2025 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.Font      = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblFooter.BackColor = System.Drawing.Color.Transparent
        lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblFooter.Size      = New System.Drawing.Size(900, 29)
        lblFooter.Location  = New System.Drawing.Point(0, 621)
        lblFooter.Name      = "lblFooter"

        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(900, 657)
        Me.Controls.Add(pnlBackground)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name                = "UserLoginForm"
        Me.Text                = "Document Archiving System — User Login"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBackground         As System.Windows.Forms.Panel
    Friend WithEvents pnlCard               As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader             As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle        As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle           As System.Windows.Forms.Label
    Friend WithEvents lblWelcome            As System.Windows.Forms.Label
    Friend WithEvents lblUsername           As System.Windows.Forms.Label
    Friend WithEvents txtUserUsername       As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword           As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword       As System.Windows.Forms.TextBox
    Friend WithEvents btnUserLogin          As System.Windows.Forms.Button
    Friend WithEvents btnUserForgotPassword As System.Windows.Forms.Button
    Friend WithEvents lblFooter             As System.Windows.Forms.Label

End Class
