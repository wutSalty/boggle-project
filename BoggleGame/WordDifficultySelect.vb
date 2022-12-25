Public Class WordDifficultySelect

    Private Sub BtnDesc_Click(sender As Object, e As EventArgs) Handles BtnDesc.Click 'How to play button
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        FormExplain.ShowWord()
        FormExplain.ShowDialog()

    End Sub

    Private Sub BtnEasy_Click(sender As Object, e As EventArgs) Handles BtnEasy.Click 'If user chooses Easy
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.WordDifficulty = 1
        SetDifficulty()

    End Sub

    Private Sub BtnMed_Click(sender As Object, e As EventArgs) Handles BtnMed.Click 'If user chooses Medium
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.WordDifficulty = 2
        SetDifficulty()

    End Sub

    Private Sub BtnHard_Click(sender As Object, e As EventArgs) Handles BtnHard.Click 'If User chooses Hard
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.WordDifficulty = 3
        SetDifficulty()

    End Sub

    Private Sub BtnCustom_Click(sender As Object, e As EventArgs) Handles BtnCustom.Click 'Custom game
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.WordDifficulty = 4
        WordCustomForm.ShowDialog()

    End Sub


    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click 'If User returns to Main Menu
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        MainForm.WordDifficulty = 0
        DebugForm.UpdateDebug()

        Me.Hide()
        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Public Sub SetDifficulty()
        DebugForm.UpdateDebug()

        Select Case MainForm.WordDifficulty 'For getting message boxes ready
            Case 1
                MainForm.WordDifficultyTxt = "Easy"
                RandomWordList = Shuffle(RegWordList.ToArray) 'Randomises the list

            Case 2
                MainForm.WordDifficultyTxt = "Medium"
                RandomWordList = Shuffle(RegWordList.ToArray) 'Randomises the list

            Case 3
                MainForm.WordDifficultyTxt = "Hard"
                RandomWordList = Shuffle(RegWordList.ToArray) 'Randomises the list

            Case Else
                MainForm.WordDifficultyTxt = "Custom"
                RandomWordList = Shuffle(SpcWordList.ToArray) 'Randomises the user list

        End Select

        DebugForm.UpdateWordList() ':DEBUG SHOULD DISABLE BECAUSE PERFORMANCE HIT
        BeginWord()

    End Sub

    Public Sub BeginWord() 'Handles process after choosing a difficulty

        WordMemoryGame1.Show()
        WordMemoryGame1.PrePrep()

    End Sub

    'Handles fancy hover for difficulty
    Private Sub BtnEasy_MouseEnter(sender As Object, e As EventArgs) Handles BtnEasy.MouseEnter
        TxtFlavour.Text = "There'll be a one word gap between words!"
        TxtDiff.Text = "High score: " & My.Settings.WordEasyTop

    End Sub

    Private Sub BtnMed_MouseEnter(sender As Object, e As EventArgs) Handles BtnMed.MouseEnter
        TxtFlavour.Text = "There'll be a two word gap between words!"
        TxtDiff.Text = "High score: " & My.Settings.WordMedTop

    End Sub


    Private Sub BtnHard_MouseEnter(sender As Object, e As EventArgs) Handles BtnHard.MouseEnter
        TxtFlavour.Text = "There'll be a three word gap between words!"
        TxtDiff.Text = "High score: " & My.Settings.WordHardTop

    End Sub


    Private Sub BtnCustom_MouseEnter(sender As Object, e As EventArgs) Handles BtnCustom.MouseEnter
        TxtFlavour.Text = "Play how you want!"

    End Sub

    Private Sub BtnDesc_MouseEnter(sender As Object, e As EventArgs) Handles BtnDesc.MouseEnter
        TxtFlavour.Text = "Need to know how to play?"

    End Sub

    Private Sub BtnReturn_MouseEnter(sender As Object, e As EventArgs) Handles BtnReturn.MouseEnter
        TxtFlavour.Text = "Return to the Main Menu"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnReturn.BackgroundImage = My.Resources.backlightb

            Case 2
                BtnReturn.BackgroundImage = My.Resources.backdarkb

        End Select

    End Sub

    Private Sub BtnReturn_MouseLeave(sender As Object, e As EventArgs) Handles BtnReturn.MouseLeave
        TxtFlavour.Text = "Handy tip go here"
        TxtDiff.Text = "Select Difficulty"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnReturn.BackgroundImage = My.Resources.backlighta

            Case 2
                BtnReturn.BackgroundImage = My.Resources.backdarka

        End Select

    End Sub

    Private Sub BtnReturn_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnReturn.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnReturn.BackgroundImage = My.Resources.backlightc

            Case 2
                BtnReturn.BackgroundImage = My.Resources.backdarkc

        End Select

    End Sub

    Private Sub BtnReturn_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnReturn.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnReturn.BackgroundImage = My.Resources.backlighta

            Case 2
                BtnReturn.BackgroundImage = My.Resources.backdarka

        End Select

    End Sub

    Private Sub AllLeave(sender As Object, e As EventArgs) Handles BtnMed.MouseLeave, BtnHard.MouseLeave, BtnCustom.MouseLeave, BtnDesc.MouseLeave, BtnEasy.MouseLeave
        TxtFlavour.Text = "Handy tip go here"
        TxtDiff.Text = "Select Difficulty"

    End Sub

End Class
