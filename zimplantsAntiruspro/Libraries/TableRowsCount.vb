Module TableRowsCount

    'telthemweb library 
    'visit https://wwww.telthemweb.co.zw
    '+263 774 914 150


    Public Sub LoadData(ByVal obj As Object, ByVal param As String)
        Try
            con.Open()
            dReader = cmd.ExecuteReader()
            Select Case param
                Case "Subscribers"
                    obj.Rows.Clear()
                    Dim i As Integer = 0
                    Do While dReader.Read = True
                        i = i + 1
                        obj.Rows.Add(i, dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6))
                    Loop



            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da.Dispose()
            con.Close()
        End Try
        con.Close()
    End Sub
    Public Sub fillTable(ByVal dtgrd As Object, ByVal design As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable
            Select Case design
                Case "defaults"
                    dtgrd.Columns(0).Visible = False
                    dtgrd.Columns(1).Visible = False
                    dtgrd.Columns(2).Visible = False
            End Select
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con.Close()
    End Sub
End Module
