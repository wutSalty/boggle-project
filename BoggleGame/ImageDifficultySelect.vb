Public Class ImageDifficultySelect

    Private Sub BtnDesc_Click(sender As Object, e As EventArgs) Handles BtnDesc.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        FormExplain.ShowImage()
        FormExplain.ShowDialog()

    End Sub

    Private Sub BtnEasy_Click(sender As Object, e As EventArgs) Handles BtnEasy.Click 'If user chooses Easy
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.ImageDifficulty = 1
        BeginImage()

    End Sub

    Private Sub BtnMed_Click(sender As Object, e As EventArgs) Handles BtnMed.Click 'If user chooses Medium
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.ImageDifficulty = 2
        BeginImage()

    End Sub

    Private Sub BtnHard_Click(sender As Object, e As EventArgs) Handles BtnHard.Click 'If user chooses Hard
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.ImageDifficulty = 3
        BeginImage()

    End Sub

    Private Sub BtnCustom_Click(sender As Object, e As EventArgs) Handles BtnCustom.Click 'If user chooses Custom
        ActiveControl = Nothing
        MainForm.CheckCards()
        If MainForm.Maffs = 0 Then
            MessageBox.Show("Please set up the cards in the \Assets\CustomPic\ folder before trying a Custom game. Instructions can be found in the user manual, or in the Settings menu. Make sure your cards are properly named too.", "Invalid cards", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.ImageDifficulty = 4
        BeginImage()

    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click 'If User returns to Main Menu
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        MainForm.ImageDifficulty = 0
        DebugForm.UpdateDebug()

        Me.Hide()
        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Private Sub BeginImage() 'Handles process after choosing a difficulty
        DebugForm.UpdateDebug()

        Select Case MainForm.ImageDifficulty 'For getting message boxes ready
            Case 1
                MainForm.ImageDifficultyTxt = "Fruit and Veg"
            Case 2
                MainForm.ImageDifficultyTxt = "Sports"
            Case 3
                MainForm.ImageDifficultyTxt = "Clothing"
            Case Else
                MainForm.ImageDifficultyTxt = "Custom"
        End Select

        MainForm.Hide()
        ImageMatchForm.LoadGame()
        ImageMatchForm.Show()

    End Sub

    'Handles fancy hover for difficulty
    Private Sub BtnEasy_MouseEnter(sender As Object, e As EventArgs) Handles BtnEasy.MouseEnter
        TxtFlavour.Text = "Play using the Fruit and Veg Deck!"
        TxtDiff.Text = "Best time: " & My.Settings.ImageA.ToString

    End Sub

    Private Sub BtnMed_MouseEnter(sender As Object, e As EventArgs) Handles BtnMed.MouseEnter
        TxtFlavour.Text = "Play using the Fruit Deck!"
        TxtDiff.Text = "Best time: " & My.Settings.ImageB.ToString

    End Sub

    Private Sub BtnHard_MouseEnter(sender As Object, e As EventArgs) Handles BtnHard.MouseEnter
        TxtFlavour.Text = "Play using the Clothing Deck!"
        TxtDiff.Text = "Best time: " & My.Settings.ImageC.ToString

    End Sub

    Private Sub BtnCustom_MouseEnter(sender As Object, e As EventArgs) Handles BtnCustom.MouseEnter
        TxtFlavour.Text = "Use your own Deck!"

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
        TxtDiff.Text = "Select Deck"
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

    Private Sub AllLeave(sender As Object, e As EventArgs) Handles BtnEasy.MouseLeave, BtnMed.MouseLeave, BtnHard.MouseLeave, BtnCustom.MouseLeave, BtnDesc.MouseLeave
        TxtFlavour.Text = "Handy tip go here"
        TxtDiff.Text = "Select Deck"

    End Sub

End Class
