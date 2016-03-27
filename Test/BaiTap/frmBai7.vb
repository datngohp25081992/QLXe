Public Class frmBai7

    Private Sub btSapXep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSapXep.Click

        Dim str As String = txtDanhSachSo.Text
        Dim test As String = ""
        Dim arr() As String
        arr = Split(str)
        Dim i As Integer = 0
        Try
            txtSoChan.Text = ""
            For i = 0 To Len(str) Step 1
                If CDbl(arr(i)) Mod 2 = 0 Then
                    txtSoChan.Text = txtSoChan.Text + " " + arr(i)
                Else
                    txtSoLe.Text = txtSoLe.Text + " " + arr(i)
                End If
            Next
        Catch ex As Exception

        End Try
        

    End Sub
End Class