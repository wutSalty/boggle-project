<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordResults
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
        Me.TxtWellDone = New System.Windows.Forms.Label()
        Me.TxtResult = New System.Windows.Forms.Label()
        Me.BtnPlayAgain = New System.Windows.Forms.Button()
        Me.BtnReturnHome = New System.Windows.Forms.Button()
        Me.BtnSameAgain = New System.Windows.Forms.Button()
        Me.BtnResults = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtWellDone
        '
        Me.TxtWellDone.AutoSize = True
        Me.TxtWellDone.BackColor = System.Drawing.Color.Transparent
        Me.TxtWellDone.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWellDone.Location = New System.Drawing.Point(25, 45)
        Me.TxtWellDone.Name = "TxtWellDone"
        Me.TxtWellDone.Size = New System.Drawing.Size(453, 90)
        Me.TxtWellDone.TabIndex = 0
        Me.TxtWellDone.Text = "Well done!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your final score was [Score]!"
        '
        'TxtResult
        '
        Me.TxtResult.AutoEllipsis = True
        Me.TxtResult.BackColor = System.Drawing.Color.Transparent
        Me.TxtResult.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResult.Location = New System.Drawing.Point(50, 170)
        Me.TxtResult.Name = "TxtResult"
        Me.TxtResult.Size = New System.Drawing.Size(684, 200)
        Me.TxtResult.TabIndex = 2
        Me.TxtResult.Text = "Good work! Since you're playing a Custom round, we can't keep track of your score" &
    "s here. But why not think about playing with some wilder settings or even creati" &
    "ng your own rules to play along with!"
        '
        'BtnPlayAgain
        '
        Me.BtnPlayAgain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlayAgain.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlayAgain.Location = New System.Drawing.Point(261, 396)
        Me.BtnPlayAgain.Name = "BtnPlayAgain"
        Me.BtnPlayAgain.Size = New System.Drawing.Size(262, 65)
        Me.BtnPlayAgain.TabIndex = 3
        Me.BtnPlayAgain.TabStop = False
        Me.BtnPlayAgain.Text = "Return to Difficulty Select"
        Me.BtnPlayAgain.UseVisualStyleBackColor = True
        '
        'BtnReturnHome
        '
        Me.BtnReturnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnReturnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturnHome.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturnHome.Location = New System.Drawing.Point(522, 396)
        Me.BtnReturnHome.Name = "BtnReturnHome"
        Me.BtnReturnHome.Size = New System.Drawing.Size(262, 65)
        Me.BtnReturnHome.TabIndex = 4
        Me.BtnReturnHome.TabStop = False
        Me.BtnReturnHome.Text = "Return to Main Menu"
        Me.BtnReturnHome.UseVisualStyleBackColor = True
        '
        'BtnSameAgain
        '
        Me.BtnSameAgain.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnSameAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSameAgain.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSameAgain.Location = New System.Drawing.Point(0, 396)
        Me.BtnSameAgain.Name = "BtnSameAgain"
        Me.BtnSameAgain.Size = New System.Drawing.Size(262, 65)
        Me.BtnSameAgain.TabIndex = 5
        Me.BtnSameAgain.TabStop = False
        Me.BtnSameAgain.Text = "Play Again (Same Difficulty)"
        Me.BtnSameAgain.UseVisualStyleBackColor = True
        '
        'BtnResults
        '
        Me.BtnResults.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.BtnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResults.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResults.Location = New System.Drawing.Point(575, 48)
        Me.BtnResults.Name = "BtnResults"
        Me.BtnResults.Size = New System.Drawing.Size(200, 40)
        Me.BtnResults.TabIndex = 6
        Me.BtnResults.TabStop = False
        Me.BtnResults.Text = "View the word list!"
        Me.BtnResults.UseVisualStyleBackColor = True
        '
        'WordResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgwordresults
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BtnResults)
        Me.Controls.Add(Me.BtnSameAgain)
        Me.Controls.Add(Me.BtnReturnHome)
        Me.Controls.Add(Me.BtnPlayAgain)
        Me.Controls.Add(Me.TxtResult)
        Me.Controls.Add(Me.TxtWellDone)
        Me.Name = "WordResults"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtWellDone As Label
    Friend WithEvents TxtResult As Label
    Friend WithEvents BtnPlayAgain As Button
    Friend WithEvents BtnReturnHome As Button
    Friend WithEvents BtnSameAgain As Button
    Friend WithEvents BtnResults As Button
End Class
