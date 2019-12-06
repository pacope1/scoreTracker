Module GlobalValues
    Public null As Object = Nothing
    Public x As Integer
    Public count As Integer
    Public alertText As String
    Public playerNum(x) As Integer
    Public names(x) As String
    Public scores(x, 1) As Integer
    Public totals(x) As Integer
    Public Function RaiseAlert(null)
        Dim frmAlert As New Alert
        frmAlert.ShowDialog()
        Return null
    End Function
End Module