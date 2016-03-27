Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Threading
Imports System.IO


Public Class frmBai11

    Private ConnectionString As String = ConfigurationSettings.AppSettings("MyConnectionString")
    Private con As SqlConnection
    Private da As SqlDataAdapter

    Private Function LayDuLieu(ByVal sqlQuery As String) As DataTable
        Dim dtable As New DataTable
        con = New SqlConnection(ConnectionString)
        da = New SqlDataAdapter(sqlQuery, con)
        Try
            con.Open()
            da.Fill(dtable)
        Catch ex As Exception
            MsgBox("Error")
        Finally
            con.Close()
        End Try
        Return dtable
    End Function

    Private Function CheckLogin(ByVal user As String, ByVal pass As String) As Boolean
        'Dim cont As New SqlLibs.SqlConnect()
        'cont.SetConnection("ANDONGNHI", "tbl_DangNhap")
        Dim sqlQuery As String = String.Format("Select * From dbo.tbl_NguoiDung where ID = '{0}' and Pass = '{1}'", user, pass)
        Dim con As SqlConnection = New SqlConnection(ConnectionString)
        Dim com As SqlCommand = New SqlCommand("Select ID From dbo.tbl_NguoiDung where ID = '@ID' and Pass = '@Pass'", con)
        com.Parameters.AddWithValue("@ID", user)
        com.Parameters.AddWithValue("@Pass", pass)
        Dim hasAny As String = com.ExecuteScalar().ToString()
        If String.IsNullOrEmpty(hasAny) Then
            Return False
        End If
        Return True
        'Dim dtable As DataTable = LayDuLieu(sqlQuery)
        'Return dtable.Rows.Count > 0
    End Function

    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(Me.txtID.Text) OrElse String.IsNullOrEmpty(Me.txtPass.Text)
    End Function


    Private Sub btDangNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDangNhap.Click


        If ckNhoMatKhau.Checked Then

            Dim sw As StreamWriter
            sw = New StreamWriter("Luu.txt", False)
            sw.WriteLine(txtID.Text + vbCrLf + txtPass.Text + vbCrLf + "True")
            sw.Close()

        Else
            Dim sw As StreamWriter
            sw = New StreamWriter("Luu.txt", False)
            sw.WriteLine(txtID.Text + vbCrLf + "" + vbCrLf + "False")
            sw.Close()
        End If


        If IsEmpty() Then
            MsgBox("Username or Password cannot be empty!")
        Else
            If CheckLogin(Me.txtID.Text.ToLower(), Me.txtPass.Text.ToLower()) Then                
                MsgBox("Login Successful!")               
                Dim frm As New frmBai1
                frm.Show()
            Else
                MsgBox("Username or Password is incorrect")
            End If
        End If
    End Sub

    Private Sub btHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHuy.Click
        Me.Close()
    End Sub

    Private Sub frmBai11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim sr As StreamReader = New StreamReader("Luu.txt")
            Dim i As Integer = 0
            Dim a(3) As String

            While Not sr.EndOfStream
                a(i) = sr.ReadLine()
                i += 1
            End While
            If a(2) = "True" Then
                txtID.Text = a(0)
                txtPass.Text = a(1)
                ckNhoMatKhau.Checked = True
            Else
                txtID.Text = a(0)
                txtPass.Text = ""
                ckNhoMatKhau.Checked = False
            End If
            sr.Close()
        Catch ex As Exception

        End Try

        

    End Sub
End Class