<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DebugForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DebugForm))
        Me.TxtFirstTimeStat = New System.Windows.Forms.Label()
        Me.TxtSkipTitleStat = New System.Windows.Forms.Label()
        Me.TxtImgDiff = New System.Windows.Forms.Label()
        Me.TxtWordDiff = New System.Windows.Forms.Label()
        Me.TxtRegLength = New System.Windows.Forms.Label()
        Me.ListDebug = New System.Windows.Forms.ListBox()
        Me.TxtEasyHigh = New System.Windows.Forms.Label()
        Me.TxtMedHigh = New System.Windows.Forms.Label()
        Me.TxtHardHigh = New System.Windows.Forms.Label()
        Me.TxtImageOK = New System.Windows.Forms.Label()
        Me.TxtCardBack = New System.Windows.Forms.Label()
        Me.TxtImageA = New System.Windows.Forms.Label()
        Me.TxtImageB = New System.Windows.Forms.Label()
        Me.TxtImageC = New System.Windows.Forms.Label()
        Me.TxtSpcLength = New System.Windows.Forms.Label()
        Me.TxtShowDeck = New System.Windows.Forms.Label()
        Me.TxtTheme = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtFirstTimeStat
        '
        Me.TxtFirstTimeStat.AutoSize = True
        Me.TxtFirstTimeStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstTimeStat.Location = New System.Drawing.Point(10, 10)
        Me.TxtFirstTimeStat.Name = "TxtFirstTimeStat"
        Me.TxtFirstTimeStat.Size = New System.Drawing.Size(70, 16)
        Me.TxtFirstTimeStat.TabIndex = 2
        Me.TxtFirstTimeStat.Text = "FirstTime: "
        '
        'TxtSkipTitleStat
        '
        Me.TxtSkipTitleStat.AutoSize = True
        Me.TxtSkipTitleStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSkipTitleStat.Location = New System.Drawing.Point(240, 10)
        Me.TxtSkipTitleStat.Name = "TxtSkipTitleStat"
        Me.TxtSkipTitleStat.Size = New System.Drawing.Size(67, 16)
        Me.TxtSkipTitleStat.TabIndex = 3
        Me.TxtSkipTitleStat.Text = "SkipTitle: "
        '
        'TxtImgDiff
        '
        Me.TxtImgDiff.AutoSize = True
        Me.TxtImgDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImgDiff.Location = New System.Drawing.Point(240, 90)
        Me.TxtImgDiff.Name = "TxtImgDiff"
        Me.TxtImgDiff.Size = New System.Drawing.Size(104, 16)
        Me.TxtImgDiff.TabIndex = 4
        Me.TxtImgDiff.Text = "Image Difficulty: "
        '
        'TxtWordDiff
        '
        Me.TxtWordDiff.AutoSize = True
        Me.TxtWordDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordDiff.Location = New System.Drawing.Point(10, 90)
        Me.TxtWordDiff.Name = "TxtWordDiff"
        Me.TxtWordDiff.Size = New System.Drawing.Size(99, 16)
        Me.TxtWordDiff.TabIndex = 5
        Me.TxtWordDiff.Text = "Word Difficulty: "
        '
        'TxtRegLength
        '
        Me.TxtRegLength.AutoSize = True
        Me.TxtRegLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRegLength.Location = New System.Drawing.Point(10, 115)
        Me.TxtRegLength.Name = "TxtRegLength"
        Me.TxtRegLength.Size = New System.Drawing.Size(105, 16)
        Me.TxtRegLength.TabIndex = 6
        Me.TxtRegLength.Text = "Reg File Length:"
        '
        'ListDebug
        '
        Me.ListDebug.FormattingEnabled = True
        Me.ListDebug.ItemHeight = 16
        Me.ListDebug.Location = New System.Drawing.Point(422, 10)
        Me.ListDebug.Name = "ListDebug"
        Me.ListDebug.Size = New System.Drawing.Size(150, 276)
        Me.ListDebug.TabIndex = 7
        '
        'TxtEasyHigh
        '
        Me.TxtEasyHigh.AutoSize = True
        Me.TxtEasyHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEasyHigh.Location = New System.Drawing.Point(10, 165)
        Me.TxtEasyHigh.Name = "TxtEasyHigh"
        Me.TxtEasyHigh.Size = New System.Drawing.Size(109, 16)
        Me.TxtEasyHigh.TabIndex = 11
        Me.TxtEasyHigh.Text = "Word Easy High:"
        '
        'TxtMedHigh
        '
        Me.TxtMedHigh.AutoSize = True
        Me.TxtMedHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMedHigh.Location = New System.Drawing.Point(10, 190)
        Me.TxtMedHigh.Name = "TxtMedHigh"
        Me.TxtMedHigh.Size = New System.Drawing.Size(129, 16)
        Me.TxtMedHigh.TabIndex = 12
        Me.TxtMedHigh.Text = "Word Medium High: "
        '
        'TxtHardHigh
        '
        Me.TxtHardHigh.AutoSize = True
        Me.TxtHardHigh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHardHigh.Location = New System.Drawing.Point(10, 215)
        Me.TxtHardHigh.Name = "TxtHardHigh"
        Me.TxtHardHigh.Size = New System.Drawing.Size(111, 16)
        Me.TxtHardHigh.TabIndex = 13
        Me.TxtHardHigh.Text = "Word Hard High: "
        '
        'TxtImageOK
        '
        Me.TxtImageOK.AutoSize = True
        Me.TxtImageOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImageOK.Location = New System.Drawing.Point(240, 140)
        Me.TxtImageOK.Name = "TxtImageOK"
        Me.TxtImageOK.Size = New System.Drawing.Size(125, 16)
        Me.TxtImageOK.TabIndex = 14
        Me.TxtImageOK.Text = "Image Custom OK?:"
        '
        'TxtCardBack
        '
        Me.TxtCardBack.AutoSize = True
        Me.TxtCardBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCardBack.Location = New System.Drawing.Point(240, 115)
        Me.TxtCardBack.Name = "TxtCardBack"
        Me.TxtCardBack.Size = New System.Drawing.Size(87, 16)
        Me.TxtCardBack.TabIndex = 15
        Me.TxtCardBack.Text = "CardBack is: "
        '
        'TxtImageA
        '
        Me.TxtImageA.AutoSize = True
        Me.TxtImageA.Location = New System.Drawing.Point(240, 165)
        Me.TxtImageA.Name = "TxtImageA"
        Me.TxtImageA.Size = New System.Drawing.Size(92, 16)
        Me.TxtImageA.TabIndex = 16
        Me.TxtImageA.Text = "ImageA High: "
        '
        'TxtImageB
        '
        Me.TxtImageB.AutoSize = True
        Me.TxtImageB.Location = New System.Drawing.Point(240, 190)
        Me.TxtImageB.Name = "TxtImageB"
        Me.TxtImageB.Size = New System.Drawing.Size(86, 16)
        Me.TxtImageB.TabIndex = 17
        Me.TxtImageB.Text = "ImageB High"
        '
        'TxtImageC
        '
        Me.TxtImageC.AutoSize = True
        Me.TxtImageC.Location = New System.Drawing.Point(240, 215)
        Me.TxtImageC.Name = "TxtImageC"
        Me.TxtImageC.Size = New System.Drawing.Size(92, 16)
        Me.TxtImageC.TabIndex = 18
        Me.TxtImageC.Text = "ImageC High: "
        '
        'TxtSpcLength
        '
        Me.TxtSpcLength.AutoSize = True
        Me.TxtSpcLength.Location = New System.Drawing.Point(10, 140)
        Me.TxtSpcLength.Name = "TxtSpcLength"
        Me.TxtSpcLength.Size = New System.Drawing.Size(106, 16)
        Me.TxtSpcLength.TabIndex = 19
        Me.TxtSpcLength.Text = "Spc File Length: "
        '
        'TxtShowDeck
        '
        Me.TxtShowDeck.AutoSize = True
        Me.TxtShowDeck.Location = New System.Drawing.Point(240, 35)
        Me.TxtShowDeck.Name = "TxtShowDeck"
        Me.TxtShowDeck.Size = New System.Drawing.Size(114, 16)
        Me.TxtShowDeck.TabIndex = 20
        Me.TxtShowDeck.Text = "Show Card Deck: "
        '
        'TxtTheme
        '
        Me.TxtTheme.AutoSize = True
        Me.TxtTheme.Location = New System.Drawing.Point(10, 35)
        Me.TxtTheme.Name = "TxtTheme"
        Me.TxtTheme.Size = New System.Drawing.Size(54, 16)
        Me.TxtTheme.TabIndex = 21
        Me.TxtTheme.Text = "Theme:"
        '
        'DebugForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(584, 311)
        Me.Controls.Add(Me.TxtTheme)
        Me.Controls.Add(Me.TxtShowDeck)
        Me.Controls.Add(Me.TxtSpcLength)
        Me.Controls.Add(Me.TxtImageC)
        Me.Controls.Add(Me.TxtImageB)
        Me.Controls.Add(Me.TxtImageA)
        Me.Controls.Add(Me.TxtCardBack)
        Me.Controls.Add(Me.TxtImageOK)
        Me.Controls.Add(Me.TxtHardHigh)
        Me.Controls.Add(Me.TxtMedHigh)
        Me.Controls.Add(Me.TxtEasyHigh)
        Me.Controls.Add(Me.ListDebug)
        Me.Controls.Add(Me.TxtRegLength)
        Me.Controls.Add(Me.TxtWordDiff)
        Me.Controls.Add(Me.TxtImgDiff)
        Me.Controls.Add(Me.TxtSkipTitleStat)
        Me.Controls.Add(Me.TxtFirstTimeStat)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DebugForm"
        Me.Text = "DebugForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFirstTimeStat As Label
    Friend WithEvents TxtSkipTitleStat As Label
    Friend WithEvents TxtImgDiff As Label
    Friend WithEvents TxtWordDiff As Label
    Friend WithEvents TxtRegLength As Label
    Friend WithEvents ListDebug As ListBox
    Friend WithEvents TxtEasyHigh As Label
    Friend WithEvents TxtMedHigh As Label
    Friend WithEvents TxtHardHigh As Label
    Friend WithEvents TxtImageOK As Label
    Friend WithEvents TxtCardBack As Label
    Friend WithEvents TxtImageA As Label
    Friend WithEvents TxtImageB As Label
    Friend WithEvents TxtImageC As Label
    Friend WithEvents TxtSpcLength As Label
    Friend WithEvents TxtShowDeck As Label
    Friend WithEvents TxtTheme As Label
End Class
