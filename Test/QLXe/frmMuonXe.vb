Public Class frmXeDangMuon

    Dim _dbSql As New DataBaseAccess

    Private Sub Load_cbTenXe()
        Dim sqlQuery As String = String.Format("Select BienSo, TenXe From tbl_Xe")
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Me.cbTenXe.DataSource = dTable
        Me.cbTenXe.DisplayMember = "TenXe"
        Me.cbTenXe.ValueMember = "BienSo"
    End Sub

    Private Sub load_cbNhanVien()
        Dim sqlQuery As String = String.Format("Select MaNV, TenNV From tbl_NhanVien")
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Me.cbNguoiMuon.DataSource = dTable
        Me.cbNguoiMuon.DisplayMember = "TenNV"
        Me.cbNguoiMuon.ValueMember = "MaNV"
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
        ElseIf (_dbSql.GetScalar(String.Format("Select MaMuon from tbl_MuonTraXe Where ThoiGianMuon<='{0}' AND ThoiGianTra>='{0}' AND BienSo='{1}'", cbTenXe.SelectedValue, dtNgayMuon.Value)) <> Nothing) Then
            MsgBox("Xe không rảnh trong thời gian này")
        Else
            Dim sqlQuery As String = ""
            sqlQuery = String.Format("Insert tbl_MuonTraXe Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}',{7},{8},{9})", cbNguoiMuon.SelectedValue, cbTenXe.SelectedValue, dtDkMuonXe.Value, dtNgayMuon.Value, dtNgayTra.Value, txtMucDich.Text, txtDiaDiem.Text, "NULL", "False", "NULL")
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class