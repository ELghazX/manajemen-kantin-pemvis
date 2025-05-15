Imports MySql.Data.MySqlClient

Public Class DetailTransaksi
    Private transaksiId As Integer

    Public Sub New(id As Integer)
        InitializeComponent()
        transaksiId = id
    End Sub

    Private Sub FormDetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblIdTransaksi.Text = "ID Transaksi: " & transaksiId.ToString()

        Dim kasirName As String = ""
        Connect()
        Dim query As String = "SELECT u.nama FROM transaksi t JOIN user u ON t.user_id = u.id WHERE t.id = @id"
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", transaksiId)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    kasirName = reader("nama").ToString()
                End If
            End Using
        End Using

        LblNamaKasir.Text = "Kasir: " & kasirName
        LoadDetailTransaksi()
    End Sub

    Private Sub LoadDetailTransaksi()
        Connect()

        Dim query As String = "SELECT p.nama AS nama_produk, dt.jumlah, dt.subtotal 
                               FROM detail_transaksi dt 
                               JOIN produk p ON dt.produk_id = p.id 
                               WHERE dt.transaksi_id = @id"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", transaksiId)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)

        DgvDetail.DataSource = dt
    End Sub
End Class