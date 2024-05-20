<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class timerWindow
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnMenitMin = New System.Windows.Forms.Button()
        Me.btnJamMin = New System.Windows.Forms.Button()
        Me.btnMenitPlus = New System.Windows.Forms.Button()
        Me.btnJamPlus = New System.Windows.Forms.Button()
        Me.txtJam = New System.Windows.Forms.TextBox()
        Me.txtMenit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCountdown)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.btnMenitMin)
        Me.Panel1.Controls.Add(Me.btnJamMin)
        Me.Panel1.Controls.Add(Me.btnMenitPlus)
        Me.Panel1.Controls.Add(Me.btnJamPlus)
        Me.Panel1.Controls.Add(Me.txtJam)
        Me.Panel1.Controls.Add(Me.txtMenit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 255)
        Me.Panel1.TabIndex = 0
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.White
        Me.lblCountdown.Location = New System.Drawing.Point(446, 222)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(80, 22)
        Me.lblCountdown.TabIndex = 8
        Me.lblCountdown.Text = "00:00:00"
        '
        'btnReset
        '
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(354, 140)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(112, 42)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Linen
        Me.btnApply.FlatAppearance.BorderSize = 0
        Me.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.Location = New System.Drawing.Point(354, 77)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(112, 42)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Text = "Start"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnMenitMin
        '
        Me.btnMenitMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenitMin.Location = New System.Drawing.Point(188, 189)
        Me.btnMenitMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenitMin.Name = "btnMenitMin"
        Me.btnMenitMin.Size = New System.Drawing.Size(92, 55)
        Me.btnMenitMin.TabIndex = 5
        Me.btnMenitMin.Text = "-"
        Me.btnMenitMin.UseVisualStyleBackColor = True
        '
        'btnJamMin
        '
        Me.btnJamMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJamMin.Location = New System.Drawing.Point(38, 189)
        Me.btnJamMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnJamMin.Name = "btnJamMin"
        Me.btnJamMin.Size = New System.Drawing.Size(92, 55)
        Me.btnJamMin.TabIndex = 4
        Me.btnJamMin.Text = "-"
        Me.btnJamMin.UseVisualStyleBackColor = True
        '
        'btnMenitPlus
        '
        Me.btnMenitPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenitPlus.Location = New System.Drawing.Point(187, 12)
        Me.btnMenitPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMenitPlus.Name = "btnMenitPlus"
        Me.btnMenitPlus.Size = New System.Drawing.Size(92, 55)
        Me.btnMenitPlus.TabIndex = 3
        Me.btnMenitPlus.Text = "+"
        Me.btnMenitPlus.UseVisualStyleBackColor = True
        '
        'btnJamPlus
        '
        Me.btnJamPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJamPlus.Location = New System.Drawing.Point(38, 11)
        Me.btnJamPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnJamPlus.Name = "btnJamPlus"
        Me.btnJamPlus.Size = New System.Drawing.Size(92, 55)
        Me.btnJamPlus.TabIndex = 2
        Me.btnJamPlus.Text = "+"
        Me.btnJamPlus.UseVisualStyleBackColor = True
        '
        'txtJam
        '
        Me.txtJam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJam.Location = New System.Drawing.Point(39, 79)
        Me.txtJam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJam.MaxLength = 2
        Me.txtJam.Name = "txtJam"
        Me.txtJam.ReadOnly = True
        Me.txtJam.Size = New System.Drawing.Size(90, 98)
        Me.txtJam.TabIndex = 0
        Me.txtJam.Text = "00"
        '
        'txtMenit
        '
        Me.txtMenit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMenit.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMenit.Location = New System.Drawing.Point(188, 79)
        Me.txtMenit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMenit.MaxLength = 2
        Me.txtMenit.Name = "txtMenit"
        Me.txtMenit.ReadOnly = True
        Me.txtMenit.Size = New System.Drawing.Size(90, 98)
        Me.txtMenit.TabIndex = 1
        Me.txtMenit.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(136, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 81)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = ":"
        '
        'timerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 255)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 311)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 311)
        Me.Name = "timerWindow"
        Me.Text = "timerWindow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtJam As TextBox
    Friend WithEvents txtMenit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnJamPlus As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnMenitMin As Button
    Friend WithEvents btnJamMin As Button
    Friend WithEvents btnMenitPlus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCountdown As Label
End Class
