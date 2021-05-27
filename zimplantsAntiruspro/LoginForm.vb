Public Class LoginForm
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUser.Text = "" Then
            MsgBox("E-mail Address is required", MsgBoxStyle.Critical)

        ElseIf txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)

        Else
            sql = "SELECT * FROM `members` WHERE `email`='" & txtUser.Text & "' AND `password`='" & txtPass.Text & "' "
            findthis(sql)

            If GetNumRows() = 1 Then
                MsgBox("You loggged in successfully", MsgBoxStyle.Information)
                LoadSingleResult("login")
                txtPass.Text = ""
                txtUser.Text = ""
            Else
                MsgBox("Username or Passwrord is not correct, Please try again!!", MsgBoxStyle.Critical)
                txtPass.Text = ""
                txtUser.Text = ""
            End If

        End If

    End Sub
End Class