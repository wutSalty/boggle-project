<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordCustomForm
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
        Me.TxtDiff = New System.Windows.Forms.Label()
        Me.TxtPrepTime = New System.Windows.Forms.Label()
        Me.TxtGameTime = New System.Windows.Forms.Label()
        Me.BoxDiff = New System.Windows.Forms.TextBox()
        Me.BoxPrepTime = New System.Windows.Forms.TextBox()
        Me.BoxGameTime = New System.Windows.Forms.TextBox()
        Me.TxtGameName = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.PanelGrab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDiff
        '
        Me.TxtDiff.AutoEllipsis = True
        Me.TxtDiff.BackColor = System.Drawing.Color.Transparent
        Me.TxtDiff.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiff.Location = New System.Drawing.Point(0, 110)
        Me.TxtDiff.Name = "TxtDiff"
        Me.TxtDiff.Size = New System.Drawing.Size(350, 60)
        Me.TxtDiff.TabIndex = 0
        Me.TxtDiff.Text = "How much of a gap should be set for the currently shown word"
        Me.TxtDiff.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtPrepTime
        '
        Me.TxtPrepTime.AutoEllipsis = True
        Me.TxtPrepTime.BackColor = System.Drawing.Color.Transparent
        Me.TxtPrepTime.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrepTime.Location = New System.Drawing.Point(0, 220)
        Me.TxtPrepTime.Name = "TxtPrepTime"
        Me.TxtPrepTime.Size = New System.Drawing.Size(350, 60)
        Me.TxtPrepTime.TabIndex = 1
        Me.TxtPrepTime.Text = "How long should be given to review the beginning words (in seconds)"
        Me.TxtPrepTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtGameTime
        '
        Me.TxtGameTime.AutoEllipsis = True
        Me.TxtGameTime.BackColor = System.Drawing.Color.Transparent
        Me.TxtGameTime.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGameTime.Location = New System.Drawing.Point(0, 330)
        Me.TxtGameTime.Name = "TxtGameTime"
        Me.TxtGameTime.Size = New System.Drawing.Size(350, 60)
        Me.TxtGameTime.TabIndex = 2
        Me.TxtGameTime.Text = "How long should the rest of the game go for (in seconds)"
        Me.TxtGameTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BoxDiff
        '
        Me.BoxDiff.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxDiff.Location = New System.Drawing.Point(125, 170)
        Me.BoxDiff.Name = "BoxDiff"
        Me.BoxDiff.Size = New System.Drawing.Size(100, 34)
        Me.BoxDiff.TabIndex = 3
        Me.BoxDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxPrepTime
        '
        Me.BoxPrepTime.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxPrepTime.Location = New System.Drawing.Point(125, 280)
        Me.BoxPrepTime.Name = "BoxPrepTime"
        Me.BoxPrepTime.ShortcutsEnabled = False
        Me.BoxPrepTime.Size = New System.Drawing.Size(100, 34)
        Me.BoxPrepTime.TabIndex = 4
        Me.BoxPrepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BoxGameTime
        '
        Me.BoxGameTime.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoxGameTime.Location = New System.Drawing.Point(123, 390)
        Me.BoxGameTime.Name = "BoxGameTime"
        Me.BoxGameTime.Size = New System.Drawing.Size(100, 34)
        Me.BoxGameTime.TabIndex = 5
        Me.BoxGameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtGameName
        '
        Me.TxtGameName.AutoEllipsis = True
        Me.TxtGameName.BackColor = System.Drawing.Color.Transparent
        Me.TxtGameName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGameName.Location = New System.Drawing.Point(0, 35)
        Me.TxtGameName.Name = "TxtGameName"
        Me.TxtGameName.Size = New System.Drawing.Size(350, 60)
        Me.TxtGameName.TabIndex = 6
        Me.TxtGameName.Text = "The Custom Word List will be used for these Custom games!"
        Me.TxtGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.Transparent
        Me.BtnStart.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStart.FlatAppearance.BorderSize = 0
        Me.BtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(150, 438)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(50, 50)
        Me.BtnStart.TabIndex = 7
        Me.BtnStart.TabStop = False
        Me.BtnStart.Text = "OK"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Controls.Add(Me.BtnExit)
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(348, 34)
        Me.PanelGrab.TabIndex = 8
        '
        'BtnExit
        '
        Me.BtnExit.FlatAppearance.BorderSize = 0
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(315, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(34, 34)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'WordCustomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgwordcustom
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 500)
        Me.Controls.Add(Me.PanelGrab)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.TxtGameName)
        Me.Controls.Add(Me.BoxGameTime)
        Me.Controls.Add(Me.BoxPrepTime)
        Me.Controls.Add(Me.BoxDiff)
        Me.Controls.Add(Me.TxtGameTime)
        Me.Controls.Add(Me.TxtPrepTime)
        Me.Controls.Add(Me.TxtDiff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WordCustomForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WordCustomForm"
        Me.PanelGrab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDiff As Label
    Friend WithEvents TxtPrepTime As Label
    Friend WithEvents TxtGameTime As Label
    Friend WithEvents BoxDiff As TextBox
    Friend WithEvents BoxPrepTime As TextBox
    Friend WithEvents BoxGameTime As TextBox
    Friend WithEvents TxtGameName As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnExit As Button
End Class
