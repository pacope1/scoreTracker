<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerNames
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerNames))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.info2 = New System.Windows.Forms.Label()
        Me.SubNames = New System.Windows.Forms.Button()
        Me.FinishedButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("SF Sports Night", 42.0!)
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(115, 50)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(653, 60)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Score Tracker"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'info2
        '
        Me.info2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info2.BackColor = System.Drawing.Color.Transparent
        Me.info2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info2.ForeColor = System.Drawing.Color.White
        Me.info2.Location = New System.Drawing.Point(12, 150)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(858, 101)
        Me.info2.TabIndex = 2
        Me.info2.Text = "Great! Now, let's name each of the players on your team. Click Submit Names to be" &
    "gin the process. Click Finished when you have assigned each player a name."
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubNames
        '
        Me.SubNames.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SubNames.BackColor = System.Drawing.Color.Transparent
        Me.SubNames.BackgroundImage = CType(resources.GetObject("SubNames.BackgroundImage"), System.Drawing.Image)
        Me.SubNames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubNames.FlatAppearance.BorderSize = 0
        Me.SubNames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SubNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SubNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubNames.Location = New System.Drawing.Point(266, 288)
        Me.SubNames.Name = "SubNames"
        Me.SubNames.Size = New System.Drawing.Size(350, 175)
        Me.SubNames.TabIndex = 4
        Me.SubNames.UseVisualStyleBackColor = False
        '
        'FinishedButton
        '
        Me.FinishedButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FinishedButton.BackColor = System.Drawing.Color.Transparent
        Me.FinishedButton.BackgroundImage = CType(resources.GetObject("FinishedButton.BackgroundImage"), System.Drawing.Image)
        Me.FinishedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FinishedButton.FlatAppearance.BorderSize = 0
        Me.FinishedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.FinishedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.FinishedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinishedButton.Location = New System.Drawing.Point(266, 500)
        Me.FinishedButton.Name = "FinishedButton"
        Me.FinishedButton.Size = New System.Drawing.Size(350, 175)
        Me.FinishedButton.TabIndex = 5
        Me.FinishedButton.UseVisualStyleBackColor = False
        '
        'PlayerNames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 703)
        Me.Controls.Add(Me.FinishedButton)
        Me.Controls.Add(Me.SubNames)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.titleLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PlayerNames"
        Me.Text = "ScoreTracker - Player Names"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents info2 As Label
    Friend WithEvents SubNames As Button
    Friend WithEvents FinishedButton As Button
End Class
