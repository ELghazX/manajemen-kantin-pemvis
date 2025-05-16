Module ModFix
    Public Sub FormFix(frm As Form)
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.MaximizeBox = False
        frm.MinimizeBox = True
        frm.Size = New Size(1280, 720)
        frm.MaximumSize = frm.Size
        frm.MinimumSize = frm.Size
        frm.StartPosition = FormStartPosition.CenterScreen
    End Sub

End Module
