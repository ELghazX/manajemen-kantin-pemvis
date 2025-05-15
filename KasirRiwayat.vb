Imports MySql.Data.MySqlClient

Public Class KasirRiwayat
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Dim f As New Login()
        f.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim f As New Kasir_pesanan()
        f.Show()
        Me.Close()
    End Sub

    Private Sub KasirRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormFix(Me)
        LblWelcome.Text = "Selamat Datang, " & currentUserName
        LblTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", New Globalization.CultureInfo("id-ID"))
        LoadRiwayat()
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
    Sub LoadRiwayat(Optional keyword As String = "")
        Connect()

        Dim query As String = "SELECT id, tanggal, total_bayar FROM transaksi WHERE user_id = @id"
        If keyword <> "" Then
            query &= " AND (id LIKE @key OR tanggal LIKE @key OR total_bayar LIKE @key)"
        End If
        query &= " ORDER BY tanggal DESC"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", currentUserId)
        If keyword <> "" Then
            cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
        End If

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DgvRiwayat.DataSource = dt
    End Sub

    Private Sub BoxCari_TextChanged(sender As Object, e As EventArgs) Handles BoxCari.TextChanged
        LoadRiwayat(BoxCari.Text)
    End Sub
End Class