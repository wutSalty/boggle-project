Imports System.Reflection

Public Class MainForm
    'Hold info about current chosen difficulty
    Public WordDifficulty As Integer = Nothing 'Difficulty for Word
    Public ImageDifficulty As Integer = Nothing 'Difficulty for Image
    Public WordDifficultyTxt As String = Nothing 'Difficulty for Word as Text
    Public ImageDifficultyTxt As String = Nothing 'Difficulty for Image as Text

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMenus() 'Loads all the menus
        CheckTheme() 'Loads the correct themes for the menus
        CheckFiles() 'Makes sure all the required files exists
        CheckCards() 'A preliminary check to see if custom cards are available
        BeginProgram() 'Starts everything else
        BeginBGM() 'Start the audio

    End Sub

    Public Sub BeginProgram()
        If My.Settings.FirstTime = True Then 'Shows First Time screen if it is user's first time opening the app
            FirstTimeScreen1.Show()
            Me.Text = "Boggle - First Time"

        ElseIf My.Settings.SkipTitle = False Then 'Checks if user has set to skip Title Screen or not
            'If False, load Title Screen
            Title_Screen1.Show()
            Me.Text = "Boggle - Title Screen"

        Else
            'If true, load Main Menu
            MainMenu1.Show()
            Me.Text = "Boggle - Main Menu"

        End If

        If My.Settings.ShowDebugForm = True Then
            DebugForm.Show() 'For troubleshooting and viewing how things are working
        End If

        DebugForm.UpdateDebug()
        Randomise.SetUpWordList() 'Prepares original list of words in Word Memory

        MainMenu1.CtrlPressed = False

    End Sub

    'This will make sure that certain files exists
    Public Sub CheckFiles()
        'Main folder
        If (Not Directory.Exists("Assets")) Then 'Check the Assets folder exists
            Directory.CreateDirectory("Assets")

        End If

        'WordList
        If (Not File.Exists("Assets\WordList.txt")) Then 'If the word list does not exist
            Dim path As String = "Assets\WordList.txt" 'This is the path name
            Dim fs As FileStream = File.Create(path) 'And here's a FileStream

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(My.Resources.english) 'Get everything from the file in Resources
            fs.Write(info, 0, info.Length) 'Save it to the wanted path
            fs.Close() 'Then close the Stream

        End If

        'Images
        If (Not Directory.Exists("Assets\CustomPic")) Then 'Checks the CustomPic folder in the Assets folder exists
            Directory.CreateDirectory("Assets\CustomPic")

        End If

        If (Not File.Exists("Assets\CustomPic\template.png")) Then 'Checks the template file exits in the CustomPic file
            My.Resources.template.Save("Assets\CustomPic\template.png")

        End If

        If (Not File.Exists("Assets\CustomPic\template1.png")) Then 'Checks the template1 file exits in the CustomPic file
            My.Resources.template1.Save("Assets\CustomPic\template1.png")

        End If

        If (Not File.Exists("Assets\CustomPic\template2.png")) Then 'Checks the template2 file exits in the CustomPic file
            My.Resources.template2.Save("Assets\CustomPic\template2.png")

        End If

    End Sub

    Public Maffs As Integer = 1 'Uses maths to check if elegible or not
    Public Sub CheckCards() 'Checks if custom cards can be played
        Maffs = 1
        Dim Files As String() = {"1.png", "2.png", "3.png", "4.png", "5.png", "6.png", "7.png", "8.png", "9.png"} 'List of files needed for a custom game

        For Each File As String In Files 'For all the files I need to check
            Dim FilePath As String = Path.Combine("Assets\CustomPic\", File) 'Combine the file name with the location of the file
            If IO.File.Exists(FilePath) Then 'If it exists
                Maffs = Maffs * 1 'This variable should not change as 1*1=1

            Else
                Maffs = Maffs * 0 'If it does not exist, it will forever be 0 since anything*0=0
            End If

        Next

        DebugForm.TxtImageOK.Text = "Image Custom OK?: " & Maffs.ToString

    End Sub

    'This stuff makes the windows dragable
    Dim drag As Boolean 'Should the window be dragged
    Dim mousex As Integer 'Position of mouse in x coord
    Dim mousey As Integer 'Position of mouse in y coord

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

    'If the drag bar buttons are used during a game, make sure it will pause the game at the same time
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ActiveControl = Nothing
        If WordMemoryGame1.gameing = True Or WordMemoryGame1.preping = True Then 'If the word memory game is being played
            If WordMemoryGame1.IsPaused = True Then 'And the game is already paused
                If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then 'Pull up the dialogue
                    Application.Exit()

                End If

            Else 'Game is probably not paused
                WordMemoryGame1.PauseGame() 'So pause the darn game first
                If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    Application.Exit()

                End If
                WordMemoryGame1.PauseGame() 'And unpause it after

            End If

            Exit Sub 'Seeing as we're already dealing with word game, just get the heck out

        End If

        'Basically force the hover text to stay as it is
        msgbox = True
        If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()

        Else
            MainMenu1.TxtFlavour.Text = "Handy tip go here"
            MainMenu1.TxtMenuName.Text = "Welcome to Boggle"

        End If

        msgbox = False

    End Sub

    'Tries not to break word game when minimising. Breaks anyways
    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        ActiveControl = Nothing
        If WordMemoryGame1.gameing = True Or WordMemoryGame1.preping = True Then 'If the word memory game is being played
            If WordMemoryGame1.IsPaused = True Then 'And the game is already paused
                Me.WindowState = FormWindowState.Minimized

            Else 'Game is probably not paused
                WordMemoryGame1.PauseGame() 'So pause the darn game first
                Me.WindowState = FormWindowState.Minimized

            End If

            Exit Sub 'Seeing as we're already dealing with word game, just get the heck out

        Else
            Me.WindowState = FormWindowState.Minimized

        End If


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

    'Fancy stuff relating to making things work on the Main Menu
    Dim msgbox As Boolean = False

    Private Sub BtnExit_MouseEnter(sender As Object, e As EventArgs) Handles BtnExit.MouseEnter
        MainMenu1.TxtFlavour.Text = "Quits the game"
        MainMenu1.TxtMenuName.Text = "Come again soon"

    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles BtnExit.MouseLeave
        If msgbox = False Then
            MainMenu1.TxtFlavour.Text = "Handy tip go here"
            MainMenu1.TxtMenuName.Text = "Welcome to Boggle"
        End If

    End Sub

    'Audio cause WHY THE HECK NOT
    Public Shared WaveBGM As New NAudio.Wave.WaveOut 'Creates new WaveOut
    Public Shared WaveBGMThread As Threading.Thread 'Creates a thread which runs separately from main program

    'When program starts, it starts a new thread that runs in the background
    Private Sub BeginBGM()
        If IsNothing(WaveBGMThread) Then 'If the thread doesn't exist
            WaveBGMThread = New Threading.Thread(AddressOf WaveBGMThreadMethod) With {.IsBackground = True} 'Create a new thread that runs in the background
            WaveBGMThread.Start() 'Then start the thread

        End If

    End Sub

    'This thread then plays the background audio, and keeps looping it
    Public Sub WaveBGMThreadMethod()
        WaveBGM = New NAudio.Wave.WaveOut 'Make sure this thread can get the WaveOut
        While True 'Loop forever
            If WaveBGM.PlaybackState = 0 Then 'Whenever the song has ended playing
                Dim BGM As New NAudio.Wave.WaveFileReader(My.Resources.BleepingDemo) 'Convert the resource file
                WaveBGM.Dispose() 'Get rid of anything old
                WaveBGM.Init(BGM) 'Get the new song ready
                WaveBGM.Play() 'Start playing the game
                If My.Settings.BGMMuted = True Then 'But if the user has disabled background music
                    WaveBGM.Pause() 'Pause the audio
                End If

            End If

        End While

    End Sub

    'Plays sound effects one at a time
    Public Sub SFXPlay(sfx) 'sfx = location from calling code
        If My.Settings.SFXMuted = False Then 'If sound effects are not muted
            My.Computer.Audio.Play(sfx, AudioPlayMode.Background) 'Then play the sound effect

        End If

    End Sub

    'Prevents form/control flickering
    Protected Overrides ReadOnly Property CreateParams() As CreateParams 'Override the default parameters
        Get
            Dim cp As CreateParams = MyBase.CreateParams 'Make a way to easily refer to the perams
            cp.ExStyle = cp.ExStyle Or &H2000000 'Set the params to a specific setting
            Return cp
        End Get
    End Property 'CreateParams

End Class