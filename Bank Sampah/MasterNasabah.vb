Imports MySql.Data.MySqlClient

Public Class MasterNasabah

    Dim conn As MySqlConnection
    Dim myCommand As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim WithEvents daftar As New koneksi
    Dim sql As String = "select * from nasabah order by id_nasabah"

    Sub KoneksiDATA()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub MasterNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftar.NamaDatabase = "bank_sampah"
        daftar.NamaTabel = "nasabah"

        Dim des() As String = {"id_nasabah", "nama_nasabah", "alamat_nasabah", "saldo", "no_telpon", "status"}
        Dim va() = {TxtIdNsb, TxtNama, TxtAlmt, TxtTelp, TxtStatus}

        Dim deslv() As String = {"id_nasabah", "nama_nasabah", "alamat_nasabah", "saldo", "no_telpon", "status"}
        Dim size() As Integer = {100, 100, 200, 200, 200, 200}

        daftar.DeskripsiTAbel = des
        daftar.ObjekTabelValue = va
        daftar.ListViewKu.Tambah(Me.lsnsb, deslv, size, sql)

        TxtIdNsb.Enabled = False
        TxtNama.Enabled = False
        TxtAlmt.Enabled = False
        TxtTelp.Enabled = False
        TxtStatus.Enabled = False


    End Sub
    Sub Otomatis()
        KoneksiDATA()
        myCommand = New MySqlCommand("select iD_NASABAH from nasabah where id_nasabah in(select max(id_nasabah) from nasabah) order by id_nasabah desc", conn)
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Dim urutan As String
        Dim hitung As Long
        If Not myReader.HasRows Then
            urutan = "NS" + "0001"
        Else
            hitung = Microsoft.VisualBasic.Right(myReader.GetString(0), 4) + 1
            urutan = "NS" + Microsoft.VisualBasic.Right("0000" & hitung, 4)
        End If
        TxtIdNsb.Text = urutan
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
        TxtIdNsb.Enabled = False
        TxtNama.Enabled = True
        TxtAlmt.Enabled = True
        TxtTelp.Enabled = True
        TxtStatus.Enabled = True
        TxtIdNsb.Focus()
        Otomatis()
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