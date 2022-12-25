Public Class WordResults

    Dim highscore As Integer = Nothing 'Prepares high scores for text
    Dim scoresetting As String = Nothing 'Prepares for saving of high scores

    Public Sub LoadResults() 'Gets results screen ready
        WordResultsList.UpdateList()
        TxtWellDone.Text = "Well done!" & Environment.NewLine & "Your final score was " & WordMemoryGame1.score.ToString & "!" 'Sets score to text

        Select Case MainForm.WordDifficulty 'grabs high scores for corresponding difficulties
            Case 1
                highscore = My.Settings.WordEasyTop
                scoresetting = "WordEasyTop"

            Case 2
                highscore = My.Settings.WordMedTop
                scoresetting = "WordMedTop"

            Case 3
                highscore = My.Settings.WordHardTop
                scoresetting = "WordHardTop"

        End Select

        Select Case MainForm.WordDifficulty
            Case 1, 2, 3 'Default messages after playing Easy, Medium, or Hard
                If WordMemoryGame1.score > highscore Then 'If you beat high score
                    TxtResult.Text = "Congrats! You beat your " & MainForm.WordDifficultyTxt & " difficulty high score of " & highscore & "! Keep it up! Too easy for you? Why not think about choosing a harder difficulty or setting a Custom round!" 'Good job text
                    My.Settings(scoresetting) = WordMemoryGame1.score 'Save new score to settings
                    My.Settings.Save()
                    DebugForm.UpdateDebug()

                Else 'But if it's a custom game
                    TxtResult.Text = "Good try! Your current record for " & MainForm.WordDifficultyTxt & " is " & highscore & ". You can do it, get that new record! Want to get familiar with the list of words? Why not try a Custom round." 'Try again text

                End If

            Case Else 'Default message if playing a Custom game
                TxtResult.Text = "Good work! Since you're playing a Custom round, we can't keep track of your scores here. But why not think about playing with some wilder settings or even creating your own rules to play along with!"

        End Select

    End Sub


    Private Sub BtnSameAgain_Click(sender As Object, e As EventArgs) Handles BtnSameAgain.Click 'Play again with same settings
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        WordDifficultySelect1.SetDifficulty() 'Reloads random list if needed
        Me.Hide()
        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles BtnPlayAgain.Click 'Return to difficulty select
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        WordMemoryGame1.Hide()
        Me.Hide()
        MainForm.WordDifficulty = 0
        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnReturnHome_Click(sender As Object, e As EventArgs) Handles BtnReturnHome.Click 'Return to main menu
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        WordDifficultySelect1.Hide()
        WordMemoryGame1.Hide()
        Me.Hide()
        MainForm.WordDifficulty = 0
        DebugForm.UpdateDebug()
        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Private Sub BtnResults_Click(sender As Object, e As EventArgs) Handles BtnResults.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        WordResultsList.ShowDialog()

    End Sub
End Class
