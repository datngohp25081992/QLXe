<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai6
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
        Me.txtNgay = New System.Windows.Forms.TextBox()
        Me.txtThang = New System.Windows.Forms.TextBox()
        Me.txtNam = New System.Windows.Forms.TextBox()
        Me.btKiemTra = New System.Windows.Forms.Button()
        Me.lbKiemTraNgay = New System.Windows.Forms.Label()
        Me.lbKiemTraQuy = New System.Windows.Forms.Label()
        Me.lbTruocSau = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngày"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Năm"
        '
        'txtNgay
        '
        Me.txtNgay.Location = New System.Drawing.Point(63, 22)
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.Size = New System.Drawing.Size(67, 20)
        Me.txtNgay.TabIndex = 3
        '
        'txtThang
        '
        Me.txtThang.Location = New System.Drawing.Point(210, 22)
        Me.txtThang.Name = "txtThang"
        Me.txtThang.Size = New System.Drawing.Size(67, 20)
        Me.txtThang.TabIndex = 4
        '
        'txtNam
        '
        Me.txtNam.Location = New System.Drawing.Point(356, 22)
        Me.txtNam.Name = "txtNam"
        Me.txtNam.Size = New System.Drawing.Size(67, 20)
        Me.txtNam.TabIndex = 5
        '
        'btKiemTra
        '
        Me.btKiemTra.Location = New System.Drawing.Point(28, 71)
        Me.btKiemTra.Name = "btKiemTra"
        Me.btKiemTra.Size = New System.Drawing.Size(75, 23)
        Me.btKiemTra.TabIndex = 6
        Me.btKiemTra.Text = "Kiểm Tra"
        Me.btKiemTra.UseVisualStyleBackColor = True
        '
        'lbKiemTraNgay
        '
        Me.lbKiemTraNgay.AutoSize = True
        Me.lbKiemTraNgay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKiemTraNgay.Location = New System.Drawing.Point(25, 116)
        Me.lbKiemTraNgay.Name = "lbKiemTraNgay"
        Me.lbKiemTraNgay.Size = New System.Drawing.Size(51, 15)
        Me.lbKiemTraNgay.TabIndex = 7
        Me.lbKiemTraNgay.Text = "Label4"
        Me.lbKiemTraNgay.Visible = False
        '
        'lbKiemTraQuy
        '
        Me.lbKiemTraQuy.AutoSize = True
        Me.lbKiemTraQuy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKiemTraQuy.Location = New System.Drawing.Point(25, 142)
        Me.lbKiemTraQuy.Name = "lbKiemTraQuy"
        Me.lbKiemTraQuy.Size = New System.Drawing.Size(51, 15)
        Me.lbKiemTraQuy.TabIndex = 8
        Me.lbKiemTraQuy.Text = "Label5"
        Me.lbKiemTraQuy.Visible = False
        '
        'lbTruocSau
        '
        Me.lbTruocSau.AutoSize = True
        Me.lbTruocSau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTruocSau.Location = New System.Drawing.Point(25, 169)
        Me.lbTruocSau.Name = "lbTruocSau"
        Me.lbTruocSau.Size = New System.Drawing.Size(51, 15)
        Me.lbTruocSau.TabIndex = 9
        Me.lbTruocSau.Text = "Label6"
        Me.lbTruocSau.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 71)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Kiểm Tra"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmBai6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 215)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbTruocSau)
        Me.Controls.Add(Me.lbKiemTraQuy)
        Me.Controls.Add(Me.lbKiemTraNgay)
        Me.Controls.Add(Me.btKiemTra)
        Me.Controls.Add(Me.txtNam)
        Me.Controls.Add(Me.txtThang)
        Me.Controls.Add(Me.txtNgay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNgay As System.Windows.Forms.TextBox
    Friend WithEvents txtThang As System.Windows.Forms.TextBox
    Friend WithEvents txtNam As System.Windows.Forms.TextBox
    Friend WithEvents btKiemTra As System.Windows.Forms.Button
    Friend WithEvents lbKiemTraNgay As System.Windows.Forms.Label
    Friend WithEvents lbKiemTraQuy As System.Windows.Forms.Label
    Friend WithEvents lbTruocSau As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
