Public Class Register
    Dim todayday As DateTime = Format("yyyy-mmm-dd", Today)
    Dim timeof As DateTime = TimeOfDay
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtName.Text = "" Then
            MsgBox("Fullname is Required!")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Email Adresss is Required!", MsgBoxStyle.Critical)
        ElseIf txtPhone.Text = "" Then
            MsgBox("Phone Number is Required!", MsgBoxStyle.Critical)
        ElseIf txtCname.Text = "" Then
            MsgBox("Company name is Required!", MsgBoxStyle.Critical)
        ElseIf txtAddress.Text = "" Then
            MsgBox("Address is Required!", MsgBoxStyle.Critical)
        ElseIf txtPass.Text = "" Then
            MsgBox("Please select role Required!", MsgBoxStyle.Critical)
        Else
            issucess = insert("INSERT INTO `members` (`fullname`,`email`,`phone`, `cname`, `caddress`, `password`,`created_at`) 
VALUES ('" & txtName.Text & "','" & txtEmail.Text & "', '" & txtPhone.Text & "', '" & txtCname.Text & "', '" & txtAddress.Text & "', '" & txtPass.Text & "','" & todayday & "');")

            If issucess = True Then
                MsgBox("User has been registered successfully!", MsgBoxStyle.Information)
                txtName.Text = ""
                txtEmail.Text = ""
                txtPhone.Text = ""
                txtAddress.Text = ""
                txtPass.Text = ""
                LoginForm.Show()
                Me.Hide()


            Else
                MsgBox("No user has been registered!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class