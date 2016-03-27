Public Class frmTraXe

    Dim _dbSql As New DataBaseAccess

    Private Sub Load_grvDanhSachXeM()
        Dim sqlQuery As String = String.Format("Select MaMuon,TenXe,TenNV,ThoiGianMuon From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien Where tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV and tbl_MuonTraXe.BienSo=tbl_Xe.BienSo and SoKmDongHo=''")
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        'grvDanhSachXeM.DataSource = dTable
    End Sub

    Private Sub frmTraXe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_grvDanhSachXeM()
    End Sub
End Class