<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTambahKasir
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
        Panel1 = New Panel()
        BtnSimpan = New Button()
        Panel4 = New Panel()
        BoxKonfirmasi = New TextBox()
        BoxPassword = New TextBox()
        BoxEmail = New TextBox()
        BoxNama = New TextBox()
        Panel3 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        BtnKembali = New Button()
        LblTambahKasir = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(BtnSimpan)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(73, 102)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(655, 282)
        Panel1.TabIndex = 2
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
        Panel4.Controls.Add(BoxKonfirmasi)
        Panel4.Controls.Add(BoxPassword)
        Panel4.Controls.Add(BoxEmail)
        Panel4.Controls.Add(BoxNama)
        Panel4.Location = New Point(199, 36)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(409, 145)
        Panel4.TabIndex = 3
        ' 
        ' BoxKonfirmasi
        ' 
        BoxKonfirmasi.Location = New Point(0, 99)
        BoxKonfirmasi.Name = "BoxKonfirmasi"
        BoxKonfirmasi.Size = New Size(409, 23)
        BoxKonfirmasi.TabIndex = 3
        ' 
        ' BoxPassword
        ' 
        BoxPassword.Location = New Point(0, 66)
        BoxPassword.Name = "BoxPassword"
        BoxPassword.Size = New Size(409, 23)
        BoxPassword.TabIndex = 2
        ' 
        ' BoxEmail
        ' 
        BoxEmail.Location = New Point(0, 34)
        BoxEmail.Name = "BoxEmail"
        BoxEmail.Size = New Size(409, 23)
        BoxEmail.TabIndex = 1
        ' 
        ' BoxNama
        ' 
        BoxNama.Location = New Point(0, 0)
        BoxNama.Name = "BoxNama"
        BoxNama.Size = New Size(409, 23)
        BoxNama.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(54, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(124, 145)
        Panel3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 15)
        Label4.TabIndex = 4
        Label4.Text = "Konfirmasi Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 2
        Label2.Text = "Email"
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
        Panel2.Controls.Add(LblTambahKasir)
        Panel2.Location = New Point(73, 30)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(655, 48)
        Panel2.TabIndex = 3
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
        ' LblTambahKasir
        ' 
        LblTambahKasir.AutoSize = True
        LblTambahKasir.Font = New Font("Segoe UI", 24F)
        LblTambahKasir.Location = New Point(0, 0)
        LblTambahKasir.Name = "LblTambahKasir"
        LblTambahKasir.Size = New Size(207, 45)
        LblTambahKasir.TabIndex = 0
        LblTambahKasir.Text = "Tambah Kasir"
        ' 
        ' AdminTambahKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "AdminTambahKasir"
        Text = "AdminTambahKasir"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BoxEmail As TextBox
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblTambahKasir As Label
    Friend WithEvents BoxKonfirmasi As TextBox
    Friend WithEvents BoxPassword As TextBox
    Friend WithEvents Label4 As Label
End Class
