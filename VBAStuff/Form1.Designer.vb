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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ControlBox = New System.Windows.Forms.GroupBox()
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
        Me.WinsLabel = New System.Windows.Forms.Label()
        Me.PowerThree = New System.Windows.Forms.Button()
        Me.PowerTwo = New System.Windows.Forms.Button()
        Me.PowerOne = New System.Windows.Forms.Button()
        Me.FeatureMode = New System.Windows.Forms.CheckBox()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.DisabledPanel = New System.Windows.Forms.Panel()
        Me.HelpBox = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ExitHelp = New System.Windows.Forms.Button()
        Me.GameOverLabel = New System.Windows.Forms.Label()
        Me.BoardContainer = New System.Windows.Forms.FlowLayoutPanel()
        Me.PlayAgain = New System.Windows.Forms.Label()
        Me.EndBox = New System.Windows.Forms.GroupBox()
        Me.ControlBox.SuspendLayout()
        Me.ControlsPanel.SuspendLayout()
        Me.FeaturePanel.SuspendLayout()
        Me.HelpBox.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EndBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PlayButton.Location = New System.Drawing.Point(309, 245)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(167, 44)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.TabStop = False
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.TitleLabel.Location = New System.Drawing.Point(177, 66)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(461, 74)
        Me.TitleLabel.TabIndex = 3
        Me.TitleLabel.Text = "Minesweeper!"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlBox
        '
        Me.ControlBox.Controls.Add(Me.DisabledPanel)
        Me.ControlBox.Controls.Add(Me.ControlsPanel)
        Me.ControlBox.Controls.Add(Me.FeaturePanel)
        Me.ControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ControlBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ControlBox.Location = New System.Drawing.Point(13, 13)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(759, 79)
        Me.ControlBox.TabIndex = 4
        Me.ControlBox.TabStop = False
        Me.ControlBox.Text = "Controls"
        Me.ControlBox.Visible = False
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
        Me.ColumnsBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ColumnsBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.ColumnsBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
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
        Me.RowBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.RowBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.RowBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
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
        Me.MineBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.MineBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MineBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.MineBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
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
        'WinsLabel
        '
        Me.WinsLabel.AutoSize = True
        Me.WinsLabel.Location = New System.Drawing.Point(147, 4)
        Me.WinsLabel.Name = "WinsLabel"
        Me.WinsLabel.Size = New System.Drawing.Size(50, 18)
        Me.WinsLabel.TabIndex = 6
        Me.WinsLabel.Text = "0 wins"
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
        Me.FeatureMode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.FeatureMode.Location = New System.Drawing.Point(7, 3)
        Me.FeatureMode.Name = "FeatureMode"
        Me.FeatureMode.Size = New System.Drawing.Size(136, 22)
        Me.FeatureMode.TabIndex = 1
        Me.FeatureMode.Text = "Power-Up Mode"
        Me.FeatureMode.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
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
        'HelpBox
        '
        Me.HelpBox.AutoSize = True
        Me.HelpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.HelpBox.Controls.Add(Me.Panel2)
        Me.HelpBox.Controls.Add(Me.Panel1)
        Me.HelpBox.Controls.Add(Me.Panel3)
        Me.HelpBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBox.Location = New System.Drawing.Point(10, 10)
        Me.HelpBox.Name = "HelpBox"
        Me.HelpBox.Size = New System.Drawing.Size(764, 435)
        Me.HelpBox.TabIndex = 6
        Me.HelpBox.TabStop = False
        Me.HelpBox.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(460, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 204)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(217, 51)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.TabIndex = 15
        Me.PictureBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(43, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(170, 24)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "without clicking a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To win you must reveal all " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cells not containing a mine."
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(23, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 61)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Customize your game!"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 204)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(111, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Right-Click to flag cells" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you think are mines."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(111, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 72)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Left-Click to reveal cells. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If they are adjacent to mines," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a number will indic" &
    "ate how many."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 92)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 92)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.ExitHelp)
        Me.Panel3.Location = New System.Drawing.Point(6, 223)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(750, 209)
        Me.Panel3.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(245, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(259, 24)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "The fine print: Controls are disabled during Power-Up mode. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you leave Power-" &
    "Up mode, your wins and powers will reset!"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(98, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Level 3:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(98, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Level 2:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(98, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Level 1:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(316, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(328, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Each win gives you one level of Power-Up!"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(210, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Randomly flag an unflagged mine."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(210, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(440, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Reveal a random cell and all adjacent cells not next to a mine."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(210, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Reveal a random cell next to a mine."
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(167, 129)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(167, 91)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(167, 53)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(131, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Power-Up Mode!"
        '
        'ExitHelp
        '
        Me.ExitHelp.BackColor = System.Drawing.Color.Transparent
        Me.ExitHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.ExitHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.ExitHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ExitHelp.Location = New System.Drawing.Point(670, 174)
        Me.ExitHelp.Name = "ExitHelp"
        Me.ExitHelp.Size = New System.Drawing.Size(75, 30)
        Me.ExitHelp.TabIndex = 13
        Me.ExitHelp.Text = "Exit Help"
        Me.ExitHelp.UseVisualStyleBackColor = False
        '
        'GameOverLabel
        '
        Me.GameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GameOverLabel.BackColor = System.Drawing.Color.Transparent
        Me.GameOverLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameOverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
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
        Me.PlayAgain.BackColor = System.Drawing.Color.Transparent
        Me.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
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
        Me.EndBox.BackColor = System.Drawing.Color.Transparent
        Me.EndBox.Controls.Add(Me.PlayAgain)
        Me.EndBox.Controls.Add(Me.GameOverLabel)
        Me.EndBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EndBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.EndBox.Location = New System.Drawing.Point(13, 13)
        Me.EndBox.Name = "EndBox"
        Me.EndBox.Padding = New System.Windows.Forms.Padding(0)
        Me.EndBox.Size = New System.Drawing.Size(759, 79)
        Me.EndBox.TabIndex = 10
        Me.EndBox.TabStop = False
        Me.EndBox.Visible = False
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
        Me.Controls.Add(Me.EndBox)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.BoardContainer)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.HelpBox)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EndBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayButton As Button
    Friend WithEvents TitleLabel As Label
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
    Friend WithEvents ControlsPanel As Panel
    Friend WithEvents DisabledPanel As Panel
    Friend WithEvents WinsLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ExitHelp As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label14 As Label
End Class
