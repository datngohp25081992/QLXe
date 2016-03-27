Imports System.Data.SqlClient
Imports System.Data
Imports System


Public Class frmTestKetNoi

    Private con As SqlConnection    
    Private Sub KetNoi()
        Dim cn As String = "Data Source=ANDONGNHI;Initial Catalog=QLSV;Integrated Security=True"
        Try
            con = New SqlConnection(cn)
            con.Open()            
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadLop()

        Dim sqlQuery As String = "Select * From dbl_lop"
        Dim db As SqlDataAdapter = Nothing
        Dim tbl As New DataTable
        db = New SqlDataAdapter(sqlQuery, con)
        db.Fill(tbl)

        cbLopHoc.DataSource = tbl
        cbLopHoc.DisplayMember = "TenLop"
        cbLopHoc.ValueMember = "MaLop"

    End Sub


    Private Sub LoadSV()

        Dim sql As String = "Select * From dbl_SinhVien"
        Dim db As SqlDataAdapter = Nothing
        Dim tbl As New DataTable
        db = New SqlDataAdapter(sql, con)
        db.Fill(tbl)

        cbTenSV.DataSource = tbl
        cbTenSV.DisplayMember = "TenSV"
        cbTenSV.ValueMember = "MaSV"

    End Sub

    Private Sub frmTestKetNoi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        KetNoi()
        LoadLop()
        LoadSV()


    End Sub

    Private Sub cbLopHoc_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLopHoc.SelectedValueChanged

        txtTenSV.Text = ""
        Dim sql As String = String.Format("select TenSV,L.MaLop,TenLop from dbl_SinhVien SV, dbl_Lop L where SV.MaLop=L.MaLop and L.MaLop='{0}'", cbLopHoc.SelectedValue.ToString())
        Dim scm As New SqlCommand(sql, con)
        Dim reader As SqlDataReader = scm.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Dim tenSV As String = reader.GetString(0)
                txtTenSV.Text += tenSV + "; "
            Loop
        End If
        reader.Close()
    End Sub

    Private Sub cbTenSV_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTenSV.SelectedValueChanged

        Dim sql As String = String.Format("select MaSV,SV.MaLop,TenLop from dbl_SinhVien SV, dbl_Lop L where SV.MaLop=L.MaLop and MaSV='{0}'", cbTenSV.SelectedValue.ToString())
        
        Dim rec As New SqlCommand(sql, con)
        Dim reader As SqlDataReader = rec.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Dim tenlop As String = reader.GetString(2)
                txtLopHoc.Text = tenlop
            Loop            
        Else
            txtLopHoc.Text = "Khong tim thay"
        End If
        reader.Close()        

    End Sub

End Class