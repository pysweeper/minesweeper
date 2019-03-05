<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSmall
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer
    Private NRow As Integer = 10
    Private NCol As Integer = 10
    Public ButtonArray(NRow * NCol - 1) As Button

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        Flags = 0
        Me.Name = "Board"
        Me.Text = "Board"
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.CenterToScreen()
        '
        For i = 0 To 99
            Dim j = 0
            ButtonArray(i) = New System.Windows.Forms.Button()
            SuspendLayout()
            ButtonArray(i).BackColor = System.Drawing.SystemColors.ControlDark
            ButtonArray(i).Location = New System.Drawing.Point((i * 36) Mod 360, (((i \ 10) * 36) + 2))
            ButtonArray(i).Name = "Button" & i
            ButtonArray(i).Size = New System.Drawing.Size(36, 36)
            ButtonArray(i).UseVisualStyleBackColor = False
            ButtonArray(i).BackColor = Color.FromArgb(0, 0, 64)
            ButtonArray(i).Text = ""
            Controls.Add(ButtonArray(i))
            AddHandler ButtonArray(i).MouseDown, AddressOf ClickHandler
        Next
        Me.ResumeLayout(False)
    End Sub

    Private Sub ClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Todo: We should send a button number to app instead of row/column
        Dim ButtonPushed As Integer = sender.name.Replace("Button", "")
        ' Temp fix is to divide by 10 for the row. and mod 10 for the column.
        Dim Row As Integer = ButtonPushed / 10
        Dim Column As Integer = ButtonPushed Mod 10
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.ButtonArray(ButtonPushed).BackColor.Equals(Color.FromArgb(0, 0, 64)) And
                IsNothing(Me.ButtonArray(ButtonPushed).BackgroundImage) Then
                Me.ButtonArray(ButtonPushed).BackgroundImage = System.Drawing.Image.FromFile("flag.jpg")
                Me.ButtonArray(ButtonPushed).BackColor = Color.FromArgb(0, 0, 0)
                Flags = Flags + 1
                FlagWin()
                ''else if right click and is already flag, set unclicked.
            ElseIf Me.ButtonArray(ButtonPushed).BackColor.Equals(Color.FromArgb(0, 0, 0)) Then
                Me.ButtonArray(ButtonPushed).BackgroundImage = Nothing
                Me.ButtonArray(ButtonPushed).BackColor = Color.FromArgb(0, 0, 64)
                Flags = Flags - 1
                FlagWin()
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            AppActivate(cpp)
            SendKeys.Send(CType(Row, String))
            Threading.Thread.Sleep(30)
            SendKeys.Send("{ENTER}")
            Threading.Thread.Sleep(30)
            SendKeys.Send(CType(Column, String))
            Threading.Thread.Sleep(30)
            SendKeys.Send("{ENTER}")
            Threading.Thread.Sleep(30)
            checkLoss()
            If testCharacter = "L" Then
                RunLoseGame()
            Else
                UpdateArray(smallArray)
                UpdateTiles()

            End If
        End If
    End Sub
End Class
