<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Minesweeper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Minesweeper))
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlBox = New System.Windows.Forms.GroupBox()
        Me.DisabledPanel = New System.Windows.Forms.Panel()
        Me.ControlsPanel = New System.Windows.Forms.Panel()
        Me.ColumnsBox = New System.Windows.Forms.MaskedTextBox()
        Me.RowBox = New System.Windows.Forms.MaskedTextBox()
        Me.RowLabel = New System.Windows.Forms.Label()
        Me.ColumnLabel = New System.Windows.Forms.Label()
        Me.MinesLabel = New System.Windows.Forms.Label()
        Me.MineBox = New System.Windows.Forms.MaskedTextBox()
        Me.FlagsLabel = New System.Windows.Forms.Label()
        Me.FlagsRemainingLabel = New System.Windows.Forms.Label()
        Me.CheatButton = New System.Windows.Forms.Button()
        Me.FeaturePanel = New System.Windows.Forms.Panel()
        Me.PowerThree = New System.Windows.Forms.Button()
        Me.PowerTwo = New System.Windows.Forms.Button()
        Me.PowerOne = New System.Windows.Forms.Button()
        Me.FeatureMode = New System.Windows.Forms.CheckBox()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.HelpBox = New System.Windows.Forms.GroupBox()
        Me.HelpText = New System.Windows.Forms.Label()
        Me.GameOverLabel = New System.Windows.Forms.Label()
        Me.BoardContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.PlayAgain = New System.Windows.Forms.Label()
        Me.EndBox = New System.Windows.Forms.GroupBox()
        Me.WinsLabel = New System.Windows.Forms.Label()
        Me.ControlBox.SuspendLayout()
        Me.ControlsPanel.SuspendLayout()
        Me.FeaturePanel.SuspendLayout()
        Me.HelpBox.SuspendLayout()
        Me.EndBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.SystemColors.Menu
        Me.PlayButton.Location = New System.Drawing.Point(309, 245)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(167, 44)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.TabStop = False
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(177, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 74)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Minesweeper!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlBox
        '
        Me.ControlBox.Controls.Add(Me.DisabledPanel)
        Me.ControlBox.Controls.Add(Me.ControlsPanel)
        Me.ControlBox.Controls.Add(Me.FeaturePanel)
        Me.ControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ControlBox.ForeColor = System.Drawing.Color.White
        Me.ControlBox.Location = New System.Drawing.Point(13, 13)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(759, 79)
        Me.ControlBox.TabIndex = 4
        Me.ControlBox.TabStop = False
        Me.ControlBox.Text = "Controls"
        Me.ControlBox.Visible = False
        '
        'DisabledPanel
        '
        Me.DisabledPanel.BackgroundImage = CType(resources.GetObject("DisabledPanel.BackgroundImage"), System.Drawing.Image)
        Me.DisabledPanel.ForeColor = System.Drawing.Color.Transparent
        Me.DisabledPanel.Location = New System.Drawing.Point(8, 16)
        Me.DisabledPanel.Name = "DisabledPanel"
        Me.DisabledPanel.Size = New System.Drawing.Size(525, 54)
        Me.DisabledPanel.TabIndex = 11
        Me.DisabledPanel.Visible = False
        '
        'ControlsPanel
        '
        Me.ControlsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ControlsPanel.Controls.Add(Me.ColumnsBox)
        Me.ControlsPanel.Controls.Add(Me.RowBox)
        Me.ControlsPanel.Controls.Add(Me.RowLabel)
        Me.ControlsPanel.Controls.Add(Me.ColumnLabel)
        Me.ControlsPanel.Controls.Add(Me.MinesLabel)
        Me.ControlsPanel.Controls.Add(Me.MineBox)
        Me.ControlsPanel.Controls.Add(Me.FlagsLabel)
        Me.ControlsPanel.Controls.Add(Me.FlagsRemainingLabel)
        Me.ControlsPanel.Controls.Add(Me.CheatButton)
        Me.ControlsPanel.Location = New System.Drawing.Point(3, 16)
        Me.ControlsPanel.Name = "ControlsPanel"
        Me.ControlsPanel.Size = New System.Drawing.Size(533, 57)
        Me.ControlsPanel.TabIndex = 10
        '
        'ColumnsBox
        '
        Me.ColumnsBox.BackColor = System.Drawing.Color.White
        Me.ColumnsBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColumnsBox.Location = New System.Drawing.Point(89, 33)
        Me.ColumnsBox.Mask = "00"
        Me.ColumnsBox.Name = "ColumnsBox"
        Me.ColumnsBox.Size = New System.Drawing.Size(30, 17)
        Me.ColumnsBox.TabIndex = 3
        Me.ColumnsBox.Text = "10"
        Me.ColumnsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnsBox.ValidatingType = GetType(Integer)
        '
        'RowBox
        '
        Me.RowBox.BackColor = System.Drawing.Color.White
        Me.RowBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RowBox.Location = New System.Drawing.Point(89, 9)
        Me.RowBox.Mask = "00"
        Me.RowBox.Name = "RowBox"
        Me.RowBox.Size = New System.Drawing.Size(30, 17)
        Me.RowBox.TabIndex = 0
        Me.RowBox.Text = "10"
        Me.RowBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RowBox.ValidatingType = GetType(Integer)
        '
        'RowLabel
        '
        Me.RowLabel.AutoSize = True
        Me.RowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RowLabel.Location = New System.Drawing.Point(29, 9)
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(51, 18)
        Me.RowLabel.TabIndex = 1
        Me.RowLabel.Text = "Rows:"
        '
        'ColumnLabel
        '
        Me.ColumnLabel.AutoSize = True
        Me.ColumnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColumnLabel.Location = New System.Drawing.Point(9, 33)
        Me.ColumnLabel.Name = "ColumnLabel"
        Me.ColumnLabel.Size = New System.Drawing.Size(72, 18)
        Me.ColumnLabel.TabIndex = 2
        Me.ColumnLabel.Text = "Columns:"
        '
        'MinesLabel
        '
        Me.MinesLabel.AutoSize = True
        Me.MinesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.MinesLabel.Location = New System.Drawing.Point(132, 9)
        Me.MinesLabel.Name = "MinesLabel"
        Me.MinesLabel.Size = New System.Drawing.Size(52, 18)
        Me.MinesLabel.TabIndex = 4
        Me.MinesLabel.Text = "Mines:"
        '
        'MineBox
        '
        Me.MineBox.BackColor = System.Drawing.Color.White
        Me.MineBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MineBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.MineBox.Location = New System.Drawing.Point(203, 10)
        Me.MineBox.Mask = "000"
        Me.MineBox.Name = "MineBox"
        Me.MineBox.Size = New System.Drawing.Size(30, 17)
        Me.MineBox.TabIndex = 5
        Me.MineBox.Text = "010"
        Me.MineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MineBox.ValidatingType = GetType(Integer)
        '
        'FlagsLabel
        '
        Me.FlagsLabel.AutoSize = True
        Me.FlagsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FlagsLabel.Location = New System.Drawing.Point(132, 34)
        Me.FlagsLabel.Name = "FlagsLabel"
        Me.FlagsLabel.Size = New System.Drawing.Size(48, 18)
        Me.FlagsLabel.TabIndex = 6
        Me.FlagsLabel.Text = "Flags:"
        '
        'FlagsRemainingLabel
        '
        Me.FlagsRemainingLabel.AutoSize = True
        Me.FlagsRemainingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagsRemainingLabel.Location = New System.Drawing.Point(200, 34)
        Me.FlagsRemainingLabel.Name = "FlagsRemainingLabel"
        Me.FlagsRemainingLabel.Size = New System.Drawing.Size(16, 18)
        Me.FlagsRemainingLabel.TabIndex = 7
        Me.FlagsRemainingLabel.Text = "0"
        '
        'CheatButton
        '
        Me.CheatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheatButton.Location = New System.Drawing.Point(308, 10)
        Me.CheatButton.Name = "CheatButton"
        Me.CheatButton.Size = New System.Drawing.Size(138, 36)
        Me.CheatButton.TabIndex = 9
        Me.CheatButton.Text = "Cheat Mode"
        Me.CheatButton.UseVisualStyleBackColor = True
        '
        'FeaturePanel
        '
        Me.FeaturePanel.Controls.Add(Me.WinsLabel)
        Me.FeaturePanel.Controls.Add(Me.PowerThree)
        Me.FeaturePanel.Controls.Add(Me.PowerTwo)
        Me.FeaturePanel.Controls.Add(Me.PowerOne)
        Me.FeaturePanel.Controls.Add(Me.FeatureMode)
        Me.FeaturePanel.Controls.Add(Me.HelpButton)
        Me.FeaturePanel.Location = New System.Drawing.Point(542, 10)
        Me.FeaturePanel.Name = "FeaturePanel"
        Me.FeaturePanel.Size = New System.Drawing.Size(211, 63)
        Me.FeaturePanel.TabIndex = 8
        '
        'PowerThree
        '
        Me.PowerThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PowerThree.Enabled = False
        Me.PowerThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PowerThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.PowerThree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerThree.Location = New System.Drawing.Point(73, 27)
        Me.PowerThree.Name = "PowerThree"
        Me.PowerThree.Size = New System.Drawing.Size(30, 30)
        Me.PowerThree.TabIndex = 4
        Me.PowerThree.Text = "F"
        Me.PowerThree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.PowerThree.UseVisualStyleBackColor = True
        '
        'PowerTwo
        '
        Me.PowerTwo.Enabled = False
        Me.PowerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PowerTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.PowerTwo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerTwo.Location = New System.Drawing.Point(40, 27)
        Me.PowerTwo.Name = "PowerTwo"
        Me.PowerTwo.Size = New System.Drawing.Size(30, 30)
        Me.PowerTwo.TabIndex = 3
        Me.PowerTwo.Text = "C"
        Me.PowerTwo.UseVisualStyleBackColor = True
        '
        'PowerOne
        '
        Me.PowerOne.Enabled = False
        Me.PowerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PowerOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.PowerOne.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerOne.Location = New System.Drawing.Point(7, 27)
        Me.PowerOne.Name = "PowerOne"
        Me.PowerOne.Size = New System.Drawing.Size(30, 30)
        Me.PowerOne.TabIndex = 2
        Me.PowerOne.Text = "#"
        Me.PowerOne.UseVisualStyleBackColor = True
        '
        'FeatureMode
        '
        Me.FeatureMode.AutoSize = True
        Me.FeatureMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.FeatureMode.Location = New System.Drawing.Point(7, 3)
        Me.FeatureMode.Name = "FeatureMode"
        Me.FeatureMode.Size = New System.Drawing.Size(133, 22)
        Me.FeatureMode.TabIndex = 1
        Me.FeatureMode.Text = "Power-up Mode"
        Me.FeatureMode.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.HelpButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.HelpButton.Location = New System.Drawing.Point(142, 27)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(58, 30)
        Me.HelpButton.TabIndex = 5
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'HelpBox
        '
        Me.HelpBox.AutoSize = True
        Me.HelpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HelpBox.Controls.Add(Me.HelpText)
        Me.HelpBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBox.Location = New System.Drawing.Point(10, 10)
        Me.HelpBox.Name = "HelpBox"
        Me.HelpBox.Size = New System.Drawing.Size(764, 435)
        Me.HelpBox.TabIndex = 6
        Me.HelpBox.TabStop = False
        Me.HelpBox.Visible = False
        '
        'HelpText
        '
        Me.HelpText.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HelpText.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpText.Location = New System.Drawing.Point(4, 9)
        Me.HelpText.Name = "HelpText"
        Me.HelpText.Size = New System.Drawing.Size(756, 422)
        Me.HelpText.TabIndex = 0
        Me.HelpText.Text = resources.GetString("HelpText.Text")
        Me.HelpText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GameOverLabel
        '
        Me.GameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GameOverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverLabel.Location = New System.Drawing.Point(185, 8)
        Me.GameOverLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.GameOverLabel.Name = "GameOverLabel"
        Me.GameOverLabel.Size = New System.Drawing.Size(389, 37)
        Me.GameOverLabel.TabIndex = 6
        Me.GameOverLabel.Text = "NULL"
        Me.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BoardContainer
        '
        Me.BoardContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BoardContainer.ForeColor = System.Drawing.Color.Transparent
        Me.BoardContainer.Location = New System.Drawing.Point(8, 101)
        Me.BoardContainer.Margin = New System.Windows.Forms.Padding(1)
        Me.BoardContainer.MaximumSize = New System.Drawing.Size(1152, 1300)
        Me.BoardContainer.Name = "BoardContainer"
        Me.BoardContainer.Size = New System.Drawing.Size(769, 349)
        Me.BoardContainer.TabIndex = 5
        Me.BoardContainer.Visible = False
        '
        'PlayAgain
        '
        Me.PlayAgain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlayAgain.AutoEllipsis = True
        Me.PlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(282, 45)
        Me.PlayAgain.Margin = New System.Windows.Forms.Padding(0)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(195, 28)
        Me.PlayAgain.TabIndex = 0
        Me.PlayAgain.Text = "Play Again?"
        Me.PlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndBox
        '
        Me.EndBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EndBox.Controls.Add(Me.PlayAgain)
        Me.EndBox.Controls.Add(Me.GameOverLabel)
        Me.EndBox.Location = New System.Drawing.Point(13, 13)
        Me.EndBox.Name = "EndBox"
        Me.EndBox.Padding = New System.Windows.Forms.Padding(0)
        Me.EndBox.Size = New System.Drawing.Size(759, 79)
        Me.EndBox.TabIndex = 10
        Me.EndBox.TabStop = False
        Me.EndBox.Visible = False
        '
        'WinsLabel
        '
        Me.WinsLabel.AutoSize = True
        Me.WinsLabel.Location = New System.Drawing.Point(147, 4)
        Me.WinsLabel.Name = "WinsLabel"
        Me.WinsLabel.Size = New System.Drawing.Size(50, 18)
        Me.WinsLabel.TabIndex = 6
        Me.WinsLabel.Text = "0 wins"
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 455)
        Me.Controls.Add(Me.ControlBox)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.BoardContainer)
        Me.Controls.Add(Me.HelpBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EndBox)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "Minesweeper"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.ControlBox.ResumeLayout(False)
        Me.ControlsPanel.ResumeLayout(False)
        Me.ControlsPanel.PerformLayout()
        Me.FeaturePanel.ResumeLayout(False)
        Me.FeaturePanel.PerformLayout()
        Me.HelpBox.ResumeLayout(False)
        Me.EndBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ControlBox As GroupBox
    Friend WithEvents RowBox As MaskedTextBox
    Friend WithEvents RowLabel As Label
    Friend WithEvents ColumnsBox As MaskedTextBox
    Friend WithEvents ColumnLabel As Label
    Friend WithEvents MineBox As MaskedTextBox
    Friend WithEvents MinesLabel As Label
    Friend WithEvents FlagsLabel As Label
    Friend WithEvents FlagsRemainingLabel As Label
    Friend WithEvents BoardContainer As FlowLayoutPanel
    Friend WithEvents FeaturePanel As Panel
    Friend WithEvents FeatureMode As CheckBox
    Friend WithEvents PowerThree As Button
    Friend WithEvents PowerTwo As Button
    Friend WithEvents PowerOne As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents CheatButton As Button
    Friend WithEvents GameOverLabel As Label
    Friend WithEvents PlayAgain As Label
    Friend WithEvents EndBox As GroupBox
    Friend WithEvents HelpBox As GroupBox
    Friend WithEvents HelpText As Label
    Friend WithEvents ControlsPanel As Panel
    Friend WithEvents DisabledPanel As Panel
    Friend WithEvents WinsLabel As Label
End Class
