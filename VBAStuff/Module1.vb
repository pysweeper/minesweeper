Public Module Module1
    Declare Function GetCurrentProcessId Lib "kernel32" () As Long
    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Public cpp As Integer
    Public gameState As Char
    Public nRow As Integer = 10
    Public nCol As Integer = 10
    Public nMines As Integer = 10
    Public nflags As Integer = 0
    Public nWins As Integer = 0
    Public buttonArray(nRow * nCol - 1) As Button
    Public boardArray(nRow - 1, nCol - 1) As Char

    '@param str - the string to remove whitespace from
    '@return - the same string without whitespace
    '@remarks - see citations, this function removes whitespace from a string.
    Public Function ClearSpaces(str As String) As String
        Return New String(str.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    ''
    '
    '@return - none
    '@remarks - after C++ updates the board.txt file, VBA's array must read in the text file and update.
    Public Sub UpdateArray(array(,) As Char)
        ReDim boardArray(nRow - 1, nCol - 1)
        Dim fileReader As String
        Threading.Thread.Sleep(100)
        fileReader = My.Computer.FileSystem.ReadAllText("board.txt")
        fileReader = ClearSpaces(fileReader)
        Dim counter As Integer
        counter = 0
        For i = 0 To nRow - 1
            For j = 0 To nCol - 1
                boardArray(i, j) = fileReader(counter)
                counter = counter + 1
            Next
        Next
    End Sub

    ''
    '
    'return - none
    '@remarks - Checks you_lose.txt for a character representing the game is over. This character would come from C++.
    Public Sub CheckLoss()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("you_lose.txt")
        fileReader = ClearSpaces(fileReader)
        If fileReader.Length = 0 Then
            gameState = "N"
        Else
            gameState = fileReader(0)
        End If
    End Sub

    ''
    '
    '@return - none
    '@remarks - Closes the C++ program, resets the VBA application. Reports win to user.
    Public Sub RunGameOver(gameStatus As Char)
        Minesweeper.ControlBox.Hide()
        If gameStatus = "W" Then
            nWins += 1
            If nWins > 0 And Minesweeper.FeatureMode.Checked Then Minesweeper.PowerOne.Enabled = True
            If nWins > 1 And Minesweeper.FeatureMode.Checked Then Minesweeper.PowerTwo.Enabled = True
            If nWins > 2 And Minesweeper.FeatureMode.Checked Then Minesweeper.PowerThree.Enabled = True
            Minesweeper.GameOverLabel.Text = "You Win!"
        Else
            nWins = 0
            Minesweeper.PowerOne.Enabled = False
            Minesweeper.PowerTwo.Enabled = False
            Minesweeper.PowerThree.Enabled = False
            Minesweeper.GameOverLabel.Text = "Oh dear! You clicked a mine!"
        End If
        Minesweeper.EndBox.Show()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Scans the tile array, updates button skins accordingly.
    Public Sub UpdateTiles()
        Dim numButtons = (nRow * nCol)
        For i = 0 To numButtons - 1
            Dim uRow = i \ nCol
            Dim uColumn = i Mod nCol
            If boardArray(uRow, uColumn) = "-" Then
                buttonArray(i).Enabled = False
                buttonArray(i).BackgroundImage = Nothing
                buttonArray(i).BackColor = ColorTranslator.FromHtml("#073642")
            ElseIf boardArray(uRow, uColumn) = "H" Then
                buttonArray(i).BackgroundImage = Nothing
            ElseIf boardArray(uRow, uColumn) = "F" Then
                buttonArray(i).BackgroundImage = System.Drawing.Image.FromFile("flag.png")
            ElseIf boardArray(uRow, uColumn) = "M" Then
                buttonArray(i).Enabled = False
                buttonArray(i).BackgroundImage = System.Drawing.Image.FromFile("clickedMine.jpg")
            Else
                buttonArray(i).Enabled = False
                buttonArray(i).BackgroundImage = Nothing
                buttonArray(i).BackColor = ColorTranslator.FromHtml("#657b83")
                buttonArray(i).Text = boardArray(uRow, uColumn)
            End If
        Next
    End Sub

    Public Sub CountFlags()
        nflags = 0
        Dim numButtons = (nRow * nCol)
        For i = 0 To numButtons - 1
            Dim uRow = i \ nCol
            Dim uColumn = i Mod nCol
            If boardArray(uRow, uColumn) = "F" Then
                nflags = nflags + 1
            End If
        Next
    End Sub

    Public Sub MessageCPP(message As String)
        If (cpp) Then
            AppActivate(cpp)
            SendKeys.Send(message)
            Threading.Thread.Sleep(50)
            SendKeys.Send("{ENTER}")
            Threading.Thread.Sleep(50)
            cpp = If(message = "-9999", 0, cpp)
        End If
    End Sub

    Public Sub Reset()
        MessageCPP("-9999")
        nRow = 10
        Minesweeper.RowBox.Text = "10"
        nCol = 10
        Minesweeper.ColumnsBox.Text = "10"
        nMines = 10
        Minesweeper.MineBox.Text = "10"
        Minesweeper.WinsLabel.Text = nWins & " Win" & If(nWins = 1, "", "s")
        Threading.Thread.Sleep(100)
        cpp = Shell("MineSweeper.exe")
    End Sub

End Module
