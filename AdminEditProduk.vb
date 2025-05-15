Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class AdminEditProduk
    Private idProduk As Integer
    Public Sub New(ByVal id As Integer, ByVal nama As String, ByVal harga As String, ByVal status As String)
        InitializeComponent()
        idProduk = id
        BoxNama.Text = nama
        BoxHarga.Text = harga
        If status = "Aktif" Then
            RbAktif.Checked = True
        Else
            RbNonaktif.Checked = True
        End If
    End Sub
    Private Sub AdminEditProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If BoxNama.Text.Trim() = "" Or BoxHarga.Text.Trim() = "" Then
            MessageBox.Show("Nama dan Harga wajib diisi.")
            Exit Sub
        End If
        If isDuplikat(BoxNama.Text.Trim(), idProduk) Then
            MessageBox.Show("Nama produk sudah digunakan oleh produk lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(BoxHarga.Text, harga) Then
            MessageBox.Show("Harga harus angka.")
            Exit Sub
        End If

        Dim status As String = If(RbAktif.Checked, "Aktif", If(RbNonaktif.Checked, "Nonaktif", ""))

        If status = "" Then
            MessageBox.Show("Pilih status produk.")
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Apakah kamu yakin ingin menyimpan perubahan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            Exit Sub
        End If

        Try
            Connect()
            Dim cmd As New MySqlCommand("UPDATE produk SET nama = @nama, harga = @harga, status = @status WHERE id = @id", conn)
            cmd.Parameters.AddWithValue("@nama", BoxNama.Text.Trim())
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@id", idProduk)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim f As New AdminProduk()
            f.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal update produk: " & ex.Message)
        End Try
    End Sub

    'Private Sub btnHapus_Click(sender As Object, e As EventArgs)
    '    Dim konfirmasi = MessageBox.Show("Apakah kamu yakin ingin menghapus produk ini secara permanen?", "Hapus Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '    If konfirmasi = DialogResult.No Then
    '        Exit Sub
    '    End If
    '    Try
    '        Connect()
    '        Dim cmd As New MySqlCommand("DELETE FROM produk WHERE id = @id", conn)
    '        cmd.Parameters.AddWithValue("@id", idProduk)
    '        cmd.ExecuteNonQuery()

    '        MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Close()
    '    Catch ex As Exception
    '        MessageBox.Show("Gagal menghapus produk: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub BoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxNama.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Function isDuplikat(nama As String, Optional excludeId As Integer = -1) As Boolean
        Connect()

        Dim query As String = "SELECT COUNT(*) FROM produk WHERE nama = @nama"
        If excludeId <> -1 Then
            query &= " AND id <> @id"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama", nama)
        If excludeId <> -1 Then
            cmd.Parameters.AddWithValue("@id", excludeId)
        End If

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim f As New AdminProduk()
        f.Show()
        Me.Close()
    End Sub

End Class