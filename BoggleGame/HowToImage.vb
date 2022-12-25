Public Class HowToImage
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

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.backbeep)
        Me.Close()

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