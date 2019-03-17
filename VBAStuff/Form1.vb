Public Class Minesweeper

    ' Play Button
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        cpp = Shell("MineSweeper.exe")
        nflags = 0
        PlayButton.Hide()
        TitleLabel.Hide()
        ControlBox.Show()
        BoardContainer.Show()
        DrawBoard()
    End Sub

    ' Destructor for Minesweeper
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles Me.FormClosing
        If (cpp) Then
            MessageCPP("-9999")
        End If
    End Sub

    Private Sub Box_Enter(sender As Object, e As KeyPressEventArgs) Handles RowBox.KeyPress, ColumnsBox.KeyPress, MineBox.KeyPress
        If e.KeyChar = vbCr Then
            Dim value As Integer = sender.Text
            Dim box = sender.name
            If box = "RowBox" Then
                If value > 20 Then
                    value = 20
                ElseIf value < 2 Then
                    value = 2
                End If
                RowBox.Text = Format(value, "00")
                nRow = RowBox.Text
            ElseIf box = "ColumnsBox" Then
                If value > 38 Then
                    value = 38
                ElseIf value < 2 Then
                    value = 2
                End If
                ColumnsBox.Text = Format(value, "00")
                nCol = ColumnsBox.Text
            Else
                nMines = MineBox.Text
            End If
            ' Update MineBox.Text for all updates.
            Dim maxMines = nRow * nCol - 1
            If nMines > maxMines Then
                nMines = maxMines
            ElseIf nMines < 1 Then
                nMines = 1
            End If
            MineBox.Text = Format(nMines, "000")
            nMines = MineBox.Text
            Dim cppCommand As String
            cppCommand = "r" & RowBox.Text & "c" & ColumnsBox.Text & "m" & MineBox.Text
            MessageCPP(cppCommand)
            DrawBoard()
            e.Handled = True
        End If
    End Sub

    Private Sub ClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim ButtonPushed As Integer = sender.name.Replace("Button", "")
        Dim Row As Integer = ButtonPushed \ nCol
        Dim Column As Integer = ButtonPushed Mod nCol
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MessageCPP("f" & Format(Row, "00") & "." & Format(Column, "00"))
            UpdateArray(boardArray)
            UpdateTiles()
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            MessageCPP("g" & Format(Row, "00") & "." & Format(Column, "00"))
            UpdateArray(boardArray)
            UpdateTiles()
            CheckLoss()
            If gameState = "L" Then
                RunGameOver(gameState)
            ElseIf gameState = "W" Then
                RunGameOver(gameState)
            End If
        End If
        CountFlags()
        FlagsRemainingLabel.Text = nflags
    End Sub

    Public Sub DrawBoard()
        FlagsRemainingLabel.Text = 0
        ReDim buttonArray(nRow * nCol - 1)
        If Not buttonArray Is Nothing Then
            BoardContainer.Visible = False
            BoardContainer.Controls.Clear()
            BoardContainer.Visible = True
        End If
        BoardContainer.Width = nCol * 30
        BoardContainer.Height = nRow * 30
        Dim XOffset = (Width / 2) - (BoardContainer.Width / 2)
        Dim YOffset = 110
        BoardContainer.Location = New Point(XOffset, YOffset)
        For i = 0 To nRow * nCol - 1
            buttonArray(i) = New System.Windows.Forms.Button With {
                .BackColor = ColorTranslator.FromHtml("#073642"),
                .ForeColor = ColorTranslator.FromHtml("#eee8d5"),
                .FlatStyle = 0,
                .Name = "Button" & i,
                .Size = New System.Drawing.Size(30, 30),
                .UseVisualStyleBackColor = False,
                .Text = "",
                .Padding = New Padding(0),
                .Margin = New Padding(0),
                .Anchor = AnchorStyles.Top
                }
            BoardContainer.Controls.Add(buttonArray(i))
            AddHandler buttonArray(i).MouseDown, AddressOf ClickHandler
        Next
    End Sub

    Private Sub CheatButton_Click(sender As Object, e As EventArgs) Handles CheatButton.Click
        MessageCPP("h")
        DrawBoard()
        UpdateArray(boardArray)
        UpdateTiles()
    End Sub

    Private Sub Minesweeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        TopMost = True
    End Sub

    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click, GameOverLabel.Click
        EndBox.Hide()
        EndBox.SendToBack()
        BoardContainer.BringToFront()
        ControlBox.BringToFront()
        ControlBox.Show()
        Reset()
        DrawBoard()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        ControlBox.Hide()
        BoardContainer.Hide()
        HelpBox.Show()
    End Sub

    Private Sub ExitHelp_Click(sender As Object, e As EventArgs) Handles ExitHelp.Click
        HelpBox.Hide()
        ControlBox.Show()
        BoardContainer.Show()
    End Sub

    Private Sub FeatureMode_CheckedChanged(sender As Object, e As EventArgs) Handles FeatureMode.CheckedChanged
        If FeatureMode.Checked Then
            ControlsPanel.Enabled = True
        Else
            Dim answer As Integer = MessageBox.Show("You will lose all Power-Up mode progress if you leave." & vbCr & "Leave Power-Up mode?", "Quit Power-Up", MessageBoxButtons.YesNo)
            If answer = DialogResult.Yes Then
                PowerOne.Enabled = False
                PowerTwo.Enabled = False
                PowerThree.Enabled = False
                ControlsPanel.Enabled = True
                nWins = 0
                WinsLabel.Text = nWins & " Win" & If(nWins = 1, "", "s")
            ElseIf answer = DialogResult.No Then
                FeatureMode.Checked = True
            End If
        End If
    End Sub

    Private Sub Power1_Click(sender As Object, e As EventArgs) Handles PowerOne.Click
        MessageCPP("p1")
        UpdateArray(boardArray)
        UpdateTiles()
        CheckLoss()
        PowerOne.Enabled = False
        If gameState = "L" Then
            RunGameOver(gameState)
        ElseIf gameState = "W" Then
            RunGameOver(gameState)
        End If
    End Sub

    Private Sub Power2_Click(sender As Object, e As EventArgs) Handles PowerTwo.Click
        MessageCPP("p2")
        UpdateArray(boardArray)
        UpdateTiles()
        CheckLoss()
        PowerTwo.Enabled = False
        If gameState = "L" Then
            RunGameOver(gameState)
        ElseIf gameState = "W" Then
            RunGameOver(gameState)
        End If

    End Sub

    Private Sub Power3_Click(sender As Object, e As EventArgs) Handles PowerThree.Click
        MessageCPP("p3")
        UpdateArray(boardArray)
        UpdateTiles()
        PowerThree.Enabled = False
    End Sub

End Class
