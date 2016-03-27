<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai10
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
        Me.txtKetQua = New System.Windows.Forms.TextBox()
        Me.btKetQua = New System.Windows.Forms.Button()
        Me.txtChuoi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtChuoiBatKi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtKetQua
        '
        Me.txtKetQua.Location = New System.Drawing.Point(98, 87)
        Me.txtKetQua.Name = "txtKetQua"
        Me.txtKetQua.Size = New System.Drawing.Size(384, 20)
        Me.txtKetQua.TabIndex = 7
        '
        'btKetQua
        '
        Me.btKetQua.Location = New System.Drawing.Point(30, 87)
        Me.btKetQua.Name = "btKetQua"
        Me.btKetQua.Size = New System.Drawing.Size(62, 23)
        Me.btKetQua.TabIndex = 6
        Me.btKetQua.Text = "Kết quả"
        Me.btKetQua.UseVisualStyleBackColor = True
        '
        'txtChuoi
        '
        Me.txtChuoi.Location = New System.Drawing.Point(98, 25)
        Me.txtChuoi.Name = "txtChuoi"
        Me.txtChuoi.Size = New System.Drawing.Size(384, 20)
        Me.txtChuoi.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nhập chuỗi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nhập chuỗi:"
        '
        'txtChuoiBatKi
        '
        Me.txtChuoiBatKi.Location = New System.Drawing.Point(98, 54)
        Me.txtChuoiBatKi.Name = "txtChuoiBatKi"
        Me.txtChuoiBatKi.Size = New System.Drawing.Size(384, 20)
        Me.txtChuoiBatKi.TabIndex = 9
        '
        'frmBai10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 159)
        Me.Controls.Add(Me.txtChuoiBatKi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKetQua)
        Me.Controls.Add(Me.btKetQua)
        Me.Controls.Add(Me.txtChuoi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKetQua As System.Windows.Forms.TextBox
    Friend WithEvents btKetQua As System.Windows.Forms.Button
    Friend WithEvents txtChuoi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtChuoiBatKi As System.Windows.Forms.TextBox
End Class
