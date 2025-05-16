Imports MySql.Data.MySqlClient

Module ModKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub Connect()
        Try
            conn = New MySqlConnection("server=localhost;user id=root;password=;database=kantin")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
