<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir_pesanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir_pesanan))
        Panel1 = New Panel()
        Panel4 = New Panel()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        BtnKeluar = New Button()
        LblTanggal = New Label()
        LblWelcome = New Label()
        Panel6 = New Panel()
        Label4 = New Label()
        Panel8 = New Panel()
        DgvProduk = New DataGridView()
        BoxCari = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Panel7 = New Panel()
        LblTotal = New Label()
        Label12 = New Label()
        Label11 = New Label()
        BtnClear = New Button()
        BtnCheckout = New Button()
        Panel9 = New Panel()
        DgvKeranjang = New DataGridView()
        Label9 = New Label()
        Label10 = New Label()
        PrintStruk = New Printing.PrintDocument()
        PreviewStruk = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        CType(DgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        CType(DgvKeranjang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(175, 682)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(12, 161)
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
        Label3.Location = New Point(34, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 15)
        Label3.TabIndex = 0
        Label3.Text = "Riwayat Pesanan"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Panel2)
        Panel3.Location = New Point(12, 96)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(148, 100)
        Panel3.TabIndex = 3
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(148, 32)
        Panel2.TabIndex = 2
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(34, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 0
        Label2.Text = "Pesanan"
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
        ' Panel5
        ' 
        Panel5.Controls.Add(BtnKeluar)
        Panel5.Controls.Add(LblTanggal)
        Panel5.Controls.Add(LblWelcome)
        Panel5.Location = New Point(197, 35)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1039, 49)
        Panel5.TabIndex = 1
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
        LblTanggal.Size = New Size(101, 15)
        LblTanggal.TabIndex = 3
        LblTanggal.Text = "Jumat, 9 Mei 2025"
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
        ' Panel6
        ' 
        Panel6.BackColor = Color.WhiteSmoke
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(BoxCari)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(197, 108)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(509, 505)
        Panel6.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 5
        Label4.Text = "Cari"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(DgvProduk)
        Panel8.Location = New Point(16, 105)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(474, 304)
        Panel8.TabIndex = 4
        ' 
        ' DgvProduk
        ' 
        DgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvProduk.Location = New Point(0, 0)
        DgvProduk.Name = "DgvProduk"
        DgvProduk.Size = New Size(474, 282)
        DgvProduk.TabIndex = 0
        ' 
        ' BoxCari
        ' 
        BoxCari.Location = New Point(50, 65)
        BoxCari.Name = "BoxCari"
        BoxCari.Size = New Size(112, 23)
        BoxCari.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(16, 36)
        Label8.Name = "Label8"
        Label8.Size = New Size(298, 15)
        Label8.TabIndex = 1
        Label8.Text = "Menampilkan semua  produk pada sistem MyKantinku."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(16, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 21)
        Label7.TabIndex = 0
        Label7.Text = "Daftar Produk"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.WhiteSmoke
        Panel7.Controls.Add(LblTotal)
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(BtnClear)
        Panel7.Controls.Add(BtnCheckout)
        Panel7.Controls.Add(Panel9)
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(Label10)
        Panel7.Location = New Point(727, 108)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(509, 505)
        Panel7.TabIndex = 3
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 16F)
        LblTotal.Location = New Point(357, 423)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(90, 30)
        LblTotal.TabIndex = 10
        LblTotal.Text = "100.000"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 16F)
        Label12.Location = New Point(325, 423)
        Label12.Name = "Label12"
        Label12.Size = New Size(39, 30)
        Label12.TabIndex = 9
        Label12.Text = "Rp"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 16F)
        Label11.Location = New Point(260, 423)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 30)
        Label11.TabIndex = 8
        Label11.Text = "Total"
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.IndianRed
        BtnClear.Location = New Point(127, 415)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(103, 49)
        BtnClear.TabIndex = 7
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' BtnCheckout
        ' 
        BtnCheckout.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnCheckout.Location = New Point(18, 415)
        BtnCheckout.Name = "BtnCheckout"
        BtnCheckout.Size = New Size(103, 49)
        BtnCheckout.TabIndex = 4
        BtnCheckout.Text = "Checkout"
        BtnCheckout.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(DgvKeranjang)
        Panel9.Location = New Point(18, 105)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(474, 304)
        Panel9.TabIndex = 5
        ' 
        ' DgvKeranjang
        ' 
        DgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvKeranjang.Location = New Point(0, 0)
        DgvKeranjang.Name = "DgvKeranjang"
        DgvKeranjang.Size = New Size(474, 282)
        DgvKeranjang.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(18, 36)
        Label9.Name = "Label9"
        Label9.Size = New Size(350, 15)
        Label9.TabIndex = 6
        Label9.Text = "Menampilkan isi kerangjang sementara pada sistem MyKantinku."
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(18, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 21)
        Label10.TabIndex = 5
        Label10.Text = "Keranjang Belanja"
        ' 
        ' PrintStruk
        ' 
        ' 
        ' PreviewStruk
        ' 
        PreviewStruk.AutoScrollMargin = New Size(0, 0)
        PreviewStruk.AutoScrollMinSize = New Size(0, 0)
        PreviewStruk.ClientSize = New Size(400, 300)
        PreviewStruk.Enabled = True
        PreviewStruk.Icon = CType(resources.GetObject("PreviewStruk.Icon"), Icon)
        PreviewStruk.Name = "PreviewStruk"
        PreviewStruk.Visible = False
        ' 
        ' Kasir_pesanan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Name = "Kasir_pesanan"
        Text = "Kasir_pesanan"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel8.ResumeLayout(False)
        CType(DgvProduk, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(DgvKeranjang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblWelcome As Label
    Friend WithEvents LblTanggal As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BoxCari As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DgvProduk As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnCheckout As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents DgvKeranjang As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintStruk As Printing.PrintDocument
    Friend WithEvents PreviewStruk As PrintPreviewDialog
    Friend WithEvents BtnKeluar As Button
End Class
