
Public Class frmQLXe

    Dim _dbSql As New DataBaseAccess   
    Dim ThaoTac As clsCommonList.ThaoTac
    Private Sub load_grvXe(ByVal record As String)
        Dim sqlQuery As String = String.Format("Select TenXe,Model,MauXe,SoCho,TinhTrang,BienSo From tbl_Xe WHERE BienSo='{0}'", record)
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Dim row As DataRow = dTable.Rows(0)
        txtBienSo.Text = row("BienSo").ToString()
        txtTenXe.Text = row("TenXe").ToString()
        txtMauXe.Text = row("MauXe").ToString()
        txtModel.Text = row("Model").ToString()
        txtSoCho.Text = row("SoCho").ToString()
        cbTinhTrang.SelectedValue = row("TinhTrang").ToString()
        'grvDanhSachXe.DataSource = dTable
    End Sub

    Private Sub frmQLXe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ResetText()
        cbTinhTrang.DataSource = (New clsCommonList).TinhTrangXe_Table()
        If (Not (IsNothing(Me.Owner))) Then
            If (Me.Owner.Text.StartsWith(clsCommonList.ThaoTac.Sua.ToString())) Then
                ThaoTac = clsCommonList.ThaoTac.Sua
                load_grvXe(Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length))
                txtBienSo.Enabled = False
            End If
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If (txtBienSo.Text = "" Or txtMauXe.Text = "" Or txtModel.Text = "" Or txtSoCho.Text = "" Or txtTenXe.Text = "") Then
            MsgBox("Không để trống dữ liệu")
        ElseIf (Not (New clsValidate).IsInteger(txtSoCho.Text)) Then
            MsgBox("Số chỗ phải là số nguyên dương")
        ElseIf (ThaoTac <> clsCommonList.ThaoTac.Sua And _dbSql.GetScalar(String.Format("SELECT BienSo FROM tbl_Xe WHERE BienSo='{0}'", txtBienSo.Text)) <> Nothing) Then
            MsgBox("Biển số xe đã tồn tại")
        Else
            Dim sqlQuery As String = ""
            If (ThaoTac = clsCommonList.ThaoTac.Sua) Then
                sqlQuery = String.Format("Update tbl_Xe Set MauXe=N'{1}',Model=N'{2}',SoCho={3},TenXe=N'{4}',TinhTrang={5} Where BienSo ='{0}'", txtBienSo.Text, txtMauXe.Text, txtModel.Text, txtSoCho.Text, txtTenXe.Text, cbTinhTrang.SelectedValue)
            Else
                sqlQuery = String.Format("Insert tbl_Xe Values(N'{0}',N'{1}',N'{2}',{3},{4},'{5}')", txtTenXe.Text, txtModel.Text, txtMauXe.Text, txtSoCho.Text, cbTinhTrang.SelectedValue, txtBienSo.Text)
            End If
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class