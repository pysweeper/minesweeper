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
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlBox = New System.Windows.Forms.GroupBox()
        Me.FlagsRemainingLabel = New System.Windows.Forms.Label()
        Me.FlagsLabel = New System.Windows.Forms.Label()
        Me.MineBox = New System.Windows.Forms.MaskedTextBox()
        Me.MinesLabel = New System.Windows.Forms.Label()
        Me.ColumnsBox = New System.Windows.Forms.MaskedTextBox()
        Me.ColumnLabel = New System.Windows.Forms.Label()
        Me.RowLabel = New System.Windows.Forms.Label()
        Me.RowBox = New System.Windows.Forms.MaskedTextBox()
        Me.BoardContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.FeaturePanel = New System.Windows.Forms.Panel()
        Me.FeatureMode = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.CheatButton = New System.Windows.Forms.Button()
        Me.ControlBox.SuspendLayout()
        Me.FeaturePanel.SuspendLayout()
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
        Me.PlayButton.Location = New System.Drawing.Point(321, 245)
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
        Me.ControlBox.Controls.Add(Me.CheatButton)
        Me.ControlBox.Controls.Add(Me.FeaturePanel)
        Me.ControlBox.Controls.Add(Me.FlagsRemainingLabel)
        Me.ControlBox.Controls.Add(Me.FlagsLabel)
        Me.ControlBox.Controls.Add(Me.MineBox)
        Me.ControlBox.Controls.Add(Me.MinesLabel)
        Me.ControlBox.Controls.Add(Me.ColumnsBox)
        Me.ControlBox.Controls.Add(Me.ColumnLabel)
        Me.ControlBox.Controls.Add(Me.RowLabel)
        Me.ControlBox.Controls.Add(Me.RowBox)
        Me.ControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.ControlBox.ForeColor = System.Drawing.Color.White
        Me.ControlBox.Location = New System.Drawing.Point(12, 13)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(759, 79)
        Me.ControlBox.TabIndex = 4
        Me.ControlBox.TabStop = False
        Me.ControlBox.Text = "Controls"
        Me.ControlBox.Visible = False
        '
        'FlagsRemainingLabel
        '
        Me.FlagsRemainingLabel.AutoSize = True
        Me.FlagsRemainingLabel.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagsRemainingLabel.Location = New System.Drawing.Point(199, 46)
        Me.FlagsRemainingLabel.Name = "FlagsRemainingLabel"
        Me.FlagsRemainingLabel.Size = New System.Drawing.Size(44, 18)
        Me.FlagsRemainingLabel.TabIndex = 7
        Me.FlagsRemainingLabel.Text = "0"
        '
        'FlagsLabel
        '
        Me.FlagsLabel.AutoSize = True
        Me.FlagsLabel.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.FlagsLabel.Location = New System.Drawing.Point(131, 46)
        Me.FlagsLabel.Name = "FlagsLabel"
        Me.FlagsLabel.Size = New System.Drawing.Size(62, 18)
        Me.FlagsLabel.TabIndex = 6
        Me.FlagsLabel.Text = "Flags:"
        '
        'MineBox
        '
        Me.MineBox.BackColor = System.Drawing.Color.White
        Me.MineBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MineBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.MineBox.Location = New System.Drawing.Point(202, 22)
        Me.MineBox.Mask = "000"
        Me.MineBox.Name = "MineBox"
        Me.MineBox.Size = New System.Drawing.Size(30, 18)
        Me.MineBox.TabIndex = 5
        Me.MineBox.Text = "010"
        Me.MineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MineBox.ValidatingType = GetType(Integer)
        '
        'MinesLabel
        '
        Me.MinesLabel.AutoSize = True
        Me.MinesLabel.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.MinesLabel.Location = New System.Drawing.Point(131, 21)
        Me.MinesLabel.Name = "MinesLabel"
        Me.MinesLabel.Size = New System.Drawing.Size(62, 18)
        Me.MinesLabel.TabIndex = 4
        Me.MinesLabel.Text = "Mines:"
        '
        'ColumnsBox
        '
        Me.ColumnsBox.BackColor = System.Drawing.Color.White
        Me.ColumnsBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnsBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.ColumnsBox.Location = New System.Drawing.Point(88, 45)
        Me.ColumnsBox.Mask = "00"
        Me.ColumnsBox.Name = "ColumnsBox"
        Me.ColumnsBox.Size = New System.Drawing.Size(30, 18)
        Me.ColumnsBox.TabIndex = 3
        Me.ColumnsBox.Text = "10"
        Me.ColumnsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnsBox.ValidatingType = GetType(Integer)
        '
        'ColumnLabel
        '
        Me.ColumnLabel.AutoSize = True
        Me.ColumnLabel.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.ColumnLabel.Location = New System.Drawing.Point(8, 45)
        Me.ColumnLabel.Name = "ColumnLabel"
        Me.ColumnLabel.Size = New System.Drawing.Size(80, 18)
        Me.ColumnLabel.TabIndex = 2
        Me.ColumnLabel.Text = "Columns:"
        '
        'RowLabel
        '
        Me.RowLabel.AutoSize = True
        Me.RowLabel.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.RowLabel.Location = New System.Drawing.Point(35, 21)
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(53, 18)
        Me.RowLabel.TabIndex = 1
        Me.RowLabel.Text = "Rows:"
        '
        'RowBox
        '
        Me.RowBox.BackColor = System.Drawing.Color.White
        Me.RowBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.RowBox.Location = New System.Drawing.Point(88, 21)
        Me.RowBox.Mask = "00"
        Me.RowBox.Name = "RowBox"
        Me.RowBox.Size = New System.Drawing.Size(30, 18)
        Me.RowBox.TabIndex = 0
        Me.RowBox.Text = "10"
        Me.RowBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RowBox.ValidatingType = GetType(Integer)
        '
        'BoardContainer
        '
        Me.BoardContainer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BoardContainer.Location = New System.Drawing.Point(12, 96)
        Me.BoardContainer.Margin = New System.Windows.Forms.Padding(1)
        Me.BoardContainer.MaximumSize = New System.Drawing.Size(1152, 1300)
        Me.BoardContainer.Name = "BoardContainer"
        Me.BoardContainer.Size = New System.Drawing.Size(759, 349)
        Me.BoardContainer.TabIndex = 5
        Me.BoardContainer.Visible = False
        '
        'FeaturePanel
        '
        Me.FeaturePanel.Controls.Add(Me.HelpButton)
        Me.FeaturePanel.Controls.Add(Me.Button3)
        Me.FeaturePanel.Controls.Add(Me.Button2)
        Me.FeaturePanel.Controls.Add(Me.Button1)
        Me.FeaturePanel.Controls.Add(Me.FeatureMode)
        Me.FeaturePanel.Location = New System.Drawing.Point(542, 10)
        Me.FeaturePanel.Name = "FeaturePanel"
        Me.FeaturePanel.Size = New System.Drawing.Size(211, 63)
        Me.FeaturePanel.TabIndex = 8
        '
        'FeatureMode
        '
        Me.FeatureMode.AutoSize = True
        Me.FeatureMode.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.FeatureMode.Location = New System.Drawing.Point(3, 3)
        Me.FeatureMode.Name = "FeatureMode"
        Me.FeatureMode.Size = New System.Drawing.Size(207, 22)
        Me.FeatureMode.TabIndex = 1
        Me.FeatureMode.Text = "Enable Power-up Mode"
        Me.FeatureMode.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(7, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "P1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(38, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "P2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(69, 29)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "P3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpButton.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 11.25!)
        Me.HelpButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.HelpButton.Location = New System.Drawing.Point(142, 29)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(58, 25)
        Me.HelpButton.TabIndex = 5
        Me.HelpButton.Text = "Help"
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'CheatButton
        '
        Me.CheatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheatButton.Location = New System.Drawing.Point(309, 27)
        Me.CheatButton.Name = "CheatButton"
        Me.CheatButton.Size = New System.Drawing.Size(138, 36)
        Me.CheatButton.TabIndex = 9
        Me.CheatButton.Text = "Cheat Mode"
        Me.CheatButton.UseVisualStyleBackColor = True
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 455)
        Me.Controls.Add(Me.BoardContainer)
        Me.Controls.Add(Me.ControlBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayButton)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "Minesweeper"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.ControlBox.ResumeLayout(False)
        Me.ControlBox.PerformLayout()
        Me.FeaturePanel.ResumeLayout(False)
        Me.FeaturePanel.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents CheatButton As Button
End Class
