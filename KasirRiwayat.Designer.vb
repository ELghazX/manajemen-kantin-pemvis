<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasirRiwayat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KasirRiwayat))
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
        Panel6 = New Panel()
        Label4 = New Label()
        Panel8 = New Panel()
        DgvRiwayat = New DataGridView()
        BoxCari = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        BtnKeluar = New Button()
        LblTanggal = New Label()
        LblWelcome = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel8.SuspendLayout()
        CType(DgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(173, 681)
        Panel1.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
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
        Label3.ForeColor = Color.WhiteSmoke
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
        Panel2.BackColor = Color.Transparent
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
        Label2.ForeColor = Color.FromArgb(CByte(38), CByte(50), CByte(56))
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
        ' Panel6
        ' 
        Panel6.BackColor = Color.WhiteSmoke
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Panel8)
        Panel6.Controls.Add(BoxCari)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(198, 109)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1039, 505)
        Panel6.TabIndex = 4
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
        Panel8.Controls.Add(DgvRiwayat)
        Panel8.Location = New Point(16, 105)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(1008, 360)
        Panel8.TabIndex = 4
        ' 
        ' DgvRiwayat
        ' 
        DgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvRiwayat.Location = New Point(0, 0)
        DgvRiwayat.Name = "DgvRiwayat"
        DgvRiwayat.Size = New Size(1006, 302)
        DgvRiwayat.TabIndex = 0
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
        Label8.Size = New Size(318, 15)
        Label8.TabIndex = 1
        Label8.Text = "Menampilkan riwayat pemesanan pada sistem MyKantinku"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(16, 15)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 21)
        Label7.TabIndex = 0
        Label7.Text = "Riwayat Pesanan"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(BtnKeluar)
        Panel5.Controls.Add(LblTanggal)
        Panel5.Controls.Add(LblWelcome)
        Panel5.Location = New Point(198, 36)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1039, 49)
        Panel5.TabIndex = 3
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
        BtnKeluar.TabIndex = 6
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
        ' KasirRiwayat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Name = "KasirRiwayat"
        Text = "KasirRiwayat"
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
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel8.ResumeLayout(False)
        CType(DgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DgvRiwayat As DataGridView
    Friend WithEvents BoxCari As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblTanggal As Label
    Friend WithEvents LblWelcome As Label
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents Label4 As Label
End Class
