Imports System.Data.SqlClient
Imports System.Data


Public Class frmTestGRV

    Private con As SqlConnection
    Private Sub KetNoi()
        Dim cn As String = "Data Source=ANDONGNHI;Initial Catalog=QLSV;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
            con.Open()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Load_grvSinhVien()
        Dim sqlQuery As String = String.Format("select MaSV,TenSV,DiaChi,TenLop from dbl_SinhVien SV, dbl_Lop L where SV.MaLop=L.MaLop")
        Dim db As SqlDataAdapter = Nothing
        Dim tbl As New DataTable
        db = New SqlDataAdapter(sqlQuery, con)
        db.Fill(tbl)
        GrvSinhVien.DataSource = tbl
    End Sub

    Private Sub frmTestGRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KetNoi()
        Load_grvSinhVien()
    End Sub

    Private Sub GrvSinhVien_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrvSinhVien.SelectionChanged
        Dim i As Integer = GrvSinhVien.CurrentCell.RowIndex
        txtMaSV.Text = GrvSinhVien.Rows(i).Cells(0).Value.ToString()
        txtTenSV.Text = GrvSinhVien.Rows(i).Cells(1).Value.ToString()
        txtDiaChi.Text = GrvSinhVien.Rows(i).Cells(2).Value.ToString()
        txtLop.Text = GrvSinhVien.Rows(i).Cells(3).Value.ToString()
    End Sub
End Class