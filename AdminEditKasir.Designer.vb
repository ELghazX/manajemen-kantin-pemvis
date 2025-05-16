<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminEditKasir
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
        Panel2 = New Panel()
        BtnKembali = New Button()
        LblEditProduk = New Label()
        Panel1 = New Panel()
        BtnHapus = New Button()
        BtnSimpan = New Button()
        Panel4 = New Panel()
        BoxPassword = New TextBox()
        BoxEmail = New TextBox()
        BoxNama = New TextBox()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(BtnKembali)
        Panel2.Controls.Add(LblEditProduk)
        Panel2.Location = New Point(69, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(655, 48)
        Panel2.TabIndex = 5
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
        ' LblEditProduk
        ' 
        LblEditProduk.AutoSize = True
        LblEditProduk.Font = New Font("Segoe UI", 24F)
        LblEditProduk.Location = New Point(0, 0)
        LblEditProduk.Name = "LblEditProduk"
        LblEditProduk.Size = New Size(151, 45)
        LblEditProduk.TabIndex = 0
        LblEditProduk.Text = "Edit Kasir"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(BtnHapus)
        Panel1.Controls.Add(BtnSimpan)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(69, 124)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(655, 282)
        Panel1.TabIndex = 6
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.IndianRed
        BtnHapus.ForeColor = Color.Black
        BtnHapus.Location = New Point(418, 205)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(92, 48)
        BtnHapus.TabIndex = 4
        BtnHapus.Text = "Hapus Kasir"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnSimpan.Location = New Point(516, 205)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(92, 48)
        BtnSimpan.TabIndex = 2
        BtnSimpan.Text = "Simpan Perubahan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(BoxPassword)
        Panel4.Controls.Add(BoxEmail)
        Panel4.Controls.Add(BoxNama)
        Panel4.Location = New Point(130, 36)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(478, 145)
        Panel4.TabIndex = 3
        ' 
        ' BoxPassword
        ' 
        BoxPassword.Location = New Point(0, 114)
        BoxPassword.Name = "BoxPassword"
        BoxPassword.Size = New Size(473, 23)
        BoxPassword.TabIndex = 2
        ' 
        ' BoxEmail
        ' 
        BoxEmail.Location = New Point(0, 61)
        BoxEmail.Name = "BoxEmail"
        BoxEmail.Size = New Size(473, 23)
        BoxEmail.TabIndex = 1
        ' 
        ' BoxNama
        ' 
        BoxNama.Location = New Point(0, 0)
        BoxNama.Name = "BoxNama"
        BoxNama.Size = New Size(473, 23)
        BoxNama.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(54, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(70, 145)
        Panel3.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(0, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 61)
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
        ' AdminEditKasir
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "AdminEditKasir"
        Text = "AdminEditKasir"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnKembali As Button
    Friend WithEvents LblEditProduk As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BoxEmail As TextBox
    Friend WithEvents BoxNama As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BoxPassword As TextBox
    Friend WithEvents BtnHapus As Button
End Class
