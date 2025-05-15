<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminKasir))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel6 = New Panel()
        PictureBox4 = New PictureBox()
        LblKasir = New Label()
        Panel5 = New Panel()
        PictureBox2 = New PictureBox()
        LblProduk = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        LblRiwayat = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel12 = New Panel()
        BtnKeluar = New Button()
        LblTanggal = New Label()
        LblWelcome = New Label()
        Panel13 = New Panel()
        Label3 = New Label()
        BtnTambah = New Button()
        Panel14 = New Panel()
        DgvKasir = New DataGridView()
        BoxCari = New TextBox()
        Label2 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel12.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        CType(DgvKasir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(173, 681)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(12, 193)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(148, 109)
        Panel2.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        Panel6.Controls.Add(PictureBox4)
        Panel6.Controls.Add(LblKasir)
        Panel6.Location = New Point(0, 66)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(148, 32)
        Panel6.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(10, 6)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(18, 18)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' LblKasir
        ' 
        LblKasir.AutoSize = True
        LblKasir.ForeColor = Color.WhiteSmoke
        LblKasir.Location = New Point(34, 9)
        LblKasir.Name = "LblKasir"
        LblKasir.Size = New Size(32, 15)
        LblKasir.TabIndex = 0
        LblKasir.Text = "Kasir"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(PictureBox2)
        Panel5.Controls.Add(LblProduk)
        Panel5.Location = New Point(0, 28)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(148, 32)
        Panel5.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(18, 18)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' LblProduk
        ' 
        LblProduk.AutoSize = True
        LblProduk.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LblProduk.Location = New Point(34, 9)
        LblProduk.Name = "LblProduk"
        LblProduk.Size = New Size(45, 15)
        LblProduk.TabIndex = 0
        LblProduk.Text = "Produk"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 1
        Label4.Text = "Master Data"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(12, 96)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(148, 78)
        Panel3.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(LblRiwayat)
        Panel4.Location = New Point(0, 28)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(148, 32)
        Panel4.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(18, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' LblRiwayat
        ' 
        LblRiwayat.AutoSize = True
        LblRiwayat.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        LblRiwayat.Location = New Point(34, 9)
        LblRiwayat.Name = "LblRiwayat"
        LblRiwayat.Size = New Size(95, 15)
        LblRiwayat.TabIndex = 0
        LblRiwayat.Text = "Riwayat Pesanan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 1
        Label1.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(BtnKeluar)
        Panel12.Controls.Add(LblTanggal)
        Panel12.Controls.Add(LblWelcome)
        Panel12.Location = New Point(198, 36)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(1039, 49)
        Panel12.TabIndex = 7
        ' 
        ' BtnKeluar
        ' 
        BtnKeluar.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnKeluar.ForeColor = Color.WhiteSmoke
        BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), Image)
        BtnKeluar.ImageAlign = ContentAlignment.MiddleLeft
        BtnKeluar.Location = New Point(936, 0)
        BtnKeluar.Name = "BtnKeluar"
        BtnKeluar.Padding = New Padding(12, 0, 12, 0)
        BtnKeluar.Size = New Size(103, 49)
        BtnKeluar.TabIndex = 5
        BtnKeluar.Text = "Keluar"
        BtnKeluar.TextAlign = ContentAlignment.MiddleRight
        BtnKeluar.UseVisualStyleBackColor = False
        ' 
        ' LblTanggal
        ' 
        LblTanggal.AutoSize = True
        LblTanggal.Font = New Font("Segoe UI", 9F)
        LblTanggal.Location = New Point(0, 27)
        LblTanggal.Name = "LblTanggal"
        LblTanggal.Size = New Size(105, 15)
        LblTanggal.TabIndex = 3
        LblTanggal.Text = "Sabtu, 17 Mei 2025"
        ' 
        ' LblWelcome
        ' 
        LblWelcome.AutoSize = True
        LblWelcome.Font = New Font("Segoe UI", 12F)
        LblWelcome.Location = New Point(0, 0)
        LblWelcome.Name = "LblWelcome"
        LblWelcome.Size = New Size(123, 21)
        LblWelcome.TabIndex = 2
        LblWelcome.Text = "Selamat Datang,"
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.WhiteSmoke
        Panel13.Controls.Add(Label3)
        Panel13.Controls.Add(BtnTambah)
        Panel13.Controls.Add(Panel14)
        Panel13.Controls.Add(BoxCari)
        Panel13.Controls.Add(Label2)
        Panel13.Controls.Add(Label7)
        Panel13.Location = New Point(198, 96)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(1039, 505)
        Panel13.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 5
        Label3.Text = "Cari"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnTambah.Location = New Point(948, 52)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(71, 32)
        BtnTambah.TabIndex = 4
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(DgvKasir)
        Panel14.Location = New Point(16, 105)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(1005, 304)
        Panel14.TabIndex = 4
        ' 
        ' DgvKasir
        ' 
        DgvKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvKasir.Location = New Point(0, 0)
        DgvKasir.Name = "DgvKasir"
        DgvKasir.Size = New Size(1003, 282)
        DgvKasir.TabIndex = 0
        ' 
        ' BoxCari
        ' 
        BoxCari.Location = New Point(49, 65)
        BoxCari.Name = "BoxCari"
        BoxCari.Size = New Size(113, 23)
        BoxCari.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(16, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 15)
        Label2.TabIndex = 1
        Label2.Text = "Menampilkan semua kasir pada sistem MyKantinku."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(16, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 21)
        Label7.TabIndex = 0
        Label7.Text = "Daftar Kasir"
        ' 
        ' AdminKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel13)
        Controls.Add(Panel12)
        Controls.Add(Panel1)
        Name = "AdminKasir"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel14.ResumeLayout(False)
        CType(DgvKasir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblKasir As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblProduk As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblRiwayat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LblWelcome As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents DgvKasir As DataGridView
    Friend WithEvents BoxCari As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnKeluar As Button
End Class
