<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAppointmentForm1
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkuNhanVien = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.progressPanel.SuspendLayout()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkuNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
        '
        'lblStartTime
        '
        Me.lblStartTime.Location = New System.Drawing.Point(16, 105)
        '
        'lblEndTime
        '
        Me.lblEndTime.Location = New System.Drawing.Point(16, 130)
        '
        'lblShowTimeAs
        '
        Me.lblShowTimeAs.Location = New System.Drawing.Point(16, 167)
        '
        'chkAllDay
        '
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(16, 390)
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(104, 390)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(192, 390)
        '
        'btnRecurrence
        '
        Me.btnRecurrence.Location = New System.Drawing.Point(280, 390)
        '
        'edtStartDate
        '
        Me.edtStartDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartDate.Location = New System.Drawing.Point(96, 102)
        '
        'edtEndDate
        '
        Me.edtEndDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndDate.Location = New System.Drawing.Point(96, 127)
        '
        'edtStartTime
        '
        Me.edtStartTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartTime.Location = New System.Drawing.Point(224, 103)
        '
        'edtEndTime
        '
        Me.edtEndTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndTime.Location = New System.Drawing.Point(224, 127)
        '
        'edtLabel
        '
        '
        'edtShowTimeAs
        '
        Me.edtShowTimeAs.Location = New System.Drawing.Point(96, 164)
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(96, 11)
        '
        'edtResource
        '
        '
        'edtResources
        '
        '
        '
        '
        Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
        Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
        Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
        Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
        Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
        '
        'chkReminder
        '
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(16, 233)
        Me.tbDescription.Size = New System.Drawing.Size(496, 148)
        '
        'cbReminder
        '
        '
        'tbLocation
        '
        '
        'progressPanel
        '
        Me.progressPanel.Location = New System.Drawing.Point(16, 197)
        '
        'tbProgress
        '
        Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
        '
        'lblPercentCompleteValue
        '
        Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "MaNV:"
        '
        'lkuNhanVien
        '
        Me.lkuNhanVien.Location = New System.Drawing.Point(96, 70)
        Me.lkuNhanVien.Name = "lkuNhanVien"
        Me.lkuNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkuNhanVien.Size = New System.Drawing.Size(216, 20)
        Me.lkuNhanVien.TabIndex = 30
        '
        'CustomAppointmentForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(528, 424)
        Me.Controls.Add(Me.lkuNhanVien)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "CustomAppointmentForm1"
        Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.edtEndTime, 0)
        Me.Controls.SetChildIndex(Me.edtEndDate, 0)
        Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnCancel, 0)
        Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
        Me.Controls.SetChildIndex(Me.lblEndTime, 0)
        Me.Controls.SetChildIndex(Me.tbLocation, 0)
        Me.Controls.SetChildIndex(Me.lblSubject, 0)
        Me.Controls.SetChildIndex(Me.lblLocation, 0)
        Me.Controls.SetChildIndex(Me.tbSubject, 0)
        Me.Controls.SetChildIndex(Me.lblStartTime, 0)
        Me.Controls.SetChildIndex(Me.btnOk, 0)
        Me.Controls.SetChildIndex(Me.edtStartDate, 0)
        Me.Controls.SetChildIndex(Me.edtStartTime, 0)
        Me.Controls.SetChildIndex(Me.panel1, 0)
        Me.Controls.SetChildIndex(Me.progressPanel, 0)
        Me.Controls.SetChildIndex(Me.tbDescription, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.lkuNhanVien, 0)
        CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.progressPanel.ResumeLayout(False)
        Me.progressPanel.PerformLayout()
        CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkuNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkuNhanVien As DevExpress.XtraEditors.LookUpEdit

End Class
