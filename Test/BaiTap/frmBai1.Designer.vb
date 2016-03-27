<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSoC = New System.Windows.Forms.TextBox()
        Me.txtSoB = New System.Windows.Forms.TextBox()
        Me.txtSoA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTong = New System.Windows.Forms.TextBox()
        Me.txtNhoNhat = New System.Windows.Forms.TextBox()
        Me.txtLonNhat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btTim = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-142, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(37, 44)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSoC)
        Me.GroupBox2.Controls.Add(Me.txtSoB)
        Me.GroupBox2.Controls.Add(Me.txtSoA)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(493, 82)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nhập dữ liệu"
        '
        'txtSoC
        '
        Me.txtSoC.Location = New System.Drawing.Point(422, 23)
        Me.txtSoC.Name = "txtSoC"
        Me.txtSoC.Size = New System.Drawing.Size(47, 20)
        Me.txtSoC.TabIndex = 12
        '
        'txtSoB
        '
        Me.txtSoB.Location = New System.Drawing.Point(231, 23)
        Me.txtSoB.Name = "txtSoB"
        Me.txtSoB.Size = New System.Drawing.Size(47, 20)
        Me.txtSoB.TabIndex = 11
        '
        'txtSoA
        '
        Me.txtSoA.Location = New System.Drawing.Point(62, 23)
        Me.txtSoA.Name = "txtSoA"
        Me.txtSoA.Size = New System.Drawing.Size(47, 20)
        Me.txtSoA.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Số C:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số B:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Số A:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTong)
        Me.GroupBox3.Controls.Add(Me.txtNhoNhat)
        Me.GroupBox3.Controls.Add(Me.txtLonNhat)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 79)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kết quả"
        '
        'txtTong
        '
        Me.txtTong.Enabled = False
        Me.txtTong.Location = New System.Drawing.Point(422, 23)
        Me.txtTong.Name = "txtTong"
        Me.txtTong.Size = New System.Drawing.Size(47, 20)
        Me.txtTong.TabIndex = 12
        '
        'txtNhoNhat
        '
        Me.txtNhoNhat.Enabled = False
        Me.txtNhoNhat.Location = New System.Drawing.Point(231, 23)
        Me.txtNhoNhat.Name = "txtNhoNhat"
        Me.txtNhoNhat.Size = New System.Drawing.Size(47, 20)
        Me.txtNhoNhat.TabIndex = 11
        '
        'txtLonNhat
        '
        Me.txtLonNhat.Enabled = False
        Me.txtLonNhat.Location = New System.Drawing.Point(62, 23)
        Me.txtLonNhat.Name = "txtLonNhat"
        Me.txtLonNhat.Size = New System.Drawing.Size(47, 20)
        Me.txtLonNhat.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tổng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Số NN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Số LN:"
        '
        'btTim
        '
        Me.btTim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTim.Location = New System.Drawing.Point(74, 112)
        Me.btTim.Name = "btTim"
        Me.btTim.Size = New System.Drawing.Size(163, 47)
        Me.btTim.TabIndex = 14
        Me.btTim.Text = "Tìm"
        Me.btTim.UseVisualStyleBackColor = True
        '
        'frmBai1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 288)
        Me.Controls.Add(Me.btTim)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBai1"
        Me.Text = "frmUclnBcnn"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSoC As System.Windows.Forms.TextBox
    Friend WithEvents txtSoB As System.Windows.Forms.TextBox
    Friend WithEvents txtSoA As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTong As System.Windows.Forms.TextBox
    Friend WithEvents txtNhoNhat As System.Windows.Forms.TextBox
    Friend WithEvents txtLonNhat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btTim As System.Windows.Forms.Button
End Class
