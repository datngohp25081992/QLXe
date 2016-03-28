<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXeDangMuon
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
        Me.txtBienSo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoCMND = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbTenXe = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.cbNguoiMuon = New System.Windows.Forms.ComboBox()
        Me.txtDiaDiem = New System.Windows.Forms.TextBox()
        Me.txtMucDich = New System.Windows.Forms.TextBox()
        Me.dtNgayTra = New System.Windows.Forms.DateTimePicker()
        Me.dtNgayMuon = New System.Windows.Forms.DateTimePicker()
        Me.dtDkMuonXe = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBienSo
        '
        Me.txtBienSo.Enabled = False
        Me.txtBienSo.Location = New System.Drawing.Point(443, 14)
        Me.txtBienSo.Name = "txtBienSo"
        Me.txtBienSo.Size = New System.Drawing.Size(174, 20)
        Me.txtBienSo.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Biển Số:"
        '
        'txtSoCMND
        '
        Me.txtSoCMND.Enabled = False
        Me.txtSoCMND.Location = New System.Drawing.Point(118, 75)
        Me.txtSoCMND.Name = "txtSoCMND"
        Me.txtSoCMND.Size = New System.Drawing.Size(190, 20)
        Me.txtSoCMND.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Số CMND:"
        '
        'cbTenXe
        '
        Me.cbTenXe.DisplayMember = "TenXe"
        Me.cbTenXe.FormattingEnabled = True
        Me.cbTenXe.Location = New System.Drawing.Point(118, 14)
        Me.cbTenXe.Name = "cbTenXe"
        Me.cbTenXe.Size = New System.Drawing.Size(190, 21)
        Me.cbTenXe.TabIndex = 48
        Me.cbTenXe.ValueMember = "BienSo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tên Xe:"
        '
        'btXoa
        '
        Me.btXoa.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btXoa.Location = New System.Drawing.Point(118, 157)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 46
        Me.btXoa.Text = "&Cancel"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(15, 157)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(75, 23)
        Me.btThem.TabIndex = 45
        Me.btThem.Text = "&Ok"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'cbNguoiMuon
        '
        Me.cbNguoiMuon.DisplayMember = "TenNV"
        Me.cbNguoiMuon.FormattingEnabled = True
        Me.cbNguoiMuon.Location = New System.Drawing.Point(118, 46)
        Me.cbNguoiMuon.Name = "cbNguoiMuon"
        Me.cbNguoiMuon.Size = New System.Drawing.Size(190, 21)
        Me.cbNguoiMuon.TabIndex = 44
        Me.cbNguoiMuon.ValueMember = "MaNV"
        '
        'txtDiaDiem
        '
        Me.txtDiaDiem.Location = New System.Drawing.Point(443, 130)
        Me.txtDiaDiem.Multiline = True
        Me.txtDiaDiem.Name = "txtDiaDiem"
        Me.txtDiaDiem.Size = New System.Drawing.Size(174, 47)
        Me.txtDiaDiem.TabIndex = 43
        '
        'txtMucDich
        '
        Me.txtMucDich.Location = New System.Drawing.Point(118, 107)
        Me.txtMucDich.Multiline = True
        Me.txtMucDich.Name = "txtMucDich"
        Me.txtMucDich.Size = New System.Drawing.Size(190, 47)
        Me.txtMucDich.TabIndex = 42
        '
        'dtNgayTra
        '
        Me.dtNgayTra.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtNgayTra.Location = New System.Drawing.Point(443, 95)
        Me.dtNgayTra.Name = "dtNgayTra"
        Me.dtNgayTra.Size = New System.Drawing.Size(174, 20)
        Me.dtNgayTra.TabIndex = 41
        '
        'dtNgayMuon
        '
        Me.dtNgayMuon.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtNgayMuon.Location = New System.Drawing.Point(443, 66)
        Me.dtNgayMuon.Name = "dtNgayMuon"
        Me.dtNgayMuon.Size = New System.Drawing.Size(174, 20)
        Me.dtNgayMuon.TabIndex = 40
        '
        'dtDkMuonXe
        '
        Me.dtDkMuonXe.CustomFormat = "dd/MM/yyyy"
        Me.dtDkMuonXe.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDkMuonXe.Location = New System.Drawing.Point(443, 40)
        Me.dtDkMuonXe.Name = "dtDkMuonXe"
        Me.dtDkMuonXe.Size = New System.Drawing.Size(174, 20)
        Me.dtDkMuonXe.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Mục Đích Mượn:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Địa Điểm Đến:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(346, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Thời Gian Trả Xe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Thời Gian Mượn Xe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Người Mượn:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(335, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Ngày ĐK Mượn Xe:"
        '
        'frmXeDangMuon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 194)
        Me.Controls.Add(Me.txtBienSo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSoCMND)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbTenXe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.cbNguoiMuon)
        Me.Controls.Add(Me.txtDiaDiem)
        Me.Controls.Add(Me.txtMucDich)
        Me.Controls.Add(Me.dtNgayTra)
        Me.Controls.Add(Me.dtNgayMuon)
        Me.Controls.Add(Me.dtDkMuonXe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmXeDangMuon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yêu Cầu Mượn Xe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBienSo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoCMND As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbTenXe As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btXoa As System.Windows.Forms.Button
    Friend WithEvents btThem As System.Windows.Forms.Button
    Friend WithEvents cbNguoiMuon As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiaDiem As System.Windows.Forms.TextBox
    Friend WithEvents txtMucDich As System.Windows.Forms.TextBox
    Friend WithEvents dtNgayTra As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtNgayMuon As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDkMuonXe As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
