<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBai5
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
        Me.txtLuong = New System.Windows.Forms.TextBox()
        Me.btTinhLuong = New System.Windows.Forms.Button()
        Me.txtThamNien = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(30, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lương ="
        '
        'txtLuong
        '
        Me.txtLuong.Location = New System.Drawing.Point(88, 80)
        Me.txtLuong.Name = "txtLuong"
        Me.txtLuong.Size = New System.Drawing.Size(227, 20)
        Me.txtLuong.TabIndex = 12
        '
        'btTinhLuong
        '
        Me.btTinhLuong.Location = New System.Drawing.Point(272, 22)
        Me.btTinhLuong.Name = "btTinhLuong"
        Me.btTinhLuong.Size = New System.Drawing.Size(75, 23)
        Me.btTinhLuong.TabIndex = 11
        Me.btTinhLuong.Text = "Tính lương"
        Me.btTinhLuong.UseVisualStyleBackColor = True
        '
        'txtThamNien
        '
        Me.txtThamNien.Location = New System.Drawing.Point(157, 24)
        Me.txtThamNien.Name = "txtThamNien"
        Me.txtThamNien.Size = New System.Drawing.Size(100, 20)
        Me.txtThamNien.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Thâm niên công tác ="
        '
        'frmBai5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 154)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLuong)
        Me.Controls.Add(Me.btTinhLuong)
        Me.Controls.Add(Me.txtThamNien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBai5"
        Me.Text = "frmBai5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLuong As System.Windows.Forms.TextBox
    Friend WithEvents btTinhLuong As System.Windows.Forms.Button
    Friend WithEvents txtThamNien As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
