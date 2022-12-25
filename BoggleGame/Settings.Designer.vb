<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckTitleSkip = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtSavedAt = New System.Windows.Forms.Label()
        Me.BtnResetAll = New System.Windows.Forms.Button()
        Me.CheckDebug = New System.Windows.Forms.CheckBox()
        Me.BtnEditList = New System.Windows.Forms.Button()
        Me.BtnHowImg = New System.Windows.Forms.Button()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.BoxCover1 = New System.Windows.Forms.PictureBox()
        Me.BoxCover2 = New System.Windows.Forms.PictureBox()
        Me.BoxCover3 = New System.Windows.Forms.PictureBox()
        Me.RadioCard1 = New System.Windows.Forms.RadioButton()
        Me.RadioCard2 = New System.Windows.Forms.RadioButton()
        Me.RadioCard3 = New System.Windows.Forms.RadioButton()
        Me.BtnCredits = New System.Windows.Forms.Button()
        Me.CheckShowCards = New System.Windows.Forms.CheckBox()
        Me.TxtFlavour = New System.Windows.Forms.Label()
        Me.CheckBGMute = New System.Windows.Forms.CheckBox()
        Me.CheckSFXMute = New System.Windows.Forms.CheckBox()
        CType(Me.BoxCover1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxCover2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxCover3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckTitleSkip
        '
        Me.CheckTitleSkip.AutoSize = True
        Me.CheckTitleSkip.BackColor = System.Drawing.Color.Transparent
        Me.CheckTitleSkip.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckTitleSkip.Location = New System.Drawing.Point(30, 115)
        Me.CheckTitleSkip.Name = "CheckTitleSkip"
        Me.CheckTitleSkip.Size = New System.Drawing.Size(182, 30)
        Me.CheckTitleSkip.TabIndex = 0
        Me.CheckTitleSkip.TabStop = False
        Me.CheckTitleSkip.Text = "Skip Title Screen"
        Me.CheckTitleSkip.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(624, 419)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 30)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.TabStop = False
        Me.BtnSave.Text = "Save and Return"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = Global.BoggleGame.My.Resources.Resources.backlighta
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(17, 47)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(40, 40)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtSavedAt
        '
        Me.TxtSavedAt.AutoEllipsis = True
        Me.TxtSavedAt.BackColor = System.Drawing.Color.Transparent
        Me.TxtSavedAt.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSavedAt.Location = New System.Drawing.Point(219, 419)
        Me.TxtSavedAt.Name = "TxtSavedAt"
        Me.TxtSavedAt.Size = New System.Drawing.Size(382, 30)
        Me.TxtSavedAt.TabIndex = 5
        Me.TxtSavedAt.Text = "-"
        Me.TxtSavedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnResetAll
        '
        Me.BtnResetAll.FlatAppearance.BorderSize = 0
        Me.BtnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetAll.Location = New System.Drawing.Point(34, 417)
        Me.BtnResetAll.Name = "BtnResetAll"
        Me.BtnResetAll.Size = New System.Drawing.Size(130, 30)
        Me.BtnResetAll.TabIndex = 0
        Me.BtnResetAll.TabStop = False
        Me.BtnResetAll.Text = "Reset Settings"
        Me.BtnResetAll.UseVisualStyleBackColor = False
        '
        'CheckDebug
        '
        Me.CheckDebug.AutoSize = True
        Me.CheckDebug.BackColor = System.Drawing.Color.Transparent
        Me.CheckDebug.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDebug.Location = New System.Drawing.Point(30, 185)
        Me.CheckDebug.Name = "CheckDebug"
        Me.CheckDebug.Size = New System.Drawing.Size(202, 30)
        Me.CheckDebug.TabIndex = 1
        Me.CheckDebug.TabStop = False
        Me.CheckDebug.Text = "Enable Debug Form"
        Me.CheckDebug.UseVisualStyleBackColor = False
        '
        'BtnEditList
        '
        Me.BtnEditList.FlatAppearance.BorderSize = 0
        Me.BtnEditList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditList.Location = New System.Drawing.Point(605, 90)
        Me.BtnEditList.Name = "BtnEditList"
        Me.BtnEditList.Size = New System.Drawing.Size(170, 60)
        Me.BtnEditList.TabIndex = 2
        Me.BtnEditList.TabStop = False
        Me.BtnEditList.Text = "How to use a custom word list?"
        Me.BtnEditList.UseVisualStyleBackColor = False
        '
        'BtnHowImg
        '
        Me.BtnHowImg.FlatAppearance.BorderSize = 0
        Me.BtnHowImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHowImg.Location = New System.Drawing.Point(606, 156)
        Me.BtnHowImg.Name = "BtnHowImg"
        Me.BtnHowImg.Size = New System.Drawing.Size(170, 60)
        Me.BtnHowImg.TabIndex = 3
        Me.BtnHowImg.TabStop = False
        Me.BtnHowImg.Text = "How to use a custom image deck?"
        Me.BtnHowImg.UseVisualStyleBackColor = False
        '
        'TxtTitle
        '
        Me.TxtTitle.AutoSize = True
        Me.TxtTitle.BackColor = System.Drawing.Color.Transparent
        Me.TxtTitle.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(65, 38)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(356, 52)
        Me.TxtTitle.TabIndex = 6
        Me.TxtTitle.Text = "Settings and Other"
        '
        'BoxCover1
        '
        Me.BoxCover1.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.BoxCover1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BoxCover1.Location = New System.Drawing.Point(45, 257)
        Me.BoxCover1.Name = "BoxCover1"
        Me.BoxCover1.Size = New System.Drawing.Size(88, 120)
        Me.BoxCover1.TabIndex = 7
        Me.BoxCover1.TabStop = False
        '
        'BoxCover2
        '
        Me.BoxCover2.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback1
        Me.BoxCover2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BoxCover2.Location = New System.Drawing.Point(192, 257)
        Me.BoxCover2.Name = "BoxCover2"
        Me.BoxCover2.Size = New System.Drawing.Size(88, 120)
        Me.BoxCover2.TabIndex = 8
        Me.BoxCover2.TabStop = False
        '
        'BoxCover3
        '
        Me.BoxCover3.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback2
        Me.BoxCover3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BoxCover3.Location = New System.Drawing.Point(337, 257)
        Me.BoxCover3.Name = "BoxCover3"
        Me.BoxCover3.Size = New System.Drawing.Size(88, 120)
        Me.BoxCover3.TabIndex = 9
        Me.BoxCover3.TabStop = False
        '
        'RadioCard1
        '
        Me.RadioCard1.AutoSize = True
        Me.RadioCard1.BackColor = System.Drawing.Color.Transparent
        Me.RadioCard1.Checked = True
        Me.RadioCard1.Location = New System.Drawing.Point(30, 230)
        Me.RadioCard1.Name = "RadioCard1"
        Me.RadioCard1.Size = New System.Drawing.Size(127, 27)
        Me.RadioCard1.TabIndex = 10
        Me.RadioCard1.TabStop = True
        Me.RadioCard1.Text = "Card Cover A"
        Me.RadioCard1.UseVisualStyleBackColor = False
        '
        'RadioCard2
        '
        Me.RadioCard2.AutoSize = True
        Me.RadioCard2.BackColor = System.Drawing.Color.Transparent
        Me.RadioCard2.Location = New System.Drawing.Point(177, 230)
        Me.RadioCard2.Name = "RadioCard2"
        Me.RadioCard2.Size = New System.Drawing.Size(125, 27)
        Me.RadioCard2.TabIndex = 11
        Me.RadioCard2.Text = "Card Cover B"
        Me.RadioCard2.UseVisualStyleBackColor = False
        '
        'RadioCard3
        '
        Me.RadioCard3.AutoSize = True
        Me.RadioCard3.BackColor = System.Drawing.Color.Transparent
        Me.RadioCard3.Location = New System.Drawing.Point(322, 230)
        Me.RadioCard3.Name = "RadioCard3"
        Me.RadioCard3.Size = New System.Drawing.Size(125, 27)
        Me.RadioCard3.TabIndex = 12
        Me.RadioCard3.Text = "Card Cover C"
        Me.RadioCard3.UseVisualStyleBackColor = False
        '
        'BtnCredits
        '
        Me.BtnCredits.FlatAppearance.BorderSize = 0
        Me.BtnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCredits.Location = New System.Drawing.Point(699, 360)
        Me.BtnCredits.Name = "BtnCredits"
        Me.BtnCredits.Size = New System.Drawing.Size(75, 30)
        Me.BtnCredits.TabIndex = 13
        Me.BtnCredits.TabStop = False
        Me.BtnCredits.Text = "Credits"
        Me.BtnCredits.UseVisualStyleBackColor = False
        '
        'CheckShowCards
        '
        Me.CheckShowCards.AutoSize = True
        Me.CheckShowCards.BackColor = System.Drawing.Color.Transparent
        Me.CheckShowCards.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckShowCards.Location = New System.Drawing.Point(30, 150)
        Me.CheckShowCards.Name = "CheckShowCards"
        Me.CheckShowCards.Size = New System.Drawing.Size(175, 30)
        Me.CheckShowCards.TabIndex = 14
        Me.CheckShowCards.TabStop = False
        Me.CheckShowCards.Text = "Show Card Deck"
        Me.CheckShowCards.UseVisualStyleBackColor = False
        '
        'TxtFlavour
        '
        Me.TxtFlavour.AutoEllipsis = True
        Me.TxtFlavour.BackColor = System.Drawing.Color.Transparent
        Me.TxtFlavour.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlavour.Location = New System.Drawing.Point(415, 43)
        Me.TxtFlavour.Name = "TxtFlavour"
        Me.TxtFlavour.Size = New System.Drawing.Size(359, 30)
        Me.TxtFlavour.TabIndex = 15
        Me.TxtFlavour.Text = "Customise your experience!"
        Me.TxtFlavour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBGMute
        '
        Me.CheckBGMute.AutoSize = True
        Me.CheckBGMute.BackColor = System.Drawing.Color.Transparent
        Me.CheckBGMute.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBGMute.Location = New System.Drawing.Point(320, 115)
        Me.CheckBGMute.Name = "CheckBGMute"
        Me.CheckBGMute.Size = New System.Drawing.Size(240, 30)
        Me.CheckBGMute.TabIndex = 16
        Me.CheckBGMute.Text = "Mute Background Music"
        Me.CheckBGMute.UseVisualStyleBackColor = False
        '
        'CheckSFXMute
        '
        Me.CheckSFXMute.AutoSize = True
        Me.CheckSFXMute.BackColor = System.Drawing.Color.Transparent
        Me.CheckSFXMute.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSFXMute.Location = New System.Drawing.Point(320, 150)
        Me.CheckSFXMute.Name = "CheckSFXMute"
        Me.CheckSFXMute.Size = New System.Drawing.Size(211, 30)
        Me.CheckSFXMute.TabIndex = 17
        Me.CheckSFXMute.Text = "Mute Sound Effects"
        Me.CheckSFXMute.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgmainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.CheckSFXMute)
        Me.Controls.Add(Me.CheckBGMute)
        Me.Controls.Add(Me.TxtFlavour)
        Me.Controls.Add(Me.CheckShowCards)
        Me.Controls.Add(Me.BtnCredits)
        Me.Controls.Add(Me.RadioCard3)
        Me.Controls.Add(Me.RadioCard2)
        Me.Controls.Add(Me.RadioCard1)
        Me.Controls.Add(Me.BoxCover3)
        Me.Controls.Add(Me.BoxCover2)
        Me.Controls.Add(Me.BoxCover1)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.TxtSavedAt)
        Me.Controls.Add(Me.BtnHowImg)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnEditList)
        Me.Controls.Add(Me.BtnResetAll)
        Me.Controls.Add(Me.CheckDebug)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.CheckTitleSkip)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Settings"
        Me.Size = New System.Drawing.Size(784, 461)
        CType(Me.BoxCover1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxCover2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxCover3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtSavedAt As Label
    Friend WithEvents CheckTitleSkip As CheckBox
    Friend WithEvents BtnResetAll As Button
    Friend WithEvents CheckDebug As CheckBox
    Friend WithEvents BtnEditList As Button
    Friend WithEvents BtnHowImg As Button
    Friend WithEvents TxtTitle As Label
    Friend WithEvents BoxCover1 As PictureBox
    Friend WithEvents BoxCover2 As PictureBox
    Friend WithEvents BoxCover3 As PictureBox
    Friend WithEvents RadioCard1 As RadioButton
    Friend WithEvents RadioCard2 As RadioButton
    Friend WithEvents RadioCard3 As RadioButton
    Friend WithEvents BtnCredits As Button
    Friend WithEvents CheckShowCards As CheckBox
    Friend WithEvents TxtFlavour As Label
    Friend WithEvents CheckBGMute As CheckBox
    Friend WithEvents CheckSFXMute As CheckBox
End Class
