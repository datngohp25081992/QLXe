Public Class frmBai3

    Private Sub btKetQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKetQua.Click

        If txtSoNguyen.Text = "" Then
            MsgBox("Không để trống dữ liệu")
        End If
        If (CDbl(txtSoNguyen.Text) <= 0) Or (CDbl(txtSoNguyen.Text) >= 10) Then
            MsgBox("Không nhập số nhỏ hơn 0 hoặc lớn hơn 10")
        Else
            Dim n As Double = CDbl(txtSoNguyen.Text)
            Dim i As Double = 1
            Dim kq As Double = 1
            For i = 1 To n Step 1
                kq *= i
            Next
            txtKetQua.Text = kq.ToString()
        End If
    End Sub
End Class