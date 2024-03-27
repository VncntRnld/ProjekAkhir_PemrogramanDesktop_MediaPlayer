Imports System.IO
Imports TagLib
Imports TagLib.Riff

Class formLagu

    'Current info storage
    Dim title As String
    Dim artist As String
    Dim album As String
    Dim year As String
    Dim duration As Integer, currentDuration As Integer

    Dim shuffle As Boolean = False


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
        lblCurrentSong.Text = title
        lblCurrentSinger.Text = artist
        lblDurasi.Text = file.Properties.Duration().ToString.Substring(3, 5)

        barLagu.Maximum = Me.duration
        Me.currentDuration = 0 '!!!

        file.Dispose()
    End Sub

    Private Sub playNewSong()
        If btnPlay.Text = "play" And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.URL = lstLagu.SelectedItems(0).Tag.ToString()

            'Text Now Playing
            CurrentInfo()

            Timer1.Enabled = True
            btnPlay.Image = My.Resources.pause32px
            btnPlay.Text = "pause"
        End If
    End Sub

    Private Sub playSong()
        If btnPlay.Text = "play" And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()

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

            stopSong()
            lstLagu.SelectedIndices.Clear()
            If selectedIndex < lstLagu.Items.Count - 1 Then

                If shuffle Then 'Jika shuffle nyala..
                    Dim random As New Random()

                    lstLagu.SelectedIndices.Add(random.Next(0, lstLagu.Items.Count))
                Else
                    lstLagu.SelectedIndices.Add(selectedIndex + 1)
                End If

            Else
                lstLagu.SelectedIndices.Add(0)

            End If
            playNewSong()

        End If
    End Sub

    Private Sub prevSong()
        If lstLagu.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = lstLagu.SelectedIndices(0)
            If selectedIndex > 0 Then
                stopSong()
                lstLagu.SelectedIndices.Clear()
                lstLagu.SelectedIndices.Add(selectedIndex - 1)
                playNewSong()
            End If
        End If
    End Sub

    Private Sub ShuffleSong() '!!!
        If shuffle = True And lstLagu.Items.Count > 0 Then
            shuffle = False
        Else
            shuffle = True
        End If

    End Sub

    'GUI Handlers
    Private Sub formLagu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlay.Text = "play"
        AxWindowsMediaPlayer1.uiMode = "none"

        Panel2.Dock = DockStyle.Fill

        Dim relativeFilePath As String = "autosave.txt"
        Dim filePath As String = Path.Combine(Application.StartupPath, relativeFilePath)
        If My.Computer.FileSystem.FileExists(filePath) Then
            lstLagu.Items.Clear()
            Dim line As String
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Console.WriteLine(line)
                    Dim file As TagLib.File = Nothing

                    file = TagLib.File.Create(line)
                    Dim item As New ListViewItem()
                    item.Text = If(file.Tag.Title, Path.GetFileNameWithoutExtension(line))
                    item.SubItems.Add(String.Join(", ", file.Tag.Performers))
                    item.SubItems.Add(file.Tag.Album)
                    item.SubItems.Add(file.Properties.Duration.ToString("mm\:ss"))
                    item.Tag = line ' Simpan jalur file untuk pemutaran
                    lstLagu.Items.Add(item)

                    If file IsNot Nothing Then
                        file.Dispose()
                    End If
                End While
            End Using
        End If
    End Sub

    Private Sub formLagu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim relativeFilePath As String = "autosave.txt"
        Dim filePath As String = Path.Combine(Application.StartupPath, relativeFilePath)
        Using writer As New StreamWriter(filePath)
            For Each item As ListViewItem In lstLagu.Items
                writer.WriteLine(item.Tag.ToString())
            Next
        End Using
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If btnPlay.Text = "play" Then
            If shuffle Then
                ShuffleSong()
            End If
            playSong()
        Else
            stopSong()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        OpenFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
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
        If lstLagu.SelectedItems.Count > 0 Then
            lstLagu.Items.Remove(lstLagu.SelectedItems(0))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        nextSong()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        prevSong()
    End Sub

    Private Sub lstLagu_DoubleClick(sender As Object, e As EventArgs) Handles lstLagu.DoubleClick
        stopSong()
        playNewSong()
    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        ShuffleSong()
    End Sub

    Private Sub FileToolStripMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownOpened
        FileToolStripMenuItem.ForeColor = Color.FromArgb(23, 26, 33)
    End Sub

    Private Sub FileToolStripMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.DropDownClosed
        FileToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Using stream As New StreamWriter(SaveFileDialog1.FileName)
                    For Each item As ListViewItem In lstLagu.Items
                        stream.WriteLine(item.Tag.ToString())
                    Next
                End Using
                MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        lstLagu.Items.Clear()

        OpenFileDialog2.Filter = "Text files (*.txt)|*.txt"
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Dim line As String
            Try
                Using reader As New StreamReader(OpenFileDialog2.FileName)
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        Console.WriteLine(line)
                        Dim file As TagLib.File = Nothing
                        Try
                            file = TagLib.File.Create(line)
                            Dim item As New ListViewItem()
                            item.Text = If(file.Tag.Title, Path.GetFileNameWithoutExtension(line))
                            item.SubItems.Add(String.Join(", ", file.Tag.Performers))
                            item.SubItems.Add(file.Tag.Album)
                            item.SubItems.Add(file.Properties.Duration.ToString("mm\:ss"))
                            item.Tag = line ' Simpan jalur file untuk pemutaran
                            lstLagu.Items.Add(item)

                        Catch ex As Exception
                            ' Menangani kesalahan pembacaan metadata
                            MessageBox.Show($"Error reading metadata for file {Path.GetFileName(line)}")

                        Finally
                            If file IsNot Nothing Then
                                file.Dispose()
                            End If
                        End Try
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show("Error Opening file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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