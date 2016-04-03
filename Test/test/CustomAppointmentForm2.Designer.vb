<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAppointmentForm2
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
        Me.lkuNhanVien = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btOk = New System.Windows.Forms.Button()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
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
        'lblSubject
        '
        Me.lblSubject.Size = New System.Drawing.Size(38, 13)
        Me.lblSubject.Text = "Tên NV:"
        '
        'lblLocation
        '
        Me.lblLocation.Size = New System.Drawing.Size(49, 13)
        Me.lblLocation.Text = "Lịch Trình:"
        '
        'lblLabel
        '
        Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblLabel.Location = New System.Drawing.Point(8, 3)
        Me.lblLabel.Size = New System.Drawing.Size(61, 13)
        Me.lblLabel.Text = "Độ Q.Trọng:"
        '
        'lblStartTime
        '
        Me.lblStartTime.Location = New System.Drawing.Point(1, 81)
        Me.lblStartTime.Size = New System.Drawing.Size(78, 13)
        Me.lblStartTime.Text = "Thời Gian Mượn:"
        '
        'lblEndTime
        '
        Me.lblEndTime.Location = New System.Drawing.Point(11, 110)
        Me.lblEndTime.Size = New System.Drawing.Size(67, 13)
        Me.lblEndTime.Text = "Thời Gian Trả:"
        '
        'chkAllDay
        '
        '
        'btnOk
        '
        Me.btnOk.AccessibleName = ""
        Me.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnOk.Location = New System.Drawing.Point(558, 412)
        Me.btnOk.Size = New System.Drawing.Size(10, 10)
        Me.btnOk.Visible = False
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
        Me.edtStartDate.Size = New System.Drawing.Size(176, 20)
        '
        'edtEndDate
        '
        Me.edtEndDate.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndDate.Size = New System.Drawing.Size(176, 20)
        '
        'edtStartTime
        '
        Me.edtStartTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtStartTime.Location = New System.Drawing.Point(280, 79)
        '
        'edtEndTime
        '
        Me.edtEndTime.EditValue = New Date(2005, 3, 31, 0, 0, 0, 0)
        Me.edtEndTime.Location = New System.Drawing.Point(280, 103)
        '
        'edtLabel
        '
        '
        'edtShowTimeAs
        '
        Me.edtShowTimeAs.Size = New System.Drawing.Size(272, 20)
        '
        'tbSubject
        '
        Me.tbSubject.Location = New System.Drawing.Point(96, 11)
        Me.tbSubject.Size = New System.Drawing.Size(472, 20)
        '
        'edtResource
        '
        '
        'lblResource
        '
        Me.lblResource.Size = New System.Drawing.Size(37, 13)
        Me.lblResource.Text = "Tên Xe:"
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
        Me.tbDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDescription.Location = New System.Drawing.Point(16, 216)
        Me.tbDescription.Size = New System.Drawing.Size(552, 165)
        '
        'cbReminder
        '
        '
        'tbLocation
        '
        Me.tbLocation.Size = New System.Drawing.Size(272, 20)
        '
        'panel1
        '
        Me.panel1.Location = New System.Drawing.Point(374, 41)
        Me.panel1.Size = New System.Drawing.Size(199, 125)
        '
        'progressPanel
        '
        Me.progressPanel.Location = New System.Drawing.Point(575, 197)
        Me.progressPanel.Size = New System.Drawing.Size(552, 30)
        '
        'tbProgress
        '
        Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
        Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tbProgress.Size = New System.Drawing.Size(443, 27)
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentComplete.Location = New System.Drawing.Point(3, 10)
        Me.lblPercentComplete.Visible = False
        '
        'lblPercentCompleteValue
        '
        Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentCompleteValue.Location = New System.Drawing.Point(534, 10)
        '
        'lkuNhanVien
        '
        Me.lkuNhanVien.Location = New System.Drawing.Point(96, 168)
        Me.lkuNhanVien.Name = "lkuNhanVien"
        Me.lkuNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkuNhanVien.Size = New System.Drawing.Size(216, 20)
        Me.lkuNhanVien.TabIndex = 32
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 169)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 31
        Me.LabelControl1.Text = "Người Mượn:"
        '
        'btOk
        '
        Me.btOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btOk.Location = New System.Drawing.Point(16, 390)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(75, 23)
        Me.btOk.TabIndex = 33
        Me.btOk.Text = "&Ok"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(16, 197)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Mục Đích:"
        '
        'CustomAppointmentForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 424)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.lkuNhanVien)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "CustomAppointmentForm2"
        Me.Text = "Đạt"
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
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.tbDescription, 0)
        Me.Controls.SetChildIndex(Me.lkuNhanVien, 0)
        Me.Controls.SetChildIndex(Me.btOk, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
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
    Friend WithEvents lkuNhanVien As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btOk As System.Windows.Forms.Button
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl

End Class
