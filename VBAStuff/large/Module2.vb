Public Module Module2

    Public ButtonArrayMed(16) As Button

    Public medArray(4, 4) As Char

    Public Sub updateMedArray(array(,) As Char)

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("board.txt")
        fileReader = ClearSpaces(fileReader)
        '' MsgBox(fileReader)

        Dim counter As Integer
        counter = 0
        For i As Integer = 0 To 3

            For j As Integer = 0 To 3

                medArray(i, j) = fileReader(counter)
                counter = counter + 1
            Next

        Next

        ' MsgBox(medArray(1, 0))
    End Sub

    Public Sub RunWinGameMed()

        MsgBox("You won!")
        ''terminate the c++ program.
        AppActivate(cpp)
        SendKeys.Send("-9999")
        Threading.Thread.Sleep(50)
        SendKeys.Send("{ENTER}")
        Threading.Thread.Sleep(50)
        ''terminate the GUI, reload the first form.
        FormMedium.Close()
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
        FormMedium.Close()
        SmallPickBombNum.Close()
        Form1.Show()
    End Sub

    Public Sub FlagWinMed()
        ''MsgBox("We ran flag win")
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        MineNum = 0
        For i = 0 To 15
            If mapString(i) = "0" Then
                MineNum = MineNum + 1
            End If
        Next
        ''  MsgBox(MineNum)
        Dim counter As Integer = 0

        ''first of all, we need to find out which boys have mines.
        For i = 0 To 15
            If mapString(i) = "0" Then
                If ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 0) Then
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
            RunWinGameMed()
        End If
    End Sub

    Public Sub AssignButtonsMed()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        ButtonArrayMed(0) = FormMedium.Button1
        ButtonArrayMed(1) = FormMedium.Button2
        ButtonArrayMed(2) = FormMedium.Button3
        ButtonArrayMed(3) = FormMedium.Button4
        ButtonArrayMed(4) = FormMedium.Button5
        ButtonArrayMed(5) = FormMedium.Button6
        ButtonArrayMed(6) = FormMedium.Button7
        ButtonArrayMed(7) = FormMedium.Button8
        ButtonArrayMed(8) = FormMedium.Button9

        ButtonArrayMed(9) = FormMedium.Button10
        ButtonArrayMed(10) = FormMedium.Button11
        ButtonArrayMed(11) = FormMedium.Button12
        ButtonArrayMed(12) = FormMedium.Button13
        ButtonArrayMed(13) = FormMedium.Button14
        ButtonArrayMed(14) = FormMedium.Button15
        ButtonArrayMed(15) = FormMedium.Button16
    End Sub


    Public Sub UpdateTilesMed()


        ''etc
        Dim i As Integer
        Dim iStr As String
        Dim secondResult As Integer
        Dim firstResult As Integer
        Dim firstStr As String

        For i = 0 To 15
            iStr = CStr(i)
            If iStr.Length = 1 Then
                firstResult = 0
            Else
                firstStr = iStr(0)
                firstResult = CInt(firstStr)

            End If
            iStr = iStr(iStr.Length - 1)
            secondResult = CInt(iStr)

            If medArray(firstResult, secondResult) = "-" Then
                    ''make the button grey.
                    ButtonArrayMed(i).BackgroundImage = Nothing
                    ButtonArrayMed(i).FlatStyle = FlatStyle.Flat
                    ButtonArrayMed(i).BackColor = SystemColors.ControlDark

                ElseIf medArray(firstResult, secondResult) = "1" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 1)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("1.png")

                ElseIf medArray(firstResult, secondResult) = "2" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 2)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("2.png")

                ElseIf medArray(firstResult, secondResult) = "3" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 3)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("3.png")

                ElseIf medArray(firstResult, secondResult) = "4" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 4)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("4.png")

                ElseIf medArray(firstResult, secondResult) = "5" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 5)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("5.png")

                ElseIf medArray(firstResult, secondResult) = "6" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 6)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("6.png")

                ElseIf medArray(firstResult, secondResult) = "7" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 7)
                    ButtonArrayMed(i).BackgroundImage = Image.FromFile("7.png")

                ElseIf medArray(firstResult, secondResult) = "8" Then
                    ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 8)
                ButtonArrayMed(i).BackgroundImage = Image.FromFile("8.png")

            End If


        Next


    End Sub

    Public Sub ResetTilesMed()
        For i = 0 To 15
            ButtonArrayMed(i).BackColor = Color.FromArgb(0, 0, 64)
        Next
    End Sub


End Module

''example
