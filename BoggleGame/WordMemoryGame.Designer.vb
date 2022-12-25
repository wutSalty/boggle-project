<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WordMemoryGame
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtStatus = New System.Windows.Forms.Label()
        Me.AnswerBox = New System.Windows.Forms.TextBox()
        Me.TimerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.TxtTimer = New System.Windows.Forms.Label()
        Me.TxtCurrent = New System.Windows.Forms.Label()
        Me.TxtScore = New System.Windows.Forms.Label()
        Me.PanelBehind = New System.Windows.Forms.Panel()
        Me.PanelFront = New System.Windows.Forms.Panel()
        Me.BtnLeave = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.Ih8VB = New System.Windows.Forms.Timer(Me.components)
        Me.TxtDiff = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtStatus
        '
        Me.TxtStatus.AutoEllipsis = True
        Me.TxtStatus.BackColor = System.Drawing.Color.Transparent
        Me.TxtStatus.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.Location = New System.Drawing.Point(10, 49)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Size = New System.Drawing.Size(352, 38)
        Me.TxtStatus.TabIndex = 3
        Me.TxtStatus.Text = "Remember these words..."
        Me.TxtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnswerBox
        '
        Me.AnswerBox.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.AnswerBox.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnswerBox.Location = New System.Drawing.Point(292, 320)
        Me.AnswerBox.Name = "AnswerBox"
        Me.AnswerBox.ShortcutsEnabled = False
        Me.AnswerBox.Size = New System.Drawing.Size(200, 48)
        Me.AnswerBox.TabIndex = 0
        Me.AnswerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimerCountdown
        '
        Me.TimerCountdown.Interval = 1000
        '
        'TxtTimer
        '
        Me.TxtTimer.BackColor = System.Drawing.Color.Transparent
        Me.TxtTimer.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTimer.Location = New System.Drawing.Point(17, 109)
        Me.TxtTimer.Name = "TxtTimer"
        Me.TxtTimer.Size = New System.Drawing.Size(60, 30)
        Me.TxtTimer.TabIndex = 2
        Me.TxtTimer.Text = "E"
        Me.TxtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCurrent
        '
        Me.TxtCurrent.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCurrent.BackColor = System.Drawing.Color.Transparent
        Me.TxtCurrent.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrent.Location = New System.Drawing.Point(92, 170)
        Me.TxtCurrent.Name = "TxtCurrent"
        Me.TxtCurrent.Size = New System.Drawing.Size(600, 70)
        Me.TxtCurrent.TabIndex = 3
        Me.TxtCurrent.Text = "---"
        Me.TxtCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtScore
        '
        Me.TxtScore.AutoEllipsis = True
        Me.TxtScore.BackColor = System.Drawing.Color.Transparent
        Me.TxtScore.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScore.Location = New System.Drawing.Point(657, 95)
        Me.TxtScore.Name = "TxtScore"
        Me.TxtScore.Size = New System.Drawing.Size(110, 30)
        Me.TxtScore.TabIndex = 4
        Me.TxtScore.Text = "Score: "
        '
        'PanelBehind
        '
        Me.PanelBehind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelBehind.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelBehind.Location = New System.Drawing.Point(32, 143)
        Me.PanelBehind.Name = "PanelBehind"
        Me.PanelBehind.Size = New System.Drawing.Size(25, 300)
        Me.PanelBehind.TabIndex = 5
        '
        'PanelFront
        '
        Me.PanelFront.BackColor = System.Drawing.Color.Transparent
        Me.PanelFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFront.Location = New System.Drawing.Point(30, 141)
        Me.PanelFront.Name = "PanelFront"
        Me.PanelFront.Size = New System.Drawing.Size(29, 304)
        Me.PanelFront.TabIndex = 0
        '
        'BtnLeave
        '
        Me.BtnLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BtnLeave.FlatAppearance.BorderSize = 0
        Me.BtnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLeave.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLeave.ForeColor = System.Drawing.Color.Black
        Me.BtnLeave.Location = New System.Drawing.Point(660, 420)
        Me.BtnLeave.Name = "BtnLeave"
        Me.BtnLeave.Size = New System.Drawing.Size(100, 30)
        Me.BtnLeave.TabIndex = 6
        Me.BtnLeave.TabStop = False
        Me.BtnLeave.Text = "Quit Early"
        Me.BtnLeave.UseVisualStyleBackColor = False
        '
        'BtnPause
        '
        Me.BtnPause.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BtnPause.FlatAppearance.BorderSize = 0
        Me.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPause.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPause.ForeColor = System.Drawing.Color.Black
        Me.BtnPause.Location = New System.Drawing.Point(530, 420)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(100, 30)
        Me.BtnPause.TabIndex = 7
        Me.BtnPause.TabStop = False
        Me.BtnPause.Text = "Pause Game"
        Me.BtnPause.UseVisualStyleBackColor = False
        '
        'Ih8VB
        '
        '
        'TxtDiff
        '
        Me.TxtDiff.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiff.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiff.Location = New System.Drawing.Point(537, 43)
        Me.TxtDiff.Name = "TxtDiff"
        Me.TxtDiff.Size = New System.Drawing.Size(230, 30)
        Me.TxtDiff.TabIndex = 8
        Me.TxtDiff.Text = "Difficulty: "
        Me.TxtDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WordMemoryGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.wordbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.TxtDiff)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnLeave)
        Me.Controls.Add(Me.PanelBehind)
        Me.Controls.Add(Me.TxtScore)
        Me.Controls.Add(Me.TxtCurrent)
        Me.Controls.Add(Me.TxtTimer)
        Me.Controls.Add(Me.AnswerBox)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.PanelFront)
        Me.Name = "WordMemoryGame"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtStatus As Label
    Friend WithEvents AnswerBox As TextBox
    Friend WithEvents TimerCountdown As Timer
    Friend WithEvents TxtTimer As Label
    Friend WithEvents TxtCurrent As Label
    Friend WithEvents TxtScore As Label
    Friend WithEvents PanelBehind As Panel
    Friend WithEvents PanelFront As Panel
    Friend WithEvents BtnLeave As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents Ih8VB As Timer
    Friend WithEvents TxtDiff As Label
End Class
