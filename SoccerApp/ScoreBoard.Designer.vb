<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreBoard))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.playerNumLbl = New System.Windows.Forms.Label()
        Me.numList = New System.Windows.Forms.ListBox()
        Me.info1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.halfList1 = New System.Windows.Forms.ListBox()
        Me.halfList2 = New System.Windows.Forms.ListBox()
        Me.totalList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubScores = New System.Windows.Forms.Button()
        Me.FinishedButton = New System.Windows.Forms.Button()
        Me.totalH1 = New System.Windows.Forms.Label()
        Me.totalH2 = New System.Windows.Forms.Label()
        Me.final = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("SF Sports Night", 42.0!)
        Me.titleLabel.ForeColor = System.Drawing.Color.Black
        Me.titleLabel.Location = New System.Drawing.Point(190, 50)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(603, 60)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Score Tracker"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'playerNumLbl
        '
        Me.playerNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.playerNumLbl.BackColor = System.Drawing.Color.Transparent
        Me.playerNumLbl.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerNumLbl.Location = New System.Drawing.Point(39, 225)
        Me.playerNumLbl.Name = "playerNumLbl"
        Me.playerNumLbl.Size = New System.Drawing.Size(150, 30)
        Me.playerNumLbl.TabIndex = 2
        Me.playerNumLbl.Text = "Player #"
        Me.playerNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'numList
        '
        Me.numList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numList.FormattingEnabled = True
        Me.numList.ItemHeight = 23
        Me.numList.Location = New System.Drawing.Point(39, 279)
        Me.numList.Name = "numList"
        Me.numList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.numList.Size = New System.Drawing.Size(150, 299)
        Me.numList.TabIndex = 3
        '
        'info1
        '
        Me.info1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.info1.BackColor = System.Drawing.Color.Transparent
        Me.info1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info1.ForeColor = System.Drawing.Color.Black
        Me.info1.Location = New System.Drawing.Point(35, 150)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(913, 34)
        Me.info1.TabIndex = 4
        Me.info1.Text = "Click Submit Scores to calculate and display your team's score."
        Me.info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameList
        '
        Me.nameList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nameList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nameList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameList.FormattingEnabled = True
        Me.nameList.ItemHeight = 23
        Me.nameList.Location = New System.Drawing.Point(216, 279)
        Me.nameList.Name = "nameList"
        Me.nameList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.nameList.Size = New System.Drawing.Size(200, 299)
        Me.nameList.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 30)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "1st Half"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(620, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "2nd Half"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(797, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 30)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'halfList1
        '
        Me.halfList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.halfList1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.halfList1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.halfList1.FormattingEnabled = True
        Me.halfList1.ItemHeight = 23
        Me.halfList1.Location = New System.Drawing.Point(448, 279)
        Me.halfList1.Name = "halfList1"
        Me.halfList1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.halfList1.Size = New System.Drawing.Size(150, 299)
        Me.halfList1.TabIndex = 10
        '
        'halfList2
        '
        Me.halfList2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.halfList2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.halfList2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.halfList2.FormattingEnabled = True
        Me.halfList2.ItemHeight = 23
        Me.halfList2.Location = New System.Drawing.Point(620, 279)
        Me.halfList2.Name = "halfList2"
        Me.halfList2.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.halfList2.Size = New System.Drawing.Size(150, 299)
        Me.halfList2.TabIndex = 11
        '
        'totalList
        '
        Me.totalList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.totalList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalList.FormattingEnabled = True
        Me.totalList.ItemHeight = 23
        Me.totalList.Location = New System.Drawing.Point(797, 279)
        Me.totalList.Name = "totalList"
        Me.totalList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.totalList.Size = New System.Drawing.Size(150, 299)
        Me.totalList.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 581)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(377, 30)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Team Totals"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubScores
        '
        Me.SubScores.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SubScores.BackColor = System.Drawing.Color.Transparent
        Me.SubScores.BackgroundImage = CType(resources.GetObject("SubScores.BackgroundImage"), System.Drawing.Image)
        Me.SubScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubScores.FlatAppearance.BorderSize = 0
        Me.SubScores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SubScores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.SubScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubScores.Location = New System.Drawing.Point(151, 691)
        Me.SubScores.Name = "SubScores"
        Me.SubScores.Size = New System.Drawing.Size(200, 100)
        Me.SubScores.TabIndex = 16
        Me.SubScores.UseVisualStyleBackColor = False
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
        Me.FinishedButton.Location = New System.Drawing.Point(631, 691)
        Me.FinishedButton.Name = "FinishedButton"
        Me.FinishedButton.Size = New System.Drawing.Size(200, 100)
        Me.FinishedButton.TabIndex = 17
        Me.FinishedButton.UseVisualStyleBackColor = False
        '
        'totalH1
        '
        Me.totalH1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.totalH1.BackColor = System.Drawing.Color.Transparent
        Me.totalH1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalH1.Location = New System.Drawing.Point(443, 581)
        Me.totalH1.Name = "totalH1"
        Me.totalH1.Size = New System.Drawing.Size(150, 30)
        Me.totalH1.TabIndex = 18
        Me.totalH1.Text = " "
        Me.totalH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalH2
        '
        Me.totalH2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.totalH2.BackColor = System.Drawing.Color.Transparent
        Me.totalH2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalH2.Location = New System.Drawing.Point(620, 581)
        Me.totalH2.Name = "totalH2"
        Me.totalH2.Size = New System.Drawing.Size(150, 30)
        Me.totalH2.TabIndex = 19
        Me.totalH2.Text = " "
        Me.totalH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'final
        '
        Me.final.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.final.BackColor = System.Drawing.Color.Transparent
        Me.final.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.final.Location = New System.Drawing.Point(792, 581)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(150, 30)
        Me.final.TabIndex = 20
        Me.final.Text = " "
        Me.final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(391, 691)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(200, 100)
        Me.ExitButton.TabIndex = 21
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ScoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 928)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.totalH2)
        Me.Controls.Add(Me.totalH1)
        Me.Controls.Add(Me.FinishedButton)
        Me.Controls.Add(Me.SubScores)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalList)
        Me.Controls.Add(Me.halfList2)
        Me.Controls.Add(Me.halfList1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.numList)
        Me.Controls.Add(Me.playerNumLbl)
        Me.Controls.Add(Me.titleLabel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScoreBoard"
        Me.Text = "ScoreTracker - Scoreboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents playerNumLbl As Label
    Friend WithEvents numList As ListBox
    Friend WithEvents info1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nameList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents halfList1 As ListBox
    Friend WithEvents halfList2 As ListBox
    Friend WithEvents totalList As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SubScores As Button
    Friend WithEvents FinishedButton As Button
    Friend WithEvents totalH1 As Label
    Friend WithEvents totalH2 As Label
    Friend WithEvents final As Label
    Friend WithEvents ExitButton As Button
End Class
