<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai7
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
        Me.txtDanhSachSo = New System.Windows.Forms.TextBox()
        Me.txtSoChan = New System.Windows.Forms.TextBox()
        Me.txtSoLe = New System.Windows.Forms.TextBox()
        Me.btSapXep = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập danh sách số:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số chẵn:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Số lẻ:"
        '
        'txtDanhSachSo
        '
        Me.txtDanhSachSo.Location = New System.Drawing.Point(133, 22)
        Me.txtDanhSachSo.Name = "txtDanhSachSo"
        Me.txtDanhSachSo.Size = New System.Drawing.Size(507, 20)
        Me.txtDanhSachSo.TabIndex = 3
        '
        'txtSoChan
        '
        Me.txtSoChan.Location = New System.Drawing.Point(133, 57)
        Me.txtSoChan.Name = "txtSoChan"
        Me.txtSoChan.Size = New System.Drawing.Size(507, 20)
        Me.txtSoChan.TabIndex = 4
        '
        'txtSoLe
        '
        Me.txtSoLe.Location = New System.Drawing.Point(133, 100)
        Me.txtSoLe.Name = "txtSoLe"
        Me.txtSoLe.Size = New System.Drawing.Size(507, 20)
        Me.txtSoLe.TabIndex = 5
        '
        'btSapXep
        '
        Me.btSapXep.Location = New System.Drawing.Point(45, 143)
        Me.btSapXep.Name = "btSapXep"
        Me.btSapXep.Size = New System.Drawing.Size(75, 23)
        Me.btSapXep.TabIndex = 6
        Me.btSapXep.Text = "Sắp xếp"
        Me.btSapXep.UseVisualStyleBackColor = True
        '
        'frmBai7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 189)
        Me.Controls.Add(Me.btSapXep)
        Me.Controls.Add(Me.txtSoLe)
        Me.Controls.Add(Me.txtSoChan)
        Me.Controls.Add(Me.txtDanhSachSo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDanhSachSo As System.Windows.Forms.TextBox
    Friend WithEvents txtSoChan As System.Windows.Forms.TextBox
    Friend WithEvents txtSoLe As System.Windows.Forms.TextBox
    Friend WithEvents btSapXep As System.Windows.Forms.Button
End Class
