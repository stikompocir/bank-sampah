Public Class Laporan_Master

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CSV.ReportSource = "Laporan Nasabah.rpt"
        CSV.RefreshReport()
        CSV.Location()
    End Sub
End Class