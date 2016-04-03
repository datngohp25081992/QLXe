Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils

Public Class frmLichTrinh


    Dim dbSql As DataBaseAccess
    Private Sub SchedulerControl1_EditAppointmentFormShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As Test.Scheduler13._1_TestDesignTime.AppointmentFormOutlook2007Style = New Test.Scheduler13._1_TestDesignTime.AppointmentFormOutlook2007Style(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try

    End Sub

    Private Sub frmLichTrinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbSql = New DataBaseAccess()
        Dim dt As New DataTable
        Dim sqlquery As String = String.Format("select * from tbl_MuonTraXe")
        dt = dbSql.GetDataTable(sqlquery)


        SchedulerStorage1.Appointments.Mappings.Start = "ThoiGianMuon"
        SchedulerStorage1.Appointments.Mappings.End = "ThoiGianTra"
        SchedulerStorage1.Appointments.Mappings.Subject = "BienSo"
        SchedulerStorage1.Appointments.DataMember = "MaMuon"
        SchedulerStorage1.Appointments.DataSource = dt

        'Dim MuonTraXes As New List(Of tbl_MuonTraXe)
        'For index = 0 To dt.Rows.Count - 1
        '    Dim MuonTraXe As New tbl_MuonTraXe
        '    MuonTraXe.BienSo = dt.Rows(index)(2).ToString()
        '    MuonTraXe.ThoiGianMuon = DateTime.Parse(dt.Rows(index)(4).ToString())
        '    MuonTraXe.ThoiGianTra = DateTime.Parse(dt.Rows(index)(5).ToString())
        '    MuonTraXes.Add(MuonTraXe)
        'Next
        'Dim Appointments As New List(Of Appointment)
        'For index = 0 To MuonTraXes.Count - 1
        '    Dim Appointment As New Appointment
        '    Appointment.Subject = MuonTraXes(index).BienSo
        '    Appointment.StartDate = MuonTraXes(index).ThoiGianMuon
        '    Appointment.EndDate = MuonTraXes(index).ThoiGianTra
        '    Appointments.Add(Appointment)
        'Next

        'SchedulerStorage1.Appointments.DataSource = MuonTraXes
        'SchedulerStorage1.Appointments.Mappings.Start = "ThoiGianMuon"
        'SchedulerStorage1.Appointments.Mappings.End = "ThoiGianTra"
        'SchedulerStorage1.Appointments.Mappings.Description = "MucDich"
        'SchedulerStorage1.Appointments.Mappings.Label = 1
        'SchedulerStorage1.Appointments.Mappings.Location = "DiaDiem"
        'SchedulerStorage1.Appointments.Mappings.Status = "SoKmDongHo"
        'SchedulerStorage1.Appointments.Mappings.Subject = "BienSo"


        'SchedulerStorage1.Appointments.DataSource = dt
        'SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        'SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        'SchedulerStorage1.Appointments.Mappings.AppointmentId = "UniqueID"
        'SchedulerStorage1.Appointments.Mappings.Description = "Description"
        'SchedulerStorage1.Appointments.Mappings.Label = "Label"
        'SchedulerStorage1.Appointments.Mappings.Location = "Location"
        'SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        'SchedulerStorage1.Appointments.Mappings.Status = "Status"
        'SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"

        'Dim apt As Appointment = SchedulerStorage1.CreateAppointment(AppointmentType.Normal)

        'Me.Tbl_MuonTraXeTableAdapter.Fill(Me.QLXeDataSet.tbl_MuonTraXe)

    End Sub

    Private Sub SchedulerControl1_EditAppointmentFormShowing_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim form As Test.CustomAppointmentForm = New Test.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try

    End Sub
End Class