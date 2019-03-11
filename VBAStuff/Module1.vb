Public Module Module1
    Declare Function GetCurrentProcessId Lib "kernel32" () As Long
    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Public cpp As Integer
    Public MineNum As Integer

    'Public ButtonArray(100) As Button
    '@param str - the string to remove whitespace from
    '@return - the same string without whitespace
    '@remarks - see citations, this function removes whitespace from a string.
    Public Function ClearSpaces(str As String) As String
        Return New String(str.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Public Flags As Integer
    Public boardArray(Minesweeper.NRow - 1, Minesweeper.NCol - 1) As Char
    Public testCharacter As Char
    Public mapString As String

    ''
    '
    '@return - none
    '@remarks - after C++ updates the board.txt file, VBA's array must read in the text file and update.
    Public Sub UpdateArray(array(,) As Char)
        ReDim boardArray(Minesweeper.NRow - 1, Minesweeper.NCol - 1)
        Dim fileReader As String
        Threading.Thread.Sleep(100)
        fileReader = My.Computer.FileSystem.ReadAllText("board.txt")
        fileReader = ClearSpaces(fileReader)
        Dim counter As Integer
        counter = 0
        For i = 0 To Minesweeper.NRow - 1
            For j = 0 To Minesweeper.NCol - 1
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
            testCharacter = "N"
        Else
            testCharacter = fileReader(0)
        End If
    End Sub

    ''
    '
    '@return - none
    '@remarks - Closes the C++ program, resets the VBA application. Reports win to user.
    Public Sub RunWinGame()
        Minesweeper.Lose.SendToBack()
        Minesweeper.Lose.Hide()
        Minesweeper.BoardContainer.SendToBack()
        Minesweeper.ControlBox.SendToBack()
        Minesweeper.ControlBox.Hide()
        Minesweeper.EndBox.BringToFront()
        Minesweeper.EndBox.Show()
        Minesweeper.PlayAgain.BringToFront()
        Minesweeper.PlayAgain.Show()
        Minesweeper.Win.BringToFront()
        Minesweeper.Win.Show()
        Minesweeper.Focus()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Closes the C++ program, resets the VBA application. Reports loss to user.
    Public Sub RunLoseGame()
        Minesweeper.Win.SendToBack()
        Minesweeper.Win.Hide()
        Minesweeper.BoardContainer.SendToBack()
        Minesweeper.ControlBox.SendToBack()
        Minesweeper.ControlBox.Hide()
        Minesweeper.PlayAgain.BringToFront()
        Minesweeper.PlayAgain.Show()
        Minesweeper.Lose.BringToFront()
        Minesweeper.Lose.Show()
        Minesweeper.EndBox.BringToFront()
        Minesweeper.EndBox.Show()
        Minesweeper.Focus()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Checks for a win condition based on flag locations. If win, run RunWinGame().
    Public Sub FlagWin()
        ''MsgBox("We ran flag win")
        mapString = My.Computer.FileSystem.ReadAllText("you_lose.txt")
        If mapString(0) = "W" Then
            RunWinGame()
        End If
    End Sub
    ''
    '
    '@return - none
    '@remarks - Scans the tile array, updates button skins accordingly.
    Public Sub UpdateTiles()
        Dim numButtons = (Minesweeper.NRow * Minesweeper.NCol)
        For i = 0 To numButtons - 1
            Dim uRow = i \ Minesweeper.NCol
            Dim uColumn = i Mod Minesweeper.NCol
            If boardArray(uRow, uColumn) = "-" Then
                Minesweeper.ButtonArray(i).Enabled = False
                Minesweeper.ButtonArray(i).BackgroundImage = Nothing
                Minesweeper.ButtonArray(i).BackColor = ColorTranslator.FromHtml("#073642")
            ElseIf boardArray(uRow, uColumn) = "H" Then
                Minesweeper.ButtonArray(i).BackgroundImage = Nothing
            ElseIf boardArray(uRow, uColumn) = "F" Then
                Minesweeper.ButtonArray(i).BackgroundImage = System.Drawing.Image.FromFile("flag.png")
            ElseIf boardArray(uRow, uColumn) = "M" Then
                Minesweeper.ButtonArray(i).BackgroundImage = System.Drawing.Image.FromFile("clickedMine.jpg")
            Else
                Minesweeper.ButtonArray(i).Enabled = False
                Minesweeper.ButtonArray(i).BackgroundImage = Nothing
                Minesweeper.ButtonArray(i).BackColor = ColorTranslator.FromHtml("#657b83")
                Minesweeper.ButtonArray(i).Text = boardArray(uRow, uColumn)
            End If
        Next
    End Sub

    Public Sub CountFlags()
        Flags = 0
        Dim numButtons = (Minesweeper.NRow * Minesweeper.NCol)
        For i = 0 To numButtons - 1
            Dim uRow = i \ Minesweeper.NCol
            Dim uColumn = i Mod Minesweeper.NCol
            If boardArray(uRow, uColumn) = "F" Then
                Flags = Flags + 1
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
        Minesweeper.NRow = 10
        Minesweeper.NCol = 10
        Minesweeper.NMines = 10
        Threading.Thread.Sleep(100)
        cpp = Shell("MineSweeper.exe")
    End Sub

End Module
