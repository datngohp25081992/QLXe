<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTongInt = New System.Windows.Forms.TextBox()
        Me.btKetQua = New System.Windows.Forms.Button()
        Me.txtSoNguyen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTongStr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(34, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "S ="
        '
        'txtTongInt
        '
        Me.txtTongInt.Location = New System.Drawing.Point(92, 95)
        Me.txtTongInt.Name = "txtTongInt"
        Me.txtTongInt.Size = New System.Drawing.Size(248, 20)
        Me.txtTongInt.TabIndex = 12
        '
        'btKetQua
        '
        Me.btKetQua.Location = New System.Drawing.Point(276, 25)
        Me.btKetQua.Name = "btKetQua"
        Me.btKetQua.Size = New System.Drawing.Size(75, 23)
        Me.btKetQua.TabIndex = 11
        Me.btKetQua.Text = "Tính Tổng"
        Me.btKetQua.UseVisualStyleBackColor = True
        '
        'txtSoNguyen
        '
        Me.txtSoNguyen.Location = New System.Drawing.Point(161, 27)
        Me.txtSoNguyen.Name = "txtSoNguyen"
        Me.txtSoNguyen.Size = New System.Drawing.Size(100, 20)
        Me.txtSoNguyen.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(34, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nhập số tự nhiên N ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(34, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "S ="
        '
        'txtTongStr
        '
        Me.txtTongStr.Location = New System.Drawing.Point(92, 62)
        Me.txtTongStr.Name = "txtTongStr"
        Me.txtTongStr.Size = New System.Drawing.Size(248, 20)
        Me.txtTongStr.TabIndex = 14
        '
        'frmBai4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 180)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTongStr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTongInt)
        Me.Controls.Add(Me.btKetQua)
        Me.Controls.Add(Me.txtSoNguyen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTongInt As System.Windows.Forms.TextBox
    Friend WithEvents btKetQua As System.Windows.Forms.Button
    Friend WithEvents txtSoNguyen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTongStr As System.Windows.Forms.TextBox
End Class
