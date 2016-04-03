<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestNgay
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
        Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
        Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
        Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
        Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
        Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
        Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
        Dim TimeScale15Minutes1 As DevExpress.XtraScheduler.TimeScale15Minutes = New DevExpress.XtraScheduler.TimeScale15Minutes()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.sc = New DevExpress.XtraScheduler.SchedulerControl()
        Me.st = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.DateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
        CType(Me.sc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.st, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sc
        '
        Me.sc.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline
        Me.sc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.sc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sc.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        Me.sc.Location = New System.Drawing.Point(0, 0)
        Me.sc.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.sc.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.sc.Name = "sc"
        Me.sc.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.sc.OptionsView.NavigationButtons.NextCaption = ""
        Me.sc.OptionsView.NavigationButtons.PrevCaption = ""
        Me.sc.PaintStyleName = "WindowsXP"
        Me.sc.Size = New System.Drawing.Size(504, 406)
        Me.sc.Start = New Date(2016, 4, 1, 0, 0, 0, 0)
        Me.sc.Storage = Me.st
        Me.sc.TabIndex = 0
        Me.sc.Text = "SchedulerControl1"
        Me.sc.Views.DayView.Appearance.TimeRuler.ForeColor = System.Drawing.Color.MediumOrchid
        Me.sc.Views.DayView.Appearance.TimeRuler.Options.UseForeColor = True
        Me.sc.Views.DayView.AppointmentDisplayOptions.AppointmentAutoHeight = True
        Me.sc.Views.DayView.AppointmentDisplayOptions.SnapToCellsMode = DevExpress.XtraScheduler.AppointmentSnapToCellsMode.[Auto]
        Me.sc.Views.DayView.DayCount = 3
        Me.sc.Views.DayView.ShowAllAppointmentsAtTimeCells = True
        Me.sc.Views.DayView.ShowMoreButtonsOnEachColumn = True
        Me.sc.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.sc.Views.MonthView.Appearance.TodayCellHeaderCaption.ForeColor = System.Drawing.Color.Black
        Me.sc.Views.MonthView.Appearance.TodayCellHeaderCaption.Options.UseForeColor = True
        Me.sc.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.ForeColor = System.Drawing.Color.Black
        Me.sc.Views.MonthView.Appearance.TodayCellHeaderCaptionLine.Options.UseForeColor = True
        TimeScaleYear1.Enabled = False
        TimeScaleQuarter1.Enabled = False
        TimeScaleMonth1.Enabled = False
        TimeScaleWeek1.Enabled = False
        TimeScale15Minutes1.Enabled = False
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleYear1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleQuarter1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleMonth1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleWeek1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleDay1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScaleHour1)
        Me.sc.Views.TimelineView.Scales.Add(TimeScale15Minutes1)
        Me.sc.Views.TimelineView.SelectionBar.Visible = False
        Me.sc.Views.WorkWeekView.AllDayAreaScrollBarVisible = True
        Me.sc.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
        '
        'DateNavigator1
        '
        Me.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateNavigator1.HotDate = Nothing
        Me.DateNavigator1.Location = New System.Drawing.Point(504, 0)
        Me.DateNavigator1.Name = "DateNavigator1"
        Me.DateNavigator1.SchedulerControl = Me.sc
        Me.DateNavigator1.Size = New System.Drawing.Size(179, 406)
        Me.DateNavigator1.TabIndex = 1
        '
        'frmTestNgay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 406)
        Me.Controls.Add(Me.sc)
        Me.Controls.Add(Me.DateNavigator1)
        Me.Name = "frmTestNgay"
        Me.Text = "frmTestNgay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.st, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sc As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents st As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents DateNavigator1 As DevExpress.XtraScheduler.DateNavigator
End Class
