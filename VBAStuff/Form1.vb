Public Class Minesweeper
    Public NRow As Integer = 10
    Public NCol As Integer = 10
    Public NMines As Integer = 10
    Public ButtonArray(NRow * NCol - 1) As Button


    ' Play Button
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        cpp = Shell("MineSweeper.exe")
        'Dim id As Long = GetCurrentProcessId
        Flags = 0
        PlayButton.Hide()
        Label1.Hide()
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
        ' This is not much better now. Will become cleaner when command is reworked.
        If e.KeyChar = vbCr Then
            Dim value As Integer = sender.Text
            Dim box = sender.name
            Dim command As Char
            If box = "RowBox" Then
                command = "r"
                If value > 20 Then
                    value = 20
                ElseIf value < 2 Then
                    value = 2
                End If
                RowBox.Text = Format(value, "00")
                NRow = RowBox.Text
            ElseIf box = "ColumnsBox" Then
                command = "c"
                If value >= 38 Then
                    value = 38
                ElseIf value < 2 Then
                    value = 2
                End If
                ColumnsBox.Text = Format(value, "00")
                NCol = ColumnsBox.Text
            Else
                command = "m"
                If value > NRow * NCol - 1 Then
                    value = NRow * NCol - 1
                ElseIf value < 1 Then
                    value = 1
                End If
                MineBox.Text = Format(value, "000")
                NMines = MineBox.Text
            End If
            Dim cppCommand As String
            If command = "r" Or command = "c" Then
                cppCommand = command & Format(value, "00")
            Else
                cppCommand = command & Format(value, "000")
            End If
            MessageCPP(cppCommand)
            DrawBoard()
            e.Handled = True
        End If
    End Sub

    Private Sub ClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim ButtonPushed As Integer = sender.name.Replace("Button", "")
        Dim Row As Integer = ButtonPushed \ NCol
        Dim Column As Integer = ButtonPushed Mod NCol
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MessageCPP("f" & Format(Row, "00") & "." & Format(Column, "00"))
            UpdateArray(boardArray)
            UpdateTiles()
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            MessageCPP("g" & Format(Row, "00") & "." & Format(Column, "00"))
            UpdateArray(boardArray)
            UpdateTiles()
            CheckLoss()
            If testCharacter = "L" Then
                RunGameOver(testCharacter)
            ElseIf testCharacter = "W" Then
                RunGameOver(testCharacter)
            End If
        End If
        CountFlags()
        FlagsRemainingLabel.Text = Flags
    End Sub

    Public Sub DrawBoard()
        FlagsRemainingLabel.Text = 0
        ReDim ButtonArray(NRow * NCol - 1)
        If Not ButtonArray Is Nothing Then
            BoardContainer.Visible = False
            BoardContainer.Controls.Clear()
            BoardContainer.Visible = True
        End If
        BoardContainer.Width = NCol * 30
        BoardContainer.Height = NRow * 30
        Dim XOffset = (Width / 2) - (BoardContainer.Width / 2)
        Dim YOffset = 110
        BoardContainer.Location = New Point(XOffset, YOffset)
        For i = 0 To NRow * NCol - 1
            ButtonArray(i) = New System.Windows.Forms.Button With {
                .BackColor = ColorTranslator.FromHtml("#93a1a1"),
                .FlatStyle = 0,
                .Name = "Button" & i,
                .Size = New System.Drawing.Size(30, 30),
                .UseVisualStyleBackColor = False,
                .Text = "",
                .Padding = New Padding(0),
                .Margin = New Padding(0),
                .Anchor = AnchorStyles.Top
                }
            BoardContainer.Controls.Add(ButtonArray(i))
            AddHandler ButtonArray(i).MouseDown, AddressOf ClickHandler
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
        HelpText.BringToFront()
        HelpBox.Show()
    End Sub

    Private Sub HelpText_Click(sender As Object, e As EventArgs) Handles HelpText.Click
        HelpBox.Hide()
        HelpText.SendToBack()
        ControlBox.Show()
        BoardContainer.Show()
    End Sub

    Private Sub FeatureMode_CheckedChanged(sender As Object, e As EventArgs) Handles FeatureMode.CheckedChanged
        If FeatureMode.Checked Then
            ControlsPanel.Enabled = False
        Else
            ControlsPanel.Enabled = True
        End If
    End Sub
End Class
