''' <summary>
''' Holds the currently logged-in user's session data.
''' Set on successful login, cleared on logout.
''' </summary>
Public Class SessionManager

    Public Shared Property Username As String = ""
    Public Shared Property UserType As String = ""
    Public Shared Property UserCode As String = ""

    Public Shared Sub Clear()
        Username = ""
        UserType = ""
        UserCode = ""
    End Sub

End Class
