Imports System.Data.SqlClient
Imports System.Data

Public Class frmChinh

    Dim _dbSql As New DataBaseAccess
    Private Sub XeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    Private Function DSMuonXe_Table() As DataTable
        Dim sqlQuery As String = String.Format("Select * From tbl_MuonTraXe")
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        XtraTabControl1.SelectedTabPage = tpQLXe
        Load_DSXe()
        Dim obj = New clsCommonList
        RepositoryItemLookUpEdit1.DataSource = obj.TinhTrangXe_Table()
    End Sub
    Private Function DSXe_CurrentRow() As String
        Return GridView1.GetFocusedRowCellValue("BienSo")
    End Function
    Private Function DSNV_CurrentRow() As String
        Return GridView2.GetFocusedRowCellValue("MaNV")
    End Function
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim record As String = DSXe_CurrentRow()
        If (record <> String.Empty) Then
            If (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                _dbSql.ExecuteNoneQuery(String.Format("DELETE FROM tbl_Xe WHERE BienSo='{0}'", DSXe_CurrentRow()))
                Load_DSXe()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If (frmQLXe.ShowDialog() = DialogResult.OK) Then
            Load_DSXe()
        End If
    End Sub


    Private Sub Load_DSNV()
        Dim sqlQuery As String = String.Format("Select * From tbl_NhanVien")
        gcQLNV.DataSource = _dbSql.GetDataTable(sqlQuery)

    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        XtraTabControl1.SelectedTabPage = tpQLNV
        Load_DSNV()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim rc As String = GridView2.GetFocusedRowCellValue("MaNV")
        If rc <> String.Empty Then
            If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                _dbSql.ExecuteNoneQuery(String.Format("Delete From tbl_NhanVien Where MaNV='{0}'", GridView2.GetFocusedRowCellValue("MaNV")))
                Load_DSNV()
            End If
        End If
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        If (frmNhanVien.ShowDialog() = DialogResult.OK) Then
            Load_DSNV()
        End If
    End Sub

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
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

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        XtraTabControl1.SelectedTabPage = tpMuonXe
        Load_DSMuonXe()
    End Sub

    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        If (frmXeDangMuon.ShowDialog() = DialogResult.OK) Then
            Load_DSMuonXe()
        End If
    End Sub
End Class