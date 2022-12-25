<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnMini = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.PanelGrab.SuspendLayout()
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
        Me.PanelGrab.Size = New System.Drawing.Size(782, 34)
        Me.PanelGrab.TabIndex = 0
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgmainmenu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.PanelGrab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boggle"
        Me.TransparencyKey = System.Drawing.Color.Purple
        Me.PanelGrab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnMini As Button
End Class
