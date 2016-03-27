Public Class frmBai10

    Private Sub btKetQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKetQua.Click

        Dim str As String = txtChuoi.Text
        Dim str1 As String = " " + txtChuoiBatKi.Text + " "
        Dim str2 As String = ""
        Dim i As Integer
        Dim a() As String        
        a = Split(str, ";")
        For i = 0 To a.Length - 1 Step 1
            a(i) = Trim(a(i))
            a(i) = Replace(a(i), " ", str1)
        Next        
        txtKetQua.Text = Join(a, " ;")
    End Sub
End Class