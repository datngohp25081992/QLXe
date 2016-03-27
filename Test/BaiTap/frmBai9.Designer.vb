<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai9
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
        Me.txtChuoi = New System.Windows.Forms.TextBox()
        Me.btKetQua = New System.Windows.Forms.Button()
        Me.txtKetQua = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập chuỗi:"
        '
        'txtChuoi
        '
        Me.txtChuoi.Location = New System.Drawing.Point(98, 20)
        Me.txtChuoi.Name = "txtChuoi"
        Me.txtChuoi.Size = New System.Drawing.Size(384, 20)
        Me.txtChuoi.TabIndex = 1
        '
        'btKetQua
        '
        Me.btKetQua.Location = New System.Drawing.Point(30, 58)
        Me.btKetQua.Name = "btKetQua"
        Me.btKetQua.Size = New System.Drawing.Size(62, 23)
        Me.btKetQua.TabIndex = 2
        Me.btKetQua.Text = "Kết quả"
        Me.btKetQua.UseVisualStyleBackColor = True
        '
        'txtKetQua
        '
        Me.txtKetQua.Location = New System.Drawing.Point(98, 58)
        Me.txtKetQua.Name = "txtKetQua"
        Me.txtKetQua.Size = New System.Drawing.Size(100, 20)
        Me.txtKetQua.TabIndex = 3
        '
        'frmBai9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 115)
        Me.Controls.Add(Me.txtKetQua)
        Me.Controls.Add(Me.btKetQua)
        Me.Controls.Add(Me.txtChuoi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChuoi As System.Windows.Forms.TextBox
    Friend WithEvents btKetQua As System.Windows.Forms.Button
    Friend WithEvents txtKetQua As System.Windows.Forms.TextBox
End Class
