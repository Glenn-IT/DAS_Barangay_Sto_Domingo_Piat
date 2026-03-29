<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainSelectionForm

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
        pnlBackground  = New System.Windows.Forms.Panel()
        pnlHeader      = New System.Windows.Forms.Panel()
        lblSystemTitle = New System.Windows.Forms.Label()
        lblSubTitle    = New System.Windows.Forms.Label()
        pnlCard        = New System.Windows.Forms.Panel()
        lblWelcome     = New System.Windows.Forms.Label()
        lblInstruction = New System.Windows.Forms.Label()
        pnlButtons     = New System.Windows.Forms.Panel()
        btnAdminLogin  = New System.Windows.Forms.Button()
        lblOr          = New System.Windows.Forms.Label()
        btnUserLogin   = New System.Windows.Forms.Button()
        lblFooter      = New System.Windows.Forms.Label()

        Me.SuspendLayout()

        Dim cream As System.Drawing.Color = System.Drawing.Color.FromArgb(242, 237, 194)
        Dim dark  As System.Drawing.Color = System.Drawing.Color.FromArgb(52, 103, 57)
        Dim mid   As System.Drawing.Color = System.Drawing.Color.FromArgb(121, 174, 111)

        ' ?? pnlBackground  (#346739 — Dark Green fill) ????????????
        pnlBackground.BackColor = dark
        pnlBackground.Dock      = System.Windows.Forms.DockStyle.Fill
        pnlBackground.Name      = "pnlBackground"

        ' ?? pnlHeader  (#79AE6F — Mid Green top) ??????????????????
        pnlHeader.BackColor = mid
        pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        pnlHeader.Height    = 110
        pnlHeader.Name      = "pnlHeader"
        pnlHeader.Padding   = New System.Windows.Forms.Padding(10, 11, 10, 11)

        lblSystemTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSystemTitle.Font      = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        lblSystemTitle.ForeColor = System.Drawing.Color.White
        lblSystemTitle.Text      = "Document Archiving System of Barangay Sto. Domingo"
        lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        lblSystemTitle.Height    = 60
        lblSystemTitle.Name      = "lblSystemTitle"

        lblSubTitle.Dock      = System.Windows.Forms.DockStyle.Top
        lblSubTitle.Font      = New System.Drawing.Font("Segoe UI", 9)
        lblSubTitle.ForeColor = cream
        lblSubTitle.Text      = "Piat, Cagayan"
        lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        lblSubTitle.Height    = 28
        lblSubTitle.Name      = "lblSubTitle"

        pnlHeader.Controls.Add(lblSubTitle)
        pnlHeader.Controls.Add(lblSystemTitle)

        ' ?? pnlCard  (Cream centered card) ????????????????????????
        pnlCard.BackColor = cream
        pnlCard.Size      = New System.Drawing.Size(420, 360)
        pnlCard.Location  = New System.Drawing.Point(240, 140)
        pnlCard.Name      = "pnlCard"

        ' Welcome label
        lblWelcome.AutoSize  = False
        lblWelcome.Text      = "Welcome!"
        lblWelcome.Font      = New System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold)
        lblWelcome.ForeColor = dark
        lblWelcome.BackColor = System.Drawing.Color.Transparent
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblWelcome.Size      = New System.Drawing.Size(420, 60)
        lblWelcome.Location  = New System.Drawing.Point(0, 30)
        lblWelcome.Name      = "lblWelcome"

        ' Instruction label
        lblInstruction.AutoSize  = False
        lblInstruction.Text      = "Please select your login type to continue."
        lblInstruction.Font      = New System.Drawing.Font("Segoe UI", 9.5)
        lblInstruction.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        lblInstruction.BackColor = System.Drawing.Color.Transparent
        lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblInstruction.Size      = New System.Drawing.Size(420, 28)
        lblInstruction.Location  = New System.Drawing.Point(0, 90)
        lblInstruction.Name      = "lblInstruction"

        ' ?? pnlButtons ????????????????????????????????????????????
        pnlButtons.BackColor = System.Drawing.Color.Transparent
        pnlButtons.Size      = New System.Drawing.Size(360, 180)
        pnlButtons.Location  = New System.Drawing.Point(30, 130)
        pnlButtons.Name      = "pnlButtons"

        ' btnAdminLogin
        btnAdminLogin.Text                              = "Login as Admin"
        btnAdminLogin.Font                              = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        btnAdminLogin.BackColor                         = dark
        btnAdminLogin.ForeColor                         = cream
        btnAdminLogin.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnAdminLogin.FlatAppearance.BorderSize         = 0
        btnAdminLogin.FlatAppearance.MouseOverBackColor = mid
        btnAdminLogin.Size                              = New System.Drawing.Size(360, 52)
        btnAdminLogin.Location                          = New System.Drawing.Point(0, 0)
        btnAdminLogin.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnAdminLogin.Name                              = "btnAdminLogin"
        btnAdminLogin.TabIndex                          = 0

        ' lblOr (divider)
        lblOr.AutoSize  = False
        lblOr.Text      = "— or —"
        lblOr.Font      = New System.Drawing.Font("Segoe UI", 9)
        lblOr.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblOr.BackColor = System.Drawing.Color.Transparent
        lblOr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblOr.Size      = New System.Drawing.Size(360, 30)
        lblOr.Location  = New System.Drawing.Point(0, 62)
        lblOr.Name      = "lblOr"

        ' btnUserLogin
        btnUserLogin.Text                              = "Login as User"
        btnUserLogin.Font                              = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        btnUserLogin.BackColor                         = mid
        btnUserLogin.ForeColor                         = System.Drawing.Color.White
        btnUserLogin.FlatStyle                         = System.Windows.Forms.FlatStyle.Flat
        btnUserLogin.FlatAppearance.BorderSize         = 0
        btnUserLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(159, 203, 152)
        btnUserLogin.Size                              = New System.Drawing.Size(360, 52)
        btnUserLogin.Location                          = New System.Drawing.Point(0, 102)
        btnUserLogin.Cursor                            = System.Windows.Forms.Cursors.Hand
        btnUserLogin.Name                              = "btnUserLogin"
        btnUserLogin.TabIndex                          = 1

        pnlButtons.Controls.Add(btnAdminLogin)
        pnlButtons.Controls.Add(lblOr)
        pnlButtons.Controls.Add(btnUserLogin)

        pnlCard.Controls.Add(lblWelcome)
        pnlCard.Controls.Add(lblInstruction)
        pnlCard.Controls.Add(pnlButtons)

        ' Footer
        lblFooter.AutoSize  = False
        lblFooter.Text      = "© 2025 Barangay Sto. Domingo - Piat  |  All Rights Reserved"
        lblFooter.Font      = New System.Drawing.Font("Segoe UI", 8)
        lblFooter.ForeColor = System.Drawing.Color.FromArgb(159, 203, 152)
        lblFooter.BackColor = System.Drawing.Color.Transparent
        lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        lblFooter.Size      = New System.Drawing.Size(900, 28)
        lblFooter.Location  = New System.Drawing.Point(0, 620)
        lblFooter.Name      = "lblFooter"

        pnlBackground.Controls.Add(pnlCard)
        pnlBackground.Controls.Add(lblFooter)

        ' ?? Form ??????????????????????????????????????????????????
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize          = New System.Drawing.Size(900, 657)
        Me.Controls.Add(pnlBackground)
        Me.Controls.Add(pnlHeader)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name                = "MainSelectionForm"
        Me.Text                = "Document Archiving System — Select Login"

        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBackground  As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader      As System.Windows.Forms.Panel
    Friend WithEvents lblSystemTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle    As System.Windows.Forms.Label
    Friend WithEvents pnlCard        As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome     As System.Windows.Forms.Label
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents pnlButtons     As System.Windows.Forms.Panel
    Friend WithEvents btnAdminLogin  As System.Windows.Forms.Button
    Friend WithEvents lblOr          As System.Windows.Forms.Label
    Friend WithEvents btnUserLogin   As System.Windows.Forms.Button
    Friend WithEvents lblFooter      As System.Windows.Forms.Label

End Class
