Public Class ScoreBoard

    Private Sub ScoreBoard_Load() Handles MyBase.Load
        Me.CenterToParent()
        For count = 0 To x - 1
            numList.Items.Add(playerNum(count))
            nameList.Items.Add(names(count))
        Next
    End Sub

    Private Sub SubScores_Click(sender As Object, e As EventArgs) Handles SubScores.Click
        Dim index As Integer = 1
        Dim userInput As String
        Dim tempValue As Integer
        ReDim scores(x, 1)

        For count = 0 To x - 1
            userInput = InputBox("How many goals did Player " + (index.ToString) + " score in the first half of the game?")
            If Not Integer.TryParse(userInput, tempValue) Then
                halfList1.Items.Clear()
                alertText = ("Please enter a number greater than zero for each player's score")
                GlobalValues.RaiseAlert(null)
                Exit Sub
            ElseIf Integer.TryParse(userInput, tempValue) > 0 Then
                halfList1.Items.Clear()
                alertText = ("Please enter a number greater than zero for each player's score")
                GlobalValues.RaiseAlert(null)
                Exit Sub
            Else
                scores(count, 0) = tempValue
            End If
            index += 1
            halfList1.Items.Add(scores(count, 0))
        Next

        MessageBox.Show("Enter the score for each player during the second half.")
        index = 1

        For count = 0 To x - 1
            userInput = InputBox("How many goals did Player " + (index.ToString) + " score in the second half of the game?")
            If Not Integer.TryParse(userInput, tempValue) Then
                halfList2.Items.Clear()
                alertText = ("Please enter a number greater than zero for each player's score")
                GlobalValues.RaiseAlert(null)
                Exit Sub
            ElseIf Integer.TryParse(userInput, tempValue) > 0 Then
                halfList2.Items.Clear()
                alertText = ("Please enter a number greater than zero for each player's score")
                GlobalValues.RaiseAlert(null)
                Exit Sub
            Else
                scores(count, 1) = tempValue
            End If
            index += 1
            halfList2.Items.Add(scores(count, 1))
        Next
    End Sub

    Private Sub FinishedButton_Click(sender As Object, e As EventArgs) Handles FinishedButton.Click
        ReDim totals(x)
        Dim total1 As Integer = 0
        Dim total2 As Integer = 0
        Dim completeTotal As Integer = 0

        For count = 0 To x - 1
            totals(count) = scores(count, 0) + scores(count, 1)
            totalList.Items.Add(totals(count))
        Next

        For intRow = 0 To x - 1
            total1 += scores(intRow, 0)
            total2 += scores(intRow, 1)
        Next

        completeTotal = total1 + total2

        totalH1.Text = total1
        totalH2.Text = total2
        final.Text = completeTotal
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
        End
    End Sub
End Class