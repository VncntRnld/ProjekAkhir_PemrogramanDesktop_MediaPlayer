
Public Class floatingWindow

    Private Sub floatingWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formLagu.title IsNot Nothing Then
            Me.lblCurrentSong.Text = formLagu.title
            Me.lblCurrentSinger.Text = formLagu.artist
        End If

        If formLagu.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            btnPlay.Image = My.Resources.pause32px
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If formLagu.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            If formLagu.shuffle Then
                formLagu.ShuffleSong()
            End If
            formLagu.playSong()
        Else
            formLagu.pauseSong()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        formLagu.nextSong()
    End Sub

    ' Move Form
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown, Panel3.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove, Panel3.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp, Panel3.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub


    ' Close and minimize
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        formLagu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class