<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title_Screen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtTitleGame = New System.Windows.Forms.Label()
        Me.BtnStartApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTitleGame
        '
        Me.txtTitleGame.AutoSize = True
        Me.txtTitleGame.BackColor = System.Drawing.Color.Transparent
        Me.txtTitleGame.Font = New System.Drawing.Font("Comic Sans MS", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleGame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTitleGame.Location = New System.Drawing.Point(5, 15)
        Me.txtTitleGame.Name = "txtTitleGame"
        Me.txtTitleGame.Size = New System.Drawing.Size(349, 135)
        Me.txtTitleGame.TabIndex = 0
        Me.txtTitleGame.Text = "Boggle"
        '
        'BtnStartApp
        '
        Me.BtnStartApp.BackColor = System.Drawing.Color.Transparent
        Me.BtnStartApp.BackgroundImage = Global.BoggleGame.My.Resources.Resources.baselighta
        Me.BtnStartApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnStartApp.FlatAppearance.BorderSize = 0
        Me.BtnStartApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnStartApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnStartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStartApp.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStartApp.Location = New System.Drawing.Point(626, 303)
        Me.BtnStartApp.Name = "BtnStartApp"
        Me.BtnStartApp.Size = New System.Drawing.Size(150, 150)
        Me.BtnStartApp.TabIndex = 2
        Me.BtnStartApp.TabStop = False
        Me.BtnStartApp.Text = "START!"
        Me.BtnStartApp.UseVisualStyleBackColor = False
        '
        'Title_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.titlescreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.BtnStartApp)
        Me.Controls.Add(Me.txtTitleGame)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Title_Screen"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitleGame As Label
    Friend WithEvents BtnStartApp As Button
End Class
