Public Class frmBai5

    Private Sub btTinhLuong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTinhLuong.Click

        If txtThamNien.Text = "" Then
            MsgBox("Không để trống dữ liệu")
        End If
        If IsNumeric(txtThamNien.Text) = False Then
            MsgBox("Xin vui lòng nhập số")
        Else
            Dim tn As Double = CDbl(txtThamNien.Text)
            Dim hs As Double
            If tn < 12 Then
                hs = 1.92
            Else
                If tn < 36 Then
                    hs = 2.34
                Else
                    If tn < 60 Then
                        hs = 3
                    Else
                        hs = 4.5
                    End If
                End If
            End If
            Dim luong As Double = 1500000 * hs
            txtLuong.Text = luong.ToString()
        End If

    End Sub
End Class