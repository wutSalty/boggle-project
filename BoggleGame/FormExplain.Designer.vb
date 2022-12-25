<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExplain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExplain))
        Me.PanelGrab = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtGameExplain = New System.Windows.Forms.Label()
        Me.TxtGameName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PanelGrab
        '
        Me.PanelGrab.BackColor = System.Drawing.Color.Transparent
        Me.PanelGrab.BackgroundImage = Global.BoggleGame.My.Resources.Resources.dragbar
        Me.PanelGrab.Location = New System.Drawing.Point(1, 1)
        Me.PanelGrab.Name = "PanelGrab"
        Me.PanelGrab.Size = New System.Drawing.Size(348, 34)
        Me.PanelGrab.TabIndex = 1
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
        Me.BtnClose.Location = New System.Drawing.Point(300, 448)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(40, 40)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.TabStop = False
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'TxtGameExplain
        '
        Me.TxtGameExplain.AutoEllipsis = True
        Me.TxtGameExplain.BackColor = System.Drawing.Color.Transparent
        Me.TxtGameExplain.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGameExplain.Location = New System.Drawing.Point(10, 115)
        Me.TxtGameExplain.Name = "TxtGameExplain"
        Me.TxtGameExplain.Size = New System.Drawing.Size(330, 342)
        Me.TxtGameExplain.TabIndex = 3
        Me.TxtGameExplain.Text = resources.GetString("TxtGameExplain.Text")
        '
        'TxtGameName
        '
        Me.TxtGameName.BackColor = System.Drawing.Color.Transparent
        Me.TxtGameName.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGameName.Location = New System.Drawing.Point(50, 45)
        Me.TxtGameName.Name = "TxtGameName"
        Me.TxtGameName.Size = New System.Drawing.Size(250, 50)
        Me.TxtGameName.TabIndex = 4
        Me.TxtGameName.Text = "Word Memory"
        Me.TxtGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormExplain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.bgwordcustom
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 500)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtGameName)
        Me.Controls.Add(Me.TxtGameExplain)
        Me.Controls.Add(Me.PanelGrab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormExplain"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormExplain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGrab As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtGameExplain As Label
    Friend WithEvents TxtGameName As Label
End Class
