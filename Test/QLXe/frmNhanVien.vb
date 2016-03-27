Imports System.Text.RegularExpressions
Public Class frmNhanVien

    Dim _dbSql As New DataBaseAccess
    Dim ThaoTac As clsCommonList.ThaoTac
    Private Sub load_grvNhanVien(ByVal record As String)
        Dim sqlQuery As String = String.Format("Select * From tbl_NhanVien WHERE MaNV='{0}'", record)
        Dim dTable As DataTable = _dbSql.GetDataTable(sqlQuery)
        Dim row As DataRow = dTable.Rows(0)
        txtMaNhanVien.Text = row("MaNV").ToString()
        DateTimePicker1.Value = DateTime.Parse(row("NgaySinh"))
        txtQueQuan.Text = row("QueQuan").ToString()
        txtSoCMND.Text = row("SoCMND").ToString()
        txtTenNhanVien.Text = row("TenNV").ToString()        
    End Sub

    Private Sub frmQLNhanVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ResetText()       
        If (Not (IsNothing(Me.Owner))) Then
            If (Me.Owner.Text.StartsWith(clsCommonList.ThaoTac.Sua.ToString())) Then
                ThaoTac = clsCommonList.ThaoTac.Sua
                load_grvNhanVien(Me.Owner.Text.Remove(0, clsCommonList.ThaoTac.Sua.ToString().Length))
                txtMaNhanVien.Enabled = False
            End If
        End If
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        If (txtMaNhanVien.Text = "" Or txtQueQuan.Text = "" Or txtSoCMND.Text = "" Or txtTenNhanVien.Text = "") Then
            MsgBox("Không để trống dữ liệu")
        ElseIf (Regex.Match(txtSoCMND.Text, "\D+").Value.Length > 0) Then
            MsgBox("Số CMND không hợp lệ")
        ElseIf (ThaoTac <> clsCommonList.ThaoTac.Sua And _dbSql.GetScalar(String.Format("SELECT MaNV FROM tbl_NhanVien WHERE MaNV='{0}'", txtMaNhanVien.Text)) <> Nothing) Then
            MsgBox("Mã nhân viên này đã tồn tại")
        Else
            Dim sqlQuery As String = ""
            If (ThaoTac = clsCommonList.ThaoTac.Sua) Then
                sqlQuery = String.Format("Update tbl_NhanVien Set TenNV=N'{1}',SoCMND='{2}',NgaySinh='{3}',QueQuan=N'{4}' Where MaNV ='{0}'", txtMaNhanVien.Text, txtTenNhanVien.Text, txtSoCMND.Text, DateTimePicker1.Value.ToString(), txtQueQuan.Text)
            Else
                sqlQuery = String.Format("Insert tbl_NhanVien Values('{0}',N'{1}','{2}','{3}',N'{4}')", txtMaNhanVien.Text, txtTenNhanVien.Text, txtSoCMND.Text, DateTimePicker1.Value.ToString(), txtQueQuan.Text)
            End If
            _dbSql.ExecuteNoneQuery(sqlQuery)
            MsgBox("Ok")
            DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub
End Class