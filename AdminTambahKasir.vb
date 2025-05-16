Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class AdminTambahKasir

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If BoxNama.Text.Trim() = "" Or BoxEmail.Text.Trim() = "" Or BoxPassword.Text = "" Or BoxKonfirmasi.Text = "" Then
            MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim patternEmail As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not Regex.IsMatch(BoxEmail.Text.Trim(), patternEmail) Then
            MessageBox.Show("Format email tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxEmail.Focus()
            Exit Sub
        End If

        If BoxPassword.Text <> BoxKonfirmasi.Text Then
            MessageBox.Show("Password dan konfirmasi tidak sama!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BoxPassword.Text.Length < 6 Then
            MessageBox.Show("Password minimal 6 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Connect()
        Dim cekEmailCmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE email = @email", conn)
        cekEmailCmd.Parameters.AddWithValue("@email", BoxEmail.Text.Trim())
        Dim jumlah As Integer = Convert.ToInt32(cekEmailCmd.ExecuteScalar())
        If jumlah > 0 Then
            MessageBox.Show("Email sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm = MessageBox.Show("Apakah kamu yakin ingin menambahkan kasir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.No Then Exit Sub

        Try
            Dim simpanCmd As New MySqlCommand("INSERT INTO user (nama, email, password, role) VALUES (@nama, @email, @pass, 'kasir')", conn)
            simpanCmd.Parameters.AddWithValue("@nama", BoxNama.Text.Trim())
            simpanCmd.Parameters.AddWithValue("@email", BoxEmail.Text.Trim())
            simpanCmd.Parameters.AddWithValue("@pass", BoxPassword.Text.Trim())
            simpanCmd.ExecuteNonQuery()

            MessageBox.Show("Kasir berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BoxNama.Clear()
            BoxEmail.Clear()
            BoxPassword.Clear()
            BoxKonfirmasi.Clear()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan kasir: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim f = New AdminKasir()
        f.Show()
        Me.Close()
    End Sub

    Private Sub AdminTambahKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class