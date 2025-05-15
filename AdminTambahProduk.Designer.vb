<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTambahProduk
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
        LblTambahProduk = New Label()
        Panel1 = New Panel()
        BtnSimpan = New Button()
        Panel4 = New Panel()
        RbNonaktif = New RadioButton()
        BoxHarga = New TextBox()
        BoxNama = New TextBox()
        RbAktif = New RadioButton()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BtnKembali = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblTambahProduk
        ' 
        LblTambahProduk.AutoSize = True
        LblTambahProduk.Font = New Font("Segoe UI", 24F)
        LblTambahProduk.Location = New Point(0, 0)
        LblTambahProduk.Name = "LblTambahProduk"
        LblTambahProduk.Size = New Size(240, 45)
        LblTambahProduk.TabIndex = 0
        LblTambahProduk.Text = "Tambah Produk"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(BtnSimpan)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(64, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(655, 282)
        Panel1.TabIndex = 1
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnSimpan.Location = New Point(516, 205)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(92, 48)
        BtnSimpan.TabIndex = 2
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(RbNonaktif)
        Panel4.Controls.Add(BoxHarga)
        Panel4.Controls.Add(BoxNama)
        Panel4.Controls.Add(RbAktif)
        Panel4.Location = New Point(135, 36)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(473, 145)
        Panel4.TabIndex = 3
        ' 
        ' RbNonaktif
        ' 
        RbNonaktif.AutoSize = True
        RbNonaktif.Location = New Point(77, 117)
        RbNonaktif.Name = "RbNonaktif"
        RbNonaktif.Size = New Size(71, 19)
        RbNonaktif.TabIndex = 3
        RbNonaktif.TabStop = True
        RbNonaktif.Text = "Nonaktif"
        RbNonaktif.UseVisualStyleBackColor = True
        ' 
        ' BoxHarga
        ' 
        BoxHarga.Location = New Point(0, 61)
        BoxHarga.Name = "BoxHarga"
        BoxHarga.Size = New Size(473, 23)
        BoxHarga.TabIndex = 1
        ' 
        ' BoxNama
        ' 
        BoxNama.Location = New Point(0, 0)
        BoxNama.Name = "BoxNama"
        BoxNama.Size = New Size(473, 23)
        BoxNama.TabIndex = 0
        ' 
        ' RbAktif
        ' 
        RbAktif.AutoSize = True
        RbAktif.Location = New Point(0, 117)
        RbAktif.Name = "RbAktif"
        RbAktif.Size = New Size(50, 19)
        RbAktif.TabIndex = 2
        RbAktif.TabStop = True
        RbAktif.Text = "Aktif"
        RbAktif.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(54, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(48, 145)
        Panel3.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 3
        Label3.Text = "Status"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 2
        Label2.Text = "Harga"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnKembali)
        Panel2.Controls.Add(LblTambahProduk)
        Panel2.Location = New Point(64, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(655, 48)
        Panel2.TabIndex = 2
        ' 
        ' BtnKembali
        ' 
        BtnKembali.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnKembali.Location = New Point(563, 0)
        BtnKembali.Name = "BtnKembali"
        BtnKembali.Size = New Size(92, 48)
        BtnKembali.TabIndex = 1
        BtnKembali.Text = "Kembali"
        BtnKembali.UseVisualStyleBackColor = False
        ' 
        ' AdminTambahProduk
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(796, 434)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AdminTambahProduk"
        Text = "AdminTambahProduk"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LblTambahProduk As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnKembali As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RbAktif As RadioButton
    Friend WithEvents BoxHarga As TextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents RbNonaktif As RadioButton
End Class
