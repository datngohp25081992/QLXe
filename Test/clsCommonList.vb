Public Class clsCommonList
    Enum TinhTrangXe
        DangSuDung = 0
        XeHong = 1
        DaThanhLy = 2
        NgungSuDung = 3
    End Enum
    Enum ThaoTac
        Them = 0
        Sua = 1
    End Enum
    Function TinhTrangXe_Table() As DataTable

        Dim results As New DataTable
        results.Columns.Add("MaTinhTrang")
        results.Columns.Add("TenTinhTrang")
        results.Rows.Add(0, "Đang Sử Dụng")
        results.Rows.Add(1, "Xe Hỏng")
        results.Rows.Add(2, "Đã Thanh Lý")
        results.Rows.Add(3, "Ngừng Sử Dụng")
        Return results

    End Function
End Class
