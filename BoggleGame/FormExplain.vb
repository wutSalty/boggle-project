Public Class FormExplain

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        MainForm.SFXPlay(My.Resources.backbeep)
        ActiveControl = Nothing
        Me.Close()

    End Sub

    'Adds shows proper information for the form
    Public Sub ShowWord()
        TxtGameName.Text = "Word Memory"
        TxtGameExplain.Text = "The aim is to remember the word that appears on screen." & Environment.NewLine & Environment.NewLine & "But the twist is you have to type in the previous word instead!" & Environment.NewLine & Environment.NewLine & "Use the 'Enter' button to move onto the next word." & Environment.NewLine & Environment.NewLine & "Each correct word gives +1 points." & Environment.NewLine & Environment.NewLine & "Try and get as many points before time runs out!"

    End Sub

    Public Sub ShowImage()
        TxtGameName.Text = "Image Match"
        TxtGameExplain.Text = "The aim of the game is to find all matching pairs of cards!" & Environment.NewLine & Environment.NewLine & "Select two cards and see if they match." & Environment.NewLine & Environment.NewLine & "If they match, the cards will remain showing!" & Environment.NewLine & Environment.NewLine & "If they don't, the cards will hide again." & Environment.NewLine & Environment.NewLine & "Try and get the shortest time!"

    End Sub

    Private Sub BtnClose_MouseEnter(sender As Object, e As EventArgs) Handles BtnClose.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnClose.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnClose.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnClose.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnClose.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnClose.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnClose.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnClose.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnClose.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnClose.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnClose.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class