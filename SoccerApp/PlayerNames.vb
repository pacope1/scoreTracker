Public Class PlayerNames
    Private Sub PlayerNames_Load() Handles MyBase.Load

        Me.CenterToParent()

    End Sub

    Private Sub SubNames_Click(sender As Object, e As EventArgs) Handles SubNames.Click
        Dim index As Integer = 1

        For count = 0 To x - 1
            names(count) = InputBox("Input the name of Player " + ((index).ToString + "."))
            index += 1
        Next
    End Sub

    Private Sub FinishedButton_Click(sender As Object, e As EventArgs) Handles FinishedButton.Click
        If names.Length < playerNum.Length Then
            alertText = ("Please input a name for each player.")
            GlobalValues.RaiseAlert(null)
        End If
        Dim frmScores As New ScoreBoard
        frmScores.ShowDialog()
    End Sub
End Class