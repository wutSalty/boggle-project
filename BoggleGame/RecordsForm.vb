Public Class RecordsForm
    Public Sub GetRecords() 'Grabs settings to put into text
        TxtWordEasy.Text = "Easy: " & My.Settings.WordEasyTop.ToString
        TxtWordMed.Text = "Medium: " & My.Settings.WordMedTop.ToString
        TxtWordHard.Text = "Hard: " & My.Settings.WordHardTop.ToString

        TxtImgEasy.Text = "Fruit and Veg: " & My.Settings.ImageA.ToString
        TxtImgMed.Text = "Sports: " & My.Settings.ImageB.ToString
        TxtImgHard.Text = "Clothing: " & My.Settings.ImageC.ToString

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
        MainMenu1.TxtFlavour.Text = "Handy tip go here"
        MainMenu1.TxtMenuName.Text = "Welcome to Boggle"
        Me.Close()
        MainMenu1.msgbox = False

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