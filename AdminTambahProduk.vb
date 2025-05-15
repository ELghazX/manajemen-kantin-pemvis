Imports MySql.Data.MySqlClient

Public Class AdminTambahProduk
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RbAktif.CheckedChanged

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Dim f = New AdminProduk()
        Me.Close()
        f.Show()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If BoxNama.Text.Trim() = "" Then
            MessageBox.Show("Nama produk harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxNama.Focus()
            Exit Sub
        End If

        If isDuplikat(BoxNama.Text.Trim()) Then
            MessageBox.Show("Nama produk sudah digunakan oleh produk lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BoxHarga.Text.Trim() = "" Then
            MessageBox.Show("Harga produk harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxHarga.Focus()
            Exit Sub
        End If

        Dim harga As Decimal
        If Not Decimal.TryParse(BoxHarga.Text, harga) Then
            MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxHarga.Focus()
            Exit Sub
        End If

        If harga <= 0 Then
            MessageBox.Show("Harga tidak boleh nol atau kurang!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BoxHarga.Focus()
            Exit Sub
        End If

        Dim status As String = ""
        If rbAktif.Checked Then
            status = "Aktif"
        ElseIf rbNonaktif.Checked Then
            status = "Nonaktif"
        Else
            MessageBox.Show("Silakan pilih status produk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim konfirmasi = MessageBox.Show("Apakah kamu yakin ingin menambahkan produk?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.No Then
            Exit Sub
        End If

        Try
            Connect()
            Dim cmd As New MySqlCommand("INSERT INTO produk (nama, harga, status) VALUES (@nama, @harga, @status)", conn)
            cmd.Parameters.AddWithValue("@nama", BoxNama.Text.Trim())
            cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BoxNama.Clear()
            BoxHarga.Clear()
            RbAktif.Checked = False
            RbNonaktif.Checked = False

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BoxHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Function isDuplikat(nama As String) As Boolean
        Connect()

        Dim query As String = "SELECT COUNT(*) FROM produk WHERE nama = @nama"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama", nama)

        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        Return count > 0
    End Function

    Private Sub AdminTambahProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormFix(Me)
    End Sub
End Class