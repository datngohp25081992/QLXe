Public Class frmBai2

    Private Sub btKetQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKetQua.Click
        If txtSoNguyen.Text = "" Then
            MsgBox("Không để trống dữ liệu")
        End If
        If (CDbl(txtSoNguyen.Text) <= 0) Or (CDbl(txtSoNguyen.Text) >= 10) Then
            MsgBox("Không nhập số nhỏ hơn 0 hoặc lớn hơn 10")
        Else
            Select Case CDbl(txtSoNguyen.Text)
                Case 1
                    txtKetQua.Text = "Một"
                Case 2
                    txtKetQua.Text = "Hai"
                Case 3
                    txtKetQua.Text = "Ba"
                Case 4
                    txtKetQua.Text = "Bốn"
                Case 5
                    txtKetQua.Text = "Năm"
                Case 6
                    txtKetQua.Text = "Sáu"
                Case 7
                    txtKetQua.Text = "Bảy"
                Case 8
                    txtKetQua.Text = "Tám"
                Case 9
                    txtKetQua.Text = "Chín"
            End Select
        End If
    End Sub
End Class