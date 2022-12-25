<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HowToImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HowToImage))
        Me.TxtHowImage = New System.Windows.Forms.Label()
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TxtCaption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtHowImage
        '
        Me.TxtHowImage.AutoEllipsis = True
        Me.TxtHowImage.BackColor = System.Drawing.Color.Transparent
        Me.TxtHowImage.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.TxtHowImage.Location = New System.Drawing.Point(12, 111)
        Me.TxtHowImage.Name = "TxtHowImage"
        Me.TxtHowImage.Size = New System.Drawing.Size(576, 380)
        Me.TxtHowImage.TabIndex = 0
        Me.TxtHowImage.Text = resources.GetString("TxtHowImage.Text")
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(598, 34)
        Me.PanelGrab.TabIndex = 2
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.Transparent
        Me.BtnOK.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnOK.FlatAppearance.BorderSize = 0
        Me.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(550, 40)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(40, 40)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "X"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'TxtCaption
        '
        Me.TxtCaption.AutoSize = True
        Me.TxtCaption.BackColor = System.Drawing.Color.Transparent
        Me.TxtCaption.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCaption.Location = New System.Drawing.Point(12, 40)
        Me.TxtCaption.Name = "TxtCaption"
        Me.TxtCaption.Size = New System.Drawing.Size(306, 40)
        Me.TxtCaption.TabIndex = 4
        Me.TxtCaption.Text = "Changing card decks?"
        '
        'HowToImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.howtos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.TxtCaption)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.PanelGrab)
        Me.Controls.Add(Me.TxtHowImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HowToImage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "HowToImage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtHowImage As Label
    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnOK As Button
    Friend WithEvents TxtCaption As Label
End Class
