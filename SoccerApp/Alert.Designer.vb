<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alert))
        Me.alertLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'alertLabel
        '
        Me.alertLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.alertLabel.BackColor = System.Drawing.Color.Transparent
        Me.alertLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alertLabel.ForeColor = System.Drawing.Color.White
        Me.alertLabel.Location = New System.Drawing.Point(12, 9)
        Me.alertLabel.Name = "alertLabel"
        Me.alertLabel.Size = New System.Drawing.Size(325, 223)
        Me.alertLabel.TabIndex = 3
        Me.alertLabel.Text = " "
        Me.alertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Location = New System.Drawing.Point(37, 261)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(275, 100)
        Me.ExitButton.TabIndex = 15
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 403)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.alertLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alert"
        Me.Text = "ScoreTracker - Alert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents alertLabel As Label
    Friend WithEvents ExitButton As Button
End Class
