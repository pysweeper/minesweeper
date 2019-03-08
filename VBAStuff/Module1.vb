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
    Public smallArray(Minesweeper.NRow, Minesweeper.NCol) As Char
    Public testCharacter As Char
    Public mapString As String

    ''
    '
    '@return - none
    '@remarks - after C++ updates the board.txt file, VBA's array must read in the text file and update.
    Public Sub UpdateArray(array(,) As Char)
        ReDim smallArray(Minesweeper.NRow, Minesweeper.NCol)
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("board.txt")
        fileReader = ClearSpaces(fileReader)
        Dim counter As Integer
        counter = 0
        For i = 0 To Minesweeper.NRow - 1
            For j = 0 To Minesweeper.NCol - 1
                smallArray(i, j) = fileReader(counter)
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
        MsgBox("You won!")
        Minesweeper.Focus()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Closes the C++ program, resets the VBA application. Reports loss to user.
    Public Sub RunLoseGame()
        MsgBox("Oh dear! You clicked a mine!")
        Minesweeper.Focus()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Checks for a win condition based on flag locations. If win, run RunWinGame().
    Public Sub FlagWin()
        ''MsgBox("We ran flag win")
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        MineNum = 0
        For i = 0 To Minesweeper.NRow * Minesweeper.NCol - 1
            If mapString(i) = "0" Then
                MineNum = MineNum + 1
            End If
        Next
        ''  MsgBox(MineNum)
        Dim counter As Integer = 0

        ''first of all, we need to find out which boys have mines.
        For i = 0 To Minesweeper.NRow * Minesweeper.NCol - 1
            If mapString(i) = "0" Then
                If Minesweeper.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 0) Then
                    counter = counter + 1
                    ''the button is a flag.
                End If
            End If
        Next

        ''  MsgBox(counter)
        ''then, we need to see if those same boys have flags.
        If counter = MineNum And Flags = MineNum Then
            ''run the win script!

            '' MsgBox("You're a winner :D")
            RunWinGame()
        End If
    End Sub
    ''
    '
    '@return - none
    '@remarks - Scans the tile array, updates button skins accordingly.
    Public Sub UpdateTiles()
        Dim secondResult As Integer
        Dim firstResult As Integer
        Dim firstStr As String
        For i = 0 To Minesweeper.NRow * Minesweeper.NCol - 1
            Dim iStr = CStr(i)
            If iStr.Length = 1 Then
                firstResult = 0
            Else
                firstStr = iStr(0)
                firstResult = CInt(firstStr)
            End If
            iStr = iStr(iStr.Length - 1)
            secondResult = CInt(iStr)
            If smallArray(firstResult, secondResult) = "-" Then
                Minesweeper.ButtonArray(i).Enabled = False
                Minesweeper.ButtonArray(i).BackColor = ColorTranslator.FromHtml("#073642")
            ElseIf smallArray(firstResult, secondResult) = "H" Then
            Else
                Minesweeper.ButtonArray(i).Enabled = False
                Minesweeper.ButtonArray(i).BackColor = ColorTranslator.FromHtml("#657b83")
                Minesweeper.ButtonArray(i).Text = smallArray(firstResult, secondResult)
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

End Module
