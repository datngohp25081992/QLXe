<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestLinhTinh
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cBieuDoTest = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dtTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtA = New System.Windows.Forms.DateTimePicker()
        Me.dtB = New System.Windows.Forms.DateTimePicker()
        Me.btOk = New System.Windows.Forms.Button()
        CType(Me.cBieuDoTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cBieuDoTest
        '
        Me.cBieuDoTest.BorderlineColor = System.Drawing.SystemColors.Window
        Me.cBieuDoTest.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Me.cBieuDoTest.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedUpwardDiagonal
        Me.cBieuDoTest.BorderSkin.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY
        Me.cBieuDoTest.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.cBieuDoTest.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = 45
        ChartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.Name = "ChartArea1"
        Me.cBieuDoTest.ChartAreas.Add(ChartArea1)
        Me.cBieuDoTest.Dock = System.Windows.Forms.DockStyle.Bottom
        Legend1.Name = "Legend1"
        Me.cBieuDoTest.Legends.Add(Legend1)
        Me.cBieuDoTest.Location = New System.Drawing.Point(0, 93)
        Me.cBieuDoTest.Name = "cBieuDoTest"
        Me.cBieuDoTest.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.cBieuDoTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series1.Legend = "Legend1"
        Series1.Name = "Rảnh"
        Series1.YValuesPerPoint = 5
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series2.Legend = "Legend1"
        Series2.Name = "Bận"
        Series2.YValuesPerPoint = 2
        Me.cBieuDoTest.Series.Add(Series1)
        Me.cBieuDoTest.Series.Add(Series2)
        Me.cBieuDoTest.Size = New System.Drawing.Size(678, 379)
        Me.cBieuDoTest.TabIndex = 0
        Me.cBieuDoTest.Text = "Chart1"
        '
        'dtTuNgay
        '
        Me.dtTuNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTuNgay.Location = New System.Drawing.Point(140, 12)
        Me.dtTuNgay.Name = "dtTuNgay"
        Me.dtTuNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtTuNgay.TabIndex = 1
        '
        'dtDenNgay
        '
        Me.dtDenNgay.CustomFormat = "dd/MM/yyyy"
        Me.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDenNgay.Location = New System.Drawing.Point(437, 12)
        Me.dtDenNgay.Name = "dtDenNgay"
        Me.dtDenNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtDenNgay.TabIndex = 2
        '
        'dtA
        '
        Me.dtA.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtA.Location = New System.Drawing.Point(49, 47)
        Me.dtA.Name = "dtA"
        Me.dtA.Size = New System.Drawing.Size(200, 20)
        Me.dtA.TabIndex = 3
        '
        'dtB
        '
        Me.dtB.CustomFormat = "dd/MM/yyyy H:mm:ss"
        Me.dtB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtB.Location = New System.Drawing.Point(380, 47)
        Me.dtB.Name = "dtB"
        Me.dtB.Size = New System.Drawing.Size(200, 20)
        Me.dtB.TabIndex = 4
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(277, 44)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(75, 23)
        Me.btOk.TabIndex = 5
        Me.btOk.Text = "&Ok"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'frmTestLinhTinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 472)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.dtB)
        Me.Controls.Add(Me.dtA)
        Me.Controls.Add(Me.dtDenNgay)
        Me.Controls.Add(Me.dtTuNgay)
        Me.Controls.Add(Me.cBieuDoTest)
        Me.Name = "frmTestLinhTinh"
        Me.Text = "frmTestLinhTinh"
        CType(Me.cBieuDoTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cBieuDoTest As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dtTuNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDenNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtB As System.Windows.Forms.DateTimePicker
    Friend WithEvents btOk As System.Windows.Forms.Button
End Class
