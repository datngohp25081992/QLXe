Imports DevExpress.XtraScheduler
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Commands
Public Class frmTestNgay

    Dim db As New DataBaseAccess
    Private Sub Load_Time()
        db = New DataBaseAccess()
        Dim dt As New DataTable

        Dim sqlquery As String = String.Format("select * from tbl_MuonTraXe,tbl_NhanVien where tbl_MuonTraXe.MaNV=tbl_NhanVien.MaNV")
        dt = db.GetDataTable(sqlquery)

        sc.Start = Date.Today

        st.Appointments.Mappings.Start = "ThoiGianMuon"
        st.Appointments.Mappings.End = "ThoiGianTra"
        st.Appointments.Mappings.Subject = "TenNV"
        st.Appointments.Mappings.ResourceId = "BienSo"
        st.Appointments.Mappings.Description = "MucDich"
        st.Appointments.Mappings.Location = "DiaDiemDen"
        st.Appointments.Mappings.Label = "TinhTrang"
        st.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("MaNV", "MaNV"))
        st.Appointments.DataMember = "MaMuon"
        st.Appointments.DataSource = dt

        st.Resources.Mappings.Id = "BienSo"
        st.Resources.Mappings.Caption = "TenXe"
        st.Resources.DataMember = "BienSo"
        'st.Resources.Mappings.Color = "MauXe"
        sqlquery = String.Format("select * from tbl_Xe")
        dt = db.GetDataTable(sqlquery)
        st.Resources.DataSource = dt
    End Sub
    Private Sub frmTestNgay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Load_Time()
    End Sub

    Private Sub sc_EditAppointmentFormShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As Test.CustomAppointmentForm1 = New Test.CustomAppointmentForm1(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try

    End Sub

    Private Sub sc_EditAppointmentFormShowing_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As Test.CustomAppointmentForm1 = New Test.CustomAppointmentForm1(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try

    End Sub
    Private Sub sc_EditAppointmentFormShowing_2(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles sc.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As Test.CustomAppointmentForm2 = New Test.CustomAppointmentForm2(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try
        Load_Time()
    End Sub

    Private Sub sc_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs) Handles sc.PopupMenuShowing
        Dim item As SchedulerMenuItem = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment)
        If item IsNot Nothing Then
            item.Caption = "Mượn Trả Xe"
        End If
        e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent)
        item = e.Menu.GetMenuItemById(SchedulerMenuItemId.GotoToday)
        If item IsNot Nothing Then
            item.Caption = "Về Ngày Hôm Nay"
        End If
        item = e.Menu.GetMenuItemById(SchedulerMenuItemId.GotoDate)
        If item IsNot Nothing Then
            item.Caption = "Xem Ngày"
        End If

        item = e.Menu.GetMenuItemById(SchedulerMenuItemId.SwitchViewMenu)
        If item IsNot Nothing Then
            item.Caption = "Tùy Chọn Hiển Thị"
            MsgBox(item.Caption.ToString())
        End If
        item = e.Menu.GetMenuItemById(SchedulerMenuItemId.TimeScaleEnable)
        If item IsNot Nothing Then
            item.Caption = "Kiểu Xem"
        End If

        item = e.Menu.GetMenuItemById(SchedulerMenuItemId.LabelSubMenu)
        If item IsNot Nothing Then
            item.Caption = "Kiểu Xem"
        End If
    End Sub
End Class