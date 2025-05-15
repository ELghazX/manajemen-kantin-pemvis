Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class AdminEditKasir
    Private idUser As Integer

    Public Sub New(ByVal idUser As Integer, ByVal nama As String, ByVal email As String, ByVal password As String)
        InitializeComponent()
        Me.idUser = idUser
        BoxNama.Text = nama
        BoxEmail.Text = email
        BoxPassword.Text = password
    End Sub
    Function isDuplikat(email As String, Optional excludeId As Integer = -1) As Boolean
        Connect()

        Dim query As String = "SELECT COUNT(*) FROM user WHERE email = @email"
        If excludeId <> -1 Then
            query &= " AND id <> @id AND is_deleted <> 1"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@email", email)
        If excludeId <> -1 Then
            cmd.Parameters.AddWithValue("@id", excludeId)
        End If

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If BoxNama.Text.Trim() = "" Or BoxEmail.Text.Trim() = "" Then
            MessageBox.Show("Nama dan Email wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If isDuplikat(BoxEmail.Text.Trim(), idUser) Then
            MsgBox("Email sudah digunakan oleh kasir lain!", MsgBoxStyle.Critical, "Peringatan")
            BoxEmail.Focus()
            Exit Sub
        End If

        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not Regex.IsMatch(BoxEmail.Text.Trim(), emailPattern) Then
            MessageBox.Show("Format email tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxEmail.Focus()
            Exit Sub
        End If

        Connect()
        Dim cekCmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE email = @email AND id <> @id", conn)
        cekCmd.Parameters.AddWithValue("@email", BoxEmail.Text.Trim())
        cekCmd.Parameters.AddWithValue("@id", idUser)
        Dim ada As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())
        If ada > 0 Then
            MessageBox.Show("Email sudah digunakan oleh kasir lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Simpan perubahan kasir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim query As String
            Dim cmd As New MySqlCommand()

            If BoxPassword.Text.Trim() = "" Then
                query = "UPDATE user SET nama = @nama, email = @email WHERE id = @id"
            Else
                query = "UPDATE user SET nama = @nama, email = @email, password = @pass WHERE id = @id"
                cmd.Parameters.AddWithValue("@pass", BoxPassword.Text.Trim())
            End If

            cmd.CommandText = query
            cmd.Connection = conn
            cmd.Parameters.AddWithValue("@nama", BoxNama.Text.Trim())
            cmd.Parameters.AddWithValue("@email", BoxEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@id", idUser)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Perubahan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim f As New AdminKasir()
            f.Show()

        Catch ex As Exception
            MessageBox.Show("Gagal update kasir: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim konfirmasi = MessageBox.Show("Apakah kamu yakin ingin menghapus kasir ini secara permanen?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.No Then
            Exit Sub
        End If

        Try
            Connect()
            Dim cmd As New MySqlCommand("UPDATE user SET is_deleted = 1 WHERE id = @id AND role = 'kasir'", conn)
            cmd.Parameters.AddWithValue("@id", idUser)
            Dim hasil = cmd.ExecuteNonQuery()

            If hasil > 0 Then
                MessageBox.Show("Kasir berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim f As New AdminKasir()
                f.Show()
                Me.Close()
            Else
                MessageBox.Show("Kasir tidak ditemukan atau tidak dapat dihapus.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim f As New AdminKasir()
        Me.Close()
        f.Show()
    End Sub

End Class