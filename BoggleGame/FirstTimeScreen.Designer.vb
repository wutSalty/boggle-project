<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FirstTimeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstTimeScreen))
        Me.TxtWelcome = New System.Windows.Forms.Label()
        Me.TxtExplain = New System.Windows.Forms.Label()
        Me.BtnToTitle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtWelcome
        '
        Me.TxtWelcome.BackColor = System.Drawing.Color.Transparent
        Me.TxtWelcome.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWelcome.Location = New System.Drawing.Point(15, 43)
        Me.TxtWelcome.Name = "TxtWelcome"
        Me.TxtWelcome.Size = New System.Drawing.Size(500, 40)
        Me.TxtWelcome.TabIndex = 0
        Me.TxtWelcome.Text = "Welcome, "
        '
        'TxtExplain
        '
        Me.TxtExplain.AutoEllipsis = True
        Me.TxtExplain.BackColor = System.Drawing.Color.Transparent
        Me.TxtExplain.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExplain.Location = New System.Drawing.Point(20, 100)
        Me.TxtExplain.Name = "TxtExplain"
        Me.TxtExplain.Size = New System.Drawing.Size(744, 270)
        Me.TxtExplain.TabIndex = 1
        Me.TxtExplain.Text = resources.GetString("TxtExplain.Text")
        '
        'BtnToTitle
        '
        Me.BtnToTitle.BackColor = System.Drawing.Color.Transparent
        Me.BtnToTitle.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnToTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnToTitle.FlatAppearance.BorderSize = 0
        Me.BtnToTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnToTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnToTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnToTitle.Font = New System.Drawing.Font("Comic Sans MS", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnToTitle.Location = New System.Drawing.Point(663, 348)
        Me.BtnToTitle.Name = "BtnToTitle"
        Me.BtnToTitle.Size = New System.Drawing.Size(105, 105)
        Me.BtnToTitle.TabIndex = 0
        Me.BtnToTitle.TabStop = False
        Me.BtnToTitle.Text = "Alright! Let's go!"
        Me.BtnToTitle.UseVisualStyleBackColor = False
        '
        'FirstTimeScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.firsttime
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BtnToTitle)
        Me.Controls.Add(Me.TxtExplain)
        Me.Controls.Add(Me.TxtWelcome)
        Me.Name = "FirstTimeScreen"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtWelcome As Label
    Friend WithEvents TxtExplain As Label
    Friend WithEvents BtnToTitle As Button
End Class
