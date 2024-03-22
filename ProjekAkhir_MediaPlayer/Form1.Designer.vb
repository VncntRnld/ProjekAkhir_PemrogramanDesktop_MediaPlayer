<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLagu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLagu))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblCurrentSong = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShuffle = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.lblDurasiSekarang = New System.Windows.Forms.Label()
        Me.barLagu = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstLagu = New System.Windows.Forms.ListView()
        Me.chTitle = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chArtists = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAlbum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnShuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barLagu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel4.CausesValidation = False
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 392)
        Me.Panel4.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.wave_sound
        Me.PictureBox1.Location = New System.Drawing.Point(34, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(20, 259)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(95, 95)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(496, 8)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(90, 25)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Delete Song"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(398, 8)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(90, 25)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Add Song"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'lblCurrentSong
        '
        Me.lblCurrentSong.AutoSize = True
        Me.lblCurrentSong.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSong.ForeColor = System.Drawing.Color.White
        Me.lblCurrentSong.Location = New System.Drawing.Point(3, 3)
        Me.lblCurrentSong.Name = "lblCurrentSong"
        Me.lblCurrentSong.Size = New System.Drawing.Size(97, 23)
        Me.lblCurrentSong.TabIndex = 5
        Me.lblCurrentSong.Text = "Now PLaying: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnShuffle)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.lblCurrentSong)
        Me.Panel1.Controls.Add(Me.btnHapus)
        Me.Panel1.Controls.Add(Me.btnPlay)
        Me.Panel1.Controls.Add(Me.lblDurasi)
        Me.Panel1.Controls.Add(Me.btnTambah)
        Me.Panel1.Controls.Add(Me.lblDurasiSekarang)
        Me.Panel1.Controls.Add(Me.barLagu)
        Me.Panel1.Location = New System.Drawing.Point(146, 269)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(593, 135)
        Me.Panel1.TabIndex = 2
        '
        'btnShuffle
        '
        Me.btnShuffle.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.shuffle
        Me.btnShuffle.Location = New System.Drawing.Point(387, 55)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(24, 24)
        Me.btnShuffle.TabIndex = 8
        Me.btnShuffle.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.back24px
        Me.btnPrev.Location = New System.Drawing.Point(226, 55)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(24, 24)
        Me.btnPrev.TabIndex = 7
        Me.btnPrev.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.next24px
        Me.btnNext.Location = New System.Drawing.Point(334, 55)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 24)
        Me.btnNext.TabIndex = 6
        Me.btnNext.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.play32px
        Me.btnPlay.Location = New System.Drawing.Point(279, 51)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(32, 32)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.TabStop = False
        '
        'lblDurasi
        '
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurasi.ForeColor = System.Drawing.Color.White
        Me.lblDurasi.Location = New System.Drawing.Point(538, 90)
        Me.lblDurasi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDurasi.Name = "lblDurasi"
        Me.lblDurasi.Size = New System.Drawing.Size(38, 15)
        Me.lblDurasi.TabIndex = 3
        Me.lblDurasi.Text = "00:00"
        '
        'lblDurasiSekarang
        '
        Me.lblDurasiSekarang.AutoSize = True
        Me.lblDurasiSekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurasiSekarang.ForeColor = System.Drawing.Color.White
        Me.lblDurasiSekarang.Location = New System.Drawing.Point(20, 90)
        Me.lblDurasiSekarang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDurasiSekarang.Name = "lblDurasiSekarang"
        Me.lblDurasiSekarang.Size = New System.Drawing.Size(38, 15)
        Me.lblDurasiSekarang.TabIndex = 3
        Me.lblDurasiSekarang.Text = "00:00"
        '
        'barLagu
        '
        Me.barLagu.Location = New System.Drawing.Point(60, 90)
        Me.barLagu.Margin = New System.Windows.Forms.Padding(0)
        Me.barLagu.Name = "barLagu"
        Me.barLagu.Size = New System.Drawing.Size(476, 45)
        Me.barLagu.TabIndex = 1
        Me.barLagu.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lstLagu)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 419)
        Me.Panel2.TabIndex = 0
        '
        'lstLagu
        '
        Me.lstLagu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTitle, Me.chArtists, Me.chAlbum, Me.chDuration})
        Me.lstLagu.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLagu.HideSelection = False
        Me.lstLagu.Location = New System.Drawing.Point(144, 38)
        Me.lstLagu.Margin = New System.Windows.Forms.Padding(2)
        Me.lstLagu.Name = "lstLagu"
        Me.lstLagu.Size = New System.Drawing.Size(595, 215)
        Me.lstLagu.TabIndex = 7
        Me.lstLagu.UseCompatibleStateImageBehavior = False
        Me.lstLagu.View = System.Windows.Forms.View.Details
        '
        'chTitle
        '
        Me.chTitle.Text = "Title"
        Me.chTitle.Width = 189
        '
        'chArtists
        '
        Me.chArtists.DisplayIndex = 2
        Me.chArtists.Text = "Artists"
        Me.chArtists.Width = 170
        '
        'chAlbum
        '
        Me.chAlbum.DisplayIndex = 3
        Me.chAlbum.Text = "Album"
        Me.chAlbum.Width = 179
        '
        'chDuration
        '
        Me.chDuration.DisplayIndex = 1
        Me.chDuration.Text = "Duration"
        Me.chDuration.Width = 61
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(755, 27)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'formLagu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(755, 419)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formLagu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3 Player"
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnShuffle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barLagu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDurasi As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblDurasiSekarang As Label
    Friend WithEvents barLagu As TrackBar
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents lblCurrentSong As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents btnPrev As PictureBox
    Friend WithEvents lstLagu As ListView
    Friend WithEvents chTitle As ColumnHeader
    Friend WithEvents chArtists As ColumnHeader
    Friend WithEvents chAlbum As ColumnHeader
    Friend WithEvents chDuration As ColumnHeader
    Friend WithEvents btnShuffle As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
