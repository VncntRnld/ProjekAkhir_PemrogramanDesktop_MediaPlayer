Imports System.IO
Imports TagLib
Imports TagLib.Riff

Class formLagu

    'Current info storage
    Public Shared title As String
    Public Shared artist As String

    Dim album As String
    Dim year As String
    Dim duration As Integer, currentDuration As Integer
    Dim countdownTime As TimeSpan

    Public Shared shuffle As Boolean = False
    Public Shared loops As Boolean = False
    Public Shared currentindex As Integer = 0


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
        If floatingWindow.Visible Then
            floatingWindow.lblCurrentSong.Text = title
            floatingWindow.lblCurrentSinger.Text = artist
        End If

        lblDurasi.Text = file.Properties.Duration().ToString.Substring(3, 5)

        barLagu.Maximum = Me.duration
        Me.currentDuration = 0 '!!!

        file.Dispose()
    End Sub

    Private Sub playNewSong()
        If lstLagu.SelectedItems.Count > 0 Then
            pauseSong()

            Try
                AxWindowsMediaPlayer1.URL = lstLagu.SelectedItems(0).Tag.ToString()

                'Text Now Playing
                CurrentInfo()

                Timer1.Enabled = True
                Timer2.Enabled = True
                btnPlay.Image = My.Resources.pause32px

                If floatingWindow.Visible Then
                    floatingWindow.btnPlay.Image = My.Resources.pause32px
                End If

            Catch ex As Exception
                Dim currentIndex As Integer = lstLagu.SelectedIndices(0)

                nextSong()

                lstLagu.Items.RemoveAt(currentIndex)
            End Try

        End If
    End Sub


    Public Sub playSong()
        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsReady) And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()

            Timer1.Enabled = True
            Timer2.Enabled = True
            btnPlay.Image = My.Resources.pause32px

            If floatingWindow.Visible Then
                floatingWindow.btnPlay.Image = My.Resources.pause32px
            End If

        End If
    End Sub

    Public Sub pauseSong()
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

            Timer1.Enabled = False
            Timer2.Enabled = False
            btnPlay.Image = My.Resources.play32px
            If floatingWindow.Visible Then
                floatingWindow.btnPlay.Image = My.Resources.play32px
            End If
        End If
    End Sub

    Public Sub nextSong()
        If lstLagu.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = lstLagu.SelectedIndices(0)

            lstLagu.SelectedIndices.Clear()
            If selectedIndex < lstLagu.Items.Count - 1 Then

                If loops Then 'Jika shuffle nyala..
                    lstLagu.SelectedIndices.Add(selectedIndex)
                ElseIf shuffle Then
                    Dim random As New Random()
                    Dim newRandom As Integer = random.Next(0, lstLagu.Items.Count)
                    While selectedIndex = newRandom 'Random will always choose a new song
                        newRandom = random.Next(0, lstLagu.Items.Count)
                    End While
                    lstLagu.SelectedIndices.Add(newRandom)
                Else
                    lstLagu.SelectedIndices.Add(selectedIndex + 1)
                End If

            Else
                lstLagu.SelectedIndices.Add(0)

            End If
            playNewSong()

        End If
    End Sub

    Public Sub prevSong()
        If lstLagu.SelectedItems.Count > 0 Then
            Dim selectedIndex As Integer = lstLagu.SelectedIndices(0)
            If selectedIndex > 0 Then
                pauseSong()
                lstLagu.SelectedIndices.Clear()
                lstLagu.SelectedIndices.Add(selectedIndex - 1)
                playNewSong()
            End If
        End If
    End Sub

    Public Sub ShuffleSong() '!!!
        If shuffle = True And lstLagu.Items.Count > 0 Then
            shuffle = False
            btnShuffle.Image = My.Resources.offshuffle
        Else
            shuffle = True
            btnShuffle.Image = My.Resources.shuffle
        End If

    End Sub

    Public Sub LoopSong()
        If loops = True And lstLagu.Items.Count > 0 Then
            loops = False
            btnLoop.Image = My.Resources.offloop
        Else
            loops = True
            btnLoop.Image = My.Resources._loop
        End If
    End Sub

    'GUI Handlers
    Private Sub formLagu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.uiMode = "none"

        Panel2.Dock = DockStyle.Fill
        If My.Computer.FileSystem.FileExists(Path.Combine(Application.StartupPath, "autosave.txt")) Then
            lstLagu.Items.Clear()
            Dim line As String
            Using reader As New StreamReader(Path.Combine(Application.StartupPath, "autosave.txt"))
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
        Using writer As New StreamWriter(Path.Combine(Application.StartupPath, "autosave.txt"))
            For Each item As ListViewItem In lstLagu.Items
                writer.WriteLine(item.Tag.ToString())
            Next
        End Using
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            playSong()
        Else
            pauseSong()
        End If
    End Sub

    Private Sub AddFileToListView(ByVal filePath As String)
        Dim file As TagLib.File = Nothing
        Try
            file = TagLib.File.Create(filePath)
            Dim item As New ListViewItem()
            item.Text = If(file.Tag.Title, Path.GetFileNameWithoutExtension(filePath))
            item.SubItems.Add(String.Join(", ", file.Tag.Performers))
            item.SubItems.Add(file.Tag.Album)
            item.SubItems.Add(file.Properties.Duration.ToString("mm\:ss"))
            item.Tag = filePath ' Save file path for playback
            lstLagu.Items.Add(item)

        Catch ex As Exception
            MessageBox.Show($"Error reading metadata for file {Path.GetFileName(filePath)}")

        Finally
            If file IsNot Nothing Then
                file.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        OpenFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            For Each lagu As String In OpenFileDialog1.FileNames
                AddFileToListView(lagu)
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
        pauseSong()
        playNewSong()
    End Sub

    Private Sub btnShuffle_Click(sender As Object, e As EventArgs) Handles btnShuffle.Click
        ShuffleSong()
    End Sub

    Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click
        LoopSong()
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

    Private Sub lstLagu_DragEnter(sender As Object, e As DragEventArgs) Handles lstLagu.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Dim allFilesValid As Boolean = True
            For Each file As String In files
                If Not file.ToLower().EndsWith(".mp3") Then
                    allFilesValid = False
                    Exit For
                End If
            Next
            If allFilesValid Then
                e.Effect = DragDropEffects.Copy
            Else
                MsgBox("Please only drop files with the .mp3 extension.")
                e.Effect = DragDropEffects.None
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub lstLagu_DragDrop(sender As Object, e As DragEventArgs) Handles lstLagu.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            For Each lagu As String In files
                AddFileToListView(lagu)
            Next
        End If
    End Sub

    Private Sub btnFloating_Click(sender As Object, e As EventArgs) Handles btnFloating.Click
        If floatingWindow.Visible Then
            floatingWindow.Dispose()
        Else
            floatingWindow.Show()
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    'Buat timer text slider
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.title.Length > 12 Then
            If lblCurrentSong.Text.Length > 12 Then
                'Add more text behind
                lblCurrentSong.Text &= " ** " & Me.title
            End If
            lblCurrentSong.Text = Me.lblCurrentSong.Text.Substring(1, Me.lblCurrentSong.Text.Length - 1)
            currentindex += 1
            If floatingWindow.Visible Then
                floatingWindow.lblCurrentSong.Text = lblCurrentSong.Text
            End If
        End If
    End Sub

    'Buat Timer per lagu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.currentDuration < Me.duration Then
            barLagu.Value = currentDuration
            lblDurasiSekarang.Text = AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString
            currentDuration = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        End If
    End Sub

    'If songs end then .. 
    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        Select Case AxWindowsMediaPlayer1.playState
            Case WMPLib.WMPPlayState.wmppsMediaEnded
                nextSong()
            Case WMPLib.WMPPlayState.wmppsReady
                If AxWindowsMediaPlayer1.Ctlcontrols.currentItem IsNot Nothing Then
                    playSong()
                End If
        End Select
    End Sub

    Private Sub barLagu_Scroll(sender As Object, e As EventArgs) Handles barLagu.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = barLagu.Value
    End Sub

    Private Sub lstLagu_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lstLagu.ColumnClick
        For Each column As ColumnHeader In lstLagu.Columns
            column.Text = column.Text.Split(" ")(0)
        Next

        If lstLagu.Sorting = SortOrder.Ascending Then
            lstLagu.Sorting = SortOrder.Descending
            If lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text & " ▲" Then
                lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text.Replace(" ▲", "") & " ▼"
            Else
                lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text.Replace(" ▲", "").Replace(" ▼", "")
            End If
            lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text & " ▼"
        Else
            lstLagu.Sorting = SortOrder.Ascending
            If lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text & " ▼" Then
                lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text.Replace(" ▼", "") & " ▲"
            Else
                lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text.Replace(" ▲", "").Replace(" ▼", "")
            End If
            lstLagu.Columns(e.Column).Text = lstLagu.Columns(e.Column).Text & " ▲"
        End If

        lstLagu.ListViewItemSorter = New ListViewItemComparer(e.Column, lstLagu.Sorting)
        lstLagu.Sort()
    End Sub

    Private Class ListViewItemComparer
        Implements IComparer

        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, order As SortOrder)
            col = column
            Me.order = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim returnVal As Integer = -1

            If IsNumeric(CType(x, ListViewItem).SubItems(col).Text) AndAlso IsNumeric(CType(y, ListViewItem).SubItems(col).Text) Then
                'Numeric
                returnVal = Val(CType(x, ListViewItem).SubItems(col).Text).CompareTo(Val(CType(y, ListViewItem).SubItems(col).Text))
            Else
                'String
                returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
            End If

            'Descending.
            If order = SortOrder.Descending Then
                returnVal *= -1
            End If

            Return returnVal
        End Function
    End Class

    Private Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        If timerWindow.Visible() Then
            timerWindow.Close()
        Else
            timerWindow.Show()
        End If
    End Sub

    Private Sub timerCountdown_Tick(sender As Object, e As EventArgs) Handles timerCountdown.Tick
        If countdownTime.TotalSeconds > 0 Then
            countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1))
            timerWindow.lblCountdown.Text = countdownTime.ToString("hh\:mm\:ss")
            lblTimerCountDown.Text = "Timer : " + countdownTime.ToString("hh\.mm\.ss")
        Else
            timerCountdown.Stop()
            Application.Exit()
        End If
    End Sub

    Public Sub SetCountdown(hours As Integer, minutes As Integer)
        countdownTime = New TimeSpan(hours, minutes, 0)
        timerWindow.lblCountdown.Text = countdownTime.ToString("hh\:mm\:ss")
        lblTimerCountDown.Text = "Timer : " + countdownTime.ToString("hh\.mm\.ss")
        timerCountdown.Start()
    End Sub

    Private Sub BarVolume_Scroll(sender As Object, e As EventArgs) Handles BarVolume.Scroll
        AxWindowsMediaPlayer1.settings.volume = BarVolume.Value
        If BarVolume.Value > 50 Then
            picVolume.Image = My.Resources.medium_volume
        ElseIf BarVolume.Value > 0 Then
            picVolume.Image = My.Resources.low_volume
        Else
            picVolume.Image = My.Resources.no_volume
        End If
    End Sub
End Class