Imports System.IO
Imports Id3
Imports TagLib

Class formLagu

    'Current info storage
    Dim title As String
    Dim artist As String
    Dim album As String
    Dim year As String
    Dim duration As Integer, currentDuration As Integer

    'Update current playing song info
    Private Sub CurrentInfo()
        Dim file As TagLib.File = TagLib.File.Create(lstLagu.SelectedItems(0).Tag.ToString)

        'Read the tags
        Me.title = file.Tag.Title
        Me.artist = file.Tag.FirstPerformer
        Me.album = file.Tag.Album
        Me.year = file.Tag.Year.ToString()
        Me.duration = CInt(file.Properties.Duration().TotalSeconds)

        'Update Info
        lblCurrentSong.Text = "Now Playing: " & title & " - " & artist
        lblDurasi.Text = file.Properties.Duration().ToString.Substring(3, 5)

        barLagu.Maximum = Me.duration
        Me.currentDuration = 0

        file.Dispose()
    End Sub

    Private Sub playSong()
        If btnPlay.Text = "play" And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.URL = lstLagu.SelectedItems(0).Tag.ToString()

            'Text Now Playing
            CurrentInfo()

            Timer1.Enabled = True
            btnPlay.Image = My.Resources.pause32px
            btnPlay.Text = "pause"
        End If
    End Sub

    Private Sub stopSong()
        If btnPlay.Text = "pause" Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

            Timer1.Enabled = False
            btnPlay.Image = My.Resources.play32px
            btnPlay.Text = "play"
        End If
    End Sub

    Private Sub nextSong()
        If lstLagu.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = lstLagu.SelectedIndices(0)
            If selectedIndex < lstLagu.Items.Count - 1 Then
                stopSong()
                lstLagu.SelectedIndices.Clear()
                lstLagu.SelectedIndices.Add(selectedIndex + 1)
                playSong()
            End If
        End If
    End Sub

    Private Sub prevSong()
        If lstLagu.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = lstLagu.SelectedIndices(0)
            If selectedIndex > 0 Then
                stopSong()
                lstLagu.SelectedIndices.Clear()
                lstLagu.SelectedIndices.Add(selectedIndex - 1)
                playSong()
            End If
        End If
    End Sub

    'GUI Handlers
    Private Sub formLagu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlay.Text = "play"
        AxWindowsMediaPlayer1.uiMode = "none"
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If btnPlay.Text = "play" Then
            playSong()
        Else
            stopSong()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        OpenFileDialog1.ShowDialog()
        If DialogResult.OK Then
            For Each lagu As String In OpenFileDialog1.FileNames
                Dim file As TagLib.File = Nothing
                Try
                    file = TagLib.File.Create(lagu)
                    Dim item As New ListViewItem()
                    item.Text = If(file.Tag.Title, Path.GetFileNameWithoutExtension(lagu))
                    item.SubItems.Add(String.Join(", ", file.Tag.Performers))
                    item.SubItems.Add(file.Tag.Album)
                    item.SubItems.Add(file.Properties.Duration.ToString("mm\:ss"))
                    item.Tag = lagu ' Simpan jalur file untuk pemutaran
                    lstLagu.Items.Add(item)

                Catch ex As Exception
                    ' Menangani kesalahan pembacaan metadata
                    MessageBox.Show($"Error reading metadata for file {Path.GetFileName(lagu)}")

                Finally
                    If file IsNot Nothing Then
                        file.Dispose()
                    End If
                End Try
            Next
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        lstLagu.Items.Remove(lstLagu.SelectedItems(0))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        nextSong()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        prevSong()
    End Sub

    'Buat Timer per lagu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.currentDuration < Me.duration Then
            barLagu.Value = currentDuration
            lblDurasiSekarang.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            currentDuration += 1
        Else
            stopSong()
            nextSong()
        End If
    End Sub

End Class