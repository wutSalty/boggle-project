Module UserControls

    'Collection of Controls and Forms to be able to reference when opening or closing menus
    Public FirstTimeScreen1 As New FirstTimeScreen With {.Dock = DockStyle.Fill}
    Public Title_Screen1 As New Title_Screen With {.Dock = DockStyle.Fill}
    Public MainMenu1 As New MainMenu With {.Dock = DockStyle.Fill}
    Public Settings1 As New Settings With {.Dock = DockStyle.Fill}

    Public WordDifficultySelect1 As New WordDifficultySelect With {.Dock = DockStyle.Fill}
    Public WordMemoryGame1 As New WordMemoryGame With {.Dock = DockStyle.Fill}
    Public WordResults1 As New WordResults With {.Dock = DockStyle.Fill}

    Public ImageDifficultySelect1 As New ImageDifficultySelect With {.Dock = DockStyle.Fill}
    Public ImageMatchGame1 As New ImageMatchGame With {.Dock = DockStyle.Fill}

    Public TheMenus(8)

    'Updates everything to display the proper theme on load
    Public Sub CheckTheme()
        Select Case My.Settings.Theme
            Case 0 'Green
                MainForm.BackgroundImage = My.Resources.bgmainmenu

                Title_Screen1.BackgroundImage = My.Resources.titlescreen
                MainMenu1.BackgroundImage = My.Resources.bgmainmenu
                RecordsForm.BackgroundImage = My.Resources.bgresults

                Settings1.BackgroundImage = My.Resources.bgmainmenu
                HowToImage.BackgroundImage = My.Resources.howtos
                HowToWordList.BackgroundImage = My.Resources.howtos
                Credits.BackgroundImage = My.Resources.bgcredits

                FormExplain.BackgroundImage = My.Resources.bgwordcustom
                WordDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu
                ImageDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu

                WordCustomForm.BackgroundImage = My.Resources.bgwordcustom
                WordMemoryGame1.BackgroundImage = My.Resources.wordbg
                WordResults1.BackgroundImage = My.Resources.bgwordresults
                WordResultsList.BackgroundImage = My.Resources.wordresultslist

                ImageMatchForm.BackgroundImage = My.Resources.imagebg

                ImageResults.BackgroundImage = My.Resources.bgimageresults

                UpdateToLight() 'Makes sure all the text and buttons are the right ones

            Case 1 'Blue
                MainForm.BackgroundImage = My.Resources.bgmainmenu1

                Title_Screen1.BackgroundImage = My.Resources.titlescreen1
                MainMenu1.BackgroundImage = My.Resources.bgmainmenu1
                RecordsForm.BackgroundImage = My.Resources.bgresults1

                Settings1.BackgroundImage = My.Resources.bgmainmenu1
                HowToImage.BackgroundImage = My.Resources.howtos1
                HowToWordList.BackgroundImage = My.Resources.howtos1
                Credits.BackgroundImage = My.Resources.bgcredits1

                FormExplain.BackgroundImage = My.Resources.bgwordcustom1
                WordDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu1
                ImageDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu1

                WordCustomForm.BackgroundImage = My.Resources.bgwordcustom1
                WordMemoryGame1.BackgroundImage = My.Resources.wordbg1
                WordResults1.BackgroundImage = My.Resources.bgwordresults1
                WordResultsList.BackgroundImage = My.Resources.wordresultslist1

                ImageMatchForm.BackgroundImage = My.Resources.imagebg1

                ImageResults.BackgroundImage = My.Resources.bgimageresults1

                UpdateToLight() 'Makes sure all the text and buttons are the right ones

            Case 2 'DARK MODE DARK MODE
                MainForm.BackgroundImage = My.Resources.bgmainmenu2

                Title_Screen1.BackgroundImage = My.Resources.titlescreen2
                MainMenu1.BackgroundImage = My.Resources.bgmainmenu2
                RecordsForm.BackgroundImage = My.Resources.bgresults2

                Settings1.BackgroundImage = My.Resources.bgmainmenu2
                HowToImage.BackgroundImage = My.Resources.howtos2
                HowToWordList.BackgroundImage = My.Resources.howtos2
                Credits.BackgroundImage = My.Resources.bgcredits2

                FormExplain.BackgroundImage = My.Resources.bgwordcustom2
                WordDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu2
                ImageDifficultySelect1.BackgroundImage = My.Resources.bgmainmenu2

                WordCustomForm.BackgroundImage = My.Resources.bgwordcustom2
                WordMemoryGame1.BackgroundImage = My.Resources.wordbg2
                WordResults1.BackgroundImage = My.Resources.bgwordresults2
                WordResultsList.BackgroundImage = My.Resources.wordresultslist2

                ImageMatchForm.BackgroundImage = My.Resources.imagebg2

                ImageResults.BackgroundImage = My.Resources.bgimageresults2

                UpdateAllToDark() 'Makes sure all the text and buttons are the right ones

            Case Else

        End Select

    End Sub

    'Sets all buttons and text to work with the "Dark" theme
    Private Sub UpdateAllToDark()
        Dim DarkText = SystemColors.ControlLightLight 'Text colours
        Dim DarkBtn = ColorTranslator.FromHtml("#4f4f4f") '575757 2b2b2b 5a5a5a 6a6a6a 6f6f6f Button colours

        MainForm.ForeColor = DarkText
        MainForm.BackColor = DarkBtn
        MainForm.BtnMini.FlatAppearance.MouseDownBackColor = Color.DimGray
        MainForm.BtnMini.FlatAppearance.MouseOverBackColor = Color.DimGray
        MainForm.PanelGrab.BackgroundImage = My.Resources.dragbar1

        Title_Screen1.txtTitleGame.ForeColor = DarkText
        Title_Screen1.BtnStartApp.ForeColor = DarkText
        Title_Screen1.BtnStartApp.BackgroundImage = My.Resources.basedarka

        MainMenu1.BackColor = DarkBtn
        MainMenu1.BtnQuit.BackgroundImage = My.Resources.basedarka
        MainMenu1.BtnImgMem.BackgroundImage = My.Resources.imageicondark
        MainMenu1.BtnWordMem.BackgroundImage = My.Resources.wordicondark
        MainMenu1.BtnScores.BackgroundImage = My.Resources.recordsicondark
        MainMenu1.BtnSettings.BackgroundImage = My.Resources.settingsicondark

        RecordsForm.ForeColor = DarkText
        RecordsForm.BackColor = DarkBtn
        RecordsForm.PanelGrab.BackgroundImage = My.Resources.dragbar1
        RecordsForm.BtnExit.BackgroundImage = My.Resources.basedarka

        Settings1.BackColor = DarkBtn
        Settings1.BtnCancel.BackgroundImage = My.Resources.backdarka

        HowToImage.ForeColor = DarkText
        HowToImage.BackColor = DarkBtn
        HowToImage.PanelGrab.BackgroundImage = My.Resources.dragbar1
        HowToImage.BtnOK.BackgroundImage = My.Resources.basedarka

        HowToWordList.ForeColor = DarkText
        HowToWordList.BackColor = DarkBtn
        HowToWordList.PanelGrab.BackgroundImage = My.Resources.dragbar1
        HowToWordList.BtnOK.BackgroundImage = My.Resources.basedarka
        HowToWordList.BtnCancel.BackgroundImage = My.Resources.basedarka

        Credits.ForeColor = DarkText
        Credits.BackColor = DarkBtn
        Credits.PanelGrab.BackgroundImage = My.Resources.dragbar1
        Credits.BtnClose.BackgroundImage = My.Resources.basedarka

        FormExplain.ForeColor = DarkText
        FormExplain.BackColor = DarkBtn
        FormExplain.PanelGrab.BackgroundImage = My.Resources.dragbar1
        FormExplain.BtnClose.BackgroundImage = My.Resources.basedarka

        WordDifficultySelect1.BackColor = DarkBtn
        WordDifficultySelect1.BtnReturn.BackgroundImage = My.Resources.backdarka
        WordDifficultySelect1.BtnEasy.ForeColor = DarkText
        WordDifficultySelect1.BtnMed.ForeColor = DarkText
        WordDifficultySelect1.BtnHard.ForeColor = DarkText
        WordDifficultySelect1.BtnCustom.ForeColor = DarkText

        ImageDifficultySelect1.BackColor = DarkBtn
        ImageDifficultySelect1.BtnReturn.BackgroundImage = My.Resources.backdarka

        WordCustomForm.ForeColor = DarkText
        WordCustomForm.BackColor = DarkBtn
        WordCustomForm.PanelGrab.BackgroundImage = My.Resources.dragbar1
        WordCustomForm.BoxDiff.BackColor = SystemColors.ControlDark
        WordCustomForm.BoxGameTime.BackColor = SystemColors.ControlDark
        WordCustomForm.BoxPrepTime.BackColor = SystemColors.ControlDark
        WordCustomForm.BoxDiff.ForeColor = DarkText
        WordCustomForm.BoxGameTime.ForeColor = DarkText
        WordCustomForm.BoxPrepTime.ForeColor = DarkText
        WordCustomForm.BtnStart.BackgroundImage = My.Resources.basedarka

        WordMemoryGame1.BackColor = DarkBtn

        WordResults1.BackColor = DarkBtn
        WordResults1.BtnPlayAgain.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        WordResults1.BtnReturnHome.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        WordResults1.BtnSameAgain.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        WordResults1.BtnResults.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        WordResults1.BtnPlayAgain.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        WordResults1.BtnReturnHome.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        WordResults1.BtnSameAgain.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        WordResults1.BtnResults.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")

        WordResultsList.ForeColor = DarkText
        WordResultsList.BackColor = DarkBtn
        WordResultsList.ListResults.BackColor = SystemColors.WindowFrame
        WordResultsList.ListResults.ForeColor = DarkText
        WordResultsList.TxtOverrideHeader1.BackColor = DarkBtn
        WordResultsList.TxtOverrideHeader2.BackColor = DarkBtn
        WordResultsList.PanelGrab.BackgroundImage = My.Resources.dragbar1

        ImageMatchForm.ForeColor = DarkText
        ImageMatchForm.BackColor = DarkBtn
        ImageMatchForm.BtnMini.FlatAppearance.MouseDownBackColor = Color.DimGray
        ImageMatchForm.BtnMini.FlatAppearance.MouseOverBackColor = Color.DimGray
        ImageMatchForm.PanelGrab.BackgroundImage = My.Resources.dragbar1

        ImageResults.ForeColor = DarkText
        ImageResults.BackColor = DarkBtn
        ImageResults.BtnPlayAgain.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        ImageResults.BtnReturnHome.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        ImageResults.BtnSameAgain.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3b3b3b")
        ImageResults.BtnPlayAgain.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        ImageResults.BtnReturnHome.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        ImageResults.BtnSameAgain.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#242424")
        ImageResults.PanelGrab.BackgroundImage = My.Resources.dragbar1

    End Sub

    'Sets all buttons and text to work with the "Light" Themes
    Private Sub UpdateToLight()
        Dim LightText = SystemColors.ControlText 'Text colours
        Dim LightBtn = SystemColors.ControlLight ' Button colours

        MainForm.ForeColor = LightText
        MainForm.BackColor = LightBtn
        MainForm.BtnMini.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
        MainForm.BtnMini.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        MainForm.PanelGrab.BackgroundImage = My.Resources.dragbar

        FirstTimeScreen1.BtnToTitle.BackgroundImage = My.Resources.baselighta

        Title_Screen1.txtTitleGame.ForeColor = LightText
        Title_Screen1.BtnStartApp.ForeColor = LightText
        Title_Screen1.BtnStartApp.BackgroundImage = My.Resources.baselighta

        MainMenu1.BackColor = LightBtn
        MainMenu1.BtnQuit.BackgroundImage = My.Resources.baselighta
        MainMenu1.BtnImgMem.BackgroundImage = My.Resources.imageiconlight2
        MainMenu1.BtnWordMem.BackgroundImage = My.Resources.wordiconlight2
        MainMenu1.BtnScores.BackgroundImage = My.Resources.recordsiconlight1
        MainMenu1.BtnSettings.BackgroundImage = My.Resources.settingsiconlight

        RecordsForm.ForeColor = LightText
        RecordsForm.BackColor = LightBtn
        RecordsForm.PanelGrab.BackgroundImage = My.Resources.dragbar
        RecordsForm.BtnExit.BackgroundImage = My.Resources.baselighta

        Settings1.BackColor = LightBtn
        Settings1.BtnCancel.BackgroundImage = My.Resources.backlighta

        HowToImage.ForeColor = LightText
        HowToImage.BackColor = LightBtn
        HowToImage.PanelGrab.BackgroundImage = My.Resources.dragbar
        HowToImage.BtnOK.BackgroundImage = My.Resources.baselighta

        HowToWordList.ForeColor = LightText
        HowToWordList.BackColor = LightBtn
        HowToWordList.PanelGrab.BackgroundImage = My.Resources.dragbar
        HowToWordList.BtnOK.BackgroundImage = My.Resources.baselighta
        HowToWordList.BtnCancel.BackgroundImage = My.Resources.baselighta

        Credits.ForeColor = LightText
        Credits.BackColor = LightBtn
        Credits.PanelGrab.BackgroundImage = My.Resources.dragbar
        Credits.BtnClose.BackgroundImage = My.Resources.baselighta

        FormExplain.ForeColor = LightText
        FormExplain.BackColor = LightBtn
        FormExplain.PanelGrab.BackgroundImage = My.Resources.dragbar
        FormExplain.BtnClose.BackgroundImage = My.Resources.baselighta

        WordDifficultySelect1.BackColor = LightBtn
        WordDifficultySelect1.BtnReturn.BackgroundImage = My.Resources.backlighta
        WordDifficultySelect1.BtnEasy.ForeColor = Color.ForestGreen
        WordDifficultySelect1.BtnMed.ForeColor = Color.DarkOrange
        WordDifficultySelect1.BtnHard.ForeColor = Color.Red
        WordDifficultySelect1.BtnCustom.ForeColor = Color.DodgerBlue

        ImageDifficultySelect1.BackColor = LightBtn
        ImageDifficultySelect1.BtnReturn.BackgroundImage = My.Resources.backlighta

        WordCustomForm.ForeColor = LightText
        WordCustomForm.BackColor = LightBtn
        WordCustomForm.PanelGrab.BackgroundImage = My.Resources.dragbar
        WordCustomForm.BoxDiff.BackColor = SystemColors.Window
        WordCustomForm.BoxGameTime.BackColor = SystemColors.Window
        WordCustomForm.BoxPrepTime.BackColor = SystemColors.Window
        WordCustomForm.BoxDiff.ForeColor = SystemColors.WindowText
        WordCustomForm.BoxGameTime.ForeColor = SystemColors.WindowText
        WordCustomForm.BoxPrepTime.ForeColor = SystemColors.WindowText
        WordCustomForm.BtnStart.BackgroundImage = My.Resources.baselighta

        WordMemoryGame1.BackColor = LightBtn

        WordResults1.BackColor = LightBtn
        WordResults1.BtnPlayAgain.FlatAppearance.MouseOverBackColor = Nothing
        WordResults1.BtnReturnHome.FlatAppearance.MouseOverBackColor = Nothing
        WordResults1.BtnSameAgain.FlatAppearance.MouseOverBackColor = Nothing
        WordResults1.BtnResults.FlatAppearance.MouseOverBackColor = Nothing
        WordResults1.BtnPlayAgain.FlatAppearance.MouseDownBackColor = Nothing
        WordResults1.BtnReturnHome.FlatAppearance.MouseDownBackColor = Nothing
        WordResults1.BtnSameAgain.FlatAppearance.MouseDownBackColor = Nothing
        WordResults1.BtnResults.FlatAppearance.MouseDownBackColor = Nothing

        WordResultsList.ForeColor = LightText
        WordResultsList.BackColor = LightBtn
        WordResultsList.ListResults.BackColor = Color.White
        WordResultsList.ListResults.ForeColor = LightText
        WordResultsList.TxtOverrideHeader1.BackColor = Color.White
        WordResultsList.TxtOverrideHeader2.BackColor = Color.White
        WordResultsList.PanelGrab.BackgroundImage = My.Resources.dragbar

        ImageMatchForm.ForeColor = LightText
        ImageMatchForm.BackColor = LightBtn
        ImageMatchForm.BtnMini.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
        ImageMatchForm.BtnMini.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
        ImageMatchForm.PanelGrab.BackgroundImage = My.Resources.dragbar

        ImageResults.ForeColor = LightText
        ImageResults.BackColor = LightBtn
        ImageResults.BtnPlayAgain.FlatAppearance.MouseOverBackColor = Nothing
        ImageResults.BtnReturnHome.FlatAppearance.MouseOverBackColor = Nothing
        ImageResults.BtnSameAgain.FlatAppearance.MouseOverBackColor = Nothing
        ImageResults.BtnPlayAgain.FlatAppearance.MouseDownBackColor = Nothing
        ImageResults.BtnReturnHome.FlatAppearance.MouseDownBackColor = Nothing
        ImageResults.BtnSameAgain.FlatAppearance.MouseDownBackColor = Nothing
        ImageResults.PanelGrab.BackgroundImage = My.Resources.dragbar

    End Sub

    'Orders each menu properly so they can be shown or hidden
    Public Sub LoadMenus()
        'Just an array to make life a little easier
        TheMenus(8) = FirstTimeScreen1
        TheMenus(7) = Title_Screen1
        TheMenus(6) = MainMenu1
        TheMenus(5) = Settings1
        TheMenus(4) = WordDifficultySelect1
        TheMenus(3) = WordMemoryGame1
        TheMenus(2) = WordResults1
        TheMenus(1) = ImageDifficultySelect1
        TheMenus(0) = ImageMatchGame1

        'For every control/menu, add them to the Main Form. Then Hide them all until they're needed again
        For Each Menu In TheMenus
            MainForm.Controls.Add(Menu)
            Menu.Hide()

        Next

    End Sub

End Module
