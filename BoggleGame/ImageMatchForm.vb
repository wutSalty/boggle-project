Public Class ImageMatchForm
    'Variables required to keep the game running
    Dim gamestart As Boolean = False 'Has the game started yet
    Dim gamepause As Boolean = False 'Is the game paused
    Public seconds As Integer = 0 'Secconds on the clock
    Public millisec As Integer = 0 'Milliseconds on the clock
    Dim cardsleft As Integer = 9 'How many pairs remain

    Dim pairselect As Integer 'Keeps track of how many cards already selected
    Dim pairpick(2) As Integer 'The cards which were picked by the user
    Dim movebehind(18) As Integer 'Assigns every card a number. Also handles the "doubling" of cards
    Dim ZaTime As Integer = 0 'Timer that handles hiding the cards again

    Public cardlist(17) As PictureBox 'All of the card's pictureboxes in an array
    Public imglist(8) As PictureBox 'The pictures that are going to be used

    Dim WasMini As Boolean = False 'Try and detect when the app was minimised

    'Transparancy Key To Try And break the breaking
    Private Sub ImageMatchForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        TransparencyKey = Nothing

    End Sub

    'All setup. Send Help
    Public Sub LoadGame()
        'Set things up
        Timer.Stop()
        Countdown.Stop()
        gamestart = False
        gamepause = False
        pairselect = 1
        cardsleft = 9
        TxtCardsLeft.Text = "Pairs left:" & Environment.NewLine & cardsleft
        seconds = 0
        millisec = 0
        TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec
        GifBox.Image = Nothing
        GifBox.Image = My.Resources.AppIcon1
        GifBox.Enabled = False
        BtnPause.Text = "Pause Game"

        'Gets ShowCardDeck from settings
        PBack.Visible = My.Settings.ShowCardDeck
        Pic1.Visible = My.Settings.ShowCardDeck
        Pic2.Visible = My.Settings.ShowCardDeck
        Pic3.Visible = My.Settings.ShowCardDeck
        Pic4.Visible = My.Settings.ShowCardDeck
        Pic5.Visible = My.Settings.ShowCardDeck
        Pic6.Visible = My.Settings.ShowCardDeck
        Pic7.Visible = My.Settings.ShowCardDeck
        Pic8.Visible = My.Settings.ShowCardDeck
        Pic9.Visible = My.Settings.ShowCardDeck

        'If a custom card back exists
        If (File.Exists("Assets\CustomPic\cardback.png")) Then
            Using str As Stream = File.OpenRead("Assets\CustomPic\cardback.png") 'Use the custom card back
                PBack.BackgroundImage = Image.FromStream(str)

            End Using

        Else 'Or else
            Select Case My.Settings.CardBack 'Use the backs from the settings
                Case 1
                    PBack.BackgroundImage = My.Resources.cardback

                Case 2
                    PBack.BackgroundImage = My.Resources.cardback1

                Case 3
                    PBack.BackgroundImage = My.Resources.cardback2

                Case Else
                    PBack.BackgroundImage = My.Resources.cardback

            End Select

        End If

        'Assigns cards to indexes
        cardlist(0) = PB1
        cardlist(1) = PB2
        cardlist(2) = PB3
        cardlist(3) = PB4
        cardlist(4) = PB5
        cardlist(5) = PB6
        cardlist(6) = PB7
        cardlist(7) = PB8
        cardlist(8) = PB9
        cardlist(9) = PB10
        cardlist(10) = PB11
        cardlist(11) = PB12
        cardlist(12) = PB13
        cardlist(13) = PB14
        cardlist(14) = PB15
        cardlist(15) = PB16
        cardlist(16) = PB17
        cardlist(17) = PB18

        'Assigns card backs to each visible card
        For Each Card In cardlist
            Card.BackgroundImage = PBack.BackgroundImage

        Next

        Select Case MainForm.ImageDifficulty 'Different image options
            Case 1 'Fruit and veg
                If My.Settings.CardBack = 1 Then 'If using card back 1
                    Pic1.BackgroundImage = My.Resources.apple
                    Pic2.BackgroundImage = My.Resources.banana
                    Pic3.BackgroundImage = My.Resources.cherry
                    Pic4.BackgroundImage = My.Resources.cucumber
                    Pic5.BackgroundImage = My.Resources.durian
                    Pic6.BackgroundImage = My.Resources.eggplant
                    Pic7.BackgroundImage = My.Resources.leek
                    Pic8.BackgroundImage = My.Resources.melon
                    Pic9.BackgroundImage = My.Resources.orange

                ElseIf My.Settings.CardBack = 2 Then 'If using card back 2
                    Pic1.BackgroundImage = My.Resources.apple1
                    Pic2.BackgroundImage = My.Resources.banana1
                    Pic3.BackgroundImage = My.Resources.cherry1
                    Pic4.BackgroundImage = My.Resources.cucumber1
                    Pic5.BackgroundImage = My.Resources.durian1
                    Pic6.BackgroundImage = My.Resources.eggplant1
                    Pic7.BackgroundImage = My.Resources.leek1
                    Pic8.BackgroundImage = My.Resources.melon1
                    Pic9.BackgroundImage = My.Resources.orange1

                ElseIf My.Settings.CardBack = 3 Then 'If using card back 3
                    Pic1.BackgroundImage = My.Resources.apple2
                    Pic2.BackgroundImage = My.Resources.banana2
                    Pic3.BackgroundImage = My.Resources.cherry2
                    Pic4.BackgroundImage = My.Resources.cucumber2
                    Pic5.BackgroundImage = My.Resources.durian2
                    Pic6.BackgroundImage = My.Resources.eggplant2
                    Pic7.BackgroundImage = My.Resources.leek2
                    Pic8.BackgroundImage = My.Resources.melon2
                    Pic9.BackgroundImage = My.Resources.orange2

                End If

                TxtDiff.Text = "Deck:" & Environment.NewLine & "Fruit Veg"

            Case 2 'Sports
                If My.Settings.CardBack = 1 Then 'If using card back 1
                    Pic1.BackgroundImage = My.Resources.basket
                    Pic2.BackgroundImage = My.Resources.cricket
                    Pic3.BackgroundImage = My.Resources.flag
                    Pic4.BackgroundImage = My.Resources.footy
                    Pic5.BackgroundImage = My.Resources.soccer
                    Pic6.BackgroundImage = My.Resources.sprint
                    Pic7.BackgroundImage = My.Resources.swim
                    Pic8.BackgroundImage = My.Resources.table
                    Pic9.BackgroundImage = My.Resources.tennis

                ElseIf My.Settings.CardBack = 2 Then 'If using card back 2
                    Pic1.BackgroundImage = My.Resources.basket1
                    Pic2.BackgroundImage = My.Resources.cricket1
                    Pic3.BackgroundImage = My.Resources.flag1
                    Pic4.BackgroundImage = My.Resources.footy1
                    Pic5.BackgroundImage = My.Resources.soccer1
                    Pic6.BackgroundImage = My.Resources.sprint1
                    Pic7.BackgroundImage = My.Resources.swim1
                    Pic8.BackgroundImage = My.Resources.table1
                    Pic9.BackgroundImage = My.Resources.tennis1

                ElseIf My.Settings.CardBack = 3 Then 'If using card back 3
                    Pic1.BackgroundImage = My.Resources.basket2
                    Pic2.BackgroundImage = My.Resources.cricket2
                    Pic3.BackgroundImage = My.Resources.flag2
                    Pic4.BackgroundImage = My.Resources.footy2
                    Pic5.BackgroundImage = My.Resources.soccer2
                    Pic6.BackgroundImage = My.Resources.sprint2
                    Pic7.BackgroundImage = My.Resources.swim2
                    Pic8.BackgroundImage = My.Resources.table2
                    Pic9.BackgroundImage = My.Resources.tennis2

                End If

                TxtDiff.Text = "Deck:" & Environment.NewLine & "Sports"

            Case 3 'Clothing
                If My.Settings.CardBack = 1 Then 'If using card back 1
                    Pic1.BackgroundImage = My.Resources.brella
                    Pic2.BackgroundImage = My.Resources.crown
                    Pic3.BackgroundImage = My.Resources.glass
                    Pic4.BackgroundImage = My.Resources.hat
                    Pic5.BackgroundImage = My.Resources.pant
                    Pic6.BackgroundImage = My.Resources.shirt
                    Pic7.BackgroundImage = My.Resources.shoe
                    Pic8.BackgroundImage = My.Resources.sock
                    Pic9.BackgroundImage = My.Resources.tie

                ElseIf My.Settings.CardBack = 2 Then 'If using card back 2
                    Pic1.BackgroundImage = My.Resources.brella1
                    Pic2.BackgroundImage = My.Resources.crown1
                    Pic3.BackgroundImage = My.Resources.glass1
                    Pic4.BackgroundImage = My.Resources.hat1
                    Pic5.BackgroundImage = My.Resources.pant1
                    Pic6.BackgroundImage = My.Resources.shirt1
                    Pic7.BackgroundImage = My.Resources.shoe1
                    Pic8.BackgroundImage = My.Resources.sock1
                    Pic9.BackgroundImage = My.Resources.tie1

                ElseIf My.Settings.CardBack = 3 Then 'If using card back 3
                    Pic1.BackgroundImage = My.Resources.brella2
                    Pic2.BackgroundImage = My.Resources.crown2
                    Pic3.BackgroundImage = My.Resources.glass2
                    Pic4.BackgroundImage = My.Resources.hat2
                    Pic5.BackgroundImage = My.Resources.pant2
                    Pic6.BackgroundImage = My.Resources.shirt2
                    Pic7.BackgroundImage = My.Resources.shoe2
                    Pic8.BackgroundImage = My.Resources.sock2
                    Pic9.BackgroundImage = My.Resources.tie2

                End If

                TxtDiff.Text = "Deck:" & Environment.NewLine & "Clothing"

            Case 4 'Custom
                'Basically visual basic sucks at opening images cause it'll just hog the entire thing.
                'So we need to create a stream that'll view the file and create a copy of it.
                'That way it won't interfere if the user wants to edit the file afterwards
                Using str As Stream = File.OpenRead("Assets\CustomPic\1.png")
                    Pic1.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\2.png")
                    Pic2.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\3.png")
                    Pic3.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\4.png")
                    Pic4.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\5.png")
                    Pic5.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\6.png")
                    Pic6.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\7.png")
                    Pic7.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\8.png")
                    Pic8.BackgroundImage = Image.FromStream(str)
                End Using

                Using str As Stream = File.OpenRead("Assets\CustomPic\9.png")
                    Pic9.BackgroundImage = Image.FromStream(str)
                End Using

                TxtDiff.Text = "Deck:" & Environment.NewLine & "Custom"

            Case Else

        End Select

        'Frontside of image
        imglist(0) = Pic1
        imglist(1) = Pic2
        imglist(2) = Pic3
        imglist(3) = Pic4
        imglist(4) = Pic5
        imglist(5) = Pic6
        imglist(6) = Pic7
        imglist(7) = Pic8
        imglist(8) = Pic9

        seconds = 6
        TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec

        CardShuffle(movebehind) 'Shuffles the cards

        For i As Integer = 1 To 18
            If movebehind(i) > 9 Then
                movebehind(i) = movebehind(i) - 9

            End If

            movebehind(i) = movebehind(i) - 1
            movebehind(i - 1) = movebehind(i)

        Next

        Countdown.Start()

    End Sub

    'Initial timer during countdown
    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        seconds -= 1
        TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec

        If seconds = 0 Then
            Countdown.Stop()
            StartGame()
            Exit Sub

        End If

    End Sub

    'Starts game after countdown finishes
    Private Sub StartGame()
        Timer.Start()
        GifBox.Enabled = True
        gamestart = True

    End Sub

    'Count up timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        millisec += 1 'Adds 1 to millisecond
        If millisec > 9 Then 'Makes sure millisec doesn't get to 10
            millisec = 0 'Sets millisec back to 0
            seconds += 1 'Increments seconds

        End If

        TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec 'Updates the time

    End Sub

    Private rnd As New Random() 'Initialise new random
    'An adaptation of the word randomiser as the image randomiser
    Private Sub CardShuffle(items() As Integer) 'Set variables: items = The things in the array
        Dim j As Integer
        Dim temp As Integer

        For Counter As Integer = 1 To 18 'Set each card index into an integer
            items(Counter) = Counter

        Next

        For n As Integer = items.Length - 1 To 1 Step -1 'For all the items in the array
            j = rnd.Next(1, n + 1) 'Choose a random number

            'Swaps the words around
            temp = items(n) 'Set current item to temp
            items(n) = items(j) 'Replace current item with new item chosen by random
            items(j) = temp 'Replace new item with old item
        Next n

    End Sub

    'Deals with clicking on the boxes.
    Private Sub PB1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PB1.Click, PB2.Click, PB3.Click, PB4.Click, PB5.Click, PB6.Click, PB7.Click, PB8.Click, PB9.Click, PB10.Click, PB11.Click, PB12.Click, PB13.Click, PB14.Click, PB15.Click, PB16.Click, PB17.Click, PB18.Click
        ActiveControl = Nothing
        Play(Int32.Parse(sender.tag))

    End Sub

    'Logic behind clicking of boxes
    Private Sub Play(ByVal Index As Integer)
        'Makes sure there's no doubling up on picking cards. Or no picking cards when the game is paused or not started
        If (pairselect = 2 And Index = pairpick(1)) Or movebehind(Index) = -1 Or gamestart = False Or gamepause = True Then
            Exit Sub

        End If

        'Shows the card that was chosen
        cardlist(Index).BackgroundImage = imglist(movebehind(Index)).BackgroundImage
        cardlist(Index).Refresh()

        'Remembers the card that was chosen
        If pairselect = 1 Then
            pairpick(1) = Index
            pairselect = 2
            Exit Sub

        End If

        'The card that was chosen second
        pairpick(2) = Index

        'If they match, take the cards out of play with a value which makes sure they can't be chosen again
        If movebehind(pairpick(1)) = movebehind(pairpick(2)) Then
            movebehind(pairpick(1)) = -1
            movebehind(pairpick(2)) = -1

            cardsleft = cardsleft - 1
            TxtCardsLeft.Text = "Pairs left:" & Environment.NewLine & cardsleft

            If My.Settings.SFXMuted = False Then 'Plays audio if needed
                My.Computer.Audio.Play(My.Resources.goodjob, AudioPlayMode.Background)

            End If

            If cardsleft = 0 Then 'Checks if there's no more cards left
                GameEnd()
                Exit Sub

            End If

        Else 'No match, start timer to hide cards
            FlipBack.Enabled = True

        End If

        pairselect = 1 'Reset the counter

    End Sub

    'If you're bad, make sure the cards hide again
    Private Sub FlipBack_Tick(sender As Object, e As EventArgs) Handles FlipBack.Tick
        ZaTime += 20

        For x As Integer = 0 To cardlist.Length - 1 'Disables cards first so no going ahead
            cardlist(x).Enabled = False

        Next

        If ZaTime = 100 Then 'Once its the right time
            FlipBack.Enabled = False 'Stop timer
            ZaTime = 0

            cardlist(pairpick(1)).BackgroundImage = PBack.BackgroundImage 'Hide the cards
            cardlist(pairpick(2)).BackgroundImage = PBack.BackgroundImage

            For x As Integer = 0 To cardlist.Length - 1 'Enable cards again
                cardlist(x).Enabled = True
            Next

        End If

    End Sub

    Private Sub GameEnd() 'Once there are no more cards, stop everything and show the results
        Timer.Stop()
        GifBox.Enabled = False
        gamestart = False

        ImageResults.LoadResults()
        ImageResults.ShowDialog()

    End Sub

    Private Sub PauseGame() 'Pause the game while it is playing
        If gamestart = False Then 'If the game is still counting down
            PauseSetup() 'Use a different thing
            Exit Sub

        End If

        If gamepause = False Then 'If the game is not paused, then pause the game
            Timer.Stop()
            gamepause = True
            BtnPause.Text = "Resume"
            TxtTime.Text = "Timer:" & Environment.NewLine & "Paused"

        ElseIf gamepause = True Then 'Or else resume the game
            Timer.Start()
            gamepause = False
            BtnPause.Text = "Pause Game"
            TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec

        End If

    End Sub

    Private Sub PauseSetup() 'Pauses the game when it is still counting down
        If gamepause = False Then
            Countdown.Stop()
            gamepause = True
            BtnPause.Text = "Resume"
            TxtTime.Text = "Timer:" & Environment.NewLine & "Paused"

        ElseIf gamepause = True Then
            Countdown.Start()
            gamepause = False
            BtnPause.Text = "Pause Game"
            TxtTime.Text = "Timer:" & Environment.NewLine & seconds & "." & millisec

        End If

    End Sub

    'Pause button
    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        ActiveControl = Nothing
        PauseGame()

    End Sub

    'Quit game early
    Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
        ActiveControl = Nothing
        If gamepause = False Then
            PauseGame()

            If MessageBox.Show("Are you sure you want to quit the game early?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Hide()
                MainForm.Show()

            End If

            PauseGame()

        ElseIf gamepause = True Then
            If MessageBox.Show("Are you sure you want to quit the game early?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Hide()
                MainForm.Show()

            End If

        End If
    End Sub

    'This stuff makes the windows dragable
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub PanelGrab_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelGrab.MouseDown 'Tells when its time to drag
        If e.Button = MouseButtons.Left Then 'Makes sure only left button is used
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top

        End If
    End Sub

    Private Sub PanelGrab_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelGrab.MouseMove 'Moves window when mouse moves
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub PanelGrab_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelGrab.MouseUp 'Stops moving window when mouse released
        drag = False

    End Sub

    Private Sub PanelGrab_MouseEnter(sender As Object, e As EventArgs) Handles PanelGrab.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                PanelGrab.BackgroundImage = My.Resources.dragbar1

            Case 2
                PanelGrab.BackgroundImage = My.Resources.dragbar2

        End Select

    End Sub

    Private Sub PanelGrab_MouseLeave(sender As Object, e As EventArgs) Handles PanelGrab.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                PanelGrab.BackgroundImage = My.Resources.dragbar

            Case 2
                PanelGrab.BackgroundImage = My.Resources.dragbar1

        End Select

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ActiveControl = Nothing
        If gamepause = False Then
            PauseGame()

            If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()

            Else
                PauseGame()

            End If

        Else
            If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()

            End If

        End If

    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        ActiveControl = Nothing
        If gamepause = False Then
            PauseGame()
            Me.WindowState = FormWindowState.Minimized

        Else
            Me.WindowState = FormWindowState.Minimized

        End If
        WasMini = True

    End Sub

    'Prevents alt f4 from breaking things
    Private Sub ImageMatchForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            BtnExit_Click(sender, e)

        End If

    End Sub

    'Tries not to break transparancy
    Private Sub ImageMatchForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If WasMini = True Then
            WasMini = False
            TransparencyKey = Color.Purple
            TransparencyTimer.Start()

        End If

    End Sub

    Private Sub TransparencyTimer_Tick(sender As Object, e As EventArgs) Handles TransparencyTimer.Tick
        TransparencyTimer.Stop()
        TransparencyKey = Nothing

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

End Class