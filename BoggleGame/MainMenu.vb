Public Class MainMenu

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click 'Settings
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)

        Settings1.LoadSettings() 'Makes sure settings are properly set when entering

        'Shuffle dem menus
        Settings1.Show()

        MainForm.Text = "Boggle - Settings and Other"

    End Sub

    Private Sub BtnWordMem_Click(sender As Object, e As EventArgs) Handles BtnWordMem.Click 'Word Memory
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        WordDifficultySelect1.Show()

        MainForm.Text = "Boggle - Word Memory"

    End Sub

    Private Sub BtnImgMem_Click(sender As Object, e As EventArgs) Handles BtnImgMem.Click 'Image Match
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        ImageDifficultySelect1.Show()

        MainForm.Text = "Boggle - Image Match"

    End Sub

    Private Sub BtnScores_Click(sender As Object, e As EventArgs) Handles BtnScores.Click 'Records
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        msgbox = True
        RecordsForm.GetRecords()
        RecordsForm.ShowDialog()

    End Sub

    Private Sub BtnTheme_Click(sender As Object, e As EventArgs) Handles BtnTheme.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        SettingsTheme.ThemeLoad()
        SettingsTheme.Location = MainForm.Location
        MainForm.Hide()
        SettingsTheme.Show()

    End Sub

    'Checks key pressed
    Public CtrlPressed As Boolean = False
    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            CtrlPressed = True

        End If

    End Sub

    Private Sub MainMenu_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        CtrlPressed = False

    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        ActiveControl = Nothing

        If CtrlPressed = True Then 'If it is the Ctrl key
            CtrlPressed = False 'Set the key pressed to pause
            Application.Restart() 'Restart app
            MainForm.Focus()
            Exit Sub

        End If

        'If not, do everything else normally
        msgbox = True
        If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()

        Else
            MainMenu1.TxtFlavour.Text = "Handy tip go here"
            MainMenu1.TxtMenuName.Text = "Welcome to Boggle"

        End If

        msgbox = False

    End Sub

    'Handles a lot of messy hover tools
    Private Sub BtnSettings_MouseEnter(sender As Object, e As EventArgs) Handles BtnSettings.MouseEnter
        TxtFlavour.Text = "Access game settings and other items"
        TxtMenuName.Text = "Settings"

    End Sub

    Private Sub BtnWordMem_MouseEnter(sender As Object, e As EventArgs) Handles BtnWordMem.MouseEnter
        TxtFlavour.Text = "Type as many words as you can in 60 seconds!"
        TxtMenuName.Text = "Word Memory"

    End Sub

    Private Sub BtnImgMem_MouseEnter(sender As Object, e As EventArgs) Handles BtnImgMem.MouseEnter
        TxtFlavour.Text = "Match cards in the shortest time possible!"
        TxtMenuName.Text = "Image Match"

    End Sub

    Private Sub BtnScores_MouseEnter(sender As Object, e As EventArgs) Handles BtnScores.MouseEnter
        TxtFlavour.Text = "Check out your high scores!"
        TxtMenuName.Text = "Records"

    End Sub

    Private Sub BtnTheme_MouseEnter(sender As Object, e As EventArgs) Handles BtnTheme.MouseEnter
        TxtFlavour.Text = "Change the look of Boggle!"
        TxtMenuName.Text = "Theme Settings"

    End Sub

    Private Sub Exit_MouseLeave(sender As Object, e As EventArgs) Handles BtnSettings.MouseLeave, BtnWordMem.MouseLeave, BtnImgMem.MouseLeave, BtnTheme.MouseLeave
        TxtFlavour.Text = "Handy tip go here"
        TxtMenuName.Text = "Welcome to Boggle"

    End Sub

    Public msgbox As Boolean = False
    Private Sub BtnScores_MouseLeave(sender As Object, e As EventArgs) Handles BtnScores.MouseLeave
        If msgbox = False Then
            TxtFlavour.Text = "Handy tip go here"
            TxtMenuName.Text = "Welcome to Boggle"
        End If

    End Sub

    Private Sub BtnQuit_MouseEnter(sender As Object, e As EventArgs) Handles BtnQuit.MouseEnter
        TxtFlavour.Text = "Quits the game"
        TxtMenuName.Text = "Come again soon"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnQuit.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnQuit.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnQuit_MouseLeave(sender As Object, e As EventArgs) Handles BtnQuit.MouseLeave
        TxtFlavour.Text = "Handy tip go here"
        TxtMenuName.Text = "Welcome to Boggle"
        Select Case My.Settings.Theme
            Case 0, 1
                BtnQuit.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnQuit.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnQuit_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnQuit.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnQuit.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnQuit.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnQuit_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnQuit.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnQuit.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnQuit.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

End Class
