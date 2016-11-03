Imports MySql.Data.MySqlClient

Public Class Master_Sampah

    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim WithEvents daftar As New koneksi
    Dim sql As String = "select * from sampah order by id_sampah"

    Private Sub Master_Sampah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftar.NamaDatabase = "bank_sampah"
        daftar.NamaTabel = "sampah"

        Dim des() As String = {"id_nasabah", "id_jenis_sampah", "nama_sampah", "harga_beli", "harga_setor"}
        Dim va() = {TxtIdSampah, CmbJenisSampah, TxtNamaSampah, TxtBeli, TxtSetor}

        Dim deslv() As String = {"id_nasabah", "id_jenis_sampah", "nama_sampah", "harga_beli", "harga_setor"}
        Dim size() As Integer = {100, 100, 200, 200, 200}

        daftar.DeskripsiTAbel = des
        daftar.ObjekTabelValue = va
        daftar.ListViewKu.Tambah(Me.LstSampah, deslv, size, sql)

        TxtIdSampah.Enabled = False
        CmbJenisSampah.Enabled = False
        TxtNamaSampah.Enabled = False
        TxtBeli.Enabled = False
        TxtSetor.Enabled = False
        TxtIdSampah.Focus()

    End Sub

    Sub hapus()
        TxtIdSampah.Clear()
        CmbJenisSampah.Text = ""
        TxtNamaSampah.Clear()
        TxtBeli.Clear()
        TxtSetor.Clear()
        TxtIdSampah.Focus()
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


    Private Sub LstSampah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstSampah.SelectedIndexChanged
        If LstSampah.SelectedItems.Count = 1 Then
            With LstSampah.SelectedItems(0)
                TxtIdSampah.Text = .SubItems(1).Text
                CmbJenisSampah.Text = .SubItems(2).Text
                TxtNamaSampah.Text = .SubItems(3).Text
                TxtBeli.Text = .SubItems(3).Text
                TxtSetor.Text = .SubItems(4).Text
            End With

        End If
        TxtIdSampah.Enabled = False
        CmbJenisSampah.Enabled = True
        TxtNamaSampah.Enabled = True
        TxtBeli.Enabled = True
        TxtSetor.Enabled = True
    End Sub
End Class