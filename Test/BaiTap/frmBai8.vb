Public Class frmBai8

    Private Sub btSapXep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSapXep.Click

        Dim a(9) As Integer
        Dim c(9) As Integer
        a(0) = CInt(txtA1.Text)
        a(1) = CInt(txtA2.Text)
        a(2) = CInt(txtA3.Text)
        a(3) = CInt(txtA4.Text)
        a(4) = CInt(txtA5.Text)
        a(5) = CInt(txtA6.Text)
        a(6) = CInt(txtA7.Text)
        a(7) = CInt(txtA8.Text)
        a(8) = CInt(txtA9.Text)
        a(9) = CInt(txtA10.Text)
        Dim b(9) As Integer
        Dim i As Integer = 0
        Dim k As Integer
        Dim tg As Integer

        For i = 0 To 9 Step 1
            b(i) = a(i)
            c(i) = a(i)
            For k = i + 1 To 9 Step 1
                If b(i) > a(k) Then
                    tg = b(i)
                    b(i) = a(k)
                    a(k) = tg
                End If
            Next
        Next

        txtB1.Text = b(0).ToString()
        txtB2.Text = b(1).ToString()
        txtB3.Text = b(2).ToString()
        txtB4.Text = b(3).ToString()
        txtB5.Text = b(4).ToString()
        txtB6.Text = b(5).ToString()
        txtB7.Text = b(6).ToString()
        txtB8.Text = b(7).ToString()
        txtB9.Text = b(8).ToString()
        txtB10.Text = b(9).ToString()
        txtSoNhoNhat.Text = b(0).ToString()
        txtSoLonNhat.Text = b(9).ToString()

        Dim so As Integer
        Dim sophu As Integer
        Dim dem As Integer = 0        
        For i = 0 To 9 Step 1
            so = b(i)
            Dim demphu As Integer = 1
            For k = i + 1 To 9 Step 1
                If so = b(k) Then
                    demphu += 1
                    If demphu > dem Then
                        dem = demphu
                        sophu = b(k)
                    End If
                End If
            Next
        Next
        txtSoXuatHienNhieu.Text = sophu.ToString()
        txtSoLanXuatHien.Text = dem.ToString()


    End Sub

    Private Sub btTimViTri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTimViTri.Click

        Dim a(9) As Integer
        Dim c(9) As Integer
        a(0) = CInt(txtA1.Text)
        a(1) = CInt(txtA2.Text)
        a(2) = CInt(txtA3.Text)
        a(3) = CInt(txtA4.Text)
        a(4) = CInt(txtA5.Text)
        a(5) = CInt(txtA6.Text)
        a(6) = CInt(txtA7.Text)
        a(7) = CInt(txtA8.Text)
        a(8) = CInt(txtA9.Text)
        a(9) = CInt(txtA10.Text)
        Dim b(9) As Integer
        Dim i As Integer = 0
        Dim k As Integer
        Dim tg As Integer

        For i = 0 To 9 Step 1
            c(i) = a(i)
        Next

        For i = 0 To 9 Step 1
            b(i) = a(i)            
            For k = i + 1 To 9 Step 1
                If b(i) > a(k) Then
                    tg = b(i)
                    b(i) = a(k)
                    a(k) = tg
                End If
            Next
        Next

        Dim so As Integer = CInt(txtNhapSo.Text)
        Dim vitrisau As String = ""
        Dim vitridau As String = ""
        For i = 0 To 9 Step 1
            If so = b(i) Then
                vitrisau = vitrisau + " " + (i + 1).ToString()
            End If
            If so = c(i) Then
                vitridau = vitridau + " " + (i + 1).ToString()
            End If
        Next
        txtViTriBanDau.Text = vitridau
        txtViTriSapXep.Text = vitrisau

    End Sub
End Class