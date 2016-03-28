Public Class clsCommonList
    Enum TinhTrangXe
        DangSuDung = 0
        XeHong = 1
        DaThanhLy = 2
        NgungSuDung = 3
    End Enum
    Enum TinhTrangXeTra
        BinhThuong = 0
        XeHong = 1
        ChuaTra = 2
        Huy = 3
    End Enum
    Enum ThaoTac
        Them = 0
        Sua = 1
    End Enum
    Function TinhTrangXe_Table() As DataTable

        Dim results As New DataTable
        results.Columns.Add("MaTinhTrang")
        results.Columns.Add("TenTinhTrang")
        results.Rows.Add(0, "Sử Dụng Được")
        results.Rows.Add(1, "Xe Hỏng")
        results.Rows.Add(2, "Đã Thanh Lý")
        results.Rows.Add(3, "Ngừng Sử Dụng")
        Return results

    End Function
    Function TinhTrangTraXe_Table() As DataTable

        Dim results As New DataTable
        results.Columns.Add("MaTinhTrang")
        results.Columns.Add("TenTinhTrang")
        results.Rows.Add(0, "Bình thường")
        results.Rows.Add(1, "Đã hỏng")
        results.Rows.Add(2, "Chưa Trả")
        results.Rows.Add(3, "Hủy")
        Return results

    End Function
End Class
