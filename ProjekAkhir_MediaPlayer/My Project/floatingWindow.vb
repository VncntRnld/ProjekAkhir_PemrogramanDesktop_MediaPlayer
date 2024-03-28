
Public Class floatingWindow

    Private Sub floatingWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If formLagu.title IsNot Nothing Then
            Me.lblCurrentSong.Text = formLagu.title
            Me.lblCurrentSinger.Text = formLagu.artist
        End If

        If formLagu.btnPlay.Text = "pause" Then
            btnPlay.Image = My.Resources.pause32px
            btnPlay.Text = "pause"
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If Me.btnPlay.Text = "play" Then
            If formLagu.shuffle Then
                formLagu.ShuffleSong()
            End If
            formLagu.playSong()
        Else
            formLagu.stopSong()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        formLagu.nextSong()
    End Sub

End Class