Public Class SettingsTheme

    Public Sub ThemeLoad()
        Select Case My.Settings.Theme
            Case 0
                RadioTheme1.Checked = True

            Case 1
                RadioTheme2.Checked = True

            Case 2
                RadioTheme3.Checked = True
        End Select

    End Sub

    Dim Current As Integer = 0 'Keeps track of current preview

    'Things changing with radiotheme allows for theme to be previewed
    Private Sub RadioTheme1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTheme1.CheckedChanged
        ActiveControl = Nothing
        If Not Current = 0 Then 'Prevents changing something that's already set
            Current = 0
            Me.BackColor = SystemColors.ControlLight
            Me.BackgroundImage = My.Resources.bgmainmenu
            Me.ForeColor = SystemColors.ControlText
            BtnMini.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            BtnMini.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            BtnCancel.BackgroundImage = My.Resources.backlighta
            PanelGrab.BackgroundImage = My.Resources.dragbar

        End If

    End Sub

    Private Sub RadioTheme2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTheme2.CheckedChanged
        ActiveControl = Nothing
        If Not Current = 1 Then
            Current = 1
            Me.BackColor = SystemColors.ControlLight
            Me.BackgroundImage = My.Resources.bgmainmenu1
            Me.ForeColor = SystemColors.ControlText
            BtnMini.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            BtnMini.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            BtnCancel.BackgroundImage = My.Resources.backlighta
            PanelGrab.BackgroundImage = My.Resources.dragbar

        End If

    End Sub

    Private Sub RadioTheme3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTheme3.CheckedChanged
        ActiveControl = Nothing
        If Not Current = 2 Then
            Current = 2
            Me.BackColor = ColorTranslator.FromHtml("#4f4f4f")
            Me.BackgroundImage = My.Resources.bgmainmenu2
            Me.ForeColor = SystemColors.ControlLightLight
            BtnMini.FlatAppearance.MouseDownBackColor = Color.DimGray
            BtnMini.FlatAppearance.MouseOverBackColor = Color.DimGray
            BtnCancel.BackgroundImage = My.Resources.backdarka
            PanelGrab.BackgroundImage = My.Resources.dragbar1

        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click 'Saving the settings
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.confirmbeep)
        If RadioTheme1.Checked Then
            My.Settings.Theme = 0

        ElseIf RadioTheme2.Checked Then
            My.Settings.Theme = 1

        ElseIf RadioTheme3.Checked Then
            My.Settings.Theme = 2

        End If

        My.Settings.Save()
        CheckTheme()
        MainForm.Location = Me.Location
        MainForm.Show()
        Me.Hide()
        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        Me.Hide()
        MainForm.Location = Me.Location
        MainForm.Show()

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

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ActiveControl = Nothing
        If MessageBox.Show("Are you sure you want to exit?", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub

    Private Sub BtnMini_Click(sender As Object, e As EventArgs) Handles BtnMini.Click
        ActiveControl = Nothing
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PanelGrab_MouseEnter(sender As Object, e As EventArgs) Handles PanelGrab.MouseEnter
        Select Case Current
            Case 0, 1
                PanelGrab.BackgroundImage = My.Resources.dragbar1

            Case 2
                PanelGrab.BackgroundImage = My.Resources.dragbar2

        End Select

    End Sub

    Private Sub PanelGrab_MouseLeave(sender As Object, e As EventArgs) Handles PanelGrab.MouseLeave
        Select Case Current
            Case 0, 1
                PanelGrab.BackgroundImage = My.Resources.dragbar

            Case 2
                PanelGrab.BackgroundImage = My.Resources.dragbar1

        End Select

    End Sub

    'Prevents closing form or might break things
    Private Sub SettingsTheme_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            BtnExit_Click(sender, e)

        End If

    End Sub

    'Hovers. A lot
    Private Sub BtnCancel_MouseEnter(sender As Object, e As EventArgs) Handles BtnCancel.MouseEnter
        TxtFlavour.Text = "Return to Main Menu"
        Select Case Current
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlightb

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarkb

        End Select

    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave
        TxtFlavour.Text = "Preview the available themes"
        Select Case Current
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlighta

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarka

        End Select

    End Sub

    Private Sub BtnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancel.MouseDown
        Select Case Current
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlightc

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarkc

        End Select

    End Sub

    Private Sub BtnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancel.MouseUp
        Select Case Current
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.backlighta

            Case 2
                BtnCancel.BackgroundImage = My.Resources.backdarka

        End Select

    End Sub

    Private Sub BtnSave_MouseEnter(sender As Object, e As EventArgs) Handles BtnSave.MouseEnter
        TxtFlavour.Text = "Saves theme, then returns"

    End Sub

    Private Sub RadioTheme1_MouseEnter(sender As Object, e As EventArgs) Handles RadioTheme1.MouseEnter
        TxtFlavour.Text = "The standard Boggle green"

    End Sub

    Private Sub RadioTheme2_MouseEnter(sender As Object, e As EventArgs) Handles RadioTheme2.MouseEnter
        TxtFlavour.Text = "A refreshing wave of blue"

    End Sub

    Private Sub RadioTheme3_MouseEnter(sender As Object, e As EventArgs) Handles RadioTheme3.MouseEnter
        TxtFlavour.Text = "A different palette of style"

    End Sub

    Private Sub All_MouseLeave(sender As Object, e As EventArgs) Handles RadioTheme1.MouseLeave, RadioTheme3.MouseLeave, RadioTheme2.MouseLeave, BtnSave.MouseLeave, BtnSave.MouseLeave
        TxtFlavour.Text = "Preview the available themes"

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class