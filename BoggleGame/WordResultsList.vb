Public Class WordResultsList
    Public Sub UpdateList() 'Grabs both lists and adds to a listview
        ListResults.Items.Clear() 'Clears old list

        For i As Integer = 0 To WordMemoryGame1.UserList.Count - 1 'For all the items in the user answers list
            Dim LVI As New ListViewItem(WordMemoryGame1.PassedList(i)) 'Create a new list view
            LVI.SubItems.Add(WordMemoryGame1.UserList(i)) 'Set the word as a listviewitem
            ListResults.Items.Add(LVI) 'Add the item to the list

        Next

    End Sub

    'Calling a function from the Windows API to show/hide scrollbars
    Private Declare Function ShowScrollBar Lib "user32" (ByVal hwnd As Long, ByVal wBar As Long, ByVal bShow As Long) As Long

    'Everytime the ListView changes, hide the horizonal scroll bar
    Private Sub ListResults_ClientSizeChanged(sender As Object, e As EventArgs) Handles ListResults.ClientSizeChanged
        ShowScrollBar(ListResults.Handle, 0, False)
    End Sub

    'All window drag stuff
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
        MainForm.SFXPlay(My.Resources.backbeep)
        Me.Close()

    End Sub

    Private Sub BtnExit_MouseEnter(sender As Object, e As EventArgs) Handles BtnExit.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnExit.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnExit.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnExit_MouseLeave(sender As Object, e As EventArgs) Handles BtnExit.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnExit.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnExit.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnExit_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnExit.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnExit.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnExit.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnExit_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnExit.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnExit.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnExit.BackgroundImage = My.Resources.basedarka

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