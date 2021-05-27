Imports MySql.Data.MySqlClient
Module Database


    Public Function myconn() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;SslMode=none;database=zimplats")

    End Function
End Module
