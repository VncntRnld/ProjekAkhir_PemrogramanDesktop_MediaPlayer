﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblCurrentSong = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnLoop = New System.Windows.Forms.PictureBox()
        Me.btnShuffle = New System.Windows.Forms.PictureBox()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.PictureBox()
        Me.lblDurasiSekarang = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.barLagu = New System.Windows.Forms.TrackBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTimerCountDown = New System.Windows.Forms.Label()
        Me.btnTimer = New System.Windows.Forms.PictureBox()
        Me.picVolume = New System.Windows.Forms.PictureBox()
        Me.btnFloating = New System.Windows.Forms.PictureBox()
        Me.BarVolume = New System.Windows.Forms.TrackBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCurrentSinger = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.btnLoop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnShuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barLagu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.btnTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnFloating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Controls.Add(Me.btnHapus)
        Me.Panel4.Controls.Add(Me.btnTambah)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(0, 28)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(201, 409)
        Me.Panel4.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.wave_sound
        Me.PictureBox1.Location = New System.Drawing.Point(51, 57)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 98)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnHapus
        '
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(33, 322)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(0)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(135, 38)
        Me.btnHapus.TabIndex = 4
        Me.btnHapus.Text = "Delete Song"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.Color.White
        Me.btnTambah.Location = New System.Drawing.Point(33, 263)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(135, 38)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Add Song"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'lblCurrentSong
        '
        Me.lblCurrentSong.AutoSize = True
        Me.lblCurrentSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSong.ForeColor = System.Drawing.Color.White
        Me.lblCurrentSong.Location = New System.Drawing.Point(164, 78)
        Me.lblCurrentSong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentSong.MaximumSize = New System.Drawing.Size(270, 35)
        Me.lblCurrentSong.Name = "lblCurrentSong"
        Me.lblCurrentSong.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrentSong.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 437)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1216, 208)
        Me.Panel1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnLoop)
        Me.Panel6.Controls.Add(Me.btnShuffle)
        Me.Panel6.Controls.Add(Me.lblDurasi)
        Me.Panel6.Controls.Add(Me.btnPrev)
        Me.Panel6.Controls.Add(Me.lblDurasiSekarang)
        Me.Panel6.Controls.Add(Me.btnPlay)
        Me.Panel6.Controls.Add(Me.btnNext)
        Me.Panel6.Controls.Add(Me.barLagu)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(330, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(556, 208)
        Me.Panel6.TabIndex = 12
        '
        'btnLoop
        '
        Me.btnLoop.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLoop.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.offloop
        Me.btnLoop.Location = New System.Drawing.Point(116, 83)
        Me.btnLoop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(36, 37)
        Me.btnLoop.TabIndex = 9
        Me.btnLoop.TabStop = False
        '
        'btnShuffle
        '
        Me.btnShuffle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnShuffle.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.offshuffle1
        Me.btnShuffle.Location = New System.Drawing.Point(416, 83)
        Me.btnShuffle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShuffle.Name = "btnShuffle"
        Me.btnShuffle.Size = New System.Drawing.Size(36, 37)
        Me.btnShuffle.TabIndex = 8
        Me.btnShuffle.TabStop = False
        '
        'lblDurasi
        '
        Me.lblDurasi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurasi.ForeColor = System.Drawing.Color.White
        Me.lblDurasi.Location = New System.Drawing.Point(470, 142)
        Me.lblDurasi.Name = "lblDurasi"
        Me.lblDurasi.Size = New System.Drawing.Size(55, 22)
        Me.lblDurasi.TabIndex = 3
        Me.lblDurasi.Text = "00:00"
        '
        'btnPrev
        '
        Me.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrev.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.back24px
        Me.btnPrev.Location = New System.Drawing.Point(184, 83)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(36, 37)
        Me.btnPrev.TabIndex = 7
        Me.btnPrev.TabStop = False
        '
        'lblDurasiSekarang
        '
        Me.lblDurasiSekarang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDurasiSekarang.AutoSize = True
        Me.lblDurasiSekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDurasiSekarang.ForeColor = System.Drawing.Color.White
        Me.lblDurasiSekarang.Location = New System.Drawing.Point(34, 142)
        Me.lblDurasiSekarang.Name = "lblDurasiSekarang"
        Me.lblDurasiSekarang.Size = New System.Drawing.Size(55, 22)
        Me.lblDurasiSekarang.TabIndex = 3
        Me.lblDurasiSekarang.Text = "00:00"
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPlay.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.play32px
        Me.btnPlay.Location = New System.Drawing.Point(261, 77)
        Me.btnPlay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(48, 49)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNext.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.next24px
        Me.btnNext.Location = New System.Drawing.Point(344, 83)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(36, 37)
        Me.btnNext.TabIndex = 6
        Me.btnNext.TabStop = False
        '
        'barLagu
        '
        Me.barLagu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barLagu.Location = New System.Drawing.Point(94, 138)
        Me.barLagu.Margin = New System.Windows.Forms.Padding(0)
        Me.barLagu.Name = "barLagu"
        Me.barLagu.Size = New System.Drawing.Size(372, 69)
        Me.barLagu.TabIndex = 1
        Me.barLagu.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblTimerCountDown)
        Me.Panel5.Controls.Add(Me.btnTimer)
        Me.Panel5.Controls.Add(Me.picVolume)
        Me.Panel5.Controls.Add(Me.btnFloating)
        Me.Panel5.Controls.Add(Me.BarVolume)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(886, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(330, 208)
        Me.Panel5.TabIndex = 11
        '
        'lblTimerCountDown
        '
        Me.lblTimerCountDown.AutoSize = True
        Me.lblTimerCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerCountDown.ForeColor = System.Drawing.Color.White
        Me.lblTimerCountDown.Location = New System.Drawing.Point(18, 138)
        Me.lblTimerCountDown.Name = "lblTimerCountDown"
        Me.lblTimerCountDown.Size = New System.Drawing.Size(154, 25)
        Me.lblTimerCountDown.TabIndex = 12
        Me.lblTimerCountDown.Text = "Timer : 00.00.00"
        '
        'btnTimer
        '
        Me.btnTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnTimer.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.stopwatch
        Me.btnTimer.Location = New System.Drawing.Point(218, 83)
        Me.btnTimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTimer.Name = "btnTimer"
        Me.btnTimer.Size = New System.Drawing.Size(36, 37)
        Me.btnTimer.TabIndex = 11
        Me.btnTimer.TabStop = False
        '
        'picVolume
        '
        Me.picVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picVolume.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.low_volume
        Me.picVolume.Location = New System.Drawing.Point(22, 83)
        Me.picVolume.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picVolume.Name = "picVolume"
        Me.picVolume.Size = New System.Drawing.Size(36, 37)
        Me.picVolume.TabIndex = 10
        Me.picVolume.TabStop = False
        '
        'btnFloating
        '
        Me.btnFloating.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnFloating.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.mini_display
        Me.btnFloating.Location = New System.Drawing.Point(268, 83)
        Me.btnFloating.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFloating.Name = "btnFloating"
        Me.btnFloating.Size = New System.Drawing.Size(36, 37)
        Me.btnFloating.TabIndex = 9
        Me.btnFloating.TabStop = False
        '
        'BarVolume
        '
        Me.BarVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarVolume.Location = New System.Drawing.Point(57, 83)
        Me.BarVolume.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BarVolume.Maximum = 100
        Me.BarVolume.Name = "BarVolume"
        Me.BarVolume.Size = New System.Drawing.Size(156, 69)
        Me.BarVolume.TabIndex = 1
        Me.BarVolume.TickFrequency = 10
        Me.BarVolume.Value = 50
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblCurrentSinger)
        Me.Panel3.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblCurrentSong)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(330, 208)
        Me.Panel3.TabIndex = 10
        '
        'lblCurrentSinger
        '
        Me.lblCurrentSinger.AutoSize = True
        Me.lblCurrentSinger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSinger.ForeColor = System.Drawing.Color.White
        Me.lblCurrentSinger.Location = New System.Drawing.Point(164, 114)
        Me.lblCurrentSinger.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentSinger.MaximumSize = New System.Drawing.Size(270, 35)
        Me.lblCurrentSinger.Name = "lblCurrentSinger"
        Me.lblCurrentSinger.Size = New System.Drawing.Size(0, 25)
        Me.lblCurrentSinger.TabIndex = 10
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(22, 27)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(80, 80)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(164, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Now Playing: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.lstLagu)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 645)
        Me.Panel2.TabIndex = 0
        '
        'lstLagu
        '
        Me.lstLagu.AllowDrop = True
        Me.lstLagu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chTitle, Me.chArtists, Me.chAlbum, Me.chDuration})
        Me.lstLagu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstLagu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLagu.HideSelection = False
        Me.lstLagu.Location = New System.Drawing.Point(201, 28)
        Me.lstLagu.MultiSelect = False
        Me.lstLagu.Name = "lstLagu"
        Me.lstLagu.Size = New System.Drawing.Size(1015, 409)
        Me.lstLagu.TabIndex = 7
        Me.lstLagu.UseCompatibleStateImageBehavior = False
        Me.lstLagu.View = System.Windows.Forms.View.Details
        '
        'chTitle
        '
        Me.chTitle.Text = "Title"
        Me.chTitle.Width = 229
        '
        'chArtists
        '
        Me.chArtists.DisplayIndex = 2
        Me.chArtists.Text = "Artists"
        Me.chArtists.Width = 165
        '
        'chAlbum
        '
        Me.chAlbum.DisplayIndex = 3
        Me.chAlbum.Text = "Album"
        Me.chAlbum.Width = 254
        '
        'chDuration
        '
        Me.chDuration.DisplayIndex = 1
        Me.chDuration.Text = "Duration"
        Me.chDuration.Width = 90
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1216, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
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
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'timerCountdown
        '
        Me.timerCountdown.Interval = 1000
        '
        'formLagu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1216, 645)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1230, 674)
        Me.Name = "formLagu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3 Player"
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.btnLoop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnShuffle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barLagu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.btnTimer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnFloating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblCurrentSinger As Label
    Friend WithEvents btnFloating As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BarVolume As TrackBar
    Friend WithEvents picVolume As PictureBox
    Friend WithEvents btnLoop As PictureBox
    Friend WithEvents btnTimer As PictureBox
    Friend WithEvents lblTimerCountDown As Label
    Friend WithEvents timerCountdown As Timer
End Class
