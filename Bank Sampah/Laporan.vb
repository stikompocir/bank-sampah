Public Class Laporan


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CRV.SelectionFormula = "{setor_nasabah1.tanggal} in date ('" & DTP.Text & "') to date ('" & DTP2.Text & "')"
        CRV.ReportSource = Laporan_Periodik11
        CRV.RefreshReport()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        CRV.SelectionFormula = "Totext({setor_nasabah.tanggal}) = '" & DTP3.Text & "'"
        CRV.ReportSource = Laporan_Harian1
        CRV.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.ReportSource = CrystalReport11
        CRV.RefreshReport()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CRV.ReportSource = CrystalReport21
        CRV.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CRV.ReportSource = PengambilanTunai1
        CRV.RefreshReport()
    End Sub

    Private Sub CRV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRV.Load
        CRV.RefreshReport()
    End Sub
End Class