Imports MySql.Data.MySqlClient

Public Class Kasir_pesanan
    Dim dtKeranjang As New DataTable
    Dim totalBayar As Decimal = 0
    Sub LoadProduk(Optional keyword As String = "")
        Connect()

        Dim query As String = "SELECT id, nama, harga FROM produk WHERE status = 'Aktif'"
        If keyword <> "" Then
            query &= " AND (nama LIKE @key)"
        End If

        Dim cmd As New MySqlCommand(query, conn)
        If keyword <> "" Then
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
        End If

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DgvProduk.Columns.Clear()
        DgvProduk.DataSource = dt

        If Not DgvProduk.Columns.Contains("Aksi") Then
            Dim btnTambah As New DataGridViewButtonColumn
            btnTambah.HeaderText = "Aksi"
            btnTambah.Name = "Aksi"
            btnTambah.Text = "+"
            btnTambah.UseColumnTextForButtonValue = True
            DgvProduk.Columns.Add(btnTambah)
        End If
    End Sub

    Private Sub Kasir_pesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
        LoadProduk()
        LblWelcome.Text = "Selamat Datang, " & currentUserName
        LblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))

        LblTotal.Text = "0"

        dtKeranjang.Columns.Add("id_produk")
        dtKeranjang.Columns.Add("nama")
        dtKeranjang.Columns.Add("harga")
        dtKeranjang.Columns.Add("jumlah")
        dtKeranjang.Columns.Add("subtotal")
        DgvKeranjang.DataSource = dtKeranjang

        'Dim da As New MySqlDataAdapter("SELECT * FROM produk WHERE status='Aktif'", conn)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'DgvProduk.DataSource = dt

        'If Not DgvProduk.Columns.Contains("Aksi") Then
        '    Dim btnTambah As New DataGridViewButtonColumn
        '    btnTambah.HeaderText = "Aksi"
        '    btnTambah.Name = "Aksi"
        '    btnTambah.Text = "+"
        '    btnTambah.UseColumnTextForButtonValue = True
        '    DgvProduk.Columns.Add(btnTambah)
        'End If

        If Not DgvKeranjang.Columns.Contains("AksiHapus") Then
            Dim btnHapus As New DataGridViewButtonColumn
            btnHapus.HeaderText = "Aksi"
            btnHapus.Name = "AksiHapus"
            btnHapus.Text = "🗑️"
            btnHapus.UseColumnTextForButtonValue = True
            DgvKeranjang.Columns.Add(btnHapus)
        End If
    End Sub

    Private Sub DgvProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProduk.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DgvProduk.Columns("Aksi").Index Then
            Dim row = DgvProduk.Rows(e.RowIndex)
            Dim id = row.Cells("id").Value
            Dim nama = row.Cells("nama").Value.ToString()
            Dim harga = Convert.ToDecimal(row.Cells("harga").Value)

            Dim found As Boolean = False
            For Each r As DataRow In dtKeranjang.Rows
                If r("id_produk").ToString() = id.ToString() Then
                    r("jumlah") = CInt(r("jumlah")) + 1
                    r("subtotal") = CDec(r("harga")) * CInt(r("jumlah"))
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                Dim newRow As DataRow = dtKeranjang.NewRow()
                newRow("id_produk") = id
                newRow("nama") = nama
                newRow("harga") = harga
                newRow("jumlah") = 1
                newRow("subtotal") = harga
                dtKeranjang.Rows.Add(newRow)
            End If
            HitungTotalBayar()
        End If
    End Sub

    Private Sub DgvKeranjang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvKeranjang.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DgvKeranjang.Columns("AksiHapus").Index Then
            dtKeranjang.Rows.RemoveAt(e.RowIndex)
            HitungTotalBayar()
        End If
    End Sub

    Private Sub HitungTotalBayar()
        totalBayar = 0
        For Each r As DataRow In dtKeranjang.Rows
            totalBayar += CDec(r("subtotal"))
        Next
        LblTotal.Text = totalBayar.ToString("N0")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        dtKeranjang.Clear()
        HitungTotalBayar()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim f As New KasirRiwayat()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim f As New Login()
        f.Show()
        Me.Close()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        If dtKeranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Connect()

            Dim cmd As New MySqlCommand("INSERT INTO transaksi (user_id, total_bayar) VALUES (@user, @total)", conn)
            cmd.Parameters.AddWithValue("@user", currentUserId)
            cmd.Parameters.AddWithValue("@total", totalBayar)
            cmd.ExecuteNonQuery()

            Dim transaksiId As Integer = cmd.LastInsertedId

            For Each r As DataRow In dtKeranjang.Rows
                Dim cmdDetail As New MySqlCommand("INSERT INTO detail_transaksi (transaksi_id, produk_id, jumlah, subtotal) VALUES (@tid, @pid, @jumlah, @subtotal)", conn)
                cmdDetail.Parameters.AddWithValue("@tid", transaksiId)
                cmdDetail.Parameters.AddWithValue("@pid", r("id_produk"))
                cmdDetail.Parameters.AddWithValue("@jumlah", r("jumlah"))
                cmdDetail.Parameters.AddWithValue("@subtotal", r("subtotal"))
                cmdDetail.ExecuteNonQuery()
            Next

            MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim konfirmasiCetak = MessageBox.Show("Ingin mencetak struk?", "Cetak Struk", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasiCetak = DialogResult.Yes Then
                PreviewStruk.Document = PrintStruk
                PreviewStruk.ShowDialog()
            End If

            dtKeranjang.Clear()
            HitungTotalBayar()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintStruk_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintStruk.PrintPage
        Dim fontJudul As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim fontIsi As New Font("Segoe UI", 10)
        Dim y As Integer = 40

        e.Graphics.DrawString("Struk Pembelian - MyKantinku", fontJudul, Brushes.Black, 20, y)
        y += 40

        e.Graphics.DrawString("Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontIsi, Brushes.Black, 20, y)
        y += 30

        e.Graphics.DrawString("Kasir: " & currentUserName, fontIsi, Brushes.Black, 20, y)
        y += 30

        e.Graphics.DrawString("==========================================", fontIsi, Brushes.Black, 20, y)
        y += 20

        For Each r As DataRow In dtKeranjang.Rows
            Dim nama As String = r("nama").ToString()
            Dim jumlah As Integer = CInt(r("jumlah"))
            Dim harga As Decimal = CDec(r("harga"))
            Dim subtotal As Decimal = CDec(r("subtotal"))

            Dim line As String = $"{nama,-15} x{jumlah}   @Rp{harga.ToString("N0")}   Rp{subtotal.ToString("N0")}"
            e.Graphics.DrawString(line, fontIsi, Brushes.Black, 20, y)
            y += 25
        Next
        y += 10
        e.Graphics.DrawString("==========================================", fontIsi, Brushes.Black, 20, y)
        y += 30

        e.Graphics.DrawString("Total Bayar: Rp" & totalBayar.ToString("N0"), fontIsi, Brushes.Black, 20, y)
        y += 30

        e.Graphics.DrawString("Terima kasih telah berbelanja!", fontIsi, Brushes.Black, 20, y)
    End Sub

    Private Sub BoxCari_TextChanged(sender As Object, e As EventArgs) Handles BoxCari.TextChanged
        LoadProduk(BoxCari.Text)
    End Sub

End Class
