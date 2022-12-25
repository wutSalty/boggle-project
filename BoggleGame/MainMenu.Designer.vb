<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtMainMenu = New System.Windows.Forms.Label()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.BtnImgMem = New System.Windows.Forms.Button()
        Me.BtnWordMem = New System.Windows.Forms.Button()
        Me.TxtFlavour = New System.Windows.Forms.Label()
        Me.BtnScores = New System.Windows.Forms.Button()
        Me.TxtMenuName = New System.Windows.Forms.Label()
        Me.BtnTheme = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtMainMenu
        '
        Me.TxtMainMenu.AutoEllipsis = True
        Me.TxtMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.TxtMainMenu.Font = New System.Drawing.Font("Comic Sans MS", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMainMenu.Location = New System.Drawing.Point(65, 32)
        Me.TxtMainMenu.Name = "TxtMainMenu"
        Me.TxtMainMenu.Size = New System.Drawing.Size(270, 65)
        Me.TxtMainMenu.TabIndex = 0
        Me.TxtMainMenu.Text = "Main Menu"
        Me.TxtMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnSettings
        '
        Me.BtnSettings.BackgroundImage = Global.BoggleGame.My.Resources.Resources.settingsiconlight
        Me.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnSettings.FlatAppearance.BorderSize = 0
        Me.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnSettings.Location = New System.Drawing.Point(575, 302)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(150, 50)
        Me.BtnSettings.TabIndex = 0
        Me.BtnSettings.TabStop = False
        Me.BtnSettings.UseVisualStyleBackColor = False
        '
        'BtnImgMem
        '
        Me.BtnImgMem.BackgroundImage = Global.BoggleGame.My.Resources.Resources.imageiconlight2
        Me.BtnImgMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnImgMem.FlatAppearance.BorderSize = 0
        Me.BtnImgMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImgMem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImgMem.Location = New System.Drawing.Point(317, 152)
        Me.BtnImgMem.Name = "BtnImgMem"
        Me.BtnImgMem.Size = New System.Drawing.Size(200, 200)
        Me.BtnImgMem.TabIndex = 0
        Me.BtnImgMem.TabStop = False
        Me.BtnImgMem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImgMem.UseVisualStyleBackColor = False
        '
        'BtnWordMem
        '
        Me.BtnWordMem.BackgroundImage = Global.BoggleGame.My.Resources.Resources.wordiconlight2
        Me.BtnWordMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnWordMem.FlatAppearance.BorderSize = 0
        Me.BtnWordMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWordMem.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWordMem.Location = New System.Drawing.Point(59, 152)
        Me.BtnWordMem.Name = "BtnWordMem"
        Me.BtnWordMem.Size = New System.Drawing.Size(200, 200)
        Me.BtnWordMem.TabIndex = 0
        Me.BtnWordMem.TabStop = False
        Me.BtnWordMem.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnWordMem.UseVisualStyleBackColor = False
        '
        'TxtFlavour
        '
        Me.TxtFlavour.AutoEllipsis = True
        Me.TxtFlavour.BackColor = System.Drawing.Color.Transparent
        Me.TxtFlavour.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlavour.Location = New System.Drawing.Point(275, 417)
        Me.TxtFlavour.Name = "TxtFlavour"
        Me.TxtFlavour.Size = New System.Drawing.Size(500, 30)
        Me.TxtFlavour.TabIndex = 0
        Me.TxtFlavour.Text = "Handy tip go here"
        Me.TxtFlavour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnScores
        '
        Me.BtnScores.BackgroundImage = Global.BoggleGame.My.Resources.Resources.recordsiconlight1
        Me.BtnScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnScores.FlatAppearance.BorderSize = 0
        Me.BtnScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnScores.Location = New System.Drawing.Point(575, 152)
        Me.BtnScores.Name = "BtnScores"
        Me.BtnScores.Size = New System.Drawing.Size(150, 125)
        Me.BtnScores.TabIndex = 0
        Me.BtnScores.TabStop = False
        Me.BtnScores.UseVisualStyleBackColor = False
        '
        'TxtMenuName
        '
        Me.TxtMenuName.AutoEllipsis = True
        Me.TxtMenuName.BackColor = System.Drawing.Color.Transparent
        Me.TxtMenuName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMenuName.Location = New System.Drawing.Point(469, 43)
        Me.TxtMenuName.Name = "TxtMenuName"
        Me.TxtMenuName.Size = New System.Drawing.Size(300, 30)
        Me.TxtMenuName.TabIndex = 0
        Me.TxtMenuName.Text = "Welcome to Boggle"
        Me.TxtMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnTheme
        '
        Me.BtnTheme.FlatAppearance.BorderSize = 0
        Me.BtnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTheme.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTheme.Location = New System.Drawing.Point(34, 417)
        Me.BtnTheme.Name = "BtnTheme"
        Me.BtnTheme.Size = New System.Drawing.Size(130, 30)
        Me.BtnTheme.TabIndex = 17
        Me.BtnTheme.TabStop = False
        Me.BtnTheme.Text = "Theme Settings"
        Me.BtnTheme.UseVisualStyleBackColor = False
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.Color.Transparent
        Me.BtnQuit.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuit.FlatAppearance.BorderSize = 0
        Me.BtnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuit.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuit.Location = New System.Drawing.Point(17, 47)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(40, 40)
        Me.BtnQuit.TabIndex = 0
        Me.BtnQuit.TabStop = False
        Me.BtnQuit.Text = "X"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgmainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnTheme)
        Me.Controls.Add(Me.TxtMenuName)
        Me.Controls.Add(Me.BtnScores)
        Me.Controls.Add(Me.TxtFlavour)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.BtnImgMem)
        Me.Controls.Add(Me.BtnWordMem)
        Me.Controls.Add(Me.TxtMainMenu)
        Me.Name = "MainMenu"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtMainMenu As Label
    Friend WithEvents BtnWordMem As Button
    Friend WithEvents BtnImgMem As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents TxtFlavour As Label
    Friend WithEvents BtnScores As Button
    Friend WithEvents TxtMenuName As Label
    Friend WithEvents BtnTheme As Button
    Friend WithEvents BtnQuit As Button
End Class
