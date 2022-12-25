Public Class DebugForm

    Private Sub DebugForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateDebug()

    End Sub

    Public Sub UpdateDebug() 'Updates all the things on the menu
        'Settings/Status
        TxtFirstTimeStat.Text = "FirstTime: " & My.Settings.FirstTime.ToString
        TxtSkipTitleStat.Text = "SkipTitle: " & My.Settings.SkipTitle.ToString
        TxtShowDeck.Text = "Show Card Deck: " & My.Settings.ShowCardDeck.ToString
        TxtTheme.Text = "Theme: " & My.Settings.Theme.ToString

        'Word game setup
        TxtWordDiff.Text = "Word Difficulty: " & MainForm.WordDifficulty
        TxtRegLength.Text = "Reg File Length: " & Randomise.RegLineCount
        TxtSpcLength.Text = "Spc File Length: " & Randomise.SpcLineCount

        'Word game scores
        TxtEasyHigh.Text = "Word Easy High: " & My.Settings.WordEasyTop.ToString
        TxtMedHigh.Text = "Word Medium High: " & My.Settings.WordMedTop.ToString
        TxtHardHigh.Text = "Word Hard High: " & My.Settings.WordHardTop.ToString

        'Image game setup
        TxtImgDiff.Text = "Image Difficulty: " & MainForm.ImageDifficulty
        TxtCardBack.Text = "CardBack is: " & My.Settings.CardBack.ToString

        'Image game scores
        TxtImageA.Text = "Image A High: " & My.Settings.ImageA.ToString
        TxtImageB.Text = "Image B High: " & My.Settings.ImageB.ToString
        TxtImageC.Text = "Image C High: " & My.Settings.ImageC.ToString

    End Sub

    Public Sub UpdateWordList() 'Updates the listbox with the list of words (might freeze program if enabled)
        ListDebug.Items.Clear()

        For Each item As String In Randomise.RandomWordList
            ListDebug.Items.Add(item)

        Next
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

End Class