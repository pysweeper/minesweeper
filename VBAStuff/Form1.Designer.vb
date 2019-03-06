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
        Me.ColumnsBox = New System.Windows.Forms.MaskedTextBox()
        Me.ColumnLabel = New System.Windows.Forms.Label()
        Me.RowLabel = New System.Windows.Forms.Label()
        Me.RowBox = New System.Windows.Forms.MaskedTextBox()
        Me.MinesBox = New System.Windows.Forms.Label()
        Me.MineBox = New System.Windows.Forms.MaskedTextBox()
        Me.ControlBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label1.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ControlBox.Controls.Add(Me.MineBox)
        Me.ControlBox.Controls.Add(Me.MinesBox)
        Me.ControlBox.Controls.Add(Me.ColumnsBox)
        Me.ControlBox.Controls.Add(Me.ColumnLabel)
        Me.ControlBox.Controls.Add(Me.RowLabel)
        Me.ControlBox.Controls.Add(Me.RowBox)
        Me.ControlBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlBox.ForeColor = System.Drawing.Color.White
        Me.ControlBox.Location = New System.Drawing.Point(12, 12)
        Me.ControlBox.Name = "ControlBox"
        Me.ControlBox.Size = New System.Drawing.Size(412, 78)
        Me.ControlBox.TabIndex = 4
        Me.ControlBox.TabStop = False
        Me.ControlBox.Text = "Controls"
        Me.ControlBox.Visible = False
        '
        'ColumnsBox
        '
        Me.ColumnsBox.BackColor = System.Drawing.Color.White
        Me.ColumnsBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnsBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnsBox.Location = New System.Drawing.Point(82, 46)
        Me.ColumnsBox.Mask = "00"
        Me.ColumnsBox.Name = "ColumnsBox"
        Me.ColumnsBox.Size = New System.Drawing.Size(30, 16)
        Me.ColumnsBox.TabIndex = 3
        Me.ColumnsBox.Text = "10"
        Me.ColumnsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnsBox.ValidatingType = GetType(Integer)
        '
        'ColumnLabel
        '
        Me.ColumnLabel.AutoSize = True
        Me.ColumnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnLabel.Location = New System.Drawing.Point(8, 43)
        Me.ColumnLabel.Name = "ColumnLabel"
        Me.ColumnLabel.Size = New System.Drawing.Size(75, 20)
        Me.ColumnLabel.TabIndex = 2
        Me.ColumnLabel.Text = "Columns:"
        '
        'RowLabel
        '
        Me.RowLabel.AutoSize = True
        Me.RowLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowLabel.Location = New System.Drawing.Point(29, 19)
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(53, 20)
        Me.RowLabel.TabIndex = 1
        Me.RowLabel.Text = "Rows:"
        '
        'RowBox
        '
        Me.RowBox.BackColor = System.Drawing.Color.White
        Me.RowBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowBox.Location = New System.Drawing.Point(82, 22)
        Me.RowBox.Mask = "00"
        Me.RowBox.Name = "RowBox"
        Me.RowBox.Size = New System.Drawing.Size(30, 16)
        Me.RowBox.TabIndex = 0
        Me.RowBox.Text = "10"
        Me.RowBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.RowBox.ValidatingType = GetType(Integer)
        '
        'MinesBox
        '
        Me.MinesBox.AutoSize = True
        Me.MinesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinesBox.Location = New System.Drawing.Point(131, 19)
        Me.MinesBox.Name = "MinesBox"
        Me.MinesBox.Size = New System.Drawing.Size(55, 20)
        Me.MinesBox.TabIndex = 4
        Me.MinesBox.Text = "Mines:"
        '
        'MineBox
        '
        Me.MineBox.BackColor = System.Drawing.Color.White
        Me.MineBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MineBox.Font = New System.Drawing.Font("DejaVu Sans Mono for Powerline", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MineBox.Location = New System.Drawing.Point(189, 22)
        Me.MineBox.Mask = "00"
        Me.MineBox.Name = "MineBox"
        Me.MineBox.Size = New System.Drawing.Size(30, 16)
        Me.MineBox.TabIndex = 5
        Me.MineBox.Text = "10"
        Me.MineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MineBox.ValidatingType = GetType(Integer)
        '
        'Minesweeper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ControlBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayButton)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Minesweeper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.ControlBox.ResumeLayout(False)
        Me.ControlBox.PerformLayout()
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
    Friend WithEvents MinesBox As Label
End Class
