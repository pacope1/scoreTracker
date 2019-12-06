Public Class Alert
    Private Sub Alert_Load() Handles MyBase.Load
        Me.CenterToParent()
        alertLabel.Text = alertText
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        alertLabel.ResetText()
        Me.Close()
    End Sub

End Class