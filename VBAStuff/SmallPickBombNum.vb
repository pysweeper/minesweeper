Public Class SmallPickBombNum
    Private Sub SmallPickBombNum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ' Label2.Hide()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FormSmall.Show()
        AppActivate(cpp)
        SendKeys.Send(ComboBox1.Text)
    End Sub
End Class