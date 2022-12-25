Public Class Settings
    Public Sub LoadSettings()
        'Loads the correct option for settings
        CheckDebug.Checked = My.Settings.ShowDebugForm
        CheckTitleSkip.Checked = My.Settings.SkipTitle
        CheckShowCards.Checked = My.Settings.ShowCardDeck
        CheckBGMute.Checked = My.Settings.BGMMuted
        CheckSFXMute.Checked = My.Settings.SFXMuted
        TxtSavedAt.Text = My.Settings.SavedAt

        Select Case My.Settings.CardBack
            Case 1
                RadioCard1.Checked = True

            Case 2
                RadioCard2.Checked = True

            Case 3
                RadioCard3.Checked = True

            Case Else
                RadioCard1.Checked = True

        End Select

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ActiveControl = Nothing

        'Saves settings
        SaveSettings()
        MainForm.SFXPlay(My.Resources.confirmbeep)
        'Removes setting menu
        Me.Hide()

        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        'Removes setting menu
        Me.Hide()

        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Private Sub BtnResetAll_Click(sender As Object, e As EventArgs) Handles BtnResetAll.Click
        ActiveControl = Nothing
        'Message Box confirming whether user wants to reset all settings
        If MessageBox.Show("This will reset ALL settings. Press OK if you know what you are doing. This will also restart the program.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK Then
            My.Settings.Reset()
            MainForm.Text = "Boogle - First Time"

            'Updates debug stuff
            DebugForm.UpdateDebug()

            Application.Restart()
        End If

    End Sub

    Public Sub SaveSettings()
        'Dynamic Showing or Hiding of Debug Form
        If My.Settings.ShowDebugForm = True And CheckDebug.Checked = False Then
            DebugForm.Close()

        ElseIf My.Settings.ShowDebugForm = False And CheckDebug.Checked = True Then
            DebugForm.Show()

        End If

        'Sets the card backs depending on the radio buttons
        If RadioCard1.Checked Then
            My.Settings.CardBack = 1

        ElseIf RadioCard2.Checked Then
            My.Settings.CardBack = 2

        ElseIf RadioCard3.Checked Then
            My.Settings.CardBack = 3

        Else
            My.Settings.CardBack = 1

        End If

        'Updates audio depending on settings
        If My.Settings.BGMMuted = True And CheckBGMute.Checked = False Then 'If the game was previously muted and now unmuted
            UnmuteAudio() 'Unmute audio

        ElseIf My.Settings.BGMMuted = False And CheckBGMute.Checked = True Then 'But if the game was previously not muted and now muted
            MuteAudio() 'Mutes the audio

        End If

        'Saves settings
        My.Settings.BGMMuted = CheckBGMute.Checked
        My.Settings.SFXMuted = CheckSFXMute.Checked
        My.Settings.ShowDebugForm = CheckDebug.Checked
        My.Settings.SkipTitle = CheckTitleSkip.Checked
        My.Settings.ShowCardDeck = CheckShowCards.Checked
        My.Settings.Save()

        'Gets current time and date and saves as text
        My.Settings.SavedAt = "Last updated at " & Today.ToShortDateString & " " & TimeString
        TxtSavedAt.Text = My.Settings.SavedAt

        'Updates debug stuff
        DebugForm.UpdateDebug()

    End Sub

    Public proc As Process
    Private Sub BtnEditList_Click(sender As Object, e As EventArgs) Handles BtnEditList.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        'If file not found, create file and give warning before opening the menu
        If (Not File.Exists("Assets\WordList.txt")) Then
            MainForm.CheckFiles()
            MessageBox.Show("Word List file was not detected. Creating a new WordList.txt file.", "Missing Word List", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        proc = Process.Start("Assets\WordList.txt")
        HowToWordList.ShowDialog()

    End Sub

    Private Sub BtnHowImg_Click(sender As Object, e As EventArgs) Handles BtnHowImg.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        'Finds the CustomPic folder and opens it up
        Dim CD As String = Directory.GetCurrentDirectory
        Shell("explorer.exe /e, " & CD & "\Assets\CustomPic", vbNormalFocus)

        'Then show the in-game instructions
        HowToImage.ShowDialog()

    End Sub

    'When you click on the pictures, it'll also select the respective radio
    Private Sub BoxCover1_Click(sender As Object, e As EventArgs) Handles BoxCover1.Click, RadioCard1.Click
        RadioCard1.Checked = True

    End Sub

    Private Sub BoxCover2_Click(sender As Object, e As EventArgs) Handles BoxCover2.Click, RadioCard2.Click
        RadioCard2.Checked = True

    End Sub

    Private Sub BoxCover3_Click(sender As Object, e As EventArgs) Handles BoxCover3.Click, RadioCard3.Click
        RadioCard3.Checked = True

    End Sub

    'Just open the credits
    Private Sub BtnCredits_Click(sender As Object, e As EventArgs) Handles BtnCredits.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        Credits.ShowDialog()

    End Sub

    'Hovers. Hover everywhere
    Private Sub CheckTitleSkip_MouseEnter(sender As Object, e As EventArgs) Handles CheckTitleSkip.MouseEnter
        TxtFlavour.Text = "Skip the Title Screen on load"

    End Sub

    Private Sub CheckDebug_MouseEnter(sender As Object, e As EventArgs) Handles CheckDebug.MouseEnter
        TxtFlavour.Text = "View the behind the scenes"

    End Sub

    Private Sub CheckBGMute_MouseEnter(sender As Object, e As EventArgs) Handles CheckBGMute.MouseEnter
        TxtFlavour.Text = "Mutes Background Music"

    End Sub

    Private Sub CheckSFXMute_MouseEnter(sender As Object, e As EventArgs) Handles CheckSFXMute.MouseEnter
        TxtFlavour.Text = "Mutes extra Sound Effects"

    End Sub

    Private Sub CheckShowCards_MouseEnter(sender As Object, e As EventArgs) Handles CheckShowCards.MouseEnter
        TxtFlavour.Text = "Show the cards that are in the deck"

    End Sub

    Private Sub CardBacks_Flavour(sender As Object, e As EventArgs) Handles RadioCard1.MouseEnter, BoxCover1.MouseEnter, RadioCard2.MouseEnter, BoxCover2.MouseEnter, RadioCard3.MouseEnter, BoxCover3.MouseEnter
        TxtFlavour.Text = "Change the look of the cards!"

    End Sub

    Private Sub BtnResetAll_MouseEnter(sender As Object, e As EventArgs) Handles BtnResetAll.MouseEnter
        TxtFlavour.Text = "Nuke it all!"

    End Sub

    Private Sub BtnEditList_MouseEnter(sender As Object, e As EventArgs) Handles BtnEditList.MouseEnter
        TxtFlavour.Text = "Edit the Custom word list"

    End Sub

    Private Sub BtnHowImg_MouseEnter(sender As Object, e As EventArgs) Handles BtnHowImg.MouseEnter
        TxtFlavour.Text = "Add Custom cards to play with"

    End Sub

    Private Sub BtnSave_MouseEnter(sender As Object, e As EventArgs) Handles BtnSave.MouseEnter
        TxtFlavour.Text = "Save your settings!"

    End Sub

    Private Sub BtnCancel_MouseEnter(sender As Object, e As EventArgs) Handles BtnCancel.MouseEnter
        TxtFlavour.Text = "Leave without saving"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlightb

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarkb

        End Select

    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave, BtnCancel.MouseUp
        TxtFlavour.Text = "Customise your experience!"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlighta

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarka

        End Select

    End Sub

    Private Sub BtnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancel.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlightc

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarkc

        End Select

    End Sub

    Private Sub BtnCredits_MouseEnter(sender As Object, e As EventArgs) Handles BtnCredits.MouseEnter
        TxtFlavour.Text = "View the credits"

    End Sub

    Private Sub UnHover(sender As Object, e As EventArgs) Handles CheckTitleSkip.MouseLeave, CheckDebug.MouseLeave, CheckShowCards.MouseLeave, RadioCard1.MouseLeave, BoxCover1.MouseLeave, RadioCard2.MouseLeave, BoxCover2.MouseLeave, RadioCard3.MouseLeave, BoxCover3.MouseLeave, BtnResetAll.MouseLeave, BtnEditList.MouseLeave, BtnHowImg.MouseLeave, BtnSave.MouseLeave, BtnCredits.MouseLeave, CheckBGMute.MouseLeave, CheckSFXMute.MouseLeave
        TxtFlavour.Text = "Customise your experience!"

    End Sub

    'Calling the NAudio Package to be able to pause or play audio via WaveOut
    Private Sub MuteAudio() 'When audio is to be muted
        MainForm.WaveBGM.Pause()

    End Sub

    Private Sub UnmuteAudio() 'When audio is to be unmuted
        MainForm.WaveBGM.Play()

    End Sub

End Class
