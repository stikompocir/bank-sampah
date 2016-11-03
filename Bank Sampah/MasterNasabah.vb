

Public Class MasterNasabah

    Dim WithEvents daftar As New koneksi
    Dim sql As String = "select * from nasabah order by id_nasabah"

    Private Sub MasterNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftar.NamaDatabase = "bank_sampah"
        daftar.NamaTabel = "nasabah"

        Dim des() As String = {"id_nasabah", "nama_nasabah", "alamat_nasabah", "no_telpon", "status"}
        Dim va() = {TxtIdNsb, TxtNama, TxtAlmt, TxtTelp, TxtStatus}

        Dim deslv() As String = {"id_nasabah", "nama_nasabah", "alamat_nasabah", "no_telpon", "status"}
        Dim size() As Integer = {100, 100, 200, 200, 200}

        daftar.DeskripsiTAbel = des
        daftar.ObjekTabelValue = va
        daftar.ListViewKu.Tambah(Me.lsnsb, deslv, size, sql)

        TxtIdNsb.Enabled = False
        TxtNama.Enabled = False
        TxtAlmt.Enabled = False
        TxtTelp.Enabled = False
        TxtStatus.Enabled = False

    End Sub

    Sub hapus()
        TxtIdNsb.Clear()
        TxtNama.Clear()
        TxtAlmt.Clear()
        TxtTelp.Clear()
        TxtStatus.Clear()
        TxtIdNsb.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        hapus()
        TxtIdNsb.Enabled = True
        TxtNama.Enabled = True
        TxtAlmt.Enabled = True
        TxtTelp.Enabled = True
        TxtStatus.Enabled = True
        TxtIdNsb.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        daftar.Aksi = koneksi.enumAksi.Simpan
        hapus()
    End Sub

    Private Sub daftar_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        daftar.Aksi = koneksi.enumAksi.Hapus
        hapus()
    End Sub

    Private Sub daftar_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Terhapus
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()

    End Sub

    Private Sub lsnsb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsnsb.SelectedIndexChanged
        If lsnsb.SelectedItems.Count = 1 Then
            With lsnsb.SelectedItems(0)
                TxtIdNsb.Text = .SubItems(1).Text
                TxtNama.Text = .SubItems(2).Text
                TxtAlmt.Text = .SubItems(3).Text
                TxtTelp.Text = .SubItems(4).Text
                TxtStatus.Text = .SubItems(5).Text
            End With
        End If
        TxtIdNsb.Enabled = False
        TxtNama.Enabled = True
        TxtAlmt.Enabled = True
        TxtTelp.Enabled = True
        TxtStatus.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        daftar.Aksi = koneksi.enumAksi.Edit
        hapus()

    End Sub

    Private Sub daftar_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Teredit
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub DataSet1BindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSet1BindingSource.CurrentChanged

    End Sub
End Class