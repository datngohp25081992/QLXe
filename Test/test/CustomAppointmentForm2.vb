#Region "Note"
'
'{**************************************************************************************************************}
'{  This file is automatically created when you open the Scheduler Control smart tag                            }
'{  *and click Create Customizable Appointment Dialog.                                                          }
'{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
'{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
'{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
'{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
'{  The code that displays this form is automatically inserted                                                  }
'{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
'{                                                                                                              }
'{**************************************************************************************************************}
'
#End Region ' Note

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Partial Public Class CustomAppointmentForm2
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As DevExpress.XtraScheduler.Appointment)
        MyBase.New(control, apt)
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As DevExpress.XtraScheduler.SchedulerControl, ByVal apt As DevExpress.XtraScheduler.Appointment, ByVal openRecurrenceForm As Boolean)
        MyBase.New(control, apt, openRecurrenceForm)
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' Add your code to obtain a custom field value and fill the editor with data.
    ''' </summary>
    Public Overrides Sub LoadFormData(ByVal appointment As DevExpress.XtraScheduler.Appointment)
        MyBase.LoadFormData(appointment)
        'If appointment.CustomFields("MaNV") Is Nothing Then
        '    lkuNhanVien.EditValue = ""
        'Else
        '    lkuNhanVien.EditValue = appointment.CustomFields("MaNV").ToString()
        'End If

    End Sub
    ''' <summary>
    ''' Add your code to retrieve a value from the editor and set the custom appointment field.
    ''' </summary>
    Public Overrides Function SaveFormData(ByVal appointment As DevExpress.XtraScheduler.Appointment) As Boolean
        Return MyBase.SaveFormData(appointment)
    End Function
    '' <summary>
    ''' Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
    ''' </summary>
    Public Overrides Function IsAppointmentChanged(ByVal appointment As DevExpress.XtraScheduler.Appointment) As Boolean
        Return False
    End Function


    'Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
    '    Dim sql As New DataBaseAccess
    '        sql.ExecuteNoneQuery(String.Format("Insert tbl_MuonTraXe(MaNV,BienSo,NgayDkMuon,ThoiGianMuon,ThoiGianTra,MucDich,DiaDiemDen,SoKmDongHo,TinhTrang,MoTa,BienSoCu) Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}',{7},{8},{9},'{10}')", cbNguoiMuon.SelectedValue, cbTenXe.SelectedValue, dtDkMuonXe.Value, dtNgayMuon.Value, dtNgayTra.Value, txtMucDich.Text, txtDiaDiem.Text, "NULL", clsCommonList.TinhTrangXeTra.ChuaTra.GetHashCode(), "NULL", cbTenXe.SelectedValue)
    '    Close()
    'End Sub
    'Public Overloads Function OnOkButton(ByVal appointment As DevExpress.XtraScheduler.Appointment) As Boolean
    '    Dim sql As New DataBaseAccess
    '    sql.ExecuteNoneQuery(String.Format("Insert tbl_MuonTraXe(MaNV,BienSo,NgayDkMuon,ThoiGianMuon,ThoiGianTra,MucDich,DiaDiemDen,SoKmDongHo,TinhTrang,MoTa,BienSoCu) Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}',{7},{8},{9},'{10}')", lkuNhanVien.EditValue.ToString(), edtResource.ResourceId.ToString(), DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"), edtStartDate.EditValue.ToString("yyyy-mm-dd") + " " + edtStartTime.EditValue.ToString("H:mm:ss"), edtEndDate.EditValue.ToString("yyyy-mm-dd") + " " + edtEndDate.EditValue.ToString("H:mm:ss"), tbDescription.Text, tbLocation.Text, "NULL", clsCommonList.TinhTrangXeTra.ChuaTra.GetHashCode(), "NULL", edtResource.SelectedText))
    '    Close()
    '    Return True
    'End Function
    Private Sub CustomAppointmentForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lkuNhanVien.Properties.DataSource = (New DataBaseAccess).GetDataTable("Select MaNV,TenNV,SoCMND from tbl_NhanVien")
        lkuNhanVien.Properties.DisplayMember = "TenNV"
        lkuNhanVien.Properties.ValueMember = "MaNV"

    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        Dim sql As New DataBaseAccess
        Dim str As String = String.Format("Insert tbl_MuonTraXe(MaNV,BienSo,NgayDkMuon,ThoiGianMuon,ThoiGianTra,MucDich,DiaDiemDen,SoKmDongHo,TinhTrang,MoTa,BienSoCu) Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}',{7},{8},{9},'{10}')", lkuNhanVien.EditValue.ToString(), edtResource.ResourceId.ToString(), DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"), DateTime.Parse(edtStartDate.EditValue).ToShortDateString() + " " + DateTime.Parse(edtStartTime.EditValue).ToShortTimeString(), DateTime.Parse(edtEndDate.EditValue).ToShortDateString() + " " + DateTime.Parse(edtEndTime.EditValue).ToShortTimeString(), tbDescription.Text, tbLocation.Text, "NULL", edtLabel.SelectedIndex, "NULL", edtResource.ResourceId.ToString())
        sql.ExecuteNoneQuery(str)
        Close()

    End Sub
End Class
