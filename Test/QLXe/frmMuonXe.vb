Public Class frmXeDangMuon

    Dim _dbSql As New DataBaseAccess

    Private Sub Load_cbTenXe()
        Dim sqlQuery As String = String.Format("Select * From tbl_Xe")
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Me.cbTenXe.DataSource = dTable
    End Sub

    Private Sub load_cbNhanVien()
        Dim sqlQuery As String = String.Format("Select * From tbl_NhanVien")
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Me.cbNguoiMuon.DataSource = dTable
    End Sub

    Private Sub frmXeDangMuon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        Load_cbTenXe()
        load_cbNhanVien()
    End Sub

    Private Sub btXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoa.Click
        Close()
    End Sub

    Private Sub btThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThem.Click
        If (cbTenXe.SelectedIndex = -1 Or cbNguoiMuon.SelectedIndex = -1 Or txtMucDich.Text = "" Or txtDiaDiem.Text = "") Then
            MsgBox("Không để trống dữ liệu")
        ElseIf (dtNgayMuon.Value >= dtNgayTra.Value) Then
            MsgBox("Khoảng thời gian mượn không hợp lệ")
        ElseIf (dtDkMuonXe.Value.Date < Today) Then
            MsgBox("Ngày đăng ký mượn không hợp lệ")
        ElseIf (_dbSql.GetScalar(String.Format("Select MaMuon from tbl_MuonTraXe Where TinhTrang <> {2} AND ThoiGianMuon<='{1}' AND ThoiGianTra>='{1}' AND BienSo='{0}'", cbTenXe.SelectedValue, dtNgayMuon.Value, clsCommonList.TinhTrangXeTra.Huy.GetHashCode())) <> Nothing) Then
            MsgBox("Xe không rảnh trong thời gian này")
        ElseIf _dbSql.GetScalar(String.Format("Select BienSo From tbl_Xe Where BienSo='{0}' And TinhTrang <> 0", cbTenXe.SelectedValue)) <> Nothing Then
            MsgBox("Xe này chưa sẵn sàng để sử dụng")
        Else
            Dim sqlQuery As String = ""
            sqlQuery = String.Format("Insert tbl_MuonTraXe(MaNV,BienSo,NgayDkMuon,ThoiGianMuon,ThoiGianTra,MucDich,DiaDiemDen,SoKmDongHo,TinhTrang,MoTa,BienSoCu) Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}',{7},{8},{9},'{10}')", cbNguoiMuon.SelectedValue, cbTenXe.SelectedValue, dtDkMuonXe.Value, dtNgayMuon.Value, dtNgayTra.Value, txtMucDich.Text, txtDiaDiem.Text, "NULL", clsCommonList.TinhTrangXeTra.ChuaTra.GetHashCode(), "NULL", cbTenXe.SelectedValue)
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub cbTenXe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTenXe.SelectedIndexChanged
        txtBienSo.Text = cbTenXe.SelectedValue
    End Sub

    Private Sub cbNguoiMuon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNguoiMuon.SelectedIndexChanged
        If cbNguoiMuon.SelectedIndex <> -1 Then
            txtSoCMND.Text = _dbSql.GetScalar(String.Format("Select SoCMND from tbl_NhanVien Where MaNV='{0}'", cbNguoiMuon.SelectedValue)).ToString()
        End If
    End Sub
End Class