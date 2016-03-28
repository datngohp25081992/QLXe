<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuaKmDongHo
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
        Me.txtSoCu = New System.Windows.Forms.TextBox()
        Me.txtSoMoi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số KM Cũ:"
        '
        'txtSoCu
        '
        Me.txtSoCu.Enabled = False
        Me.txtSoCu.Location = New System.Drawing.Point(76, 21)
        Me.txtSoCu.Name = "txtSoCu"
        Me.txtSoCu.Size = New System.Drawing.Size(140, 20)
        Me.txtSoCu.TabIndex = 1
        '
        'txtSoMoi
        '
        Me.txtSoMoi.Location = New System.Drawing.Point(76, 61)
        Me.txtSoMoi.Name = "txtSoMoi"
        Me.txtSoMoi.Size = New System.Drawing.Size(140, 20)
        Me.txtSoMoi.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số KM Mới:"
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(90, 110)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(75, 23)
        Me.btOk.TabIndex = 4
        Me.btOk.Text = "&Ok"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'frmSuaKmDongHo
        '
        Me.AcceptButton = Me.btOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 148)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.txtSoMoi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSoCu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSuaKmDongHo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSuaKmDongHo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoCu As System.Windows.Forms.TextBox
    Friend WithEvents txtSoMoi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btOk As System.Windows.Forms.Button
End Class
