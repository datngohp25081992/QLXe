<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraXe
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbNguoiMuon = New System.Windows.Forms.ComboBox()
        Me.cbTenXe = New System.Windows.Forms.ComboBox()
        Me.cbTinhTrangTra = New System.Windows.Forms.ComboBox()
        Me.txtMoTa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSoKmDongHo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.dtNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.dtTraXeThuc = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBienSo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbNguoiMuon)
        Me.Panel1.Controls.Add(Me.cbTenXe)
        Me.Panel1.Controls.Add(Me.cbTinhTrangTra)
        Me.Panel1.Controls.Add(Me.txtMoTa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSoKmDongHo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btXoa)
        Me.Panel1.Controls.Add(Me.btThem)
        Me.Panel1.Controls.Add(Me.dtNgayMuon)
        Me.Panel1.Controls.Add(Me.dtTraXeThuc)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtNgayTra)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 252)
        Me.Panel1.TabIndex = 4
        '
        'cbNguoiMuon
        '
        Me.cbNguoiMuon.DisplayMember = "TenNV"
        Me.cbNguoiMuon.Enabled = False
        Me.cbNguoiMuon.FormattingEnabled = True
        Me.cbNguoiMuon.Location = New System.Drawing.Point(142, 48)
        Me.cbNguoiMuon.Name = "cbNguoiMuon"
        Me.cbNguoiMuon.Size = New System.Drawing.Size(174, 21)
        Me.cbNguoiMuon.TabIndex = 38
        Me.cbNguoiMuon.ValueMember = "MaNV"
        '
        'cbTenXe
        '
        Me.cbTenXe.DisplayMember = "TenXe"
        Me.cbTenXe.Enabled = False
        Me.cbTenXe.FormattingEnabled = True
        Me.cbTenXe.Location = New System.Drawing.Point(142, 15)
        Me.cbTenXe.Name = "cbTenXe"
        Me.cbTenXe.Size = New System.Drawing.Size(174, 21)
        Me.cbTenXe.TabIndex = 38
        Me.cbTenXe.ValueMember = "BienSo"
        '
        'cbTinhTrangTra
        '
        Me.cbTinhTrangTra.DisplayMember = "TenTinhTrang"
        Me.cbTinhTrangTra.FormattingEnabled = True
        Me.cbTinhTrangTra.Location = New System.Drawing.Point(425, 48)
        Me.cbTinhTrangTra.Name = "cbTinhTrangTra"
        Me.cbTinhTrangTra.Size = New System.Drawing.Size(189, 21)
        Me.cbTinhTrangTra.TabIndex = 38
        Me.cbTinhTrangTra.ValueMember = "MaTinhTrang"
        '
        'txtMoTa
        '
        Me.txtMoTa.Location = New System.Drawing.Point(425, 81)
        Me.txtMoTa.Multiline = True
        Me.txtMoTa.Name = "txtMoTa"
        Me.txtMoTa.Size = New System.Drawing.Size(189, 51)
        Me.txtMoTa.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(378, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mô Tả:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tình Trạng:"
        '
        'txtSoKmDongHo
        '
        Me.txtSoKmDongHo.Location = New System.Drawing.Point(142, 114)
        Me.txtSoKmDongHo.Name = "txtSoKmDongHo"
        Me.txtSoKmDongHo.Size = New System.Drawing.Size(174, 20)
        Me.txtSoKmDongHo.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Ngày mượn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Số km Đồng Hồ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Người mượn:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Tên Xe:"
        '
        'btXoa
        '
        Me.btXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btXoa.Location = New System.Drawing.Point(124, 217)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 23
        Me.btXoa.Text = "&Cancel"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(16, 217)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(75, 23)
        Me.btThem.TabIndex = 21
        Me.btThem.Text = "&Ok"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'dtNgayMuon
        '
        Me.dtNgayMuon.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtNgayMuon.Enabled = False
        Me.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtNgayMuon.Location = New System.Drawing.Point(142, 79)
        Me.dtNgayMuon.Name = "dtNgayMuon"
        Me.dtNgayMuon.Size = New System.Drawing.Size(174, 20)
        Me.dtNgayMuon.TabIndex = 17
        '
        'dtTraXeThuc
        '
        Me.dtTraXeThuc.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtTraXeThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTraXeThuc.Location = New System.Drawing.Point(142, 173)
        Me.dtTraXeThuc.Name = "dtTraXeThuc"
        Me.dtTraXeThuc.Size = New System.Drawing.Size(174, 20)
        Me.dtTraXeThuc.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Thời Gian Trả Xe:"
        '
        'dtNgayTra
        '
        Me.dtNgayTra.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtNgayTra.Enabled = False
        Me.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtNgayTra.Location = New System.Drawing.Point(142, 145)
        Me.dtNgayTra.Name = "dtNgayTra"
        Me.dtNgayTra.Size = New System.Drawing.Size(174, 20)
        Me.dtNgayTra.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Thời Gian Trả Xe Dự Kiến:"
        '
        'txtBienSo
        '
        Me.txtBienSo.Enabled = False
        Me.txtBienSo.Location = New System.Drawing.Point(431, 15)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(183, 20)
        Me.txtBienSo.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Biển Số:"
        '
        'frmTraXe
        '
        Me.AcceptButton = Me.btThem
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btXoa
        Me.ClientSize = New System.Drawing.Size(630, 252)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTraXe"
        Me.Text = "Trả Xe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbTinhTrangTra As System.Windows.Forms.ComboBox
    Friend WithEvents txtMoTa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSoKmDongHo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btXoa As System.Windows.Forms.Button
    Friend WithEvents btThem As System.Windows.Forms.Button
    Friend WithEvents dtNgayTra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbNguoiMuon As System.Windows.Forms.ComboBox
    Friend WithEvents cbTenXe As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtNgayMuon As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTraXeThuc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBienSo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
