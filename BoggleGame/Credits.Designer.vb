<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credits))
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtTitle = New System.Windows.Forms.Label()
        Me.TxtCredits = New System.Windows.Forms.Label()
        Me.GifBox = New System.Windows.Forms.PictureBox()
        Me.TxtAttributes = New System.Windows.Forms.Label()
        CType(Me.GifBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(798, 34)
        Me.PanelGrab.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(748, 41)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtTitle
        '
        Me.TxtTitle.AutoSize = True
        Me.TxtTitle.BackColor = System.Drawing.Color.Transparent
        Me.TxtTitle.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(12, 38)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(110, 38)
        Me.TxtTitle.TabIndex = 4
        Me.TxtTitle.Text = "Credits"
        '
        'TxtCredits
        '
        Me.TxtCredits.AutoEllipsis = True
        Me.TxtCredits.BackColor = System.Drawing.Color.Transparent
        Me.TxtCredits.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCredits.Location = New System.Drawing.Point(20, 80)
        Me.TxtCredits.Name = "TxtCredits"
        Me.TxtCredits.Size = New System.Drawing.Size(450, 298)
        Me.TxtCredits.TabIndex = 5
        Me.TxtCredits.Text = resources.GetString("TxtCredits.Text")
        '
        'GifBox
        '
        Me.GifBox.BackColor = System.Drawing.Color.Transparent
        Me.GifBox.Image = Global.BoggleGame.My.Resources.Resources.AppIcon1
        Me.GifBox.Location = New System.Drawing.Point(738, 328)
        Me.GifBox.Name = "GifBox"
        Me.GifBox.Size = New System.Drawing.Size(50, 50)
        Me.GifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GifBox.TabIndex = 6
        Me.GifBox.TabStop = False
        '
        'TxtAttributes
        '
        Me.TxtAttributes.BackColor = System.Drawing.Color.Transparent
        Me.TxtAttributes.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAttributes.Location = New System.Drawing.Point(484, 83)
        Me.TxtAttributes.Name = "TxtAttributes"
        Me.TxtAttributes.Size = New System.Drawing.Size(304, 295)
        Me.TxtAttributes.TabIndex = 7
        Me.TxtAttributes.Text = resources.GetString("TxtAttributes.Text")
        '
        'Credits
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgcredits
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 390)
        Me.Controls.Add(Me.GifBox)
        Me.Controls.Add(Me.TxtCredits)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PanelGrab)
        Me.Controls.Add(Me.TxtAttributes)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Credits"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Credits"
        CType(Me.GifBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtTitle As Label
    Friend WithEvents TxtCredits As Label
    Friend WithEvents GifBox As PictureBox
    Friend WithEvents TxtAttributes As Label
End Class
