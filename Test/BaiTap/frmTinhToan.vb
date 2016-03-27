Public Class frmTinhToan

    Private Sub btTinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTinh.Click

        If (IsNumeric(txtSoA.Text) = False) Or (IsNumeric(txtSoB.Text) = False) Then
            MsgBox("Hãy nhập số!")
        Else
            Dim a As Double = CDbl(txtSoA.Text)
            Dim b As Double = CDbl(txtSoB.Text)

            If a > b Then
                MsgBox("A lớn hơn B!")
            End If
            If a < b Then
                MsgBox("B lớn hơn A!")
            End If
            If a = b Then
                MsgBox("A bằng B!")
            End If

            If (txtSoA.Text = "") And (txtSoB.Text = "") Then
                MsgBox("Không để trống dữ liệu!")
            Else

                If cbPhepToan.Text = "" Then
                    MsgBox("Vui lòng chọn phép toán ")
                Else

                    If cbPhepToan.Text = "Cộng" Then
                        Dim c As Double = a + b
                        lbKetQua.Text = "Kết quả A + B"
                        txtKetQua.Text = c.ToString()
                    End If

                    If cbPhepToan.Text = "Trừ" Then
                        Dim c As Double = a - b
                        lbKetQua.Text = "Kết quả A - B"
                        txtKetQua.Text = c.ToString()
                    End If

                    If cbPhepToan.Text = "Nhân" Then
                        Dim c As Double = a * b
                        lbKetQua.Text = "Kết quả A * B"
                        txtKetQua.Text = c.ToString()
                    End If

                    If b = 0 Then
                        MsgBox("Không để giá trị B = 0 ")
                        txtSoB.Focus()
                    Else
                        If cbPhepToan.Text = "Chia" Then
                            Dim c As Double = a / b
                            lbKetQua.Text = "Kết quả A / B"
                            txtKetQua.Text = c.ToString()
                        End If
                    End If
                End If

            End If
        End If


    End Sub

    Private Sub btUCLN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUCLN.Click

        If (IsNumeric(txtSoA.Text) = False) Or (IsNumeric(txtSoB.Text) = False) Then
            MsgBox("Hãy nhập số!")
        Else
            If (txtSoA.Text = "") Or (txtSoB.Text = "") Then
                MsgBox("Không để trống dữ liệu")
            Else
                Dim a As Double = CDbl(txtSoA.Text)
                Dim b As Double = CDbl(txtSoB.Text)
                Do While a <> b
                    If a > b Then
                        a -= b
                    Else
                        b -= a
                    End If
                Loop
                lbKetQua.Text = "UCLN:"
                txtKetQua.Text = a.ToString()
            End If
        End If

    End Sub

    Private Sub btBCNN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBCNN.Click

        If (IsNumeric(txtSoA.Text) = False) Or (IsNumeric(txtSoB.Text) = False) Then
            MsgBox("Hãy nhập số")
        Else
            If (txtSoA.Text = "") Or (txtSoB.Text = "") Then
                MsgBox("Không để trống dữ liệu")
            Else
                Dim a As Double = CDbl(txtSoA.Text)
                Dim b As Double = CDbl(txtSoB.Text)
                Dim i As Double = 1
                If a > b Then
                    Do While (a * i) Mod b <> 0
                        i += 1
                    Loop
                    lbKetQua.Text = "BCNN:"
                    txtKetQua.Text = (a * i).ToString()
                Else
                    Do While (b * i) Mod a <> 0
                        i += 1
                    Loop
                    lbKetQua.Text = "BCNN:"
                    txtKetQua.Text = (b * i).ToString()
                End If
            End If
        End If

    End Sub
End Class
