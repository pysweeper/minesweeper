Public Module Module1
    Declare Function GetCurrentProcessId Lib "kernel32" () As Long
    Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Integer) As Integer
    Public cpp As Integer
    Public Function ClearSpaces(str As String) As String
        Return New String(str.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
    Public smallArray(10, 10) As Char
    Public testCharacter As Char
    Public Sub UpdateArray(array(,) As Char)
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Program Files\Minesweeper\board.txt")
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
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Program Files\Minesweeper\you_lose.txt")
        fileReader = ClearSpaces(fileReader)
        testCharacter = fileReader(0)
    End Sub
End Module
