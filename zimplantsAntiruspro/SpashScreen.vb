Public Class SpashScreen
    Private Sub SpashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        splashTimer.Enabled = True
    End Sub

    Private Sub splashTimer_Tick(sender As Object, e As EventArgs) Handles splashTimer.Tick

        ProgressLoader.Increment(+2)
        ProgressLoader.Maximum = (100)
        ProgressLoader.Minimum = (0)

        lblProCount.Text = ProgressLoader.Value & "%"

        If ProgressLoader.Value = 100 Then
            splashTimer.Stop()
            LoginForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
