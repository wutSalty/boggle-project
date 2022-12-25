Public Class ImageResults

    Dim highscore As String
    Dim scoresetting As String
    Dim finaltime As Decimal

    Public Sub LoadResults()
        Dim formatted = String.Format("{0}.{1}", ImageMatchForm.seconds, ImageMatchForm.millisec)
        finaltime = Decimal.Parse(formatted)

        Select Case MainForm.ImageDifficulty
            Case 1
                highscore = My.Settings.ImageA
                scoresetting = "ImageA"

            Case 2
                highscore = My.Settings.ImageB
                scoresetting = "ImageB"

            Case 3
                highscore = My.Settings.ImageC
                scoresetting = "ImageC"

        End Select

        TxtResult.Text = "On the " & MainForm.ImageDifficultyTxt & " deck, you managed to match all the cards in " & finaltime.ToString & " seconds!"

        Select Case MainForm.ImageDifficulty
            Case 1, 2, 3
                If finaltime < highscore Or highscore = 0.0 Then
                    TxtRecords.Text = "You also managed to beat your old record of " & highscore.ToString & " seconds! Great job! Keep trying to chop that time down, or maybe even try out a Custom deck of your own!"
                    My.Settings(scoresetting) = finaltime
                    My.Settings.Save()
                    DebugForm.UpdateDebug()

                Else
                    TxtRecords.Text = "Unfortunately you didn't beat your record of " & highscore.ToString & " for this deck. But keep it at! Want to play with different cards? Why not check out the Custom deck options!"

                End If

            Case 4
                TxtRecords.Text = "Since you're playing a Custom deck, we can't track your high scores here. But why not think of some really nefarious decks to build, or challenge yourself further with weird rules!"

        End Select

    End Sub

    Private Sub BtnSameAgain_Click(sender As Object, e As EventArgs) Handles BtnSameAgain.Click 'Play again with same settings
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        MainForm.CheckCards() 'Checks card deck again
        If (MainForm.ImageDifficulty = 4) And (MainForm.Maffs = 0) Then 'If the game is custom and deck becomes invalid
            MessageBox.Show("Cards from the Custom deck are now missing or invalid. Unable to begin a Custom game. Returning to Deck select.", "Unable to begin Custom game", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Show error message

            'Exit out to deck select
            Me.Hide()
            ImageMatchForm.Hide()
            MainForm.Show()

            MainForm.ImageDifficulty = 0
            DebugForm.UpdateDebug()
            Exit Sub

        End If

        Me.Hide() 'Hides results stuff

        ImageMatchForm.Hide() 'Hide game form
        ImageMatchForm.LoadGame() 'Reset things
        ImageMatchForm.Show() 'Show form again

        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnPlayAgain_Click(sender As Object, e As EventArgs) Handles BtnPlayAgain.Click 'Return to deck select
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        Me.Hide()
        ImageMatchForm.Hide()
        MainForm.Show()

        MainForm.ImageDifficulty = 0
        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnReturnHome_Click(sender As Object, e As EventArgs) Handles BtnReturnHome.Click 'Return to main menu
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        Me.Hide()
        ImageMatchForm.Hide()
        ImageDifficultySelect1.Hide()
        MainForm.Show()

        MainForm.ImageDifficulty = 0
        DebugForm.UpdateDebug()
        MainForm.Text = "Boggle - Main Menu"

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

    'Prevents user from closing this form which will break the other form
    Private Sub ImageResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Application.Exit()

            End If

        End If

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class