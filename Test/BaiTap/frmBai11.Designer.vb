<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBai11))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckNhoMatKhau = New System.Windows.Forms.CheckBox()
        Me.btDangNhap = New System.Windows.Forms.Button()
        Me.btHuy = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(155, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ĐĂNG NHẬP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Đăng Nhập:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(214, 72)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(237, 20)
        Me.txtID.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(214, 111)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(237, 20)
        Me.txtPass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mật Khẩu:"
        '
        'ckNhoMatKhau
        '
        Me.ckNhoMatKhau.AutoSize = True
        Me.ckNhoMatKhau.Location = New System.Drawing.Point(214, 143)
        Me.ckNhoMatKhau.Name = "ckNhoMatKhau"
        Me.ckNhoMatKhau.Size = New System.Drawing.Size(95, 17)
        Me.ckNhoMatKhau.TabIndex = 6
        Me.ckNhoMatKhau.Text = "Nhớ Mật Khẩu"
        Me.ckNhoMatKhau.UseVisualStyleBackColor = True
        '
        'btDangNhap
        '
        Me.btDangNhap.Location = New System.Drawing.Point(214, 175)
        Me.btDangNhap.Name = "btDangNhap"
        Me.btDangNhap.Size = New System.Drawing.Size(104, 33)
        Me.btDangNhap.TabIndex = 7
        Me.btDangNhap.Text = "Đăng Nhập"
        Me.btDangNhap.UseVisualStyleBackColor = True
        '
        'btHuy
        '
        Me.btHuy.Location = New System.Drawing.Point(335, 175)
        Me.btHuy.Name = "btHuy"
        Me.btHuy.Size = New System.Drawing.Size(104, 33)
        Me.btHuy.TabIndex = 8
        Me.btHuy.Text = "Hủy Bỏ"
        Me.btHuy.UseVisualStyleBackColor = True
        '
        'frmBai11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 226)
        Me.Controls.Add(Me.btHuy)
        Me.Controls.Add(Me.btDangNhap)
        Me.Controls.Add(Me.ckNhoMatKhau)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmBai11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai11"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckNhoMatKhau As System.Windows.Forms.CheckBox
    Friend WithEvents btDangNhap As System.Windows.Forms.Button
    Friend WithEvents btHuy As System.Windows.Forms.Button
End Class
