Public Class frmBai9

    Private Sub btKetQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKetQua.Click

        Dim a() As String
        Dim b() As String      
        Dim i As Integer = 0
        Dim tongtu As Integer = 0
        Dim tongmau As Integer = 0
        Dim str As String
        str = txtChuoi.Text
        a = Split(str)
        If str = "" Then
            MsgBox("Không để trống dữ liệu")
            Return
        Else           
                For i = 0 To a.Length - 1 Step 1
                    b = Split(a(i), "/")
                If b.Length = 1 And IsNumeric(b(0)) = False Then
                    MsgBox("Vui lòng nhập số")
                    Return
                Else
                    If b.Length = 2 And (b(1) = "0" Or IsNumeric(CInt(b(1))) = False Or IsNumeric(CInt(b(0))) = False) Then
                        MsgBox("Lỗi nhập liệu")
                        Return
                    Else
                        tongtu += CInt(b(0))
                        tongmau += CInt(b(1))
                    End If
                End If
                Next            
        End If                   
        txtKetQua.Text = tongtu.ToString() + "/" + tongmau.ToString()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtChuoi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChuoi.TextChanged

    End Sub

    Private Sub txtKetQua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKetQua.TextChanged

    End Sub
End Class