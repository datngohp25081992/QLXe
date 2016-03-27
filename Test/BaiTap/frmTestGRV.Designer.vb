<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestGRV
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtTenSV = New System.Windows.Forms.TextBox()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrvSinhVien = New System.Windows.Forms.DataGridView()
        Me.MaSV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenLop = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrvSinhVien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(199, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thông Tin Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sinh Viên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(35, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Sinh Viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Location = New System.Drawing.Point(387, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lớp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Location = New System.Drawing.Point(371, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Địa Chỉ"
        '
        'txtMaSV
        '
        Me.txtMaSV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtMaSV.Location = New System.Drawing.Point(115, 77)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(213, 20)
        Me.txtMaSV.TabIndex = 5
        '
        'txtTenSV
        '
        Me.txtTenSV.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTenSV.Location = New System.Drawing.Point(111, 125)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(217, 20)
        Me.txtTenSV.TabIndex = 6
        '
        'txtLop
        '
        Me.txtLop.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtLop.Location = New System.Drawing.Point(427, 77)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(241, 20)
        Me.txtLop.TabIndex = 7
        '
        'txtDiaChi
        '
        Me.txtDiaChi.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtDiaChi.Location = New System.Drawing.Point(427, 126)
        Me.txtDiaChi.Multiline = True
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(241, 97)
        Me.txtDiaChi.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrvSinhVien)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 247)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bảng Sinh Viên"
        '
        'GrvSinhVien
        '
        Me.GrvSinhVien.AllowUserToAddRows = False
        Me.GrvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrvSinhVien.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSV, Me.TenSV, Me.DiaChi, Me.TenLop})
        Me.GrvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrvSinhVien.Location = New System.Drawing.Point(3, 16)
        Me.GrvSinhVien.Name = "GrvSinhVien"
        Me.GrvSinhVien.Size = New System.Drawing.Size(687, 228)
        Me.GrvSinhVien.TabIndex = 0
        '
        'MaSV
        '
        Me.MaSV.DataPropertyName = "MaSV"
        Me.MaSV.FillWeight = 40.0!
        Me.MaSV.HeaderText = "Mã Sinh Viên"
        Me.MaSV.Name = "MaSV"
        '
        'TenSV
        '
        Me.TenSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenSV.DataPropertyName = "TenSV"
        Me.TenSV.FillWeight = 85.95601!
        Me.TenSV.HeaderText = "Tên Sinh Viên"
        Me.TenSV.Name = "TenSV"
        '
        'DiaChi
        '
        Me.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiaChi.DataPropertyName = "DiaChi"
        Me.DiaChi.FillWeight = 85.95601!
        Me.DiaChi.HeaderText = "Địa Chỉ"
        Me.DiaChi.Name = "DiaChi"
        '
        'TenLop
        '
        Me.TenLop.DataPropertyName = "TenLop"
        Me.TenLop.FillWeight = 85.95601!
        Me.TenLop.HeaderText = "Lớp"
        Me.TenLop.Name = "TenLop"
        '
        'frmTestGRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtLop)
        Me.Controls.Add(Me.txtTenSV)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTestGRV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTestGRV"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrvSinhVien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaSV As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSV As System.Windows.Forms.TextBox
    Friend WithEvents txtLop As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrvSinhVien As System.Windows.Forms.DataGridView
    Friend WithEvents MaSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenSV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaChi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenLop As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
