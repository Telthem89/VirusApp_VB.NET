Imports MySql.Data.MySqlClient
Module TablesQuery


    Public Sub findthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
        con.Close()
    End Sub
    Public Sub LoadSingleResult(ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param

                Case "login"
                    Do While dReader.Read = True

                        ACCOUNT_NAME = dReader("fullname")
                        ACCOUNT_USERNAME = dReader("email")
                        ACCOUNT_TYPE = dReader("user_role")
                        ACCOUNT_ID = dReader("id")

                        If ACCOUNT_TYPE = "Administrator" Then
                            Dashboard.btnLogout.Text = ACCOUNT_NAME
                            Dashboard.lblUserRole.Text = "ADMIN VERSION"
                            Dashboard.lblUserRole.BackColor = Color.Green
                            Dashboard.lblUserRole.ForeColor = Color.White
                            Dashboard.Show()
                            LoginForm.Hide()

                        ElseIf ACCOUNT_TYPE = "Member" Then

                            Dashboard.btnLogout.Text = ACCOUNT_NAME
                            Dashboard.lblUserRole.Text = "TRIAL VERSION"
                            Dashboard.lblUserRole.BackColor = Color.Red
                            Dashboard.lblUserRole.ForeColor = Color.White
                            Dashboard.btnSubscribe.Visible = False

                            Dashboard.Show()
                            LoginForm.Hide()

                        Else
                            MsgBox("You don't have an account", MsgBoxStyle.Exclamation)
                        End If
                    Loop
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            con.Close()
            da.Dispose()
        End Try
        con.Close()
    End Sub
End Module
