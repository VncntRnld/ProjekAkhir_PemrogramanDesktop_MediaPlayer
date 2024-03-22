<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVideo
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVideo))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnShuffle = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.lblCurrentSong = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.lblDurasi = New System.Windows.Forms.Label()
        Me.lblDurasiSekarang = New System.Windows.Forms.Label()
        Me.barLagu = New System.Windows.Forms.TrackBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnShuffle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barLagu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 419)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 419)
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
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(146, 11)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(593, 246)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnShuffle)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.lblCurrentSong)
        Me.Panel1.Controls.Add(Me.btnChoose)
        Me.Panel1.Controls.Add(Me.btnPlay)
        Me.Panel1.Controls.Add(Me.lblDurasi)
        Me.Panel1.Controls.Add(Me.lblDurasiSekarang)
        Me.Panel1.Controls.Add(Me.barLagu)
        Me.Panel1.Location = New System.Drawing.Point(146, 269)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'btnChoose
        '
        Me.btnChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnChoose.FlatAppearance.BorderSize = 0
        Me.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.ForeColor = System.Drawing.Color.White
        Me.btnChoose.Location = New System.Drawing.Point(461, 8)
        Me.btnChoose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(125, 25)
        Me.btnChoose.TabIndex = 4
        Me.btnChoose.Text = "Choose Video"
        Me.btnChoose.UseVisualStyleBackColor = False
        '
        'FormVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 419)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormVideo"
        Me.Text = "FormVideo"
        Me.Panel2.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnShuffle As PictureBox
    Friend WithEvents btnPrev As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents lblCurrentSong As Label
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents lblDurasi As Label
    Friend WithEvents lblDurasiSekarang As Label
    Friend WithEvents barLagu As TrackBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnChoose As Button
End Class
