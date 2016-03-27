Public Class frmBai6

    Private Sub btKiemTra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btKiemTra.Click

        If (txtNam.Text = "") Or (txtNgay.Text = "") Or (txtThang.Text = "") Then
            MsgBox("Không để trống dữ liệu")
            Return
        End If

        Dim ngay As Integer = CInt(txtNgay.Text)
        Dim thang As Integer = CInt(txtThang.Text)
        Dim nam As Integer = CInt(txtNam.Text)

        If (ngay < 1) Or (ngay > 31) Or (thang < 1) Or (thang > 12) Or (nam < 0) Then
            MsgBox("Bạn nhập Ngày hoặc Tháng hoặc Năm không hợp lệ")
        Else
            lbKiemTraNgay.Text = "Ngày " + ngay.ToString() + "/" + thang.ToString() + "/" + nam.ToString() + " hợp lệ"
            lbKiemTraNgay.Visible = True
            Dim SoNgay As Integer
            If thang = 1 Or thang = 3 Or thang = 5 Or thang = 7 Or thang = 8 Or thang = 10 Or thang = 12 Then
                SoNgay = 31
            Else
                If thang = 2 Then
                    SoNgay = 29
                Else
                    SoNgay = 30
                End If
            End If
            If thang < 4 Then
                lbKiemTraQuy.Text = "Tháng " + thang.ToString() + " thuộc quý I trong năm " + nam.ToString() + " và có " + SoNgay.ToString() + " ngày"
                lbKiemTraQuy.Visible = True
            Else
                If thang < 7 Then
                    lbKiemTraQuy.Text = "Tháng " + thang.ToString() + " thuộc quý II trong năm " + nam.ToString() + " và có " + SoNgay.ToString() + " ngày"
                    lbKiemTraQuy.Visible = True
                Else
                    If thang < 10 Then
                        lbKiemTraQuy.Text = "Tháng " + thang.ToString() + " thuộc quý III trong năm " + nam.ToString() + " và có " + SoNgay.ToString() + " ngày"
                        lbKiemTraQuy.Visible = True
                    Else
                        lbKiemTraQuy.Text = "Tháng " + thang.ToString() + " thuộc quý IV trong năm " + nam.ToString() + " và có " + SoNgay.ToString() + " ngày"
                        lbKiemTraQuy.Visible = True
                    End If
                End If
            End If

            Dim ngaytruoc As Integer = ngay - 1
            Dim ngaysau As Integer = ngay + 1
            Dim thangtruoc As Integer = thang
            Dim thangsau As Integer = thang
            Dim namtruoc As Integer = nam
            Dim namsau As Integer = nam
            If ngay = 1 Then                
                If thang = 1 Then
                    ngaytruoc = 31
                    thangtruoc = 12
                    namtruoc = nam - 1
                    ngaysau = 2
                    thangsau = thang
                    namsau = nam
                Else
                    If thang = 12 Then
                        ngaytruoc = 30
                        thangtruoc = 11
                        namtruoc = nam
                        ngaysau = 2
                        thangsau = thang
                        namsau = nam
                    Else
                        If thang = 3 Then
                            ngaytruoc = 29
                            ngaysau = ngay + 1
                            thangtruoc = 2
                            thangsau = 3
                            namtruoc = nam
                            namsau = nam
                        End If
                        If thang = 5 Or thang = 7 Or thang = 8 Or thang = 10 Then
                            ngaytruoc = 30
                            ngaysau = 2
                            thangtruoc = thang - 1
                            thangsau = thang
                            namtruoc = nam
                            namsau = nam
                        End If
                        If thang = 2 Or thang = 4 Or thang = 6 Or thang = 9 Or thang = 11 Then
                            ngaytruoc = 31
                            ngaysau = 2
                            thangtruoc = thang - 1
                            thangsau = thang
                            namtruoc = namsau = nam
                        End If
                    End If
                End If                                
            End If
            If ngay = 30 And (thang = 4 Or thang = 6 Or thang = 9 Or thang = 11) Then
                ngaytruoc = 29
                ngaysau = 1
                thangtruoc = thang
                thangsau = thang + 1
                namtruoc = namsau = nam
            End If
            If ngay = 31 And (thang = 1 Or thang = 3 Or thang = 5 Or thang = 7 Or thang = 8 Or thang = 10) Then
                ngaytruoc = 30
                ngaysau = 1
                thangtruoc = thang
                thangsau = thang + 1
                namtruoc = namsau = nam
            End If
            If ngay = 31 And thang = 12 Then
                ngaytruoc = 30
                ngaysau = 1
                thangtruoc = 12
                thangsau = 1
                namtruoc = nam
                namsau = nam + 1
            End If
            lbTruocSau.Text = "Ngày hôm trước là ngày " + ngaytruoc.ToString() + "/" + thangtruoc.ToString() + "/" + namtruoc.ToString() + ", ngày hôm sau là ngày " + ngaysau.ToString() + "/" + thangsau.ToString() + "/" + namsau.ToString()
            lbTruocSau.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim dt As New DateTime(Convert.ToInt32(txtNam.Text), Convert.ToInt32(txtThang.Text), Convert.ToInt32(txtNgay.Text))
            MsgBox(dt.AddDays(-1).ToString("dd MM yyyy"))
            MsgBox(dt.AddDays(1).ToString("dd MM yyyy"))

        Catch ex As Exception
            MsgBox("Ngày or tháng or năm không họp lệ")
        End Try


    End Sub
End Class