Public Class frmBai4

    Private Sub btKetQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKetQua.Click

        If txtSoNguyen.Text = "" Then
            MsgBox("Không để trống dữ liệu")
        End If
        If (CDbl(txtSoNguyen.Text) <= 0) Or (CDbl(txtSoNguyen.Text) >= 10) Then
            MsgBox("Không nhập số nhỏ hơn 0 hoặc lớn hơn 10")
        Else
            Dim n As Double = CDbl(txtSoNguyen.Text)
            Dim i As Double = 1
            Dim tong As Double = 0
            Dim chuoi As String = "1"
            For i = 1 To n Step 1
                tong += i
                If i <> 1 Then
                    chuoi = chuoi + "+" + i.ToString()
                End If
            Next
            txtTongInt.Text = tong.ToString()
            txtTongStr.Text = chuoi.ToCharArray()
        End If

    End Sub
End Class