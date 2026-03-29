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
        pnlBackground = New Panel()
        pnlCard = New Panel()
        pnlHeader = New Panel()
        lblSubTitle = New Label()
        lblSystemTitle = New Label()
        lblWelcome = New Label()
        lblUsername = New Label()
        txtAdminUsername = New TextBox()
        lblPassword = New Label()
        txtAdminPassword = New TextBox()
        btnAdminLogin = New Button()
        btnAdminForgotPassword = New Button()
        lblFooter = New Label()
        pnlBackground.SuspendLayout()
        pnlCard.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBackground
        ' 
        pnlBackground.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)
        pnlBackground.Dock = DockStyle.Fill
        pnlBackground.Location = New Point(0, 0)
        pnlBackground.Name = "pnlBackground"
        pnlBackground.Size = New Size(900, 657)
        pnlBackground.TabIndex = 0
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        pnlCard.Controls.Add(pnlHeader)
        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtAdminUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtAdminPassword)
        pnlCard.Controls.Add(btnAdminLogin)
        pnlCard.Controls.Add(btnAdminForgotPassword)
        pnlCard.Location = New Point(250, 79)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(400, 487)
        pnlCard.TabIndex = 0
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(10, 11, 10, 11)
        pnlHeader.Size = New Size(400, 113)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubTitle
        ' 
        lblSubTitle.Dock = DockStyle.Top
        lblSubTitle.Font = New Font("Segoe UI", 8.5F)
        lblSubTitle.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        lblSubTitle.Location = New Point(10, 68)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(380, 32)
        lblSubTitle.TabIndex = 0
        lblSubTitle.Text = "Piat, Cagayan"
        lblSubTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSystemTitle
        ' 
        lblSystemTitle.Dock = DockStyle.Top
        lblSystemTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSystemTitle.ForeColor = Color.White
        lblSystemTitle.Location = New Point(10, 11)
        lblSystemTitle.Name = "lblSystemTitle"
        lblSystemTitle.Size = New Size(380, 57)
        lblSystemTitle.TabIndex = 1
        lblSystemTitle.Text = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblWelcome.Location = New Point(30, 131)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(340, 43)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "Admin Login"
        lblWelcome.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblUsername.Location = New Point(30, 193)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(340, 23)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' txtAdminUsername
        ' 
        txtAdminUsername.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtAdminUsername.BorderStyle = BorderStyle.FixedSingle
        txtAdminUsername.Font = New Font("Segoe UI", 10F)
        txtAdminUsername.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtAdminUsername.Location = New Point(30, 218)
        txtAdminUsername.Name = "txtAdminUsername"
        txtAdminUsername.PlaceholderText = "Enter username"
        txtAdminUsername.Size = New Size(340, 27)
        txtAdminUsername.TabIndex = 0
        ' 
        ' lblPassword
        ' 
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        lblPassword.Location = New Point(30, 274)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(340, 23)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Password"
        ' 
        ' txtAdminPassword
        ' 
        txtAdminPassword.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtAdminPassword.BorderStyle = BorderStyle.FixedSingle
        txtAdminPassword.Font = New Font("Segoe UI", 10F)
        txtAdminPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtAdminPassword.Location = New Point(30, 299)
        txtAdminPassword.Name = "txtAdminPassword"
        txtAdminPassword.PasswordChar = "*"c
        txtAdminPassword.PlaceholderText = "Enter password"
        txtAdminPassword.Size = New Size(340, 27)
        txtAdminPassword.TabIndex = 1
        ' 
        ' btnAdminLogin
        ' 
        btnAdminLogin.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnAdminLogin.Cursor = Cursors.Hand
        btnAdminLogin.FlatAppearance.BorderSize = 0
        btnAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnAdminLogin.FlatStyle = FlatStyle.Flat
        btnAdminLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnAdminLogin.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnAdminLogin.Location = New Point(30, 365)
        btnAdminLogin.Name = "btnAdminLogin"
        btnAdminLogin.Size = New Size(340, 48)
        btnAdminLogin.TabIndex = 2
        btnAdminLogin.Text = "LOGIN"
        btnAdminLogin.UseVisualStyleBackColor = False
        ' 
        ' btnAdminForgotPassword
        ' 
        btnAdminForgotPassword.BackColor = Color.Transparent
        btnAdminForgotPassword.Cursor = Cursors.Hand
        btnAdminForgotPassword.FlatAppearance.BorderSize = 0
        btnAdminForgotPassword.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnAdminForgotPassword.FlatStyle = FlatStyle.Flat
        btnAdminForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        btnAdminForgotPassword.ForeColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnAdminForgotPassword.Location = New Point(30, 428)
        btnAdminForgotPassword.Name = "btnAdminForgotPassword"
        btnAdminForgotPassword.Size = New Size(340, 32)
        btnAdminForgotPassword.TabIndex = 3
        btnAdminForgotPassword.Text = "Forgot Password?"
        btnAdminForgotPassword.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.BackColor = Color.Transparent
        lblFooter.Font = New Font("Segoe UI", 8F)
        lblFooter.ForeColor = Color.FromArgb(CByte(159), CByte(203), CByte(152))
        lblFooter.Location = New Point(0, 621)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(900, 29)
        lblFooter.TabIndex = 1
        lblFooter.Text = "© 2026 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 657)
        Controls.Add(pnlBackground)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AdminLoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Document Archiving System — Admin Login"
        pnlBackground.ResumeLayout(False)
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    ' ── Control Declarations ───────────────────────────────────────
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
