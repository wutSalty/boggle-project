<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsForm
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
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtWordEx = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.TxtWordEasy = New System.Windows.Forms.Label()
        Me.TxtWordMed = New System.Windows.Forms.Label()
        Me.TxtWordHard = New System.Windows.Forms.Label()
        Me.TxtImgEx = New System.Windows.Forms.Label()
        Me.TxtImgHard = New System.Windows.Forms.Label()
        Me.TxtImgMed = New System.Windows.Forms.Label()
        Me.TxtImgEasy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(378, 34)
        Me.PanelGrab.TabIndex = 9
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.BtnExit.Location = New System.Drawing.Point(328, 398)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(40, 40)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TxtWordEx
        '
        Me.TxtWordEx.AutoEllipsis = True
        Me.TxtWordEx.BackColor = System.Drawing.Color.Transparent
        Me.TxtWordEx.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordEx.Location = New System.Drawing.Point(40, 95)
        Me.TxtWordEx.Name = "TxtWordEx"
        Me.TxtWordEx.Size = New System.Drawing.Size(300, 60)
        Me.TxtWordEx.TabIndex = 10
        Me.TxtWordEx.Text = "Your best score for Word Memory is..."
        Me.TxtWordEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTitle
        '
        Me.TxtTitle.AutoEllipsis = True
        Me.TxtTitle.BackColor = System.Drawing.Color.Transparent
        Me.TxtTitle.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(115, 40)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(150, 40)
        Me.TxtTitle.TabIndex = 11
        Me.TxtTitle.Text = "Records"
        Me.TxtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtWordEasy
        '
        Me.TxtWordEasy.AutoEllipsis = True
        Me.TxtWordEasy.BackColor = System.Drawing.Color.Transparent
        Me.TxtWordEasy.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordEasy.Location = New System.Drawing.Point(0, 160)
        Me.TxtWordEasy.Name = "TxtWordEasy"
        Me.TxtWordEasy.Size = New System.Drawing.Size(380, 30)
        Me.TxtWordEasy.TabIndex = 12
        Me.TxtWordEasy.Text = "Easy:"
        Me.TxtWordEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtWordMed
        '
        Me.TxtWordMed.AutoEllipsis = True
        Me.TxtWordMed.BackColor = System.Drawing.Color.Transparent
        Me.TxtWordMed.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordMed.Location = New System.Drawing.Point(0, 190)
        Me.TxtWordMed.Name = "TxtWordMed"
        Me.TxtWordMed.Size = New System.Drawing.Size(380, 30)
        Me.TxtWordMed.TabIndex = 13
        Me.TxtWordMed.Text = "Medium:"
        Me.TxtWordMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtWordHard
        '
        Me.TxtWordHard.AutoEllipsis = True
        Me.TxtWordHard.BackColor = System.Drawing.Color.Transparent
        Me.TxtWordHard.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWordHard.Location = New System.Drawing.Point(0, 220)
        Me.TxtWordHard.Name = "TxtWordHard"
        Me.TxtWordHard.Size = New System.Drawing.Size(380, 30)
        Me.TxtWordHard.TabIndex = 14
        Me.TxtWordHard.Text = "Hard:"
        Me.TxtWordHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtImgEx
        '
        Me.TxtImgEx.AutoEllipsis = True
        Me.TxtImgEx.BackColor = System.Drawing.Color.Transparent
        Me.TxtImgEx.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImgEx.Location = New System.Drawing.Point(40, 265)
        Me.TxtImgEx.Name = "TxtImgEx"
        Me.TxtImgEx.Size = New System.Drawing.Size(300, 60)
        Me.TxtImgEx.TabIndex = 15
        Me.TxtImgEx.Text = "Your best time for Image Match is..."
        Me.TxtImgEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtImgHard
        '
        Me.TxtImgHard.AutoEllipsis = True
        Me.TxtImgHard.BackColor = System.Drawing.Color.Transparent
        Me.TxtImgHard.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImgHard.Location = New System.Drawing.Point(0, 390)
        Me.TxtImgHard.Name = "TxtImgHard"
        Me.TxtImgHard.Size = New System.Drawing.Size(380, 30)
        Me.TxtImgHard.TabIndex = 18
        Me.TxtImgHard.Text = "Clothing:"
        Me.TxtImgHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtImgMed
        '
        Me.TxtImgMed.AutoEllipsis = True
        Me.TxtImgMed.BackColor = System.Drawing.Color.Transparent
        Me.TxtImgMed.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImgMed.Location = New System.Drawing.Point(0, 360)
        Me.TxtImgMed.Name = "TxtImgMed"
        Me.TxtImgMed.Size = New System.Drawing.Size(380, 30)
        Me.TxtImgMed.TabIndex = 17
        Me.TxtImgMed.Text = "Sports:"
        Me.TxtImgMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtImgEasy
        '
        Me.TxtImgEasy.AutoEllipsis = True
        Me.TxtImgEasy.BackColor = System.Drawing.Color.Transparent
        Me.TxtImgEasy.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImgEasy.Location = New System.Drawing.Point(0, 330)
        Me.TxtImgEasy.Name = "TxtImgEasy"
        Me.TxtImgEasy.Size = New System.Drawing.Size(380, 30)
        Me.TxtImgEasy.TabIndex = 16
        Me.TxtImgEasy.Text = "Fruit and Veg:"
        Me.TxtImgEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecordsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgresults
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(380, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtImgHard)
        Me.Controls.Add(Me.TxtImgMed)
        Me.Controls.Add(Me.TxtImgEasy)
        Me.Controls.Add(Me.TxtImgEx)
        Me.Controls.Add(Me.TxtWordHard)
        Me.Controls.Add(Me.TxtWordMed)
        Me.Controls.Add(Me.TxtWordEasy)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.TxtWordEx)
        Me.Controls.Add(Me.PanelGrab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecordsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RecordsForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtWordEx As Label
    Friend WithEvents TxtTitle As Label
    Friend WithEvents TxtWordEasy As Label
    Friend WithEvents TxtWordMed As Label
    Friend WithEvents TxtWordHard As Label
    Friend WithEvents TxtImgEx As Label
    Friend WithEvents TxtImgHard As Label
    Friend WithEvents TxtImgMed As Label
    Friend WithEvents TxtImgEasy As Label
End Class
