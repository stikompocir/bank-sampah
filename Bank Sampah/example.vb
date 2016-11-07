Imports MySql.Data.MySqlClient
Public Class example
    Dim conn As MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myReader As MySqlDataReader
    Dim WithEvents daftar As koneksi
    Sub Koneksi()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;user id=root; database=bank_sampah"
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("kesalahan koneksi")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            Call Koneksi()
            Dim sql As String
            sql = "select * from sampah where id_sampah = '" & DGV.Rows(e.RowIndex).Cells(0).Value & "'"
            myCommand = New MySqlCommand(sql, conn)
            myReader = myCommand.ExecuteReader
            myReader.Read()
            If myReader.HasRows Then
                DGV.Rows(e.RowIndex).Cells(1).Value = myReader.Item("nama_sampah")
                DGV.Rows(e.RowIndex).Cells(2).Value = myReader.Item("harga_setor")
            End If
        End If
    End Sub

    Private Sub example_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(Microsoft.VisualBasic.Mid(TextBox1.Text, 1, 4))
        'MsgBox(Microsoft.VisualBasic.Right(TxtIdSampah.Text, 4))
        If Button1.Text = "Buat" Then
            'Button1.Text = "Tunggu"
            Otomatis()
        End If

    End Sub

    Sub Otomatis()
        Koneksi()
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
        myCommand = New MySqlCommand("select * from sampah where left(id_sampah, 2)='" & kode & "' order by id_sampah desc", conn)
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
    End Sub

    Sub Otomatis2()
        Koneksi()
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
        TxtIdSampah.Text = urutan
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Lagi" Then
            Button2.Text = "Eunya"
            Otomatis2()
        ElseIf Button2.Text = "Eunya" Then
            Button2.Text = "Lagi"
            TxtIdSampah.Text = " "
            'Otomatis2()
        End If
    End Sub

    Private Sub CmbJenisSampah_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbJenisSampah.SelectedIndexChanged
        Koneksi()
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
    End Sub
End Class