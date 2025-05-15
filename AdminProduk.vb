Imports MySql.Data.MySqlClient
Public Class AdminProduk
    Sub LoadProduk(Optional keyword As String = "")
        Connect()
        Dim query As String = "SELECT id, nama, harga, status FROM produk"
        If keyword <> "" Then
            query &= " WHERE 
                    id LIKE @key OR 
                    nama LIKE @key OR 
                    harga LIKE @key OR 
                    status LIKE @key"
        End If

        query &= " ORDER BY id ASC"

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
            Dim btnEdit As New DataGridViewButtonColumn
            btnEdit.HeaderText = "Aksi"
            btnEdit.Name = "Aksi"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DgvProduk.Columns.Add(btnEdit)
        End If
    End Sub
    Private Sub AdminProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
        LblWelcome.Text = "Selamat Datang, " & currentUserName
        LblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
        LoadProduk()
    End Sub
    Private Sub DgvProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProduk.CellContentClick
        If e.RowIndex >= 0 AndAlso DgvProduk.Columns(e.ColumnIndex).Name = "Aksi" Then
            Dim row = DgvProduk.Rows(e.RowIndex)
            Dim idProduk = row.Cells("id").Value
            Dim nama = row.Cells("nama").Value.ToString()
            Dim harga = row.Cells("harga").Value.ToString()
            Dim status = row.Cells("status").Value.ToString()

            Dim formEdit As New AdminEditProduk(idProduk, nama, harga, status)
            Me.Close()
            formEdit.Show()

        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs)
        Dim f As New Login
        Close
        f.Show
    End Sub

    Private Sub LblProduk_Click(sender As Object, e As EventArgs)
        Dim f As New AdminProduk
        Close()
        f.Show()
    End Sub

    Private Sub LblKasir_Click(sender As Object, e As EventArgs) Handles LblKasir.Click

        Dim f As New AdminKasir()
        Me.Close()
        f.Show()

    End Sub

    Private Sub LblRiwayat_Click(sender As Object, e As EventArgs) Handles LblRiwayat.Click
        Dim f As New AdminRiwayat()
        Me.Close()
        f.Show()
    End Sub


    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim f As New AdminTambahProduk()
        Me.Close()
        f.Show()
    End Sub

    Private Sub BoxCari_TextChanged(sender As Object, e As EventArgs) Handles BoxCari.TextChanged
        LoadProduk(BoxCari.Text.Trim())
    End Sub

    Private Sub BtnKeluar_Click_1(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim f As New Login()
        Me.Close()
        f.Show()
    End Sub
End Class