Public Class Minesweeper
    Private NRow As Integer = 10
    Private NCol As Integer = 10
    Public ButtonArray(NRow * NCol - 1) As Button

    ' Play Button
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        cpp = Shell("MineSweeper.exe")
        Dim id As Long = GetCurrentProcessId
        Threading.Thread.Sleep(100)
        MessageCPP("10")
        Threading.Thread.Sleep(30)
        MessageCPP("4")
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
            Dim rowString As String
            'MsgBox(RowBox.Text)
            rowString = RowBox.Text
            NRow = Integer.Parse(rowString)
            'MsgBox("Hello")
            ' Grab(box.text And set to NRow)
        End If
    End Sub

    Private Sub ColumnsBox_Enter(sender As Object, e As KeyPressEventArgs) Handles ColumnsBox.KeyPress
        If e.KeyChar = vbCr Then
            'MsgBox(ColumnsBox.Text)
            Dim colString As String
            'MsgBox(RowBox.Text)
            colString = ColumnsBox.Text
            NCol = Integer.Parse(colString)
        End If
    End Sub

    Private Sub MinesBox_Enter(sender As Object, e As KeyPressEventArgs) Handles MineBox.KeyPress
        If e.KeyChar = vbCr Then
            'MsgBox(MineBox.Text)
            Dim mineString As String
            mineString = RowBox.Text
            MineNum = Integer.Parse(mineString)
        End If
    End Sub

    Private Sub BoardContainer_Paint(sender As Object, e As PaintEventArgs) Handles BoardContainer.Paint

    End Sub

    Private Sub ClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Todo: We should send a button number to app instead of row/column
        Dim ButtonPushed As Integer = sender.name.Replace("Button", "")
        ' Temp fix is to divide by 10 for the row. and mod 10 for the column.
        Dim Row As Integer = ButtonPushed / 10
        Dim Column As Integer = ButtonPushed Mod 10
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ButtonArray(ButtonPushed).BackColor.Equals(Color.FromArgb(0, 0, 64)) And
                IsNothing(Me.ButtonArray(ButtonPushed).BackgroundImage) Then
                Me.ButtonArray(ButtonPushed).BackgroundImage = System.Drawing.Image.FromFile("flag.jpg")
                Me.ButtonArray(ButtonPushed).BackColor = Color.FromArgb(0, 0, 0)
                Flags = Flags + 1
                FlagWin()
                ''else if right click and is already flag, set unclicked.
            ElseIf Me.ButtonArray(ButtonPushed).BackColor.Equals(Color.FromArgb(0, 0, 0)) Then
                Me.ButtonArray(ButtonPushed).BackgroundImage = Nothing
                Me.ButtonArray(ButtonPushed).BackColor = Color.FromArgb(0, 0, 64)
                Flags = Flags - 1
                FlagWin()
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            MessageCPP(CType(Row, String))
            MessageCPP(CType(Column, String))
            CheckLoss()
            If testCharacter = "L" Then
                RunLoseGame()
            Else
                UpdateArray(smallArray)
                UpdateTiles()

            End If
        End If
    End Sub

    Private Sub DrawBoard()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        '
        For i = 0 To NRow * NCol - 1
            ButtonArray(i) = New System.Windows.Forms.Button With {
                .BackColor = System.Drawing.SystemColors.ControlDark,
                .Location = New System.Drawing.Point((i * 36) Mod 360, (((i \ 10) * 36) + 2)),
                .Name = "Button" & i,
                .Size = New System.Drawing.Size(36, 36),
                .UseVisualStyleBackColor = False,
                .Text = ""
                }
            'ButtonArray(i).Margin = New Padding(0)
            BoardContainer.Controls.Add(ButtonArray(i))

            AddHandler ButtonArray(i).MouseDown, AddressOf ClickHandler
        Next
        Me.ResumeLayout(False)
    End Sub

End Class
