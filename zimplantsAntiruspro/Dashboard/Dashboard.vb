Public Class Dashboard
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Application.Exit()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        QuickScan.TopLevel = False
        DashboardMenu.Controls.Add(QuickScan)
        QuickScan.BringToFront()
        QuickScan.Show()
    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs)
        FullScan.TopLevel = False
        DashboardMenu.Controls.Add(FullScan)
        FullScan.BringToFront()
        FullScan.Show()
    End Sub



    Private Sub Label7_Click(sender As Object, e As EventArgs)
        customScan.TopLevel = False
        DashboardMenu.Controls.Add(customScan)
        customScan.BringToFront()
        customScan.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Selectdrive.TopLevel = False
        DashboardMenu.Controls.Add(Selectdrive)
        Selectdrive.BringToFront()
        Selectdrive.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSubscribe.Click
        Subscribers.TopLevel = False
        DashboardMenu.Controls.Add(Subscribers)
        Subscribers.BringToFront()
        Subscribers.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        QuickScan.TopLevel = False
        DashboardMenu.Controls.Add(QuickScan)
        QuickScan.BringToFront()
        QuickScan.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogout_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogout.MouseDown

    End Sub

    Private Sub Dashboard_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Dashboard_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Dashboard_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
End Class