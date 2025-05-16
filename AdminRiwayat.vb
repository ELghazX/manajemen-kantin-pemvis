Imports MySql.Data.MySqlClient
Public Class AdminRiwayat
    Private Sub AdminRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
        LoadRiwayat()


        LblWelcome.Text = "Selamat Datang, " & currentUserName

        LblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
        If Not DgvRiwayat.Columns.Contains("Detail") Then
            Dim btnDetail As New DataGridViewButtonColumn
            btnDetail.HeaderText = "Detail"
            btnDetail.Name = "Detail"
            btnDetail.Text = "🔍"
            btnDetail.UseColumnTextForButtonValue = True
            DgvRiwayat.Columns.Add(btnDetail)
        End If
    End Sub
    Private Sub dgvRiwayat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRiwayat.CellContentClick
        If e.RowIndex >= 0 AndAlso DgvRiwayat.Columns(e.ColumnIndex).Name = "Detail" Then
            Dim idTransaksi As Integer = DgvRiwayat.Rows(e.RowIndex).Cells("id").Value
            Dim detailForm As New DetailTransaksi(idTransaksi)
            detailForm.ShowDialog()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles BoxCari.TextChanged
        LoadRiwayat(BoxCari.Text.Trim())
    End Sub
    Sub LoadRiwayat(Optional keyword As String = "")
        Connect()

        Dim query As String = "SELECT id, tanggal, total_bayar FROM transaksi"
        If keyword <> "" Then
            query &= " WHERE id LIKE @keyword OR tanggal LIKE @keyword OR total_bayar LIKE @keyword"
        End If
        query &= " ORDER BY tanggal DESC"

        Dim cmd As New MySqlCommand(query, conn)
        If keyword <> "" Then
            cmd.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
        End If

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DgvRiwayat.DataSource = dt
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim f As New Login()
        Me.Close()
        f.Show()
    End Sub

    Private Sub LblProduk_Click(sender As Object, e As EventArgs) Handles LblProduk.Click
        Dim f As New AdminProduk()
        Me.Close()
        f.Show()
    End Sub

    Private Sub LblKasir_Click(sender As Object, e As EventArgs) Handles LblKasir.Click

        Dim f As New AdminKasir()
        Me.Close()
        f.Show()

    End Sub



    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        Dim f = New AdminProduk()
        f.Show()
        Me.Close()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Dim f = New AdminKasir()
        f.Show()
        Me.Close()
    End Sub
End Class