Imports System.TimeSpan

Public Class frmTestLinhTinh

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click

        cBieuDoTest.Series(0).Points.Clear()
        cBieuDoTest.Series(1).Points.Clear()

        Dim i As New DateTime
        i = dtTuNgay.Value.Date.Date
        
        While i <= dtDenNgay.Value.Date.Date

            If dtA.Value.Date = dtB.Value.Date And i.Date = dtA.Value.Date Then
                cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtB.Value.Hour - dtA.Value.Hour)
                cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtA.Value.Hour)
            Else
                If dtA.Value.Date < dtTuNgay.Value.Date And dtB.Value.Date > dtDenNgay.Value.Date Then
                    cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                End If

                If (dtA.Value.Date < dtTuNgay.Value.Date And dtB.Value.Date <= dtDenNgay.Value.Date) Or (dtA.Value.Date < dtTuNgay.Value.Date And dtB.Value.Date = dtTuNgay.Value.Date) Then
                    If i.Date = dtB.Value.Date.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtB.Value.Hour)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                    ElseIf i.Date < dtB.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                    Else
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                    End If
                End If

                If (dtA.Value.Date = dtTuNgay.Value.Date And dtB.Value.Date > dtDenNgay.Value.Date) Or (dtA.Value.Date > dtTuNgay.Value.Date And dtA.Value.Date < dtDenNgay.Value.Date And dtB.Value.Date > dtDenNgay.Value.Date) Or (dtA.Value.Date = dtDenNgay.Value.Date And dtB.Value.Date > dtDenNgay.Value.Date) Then
                    If i.Date < dtA.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                    End If
                    If i.Date = dtA.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24 - dtA.Value.Hour)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtA.Value.Hour)
                    End If
                    If i.Date > dtA.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                    End If
                End If

                If (dtA.Value.Date = dtTuNgay.Value.Date And (dtB.Value.Date = dtDenNgay.Value.Date Or dtB.Value.Date = dtTuNgay.Value.Date)) Or (dtA.Value.Date = dtTuNgay.Value.Date And dtB.Value.Date < dtDenNgay.Value.Date And dtB.Value.Date > dtTuNgay.Value.Date) Or (dtA.Value.Date > dtTuNgay.Value.Date And dtB.Value.Date <= dtDenNgay.Value.Date) Or (dtA.Value.Date = dtDenNgay.Value.Date And dtB.Value.Date >= dtDenNgay.Value.Date) Then
                    If i.Date < dtA.Value.Date Or i.Date > dtB.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                    End If
                    If i.Date = dtA.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24 - dtA.Value.Hour)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtA.Value.Hour)
                    End If
                    If i.Date > dtA.Value.Date And i.Date < dtB.Value.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 24)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                    End If
                    If i.Date = dtB.Value.Date.Date Then
                        cBieuDoTest.Series("Bận").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), dtB.Value.Hour)
                        cBieuDoTest.Series("Rảnh").Points.AddXY(i.Date.ToString("dd/MM/yyyy"), 0)
                    End If
                End If
            End If

            
            i = i.AddDays(1)
        End While
    End Sub
End Class