<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageResults))
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.TxtDone = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.Label()
        Me.TxtRecords = New System.Windows.Forms.Label()
        Me.BtnSameAgain = New System.Windows.Forms.Button()
        Me.BtnPlayAgain = New System.Windows.Forms.Button()
        Me.BtnReturnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(748, 34)
        Me.PanelGrab.TabIndex = 3
        '
        'TxtDone
        '
        Me.TxtDone.AutoSize = True
        Me.TxtDone.BackColor = System.Drawing.Color.Transparent
        Me.TxtDone.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDone.Location = New System.Drawing.Point(25, 45)
        Me.TxtDone.Name = "TxtDone"
        Me.TxtDone.Size = New System.Drawing.Size(324, 45)
        Me.TxtDone.TabIndex = 4
        Me.TxtDone.Text = "Congrats! You did it!"
        '
        'TxtResult
        '
        Me.TxtResult.AutoEllipsis = True
        Me.TxtResult.BackColor = System.Drawing.Color.Transparent
        Me.TxtResult.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(40, 115)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(650, 150)
        Me.TxtResult.TabIndex = 5
        Me.TxtResult.Text = "On the [game type] deck, you managed to match all the cards in [seconds].[time]!"
        '
        'TxtRecords
        '
        Me.TxtRecords.AutoEllipsis = True
        Me.TxtRecords.BackColor = System.Drawing.Color.Transparent
        Me.TxtRecords.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecords.Location = New System.Drawing.Point(40, 220)
        Me.TxtRecords.Name = "TxtRecords"
        Me.TxtRecords.Size = New System.Drawing.Size(650, 175)
        Me.TxtRecords.TabIndex = 6
        Me.TxtRecords.Text = "Unfortunately you didn't beat your record of [record time] for this deck. But kee" &
    "p it at! Want to play with different cards? Why not check out the Custom deck op" &
    "tions!"
        '
        'BtnSameAgain
        '
        Me.BtnSameAgain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnSameAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSameAgain.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSameAgain.Location = New System.Drawing.Point(0, 410)
        Me.BtnSameAgain.Name = "BtnSameAgain"
        Me.BtnSameAgain.Size = New System.Drawing.Size(251, 65)
        Me.BtnSameAgain.TabIndex = 0
        Me.BtnSameAgain.TabStop = False
        Me.BtnSameAgain.Text = "Play Again (Same Deck)"
        Me.BtnSameAgain.UseVisualStyleBackColor = False
        '
        'BtnPlayAgain
        '
        Me.BtnPlayAgain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlayAgain.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlayAgain.Location = New System.Drawing.Point(250, 410)
        Me.BtnPlayAgain.Name = "BtnPlayAgain"
        Me.BtnPlayAgain.Size = New System.Drawing.Size(250, 65)
        Me.BtnPlayAgain.TabIndex = 0
        Me.BtnPlayAgain.TabStop = False
        Me.BtnPlayAgain.Text = "Return to Deck Select"
        Me.BtnPlayAgain.UseVisualStyleBackColor = False
        '
        'BtnReturnHome
        '
        Me.BtnReturnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturnHome.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturnHome.Location = New System.Drawing.Point(499, 410)
        Me.BtnReturnHome.Name = "BtnReturnHome"
        Me.BtnReturnHome.Size = New System.Drawing.Size(251, 65)
        Me.BtnReturnHome.TabIndex = 0
        Me.BtnReturnHome.TabStop = False
        Me.BtnReturnHome.Text = "Return to Main Menu"
        Me.BtnReturnHome.UseVisualStyleBackColor = False
        '
        'ImageResults
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgimageresults
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(750, 475)
        Me.Controls.Add(Me.BtnReturnHome)
        Me.Controls.Add(Me.BtnPlayAgain)
        Me.Controls.Add(Me.BtnSameAgain)
        Me.Controls.Add(Me.TxtRecords)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.TxtDone)
        Me.Controls.Add(Me.PanelGrab)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImageResults"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ImageResults"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents TxtDone As Label
    Friend WithEvents TxtResult As Label
    Friend WithEvents TxtRecords As Label
    Friend WithEvents BtnSameAgain As Button
    Friend WithEvents BtnPlayAgain As Button
    Friend WithEvents BtnReturnHome As Button
End Class
