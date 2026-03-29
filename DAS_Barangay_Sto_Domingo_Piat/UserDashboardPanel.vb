Public Class UserDashboardPanel
    Inherits System.Windows.Forms.UserControl

    ' Placeholder counts — replace with DB values later
    Private ReadOnly TotalDocuments    As Integer = 7
    Private ReadOnly RecentUploads     As Integer = 3
    Private ReadOnly PendingApproval   As Integer = 3

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub UserDashboardPanel_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTotalCount.Text   = TotalDocuments.ToString()
        lblRecentCount.Text  = RecentUploads.ToString()
        lblPendingCount.Text = PendingApproval.ToString()
    End Sub

End Class
