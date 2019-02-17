
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SmallPickBombNum.Show()
        Me.Hide()
        cpp = Shell("MineSweeper.exe")
        ''p = Process.Start("MineSweeper.exe")
        Threading.Thread.Sleep(100)
        SendKeys.Send("10")
        Dim id As Long
        id = GetCurrentProcessId
        ''SmallPickBombNum.Label2.Text = id
        'MsgBox(id)
        Threading.Thread.Sleep(30)
        SendKeys.Send("{ENTER}")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
