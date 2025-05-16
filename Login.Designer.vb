<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        BtnLogin = New Button()
        Label3 = New Label()
        Label2 = New Label()
        BoxPassword = New TextBox()
        BoxEmail = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(BtnLogin)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(BoxPassword)
        Panel1.Controls.Add(BoxEmail)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(174, 112)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(916, 438)
        Panel1.TabIndex = 0
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(109), CByte(139), CByte(116))
        BtnLogin.ForeColor = Color.WhiteSmoke
        BtnLogin.Location = New Point(583, 281)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(236, 36)
        BtnLogin.TabIndex = 6
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(583, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(583, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 4
        Label2.Text = "Email"
        ' 
        ' BoxPassword
        ' 
        BoxPassword.Location = New Point(583, 229)
        BoxPassword.Name = "BoxPassword"
        BoxPassword.PasswordChar = "*"c
        BoxPassword.Size = New Size(236, 23)
        BoxPassword.TabIndex = 3
        ' 
        ' BoxEmail
        ' 
        BoxEmail.Location = New Point(583, 160)
        BoxEmail.Name = "BoxEmail"
        BoxEmail.Size = New Size(236, 23)
        BoxEmail.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(583, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 15)
        Label1.TabIndex = 1
        Label1.Text = "Silahkan gunakan email anda untuk masuk."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(502, 438)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panel1)
        MaximumSize = New Size(1280, 720)
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BoxPassword As TextBox
    Friend WithEvents BoxEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogin As Button

End Class
