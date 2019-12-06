Public Class TeamCreation

    Private Sub TeamCreation_Load() Handles MyBase.Load

        Me.CenterToParent()

    End Sub
    Private Sub GameTime_Click(sender As Object, e As EventArgs) Handles GameTime.Click
        Dim index As Integer = 1

        If Not Integer.TryParse(numBox.Text, x) Then
            alertText = ("The number of players must be a whole number greater than zero.")
            GlobalValues.RaiseAlert(null)
        ElseIf Integer.TryParse(numBox.Text, x) Then
            If x <= 0 Then
                alertText = ("The number of players must be a whole number greater than zero.")
                GlobalValues.RaiseAlert(null)
            ElseIf x > 15 Then
                alertText = ("Soccer rules allow only fifteen players per team.")
                GlobalValues.RaiseAlert(null)
            Else
                ' x = numBox.Text - 1
                x = CInt(numBox.Text)
                ReDim playerNum(x)
                ReDim names(x)
                For count = 0 To x
                    playerNum(count) = index
                    index += 1
                Next
                Dim frmPlayerNames As New PlayerNames
                frmPlayerNames.ShowDialog()
            End If
        End If
    End Sub
End Class
