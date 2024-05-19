<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class floatingWindow
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.lblCurrentSinger = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCurrentSong = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnMinimize)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnPlay)
        Me.Panel3.Controls.Add(Me.btnNext)
        Me.Panel3.Controls.Add(Me.lblCurrentSinger)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.lblCurrentSong)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(342, 113)
        Me.Panel3.TabIndex = 11
        '
        'btnClose
        '
        Me.btnClose.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.close
        Me.btnClose.Location = New System.Drawing.Point(319, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(16, 16)
        Me.btnClose.TabIndex = 13
        Me.btnClose.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.play32px
        Me.btnPlay.Location = New System.Drawing.Point(217, 43)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(32, 32)
        Me.btnPlay.TabIndex = 11
        Me.btnPlay.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.next24px
        Me.btnNext.Location = New System.Drawing.Point(264, 47)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(24, 24)
        Me.btnNext.TabIndex = 12
        Me.btnNext.TabStop = False
        '
        'lblCurrentSinger
        '
        Me.lblCurrentSinger.AutoSize = True
        Me.lblCurrentSinger.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSinger.ForeColor = System.Drawing.Color.White
        Me.lblCurrentSinger.Location = New System.Drawing.Point(22, 66)
        Me.lblCurrentSinger.MaximumSize = New System.Drawing.Size(140, 23)
        Me.lblCurrentSinger.Name = "lblCurrentSinger"
        Me.lblCurrentSinger.Size = New System.Drawing.Size(0, 23)
        Me.lblCurrentSinger.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Now Playing: "
        '
        'lblCurrentSong
        '
        Me.lblCurrentSong.AutoSize = True
        Me.lblCurrentSong.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentSong.ForeColor = System.Drawing.Color.White
        Me.lblCurrentSong.Location = New System.Drawing.Point(22, 43)
        Me.lblCurrentSong.MaximumSize = New System.Drawing.Size(140, 23)
        Me.lblCurrentSong.Name = "lblCurrentSong"
        Me.lblCurrentSong.Size = New System.Drawing.Size(0, 23)
        Me.lblCurrentSong.TabIndex = 5
        '
        'btnMinimize
        '
        Me.btnMinimize.Image = Global.ProjekAkhir_MediaPlayer.My.Resources.Resources.minimize_sign
        Me.btnMinimize.Location = New System.Drawing.Point(294, 11)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnMinimize.TabIndex = 14
        Me.btnMinimize.TabStop = False
        '
        'floatingWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 113)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 113)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 113)
        Me.Name = "floatingWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "floatingWindow"
        Me.TopMost = True
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCurrentSinger As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCurrentSong As Label
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents btnMinimize As PictureBox
End Class
