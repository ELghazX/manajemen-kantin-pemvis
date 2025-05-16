Imports MySql.Data.MySqlClient
Public Class AdminKasir
    Sub LoadKasir(Optional keyword As String = "")
        Connect()

        Dim query As String = "SELECT id, nama, email, password, role FROM user WHERE role = 'kasir' AND is_deleted = 0"
        If keyword <> "" Then
            query &= " AND (id LIKE @key OR nama LIKE @key OR email LIKE @key)"
        End If

        query &= " ORDER BY id ASC"

        Dim cmd As New MySqlCommand(query, conn)
        If keyword <> "" Then
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
        End If

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DgvKasir.Columns.Clear()
        DgvKasir.DataSource = dt

        If Not DgvKasir.Columns.Contains("Aksi") Then
            Dim btnEdit As New DataGridViewButtonColumn
            btnEdit.HeaderText = "Aksi"
            btnEdit.Name = "Aksi"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True
            DgvKasir.Columns.Add(btnEdit)
        End If
    End Sub

    Private Sub AdminKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
        Me.StartPosition = FormStartPosition.CenterScreen
        LblWelcome.Text = "Selamat Datang, " & currentUserName
        LblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
        LoadKasir()
    End Sub

    Private Sub DgvProduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvKasir.CellContentClick
        If e.RowIndex >= 0 AndAlso DgvKasir.Columns(e.ColumnIndex).Name = "Aksi" Then
            Dim row = DgvKasir.Rows(e.RowIndex)
            Dim idKasir = row.Cells("id").Value
            Dim nama = row.Cells("nama").Value.ToString()
            Dim email = row.Cells("email").Value.ToString()
            Dim password = row.Cells("password").Value.ToString()

            Dim formEdit As New AdminEditKasir(idKasir, nama, email, password)
            formEdit.Show()
            Me.Close()

        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim f = New Login()
        f.Show()
        Me.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim f As New AdminTambahKasir()
        Me.Close()
        f.Show()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Dim f As New AdminRiwayat()
        Me.Close()
        f.Show()
    End Sub

    Private Sub LblRiwayat_Click(sender As Object, e As EventArgs) Handles LblRiwayat.Click
        Dim f As New AdminRiwayat()
        Me.Close()
        f.Show()
    End Sub

    Private Sub LblKasir_Click(sender As Object, e As EventArgs) Handles LblKasir.Click
        Dim f As New AdminKasir()
        Me.Close()
        f.Show()
    End Sub

    Private Sub LblProduk_Click(sender As Object, e As EventArgs) Handles LblProduk.Click
        Dim f As New AdminProduk()
        Me.Close()
        f.Show()
    End Sub

    Private Sub BoxCari_TextChanged(sender As Object, e As EventArgs) Handles BoxCari.TextChanged
        LoadKasir(BoxCari.Text.Trim())
    End Sub


End Class