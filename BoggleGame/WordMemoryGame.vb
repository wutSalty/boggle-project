Public Class WordMemoryGame
    'Timer preperation
    Dim preptime As Integer = Nothing 'total time for prep
    Dim gametime As Integer = Nothing 'total time for game
    Dim preptimeleft As Integer = Nothing 'seconds left for preptime
    Dim gametimeleft As Integer = Nothing 'seconds left for game time
    Public preping As Boolean = False 'flags for prep time
    Public gameing As Boolean = False 'flags for game time

    'Keeps track of height for custom progress bar
    Dim panelheight As Integer = Nothing

    'Variables to keep track of game progress
    Public score As Integer = 0 'game score
    Dim wordskip As Integer = Nothing 'sets how much words should be skipped by
    Dim CurrentWord As String = Nothing 'the current word that is shown
    Dim CheckWord As String = Nothing 'the word that is to be checked with
    Dim UserWord As String = Nothing 'the word which the user inputs
    Dim ForWord As Integer = 0 'keeps track of current index in list

    'Variables to keep track of game state
    Public IsPaused As Boolean = False 'Is the game paused or not
    Dim timercolour As Color = Nothing 'Gets the colour of the progress bar
    Dim usertemp As String = Nothing 'Stores the word the user has in the box

    'Keeps track of the user's answers
    Public UserList As New List(Of String) 'The words the user puts in
    Public PassedList As New List(Of String) 'The word that is expected

    Public Sub PrePrep() 'Sets up everything required for the game before it begins. Required in the case of a replay

        Select Case MainForm.WordDifficulty 'Sets timings on a per difficulty basis. Supports custom settings too
            Case 1, 2, 3 'Easy Or Medium Or Hard
                preptime = 5
                gametime = 60

                preptimeleft = 5
                gametimeleft = 60

                wordskip = MainForm.WordDifficulty

            Case Else 'Sets the required variables for the custom game based off the WordCustomForm
                preptime = WordCustomForm.TimePrep
                gametime = WordCustomForm.TimeGame

                preptimeleft = preptime
                gametimeleft = gametime

                wordskip = WordCustomForm.Diff

        End Select

        score = 0 'Resets score just-in-case
        ForWord = 0 'Resets index just-in-case
        UserWord = Nothing

        'Resetting custom progress bar
        panelheight = gametimeleft / gametime * 300
        PanelBehind.Top += PanelBehind.Height - panelheight
        PanelBehind.Height = panelheight
        PanelBehind.BackColor = Color.Gray

        'Resets game state variables
        IsPaused = False
        timercolour = Nothing
        usertemp = Nothing

        TxtStatus.Text = "Remember these words..."

        'Reset lists
        UserList.Clear()
        PassedList.Clear()

        PanelBehind.BringToFront() 'Workaround for custom progress bar

        ActiveControl = AnswerBox
        AnswerBox.ReadOnly = True 'Disables textbox during prep time
        AnswerBox.BackColor = SystemColors.ScrollBar 'Shows to user that textbox is unaccessible
        AnswerBox.TextAlign = HorizontalAlignment.Center 'Centers text during countdown

        TimerCountdown.Stop() 'Stops timer from going ahead
        Ih8VB.Start()

        BeginPrep() 'Begins the prep phase

    End Sub

    Private Sub BeginPrep()
        preping = True 'Flags that the game is still in the pre-play phase
        gameing = False 'Game has not started

        TxtDiff.Text = "Difficulty: " & MainForm.WordDifficultyTxt 'Shows current difficulty
        preptimeleft = preptime 'reset current time for multiple words
        TxtScore.Text = "Score: " & score
        TxtTimer.Text = gametime.ToString 'Shows the time in a label
        AnswerBox.Text = preptime

        CurrentWord = RandomWordList(ForWord)
        TxtCurrent.Text = CurrentWord

        TimerCountdown.Start() 'Begins the countdown

    End Sub

    'Forces textbox to be focused whether it wants to or not
    Private Sub Ih8VB_Tick() Handles Ih8VB.Tick
        Ih8VB.Stop()
        ActiveControl = AnswerBox

    End Sub

    Private Sub TimerCountdown_Tick() Handles TimerCountdown.Tick '100% handles the ticking down of the timer
        If preping = True Then 'Checks if text should be edited in textbox or timer label
            If preptimeleft > 1 Then 'Make sures there's still time on the clock and updates text accordingly
                preptimeleft -= 1
                AnswerBox.Text = preptimeleft.ToString

            Else
                TimerCountdown.Stop() 'Once the timer reaches zero, stops the timer
                CheckWordPos()

            End If

        Else 'Updates label instead of textbox and bar
            If gametimeleft > 1 Then
                gametimeleft -= 1
                TxtTimer.Text = gametimeleft & " seconds"
                panelheight = gametimeleft / gametime * 300
                PanelBehind.Top += PanelBehind.Height - panelheight
                PanelBehind.Height = panelheight

            Else
                gameing = False
                TimerCountdown.Stop()
                EndGame()

            End If
        End If

    End Sub

    Private Sub CheckWordPos()
        If ForWord + 1 - wordskip < 0 Then 'Uses current difficulty to calculate whether prep time continues or not
            ForWord += 1
            BeginPrep()

        Else 'If not then continue on
            gameing = True 'The game has started
            preping = False 'Disable's flag which indicates its the game is about to start proper

            PanelBehind.BackColor = Color.DodgerBlue

            'Updates textbox to allow input
            AnswerBox.ReadOnly = False
            AnswerBox.BackColor = Color.White
            AnswerBox.Text = ""

            TimerCountdown.Start()
            StepWord() 'Begins stepping of words
        End If

    End Sub

    Private Sub StepWord() 'Increases index of list by 1 then displays the new word
        ForWord += 1
        If ForWord > RandomWordList.Count Then
            ForWord = 0
        End If
        CurrentWord = RandomWordList(ForWord)
        TxtCurrent.Text = CurrentWord

    End Sub

    Private Sub AnswerBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles AnswerBox.KeyPress 'Detects whether a key has been pressed
        If gameing = False Then 'No pressing button if game hasn't started yet
            Exit Sub
        End If

        Select Case e.KeyChar 'Makes sures the user can't input non-alphabet characters
            Case Chr(32) To Chr(64)
                e.Handled = True

            Case Chr(91) To Chr(96)
                e.Handled = True

            Case Chr(123) To Chr(255)
                e.Handled = True

            Case Else
                Exit Select

        End Select

        If e.KeyChar = ChrW(Keys.Enter Or Keys.Return) Then 'If it is the Enter or Return key
            e.Handled = True 'Make the textbox ignore it
            UserWord = AnswerBox.Text.ToLower 'Saves the user input and into lowercase

            UserList.Add(UserWord) 'Adds the word to userlist
            PassedList.Add(RandomWordList(ForWord - wordskip)) 'Gets the corresponding word to add to a second list

            AnswerBox.Clear() 'Clears anything inside the textbox
            CheckAns()

        End If
    End Sub

    Private Sub CheckAns() 'Checks answer
        If UserWord = RandomWordList(ForWord - wordskip) Then 'Compares user answer to the expected answer
            score += 1 'Add a correct indicator
            PanelBehind.BackColor = Color.Green 'Show that it is correct
            TxtScore.Text = "Score: " & score.ToString 'Update score

        Else 'If wrong
            PanelBehind.BackColor = Color.Red 'Show that it's wrong

        End If

        StepWord() 'Continue onto next word
        UserWord = Nothing 'Reset the word

    End Sub

    Private Sub EndGame() 'Once timer reaches zero, switch to results screen
        AnswerBox.ReadOnly = True
        ActiveControl = Nothing
        WordResults1.LoadResults()
        WordResults1.Show()

    End Sub

    Public Sub PauseGame() 'Subroutine to pause or resume the game when requested
        If IsPaused = False Then 'If the game needs to be paused
            TimerCountdown.Stop() 'Pauses timer

            usertemp = AnswerBox.Text 'Stores the current text from the box

            AnswerBox.ReadOnly = True 'Disables textbox
            AnswerBox.BackColor = SystemColors.ScrollBar 'Shows to user that textbox is unaccessible
            AnswerBox.Text = "Paused" 'Tells user that the game is currenly in a paused state

            TxtStatus.Text = "No cheating ;)"
            TxtCurrent.Text = "Currently Paused"
            BtnPause.Text = "Resume Game" 'Changes button text

            timercolour = PanelBehind.BackColor 'Gets current colour of bar
            PanelBehind.BackColor = Color.Gray 'Shows the timer is currently paused

            IsPaused = True 'Keep track of game state

        ElseIf IsPaused = True Then 'If the game needs to be started
            TimerCountdown.Start() 'Starts timer

            TxtStatus.Text = "Remember these words..."
            TxtCurrent.Text = CurrentWord 'Shows current word again
            BtnPause.Text = "Pause Game" 'Changes button text

            PanelBehind.BackColor = timercolour

            IsPaused = False 'Keep track of game state

            If preping = False Then 'Resets inputs and outputs depending whether input it allowed yet or not
                AnswerBox.ReadOnly = False 'Enables textbox
                AnswerBox.BackColor = Color.White 'Shows to user that textbox is accessible
                AnswerBox.Text = usertemp 'Returns the word the user had in here

            Else
                AnswerBox.Text = preptimeleft

            End If

        End If

    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        PauseGame()

    End Sub

    Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
        ActiveControl = Nothing
        If IsPaused = True Then
            If MessageBox.Show("Are you sure you want to quit the game early?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Hide()

            End If

        Else
            PauseGame()
            If MessageBox.Show("Are you sure you want to quit the game early?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Hide()

            Else
                PauseGame()

            End If

        End If

    End Sub

End Class
