Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports TagLib
Imports TagLib.Riff

Class formLagu

    'Current info storage
    Public Shared title As String
    Public Shared artist As String

    Dim album As String
    Dim year As String
    Dim duration As Integer, currentDuration As Integer

    Public Shared shuffle As Boolean = False
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
        If btnPlay.Text = "play" And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.URL = lstLagu.SelectedItems(0).Tag.ToString()

            'Text Now Playing
            CurrentInfo()

            Timer1.Enabled = True
            Timer2.Enabled = True
            btnPlay.Image = My.Resources.pause32px
            btnPlay.Text = "pause"
            If floatingWindow.Visible Then
                floatingWindow.btnPlay.Image = My.Resources.pause32px
                floatingWindow.btnPlay.Text = "pause"
            End If
        End If
    End Sub

    Public Sub playSong()
        If btnPlay.Text = "play" And lstLagu.SelectedItems.Count > 0 Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()

            Timer1.Enabled = True
            Timer2.Enabled = True
            btnPlay.Image = My.Resources.pause32px
            btnPlay.Text = "pause"
            If floatingWindow.Visible Then
                floatingWindow.btnPlay.Image = My.Resources.pause32px
                floatingWindow.btnPlay.Text = "pause"
            End If

        End If
    End Sub

    Public Sub stopSong()
        If btnPlay.Text = "pause" Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

            Timer1.Enabled = False
            Timer2.Enabled = False
            btnPlay.Image = My.Resources.play32px
            btnPlay.Text = "play"
            If floatingWindow.Visible Then
                floatingWindow.btnPlay.Image = My.Resources.play32px
                floatingWindow.btnPlay.Text = "play"
            End If
        End If
    End Sub

    Public Sub nextSong()
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

    Public Sub prevSong()
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

    Public Sub ShuffleSong() '!!!
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
        If My.Computer.FileSystem.FileExists(Path.Combine(Application.StartupPath, "autosave.txt")) Then
            lstLagu.Items.Clear()
            Dim line As String
            Using reader As New StreamReader(Path.Combine(Application.StartupPath, "autosave.txt"))
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Console.WriteLine(line)
                    AddFileToListView(line)
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
        If btnPlay.Text = "play" Then
            If shuffle Then
                ShuffleSong()
            End If
            playSong()
        Else
            stopSong()
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
        Catch
            If file IsNot Nothing Then
                file.Dispose()
            End If
        End Try
        lstLagu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
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
                        AddFileToListView(line)
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

        lstLagu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
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

    Private Sub btnFloating_Click(sender As Object, e As EventArgs) Handles btnFloating.Click
        floatingWindow.Show()
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
            currentDuration += 1
        Else
            stopSong()
            nextSong()
        End If
    End Sub

End Class