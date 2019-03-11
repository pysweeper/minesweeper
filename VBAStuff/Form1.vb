﻿Public Class Minesweeper
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
        RowBox.Show()
        BoardContainer.Show()
        DrawBoard()
    End Sub

    ' Destructor for Minesweeper
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles Me.FormClosing
        If (cpp) Then
            MessageCPP("-9999")
        End If
    End Sub

    Private Sub RowBox_Enter(sender As Object, e As KeyPressEventArgs) Handles RowBox.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            NRow = sender.Text
            If NRow >= 20 Then
                NRow = 20
            ElseIf NCol < 2 Then
                NCol = 2
            End If
            Dim EnteredRows = "r" & Format(NRow, "00")
            MessageCPP(EnteredRows)
            DrawBoard()
            RowLabel.Focus()
        End If
    End Sub

    Private Sub ColumnsBox_Enter(sender As Object, e As KeyPressEventArgs) Handles ColumnsBox.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            NCol = sender.Text
            If NCol >= 38 Then
                NCol = 38
            ElseIf NCol < 2 Then
                NCol = 2
            End If
            Dim EnteredColumns = "c" & Format(NCol, "00")
            MessageCPP(EnteredColumns)
            DrawBoard()
            ColumnLabel.Focus()
        End If
    End Sub

    Private Sub MinesBox_Enter(sender As Object, e As KeyPressEventArgs) Handles MineBox.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            NMines = sender.Text
            If NMines > NRow * NCol - 1 Then
                NMines = NRow * NCol - 1
            ElseIf NMines < 1 Then
                NMines = 1
            End If
            Dim EnteredMines = "m" & Format(NMines, "000")
            MessageCPP(EnteredMines)
            DrawBoard()
            MinesLabel.Focus()
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
                RunLoseGame()
            ElseIf testCharacter = "W" Then
                RunWinGame()
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

    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click, Win.Click, Lose.Click
        EndBox.Hide()
        Win.Hide()
        Lose.Hide()
        PlayAgain.Hide()
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

End Class
