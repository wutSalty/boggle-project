<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WordDifficultySelect
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
        Me.TxtWordMem = New System.Windows.Forms.Label()
        Me.BtnMed = New System.Windows.Forms.Button()
        Me.BtnHard = New System.Windows.Forms.Button()
        Me.TxtDiff = New System.Windows.Forms.Label()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.BtnCustom = New System.Windows.Forms.Button()
        Me.BtnDesc = New System.Windows.Forms.Button()
        Me.TxtFlavour = New System.Windows.Forms.Label()
        Me.BtnEasy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnEasy
        '
        Me.BtnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEasy.FlatAppearance.BorderSize = 0
        Me.BtnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEasy.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEasy.ForeColor = System.Drawing.Color.ForestGreen
        Me.BtnEasy.Location = New System.Drawing.Point(111, 135)
        Me.BtnEasy.Name = "BtnEasy"
        Me.BtnEasy.Size = New System.Drawing.Size(225, 100)
        Me.BtnEasy.TabIndex = 2
        Me.BtnEasy.TabStop = False
        Me.BtnEasy.Text = "Easy"
        Me.BtnEasy.UseVisualStyleBackColor = False

        '
        'TxtWordMem
        '
        Me.TxtWordMem.AutoEllipsis = True
        Me.TxtWordMem.BackColor = System.Drawing.Color.Transparent
        Me.TxtWordMem.Font = New System.Drawing.Font("Comic Sans MS", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordMem.Location = New System.Drawing.Point(65, 33)
        Me.TxtWordMem.Name = "TxtWordMem"
        Me.TxtWordMem.Size = New System.Drawing.Size(347, 65)
        Me.TxtWordMem.TabIndex = 0
        Me.TxtWordMem.Text = "Word Memory"
        Me.TxtWordMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnMed
        '
        Me.BtnMed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMed.FlatAppearance.BorderSize = 0
        Me.BtnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMed.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMed.ForeColor = System.Drawing.Color.DarkOrange
        Me.BtnMed.Location = New System.Drawing.Point(448, 135)
        Me.BtnMed.Name = "BtnMed"
        Me.BtnMed.Size = New System.Drawing.Size(225, 100)
        Me.BtnMed.TabIndex = 3
        Me.BtnMed.TabStop = False
        Me.BtnMed.Text = "Medium"
        Me.BtnMed.UseVisualStyleBackColor = False
        '
        'BtnHard
        '
        Me.BtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnHard.FlatAppearance.BorderSize = 0
        Me.BtnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHard.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHard.ForeColor = System.Drawing.Color.Red
        Me.BtnHard.Location = New System.Drawing.Point(111, 270)
        Me.BtnHard.Name = "BtnHard"
        Me.BtnHard.Size = New System.Drawing.Size(225, 100)
        Me.BtnHard.TabIndex = 4
        Me.BtnHard.TabStop = False
        Me.BtnHard.Text = "Hard"
        Me.BtnHard.UseVisualStyleBackColor = False
        '
        'TxtDiff
        '
        Me.TxtDiff.AutoEllipsis = True
        Me.TxtDiff.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiff.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiff.Location = New System.Drawing.Point(469, 43)
        Me.TxtDiff.Name = "TxtDiff"
        Me.TxtDiff.Size = New System.Drawing.Size(300, 30)
        Me.TxtDiff.TabIndex = 5
        Me.TxtDiff.Text = "Select Difficulty"
        Me.TxtDiff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.Color.Transparent
        Me.BtnReturn.BackgroundImage = Global.BoggleGame.My.Resources.Resources.backlighta
        Me.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReturn.FlatAppearance.BorderSize = 0
        Me.BtnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturn.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReturn.Location = New System.Drawing.Point(17, 47)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(40, 40)
        Me.BtnReturn.TabIndex = 0
        Me.BtnReturn.TabStop = False
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'BtnCustom
        '
        Me.BtnCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCustom.FlatAppearance.BorderSize = 0
        Me.BtnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustom.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustom.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnCustom.Location = New System.Drawing.Point(448, 270)
        Me.BtnCustom.Name = "BtnCustom"
        Me.BtnCustom.Size = New System.Drawing.Size(225, 100)
        Me.BtnCustom.TabIndex = 7
        Me.BtnCustom.TabStop = False
        Me.BtnCustom.Text = "Custom"
        Me.BtnCustom.UseVisualStyleBackColor = False
        '
        'BtnDesc
        '
        Me.BtnDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDesc.FlatAppearance.BorderSize = 0
        Me.BtnDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesc.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesc.Location = New System.Drawing.Point(34, 417)
        Me.BtnDesc.Name = "BtnDesc"
        Me.BtnDesc.Size = New System.Drawing.Size(130, 30)
        Me.BtnDesc.TabIndex = 0
        Me.BtnDesc.TabStop = False
        Me.BtnDesc.Text = "How to Play"
        Me.BtnDesc.UseVisualStyleBackColor = True
        '
        'TxtFlavour
        '
        Me.TxtFlavour.AutoEllipsis = True
        Me.TxtFlavour.BackColor = System.Drawing.Color.Transparent
        Me.TxtFlavour.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlavour.Location = New System.Drawing.Point(275, 417)
        Me.TxtFlavour.Name = "TxtFlavour"
        Me.TxtFlavour.Size = New System.Drawing.Size(500, 30)
        Me.TxtFlavour.TabIndex = 9
        Me.TxtFlavour.Text = "Handy tip go here"
        Me.TxtFlavour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WordDifficultySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgmainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.TxtFlavour)
        Me.Controls.Add(Me.BtnDesc)
        Me.Controls.Add(Me.BtnCustom)
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.TxtDiff)
        Me.Controls.Add(Me.BtnHard)
        Me.Controls.Add(Me.BtnMed)
        Me.Controls.Add(Me.BtnEasy)
        Me.Controls.Add(Me.TxtWordMem)
        Me.Name = "WordDifficultySelect"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtWordMem As Label
    Friend WithEvents BtnMed As Button
    Friend WithEvents BtnHard As Button
    Friend WithEvents TxtDiff As Label
    Friend WithEvents BtnReturn As Button
    Friend WithEvents BtnCustom As Button
    Friend WithEvents BtnDesc As Button
    Friend WithEvents TxtFlavour As Label
    Friend WithEvents BtnEasy As Button
End Class
