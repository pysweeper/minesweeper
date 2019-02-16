Public Module Module1

    Declare Function GetCurrentProcessId Lib "kernel32" () As Long

    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer




    Public cpp As Integer

    Public MineNum As Integer

    Public ButtonArray(100) As Button

    Public Function ClearSpaces(str As String) As String
        Return New String(str.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function

    Public Flags As Integer


    Public smallArray(10, 10) As Char

    Public testCharacter As Char

    Public mapString As String


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
        Form1.Show()
    End Sub

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
        Form1.Show()
    End Sub

    Public Sub FlagWin()

        MineNum = 0
        For i = 0 To 99
            If mapString(i) = "0" Then
                MineNum = MineNum + 1
            End If
        Next

        Dim counter As Integer = 0

        ''first of all, we need to find out which boys have mines.
        For i = 0 To 99
            If mapString(i) = "0" Then
                If ButtonArray(i).BackColor = Color.FromArgb(0, 0, 0) Then
                    counter = counter + 1
                    ''the button is a flag.
                End If
            End If
        Next


        ''then, we need to see if those same boys have flags.
        If counter = MineNum And Flags = MineNum Then
            ''run the win script!

            '' MsgBox("You're a winner :D")
            RunWinGame()
        End If
    End Sub

    Public Sub AssignButtons()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        ButtonArray(0) = FormSmall.Button1
        ButtonArray(1) = FormSmall.Button2
        ButtonArray(2) = FormSmall.Button3
        ButtonArray(3) = FormSmall.Button4
        ButtonArray(4) = FormSmall.Button5
        ButtonArray(5) = FormSmall.Button6
        ButtonArray(6) = FormSmall.Button7
        ButtonArray(7) = FormSmall.Button8
        ButtonArray(8) = FormSmall.Button9

        ButtonArray(9) = FormSmall.Button10
        ButtonArray(10) = FormSmall.Button11
        ButtonArray(11) = FormSmall.Button12
        ButtonArray(12) = FormSmall.Button13
        ButtonArray(13) = FormSmall.Button14
        ButtonArray(14) = FormSmall.Button15
        ButtonArray(15) = FormSmall.Button16
        ButtonArray(16) = FormSmall.Button17
        ButtonArray(17) = FormSmall.Button18

        ButtonArray(18) = FormSmall.Button19
        ButtonArray(19) = FormSmall.Button20
        ButtonArray(20) = FormSmall.Button21
        ButtonArray(21) = FormSmall.Button22
        ButtonArray(22) = FormSmall.Button23
        ButtonArray(23) = FormSmall.Button24
        ButtonArray(24) = FormSmall.Button25
        ButtonArray(25) = FormSmall.Button26
        ButtonArray(26) = FormSmall.Button27

        ButtonArray(27) = FormSmall.Button28
        ButtonArray(28) = FormSmall.Button29
        ButtonArray(29) = FormSmall.Button30
        ButtonArray(30) = FormSmall.Button31
        ButtonArray(31) = FormSmall.Button32
        ButtonArray(32) = FormSmall.Button33
        ButtonArray(33) = FormSmall.Button34
        ButtonArray(34) = FormSmall.Button35
        ButtonArray(35) = FormSmall.Button36

        ButtonArray(36) = FormSmall.Button37
        ButtonArray(37) = FormSmall.Button38
        ButtonArray(38) = FormSmall.Button39
        ButtonArray(39) = FormSmall.Button40
        ButtonArray(40) = FormSmall.Button41
        ButtonArray(41) = FormSmall.Button42
        ButtonArray(42) = FormSmall.Button43
        ButtonArray(43) = FormSmall.Button44
        ButtonArray(44) = FormSmall.Button45

        ButtonArray(45) = FormSmall.Button46
        ButtonArray(46) = FormSmall.Button47
        ButtonArray(47) = FormSmall.Button48
        ButtonArray(48) = FormSmall.Button49
        ButtonArray(49) = FormSmall.Button50
        ButtonArray(50) = FormSmall.Button51
        ButtonArray(51) = FormSmall.Button52
        ButtonArray(52) = FormSmall.Button53
        ButtonArray(53) = FormSmall.Button54

        ButtonArray(45) = FormSmall.Button46
        ButtonArray(46) = FormSmall.Button47
        ButtonArray(47) = FormSmall.Button48
        ButtonArray(48) = FormSmall.Button49
        ButtonArray(49) = FormSmall.Button50
        ButtonArray(50) = FormSmall.Button51
        ButtonArray(51) = FormSmall.Button52
        ButtonArray(52) = FormSmall.Button53
        ButtonArray(53) = FormSmall.Button54

        ButtonArray(54) = FormSmall.Button55
        ButtonArray(55) = FormSmall.Button56
        ButtonArray(56) = FormSmall.Button57
        ButtonArray(57) = FormSmall.Button58
        ButtonArray(58) = FormSmall.Button59
        ButtonArray(59) = FormSmall.Button60
        ButtonArray(60) = FormSmall.Button61
        ButtonArray(61) = FormSmall.Button62
        ButtonArray(62) = FormSmall.Button63

        ButtonArray(63) = FormSmall.Button64
        ButtonArray(64) = FormSmall.Button65
        ButtonArray(65) = FormSmall.Button66
        ButtonArray(66) = FormSmall.Button67
        ButtonArray(67) = FormSmall.Button68
        ButtonArray(68) = FormSmall.Button69
        ButtonArray(69) = FormSmall.Button70
        ButtonArray(70) = FormSmall.Button71
        ButtonArray(71) = FormSmall.Button72

        ButtonArray(72) = FormSmall.Button73
        ButtonArray(73) = FormSmall.Button74
        ButtonArray(74) = FormSmall.Button75
        ButtonArray(75) = FormSmall.Button76
        ButtonArray(76) = FormSmall.Button77
        ButtonArray(77) = FormSmall.Button78
        ButtonArray(78) = FormSmall.Button79
        ButtonArray(79) = FormSmall.Button80
        ButtonArray(80) = FormSmall.Button81

        ButtonArray(81) = FormSmall.Button82
        ButtonArray(82) = FormSmall.Button83
        ButtonArray(83) = FormSmall.Button84
        ButtonArray(84) = FormSmall.Button85
        ButtonArray(85) = FormSmall.Button86
        ButtonArray(86) = FormSmall.Button87
        ButtonArray(87) = FormSmall.Button88
        ButtonArray(88) = FormSmall.Button89
        ButtonArray(89) = FormSmall.Button90

        ButtonArray(90) = FormSmall.Button91
        ButtonArray(91) = FormSmall.Button92
        ButtonArray(92) = FormSmall.Button93
        ButtonArray(93) = FormSmall.Button94
        ButtonArray(94) = FormSmall.Button95
        ButtonArray(95) = FormSmall.Button96
        ButtonArray(96) = FormSmall.Button97
        ButtonArray(97) = FormSmall.Button98
        ButtonArray(98) = FormSmall.Button99
        ButtonArray(99) = FormSmall.Button100
    End Sub



    Public Sub UpdateTiles()


        ''etc
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
                    ButtonArray(i).BackgroundImage = Nothing
                    ButtonArray(i).FlatStyle = FlatStyle.Flat
                    ButtonArray(i).BackColor = SystemColors.ControlDark

                ElseIf smallArray(firstResult, secondResult) = "1" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 1)
                    ButtonArray(i).BackgroundImage = Image.FromFile("1.png")

                ElseIf smallArray(firstResult, secondResult) = "2" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 2)
                    ButtonArray(i).BackgroundImage = Image.FromFile("2.png")

                ElseIf smallArray(firstResult, secondResult) = "3" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 3)
                    ButtonArray(i).BackgroundImage = Image.FromFile("3.png")

                ElseIf smallArray(firstResult, secondResult) = "4" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 4)
                    ButtonArray(i).BackgroundImage = Image.FromFile("4.png")

                ElseIf smallArray(firstResult, secondResult) = "5" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 5)
                    ButtonArray(i).BackgroundImage = Image.FromFile("5.png")

                ElseIf smallArray(firstResult, secondResult) = "6" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 6)
                    ButtonArray(i).BackgroundImage = Image.FromFile("6.png")

                ElseIf smallArray(firstResult, secondResult) = "7" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 7)
                    ButtonArray(i).BackgroundImage = Image.FromFile("7.png")

                ElseIf smallArray(firstResult, secondResult) = "8" Then
                    ButtonArray(i).BackColor = Color.FromArgb(0, 0, 8)
                ButtonArray(i).BackgroundImage = Image.FromFile("8.png")

            End If


        Next


    End Sub

    Public Sub ResetTiles()
        For i = 0 To 99
            ButtonArray(i).BackColor = Color.FromArgb(0, 0, 64)
        Next
    End Sub


End Module

''example



