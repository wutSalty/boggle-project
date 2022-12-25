<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageMatchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageMatchForm))
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnMini = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.PB1 = New System.Windows.Forms.PictureBox()
        Me.PB2 = New System.Windows.Forms.PictureBox()
        Me.PB3 = New System.Windows.Forms.PictureBox()
        Me.PB4 = New System.Windows.Forms.PictureBox()
        Me.PB5 = New System.Windows.Forms.PictureBox()
        Me.PB6 = New System.Windows.Forms.PictureBox()
        Me.PB7 = New System.Windows.Forms.PictureBox()
        Me.PB8 = New System.Windows.Forms.PictureBox()
        Me.PB9 = New System.Windows.Forms.PictureBox()
        Me.PB10 = New System.Windows.Forms.PictureBox()
        Me.PB11 = New System.Windows.Forms.PictureBox()
        Me.PB12 = New System.Windows.Forms.PictureBox()
        Me.PB13 = New System.Windows.Forms.PictureBox()
        Me.PB14 = New System.Windows.Forms.PictureBox()
        Me.PB15 = New System.Windows.Forms.PictureBox()
        Me.PB16 = New System.Windows.Forms.PictureBox()
        Me.PB17 = New System.Windows.Forms.PictureBox()
        Me.PB18 = New System.Windows.Forms.PictureBox()
        Me.BtnLeave = New System.Windows.Forms.Button()
        Me.TxtTime = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TxtCardsLeft = New System.Windows.Forms.Label()
        Me.GifBox = New System.Windows.Forms.PictureBox()
        Me.TxtAdvice = New System.Windows.Forms.Label()
        Me.PBack = New System.Windows.Forms.PictureBox()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Pic2 = New System.Windows.Forms.PictureBox()
        Me.Pic3 = New System.Windows.Forms.PictureBox()
        Me.Pic4 = New System.Windows.Forms.PictureBox()
        Me.Pic5 = New System.Windows.Forms.PictureBox()
        Me.Pic6 = New System.Windows.Forms.PictureBox()
        Me.Pic7 = New System.Windows.Forms.PictureBox()
        Me.Pic8 = New System.Windows.Forms.PictureBox()
        Me.Pic9 = New System.Windows.Forms.PictureBox()
        Me.FlipBack = New System.Windows.Forms.Timer(Me.components)
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.TxtDiff = New System.Windows.Forms.Label()
        Me.TransparencyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelGrab.SuspendLayout()
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GifBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Controls.Add(Me.BtnMini)
        Me.PanelGrab.Controls.Add(Me.BtnExit)
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(1158, 34)
        Me.PanelGrab.TabIndex = 1
        '
        'BtnMini
        '
        Me.BtnMini.FlatAppearance.BorderSize = 0
        Me.BtnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMini.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMini.Location = New System.Drawing.Point(1090, 0)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(34, 34)
        Me.BtnMini.TabIndex = 3
        Me.BtnMini.TabStop = False
        Me.BtnMini.Text = "-"
        Me.BtnMini.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(1124, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(34, 34)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PB1
        '
        Me.PB1.BackColor = System.Drawing.Color.Transparent
        Me.PB1.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB1.InitialImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB1.Location = New System.Drawing.Point(50, 76)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(110, 150)
        Me.PB1.TabIndex = 2
        Me.PB1.TabStop = False
        Me.PB1.Tag = "0"
        '
        'PB2
        '
        Me.PB2.BackColor = System.Drawing.Color.Transparent
        Me.PB2.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB2.InitialImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB2.Location = New System.Drawing.Point(210, 76)
        Me.PB2.Name = "PB2"
        Me.PB2.Size = New System.Drawing.Size(110, 150)
        Me.PB2.TabIndex = 3
        Me.PB2.TabStop = False
        Me.PB2.Tag = "1"
        '
        'PB3
        '
        Me.PB3.BackColor = System.Drawing.Color.Transparent
        Me.PB3.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB3.InitialImage = CType(resources.GetObject("PB3.InitialImage"), System.Drawing.Image)
        Me.PB3.Location = New System.Drawing.Point(370, 76)
        Me.PB3.Name = "PB3"
        Me.PB3.Size = New System.Drawing.Size(110, 150)
        Me.PB3.TabIndex = 4
        Me.PB3.TabStop = False
        Me.PB3.Tag = "2"
        '
        'PB4
        '
        Me.PB4.BackColor = System.Drawing.Color.Transparent
        Me.PB4.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB4.InitialImage = CType(resources.GetObject("PB4.InitialImage"), System.Drawing.Image)
        Me.PB4.Location = New System.Drawing.Point(530, 76)
        Me.PB4.Name = "PB4"
        Me.PB4.Size = New System.Drawing.Size(110, 150)
        Me.PB4.TabIndex = 5
        Me.PB4.TabStop = False
        Me.PB4.Tag = "3"
        '
        'PB5
        '
        Me.PB5.BackColor = System.Drawing.Color.Transparent
        Me.PB5.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB5.InitialImage = CType(resources.GetObject("PB5.InitialImage"), System.Drawing.Image)
        Me.PB5.Location = New System.Drawing.Point(690, 76)
        Me.PB5.Name = "PB5"
        Me.PB5.Size = New System.Drawing.Size(110, 150)
        Me.PB5.TabIndex = 6
        Me.PB5.TabStop = False
        Me.PB5.Tag = "4"
        '
        'PB6
        '
        Me.PB6.BackColor = System.Drawing.Color.Transparent
        Me.PB6.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB6.InitialImage = CType(resources.GetObject("PB6.InitialImage"), System.Drawing.Image)
        Me.PB6.Location = New System.Drawing.Point(850, 76)
        Me.PB6.Name = "PB6"
        Me.PB6.Size = New System.Drawing.Size(110, 150)
        Me.PB6.TabIndex = 7
        Me.PB6.TabStop = False
        Me.PB6.Tag = "5"
        '
        'PB7
        '
        Me.PB7.BackColor = System.Drawing.Color.Transparent
        Me.PB7.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB7.InitialImage = CType(resources.GetObject("PB7.InitialImage"), System.Drawing.Image)
        Me.PB7.Location = New System.Drawing.Point(50, 267)
        Me.PB7.Name = "PB7"
        Me.PB7.Size = New System.Drawing.Size(110, 150)
        Me.PB7.TabIndex = 8
        Me.PB7.TabStop = False
        Me.PB7.Tag = "6"
        '
        'PB8
        '
        Me.PB8.BackColor = System.Drawing.Color.Transparent
        Me.PB8.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB8.InitialImage = CType(resources.GetObject("PB8.InitialImage"), System.Drawing.Image)
        Me.PB8.Location = New System.Drawing.Point(210, 267)
        Me.PB8.Name = "PB8"
        Me.PB8.Size = New System.Drawing.Size(110, 150)
        Me.PB8.TabIndex = 9
        Me.PB8.TabStop = False
        Me.PB8.Tag = "7"
        '
        'PB9
        '
        Me.PB9.BackColor = System.Drawing.Color.Transparent
        Me.PB9.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB9.InitialImage = CType(resources.GetObject("PB9.InitialImage"), System.Drawing.Image)
        Me.PB9.Location = New System.Drawing.Point(370, 267)
        Me.PB9.Name = "PB9"
        Me.PB9.Size = New System.Drawing.Size(110, 150)
        Me.PB9.TabIndex = 10
        Me.PB9.TabStop = False
        Me.PB9.Tag = "8"
        '
        'PB10
        '
        Me.PB10.BackColor = System.Drawing.Color.Transparent
        Me.PB10.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB10.InitialImage = CType(resources.GetObject("PB10.InitialImage"), System.Drawing.Image)
        Me.PB10.Location = New System.Drawing.Point(530, 267)
        Me.PB10.Name = "PB10"
        Me.PB10.Size = New System.Drawing.Size(110, 150)
        Me.PB10.TabIndex = 11
        Me.PB10.TabStop = False
        Me.PB10.Tag = "9"
        '
        'PB11
        '
        Me.PB11.BackColor = System.Drawing.Color.Transparent
        Me.PB11.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB11.InitialImage = CType(resources.GetObject("PB11.InitialImage"), System.Drawing.Image)
        Me.PB11.Location = New System.Drawing.Point(690, 267)
        Me.PB11.Name = "PB11"
        Me.PB11.Size = New System.Drawing.Size(110, 150)
        Me.PB11.TabIndex = 12
        Me.PB11.TabStop = False
        Me.PB11.Tag = "10"
        '
        'PB12
        '
        Me.PB12.BackColor = System.Drawing.Color.Transparent
        Me.PB12.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB12.InitialImage = CType(resources.GetObject("PB12.InitialImage"), System.Drawing.Image)
        Me.PB12.Location = New System.Drawing.Point(850, 267)
        Me.PB12.Name = "PB12"
        Me.PB12.Size = New System.Drawing.Size(110, 150)
        Me.PB12.TabIndex = 13
        Me.PB12.TabStop = False
        Me.PB12.Tag = "11"
        '
        'PB13
        '
        Me.PB13.BackColor = System.Drawing.Color.Transparent
        Me.PB13.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB13.InitialImage = CType(resources.GetObject("PB13.InitialImage"), System.Drawing.Image)
        Me.PB13.Location = New System.Drawing.Point(50, 458)
        Me.PB13.Name = "PB13"
        Me.PB13.Size = New System.Drawing.Size(110, 150)
        Me.PB13.TabIndex = 14
        Me.PB13.TabStop = False
        Me.PB13.Tag = "12"
        '
        'PB14
        '
        Me.PB14.BackColor = System.Drawing.Color.Transparent
        Me.PB14.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB14.InitialImage = CType(resources.GetObject("PB14.InitialImage"), System.Drawing.Image)
        Me.PB14.Location = New System.Drawing.Point(210, 458)
        Me.PB14.Name = "PB14"
        Me.PB14.Size = New System.Drawing.Size(110, 150)
        Me.PB14.TabIndex = 15
        Me.PB14.TabStop = False
        Me.PB14.Tag = "13"
        '
        'PB15
        '
        Me.PB15.BackColor = System.Drawing.Color.Transparent
        Me.PB15.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB15.InitialImage = CType(resources.GetObject("PB15.InitialImage"), System.Drawing.Image)
        Me.PB15.Location = New System.Drawing.Point(370, 458)
        Me.PB15.Name = "PB15"
        Me.PB15.Size = New System.Drawing.Size(110, 150)
        Me.PB15.TabIndex = 16
        Me.PB15.TabStop = False
        Me.PB15.Tag = "14"
        '
        'PB16
        '
        Me.PB16.BackColor = System.Drawing.Color.Transparent
        Me.PB16.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB16.InitialImage = CType(resources.GetObject("PB16.InitialImage"), System.Drawing.Image)
        Me.PB16.Location = New System.Drawing.Point(530, 458)
        Me.PB16.Name = "PB16"
        Me.PB16.Size = New System.Drawing.Size(110, 150)
        Me.PB16.TabIndex = 17
        Me.PB16.TabStop = False
        Me.PB16.Tag = "15"
        '
        'PB17
        '
        Me.PB17.BackColor = System.Drawing.Color.Transparent
        Me.PB17.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB17.InitialImage = CType(resources.GetObject("PB17.InitialImage"), System.Drawing.Image)
        Me.PB17.Location = New System.Drawing.Point(690, 458)
        Me.PB17.Name = "PB17"
        Me.PB17.Size = New System.Drawing.Size(110, 150)
        Me.PB17.TabIndex = 18
        Me.PB17.TabStop = False
        Me.PB17.Tag = "16"
        '
        'PB18
        '
        Me.PB18.BackColor = System.Drawing.Color.Transparent
        Me.PB18.BackgroundImage = Global.BoggleGame.My.Resources.Resources.cardback
        Me.PB18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB18.InitialImage = CType(resources.GetObject("PB18.InitialImage"), System.Drawing.Image)
        Me.PB18.Location = New System.Drawing.Point(850, 458)
        Me.PB18.Name = "PB18"
        Me.PB18.Size = New System.Drawing.Size(110, 150)
        Me.PB18.TabIndex = 19
        Me.PB18.TabStop = False
        Me.PB18.Tag = "17"
        '
        'BtnLeave
        '
        Me.BtnLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnLeave.FlatAppearance.BorderSize = 0
        Me.BtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeave.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLeave.ForeColor = System.Drawing.Color.Black
        Me.BtnLeave.Location = New System.Drawing.Point(1035, 594)
        Me.BtnLeave.Name = "BtnLeave"
        Me.BtnLeave.Size = New System.Drawing.Size(100, 40)
        Me.BtnLeave.TabIndex = 20
        Me.BtnLeave.TabStop = False
        Me.BtnLeave.Text = "Quit Early"
        Me.BtnLeave.UseVisualStyleBackColor = False
        '
        'TxtTime
        '
        Me.TxtTime.AutoEllipsis = True
        Me.TxtTime.BackColor = System.Drawing.Color.Transparent
        Me.TxtTime.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTime.Location = New System.Drawing.Point(1015, 76)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.Size = New System.Drawing.Size(140, 70)
        Me.TxtTime.TabIndex = 21
        Me.TxtTime.Text = "Timer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0.0"
        '
        'Timer
        '
        '
        'TxtCardsLeft
        '
        Me.TxtCardsLeft.AutoEllipsis = True
        Me.TxtCardsLeft.BackColor = System.Drawing.Color.Transparent
        Me.TxtCardsLeft.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCardsLeft.Location = New System.Drawing.Point(1015, 156)
        Me.TxtCardsLeft.Name = "TxtCardsLeft"
        Me.TxtCardsLeft.Size = New System.Drawing.Size(130, 70)
        Me.TxtCardsLeft.TabIndex = 23
        Me.TxtCardsLeft.Text = "Pairs left:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        '
        'GifBox
        '
        Me.GifBox.BackColor = System.Drawing.Color.Transparent
        Me.GifBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GifBox.Enabled = False
        Me.GifBox.Image = Global.BoggleGame.My.Resources.Resources.AppIcon1
        Me.GifBox.Location = New System.Drawing.Point(1050, 375)
        Me.GifBox.Name = "GifBox"
        Me.GifBox.Size = New System.Drawing.Size(75, 75)
        Me.GifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GifBox.TabIndex = 24
        Me.GifBox.TabStop = False
        '
        'TxtAdvice
        '
        Me.TxtAdvice.AutoEllipsis = True
        Me.TxtAdvice.BackColor = System.Drawing.Color.Transparent
        Me.TxtAdvice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdvice.Location = New System.Drawing.Point(1042, 453)
        Me.TxtAdvice.Name = "TxtAdvice"
        Me.TxtAdvice.Size = New System.Drawing.Size(90, 60)
        Me.TxtAdvice.TabIndex = 25
        Me.TxtAdvice.Text = "Take your time..."
        Me.TxtAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBack
        '
        Me.PBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBack.Location = New System.Drawing.Point(8, 84)
        Me.PBack.Name = "PBack"
        Me.PBack.Size = New System.Drawing.Size(33, 45)
        Me.PBack.TabIndex = 26
        Me.PBack.TabStop = False
        '
        'Pic1
        '
        Me.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic1.Location = New System.Drawing.Point(8, 136)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(33, 45)
        Me.Pic1.TabIndex = 27
        Me.Pic1.TabStop = False
        '
        'Pic2
        '
        Me.Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic2.Location = New System.Drawing.Point(8, 188)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(33, 45)
        Me.Pic2.TabIndex = 28
        Me.Pic2.TabStop = False
        '
        'Pic3
        '
        Me.Pic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic3.Location = New System.Drawing.Point(8, 240)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(33, 45)
        Me.Pic3.TabIndex = 29
        Me.Pic3.TabStop = False
        '
        'Pic4
        '
        Me.Pic4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic4.Location = New System.Drawing.Point(8, 292)
        Me.Pic4.Name = "Pic4"
        Me.Pic4.Size = New System.Drawing.Size(33, 45)
        Me.Pic4.TabIndex = 30
        Me.Pic4.TabStop = False
        '
        'Pic5
        '
        Me.Pic5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic5.Location = New System.Drawing.Point(8, 344)
        Me.Pic5.Name = "Pic5"
        Me.Pic5.Size = New System.Drawing.Size(33, 45)
        Me.Pic5.TabIndex = 31
        Me.Pic5.TabStop = False
        '
        'Pic6
        '
        Me.Pic6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic6.Location = New System.Drawing.Point(8, 396)
        Me.Pic6.Name = "Pic6"
        Me.Pic6.Size = New System.Drawing.Size(33, 45)
        Me.Pic6.TabIndex = 32
        Me.Pic6.TabStop = False
        '
        'Pic7
        '
        Me.Pic7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic7.Location = New System.Drawing.Point(8, 448)
        Me.Pic7.Name = "Pic7"
        Me.Pic7.Size = New System.Drawing.Size(33, 45)
        Me.Pic7.TabIndex = 33
        Me.Pic7.TabStop = False
        '
        'Pic8
        '
        Me.Pic8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic8.Location = New System.Drawing.Point(8, 500)
        Me.Pic8.Name = "Pic8"
        Me.Pic8.Size = New System.Drawing.Size(33, 45)
        Me.Pic8.TabIndex = 34
        Me.Pic8.TabStop = False
        '
        'Pic9
        '
        Me.Pic9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic9.Location = New System.Drawing.Point(8, 552)
        Me.Pic9.Name = "Pic9"
        Me.Pic9.Size = New System.Drawing.Size(33, 45)
        Me.Pic9.TabIndex = 35
        Me.Pic9.TabStop = False
        '
        'FlipBack
        '
        '
        'BtnPause
        '
        Me.BtnPause.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnPause.FlatAppearance.BorderSize = 0
        Me.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPause.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPause.ForeColor = System.Drawing.Color.Black
        Me.BtnPause.Location = New System.Drawing.Point(1035, 548)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(100, 40)
        Me.BtnPause.TabIndex = 36
        Me.BtnPause.TabStop = False
        Me.BtnPause.Text = "Pause Game"
        Me.BtnPause.UseVisualStyleBackColor = False
        '
        'Countdown
        '
        Me.Countdown.Interval = 1000
        '
        'TxtDiff
        '
        Me.TxtDiff.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiff.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiff.Location = New System.Drawing.Point(1015, 267)
        Me.TxtDiff.Name = "TxtDiff"
        Me.TxtDiff.Size = New System.Drawing.Size(140, 70)
        Me.TxtDiff.TabIndex = 37
        Me.TxtDiff.Text = "Deck:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fruit and Veg"
        '
        'TransparencyTimer
        '
        '
        'ImageMatchForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.imagebg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1160, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtDiff)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.Pic9)
        Me.Controls.Add(Me.Pic8)
        Me.Controls.Add(Me.Pic7)
        Me.Controls.Add(Me.Pic6)
        Me.Controls.Add(Me.Pic5)
        Me.Controls.Add(Me.Pic4)
        Me.Controls.Add(Me.Pic3)
        Me.Controls.Add(Me.Pic2)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.PBack)
        Me.Controls.Add(Me.TxtAdvice)
        Me.Controls.Add(Me.GifBox)
        Me.Controls.Add(Me.TxtCardsLeft)
        Me.Controls.Add(Me.TxtTime)
        Me.Controls.Add(Me.BtnLeave)
        Me.Controls.Add(Me.PB18)
        Me.Controls.Add(Me.PB17)
        Me.Controls.Add(Me.PB16)
        Me.Controls.Add(Me.PB15)
        Me.Controls.Add(Me.PB14)
        Me.Controls.Add(Me.PB13)
        Me.Controls.Add(Me.PB12)
        Me.Controls.Add(Me.PB11)
        Me.Controls.Add(Me.PB10)
        Me.Controls.Add(Me.PB9)
        Me.Controls.Add(Me.PB8)
        Me.Controls.Add(Me.PB7)
        Me.Controls.Add(Me.PB6)
        Me.Controls.Add(Me.PB5)
        Me.Controls.Add(Me.PB4)
        Me.Controls.Add(Me.PB3)
        Me.Controls.Add(Me.PB2)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.PanelGrab)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImageMatchForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boggle - Image Match"
        Me.PanelGrab.ResumeLayout(False)
        CType(Me.PB1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GifBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelGrab As Panel
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents PB4 As PictureBox
    Friend WithEvents PB5 As PictureBox
    Friend WithEvents PB6 As PictureBox
    Friend WithEvents PB7 As PictureBox
    Friend WithEvents PB8 As PictureBox
    Friend WithEvents PB9 As PictureBox
    Friend WithEvents PB10 As PictureBox
    Friend WithEvents PB11 As PictureBox
    Friend WithEvents PB12 As PictureBox
    Friend WithEvents PB13 As PictureBox
    Friend WithEvents PB14 As PictureBox
    Friend WithEvents PB15 As PictureBox
    Friend WithEvents PB16 As PictureBox
    Friend WithEvents PB17 As PictureBox
    Friend WithEvents PB18 As PictureBox
    Friend WithEvents BtnLeave As Button
    Friend WithEvents TxtTime As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents TxtCardsLeft As Label
    Friend WithEvents GifBox As PictureBox
    Friend WithEvents TxtAdvice As Label
    Friend WithEvents PBack As PictureBox
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Pic2 As PictureBox
    Friend WithEvents Pic3 As PictureBox
    Friend WithEvents Pic4 As PictureBox
    Friend WithEvents Pic5 As PictureBox
    Friend WithEvents Pic6 As PictureBox
    Friend WithEvents Pic7 As PictureBox
    Friend WithEvents Pic8 As PictureBox
    Friend WithEvents Pic9 As PictureBox
    Friend WithEvents FlipBack As Timer
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnMini As Button
    Friend WithEvents Countdown As Timer
    Friend WithEvents TxtDiff As Label
    Friend WithEvents TransparencyTimer As Timer
End Class
