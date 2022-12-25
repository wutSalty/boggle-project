<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsTheme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsTheme))
        Me.TxtPreview = New System.Windows.Forms.Label()
        Me.TxtFlavour = New System.Windows.Forms.Label()
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnMini = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.RadioTheme1 = New System.Windows.Forms.RadioButton()
        Me.RadioTheme2 = New System.Windows.Forms.RadioButton()
        Me.RadioTheme3 = New System.Windows.Forms.RadioButton()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.TxtA = New System.Windows.Forms.Label()
        Me.TxtB = New System.Windows.Forms.Label()
        Me.TxtLight = New System.Windows.Forms.Label()
        Me.TxtDark = New System.Windows.Forms.Label()
        Me.PanelGrab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPreview
        '
        Me.TxtPreview.AutoSize = True
        Me.TxtPreview.BackColor = System.Drawing.Color.Transparent
        Me.TxtPreview.Font = New System.Drawing.Font("Comic Sans MS", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPreview.Location = New System.Drawing.Point(65, 36)
        Me.TxtPreview.Name = "TxtPreview"
        Me.TxtPreview.Size = New System.Drawing.Size(366, 62)
        Me.TxtPreview.TabIndex = 0
        Me.TxtPreview.Text = "Preview Themes"
        '
        'TxtFlavour
        '
        Me.TxtFlavour.BackColor = System.Drawing.Color.Transparent
        Me.TxtFlavour.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFlavour.Location = New System.Drawing.Point(437, 43)
        Me.TxtFlavour.Name = "TxtFlavour"
        Me.TxtFlavour.Size = New System.Drawing.Size(335, 29)
        Me.TxtFlavour.TabIndex = 0
        Me.TxtFlavour.Text = "Preview the available themes"
        Me.TxtFlavour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Controls.Add(Me.BtnMini)
        Me.PanelGrab.Controls.Add(Me.BtnExit)
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(782, 34)
        Me.PanelGrab.TabIndex = 2
        '
        'BtnMini
        '
        Me.BtnMini.FlatAppearance.BorderSize = 0
        Me.BtnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMini.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMini.Location = New System.Drawing.Point(714, 0)
        Me.BtnMini.Name = "BtnMini"
        Me.BtnMini.Size = New System.Drawing.Size(34, 34)
        Me.BtnMini.TabIndex = 0
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
        Me.BtnExit.Location = New System.Drawing.Point(748, 0)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(34, 34)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.TabStop = False
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'RadioTheme1
        '
        Me.RadioTheme1.AutoSize = True
        Me.RadioTheme1.BackColor = System.Drawing.Color.Transparent
        Me.RadioTheme1.Location = New System.Drawing.Point(70, 168)
        Me.RadioTheme1.Name = "RadioTheme1"
        Me.RadioTheme1.Size = New System.Drawing.Size(217, 27)
        Me.RadioTheme1.TabIndex = 0
        Me.RadioTheme1.Text = "Standard Green (Default)"
        Me.RadioTheme1.UseVisualStyleBackColor = False
        '
        'RadioTheme2
        '
        Me.RadioTheme2.AutoSize = True
        Me.RadioTheme2.BackColor = System.Drawing.Color.Transparent
        Me.RadioTheme2.Location = New System.Drawing.Point(70, 201)
        Me.RadioTheme2.Name = "RadioTheme2"
        Me.RadioTheme2.Size = New System.Drawing.Size(135, 27)
        Me.RadioTheme2.TabIndex = 0
        Me.RadioTheme2.Text = "Alternate Blue"
        Me.RadioTheme2.UseVisualStyleBackColor = False
        '
        'RadioTheme3
        '
        Me.RadioTheme3.AutoSize = True
        Me.RadioTheme3.BackColor = System.Drawing.Color.Transparent
        Me.RadioTheme3.Location = New System.Drawing.Point(467, 168)
        Me.RadioTheme3.Name = "RadioTheme3"
        Me.RadioTheme3.Size = New System.Drawing.Size(113, 27)
        Me.RadioTheme3.TabIndex = 0
        Me.RadioTheme3.Text = "After Dark"
        Me.RadioTheme3.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Location = New System.Drawing.Point(622, 419)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(150, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.TabStop = False
        Me.BtnSave.Text = "Save and Return"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.BackgroundImage = Global.BoggleGame.My.Resources.Resources.backlighta
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(17, 47)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(40, 40)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'TxtA
        '
        Me.TxtA.AutoEllipsis = True
        Me.TxtA.BackColor = System.Drawing.Color.Transparent
        Me.TxtA.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.TxtA.Location = New System.Drawing.Point(55, 135)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(130, 30)
        Me.TxtA.TabIndex = 8
        Me.TxtA.Text = "Light Themes"
        '
        'TxtB
        '
        Me.TxtB.AutoEllipsis = True
        Me.TxtB.BackColor = System.Drawing.Color.Transparent
        Me.TxtB.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.TxtB.Location = New System.Drawing.Point(447, 135)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(130, 30)
        Me.TxtB.TabIndex = 0
        Me.TxtB.Text = "Dark Themes"
        '
        'TxtLight
        '
        Me.TxtLight.AutoEllipsis = True
        Me.TxtLight.BackColor = System.Drawing.Color.Transparent
        Me.TxtLight.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.TxtLight.Location = New System.Drawing.Point(55, 250)
        Me.TxtLight.Name = "TxtLight"
        Me.TxtLight.Size = New System.Drawing.Size(330, 130)
        Me.TxtLight.TabIndex = 0
        Me.TxtLight.Text = "Light themes offer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Dark text on a bright background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-A vibrant user interface" &
    " experience" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Unique theming and colours"
        '
        'TxtDark
        '
        Me.TxtDark.AutoEllipsis = True
        Me.TxtDark.BackColor = System.Drawing.Color.Transparent
        Me.TxtDark.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.TxtDark.Location = New System.Drawing.Point(452, 250)
        Me.TxtDark.Name = "TxtDark"
        Me.TxtDark.Size = New System.Drawing.Size(330, 130)
        Me.TxtDark.TabIndex = 0
        Me.TxtDark.Text = "Dark themes offer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-White text on a dark background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-A user interface easier on" &
    " the eyes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-Perfect for late night hermit crabs"
        '
        'SettingsTheme
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgmainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TxtFlavour)
        Me.Controls.Add(Me.TxtDark)
        Me.Controls.Add(Me.TxtLight)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.RadioTheme3)
        Me.Controls.Add(Me.RadioTheme2)
        Me.Controls.Add(Me.RadioTheme1)
        Me.Controls.Add(Me.PanelGrab)
        Me.Controls.Add(Me.TxtPreview)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsTheme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Boggle - Theme Settings"
        Me.TransparencyKey = System.Drawing.Color.Purple
        Me.PanelGrab.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPreview As Label
    Friend WithEvents TxtFlavour As Label
    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnMini As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents RadioTheme1 As RadioButton
    Friend WithEvents RadioTheme2 As RadioButton
    Friend WithEvents RadioTheme3 As RadioButton
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents TxtA As Label
    Friend WithEvents TxtB As Label
    Friend WithEvents TxtLight As Label
    Friend WithEvents TxtDark As Label
End Class
