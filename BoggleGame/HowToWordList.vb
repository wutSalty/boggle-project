Public Class HowToWordList
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

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click 'When the user closes the menu via the OK button
        ActiveControl = Nothing
        If (Not File.Exists("Assets\WordList.txt")) Then 'If the file has been deleted in the in-between time
            MainForm.CheckFiles() 'Recreate the file
            MessageBox.Show("Word List file was not detected. Creating a new WordList.txt file.", "Missing Word List", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf MessageBox.Show("Have you saved the file yet?", "Saved your work?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            SpcWordList.Clear() 'Resets the word list and sets it up again
            UserWordList()

            MainForm.SFXPlay(My.Resources.confirmbeep)
            Me.Close()

            'If the user has already closed notepad, don't throw a fit
            Try
                Settings1.proc.Kill()
            Catch ex As Exception
            End Try

            Settings1.SaveSettings()

        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ActiveControl = Nothing
        If (Not File.Exists("Assets\WordList.txt")) Then 'If the file has been deleted in the in-between time
            MainForm.CheckFiles() 'Recreate the file
            MessageBox.Show("Word List file was not detected. Creating a new WordList.txt file.", "Missing Word List", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            MainForm.SFXPlay(My.Resources.backbeep)

        End If

        Try
            Settings1.proc.Kill()
        Catch ex As Exception
        End Try
        Me.Close()

    End Sub

    Private Sub BtnCancel_MouseEnter(sender As Object, e As EventArgs) Handles BtnCancel.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnCancel.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnCancel_MouseLeave(sender As Object, e As EventArgs) Handles BtnCancel.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnCancel.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancel.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnCancel.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancel.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnCancel.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnCancel.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnOK_MouseEnter(sender As Object, e As EventArgs) Handles BtnOK.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnOK.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnOK.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnOK_MouseLeave(sender As Object, e As EventArgs) Handles BtnOK.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnOK.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnOK.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnOK_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnOK.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnOK.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnOK.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnOK_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnOK.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnOK.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnOK.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class