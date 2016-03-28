Public Class frmSuaKmDongHo

    Dim _dbSql As New DataBaseAccess
    Dim ThaoTac As clsCommonList.ThaoTac

    Private Sub load_Km(ByVal record As String)
        Dim sqlQuery As String = String.Format("Select SoKmDongHo From tbl_MuonTraXe WHERE MaMuon='{0}'", record)
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Dim row As DataRow = dTable.Rows(0)
        txtSoCu.Text = row("SoKmDongHo").ToString()        
    End Sub
    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If txtSoMoi.Text = "" Then
            MsgBox("Không để trống dữ liệu")
        Else
            Dim sqlQuery As String = ""
            If (ThaoTac = clsCommonList.ThaoTac.Sua) Then
                If txtSoCu.Text = "" Then
                    sqlQuery = String.Format("Update tbl_MuonTraXe Set SoKmDongHo='{0}',TinhTrang={2} where MaMuon={1}", txtSoMoi.Text, Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length), clsCommonList.TinhTrangXe.DangSuDung)
                Else
                    sqlQuery = String.Format("Update tbl_MuonTraXe Set SoKmDongHo='{0}' where MaMuon={1}", txtSoMoi.Text, Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length))
                End If
            End If
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If
        
    End Sub

    Private Sub frmSuaKmDongHo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ResetText()        
        If (Not (IsNothing(Me.Owner))) Then
            If (Me.Owner.Text.StartsWith(clsCommonList.ThaoTac.Sua.ToString())) Then
                ThaoTac = clsCommonList.ThaoTac.Sua
                load_Km(Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length))                
            End If
        End If
    End Sub
End Class