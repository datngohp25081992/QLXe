<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLichTrinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
        Me.QLXeDataSet = New Test.QLXeDataSet()
        Me.TblMuonTraXeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MuonTraXeTableAdapter = New Test.QLXeDataSetTableAdapters.tbl_MuonTraXeTableAdapter()
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QLXeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMuonTraXeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulerControl1
        '
        Me.SchedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Week
        Me.SchedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SchedulerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Lime
        Me.SchedulerControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Red
        Me.SchedulerControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SchedulerControl1.LookAndFeel.UseWindowsXPTheme = True
        Me.SchedulerControl1.Name = "SchedulerControl1"
        Me.SchedulerControl1.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.SchedulerControl1.Size = New System.Drawing.Size(522, 421)
        Me.SchedulerControl1.Start = New Date(2016, 3, 28, 0, 0, 0, 0)
        Me.SchedulerControl1.Storage = Me.SchedulerStorage1
        Me.SchedulerControl1.TabIndex = 0
        Me.SchedulerControl1.Text = "SchedulerControl1"
        Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.DependentId = "BienSo"
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.ParentId = "MaNV"
        Me.SchedulerStorage1.AppointmentDependencies.Mappings.Type = "MaMuon"
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "NgayDkMuon"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "DiaDiemDen"
        Me.SchedulerStorage1.Appointments.Mappings.End = "ThoiGianTra"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "MucDich"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "MaMuon"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "BienSo"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "ThoiGianMuon"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "TinhTrang"
        Me.SchedulerStorage1.Resources.Mappings.Caption = "TenXe"
        Me.SchedulerStorage1.Resources.Mappings.Color = "TinhTrang"
        Me.SchedulerStorage1.Resources.Mappings.Id = "BienSo"
        '
        'DateNavigator1
        '
        Me.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateNavigator1.HotDate = Nothing
        Me.DateNavigator1.Location = New System.Drawing.Point(522, 0)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.SchedulerControl = Me.SchedulerControl1
        Me.DateNavigator1.Size = New System.Drawing.Size(179, 421)
        Me.DateNavigator1.TabIndex = 1
        '
        'QLXeDataSet
        '
        Me.QLXeDataSet.DataSetName = "QLXeDataSet"
        Me.QLXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMuonTraXeBindingSource
        '
        Me.TblMuonTraXeBindingSource.DataMember = "tbl_MuonTraXe"
        Me.TblMuonTraXeBindingSource.DataSource = Me.QLXeDataSet
        '
        'Tbl_MuonTraXeTableAdapter
        '
        Me.Tbl_MuonTraXeTableAdapter.ClearBeforeFill = True
        '
        'frmLichTrinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 421)
        Me.Controls.Add(Me.SchedulerControl1)
        Me.Controls.Add(Me.DateNavigator1)
        Me.Name = "frmLichTrinh"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lịch trình xe - "
        CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QLXeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMuonTraXeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents QLXeDataSet As Test.QLXeDataSet
    Friend WithEvents TblMuonTraXeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_MuonTraXeTableAdapter As Test.QLXeDataSetTableAdapters.tbl_MuonTraXeTableAdapter
End Class
