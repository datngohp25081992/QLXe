<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai3
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
        Me.txtSoNguyen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtKetQua
        '
        Me.txtKetQua.Location = New System.Drawing.Point(70, 74)
        Me.txtKetQua.Name = "txtKetQua"
        Me.txtKetQua.Size = New System.Drawing.Size(227, 20)
        Me.txtKetQua.TabIndex = 7
        '
        'btKetQua
        '
        Me.btKetQua.Location = New System.Drawing.Point(254, 16)
        Me.btKetQua.Name = "btKetQua"
        Me.btKetQua.Size = New System.Drawing.Size(75, 23)
        Me.btKetQua.TabIndex = 6
        Me.btKetQua.Text = "Tính Tổng"
        Me.btKetQua.UseVisualStyleBackColor = True
        '
        'txtSoNguyen
        '
        Me.txtSoNguyen.Location = New System.Drawing.Point(139, 18)
        Me.txtSoNguyen.Name = "txtSoNguyen"
        Me.txtSoNguyen.Size = New System.Drawing.Size(100, 20)
        Me.txtSoNguyen.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nhập số tự nhiên N ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "N! ="
        '
        'frmBai3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 152)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKetQua)
        Me.Controls.Add(Me.btKetQua)
        Me.Controls.Add(Me.txtSoNguyen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBai3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKetQua As System.Windows.Forms.TextBox
    Friend WithEvents btKetQua As System.Windows.Forms.Button
    Friend WithEvents txtSoNguyen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
