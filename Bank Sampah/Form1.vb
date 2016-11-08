Public Class Form1

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.Control And e.KeyCode = Keys.Z Then
        'MessageBox.Show("Oke !!!")
        'End If
        Select Case e.KeyValue
            Case 112 'F1
                Pengambilan.Show()
                Pengambilan.MdiParent = Me
            Case 113 'F2
                example.Show()
                example.MdiParent = Me
            Case Keys.Escape
                If MessageBox.Show("Tutup aplikasi..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    End
                End If
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Tutup aplikasi..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Pengambilan.Show()
        Pengambilan.MdiParent = Me
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Transaksi.Show()
        Transaksi.MdiParent = Me
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Penjualan.Show()
        Penjualan.MdiParent = Me
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MasterNasabah.Show()
        Master_Sampah.MdiParent = Me
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Master_Sampah.Show()
        Master_Sampah.MdiParent = Me
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Stok.Show()
        Stok.MdiParent = Me
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Laporan.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Ganti_Password.Show()
    End Sub
End Class
