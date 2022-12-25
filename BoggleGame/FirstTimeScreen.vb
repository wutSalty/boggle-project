Public Class FirstTimeScreen

    'Gosh darn fonts
    Private ItalicFont As New Font("Comic Sans MS", 12, FontStyle.Italic)
    Private StandardFont As New Font("Comic Sans MS", 12, FontStyle.Regular)

    Private Sub FirstTimeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtWelcome.Text = TxtWelcome.Text + SystemInformation.UserName + "!"

    End Sub

    Private Sub BtnToTitle_Click(sender As Object, e As EventArgs) Handles BtnToTitle.Click
        ActiveControl = Nothing
        MainForm.SFXPlay(My.Resources.beep)
        Title_Screen1.Show()
        Me.Hide()
        MainForm.Text = "Boggle - Title Screen"

        My.Settings.FirstTime = False
        DebugForm.UpdateDebug()

    End Sub

    Private Sub BtnToTitle_MouseEnter(sender As Object, e As EventArgs) Handles BtnToTitle.MouseEnter
        Select Case My.Settings.Theme
            Case 0, 1
                BtnToTitle.BackgroundImage = My.Resources.baselightb

            Case 2
                BtnToTitle.BackgroundImage = My.Resources.basedarkb

        End Select

    End Sub

    Private Sub BtnToTitle_MouseLeave(sender As Object, e As EventArgs) Handles BtnToTitle.MouseLeave
        Select Case My.Settings.Theme
            Case 0, 1
                BtnToTitle.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnToTitle.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub

    Private Sub BtnToTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnToTitle.MouseDown
        Select Case My.Settings.Theme
            Case 0, 1
                BtnToTitle.BackgroundImage = My.Resources.baselightc

            Case 2
                BtnToTitle.BackgroundImage = My.Resources.basedarkc

        End Select

    End Sub

    Private Sub BtnToTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnToTitle.MouseUp
        Select Case My.Settings.Theme
            Case 0, 1
                BtnToTitle.BackgroundImage = My.Resources.baselighta

            Case 2
                BtnToTitle.BackgroundImage = My.Resources.basedarka

        End Select

    End Sub
End Class
