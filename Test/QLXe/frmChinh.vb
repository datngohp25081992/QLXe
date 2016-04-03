Imports System.Data.SqlClient
Imports System.Data

Public Class frmChinh

    Dim _dbSql As New DataBaseAccess
    Private Function DSMuonXe_Table() As DataTable
        Dim sqlQuery As String = String.Format("select MaMuon,TenNV,TenXe,SoCMND,tbl_Xe.BienSo,ThoiGianMuon,ThoiGianTra,BienSoCu From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien WHERE tbl_MuonTraXe.BienSo=tbl_Xe.BienSo AND tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV AND tbl_MuonTraXe.TinhTrang <> {0}", clsCommonList.TinhTrangXeTra.Huy.GetHashCode())
        Return _dbSql.GetDataTable(sqlQuery)
    End Function
    Private Function DSTraXe_Table() As DataTable
        Dim sqlQuery As String = String.Format("select * From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien WHERE tbl_MuonTraXe.BienSo=tbl_Xe.BienSo AND tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV and SoKmDongHo IS NULL and tbl_MuonTraXe.TinhTrang <>{0}", clsCommonList.TinhTrangXeTra.Huy.GetHashCode())
        Return _dbSql.GetDataTable(sqlQuery)
    End Function
    Private Function DSXe_Table() As DataTable
        Dim sqlQuery As String = String.Format("Select TenXe,Model,MauXe,SoCho,TinhTrang,BienSo From tbl_Xe")
        Return _dbSql.GetDataTable(sqlQuery)
    End Function
    Private Sub Load_DSXe()
        gcQLXe.DataSource = DSXe_Table()
        gcQLXe.RefreshDataSource()
    End Sub
    Private Sub Load_DSMuonXe()
        gcMuonXe.DataSource = DSMuonXe_Table()
        gcMuonXe.RefreshDataSource()
    End Sub
    Private Sub Load_DSTraXe()
        gcTraXe.DataSource = DSTraXe_Table()
        gcTraXe.RefreshDataSource()
    End Sub
    Private Sub Load_DSMuonTraXe()
        Dim sqlQuery As String = String.Format("Select * From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien where tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV and tbl_MuonTraXe.BienSo=tbl_Xe.BienSo")
        gcMuonTraXe.DataSource = _dbSql.GetDataTable(sqlQuery)

    End Sub
    Private Sub btQLXe_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btQLXe.ItemClick
        XtraTabControl1.SelectedTabPage = tpQLXe
        Load_DSXe()
    End Sub
    Private Function DSXe_CurrentRow() As String
        Return GridView1.GetFocusedRowCellValue("BienSo")
    End Function
    Private Function DSTraXe_CurrentRow() As String
        Return GridView4.GetFocusedRowCellValue("MaMuon")
    End Function
    Private Function DSNV_CurrentRow() As String
        Return GridView2.GetFocusedRowCellValue("MaNV")
    End Function
    Private Sub btXoaXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoaXe.Click
        Dim record As String = DSXe_CurrentRow()
        If (record <> String.Empty) Then
            If (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                _dbSql.ExecuteNoneQuery(String.Format("DELETE FROM tbl_Xe WHERE BienSo='{0}'", DSXe_CurrentRow()))
                Load_DSXe()
            End If
        End If
    End Sub

    Private Sub btSuaXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSuaXe.Click
        Dim frmQLXe As New frmQLXe
        Dim record As String = DSXe_CurrentRow()
        If (record <> String.Empty) Then
            Me.Text = clsCommonList.ThaoTac.Sua.ToString() + DSXe_CurrentRow()
            frmQLXe.Owner = Me
            If (frmQLXe.ShowDialog() = DialogResult.OK) Then
                Load_DSXe()
            End If
            Me.ResetText()
        End If
    End Sub

    Private Sub btThemXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThemXe.Click
        If (frmQLXe.ShowDialog() = DialogResult.OK) Then
            Load_DSXe()
        End If
    End Sub


    Private Sub Load_DSNV()
        Dim sqlQuery As String = String.Format("Select * From tbl_NhanVien")
        gcQLNV.DataSource = _dbSql.GetDataTable(sqlQuery)

    End Sub
    Private Sub btQLNhanVien_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btQLNhanVien.ItemClick
        XtraTabControl1.SelectedTabPage = tpQLNV
        Load_DSNV()
    End Sub

    Private Sub btXoaNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoaNhanVien.Click
        Dim rc As String = GridView2.GetFocusedRowCellValue("MaNV")
        If rc <> String.Empty Then
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _dbSql.ExecuteNoneQuery(String.Format("Delete From tbl_NhanVien Where MaNV='{0}'", GridView2.GetFocusedRowCellValue("MaNV")))
                Load_DSNV()
            End If
        End If
    End Sub

    Private Sub btThemNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThemNhanVien.Click
        If (frmNhanVien.ShowDialog() = DialogResult.OK) Then
            Load_DSNV()
        End If
    End Sub

    Private Sub btSuaNhanVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSuaNhanVien.Click
        Dim frmQLNV As New frmNhanVien
        Dim record As String = DSNV_CurrentRow()
        If (record <> String.Empty) Then
            Me.Text = clsCommonList.ThaoTac.Sua.ToString() + DSNV_CurrentRow()
            frmQLNV.Owner = Me
            If (frmQLNV.ShowDialog() = DialogResult.OK) Then
                Load_DSNV()
            End If
            Me.ResetText()
        End If
    End Sub

    Private Sub btMuonXe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btMuonXe.ItemClick
        XtraTabControl1.SelectedTabPage = tpMuonXe
        Load_DSMuonXe()
    End Sub

    Private Sub btThemMuonXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThemMuonXe.Click
        If (frmXeDangMuon.ShowDialog() = DialogResult.OK) Then
            Load_DSMuonXe()
        End If
    End Sub

    Private Sub frmChinh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RepositoryItemLookUpEdit1.DataSource = (New clsCommonList).TinhTrangXe_Table()
        RepositoryItemLookUpEdit2.DataSource = (New clsCommonList).TinhTrangTraXe_Table()       
    End Sub

    Private Sub btTKTraXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btThemTraXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btThemTraXe.Click
        Me.Text = clsCommonList.ThaoTac.Sua.ToString() + DSTraXe_CurrentRow()
        Dim frmTraXe As New frmTraXe
        frmTraXe.Owner = Me
        Dim record As String = GridView4.GetFocusedRowCellValue("MaMuon")
        If (record <> String.Empty) Then
            If (frmTraXe.ShowDialog() = DialogResult.OK) Then
                Load_DSTraXe()
            End If
        End If
    End Sub

    Private Sub btTraXe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btTraXe.ItemClick
        XtraTabControl1.SelectedTabPage = tpTraXe
        Load_DSTraXe()
    End Sub

    Private Sub btThongKe_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btThongKe.ItemClick
        XtraTabControl1.SelectedTabPage = tpThongKe
        Load_DSMuonTraXe()
    End Sub

    'Private Sub btXoaMuonXe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btXoaMuonXe.Click
    '    Dim rc As String = GridView3.GetFocusedRowCellValue("MaMuon")
    '    If rc <> String.Empty Then
    '        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
    '            _dbSql.ExecuteNoneQuery(String.Format("Delete From tbl_MuonTraXe Where MaMuon='{0}'", GridView3.GetFocusedRowCellValue("MaMuon")))
    '            Load_DSMuonXe()
    '        End If
    '    End If
    'End Sub

    Private Sub btLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLoc.Click
        If dtTuNgay.Value > dtDenNgay.Value Then
            MsgBox("Thời gian chưa hợp lệ")
        Else
            Dim sqlQuery As String = String.Format("Select * From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien where tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV and tbl_MuonTraXe.BienSo=tbl_Xe.BienSo and '{0}'<=ThoiGianMuon+1 and '{1}'>=ThoiGianMuon", dtTuNgay.Value, dtDenNgay.Value)
            gcMuonTraXe.DataSource = _dbSql.GetDataTable(sqlQuery)
        End If
    End Sub

    'Private Sub btSuaKm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSuaKm.Click
    '    Dim frmSuaKm As New frmSuaKmDongHo
    '    Dim record As String = GridView5.GetFocusedRowCellValue("MaMuon")
    '    If (record <> String.Empty) Then
    '        Me.Text = clsCommonList.ThaoTac.Sua.ToString() + GridView5.GetFocusedRowCellValue("MaMuon").ToString()
    '        frmSuaKmDongHo.Owner = Me
    '        If (frmSuaKmDongHo.ShowDialog() = DialogResult.OK) Then
    '            Load_DSMuonTraXe()
    '        End If
    '        Me.ResetText()
    '    End If
    'End Sub

    Private Sub btHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHuy.Click
        If MessageBox.Show("Are you sure", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            Dim record As String = GridView3.GetFocusedRowCellValue("MaMuon")
            If (record <> String.Empty) Then
                _dbSql.ExecuteNoneQuery(String.Format("Update tbl_MuonTraXe Set TinhTrang={0} where MaMuon={1}", clsCommonList.TinhTrangXeTra.Huy.GetHashCode(), record))
                Load_DSMuonXe()
            End If
        End If
    End Sub

    Private Sub btTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTimKiem.Click
        Me.Text = dtLocTuNgay.Value.ToString() + ";" + dtLocDenNgay.Value.ToString()
        Dim frmLinhTinh As New frmLichTrinh
        frmLinhTinh.Owner = Me
        frmLinhTinh.Show()
        'Dim sqlQuery As String = String.Format("select * From tbl_MuonTraXe,tbl_Xe,tbl_NhanVien WHERE tbl_MuonTraXe.BienSo=tbl_Xe.BienSo AND tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV and tbl_MuonTraXe.TinhTrang <>{0} and ((ThoiGianMuon >= '{1}' and ThoiGianMuon-1 <= '{2}') or (ThoiGianTra >= '{1}' and ThoiGianTra-1 <= '{2}'))", clsCommonList.TinhTrangXeTra.Huy.GetHashCode(), dtLocTuNgay.Value.Date, dtLocDenNgay.Value.Date)
        'gcMuonXe.DataSource = _dbSql.GetDataTable(sqlQuery)
        'gcMuonXe.RefreshDataSource()
    End Sub
End Class