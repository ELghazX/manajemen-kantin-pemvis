Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub boxEmail_TextChanged(sender As Object, e As EventArgs) Handles BoxEmail.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = BoxEmail.Text.Trim()
        Dim password As String = BoxPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Email dan password tidak boleh kosong!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Connect()
            Dim query As String = "SELECT * FROM user WHERE email=@user AND password=@pass"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                currentUserId = dr("id")
                currentUserRole = dr("role").ToString()
                currentUserName = dr("nama").ToString()

                MessageBox.Show("Login berhasil sebagai " & currentUserRole, "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If currentUserRole = "admin" Then
                    Dim f As New AdminRiwayat()
                    f.Show()
                    Me.Hide()
                ElseIf currentUserRole = "kasir" Then
                    Dim f As New Kasir_pesanan()
                    f.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error saat login: " & ex.Message)
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
    End Sub
End Class
