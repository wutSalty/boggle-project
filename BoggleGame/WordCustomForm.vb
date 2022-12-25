Public Class WordCustomForm
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

    Private Sub BtnStart_MouseEnter(sender As Object, e As EventArgs) Handles BtnStart.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStart.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnStart.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnStart_MouseLeave(sender As Object, e As EventArgs) Handles BtnStart.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStart.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnStart.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnStart_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnStart.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStart.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnStart.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnStart_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnStart.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStart.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnStart.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Public Diff As Integer
    Public TimeGame As Integer
    Public TimePrep As integer

    'Makes sure that when the user presses enter, all the inputs are valid
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        ActiveControl = Nothing
        If IsNumeric(BoxDiff.Text) = True And IsNumeric(BoxPrepTime.Text) = True And IsNumeric(BoxGameTime.Text) = True Then 'If all 3 textboxes are numbers
            If BoxDiff.Text <= 0 Or BoxPrepTime.Text <= 0 Or BoxGameTime.Text <= 0 Then 'But they are less than or equal to 0
                'Error time
                MessageBox.Show("One or more inputs are not valid! Please use numbers greater than 0!", "Are these numbers valid?", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else 'But if the numbers are ok
                'Setup the game
                MainForm.SFXPlay(My.Resources.confirmbeep)
                Me.Close()

                Diff = BoxDiff.Text
                TimeGame = BoxGameTime.Text
                TimePrep = BoxPrepTime.Text

                BoxDiff.Clear()
                BoxGameTime.Clear()
                BoxPrepTime.Clear()

                WordDifficultySelect1.SetDifficulty()

            End If

        Else 'But if the textboxes are not numbers
            'More errors
            MessageBox.Show("One or more inputs are not valid! Please make sure you are only entering numbers (0-9)", "Are these numbers?", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        Close()
        BoxDiff.Clear()
        BoxGameTime.Clear()
        BoxPrepTime.Clear()

    End Sub

    'Makes sure only numbers are put into the boxes. And if enter is pressed, start the game
    Private Sub BoxDiff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxDiff.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter Or Keys.Return) Then
            BtnStart_Click(sender, e)

        End If

    End Sub

    Private Sub BoxGameTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxGameTime.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter Or Keys.Return) Then
            BtnStart_Click(sender, e)

        End If

    End Sub

    Private Sub BoxPrepTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxPrepTime.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter Or Keys.Return) Then
            BtnStart_Click(sender, e)

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