Public Class Title_Screen

    Private Sub BtnStartApp_Click(sender As Object, e As EventArgs) Handles BtnStartApp.Click
        MainForm.SFXPlay(My.Resources.openbeep)
        'Shuffle menus around
        MainMenu1.Show()
        MainForm.ActiveControl = MainMenu1
        MainForm.Text = "Boggle - Main Menu"

    End Sub

    Private Sub BtnStartApp_MouseEnter(sender As Object, e As EventArgs) Handles BtnStartApp.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStartApp.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnStartApp.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnStartApp_MouseLeave(sender As Object, e As EventArgs) Handles BtnStartApp.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStartApp.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnStartApp.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnStartApp_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnStartApp.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStartApp.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnStartApp.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnStartApp_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnStartApp.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnStartApp.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnStartApp.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub
End Class
