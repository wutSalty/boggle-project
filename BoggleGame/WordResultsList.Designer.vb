<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WordResultsList
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
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.ListResults = New System.Windows.Forms.ListView()
        Me.ListPassed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListUser = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtOverrideHeader1 = New System.Windows.Forms.Label()
        Me.TxtOverrideHeader2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(348, 34)
        Me.PanelGrab.TabIndex = 10
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
        Me.BtnExit.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(303, 40)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(40, 40)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'TxtTitle
        '
        Me.TxtTitle.AutoEllipsis = True
        Me.TxtTitle.BackColor = System.Drawing.Color.Transparent
        Me.TxtTitle.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(5, 40)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(300, 40)
        Me.TxtTitle.TabIndex = 13
        Me.TxtTitle.Text = "Here's how you went!"
        Me.TxtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListResults
        '
        Me.ListResults.BackColor = System.Drawing.SystemColors.Window
        Me.ListResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListResults.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ListPassed, Me.ListUser})
        Me.ListResults.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListResults.FullRowSelect = True
        Me.ListResults.GridLines = True
        Me.ListResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListResults.HideSelection = False
        Me.ListResults.Location = New System.Drawing.Point(10, 90)
        Me.ListResults.MultiSelect = False
        Me.ListResults.Name = "ListResults"
        Me.ListResults.ShowGroups = False
        Me.ListResults.Size = New System.Drawing.Size(330, 400)
        Me.ListResults.TabIndex = 14
        Me.ListResults.TabStop = False
        Me.ListResults.UseCompatibleStateImageBehavior = False
        Me.ListResults.View = System.Windows.Forms.View.Details
        '
        'ListPassed
        '
        Me.ListPassed.Text = "The Word"
        Me.ListPassed.Width = 163
        '
        'ListUser
        '
        Me.ListUser.Text = "Your Answer"
        Me.ListUser.Width = 163
        '
        'TxtOverrideHeader1
        '
        Me.TxtOverrideHeader1.AutoEllipsis = True
        Me.TxtOverrideHeader1.BackColor = System.Drawing.Color.White
        Me.TxtOverrideHeader1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOverrideHeader1.Location = New System.Drawing.Point(11, 91)
        Me.TxtOverrideHeader1.Name = "TxtOverrideHeader1"
        Me.TxtOverrideHeader1.Size = New System.Drawing.Size(328, 29)
        Me.TxtOverrideHeader1.TabIndex = 15
        Me.TxtOverrideHeader1.Text = "The Word"
        '
        'TxtOverrideHeader2
        '
        Me.TxtOverrideHeader2.AutoEllipsis = True
        Me.TxtOverrideHeader2.BackColor = System.Drawing.Color.White
        Me.TxtOverrideHeader2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOverrideHeader2.Location = New System.Drawing.Point(174, 91)
        Me.TxtOverrideHeader2.Name = "TxtOverrideHeader2"
        Me.TxtOverrideHeader2.Size = New System.Drawing.Size(144, 26)
        Me.TxtOverrideHeader2.TabIndex = 16
        Me.TxtOverrideHeader2.Text = "Your Answer"
        '
        'WordResultsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.wordresultslist
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 500)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtOverrideHeader2)
        Me.Controls.Add(Me.TxtOverrideHeader1)
        Me.Controls.Add(Me.ListResults)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.PanelGrab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WordResultsList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WordResultsList"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents TxtTitle As Label
    Friend WithEvents ListResults As ListView
    Friend WithEvents ListPassed As ColumnHeader
    Friend WithEvents ListUser As ColumnHeader
    Friend WithEvents BtnExit As Button
    Friend WithEvents TxtOverrideHeader1 As Label
    Friend WithEvents TxtOverrideHeader2 As Label
End Class
