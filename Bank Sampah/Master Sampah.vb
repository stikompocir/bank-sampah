Imports MySql.Data.MySqlClient

Public Class Master_Sampah

    Dim conn As MySqlConnection
    Dim myCommand As MySqlCommand
    Dim myReader As MySqlDataReader
    Dim WithEvents daftar As New koneksi
    Dim sql As String = "select * from sampah order by id_sampah"

    Sub KoneksiDATA()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub Master_Sampah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftar.NamaDatabase = "bank_sampah"
        daftar.NamaTabel = "sampah"
        Dim SETOKSAMPAH As Integer = 0

        Dim des() As String = {"id_sampah", "nama_sampah", "harga_beli", "harga_setor"}
        Dim va() = {TxtIdSampah, TxtNamaSampah, TxtBeli, TxtSetor, SETOKSAMPAH}

        Dim deslv() As String = {"id_sampah", "nama_sampah", "harga_beli", "harga_setor"}
        Dim size() As Integer = {100, 200, 200, 200}
        Dim upper As String = TxtNamaSampah.Text
        daftar.DeskripsiTAbel = des
        daftar.ObjekTabelValue = va
        daftar.ListViewKu.Tambah(Me.LstSampah, deslv, size, sql)

        TxtIdSampah.Enabled = False
        CmbJenisSampah.Focus()
        'UCase(TxtNamaSampah.Text)
        'TxtBeli.Enabled = False
        'TxtSetor.Enabled = False
        'TxtIdSampah.Focus()
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

    Private Sub CmbJenisSampah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbJenisSampah.SelectedIndexChanged
        KoneksiDATA()
        Dim kode As String
        If CmbJenisSampah.Text = "Kertas" Then
            kode = "BS1"
        ElseIf CmbJenisSampah.Text = "Plastik" Then
            kode = "BS2"
        ElseIf CmbJenisSampah.Text = "Kaleng" Then
            kode = "BS3"
        ElseIf CmbJenisSampah.Text = "Alumunium" Then
            kode = "BS4"
        ElseIf CmbJenisSampah.Text = "Besi" Then
            kode = "BS5"
        End If
        myCommand = New MySqlCommand("select * from sampah where left(id_sampah, 3)='" & kode & "' order by id_sampah desc", conn)
        myReader = myCommand.ExecuteReader
        myReader.Read()
        Dim urutan As String
        Dim hitung As Long
        If Not myReader.HasRows Then
            urutan = kode + "01"
        Else
            hitung = Microsoft.VisualBasic.Right(myReader.GetString(0), 2) + 1
            urutan = kode + Microsoft.VisualBasic.Right("00" & hitung, 2)
        End If
        TxtIdSampah.Text = urutan
        TxtIdSampah.Enabled = False
        TxtNamaSampah.Focus()
    End Sub

    Private Sub TxtNamaSampah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TxtSetor.Focus()
        End If
    End Sub
End Class