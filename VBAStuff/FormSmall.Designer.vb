<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSmall
    Inherits System.Windows.Forms.Form

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private NRow As Integer = 10
    Private NCol As Integer = 10
    Public ButtonArray(NRow * NCol - 1) As Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Name = "FormSmall"
        Me.Text = "FormSmall"
        Me.ResumeLayout(False)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub ClickHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ''if right click and box is unclicked set it to flag
            If Me.ButtonArray(sender).BackColor.Equals(Color.FromArgb(0, 0, 64)) And IsNothing(Me.ButtonArray(sender).BackgroundImage) Then
                Me.ButtonArray(sender).BackgroundImage = System.Drawing.Image.FromFile("flag.jpg")
                Me.ButtonArray(sender).BackColor = Color.FromArgb(0, 0, 0)
                '' you placed another flag
                Flags = Flags + 1
                ''run some method to see if all mines and ONLY mines are flags. if so, end game.
                '' MsgBox("Flag win is the problem")
                FlagWin()
                ''else if right click and is already flag, set unclicked.
            ElseIf Me.ButtonArray(sender).BackColor.Equals(Color.FromArgb(0, 0, 0)) Then
                Me.ButtonArray(sender).BackgroundImage = Nothing
                Me.ButtonArray(sender).BackColor = Color.FromArgb(0, 0, 64)
                '' you removed a flag
                Flags = Flags - 1
                ''run some method to see if all mines and ONLY mines are flags. if so, end game.
                FlagWin()
                ''Naturally, in all other instances we will ignore a right click.
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            ''cpp = Shell("C:\Program Files\Minesweeper\MineSweeper.exe")
            AppActivate(cpp)
            SendKeys.Send("0")
            Threading.Thread.Sleep(30)
            SendKeys.Send("{ENTER}")
            Threading.Thread.Sleep(30)
            SendKeys.Send("0")
            Threading.Thread.Sleep(30)
            SendKeys.Send("{ENTER}")
            Threading.Thread.Sleep(30)

            ''Now we must check to see if we lost the game
            checkLoss()
            If testCharacter = "L" Then
                ''run the end game script
                RunLoseGame()
            Else
                UpdateArray(smallArray)
                UpdateTiles()

            End If
        End If
    End Sub

    Private Sub FormSmall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssignButtons()
        mapString = My.Computer.FileSystem.ReadAllText("map.txt")
        Flags = 0
        For i = 0 To 99
            Dim j = 0
            ButtonArray(i) = New System.Windows.Forms.Button()
            SuspendLayout()
            ButtonArray(i).BackColor = System.Drawing.SystemColors.ControlDark
            ButtonArray(i).Location = New System.Drawing.Point((i * 36) Mod 360, (((i \ 10) * 36) + 2))
            ButtonArray(i).Name = "Button" & i
            ButtonArray(i).Size = New System.Drawing.Size(36, 36)
            ButtonArray(i).TabIndex = 0
            ButtonArray(i).UseVisualStyleBackColor = False
            ButtonArray(i).BackColor = Color.FromArgb(0, 0, 64)
            ButtonArray(i).Text = ""
            Controls.Add(ButtonArray(i))
            AddHandler ButtonArray(i).Click, AddressOf ClickHandler
        Next
    End Sub

End Class
