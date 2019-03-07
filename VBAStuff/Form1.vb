
Public Class Minesweeper
    Private NRow As Integer = 10
    Private NCol As Integer = 10

    ' Play Button
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        cpp = Shell("MineSweeper.exe")
        Threading.Thread.Sleep(100)
        SendKeys.Send("10")
        Dim id As Long = GetCurrentProcessId
        Threading.Thread.Sleep(30)
        SendKeys.Send("{ENTER}")
        Threading.Thread.Sleep(30)
        SendKeys.Send("4")
        Threading.Thread.Sleep(30)
        SendKeys.Send("{ENTER}")
        Me.PlayButton.Hide()
        Me.Label1.Hide()
        Me.ControlBox.Show()
        Me.RowBox.Show()
    End Sub

    ' Destructor for Minesweeper
    Private Sub Form1_Closing(sender As Object, e As EventArgs) Handles Me.FormClosing
        If (cpp) Then
            AppActivate(cpp)
            Threading.Thread.Sleep(100)
            SendKeys.Send("-9999")
            Threading.Thread.Sleep(30)
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub RowBox_Enter(sender As Object, e As KeyPressEventArgs) Handles RowBox.KeyPress
        If e.KeyChar = vbCr Then
            Dim rowString As String
            'MsgBox(RowBox.Text)
            rowString = RowBox.Text
            MineNum = Integer.Parse(rowString)
            'MsgBox("Hello")
            ' Grab(box.text And set to NRow)
        End If
    End Sub

    Private Sub ColumnsBox_Enter(sender As Object, e As KeyPressEventArgs) Handles ColumnsBox.KeyPress
        If e.KeyChar = vbCr Then
            MsgBox(ColumnsBox.Text)

        End If
    End Sub

    Private Sub MinesBox_Enter(sender As Object, e As KeyPressEventArgs) Handles MineBox.KeyPress
        If e.KeyChar = vbCr Then
            MsgBox(MineBox.Text)

        End If
    End Sub
End Class
