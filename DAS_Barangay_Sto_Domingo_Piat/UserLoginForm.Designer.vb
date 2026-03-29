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
        pnlBackground = New Panel()
        pnlCard = New Panel()
        pnlHeader = New Panel()
        lblSubTitle = New Label()
        lblSystemTitle = New Label()
        lblWelcome = New Label()
        lblUsername = New Label()
        txtUserUsername = New TextBox()
        lblPassword = New Label()
        txtUserPassword = New TextBox()
        btnUserLogin = New Button()
        btnUserForgotPassword = New Button()
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
        pnlCard.Controls.Add(txtUserUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtUserPassword)
        pnlCard.Controls.Add(btnUserLogin)
        pnlCard.Controls.Add(btnUserForgotPassword)
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
        lblWelcome.Text = "User Login"
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
        ' txtUserUsername
        ' 
        txtUserUsername.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtUserUsername.BorderStyle = BorderStyle.FixedSingle
        txtUserUsername.Font = New Font("Segoe UI", 10F)
        txtUserUsername.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtUserUsername.Location = New Point(30, 218)
        txtUserUsername.Name = "txtUserUsername"
        txtUserUsername.PlaceholderText = "Enter username"
        txtUserUsername.Size = New Size(340, 27)
        txtUserUsername.TabIndex = 0
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
        ' txtUserPassword
        ' 
        txtUserPassword.BackColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        txtUserPassword.BorderStyle = BorderStyle.FixedSingle
        txtUserPassword.Font = New Font("Segoe UI", 10F)
        txtUserPassword.ForeColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        txtUserPassword.Location = New Point(30, 299)
        txtUserPassword.Name = "txtUserPassword"
        txtUserPassword.PasswordChar = "*"c
        txtUserPassword.PlaceholderText = "Enter password"
        txtUserPassword.Size = New Size(340, 27)
        txtUserPassword.TabIndex = 1
        ' 
        ' btnUserLogin
        ' 
        btnUserLogin.BackColor = Color.FromArgb(CByte(52), CByte(103), CByte(57))
        btnUserLogin.Cursor = Cursors.Hand
        btnUserLogin.FlatAppearance.BorderSize = 0
        btnUserLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUserLogin.FlatStyle = FlatStyle.Flat
        btnUserLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnUserLogin.ForeColor = Color.FromArgb(CByte(242), CByte(237), CByte(194))
        btnUserLogin.Location = New Point(30, 365)
        btnUserLogin.Name = "btnUserLogin"
        btnUserLogin.Size = New Size(340, 48)
        btnUserLogin.TabIndex = 2
        btnUserLogin.Text = "LOGIN"
        btnUserLogin.UseVisualStyleBackColor = False
        ' 
        ' btnUserForgotPassword
        ' 
        btnUserForgotPassword.BackColor = Color.Transparent
        btnUserForgotPassword.Cursor = Cursors.Hand
        btnUserForgotPassword.FlatAppearance.BorderSize = 0
        btnUserForgotPassword.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnUserForgotPassword.FlatStyle = FlatStyle.Flat
        btnUserForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        btnUserForgotPassword.ForeColor = Color.FromArgb(CByte(121), CByte(174), CByte(111))
        btnUserForgotPassword.Location = New Point(30, 428)
        btnUserForgotPassword.Name = "btnUserForgotPassword"
        btnUserForgotPassword.Size = New Size(340, 32)
        btnUserForgotPassword.TabIndex = 3
        btnUserForgotPassword.Text = "Forgot Password?"
        btnUserForgotPassword.UseVisualStyleBackColor = False
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
        ' UserLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 657)
        Controls.Add(pnlBackground)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "UserLoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Document Archiving System — User Login"
        pnlBackground.ResumeLayout(False)
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)
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
