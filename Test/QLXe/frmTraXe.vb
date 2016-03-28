Public Class frmTraXe

    Dim _dbSql As New DataBaseAccess
    Private Sub frmTraXe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbTinhTrangTra.DataSource = (New clsCommonList).TinhTrangTraXe_Table()
        cbTenXe.DataSource = _dbSql.GetDataTable("Select TenXe,BienSo from tbl_Xe")
        cbNguoiMuon.DataSource = _dbSql.GetDataTable("Select TenNV,MaNV from tbl_NhanVien")
        Dim dt As New DataTable
        dt = _dbSql.GetDataTable(String.Format("SELECT TOP 1 * FROM tbl_MuonTraXe WHERE MaMuon={0}", Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length)))
        Dim dr As DataRow = dt.Rows(0)

        cbNguoiMuon.SelectedValue = dr(1).ToString()
        cbTenXe.SelectedValue = dr(2).ToString()
        dtNgayMuon.Value = DateTime.Parse(dr(4))
        dtNgayTra.Value = DateTime.Parse(dr(5))
    End Sub

    Private Sub btXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoa.Click
        Close()
    End Sub

    Private Sub btThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThem.Click
        If (dtTraXeThuc.Value <= dtNgayMuon.Value) Then
            MsgBox("Thời gian trả không hợp lệ")
        ElseIf (Not (New clsValidate).IsInteger(txtSoKmDongHo.Text)) Then
            MsgBox("Số KM đồng hồ không hợp lệ")
        Else
            Dim sqlQuery As String = ""
            sqlQuery = String.Format("update tbl_MuonTraXe SET ThoiGianTra='{0}',SoKmDongHo='{1}',TinhTrang={2},MoTa=N'{3}' WHERE MaMuon={4}", dtTraXeThuc.Value, txtSoKmDongHo.Text, cbTinhTrangTra.SelectedValue, txtMoTa.Text, Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length))
            _dbSql.ExecuteNoneQuery(sqlQuery)
            sqlQuery = String.Format("Update tbl_Xe Set TinhTrang={0} Where BienSo='{1}'", cbTinhTrangTra.SelectedValue, txtBienSo.Text)
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub cbTenXe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTenXe.SelectedIndexChanged
        txtBienSo.Text = cbTenXe.SelectedValue
    End Sub
End Class