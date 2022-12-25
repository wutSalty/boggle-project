<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImageMatchGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageMatchGame))
        Me.TxtOops = New System.Windows.Forms.Label()
        Me.TxtUhOh = New System.Windows.Forms.Label()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtOops
        '
        Me.TxtOops.AutoEllipsis = True
        Me.TxtOops.BackColor = System.Drawing.Color.Transparent
        Me.TxtOops.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOops.Location = New System.Drawing.Point(10, 116)
        Me.TxtOops.Name = "TxtOops"
        Me.TxtOops.Size = New System.Drawing.Size(764, 287)
        Me.TxtOops.TabIndex = 0
        Me.TxtOops.Text = resources.GetString("TxtOops.Text")
        '
        'TxtUhOh
        '
        Me.TxtUhOh.AutoSize = True
        Me.TxtUhOh.BackColor = System.Drawing.Color.Transparent
        Me.TxtUhOh.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUhOh.Location = New System.Drawing.Point(18, 50)
        Me.TxtUhOh.Name = "TxtUhOh"
        Me.TxtUhOh.Size = New System.Drawing.Size(91, 38)
        Me.TxtUhOh.TabIndex = 1
        Me.TxtUhOh.Text = "Uh oh"
        '
        'BtnRestart
        '
        Me.BtnRestart.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart.Location = New System.Drawing.Point(581, 421)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(130, 30)
        Me.BtnRestart.TabIndex = 2
        Me.BtnRestart.Text = "Restart Program"
        Me.BtnRestart.UseVisualStyleBackColor = True
        '
        'ImageMatchGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoggleGame.My.Resources.Resources.wordbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.TxtUhOh)
        Me.Controls.Add(Me.TxtOops)
        Me.Name = "ImageMatchGame"
        Me.Size = New System.Drawing.Size(784, 461)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtOops As Label
    Friend WithEvents TxtUhOh As Label
    Friend WithEvents BtnRestart As Button
End Class
