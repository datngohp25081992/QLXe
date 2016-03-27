<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTinhToan
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
        Me.lbKetQua = New System.Windows.Forms.Label()
        Me.txtSoA = New System.Windows.Forms.TextBox()
        Me.txtSoB = New System.Windows.Forms.TextBox()
        Me.txtKetQua = New System.Windows.Forms.TextBox()
        Me.cbPhepToan = New System.Windows.Forms.ComboBox()
        Me.btTinh = New System.Windows.Forms.Button()
        Me.btUCLN = New System.Windows.Forms.Button()
        Me.btBCNN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số B:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phép Tính:"
        '
        'lbKetQua
        '
        Me.lbKetQua.AutoSize = True
        Me.lbKetQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbKetQua.Location = New System.Drawing.Point(48, 196)
        Me.lbKetQua.Name = "lbKetQua"
        Me.lbKetQua.Size = New System.Drawing.Size(64, 17)
        Me.lbKetQua.TabIndex = 3
        Me.lbKetQua.Text = "Kết Quả:"
        '
        'txtSoA
        '
        Me.txtSoA.Location = New System.Drawing.Point(141, 25)
        Me.txtSoA.Name = "txtSoA"
        Me.txtSoA.Size = New System.Drawing.Size(138, 20)
        Me.txtSoA.TabIndex = 4
        '
        'txtSoB
        '
        Me.txtSoB.Location = New System.Drawing.Point(141, 65)
        Me.txtSoB.Name = "txtSoB"
        Me.txtSoB.Size = New System.Drawing.Size(138, 20)
        Me.txtSoB.TabIndex = 5
        '
        'txtKetQua
        '
        Me.txtKetQua.Enabled = False
        Me.txtKetQua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKetQua.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKetQua.Location = New System.Drawing.Point(141, 195)
        Me.txtKetQua.Name = "txtKetQua"
        Me.txtKetQua.Size = New System.Drawing.Size(138, 21)
        Me.txtKetQua.TabIndex = 6
        '
        'cbPhepToan
        '
        Me.cbPhepToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPhepToan.FormattingEnabled = True
        Me.cbPhepToan.Items.AddRange(New Object() {"Cộng", "Trừ", "Nhân", "Chia"})
        Me.cbPhepToan.Location = New System.Drawing.Point(141, 108)
        Me.cbPhepToan.Name = "cbPhepToan"
        Me.cbPhepToan.Size = New System.Drawing.Size(121, 21)
        Me.cbPhepToan.TabIndex = 7
        '
        'btTinh
        '
        Me.btTinh.Location = New System.Drawing.Point(51, 149)
        Me.btTinh.Name = "btTinh"
        Me.btTinh.Size = New System.Drawing.Size(87, 25)
        Me.btTinh.TabIndex = 8
        Me.btTinh.Text = "Tính"
        Me.btTinh.UseVisualStyleBackColor = True
        '
        'btUCLN
        '
        Me.btUCLN.Location = New System.Drawing.Point(159, 149)
        Me.btUCLN.Name = "btUCLN"
        Me.btUCLN.Size = New System.Drawing.Size(87, 25)
        Me.btUCLN.TabIndex = 9
        Me.btUCLN.Text = "UCLN"
        Me.btUCLN.UseVisualStyleBackColor = True
        '
        'btBCNN
        '
        Me.btBCNN.Location = New System.Drawing.Point(263, 149)
        Me.btBCNN.Name = "btBCNN"
        Me.btBCNN.Size = New System.Drawing.Size(87, 25)
        Me.btBCNN.TabIndex = 10
        Me.btBCNN.Text = "BCNN"
        Me.btBCNN.UseVisualStyleBackColor = True
        '
        'frmTinhToan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 281)
        Me.Controls.Add(Me.btBCNN)
        Me.Controls.Add(Me.btUCLN)
        Me.Controls.Add(Me.btTinh)
        Me.Controls.Add(Me.cbPhepToan)
        Me.Controls.Add(Me.txtKetQua)
        Me.Controls.Add(Me.txtSoB)
        Me.Controls.Add(Me.txtSoA)
        Me.Controls.Add(Me.lbKetQua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTinhToan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbKetQua As System.Windows.Forms.Label
    Friend WithEvents txtSoA As System.Windows.Forms.TextBox
    Friend WithEvents txtSoB As System.Windows.Forms.TextBox
    Friend WithEvents cbPhepToan As System.Windows.Forms.ComboBox
    Friend WithEvents btTinh As System.Windows.Forms.Button
    Friend WithEvents btUCLN As System.Windows.Forms.Button
    Friend WithEvents btBCNN As System.Windows.Forms.Button
    Friend WithEvents txtKetQua As System.Windows.Forms.TextBox

End Class
