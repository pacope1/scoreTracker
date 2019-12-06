<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamCreation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamCreation))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.info1 = New System.Windows.Forms.Label()
        Me.numBox = New System.Windows.Forms.TextBox()
        Me.GameTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!)
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(115, 50)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(653, 83)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Score Tracker"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'info1
        '
        Me.info1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info1.BackColor = System.Drawing.Color.Transparent
        Me.info1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info1.ForeColor = System.Drawing.Color.White
        Me.info1.Location = New System.Drawing.Point(12, 150)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(858, 101)
        Me.info1.TabIndex = 1
        Me.info1.Text = "Welcome to Score Tracker, your one stop scoring application for all things soccer" &
    ". To begin, please enter the number of players on your team in the field below a" &
    "nd click Game Time!"
        Me.info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numBox
        '
        Me.numBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numBox.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBox.Location = New System.Drawing.Point(216, 328)
        Me.numBox.Name = "numBox"
        Me.numBox.Size = New System.Drawing.Size(450, 60)
        Me.numBox.TabIndex = 2
        Me.numBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GameTime
        '
        Me.GameTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GameTime.BackColor = System.Drawing.Color.Transparent
        Me.GameTime.BackgroundImage = CType(resources.GetObject("GameTime.BackgroundImage"), System.Drawing.Image)
        Me.GameTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GameTime.FlatAppearance.BorderSize = 0
        Me.GameTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.GameTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.GameTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameTime.Location = New System.Drawing.Point(241, 465)
        Me.GameTime.Name = "GameTime"
        Me.GameTime.Size = New System.Drawing.Size(400, 175)
        Me.GameTime.TabIndex = 3
        Me.GameTime.UseVisualStyleBackColor = False
        '
        'TeamCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(882, 703)
        Me.Controls.Add(Me.GameTime)
        Me.Controls.Add(Me.numBox)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.titleLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeamCreation"
        Me.Text = "ScoreTracker - Team Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents info1 As Label
    Friend WithEvents numBox As TextBox
    Friend WithEvents GameTime As Button
End Class
