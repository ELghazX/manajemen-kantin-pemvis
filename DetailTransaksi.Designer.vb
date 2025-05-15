<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksi
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
        DgvDetail = New DataGridView()
        LblIdTransaksi = New Label()
        LblNamaKasir = New Label()
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        CType(DgvDetail, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgvDetail
        ' 
        DgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvDetail.Location = New Point(26, 3)
        DgvDetail.Name = "DgvDetail"
        DgvDetail.Size = New Size(438, 223)
        DgvDetail.TabIndex = 0
        ' 
        ' LblIdTransaksi
        ' 
        LblIdTransaksi.AutoSize = True
        LblIdTransaksi.Font = New Font("Segoe UI", 14F)
        LblIdTransaksi.Location = New Point(15, 12)
        LblIdTransaksi.Name = "LblIdTransaksi"
        LblIdTransaksi.Size = New Size(67, 25)
        LblIdTransaksi.TabIndex = 1
        LblIdTransaksi.Text = "Label1"
        ' 
        ' LblNamaKasir
        ' 
        LblNamaKasir.AutoSize = True
        LblNamaKasir.Font = New Font("Segoe UI", 14F)
        LblNamaKasir.Location = New Point(88, 12)
        LblNamaKasir.Name = "LblNamaKasir"
        LblNamaKasir.Size = New Size(67, 25)
        LblNamaKasir.TabIndex = 2
        LblNamaKasir.Text = "Label1"
        LblNamaKasir.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(DgvDetail)
        Panel1.Location = New Point(69, 88)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(490, 275)
        Panel1.TabIndex = 3
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.WhiteSmoke
        FlowLayoutPanel1.Controls.Add(LblIdTransaksi)
        FlowLayoutPanel1.Controls.Add(LblNamaKasir)
        FlowLayoutPanel1.Location = New Point(69, 24)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(12)
        FlowLayoutPanel1.Size = New Size(490, 58)
        FlowLayoutPanel1.TabIndex = 4
        ' 
        ' DetailTransaksi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(239), CByte(234), CByte(216))
        ClientSize = New Size(616, 441)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        Name = "DetailTransaksi"
        Text = "DetailTransaksi"
        CType(DgvDetail, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DgvDetail As DataGridView
    Friend WithEvents LblIdTransaksi As Label
    Friend WithEvents LblNamaKasir As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
