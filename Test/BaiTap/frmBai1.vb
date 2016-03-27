Public Class frmBai1

    Private Sub btTim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTim.Click

        If (txtSoA.Text = "") Or (txtSoB.Text = "") Or (txtSoC.Text = "") Then
            MsgBox("Không để trống dữ liệu")
        Else
            If (IsNumeric(txtSoA.Text) = False) Or (IsNumeric(txtSoB.Text) = False) Or (IsNumeric(txtSoC.Text) = False) Then
                MsgBox("Vui lòng nhập dữ liệu dạng số")
            Else
                Dim a(3) As Double
                a(0) = CDbl(txtSoA.Text)
                a(1) = CDbl(txtSoB.Text)
                a(2) = CDbl(txtSoC.Text)
                Dim max As Double = a(0)
                Dim min As Double = a(0)
                Dim tong As Double = 0
                Dim i As Double = 0
                For i = 0 To 2 Step 1
                    If max <= a(i) Then
                        max = a(i)
                    End If
                    If min >= a(i) Then
                        min = a(i)
                    End If
                    tong += a(i)
                Next
                txtLonNhat.Text = max.ToString()
                txtNhoNhat.Text = min.ToString()
                txtTong.Text = tong.ToString()
            End If
        End If

    End Sub
End Class