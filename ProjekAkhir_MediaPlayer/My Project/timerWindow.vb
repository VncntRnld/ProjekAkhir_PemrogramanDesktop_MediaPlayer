Public Class timerWindow
    Private Sub btnJamPlus_Click(sender As Object, e As EventArgs) Handles btnJamPlus.Click
        Dim hours As Integer = Integer.Parse(txtJam.Text)
        hours = (hours + 1) Mod 24
        txtJam.Text = hours.ToString("D2")
    End Sub
    Private Sub btnJamMin_Click(sender As Object, e As EventArgs) Handles btnJamMin.Click
        Dim hours As Integer = Integer.Parse(txtJam.Text)
        hours = (hours - 1 + 24) Mod 24
        txtJam.Text = hours.ToString("D2")
    End Sub

    Private Sub btnMenitPlus_Click(sender As Object, e As EventArgs) Handles btnMenitPlus.Click
        Dim minutes As Integer = Integer.Parse(txtMenit.Text)
        minutes = (minutes + 1) Mod 60
        txtMenit.Text = minutes.ToString("D2")
    End Sub

    Private Sub btnMenitMin_Click(sender As Object, e As EventArgs) Handles btnMenitMin.Click
        Dim minutes As Integer = Integer.Parse(txtMenit.Text)
        minutes = (minutes - 1 + 60) Mod 60
        txtMenit.Text = minutes.ToString("D2")
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim hours As Integer = Integer.Parse(txtJam.Text)
        Dim minutes As Integer = Integer.Parse(txtMenit.Text)
        formLagu.SetCountdown(hours, minutes)
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        formLagu.timerCountdown.Stop()

        txtJam.Text = "00"
        txtMenit.Text = "00"
        lblCountdown.Text = "00:00:00"
        formLagu.lblTimerCountDown.Text = "Timer : 00.00.00"
    End Sub
End Class