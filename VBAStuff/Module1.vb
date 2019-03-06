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
    Public smallArray(10, 10) As Char
    Public testCharacter As Char
    Public mapString As String

    ''
    '
    '@return - none
    '@remarks - after C++ updates the board.txt file, VBA's array must read in the text file and update.
    Public Sub UpdateArray(array(,) As Char)

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("board.txt")
        fileReader = ClearSpaces(fileReader)
        '' MsgBox(fileReader)

        Dim counter As Integer
        counter = 0
        For i As Integer = 0 To 9

            For j As Integer = 0 To 9

                smallArray(i, j) = fileReader(counter)
                counter = counter + 1
            Next

        Next

        ' MsgBox(smallArray(1, 0))
    End Sub

    ''
    '
    'return - none
    '@remarks - Checks you_lose.txt for a character representing the game is over. This character would come from C++.
    Public Sub checkLoss()
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
        ''terminate the c++ program.
        AppActivate(cpp)
        SendKeys.Send("-9999")
        Threading.Thread.Sleep(50)
        SendKeys.Send("{ENTER}")
        Threading.Thread.Sleep(50)
        ''terminate the GUI, reload the first form.
        FormSmall.Close()
        SmallPickBombNum.Close()
        Minesweeper.Show()
    End Sub

    ''
    '
    '@return - none
    '@remarks - Closes the C++ program, resets the VBA application. Reports loss to user.
    Public Sub RunLoseGame()
        MsgBox("Oh dear! You clicked a mine!")
        AppActivate(cpp)
        SendKeys.Send("-9999")
        Threading.Thread.Sleep(50)
        SendKeys.Send("{ENTER}")
        Threading.Thread.Sleep(50)
        ''terminate the GUI, reload the first form.
        FormSmall.Close()
        SmallPickBombNum.Close()
        Minesweeper.Show()
    End Sub


    ''
    '
    '@return - none
    '@remarks - Checks for a win condition based on flag locations. If win, run RunWinGame().
    Public Sub FlagWin()
        ''MsgBox("We ran flag win")
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        MineNum = 0
        For i = 0 To 99
            If mapString(i) = "0" Then
                MineNum = MineNum + 1
            End If
        Next
        ''  MsgBox(MineNum)
        Dim counter As Integer = 0

        ''first of all, we need to find out which boys have mines.
        For i = 0 To 99
            If mapString(i) = "0" Then
                If FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 0) Then
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
    '@remarks - Pushes all buttons on FormSmall to the button array.
    Public Sub AssignButtons()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
    End Sub


    ''
    '
    '@return - none
    '@remarks - Scans the tile array, updates button skins accordingly.
    Public Sub UpdateTiles()



        Dim i As Integer
        Dim iStr As String
        Dim secondResult As Integer
        Dim firstResult As Integer
        Dim firstStr As String

        For i = 0 To 99
            iStr = CStr(i)
            If iStr.Length = 1 Then
                firstResult = 0
            Else
                firstStr = iStr(0)
                firstResult = CInt(firstStr)

            End If
            iStr = iStr(iStr.Length - 1)
            secondResult = CInt(iStr)

            If smallArray(firstResult, secondResult) = "-" Then
                ''make the button grey.
                FormSmall.ButtonArray(i).BackgroundImage = Nothing
                FormSmall.ButtonArray(i).FlatStyle = FlatStyle.Flat
                FormSmall.ButtonArray(i).BackColor = SystemColors.ControlDark

            ElseIf smallArray(firstResult, secondResult) = "1" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 1)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("1.png")

            ElseIf smallArray(firstResult, secondResult) = "2" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 2)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("2.png")

            ElseIf smallArray(firstResult, secondResult) = "3" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 3)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("3.png")

            ElseIf smallArray(firstResult, secondResult) = "4" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 4)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("4.png")

            ElseIf smallArray(firstResult, secondResult) = "5" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 5)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("5.png")

            ElseIf smallArray(firstResult, secondResult) = "6" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 6)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("6.png")

            ElseIf smallArray(firstResult, secondResult) = "7" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 7)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("7.png")

            ElseIf smallArray(firstResult, secondResult) = "8" Then
                FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 8)
                FormSmall.ButtonArray(i).BackgroundImage = Image.FromFile("8.png")

            End If


        Next


    End Sub

    ''
    '
    '@return - none
    '@remarks - Resets tiles to default skin.
    Public Sub ResetTiles()
        For i = 0 To 99
            FormSmall.ButtonArray(i).BackColor = Color.FromArgb(0, 0, 64)
        Next
    End Sub


End Module

''example



