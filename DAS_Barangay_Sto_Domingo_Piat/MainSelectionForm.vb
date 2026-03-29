Public Class MainSelectionForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim frm As New AdminLoginForm()
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnUserLogin_Click(sender As Object, e As EventArgs) Handles btnUserLogin.Click
        Dim frm As New UserLoginForm()
        Me.Hide()
        frm.ShowDialog()
        Me.Show()
    End Sub

End Class
